using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PubSubApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PubSub" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PubSub.svc or PubSub.svc.cs at the Solution Explorer and start debugging.
    
    public class PubSub : IPub, ISub
    {
        delegate void MessageDeleagte(string message);
        static event MessageDeleagte MessageArrivedEvent;

        public static Dictionary<string, string> Users = new Dictionary<string, string>();
        public void InitSub(string username, string password)
        {
            if(!Users.ContainsKey(username))
            {
                Users.Add(username, password);
                MessageArrivedEvent += OperationContext.Current.GetCallbackChannel<ICallback>().MessageArrived;
            }
        }
        public void SendMessage(string message)
        {
           MessageArrivedEvent?.Invoke($"Message {message} arrived at {DateTime.Now}");
        }
    }
}
