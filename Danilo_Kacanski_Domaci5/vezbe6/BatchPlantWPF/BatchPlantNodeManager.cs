using BatchPlant;
using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BatchPlantWPF
{
    internal class BatchPlantNodeManager : CustomNodeManager2
    {
        public BatchPlantNodeManager(IServerInternal server, ApplicationConfiguration configuration) 
        :
        base(server, configuration)             // konstruktor bazne (CustomNodeManager2) klase
        {
            SystemContext.NodeIdFactory = this;

            // postavlja prostor imena za staticki i dinamicki kreirane nodove
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = BatchPlant.Namespaces.BatchPlant;
            namespaceUrls[1] = BatchPlant.Namespaces.BatchPlant + "/Instance";
            SetNamespaces(namespaceUrls);           // dodaje prostore imena u NodeManager

            // dobija konfiguraciju
            m_configuration = configuration.ParseExtension<BatchPlantServerConfiguration>();

            // koristi podrazumevanu konfiguraciju ukoliko ona ne postoji
            if (m_configuration == null)
            {
                m_configuration = new BatchPlantServerConfiguration();
            }
        }
        // ucitava unapred definisane cvorove sa odredjene putanje, dobijenih pozivanjem skripte
        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "..\\..\\BatchPlant.PredefinedNodes.uanodes",
                typeof(BatchPlantNodeManager).GetTypeInfo().Assembly,
                true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                // nalazi Batch Plant 1 cvor koji je kreiran prilikom ucitavanja svih cvorova
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(BatchPlant.Objects.BatchPlant1, NamespaceIndexes[0]), typeof(BaseObjectState));

                // konvertuje netipiziran cvor u tipiziran radi lakse manipulacije
                m_batchPlant1 = new BatchPlantState(null);
                m_batchPlant1.Create(SystemContext, passiveNode);

                // dodavanje cvorova u adresni prostor
                AddPredefinedNode(SystemContext, m_batchPlant1);

                // definisanje koje metode korisnik moze da pozove
                m_batchPlant1.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
                m_batchPlant1.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);
                m_batchPlant1.TurnOnPump.OnCallMethod = new GenericMethodCalledEventHandler(OnTurnOnPump);
                m_batchPlant1.TurnOffPump.OnCallMethod = new GenericMethodCalledEventHandler(OnTurnOffPump);
            }
        }

        private ServiceResult OnStartProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            // TODO : prilikom pokretanja procesa upaliti pumpe/motore, postaviti neke vrednosti senzora itd.
            m_batchPlant1.Mixer.MixerMotor.Speed.Value = 50;

            m_batchPlant1.Pump.PumpMotor.Speed.Value = 50;
            m_batchPlant1.Pump.PumpMotor.State.Value = false;
            m_batchPlant1.Pump.PumpTemperatureSensor.Temperature.Value = 20;
            m_batchPlant1.Pump.PumpTemperatureSensor.Units.Value = "F";
            // Ažuriranje vrednosti sa notifikacijom
            m_batchPlant1.Mixer.MixerMotor.Speed.Timestamp = DateTime.UtcNow;
            m_batchPlant1.Mixer.MixerMotor.Speed.StatusCode = StatusCodes.Good;
            m_batchPlant1.Mixer.MixerMotor.Speed.ClearChangeMasks(SystemContext, true);

            m_batchPlant1.Pump.PumpMotor.Speed.Timestamp = DateTime.UtcNow;
            m_batchPlant1.Pump.PumpMotor.Speed.StatusCode = StatusCodes.Good;
            m_batchPlant1.Pump.PumpMotor.Speed.ClearChangeMasks(SystemContext, true);

            m_batchPlant1.Pump.PumpMotor.State.Timestamp = DateTime.UtcNow;
            m_batchPlant1.Pump.PumpMotor.State.StatusCode = StatusCodes.Good;
            m_batchPlant1.Pump.PumpMotor.State.ClearChangeMasks(SystemContext, true);

            m_batchPlant1.Pump.PumpTemperatureSensor.Temperature.Timestamp = DateTime.UtcNow;
            m_batchPlant1.Pump.PumpTemperatureSensor.Temperature.StatusCode = StatusCodes.Good;
            m_batchPlant1.Pump.PumpTemperatureSensor.Temperature.ClearChangeMasks(SystemContext, true);


            return ServiceResult.Good;
        }

        private ServiceResult OnTurnOnPump(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            m_batchPlant1.Pump.PumpMotor.State.Value = true;

            m_batchPlant1.Pump.PumpMotor.State.Timestamp = DateTime.UtcNow;
            m_batchPlant1.Pump.PumpMotor.State.StatusCode = StatusCodes.Good;
            m_batchPlant1.Pump.PumpMotor.State.ClearChangeMasks(SystemContext, true);
            return ServiceResult.Good;
        }

        private ServiceResult OnTurnOffPump(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            m_batchPlant1.Pump.PumpMotor.State.Value = false;

            m_batchPlant1.Pump.PumpMotor.State.Timestamp = DateTime.UtcNow;
            m_batchPlant1.Pump.PumpMotor.State.StatusCode = StatusCodes.Good;
            m_batchPlant1.Pump.PumpMotor.State.ClearChangeMasks(SystemContext, true);
            return ServiceResult.Good;
        }

        private ServiceResult OnStopProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            // TODO : prilikom zaustavljanja sve izgastiti i postaviti analogne vrednosti na -1
            m_batchPlant1.Mixer.MixerMotor.Speed.Value = -1;

            m_batchPlant1.Pump.PumpMotor.Speed.Value = -1;
            m_batchPlant1.Pump.PumpMotor.State.Value = false;
            m_batchPlant1.Pump.PumpTemperatureSensor.Temperature.Value = -1;

            // Ažuriranje vrednosti sa notifikacijom
            m_batchPlant1.Mixer.MixerMotor.Speed.Timestamp = DateTime.UtcNow;
            m_batchPlant1.Mixer.MixerMotor.Speed.StatusCode = StatusCodes.Good;
            m_batchPlant1.Mixer.MixerMotor.Speed.ClearChangeMasks(SystemContext, true);

            m_batchPlant1.Pump.PumpMotor.Speed.Timestamp = DateTime.UtcNow;
            m_batchPlant1.Pump.PumpMotor.Speed.StatusCode = StatusCodes.Good;
            m_batchPlant1.Pump.PumpMotor.Speed.ClearChangeMasks(SystemContext, true);

            m_batchPlant1.Pump.PumpMotor.State.Timestamp = DateTime.UtcNow;
            m_batchPlant1.Pump.PumpMotor.State.StatusCode = StatusCodes.Good;
            m_batchPlant1.Pump.PumpMotor.State.ClearChangeMasks(SystemContext, true);

            m_batchPlant1.Pump.PumpTemperatureSensor.Temperature.Timestamp = DateTime.UtcNow;
            m_batchPlant1.Pump.PumpTemperatureSensor.Temperature.StatusCode = StatusCodes.Good;
            m_batchPlant1.Pump.PumpTemperatureSensor.Temperature.ClearChangeMasks(SystemContext, true);


            return ServiceResult.Good;
        }

        private BatchPlantServerConfiguration m_configuration;
        private static BatchPlantState m_batchPlant1;           // preko ovog cvora klijenti komuniciraju sa serverom

    }
}

