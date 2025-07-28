using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService
{
    // Status poruke koju servis vraća
    [DataContract]
    public enum MessageStatus
    {
        [EnumMember] Ok,
        [EnumMember] Error
    }

    // Mogući razlozi greške pri registraciji
    [DataContract]
    public enum MessageError
    {
        [EnumMember] AlreadyRegistred,
        [EnumMember] TooManyRegistred
    }

    // DTO koji vraćamo klijentu prilikom registracije
    [DataContract]
    public class Message
    {
        [DataMember] public MessageStatus Status;
        [DataMember] public MessageError? Error;
    }

    // Stanja radnika
    [DataContract]
    public enum WorkerState
    {
        [EnumMember] Standby,  // u pripravnosti
        [EnumMember] Active,   // trenutno radi
        [EnumMember] Dead      // mrtav / neodgovara
    }

    // Interni podaci o radniku na serveru
    [DataContract]
    public class WorkerInfo
    {
        [DataMember] public WorkerState State;
        [DataMember] public DateTime LastHeartbeat;
        public ICallback Callback { get; set; }  // za callback pozive prema klijentu
    }

    // Callback interfejs koji klijent implementira
    public interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void ChangeWorkerState(WorkerState newState);  // obavesti o promeni stanja

        [OperationContract(IsOneWay = true)]
        void ShutdownWorker();  // naloži klijentu gašenje

        [OperationContract(IsOneWay = true)]
        void UpdateActiveWorkers(int[] activeIds);  // pošalji novu listu aktivnih
    }

    // Glavni servisni interfejs
    [ServiceContract(CallbackContract = typeof(ICallback), SessionMode = SessionMode.Required)]
    public interface IService
    {
        [OperationContract]
        Message Register(int registrationWorkerId);  // registruj radnika

        [OperationContract]
        void SendHeartbeat(int workerId);            // heartbeat od klijenta
    }
}
