using System;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace ClientApp.ServiceProxy
{
    // DataContracts
    [DataContract]
    public enum MessageStatus
    {
        [EnumMember] Ok,
        [EnumMember] Error
    }

    [DataContract]
    public enum MessageError
    {
        [EnumMember] AlreadyRegistred,
        [EnumMember] TooManyRegistred
    }

    [DataContract]
    public class Message
    {
        [DataMember] public MessageStatus Status;
        [DataMember] public MessageError? Error;
    }

    [DataContract]
    public enum WorkerState
    {
        [EnumMember] Standby,
        [EnumMember] Active,
        [EnumMember] Dead
    }

    // Callback contract
    public interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void ChangeWorkerState(WorkerState newState);

        [OperationContract(IsOneWay = true)]
        void ShutdownWorker();

        [OperationContract(IsOneWay = true)]
        void UpdateActiveWorkers(int[] activeIds);
    }

    // Service contract
    [ServiceContract(CallbackContract = typeof(ICallback), SessionMode = SessionMode.Required)]
    public interface IService
    {
        [OperationContract]
        Message Register(int registrationWorkerId);

        [OperationContract]
        void SendHeartbeat(int workerId);
    }

    // Factory za kreiranje duplex proxy-ja
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
