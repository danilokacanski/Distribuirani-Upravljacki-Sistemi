/* ========================================================================
 * Copyright (c) 2005-2024 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace BatchPlant
{
    #region GenericSensorState Class
    #if (!OPCUA_EXCLUDE_GenericSensorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericSensorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericSensorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.GenericSensorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGQAA" +
           "AEdlbmVyaWNTZW5zb3JUeXBlSW5zdGFuY2UBAQEAAQEBAAEAAAD/////AgAAABVgiQoCAAAAAQAGAAAA" +
           "T3V0cHV0AQECAAAvAQBACQIAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEG" +
           "AAAuAEQGAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBCAAALgBECAAAAAAM" +
           "/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Units
        {
            get
            {
                return m_units;
            }

            set
            {
                if (!Object.ReferenceEquals(m_units, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_units = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_output != null)
            {
                children.Add(m_output);
            }

            if (m_units != null)
            {
                children.Add(m_units);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }

                case BatchPlant.BrowseNames.Units:
                {
                    if (createOrReplace)
                    {
                        if (Units == null)
                        {
                            if (replacement == null)
                            {
                                Units = new PropertyState<string>(this);
                            }
                            else
                            {
                                Units = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Units;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_output;
        private PropertyState<string> m_units;
        #endregion
    }
    #endif
    #endregion

    #region GenericActuatorState Class
    #if (!OPCUA_EXCLUDE_GenericActuatorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericActuatorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericActuatorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.GenericActuatorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGwAA" +
           "AEdlbmVyaWNBY3R1YXRvclR5cGVJbnN0YW5jZQEBCQABAQkACQAAAP////8CAAAAFWCJCgIAAAABAAUA" +
           "AABJbnB1dAEBCgAALwEAQAkKAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "DgAALgBEDgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQEQAAAvAQBACRAA" +
           "AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEUAAAuAEQUAAAAAQB0A/////8B" +
           "Af////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Input
        {
            get
            {
                return m_input;
            }

            set
            {
                if (!Object.ReferenceEquals(m_input, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_input = value;
            }
        }

        /// <remarks />
        public AnalogItemState<double> Output
        {
            get
            {
                return m_output;
            }

            set
            {
                if (!Object.ReferenceEquals(m_output, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_output = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_input != null)
            {
                children.Add(m_input);
            }

            if (m_output != null)
            {
                children.Add(m_output);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Input:
                {
                    if (createOrReplace)
                    {
                        if (Input == null)
                        {
                            if (replacement == null)
                            {
                                Input = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Input = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Input;
                    break;
                }

                case BatchPlant.BrowseNames.Output:
                {
                    if (createOrReplace)
                    {
                        if (Output == null)
                        {
                            if (replacement == null)
                            {
                                Output = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Output = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Output;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_input;
        private AnalogItemState<double> m_output;
        #endregion
    }
    #endif
    #endregion

    #region GenericMotorState Class
    #if (!OPCUA_EXCLUDE_GenericMotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericMotorState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public GenericMotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.GenericMotorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGAAA" +
           "AEdlbmVyaWNNb3RvclR5cGVJbnN0YW5jZQEBFgABARYAFgAAAP////8BAAAAFWCJCgIAAAABAAUAAABT" +
           "cGVlZAEBFwAALwEAQAkXAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBGwAA" +
           "LgBEGwAAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Speed
        {
            get
            {
                return m_speed;
            }

            set
            {
                if (!Object.ReferenceEquals(m_speed, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_speed = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_speed != null)
            {
                children.Add(m_speed);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Speed:
                {
                    if (createOrReplace)
                    {
                        if (Speed == null)
                        {
                            if (replacement == null)
                            {
                                Speed = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Speed = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Speed;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_speed;
        #endregion
    }
    #endif
    #endregion

    #region LevelIndicatorState Class
    #if (!OPCUA_EXCLUDE_LevelIndicatorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LevelIndicatorState : GenericSensorState
    {
        #region Constructors
        /// <remarks />
        public LevelIndicatorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.LevelIndicatorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGgAA" +
           "AExldmVsSW5kaWNhdG9yVHlwZUluc3RhbmNlAQEdAAEBHQAdAAAA/////wIAAAAVYIkKAgAAAAEABgAA" +
           "AE91dHB1dAIBAEFCDwAALwEAQAlBQg8AAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQIBAEVCDwAALgBERUIPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMCAQBHQg8A" +
           "AC4AREdCDwAADP////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LoadcellTransmitterState Class
    #if (!OPCUA_EXCLUDE_LoadcellTransmitterState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LoadcellTransmitterState : GenericSensorState
    {
        #region Constructors
        /// <remarks />
        public LoadcellTransmitterState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.LoadcellTransmitterType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAHwAA" +
           "AExvYWRjZWxsVHJhbnNtaXR0ZXJUeXBlSW5zdGFuY2UBAR4AAQEeAB4AAAD/////AwAAABVgiQoCAAAA" +
           "AQAGAAAAT3V0cHV0AgEASEIPAAAvAQBACUhCDwAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAgEATEIPAAAuAERMQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwIB" +
           "AE5CDwAALgBETkIPAAAM/////wMD/////wAAAAAVYIkKAgAAAAEAEQAAAEV4Y2l0YXRpb25Wb2x0YWdl" +
           "AQEfAAAvAQBACR8AAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEjAAAuAEQj" +
           "AAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> ExcitationVoltage
        {
            get
            {
                return m_excitationVoltage;
            }

            set
            {
                if (!Object.ReferenceEquals(m_excitationVoltage, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_excitationVoltage = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_excitationVoltage != null)
            {
                children.Add(m_excitationVoltage);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.ExcitationVoltage:
                {
                    if (createOrReplace)
                    {
                        if (ExcitationVoltage == null)
                        {
                            if (replacement == null)
                            {
                                ExcitationVoltage = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                ExcitationVoltage = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = ExcitationVoltage;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_excitationVoltage;
        #endregion
    }
    #endif
    #endregion

    #region TemperatureState Class
    #if (!OPCUA_EXCLUDE_TemperatureState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureState : GenericSensorState
    {
        #region Constructors
        /// <remarks />
        public TemperatureState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.TemperatureType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAFwAA" +
           "AFRlbXBlcmF0dXJlVHlwZUluc3RhbmNlAQHtAQEB7QHtAQAA/////wMAAAAVYIkKAgAAAAEABgAAAE91" +
           "dHB1dAIBAE9CDwAALwEAQAlPQg8AAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQIB" +
           "AFNCDwAALgBEU0IPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMCAQBVQg8AAC4A" +
           "RFVCDwAADP////8DA/////8AAAAAFWCJCgIAAAABAAsAAABUZW1wZXJhdHVyZQEB7gEALwEAQAnuAQAA" +
           "AAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB8gEALgBE8gEAAAEAdAP/////AQH/" +
           "////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> Temperature
        {
            get
            {
                return m_temperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temperature = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_temperature != null)
            {
                children.Add(m_temperature);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Temperature:
                {
                    if (createOrReplace)
                    {
                        if (Temperature == null)
                        {
                            if (replacement == null)
                            {
                                Temperature = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Temperature = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Temperature;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private AnalogItemState<double> m_temperature;
        #endregion
    }
    #endif
    #endregion

    #region ValveState Class
    #if (!OPCUA_EXCLUDE_ValveState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ValveState : GenericActuatorState
    {
        #region Constructors
        /// <remarks />
        public ValveState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.ValveType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AFZhbHZlVHlwZUluc3RhbmNlAQElAAEBJQAlAAAA/////wIAAAAVYIkKAgAAAAEABQAAAElucHV0AgEA" +
           "VkIPAAAvAQBACVZCDwAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAgEAWkIPAAAu" +
           "AERaQg8AAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAYAAABPdXRwdXQCAQBcQg8AAC8BAEAJXEIP" +
           "AAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UCAQBgQg8AAC4ARGBCDwABAHQD////" +
           "/wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MixerMotorState Class
    #if (!OPCUA_EXCLUDE_MixerMotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MixerMotorState : GenericMotorState
    {
        #region Constructors
        /// <remarks />
        public MixerMotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.MixerMotorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAFgAA" +
           "AE1peGVyTW90b3JUeXBlSW5zdGFuY2UBASYAAQEmACYAAAD/////AQAAABVgiQoCAAAAAQAFAAAAU3Bl" +
           "ZWQCAQBiQg8AAC8BAEAJYkIPAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UCAQBm" +
           "Qg8AAC4ARGZCDwABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region ConveyorMotorState Class
    #if (!OPCUA_EXCLUDE_ConveyorMotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConveyorMotorState : GenericMotorState
    {
        #region Constructors
        /// <remarks />
        public ConveyorMotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.ConveyorMotorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGQAA" +
           "AENvbnZleW9yTW90b3JUeXBlSW5zdGFuY2UBAScAAQEnACcAAAD/////AQAAABVgiQoCAAAAAQAFAAAA" +
           "U3BlZWQCAQBoQg8AAC8BAEAJaEIPAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UC" +
           "AQBsQg8AAC4ARGxCDwABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region PumpMotorState Class
    #if (!OPCUA_EXCLUDE_PumpMotorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PumpMotorState : GenericMotorState
    {
        #region Constructors
        /// <remarks />
        public PumpMotorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.PumpMotorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAFQAA" +
           "AFB1bXBNb3RvclR5cGVJbnN0YW5jZQEBoAEBAaABoAEAAP////8CAAAAFWCJCgIAAAABAAUAAABTcGVl" +
           "ZAIBAG5CDwAALwEAQAluQg8AAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQIBAHJC" +
           "DwAALgBEckIPAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAU3RhdGUBAR4CAC8APx4CAAAA" +
           "Af////8DA/////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseDataVariableState<bool> State
        {
            get
            {
                return m_state;
            }

            set
            {
                if (!Object.ReferenceEquals(m_state, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_state = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_state != null)
            {
                children.Add(m_state);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.State:
                {
                    if (createOrReplace)
                    {
                        if (State == null)
                        {
                            if (replacement == null)
                            {
                                State = new BaseDataVariableState<bool>(this);
                            }
                            else
                            {
                                State = (BaseDataVariableState<bool>)replacement;
                            }
                        }
                    }

                    instance = State;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseDataVariableState<bool> m_state;
        #endregion
    }
    #endif
    #endregion

    #region Silo1State Class
    #if (!OPCUA_EXCLUDE_Silo1State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Silo1State : FolderState
    {
        #region Constructors
        /// <remarks />
        public Silo1State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.Silo1Type, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AFNpbG8xVHlwZUluc3RhbmNlAQEoAAEBKAAoAAAAAQAAAAAwAAEBKQACAAAAhGDACgEAAAATAAAAU2ls" +
           "bzFMZXZlbEluZGljYXRvcgEABQAAAExJMDAxAQEpAAAvAQEdACkAAAABAQAAAAAwAQEBKAACAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBASoAAC8BAEAJKgAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAS4AAC4ARC4AAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQEw" +
           "AAAuAEQwAAAAAAz/////AwP/////AAAAAIRgwAoBAAAAEwAAAFNpbG8xRGlzY2hhcmdlVmFsdmUBAAgA" +
           "AABWYWx2ZTAwMQEBMQAALwEBJQAxAAAAAf////8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBMgAALwEA" +
           "QAkyAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBNgAALgBENgAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQE4AAAvAQBACTgAAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQE8AAAuAEQ8AAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LevelIndicatorState Silo1LevelIndicator
        {
            get
            {
                return m_silo1LevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo1LevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo1LevelIndicator = value;
            }
        }

        /// <remarks />
        public ValveState Silo1DischargeValve
        {
            get
            {
                return m_silo1DischargeValve;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo1DischargeValve, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo1DischargeValve = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_silo1LevelIndicator != null)
            {
                children.Add(m_silo1LevelIndicator);
            }

            if (m_silo1DischargeValve != null)
            {
                children.Add(m_silo1DischargeValve);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Silo1LevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (Silo1LevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                Silo1LevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                Silo1LevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = Silo1LevelIndicator;
                    break;
                }

                case BatchPlant.BrowseNames.Silo1DischargeValve:
                {
                    if (createOrReplace)
                    {
                        if (Silo1DischargeValve == null)
                        {
                            if (replacement == null)
                            {
                                Silo1DischargeValve = new ValveState(this);
                            }
                            else
                            {
                                Silo1DischargeValve = (ValveState)replacement;
                            }
                        }
                    }

                    instance = Silo1DischargeValve;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_silo1LevelIndicator;
        private ValveState m_silo1DischargeValve;
        #endregion
    }
    #endif
    #endregion

    #region Silo2State Class
    #if (!OPCUA_EXCLUDE_Silo2State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Silo2State : FolderState
    {
        #region Constructors
        /// <remarks />
        public Silo2State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.Silo2Type, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AFNpbG8yVHlwZUluc3RhbmNlAQE+AAEBPgA+AAAAAQAAAAAwAAEBPwACAAAAhGDACgEAAAATAAAAU2ls" +
           "bzJMZXZlbEluZGljYXRvcgEABQAAAExJMDAyAQE/AAAvAQEdAD8AAAABAQAAAAAwAQEBPgACAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAUAAAC8BAEAJQAAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAUQAAC4AREQAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQFG" +
           "AAAuAERGAAAAAAz/////AwP/////AAAAAIRgwAoBAAAAEwAAAFNpbG8yRGlzY2hhcmdlVmFsdmUBAAgA" +
           "AABWYWx2ZTAwMgEBRwAALwEBJQBHAAAAAf////8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBSAAALwEA" +
           "QAlIAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBTAAALgBETAAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQFOAAAvAQBACU4AAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFSAAAuAERSAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LevelIndicatorState Silo2LevelIndicator
        {
            get
            {
                return m_silo2LevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo2LevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo2LevelIndicator = value;
            }
        }

        /// <remarks />
        public ValveState Silo2DischargeValve
        {
            get
            {
                return m_silo2DischargeValve;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo2DischargeValve, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo2DischargeValve = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_silo2LevelIndicator != null)
            {
                children.Add(m_silo2LevelIndicator);
            }

            if (m_silo2DischargeValve != null)
            {
                children.Add(m_silo2DischargeValve);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Silo2LevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (Silo2LevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                Silo2LevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                Silo2LevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = Silo2LevelIndicator;
                    break;
                }

                case BatchPlant.BrowseNames.Silo2DischargeValve:
                {
                    if (createOrReplace)
                    {
                        if (Silo2DischargeValve == null)
                        {
                            if (replacement == null)
                            {
                                Silo2DischargeValve = new ValveState(this);
                            }
                            else
                            {
                                Silo2DischargeValve = (ValveState)replacement;
                            }
                        }
                    }

                    instance = Silo2DischargeValve;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_silo2LevelIndicator;
        private ValveState m_silo2DischargeValve;
        #endregion
    }
    #endif
    #endregion

    #region Silo3State Class
    #if (!OPCUA_EXCLUDE_Silo3State)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Silo3State : FolderState
    {
        #region Constructors
        /// <remarks />
        public Silo3State(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.Silo3Type, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AFNpbG8zVHlwZUluc3RhbmNlAQFUAAEBVABUAAAAAQAAAAAwAAEBVQACAAAAhGDACgEAAAATAAAAU2ls" +
           "bzNMZXZlbEluZGljYXRvcgEABQAAAExJMDAzAQFVAAAvAQEdAFUAAAABAQAAAAAwAQEBVAACAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAVYAAC8BAEAJVgAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAVoAAC4ARFoAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQFc" +
           "AAAuAERcAAAAAAz/////AwP/////AAAAAIRgwAoBAAAAEwAAAFNpbG8zRGlzY2hhcmdlVmFsdmUBAAgA" +
           "AABWYWx2ZTAwMwEBXQAALwEBJQBdAAAAAf////8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBXgAALwEA" +
           "QAleAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBYgAALgBEYgAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQFkAAAvAQBACWQAAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFoAAAuAERoAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LevelIndicatorState Silo3LevelIndicator
        {
            get
            {
                return m_silo3LevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo3LevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo3LevelIndicator = value;
            }
        }

        /// <remarks />
        public ValveState Silo3DischargeValve
        {
            get
            {
                return m_silo3DischargeValve;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo3DischargeValve, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo3DischargeValve = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_silo3LevelIndicator != null)
            {
                children.Add(m_silo3LevelIndicator);
            }

            if (m_silo3DischargeValve != null)
            {
                children.Add(m_silo3DischargeValve);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Silo3LevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (Silo3LevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                Silo3LevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                Silo3LevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = Silo3LevelIndicator;
                    break;
                }

                case BatchPlant.BrowseNames.Silo3DischargeValve:
                {
                    if (createOrReplace)
                    {
                        if (Silo3DischargeValve == null)
                        {
                            if (replacement == null)
                            {
                                Silo3DischargeValve = new ValveState(this);
                            }
                            else
                            {
                                Silo3DischargeValve = (ValveState)replacement;
                            }
                        }
                    }

                    instance = Silo3DischargeValve;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_silo3LevelIndicator;
        private ValveState m_silo3DischargeValve;
        #endregion
    }
    #endif
    #endregion

    #region PumpState Class
    #if (!OPCUA_EXCLUDE_PumpState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PumpState : FolderState
    {
        #region Constructors
        /// <remarks />
        public PumpState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.PumpType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEAAA" +
           "AFB1bXBUeXBlSW5zdGFuY2UBAacBAQGnAacBAAD/////AgAAAIRgwAoBAAAACQAAAFB1bXBNb3RvcgEA" +
           "BgAAAFB1bXAwMQEBqAEALwEBoAGoAQAAAf////8CAAAAFWCJCgIAAAABAAUAAABTcGVlZAEBqQEALwEA" +
           "QAmpAQAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBrQEALgBErQEAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAFAAAAU3RhdGUBAR8CAC8APx8CAAAAAf////8DA/////8AAAAA" +
           "hGDACgEAAAAVAAAAUHVtcFRlbXBlcmF0dXJlU2Vuc29yAQAXAAAAUHVtcFRlbXBlcmF0dXJlU2Vuc29y" +
           "MDEBAfQBAC8BAe0B9AEAAAH/////AwAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQH1AQAvAQBACfUBAAAA" +
           "C/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQH5AQAuAET5AQAAAQB0A/////8BAf//" +
           "//8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEB+wEALgBE+wEAAAAM/////wMD/////wAAAAAVYIkKAgAA" +
           "AAEACwAAAFRlbXBlcmF0dXJlAQH8AQAvAQBACfwBAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQEAAgAuAEQAAgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PumpMotorState PumpMotor
        {
            get
            {
                return m_pumpMotor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pumpMotor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pumpMotor = value;
            }
        }

        /// <remarks />
        public TemperatureState PumpTemperatureSensor
        {
            get
            {
                return m_pumpTemperatureSensor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pumpTemperatureSensor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pumpTemperatureSensor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_pumpMotor != null)
            {
                children.Add(m_pumpMotor);
            }

            if (m_pumpTemperatureSensor != null)
            {
                children.Add(m_pumpTemperatureSensor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.PumpMotor:
                {
                    if (createOrReplace)
                    {
                        if (PumpMotor == null)
                        {
                            if (replacement == null)
                            {
                                PumpMotor = new PumpMotorState(this);
                            }
                            else
                            {
                                PumpMotor = (PumpMotorState)replacement;
                            }
                        }
                    }

                    instance = PumpMotor;
                    break;
                }

                case BatchPlant.BrowseNames.PumpTemperatureSensor:
                {
                    if (createOrReplace)
                    {
                        if (PumpTemperatureSensor == null)
                        {
                            if (replacement == null)
                            {
                                PumpTemperatureSensor = new TemperatureState(this);
                            }
                            else
                            {
                                PumpTemperatureSensor = (TemperatureState)replacement;
                            }
                        }
                    }

                    instance = PumpTemperatureSensor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PumpMotorState m_pumpMotor;
        private TemperatureState m_pumpTemperatureSensor;
        #endregion
    }
    #endif
    #endregion

    #region MixerState Class
    #if (!OPCUA_EXCLUDE_MixerState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MixerState : FolderState
    {
        #region Constructors
        /// <remarks />
        public MixerState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.MixerType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AE1peGVyVHlwZUluc3RhbmNlAQFqAAEBagBqAAAAAQAAAAAwAAEBawADAAAAhGDACgEAAAATAAAATG9h" +
           "ZGNlbGxUcmFuc21pdHRlcgEABQAAAExUMDAxAQFrAAAvAQEeAGsAAAABAQAAAAAwAQEBagADAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAWwAAC8BAEAJbAAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAXAAAC4ARHAAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQFy" +
           "AAAuAERyAAAAAAz/////AwP/////AAAAABVgiQoCAAAAAQARAAAARXhjaXRhdGlvblZvbHRhZ2UBAXMA" +
           "AC8BAEAJcwAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAXcAAC4ARHcAAAAB" +
           "AHQD/////wEB/////wAAAACEYMAKAQAAAAoAAABNaXhlck1vdG9yAQAHAAAATW90b3IwMQEBeQAALwEB" +
           "JgB5AAAAAf////8BAAAAFWCJCgIAAAABAAUAAABTcGVlZAEBegAALwEAQAl6AAAAAAv/////AwP/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBfgAALgBEfgAAAAEAdAP/////AQH/////AAAAAIRgwAoB" +
           "AAAAEwAAAE1peGVyRGlzY2hhcmdlVmFsdmUBAAgAAABWYWx2ZTAwNAEBgAAALwEBJQCAAAAAAf////8C" +
           "AAAAFWCJCgIAAAABAAUAAABJbnB1dAEBgQAALwEAQAmBAAAAAAv/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBhQAALgBEhQAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0" +
           "cHV0AQGHAAAvAQBACYcAAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGLAAAu" +
           "AESLAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LoadcellTransmitterState LoadcellTransmitter
        {
            get
            {
                return m_loadcellTransmitter;
            }

            set
            {
                if (!Object.ReferenceEquals(m_loadcellTransmitter, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_loadcellTransmitter = value;
            }
        }

        /// <remarks />
        public MixerMotorState MixerMotor
        {
            get
            {
                return m_mixerMotor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mixerMotor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mixerMotor = value;
            }
        }

        /// <remarks />
        public ValveState MixerDischargeValve
        {
            get
            {
                return m_mixerDischargeValve;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mixerDischargeValve, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mixerDischargeValve = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_loadcellTransmitter != null)
            {
                children.Add(m_loadcellTransmitter);
            }

            if (m_mixerMotor != null)
            {
                children.Add(m_mixerMotor);
            }

            if (m_mixerDischargeValve != null)
            {
                children.Add(m_mixerDischargeValve);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.LoadcellTransmitter:
                {
                    if (createOrReplace)
                    {
                        if (LoadcellTransmitter == null)
                        {
                            if (replacement == null)
                            {
                                LoadcellTransmitter = new LoadcellTransmitterState(this);
                            }
                            else
                            {
                                LoadcellTransmitter = (LoadcellTransmitterState)replacement;
                            }
                        }
                    }

                    instance = LoadcellTransmitter;
                    break;
                }

                case BatchPlant.BrowseNames.MixerMotor:
                {
                    if (createOrReplace)
                    {
                        if (MixerMotor == null)
                        {
                            if (replacement == null)
                            {
                                MixerMotor = new MixerMotorState(this);
                            }
                            else
                            {
                                MixerMotor = (MixerMotorState)replacement;
                            }
                        }
                    }

                    instance = MixerMotor;
                    break;
                }

                case BatchPlant.BrowseNames.MixerDischargeValve:
                {
                    if (createOrReplace)
                    {
                        if (MixerDischargeValve == null)
                        {
                            if (replacement == null)
                            {
                                MixerDischargeValve = new ValveState(this);
                            }
                            else
                            {
                                MixerDischargeValve = (ValveState)replacement;
                            }
                        }
                    }

                    instance = MixerDischargeValve;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LoadcellTransmitterState m_loadcellTransmitter;
        private MixerMotorState m_mixerMotor;
        private ValveState m_mixerDischargeValve;
        #endregion
    }
    #endif
    #endregion

    #region PackagingUnitState Class
    #if (!OPCUA_EXCLUDE_PackagingUnitState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PackagingUnitState : FolderState
    {
        #region Constructors
        /// <remarks />
        public PackagingUnitState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.PackagingUnitType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGQAA" +
           "AFBhY2thZ2luZ1VuaXRUeXBlSW5zdGFuY2UBAY0AAQGNAI0AAAABAAAAADAAAQGOAAEAAACEYMAKAQAA" +
           "ABsAAABQYWNrYWdpbmdVbml0TGV2ZWxJbmRpY2F0b3IBAAUAAABMSTAwNAEBjgAALwEBHQCOAAAAAQEA" +
           "AAAAMAEBAY0AAgAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQGPAAAvAQBACY8AAAAAC/////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGTAAAuAESTAAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAUAAABVbml0cwEBlQAALgBElQAAAAAM/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public LevelIndicatorState PackagingUnitLevelIndicator
        {
            get
            {
                return m_packagingUnitLevelIndicator;
            }

            set
            {
                if (!Object.ReferenceEquals(m_packagingUnitLevelIndicator, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_packagingUnitLevelIndicator = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_packagingUnitLevelIndicator != null)
            {
                children.Add(m_packagingUnitLevelIndicator);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.PackagingUnitLevelIndicator:
                {
                    if (createOrReplace)
                    {
                        if (PackagingUnitLevelIndicator == null)
                        {
                            if (replacement == null)
                            {
                                PackagingUnitLevelIndicator = new LevelIndicatorState(this);
                            }
                            else
                            {
                                PackagingUnitLevelIndicator = (LevelIndicatorState)replacement;
                            }
                        }
                    }

                    instance = PackagingUnitLevelIndicator;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private LevelIndicatorState m_packagingUnitLevelIndicator;
        #endregion
    }
    #endif
    #endregion

    #region ConveyorState Class
    #if (!OPCUA_EXCLUDE_ConveyorState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConveyorState : FolderState
    {
        #region Constructors
        /// <remarks />
        public ConveyorState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.ConveyorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAFAAA" +
           "AENvbnZleW9yVHlwZUluc3RhbmNlAQGWAAEBlgCWAAAAAQAAAAAwAAEBlwABAAAAhGDACgEAAAANAAAA" +
           "Q29udmV5b3JNb3RvcgEABwAAAE1vdG9yMDIBAZcAAC8BAScAlwAAAAEBAAAAADABAQGWAAEAAAAVYIkK" +
           "AgAAAAEABQAAAFNwZWVkAQGYAAAvAQBACZgAAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQGcAAAuAEScAAAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public ConveyorMotorState ConveyorMotor
        {
            get
            {
                return m_conveyorMotor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_conveyorMotor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_conveyorMotor = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_conveyorMotor != null)
            {
                children.Add(m_conveyorMotor);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.ConveyorMotor:
                {
                    if (createOrReplace)
                    {
                        if (ConveyorMotor == null)
                        {
                            if (replacement == null)
                            {
                                ConveyorMotor = new ConveyorMotorState(this);
                            }
                            else
                            {
                                ConveyorMotor = (ConveyorMotorState)replacement;
                            }
                        }
                    }

                    instance = ConveyorMotor;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private ConveyorMotorState m_conveyorMotor;
        #endregion
    }
    #endif
    #endregion

    #region BatchPlantState Class
    #if (!OPCUA_EXCLUDE_BatchPlantState)
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BatchPlantState : BaseObjectState
    {
        #region Constructors
        /// <remarks />
        public BatchPlantState(NodeState parent) : base(parent)
        {
        }

        /// <remarks />
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.BatchPlantType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <remarks />
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <remarks />
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <remarks />
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////+EYIACAQAAAAEAFgAA" +
           "AEJhdGNoUGxhbnRUeXBlSW5zdGFuY2UBAZ4AAQGeAJ4AAAABBgAAAAAwAAEBnwAAMAABAbcAADAAAQHP" +
           "AAAwAAEB5wAAMAABAQwBADAAAQEVAQsAAACEYMAKAQAAAAUAAABTaWxvMQEACAAAAFNpbG9YMDAxAQGf" +
           "AAAvAQEoAJ8AAAABAgAAAAAwAQEBngAAMAABAaAAAwAAAIRgwAoBAAAAEwAAAFNpbG8xTGV2ZWxJbmRp" +
           "Y2F0b3IBAAUAAABMSTAwMQEBoAAALwEBHQCgAAAAAQEAAAAAMAEBAZ8AAgAAABVgiQoCAAAAAQAGAAAA" +
           "T3V0cHV0AQGhAAAvAQBACaEAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGl" +
           "AAAuAESlAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBpwAALgBEpwAAAAAM" +
           "/////wMD/////wAAAACEYMAKAQAAABMAAABTaWxvMURpc2NoYXJnZVZhbHZlAQAIAAAAVmFsdmUwMDEB" +
           "AagAAC8BASUAqAAAAAH/////AgAAABVgiQoCAAAAAQAFAAAASW5wdXQBAakAAC8BAEAJqQAAAAAL////" +
           "/wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAa0AAC4ARK0AAAABAHQD/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEABgAAAE91dHB1dAEBrwAALwEAQAmvAAAAAAv/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBswAALgBEswAAAAEAdAP/////AQH/////AAAAAARggAoBAAAAAQAOAAAARGlz" +
           "Y2hhcmdlVmFsdmUBAbUAAC8AOrUAAAD/////AQAAABVgiQoCAAAAAQAFAAAASW5wdXQBAbYAAC8AP7YA" +
           "AAAAGP////8BAf////8AAAAAhGDACgEAAAAFAAAAU2lsbzIBAAgAAABTaWxvWDAwMgEBtwAALwEBPgC3" +
           "AAAAAQIAAAAAMAEBAZ4AADAAAQG4AAMAAACEYMAKAQAAABMAAABTaWxvMkxldmVsSW5kaWNhdG9yAQAF" +
           "AAAATEkwMDIBAbgAAC8BAR0AuAAAAAEBAAAAADABAQG3AAIAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEB" +
           "uQAALwEAQAm5AAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBvQAALgBEvQAA" +
           "AAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBAb8AAC4ARL8AAAAADP////8DA///" +
           "//8AAAAAhGDACgEAAAATAAAAU2lsbzJEaXNjaGFyZ2VWYWx2ZQEACAAAAFZhbHZlMDAyAQHAAAAvAQEl" +
           "AMAAAAAB/////wIAAAAVYIkKAgAAAAEABQAAAElucHV0AQHBAAAvAQBACcEAAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHFAAAuAETFAAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAYAAABPdXRwdXQBAccAAC8BAEAJxwAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAcsAAC4ARMsAAAABAHQD/////wEB/////wAAAAAEYIAKAQAAAAEADgAAAERpc2NoYXJnZVZh" +
           "bHZlAQHNAAAvADrNAAAA/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQHOAAAvAD/OAAAAABj/////" +
           "AQH/////AAAAAIRgwAoBAAAABQAAAFNpbG8zAQAIAAAAU2lsb1gwMDMBAc8AAC8BAVQAzwAAAAECAAAA" +
           "ADABAQGeAAAwAAEB0AADAAAAhGDACgEAAAATAAAAU2lsbzNMZXZlbEluZGljYXRvcgEABQAAAExJMDAz" +
           "AQHQAAAvAQEdANAAAAABAQAAAAAwAQEBzwACAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAdEAAC8BAEAJ" +
           "0QAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdUAAC4ARNUAAAABAHQD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQHXAAAuAETXAAAAAAz/////AwP/////AAAAAIRg" +
           "wAoBAAAAEwAAAFNpbG8zRGlzY2hhcmdlVmFsdmUBAAgAAABWYWx2ZTAwMwEB2AAALwEBJQDYAAAAAf//" +
           "//8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEB2QAALwEAQAnZAAAAAAv/////AwP/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEB3QAALgBE3QAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAA" +
           "T3V0cHV0AQHfAAAvAQBACd8AAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHj" +
           "AAAuAETjAAAAAQB0A/////8BAf////8AAAAABGCACgEAAAABAA4AAABEaXNjaGFyZ2VWYWx2ZQEB5QAA" +
           "LwA65QAAAP////8BAAAAFWCJCgIAAAABAAUAAABJbnB1dAEB5gAALwA/5gAAAAAY/////wEB/////wAA" +
           "AACEYMAKAQAAAAQAAABQdW1wAQAIAAAAUHVtcFgwMDEBAbYBAC8BAacBtgEAAAH/////AgAAAIRgwAoB" +
           "AAAACQAAAFB1bXBNb3RvcgEABgAAAFB1bXAwMQEBtwEALwEBoAG3AQAAAf////8CAAAAFWCJCgIAAAAB" +
           "AAUAAABTcGVlZAEBuAEALwEAQAm4AQAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5n" +
           "ZQEBvAEALgBEvAEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAU3RhdGUBASACAC8APyAC" +
           "AAAAAf////8DA/////8AAAAAhGDACgEAAAAVAAAAUHVtcFRlbXBlcmF0dXJlU2Vuc29yAQAXAAAAUHVt" +
           "cFRlbXBlcmF0dXJlU2Vuc29yMDEBAQICAC8BAe0BAgIAAAH/////AwAAABVgiQoCAAAAAQAGAAAAT3V0" +
           "cHV0AQEDAgAvAQBACQMCAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEHAgAu" +
           "AEQHAgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBCQIALgBECQIAAAAM////" +
           "/wMD/////wAAAAAVYIkKAgAAAAEACwAAAFRlbXBlcmF0dXJlAQEKAgAvAQBACQoCAAAAC/////8DA///" +
           "//8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEOAgAuAEQOAgAAAQB0A/////8BAf////8AAAAAhGDA" +
           "CgEAAAAFAAAATWl4ZXIBAAkAAABNaXhlclgwMDEBAecAAC8BAWoA5wAAAAECAAAAADABAQGeAAAwAAEB" +
           "6AAEAAAAhGDACgEAAAATAAAATG9hZGNlbGxUcmFuc21pdHRlcgEABQAAAExUMDAxAQHoAAAvAQEeAOgA" +
           "AAABAQAAAAAwAQEB5wADAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAekAAC8BAEAJ6QAAAAAL/////wEB" +
           "/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAe0AAC4ARO0AAAABAHQD/////wEB/////wAAAAAV" +
           "YIkKAgAAAAEABQAAAFVuaXRzAQHvAAAuAETvAAAAAAz/////AwP/////AAAAABVgiQoCAAAAAQARAAAA" +
           "RXhjaXRhdGlvblZvbHRhZ2UBAfAAAC8BAEAJ8AAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAfQAAC4ARPQAAAABAHQD/////wEB/////wAAAACEYMAKAQAAAAoAAABNaXhlck1vdG9y" +
           "AQAHAAAATW90b3IwMQEB9gAALwEBJgD2AAAAAf////8BAAAAFWCJCgIAAAABAAUAAABTcGVlZAEB9wAA" +
           "LwEAQAn3AAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB+wAALgBE+wAAAAEA" +
           "dAP/////AQH/////AAAAAIRgwAoBAAAAEwAAAE1peGVyRGlzY2hhcmdlVmFsdmUBAAgAAABWYWx2ZTAw" +
           "NAEB/QAALwEBJQD9AAAAAf////8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEB/gAALwEAQAn+AAAAAAv/" +
           "////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBAgEALgBEAgEAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQEEAQAvAQBACQQBAAAAC/////8DA/////8BAAAAFWCJCgIA" +
           "AAAAAAcAAABFVVJhbmdlAQEIAQAuAEQIAQAAAQB0A/////8BAf////8AAAAABGCACgEAAAABAA4AAABE" +
           "aXNjaGFyZ2VWYWx2ZQEBCgEALwA6CgEAAP////8BAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBCwEALwA/" +
           "CwEAAAAY/////wEB/////wAAAACEYMAKAQAAAA0AAABQYWNrYWdpbmdVbml0AQARAAAAUGFja2FnaW5n" +
           "VW5pdFgwMDEBAQwBAC8BAY0ADAEAAAECAAAAADABAQGeAAAwAAEBDQEBAAAAhGDACgEAAAAbAAAAUGFj" +
           "a2FnaW5nVW5pdExldmVsSW5kaWNhdG9yAQAFAAAATEkwMDQBAQ0BAC8BAR0ADQEAAAEBAAAAADABAQEM" +
           "AQIAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBDgEALwEAQAkOAQAAAAv/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBEgEALgBEEgEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAA" +
           "VW5pdHMBARQBAC4ARBQBAAAADP////8DA/////8AAAAAhGDACgEAAAAIAAAAQ29udmV5b3IBAAwAAABD" +
           "b252ZXlvclgwMDEBARUBAC8BAZYAFQEAAAECAAAAADABAQGeAAAwAAEBFgEBAAAAhGDACgEAAAANAAAA" +
           "Q29udmV5b3JNb3RvcgEABwAAAE1vdG9yMDIBARYBAC8BAScAFgEAAAEBAAAAADABAQEVAQEAAAAVYIkK" +
           "AgAAAAEABQAAAFNwZWVkAQEXAQAvAQBACRcBAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQEbAQAuAEQbAQAAAQB0A/////8BAf////8AAAAABGGCCgQAAAABAAwAAABTdGFydFByb2Nl" +
           "c3MBAR0BAC8BAR0BHQEAAAEB/////wAAAAAEYYIKBAAAAAEACwAAAFN0b3BQcm9jZXNzAQEeAQAvAQEe" +
           "AR4BAAABAf////8AAAAABGGCCgQAAAABAAoAAABUdXJuT25QdW1wAQEiAgAvAQEiAiICAAABAf////8A" +
           "AAAABGGCCgQAAAABAAsAAABUdXJuT2ZmUHVtcAEBIwIALwEBIwIjAgAAAQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public Silo1State Silo1
        {
            get
            {
                return m_silo1;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo1, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo1 = value;
            }
        }

        /// <remarks />
        public Silo2State Silo2
        {
            get
            {
                return m_silo2;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo2, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo2 = value;
            }
        }

        /// <remarks />
        public Silo3State Silo3
        {
            get
            {
                return m_silo3;
            }

            set
            {
                if (!Object.ReferenceEquals(m_silo3, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_silo3 = value;
            }
        }

        /// <remarks />
        public PumpState Pump
        {
            get
            {
                return m_pump;
            }

            set
            {
                if (!Object.ReferenceEquals(m_pump, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_pump = value;
            }
        }

        /// <remarks />
        public MixerState Mixer
        {
            get
            {
                return m_mixer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_mixer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_mixer = value;
            }
        }

        /// <remarks />
        public PackagingUnitState PackagingUnit
        {
            get
            {
                return m_packagingUnit;
            }

            set
            {
                if (!Object.ReferenceEquals(m_packagingUnit, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_packagingUnit = value;
            }
        }

        /// <remarks />
        public ConveyorState Conveyor
        {
            get
            {
                return m_conveyor;
            }

            set
            {
                if (!Object.ReferenceEquals(m_conveyor, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_conveyor = value;
            }
        }

        /// <remarks />
        public MethodState StartProcess
        {
            get
            {
                return m_startProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_startProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_startProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState StopProcess
        {
            get
            {
                return m_stopProcessMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_stopProcessMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_stopProcessMethod = value;
            }
        }

        /// <remarks />
        public MethodState TurnOnPump
        {
            get
            {
                return m_turnOnPumpMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_turnOnPumpMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_turnOnPumpMethod = value;
            }
        }

        /// <remarks />
        public MethodState TurnOffPump
        {
            get
            {
                return m_turnOffPumpMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_turnOffPumpMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_turnOffPumpMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <remarks />
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_silo1 != null)
            {
                children.Add(m_silo1);
            }

            if (m_silo2 != null)
            {
                children.Add(m_silo2);
            }

            if (m_silo3 != null)
            {
                children.Add(m_silo3);
            }

            if (m_pump != null)
            {
                children.Add(m_pump);
            }

            if (m_mixer != null)
            {
                children.Add(m_mixer);
            }

            if (m_packagingUnit != null)
            {
                children.Add(m_packagingUnit);
            }

            if (m_conveyor != null)
            {
                children.Add(m_conveyor);
            }

            if (m_startProcessMethod != null)
            {
                children.Add(m_startProcessMethod);
            }

            if (m_stopProcessMethod != null)
            {
                children.Add(m_stopProcessMethod);
            }

            if (m_turnOnPumpMethod != null)
            {
                children.Add(m_turnOnPumpMethod);
            }

            if (m_turnOffPumpMethod != null)
            {
                children.Add(m_turnOffPumpMethod);
            }

            base.GetChildren(context, children);
        }
            
        /// <remarks />
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BatchPlant.BrowseNames.Silo1:
                {
                    if (createOrReplace)
                    {
                        if (Silo1 == null)
                        {
                            if (replacement == null)
                            {
                                Silo1 = new Silo1State(this);
                            }
                            else
                            {
                                Silo1 = (Silo1State)replacement;
                            }
                        }
                    }

                    instance = Silo1;
                    break;
                }

                case BatchPlant.BrowseNames.Silo2:
                {
                    if (createOrReplace)
                    {
                        if (Silo2 == null)
                        {
                            if (replacement == null)
                            {
                                Silo2 = new Silo2State(this);
                            }
                            else
                            {
                                Silo2 = (Silo2State)replacement;
                            }
                        }
                    }

                    instance = Silo2;
                    break;
                }

                case BatchPlant.BrowseNames.Silo3:
                {
                    if (createOrReplace)
                    {
                        if (Silo3 == null)
                        {
                            if (replacement == null)
                            {
                                Silo3 = new Silo3State(this);
                            }
                            else
                            {
                                Silo3 = (Silo3State)replacement;
                            }
                        }
                    }

                    instance = Silo3;
                    break;
                }

                case BatchPlant.BrowseNames.Pump:
                {
                    if (createOrReplace)
                    {
                        if (Pump == null)
                        {
                            if (replacement == null)
                            {
                                Pump = new PumpState(this);
                            }
                            else
                            {
                                Pump = (PumpState)replacement;
                            }
                        }
                    }

                    instance = Pump;
                    break;
                }

                case BatchPlant.BrowseNames.Mixer:
                {
                    if (createOrReplace)
                    {
                        if (Mixer == null)
                        {
                            if (replacement == null)
                            {
                                Mixer = new MixerState(this);
                            }
                            else
                            {
                                Mixer = (MixerState)replacement;
                            }
                        }
                    }

                    instance = Mixer;
                    break;
                }

                case BatchPlant.BrowseNames.PackagingUnit:
                {
                    if (createOrReplace)
                    {
                        if (PackagingUnit == null)
                        {
                            if (replacement == null)
                            {
                                PackagingUnit = new PackagingUnitState(this);
                            }
                            else
                            {
                                PackagingUnit = (PackagingUnitState)replacement;
                            }
                        }
                    }

                    instance = PackagingUnit;
                    break;
                }

                case BatchPlant.BrowseNames.Conveyor:
                {
                    if (createOrReplace)
                    {
                        if (Conveyor == null)
                        {
                            if (replacement == null)
                            {
                                Conveyor = new ConveyorState(this);
                            }
                            else
                            {
                                Conveyor = (ConveyorState)replacement;
                            }
                        }
                    }

                    instance = Conveyor;
                    break;
                }

                case BatchPlant.BrowseNames.StartProcess:
                {
                    if (createOrReplace)
                    {
                        if (StartProcess == null)
                        {
                            if (replacement == null)
                            {
                                StartProcess = new MethodState(this);
                            }
                            else
                            {
                                StartProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StartProcess;
                    break;
                }

                case BatchPlant.BrowseNames.StopProcess:
                {
                    if (createOrReplace)
                    {
                        if (StopProcess == null)
                        {
                            if (replacement == null)
                            {
                                StopProcess = new MethodState(this);
                            }
                            else
                            {
                                StopProcess = (MethodState)replacement;
                            }
                        }
                    }

                    instance = StopProcess;
                    break;
                }

                case BatchPlant.BrowseNames.TurnOnPump:
                {
                    if (createOrReplace)
                    {
                        if (TurnOnPump == null)
                        {
                            if (replacement == null)
                            {
                                TurnOnPump = new MethodState(this);
                            }
                            else
                            {
                                TurnOnPump = (MethodState)replacement;
                            }
                        }
                    }

                    instance = TurnOnPump;
                    break;
                }

                case BatchPlant.BrowseNames.TurnOffPump:
                {
                    if (createOrReplace)
                    {
                        if (TurnOffPump == null)
                        {
                            if (replacement == null)
                            {
                                TurnOffPump = new MethodState(this);
                            }
                            else
                            {
                                TurnOffPump = (MethodState)replacement;
                            }
                        }
                    }

                    instance = TurnOffPump;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private Silo1State m_silo1;
        private Silo2State m_silo2;
        private Silo3State m_silo3;
        private PumpState m_pump;
        private MixerState m_mixer;
        private PackagingUnitState m_packagingUnit;
        private ConveyorState m_conveyor;
        private MethodState m_startProcessMethod;
        private MethodState m_stopProcessMethod;
        private MethodState m_turnOnPumpMethod;
        private MethodState m_turnOffPumpMethod;
        #endregion
    }
    #endif
    #endregion
}