using System;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace ClientApp
{
    // status odgovora sa servisa
    [DataContract]
    public enum MessageStatus
    {
        [EnumMember] Ok,
        [EnumMember] Error
    }

    // vrsta greške prilikom registracije
    [DataContract]
    public enum MessageError
    {
        [EnumMember] AlreadyRegistred,
        [EnumMember] TooManyRegistred
    }

    // omot za poruku servisa
    [DataContract]
    public class Message
    {
        [DataMember] public MessageStatus Status;
        [DataMember] public MessageError? Error;
    }

    // stanje radnika na servisu
    [DataContract]
    public enum WorkerState
    {
        [EnumMember] Standby,
        [EnumMember] Active,
        [EnumMember] Dead
    }

    // callback metode koje servis poziva na klijentu
    public interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void ChangeWorkerState(WorkerState newState);

        [OperationContract(IsOneWay = true)]
        void ShutdownWorker();

        [OperationContract(IsOneWay = true)]
        void UpdateActiveWorkers(int[] activeIds);
    }

    // definicija WCF servisa
    [ServiceContract(CallbackContract = typeof(ICallback), SessionMode = SessionMode.Required)]
    public interface IService
    {
        [OperationContract]
        Message Register(int registrationWorkerId);

        [OperationContract]
        void SendHeartbeat(int workerId);
    }

    // kreira duplex proxy za komunikaciju sa servisom
    public static class ServiceProxyFactory
    {
        private static readonly WSDualHttpBinding _binding = new WSDualHttpBinding(WSDualHttpSecurityMode.None)
        {
            OpenTimeout = TimeSpan.FromSeconds(10),
            ReceiveTimeout = TimeSpan.FromMinutes(5)
        };

        public static IService CreateProxy(ICallback callbackInstance)
        {
            var context = new InstanceContext(callbackInstance);
            var endpoint = new EndpointAddress("http://localhost:8080/Service/");
            var factory = new DuplexChannelFactory<IService>(context, _binding, endpoint);
            var channel = factory.CreateChannel();
            ((ICommunicationObject)channel).Open();
            return channel;
        }
    }
}
