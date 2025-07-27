using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using static System.Net.Mime.MediaTypeNames;

// GLAVNI KOMETAR

//  Sistem radi kao distribuirani PubSub koji koristi WCF za komunikciju izmedju klijenta i servera.  
//  Klijenti se prijave na Loto unesu odredjenje podatke, a zatim su obavesteni o rezultatima izvlacenja
//  putem servera koji upravlja svim prijavama i rezultatima.
//  Server kontinualno izvlaci brojeve i obavestava i vodi racuna o trenutnim stanjima i rangu igraca.
//  Pomocu ovoga je moguca interakcija izmedju klijenata i servera u realnom vremenu, cineci ovaj sistem efikasnim.


namespace Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class Service : IPublisher, ISubscriber
    {
        public delegate void OnNotifiedDelegate(int FirstNumber, int SecondNumber, Dictionary<int, Player> OrderedPlayers);
        private static readonly ConcurrentDictionary<int, Player> Players = new ConcurrentDictionary<int, Player>();
        private static readonly ConcurrentDictionary<ICallback, OnNotifiedDelegate> Callbacks = new ConcurrentDictionary<ICallback, OnNotifiedDelegate>();

        // javljenja brojeva svim prijavljenjim igracima
        public void Publish(int FirstNumber, int SecondNumber)
        {
            if (Players.Any())
            {
                CalculateBalances(FirstNumber, SecondNumber);
                var orderedPlayers = OrderPlayers();
                CallbackPlayers(FirstNumber, SecondNumber, orderedPlayers);
            }
        }

        // registacija novog 
        public void InitPlayer(Player player)
        {
            bool playerAdded = false;
            while (!playerAdded)
            {
                if (Players.ContainsKey(player.Credentials.Id))
                {   
                    // ako vec postoji prekida se   
                    break;
                 
                }
                else if (Players.TryAdd(player.Credentials.Id, player))
                {
                    var callback = OperationContext.Current.GetCallbackChannel<ICallback>();
                    var notifyDelegate = new OnNotifiedDelegate((first, second, ordered) => callback.OnNotified(first, second, ordered));
                    Callbacks.TryAdd(callback, notifyDelegate);
                    OperationContext.Current.Channel.Closed += (sender, args) => RemovePlayer(player.Credentials.Id, callback);
                    playerAdded = true;
                }
            }
        }


        private void RemovePlayer(int playerId, ICallback callback)
        {
            if (Players.TryRemove(playerId, out var _))
            {
                Callbacks.TryRemove(callback, out var _);
            }
        }

        private void CalculateBalances(int FirstNumber, int SecondNumber)
        {
            var rewards = new Dictionary<int, int>
            {
                {2, 5},  // Dodaj 5 puta u slucaju 2
                {1, 1},  // Dodaj ulozeno u slucaju 1
                {0, -1}  // Odnuzmi ulozeno u slucaju 0
            };

            foreach (var player in Players.Values)
            {
                int matches = new[] { FirstNumber, SecondNumber }
                                .Intersect(new[] { player.Ticket.FirstNumber, player.Ticket.SecondNumber })
                                .Count();

                // Primeni faktor u odnosu na slucaj
                if (rewards.TryGetValue(matches, out var factor))
                {
                    player.CurrentBalance += factor * player.Ticket.InvestedMoney;
                }
            }
        }

        private int CountMatchingNumbers(Player player, int first, int second)
        {
            // skup izvucenih brojeva i provera kolko igrac igrac ima
            var drawnNumbers = new HashSet<int> { first, second };
            int matches = 0;
            if (drawnNumbers.Contains(player.Ticket.FirstNumber))
                matches++;
            if (drawnNumbers.Contains(player.Ticket.SecondNumber))
                matches++;

            return matches;
        }

        private Dictionary<int, Player> OrderPlayers()  // sortiranje
        {
            return Players.OrderByDescending(kvp => kvp.Value.CurrentBalance).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }

        private void CallbackPlayers(int FirstNumber, int SecondNumber, Dictionary<int, Player> OrderedPlayers)
        {
            foreach (var callback in Callbacks.Values)
            {
                callback(FirstNumber, SecondNumber, OrderedPlayers);
            }
        }
    }
}
