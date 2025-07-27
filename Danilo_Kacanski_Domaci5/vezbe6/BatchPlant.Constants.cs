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
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace BatchPlant
{
    #region Method Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <remarks />
        public const uint BatchPlantType_StartProcess = 285;

        /// <remarks />
        public const uint BatchPlantType_StopProcess = 286;

        /// <remarks />
        public const uint BatchPlant1_StartProcess = 414;

        /// <remarks />
        public const uint BatchPlant1_StopProcess = 415;
    }
    #endregion

    #region Object Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <remarks />
        public const uint Silo1Type_Silo1LevelIndicator = 41;

        /// <remarks />
        public const uint Silo1Type_Silo1DischargeValve = 49;

        /// <remarks />
        public const uint Silo2Type_Silo2LevelIndicator = 63;

        /// <remarks />
        public const uint Silo2Type_Silo2DischargeValve = 71;

        /// <remarks />
        public const uint Silo3Type_Silo3LevelIndicator = 85;

        /// <remarks />
        public const uint Silo3Type_Silo3DischargeValve = 93;

        /// <remarks />
        public const uint MixerType_LoadcellTransmitter = 107;

        /// <remarks />
        public const uint MixerType_MixerMotor = 121;

        /// <remarks />
        public const uint MixerType_MixerDischargeValve = 128;

        /// <remarks />
        public const uint PackagingUnitType_PackagingUnitLevelIndicator = 142;

        /// <remarks />
        public const uint ConveyorType_ConveyorMotor = 151;

        /// <remarks />
        public const uint PumpType_PumpMotor = 424;

        /// <remarks />
        public const uint BatchPlantType_Silo1 = 159;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator = 160;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1DischargeValve = 168;

        /// <remarks />
        public const uint BatchPlantType_Silo1_DischargeValve = 181;

        /// <remarks />
        public const uint BatchPlantType_Silo2 = 183;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator = 184;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2DischargeValve = 192;

        /// <remarks />
        public const uint BatchPlantType_Silo2_DischargeValve = 205;

        /// <remarks />
        public const uint BatchPlantType_Silo3 = 207;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator = 208;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3DischargeValve = 216;

        /// <remarks />
        public const uint BatchPlantType_Silo3_DischargeValve = 229;

        /// <remarks />
        public const uint BatchPlantType_Mixer = 231;

        /// <remarks />
        public const uint BatchPlantType_Mixer_LoadcellTransmitter = 232;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerMotor = 246;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerDischargeValve = 253;

        /// <remarks />
        public const uint BatchPlantType_Mixer_DischargeValve = 266;

        /// <remarks />
        public const uint BatchPlantType_PackagingUnit = 268;

        /// <remarks />
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator = 269;

        /// <remarks />
        public const uint BatchPlantType_Conveyor = 277;

        /// <remarks />
        public const uint BatchPlantType_Conveyor_ConveyorMotor = 278;

        /// <remarks />
        public const uint BatchPlantType_Pump = 438;

        /// <remarks />
        public const uint BatchPlantType_Pump_PumpMotor = 439;

        /// <remarks />
        public const uint BatchPlant1 = 287;

        /// <remarks />
        public const uint BatchPlant1_Silo1 = 288;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator = 289;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1DischargeValve = 297;

        /// <remarks />
        public const uint BatchPlant1_Silo1_DischargeValve = 310;

        /// <remarks />
        public const uint BatchPlant1_Silo2 = 312;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator = 313;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2DischargeValve = 321;

        /// <remarks />
        public const uint BatchPlant1_Silo2_DischargeValve = 334;

        /// <remarks />
        public const uint BatchPlant1_Silo3 = 336;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator = 337;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3DischargeValve = 345;

        /// <remarks />
        public const uint BatchPlant1_Silo3_DischargeValve = 358;

        /// <remarks />
        public const uint BatchPlant1_Mixer = 360;

        /// <remarks />
        public const uint BatchPlant1_Mixer_LoadcellTransmitter = 361;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerMotor = 375;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerDischargeValve = 382;

        /// <remarks />
        public const uint BatchPlant1_Mixer_DischargeValve = 395;

        /// <remarks />
        public const uint BatchPlant1_PackagingUnit = 397;

        /// <remarks />
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator = 398;

        /// <remarks />
        public const uint BatchPlant1_Conveyor = 406;

        /// <remarks />
        public const uint BatchPlant1_Conveyor_ConveyorMotor = 407;

        /// <remarks />
        public const uint BatchPlant1_Pump = 453;

        /// <remarks />
        public const uint BatchPlant1_Pump_PumpMotor = 454;
    }
    #endregion

    #region ObjectType Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <remarks />
        public const uint GenericSensorType = 1;

        /// <remarks />
        public const uint GenericActuatorType = 9;

        /// <remarks />
        public const uint GenericMotorType = 22;

        /// <remarks />
        public const uint LevelIndicatorType = 29;

        /// <remarks />
        public const uint LoadcellTransmitterType = 30;

        /// <remarks />
        public const uint ValveType = 37;

        /// <remarks />
        public const uint MixerMotorType = 38;

        /// <remarks />
        public const uint ConveyorMotorType = 39;

        /// <remarks />
        public const uint PumpMotorType = 416;

        /// <remarks />
        public const uint Silo1Type = 40;

        /// <remarks />
        public const uint Silo2Type = 62;

        /// <remarks />
        public const uint Silo3Type = 84;

        /// <remarks />
        public const uint MixerType = 106;

        /// <remarks />
        public const uint PackagingUnitType = 141;

        /// <remarks />
        public const uint ConveyorType = 150;

        /// <remarks />
        public const uint PumpType = 423;

        /// <remarks />
        public const uint BatchPlantType = 158;
    }
    #endregion

    #region Variable Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <remarks />
        public const uint GenericSensorType_Output = 2;

        /// <remarks />
        public const uint GenericSensorType_Output_EURange = 6;

        /// <remarks />
        public const uint GenericSensorType_Units = 8;

        /// <remarks />
        public const uint GenericActuatorType_Input = 10;

        /// <remarks />
        public const uint GenericActuatorType_Input_EURange = 14;

        /// <remarks />
        public const uint GenericActuatorType_Output = 16;

        /// <remarks />
        public const uint GenericActuatorType_Output_EURange = 20;

        /// <remarks />
        public const uint GenericMotorType_Speed = 23;

        /// <remarks />
        public const uint GenericMotorType_Speed_EURange = 27;

        /// <remarks />
        public const uint LoadcellTransmitterType_ExcitationVoltage = 31;

        /// <remarks />
        public const uint LoadcellTransmitterType_ExcitationVoltage_EURange = 35;

        /// <remarks />
        public const uint PumpMotorType_Temperature = 417;

        /// <remarks />
        public const uint PumpMotorType_Temperature_EURange = 421;

        /// <remarks />
        public const uint Silo1Type_Silo1LevelIndicator_Output = 42;

        /// <remarks />
        public const uint Silo1Type_Silo1LevelIndicator_Output_EURange = 46;

        /// <remarks />
        public const uint Silo1Type_Silo1LevelIndicator_Units = 48;

        /// <remarks />
        public const uint Silo1Type_Silo1DischargeValve_Input = 50;

        /// <remarks />
        public const uint Silo1Type_Silo1DischargeValve_Input_EURange = 54;

        /// <remarks />
        public const uint Silo1Type_Silo1DischargeValve_Output = 56;

        /// <remarks />
        public const uint Silo1Type_Silo1DischargeValve_Output_EURange = 60;

        /// <remarks />
        public const uint Silo2Type_Silo2LevelIndicator_Output = 64;

        /// <remarks />
        public const uint Silo2Type_Silo2LevelIndicator_Output_EURange = 68;

        /// <remarks />
        public const uint Silo2Type_Silo2LevelIndicator_Units = 70;

        /// <remarks />
        public const uint Silo2Type_Silo2DischargeValve_Input = 72;

        /// <remarks />
        public const uint Silo2Type_Silo2DischargeValve_Input_EURange = 76;

        /// <remarks />
        public const uint Silo2Type_Silo2DischargeValve_Output = 78;

        /// <remarks />
        public const uint Silo2Type_Silo2DischargeValve_Output_EURange = 82;

        /// <remarks />
        public const uint Silo3Type_Silo3LevelIndicator_Output = 86;

        /// <remarks />
        public const uint Silo3Type_Silo3LevelIndicator_Output_EURange = 90;

        /// <remarks />
        public const uint Silo3Type_Silo3LevelIndicator_Units = 92;

        /// <remarks />
        public const uint Silo3Type_Silo3DischargeValve_Input = 94;

        /// <remarks />
        public const uint Silo3Type_Silo3DischargeValve_Input_EURange = 98;

        /// <remarks />
        public const uint Silo3Type_Silo3DischargeValve_Output = 100;

        /// <remarks />
        public const uint Silo3Type_Silo3DischargeValve_Output_EURange = 104;

        /// <remarks />
        public const uint MixerType_LoadcellTransmitter_Output = 108;

        /// <remarks />
        public const uint MixerType_LoadcellTransmitter_Output_EURange = 112;

        /// <remarks />
        public const uint MixerType_LoadcellTransmitter_Units = 114;

        /// <remarks />
        public const uint MixerType_LoadcellTransmitter_ExcitationVoltage = 115;

        /// <remarks />
        public const uint MixerType_LoadcellTransmitter_ExcitationVoltage_EURange = 119;

        /// <remarks />
        public const uint MixerType_MixerMotor_Speed = 122;

        /// <remarks />
        public const uint MixerType_MixerMotor_Speed_EURange = 126;

        /// <remarks />
        public const uint MixerType_MixerDischargeValve_Input = 129;

        /// <remarks />
        public const uint MixerType_MixerDischargeValve_Input_EURange = 133;

        /// <remarks />
        public const uint MixerType_MixerDischargeValve_Output = 135;

        /// <remarks />
        public const uint MixerType_MixerDischargeValve_Output_EURange = 139;

        /// <remarks />
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Output = 143;

        /// <remarks />
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange = 147;

        /// <remarks />
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Units = 149;

        /// <remarks />
        public const uint ConveyorType_ConveyorMotor_Speed = 152;

        /// <remarks />
        public const uint ConveyorType_ConveyorMotor_Speed_EURange = 156;

        /// <remarks />
        public const uint PumpType_PumpMotor_Speed = 425;

        /// <remarks />
        public const uint PumpType_PumpMotor_Speed_EURange = 429;

        /// <remarks />
        public const uint PumpType_PumpMotor_Temperature = 431;

        /// <remarks />
        public const uint PumpType_PumpMotor_Temperature_EURange = 435;

        /// <remarks />
        public const uint PumpType_State = 437;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator_Output = 161;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange = 165;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator_Units = 167;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Input = 169;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange = 173;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Output = 175;

        /// <remarks />
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange = 179;

        /// <remarks />
        public const uint BatchPlantType_Silo1_DischargeValve_Input = 182;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator_Output = 185;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange = 189;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator_Units = 191;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Input = 193;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange = 197;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Output = 199;

        /// <remarks />
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange = 203;

        /// <remarks />
        public const uint BatchPlantType_Silo2_DischargeValve_Input = 206;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator_Output = 209;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange = 213;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator_Units = 215;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Input = 217;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange = 221;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Output = 223;

        /// <remarks />
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange = 227;

        /// <remarks />
        public const uint BatchPlantType_Silo3_DischargeValve_Input = 230;

        /// <remarks />
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_Output = 233;

        /// <remarks />
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange = 237;

        /// <remarks />
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_Units = 239;

        /// <remarks />
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage = 240;

        /// <remarks />
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = 244;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerMotor_Speed = 247;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerMotor_Speed_EURange = 251;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Input = 254;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Input_EURange = 258;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Output = 260;

        /// <remarks />
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Output_EURange = 264;

        /// <remarks />
        public const uint BatchPlantType_Mixer_DischargeValve_Input = 267;

        /// <remarks />
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output = 270;

        /// <remarks />
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = 274;

        /// <remarks />
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units = 276;

        /// <remarks />
        public const uint BatchPlantType_Conveyor_ConveyorMotor_Speed = 279;

        /// <remarks />
        public const uint BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange = 283;

        /// <remarks />
        public const uint BatchPlantType_Pump_PumpMotor_Speed = 440;

        /// <remarks />
        public const uint BatchPlantType_Pump_PumpMotor_Speed_EURange = 444;

        /// <remarks />
        public const uint BatchPlantType_Pump_PumpMotor_Temperature = 446;

        /// <remarks />
        public const uint BatchPlantType_Pump_PumpMotor_Temperature_EURange = 450;

        /// <remarks />
        public const uint BatchPlantType_Pump_State = 452;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator_Output = 290;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange = 294;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator_Units = 296;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Input = 298;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange = 302;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Output = 304;

        /// <remarks />
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange = 308;

        /// <remarks />
        public const uint BatchPlant1_Silo1_DischargeValve_Input = 311;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator_Output = 314;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange = 318;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator_Units = 320;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Input = 322;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange = 326;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Output = 328;

        /// <remarks />
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange = 332;

        /// <remarks />
        public const uint BatchPlant1_Silo2_DischargeValve_Input = 335;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator_Output = 338;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange = 342;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator_Units = 344;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Input = 346;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange = 350;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Output = 352;

        /// <remarks />
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange = 356;

        /// <remarks />
        public const uint BatchPlant1_Silo3_DischargeValve_Input = 359;

        /// <remarks />
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_Output = 362;

        /// <remarks />
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange = 366;

        /// <remarks />
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_Units = 368;

        /// <remarks />
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage = 369;

        /// <remarks />
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = 373;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerMotor_Speed = 376;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerMotor_Speed_EURange = 380;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Input = 383;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Input_EURange = 387;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Output = 389;

        /// <remarks />
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Output_EURange = 393;

        /// <remarks />
        public const uint BatchPlant1_Mixer_DischargeValve_Input = 396;

        /// <remarks />
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output = 399;

        /// <remarks />
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = 403;

        /// <remarks />
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units = 405;

        /// <remarks />
        public const uint BatchPlant1_Conveyor_ConveyorMotor_Speed = 408;

        /// <remarks />
        public const uint BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange = 412;

        /// <remarks />
        public const uint BatchPlant1_Pump_PumpMotor_Speed = 455;

        /// <remarks />
        public const uint BatchPlant1_Pump_PumpMotor_Speed_EURange = 459;

        /// <remarks />
        public const uint BatchPlant1_Pump_PumpMotor_Temperature = 461;

        /// <remarks />
        public const uint BatchPlant1_Pump_PumpMotor_Temperature_EURange = 465;

        /// <remarks />
        public const uint BatchPlant1_Pump_State = 467;
    }
    #endregion

    #region Method Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_StartProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlantType_StartProcess, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_StopProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlantType_StopProcess, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_StartProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlant1_StartProcess, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_StopProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlant1_StopProcess, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region Object Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.Silo1Type_Silo1LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve = new ExpandedNodeId(BatchPlant.Objects.Silo1Type_Silo1DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.Silo2Type_Silo2LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve = new ExpandedNodeId(BatchPlant.Objects.Silo2Type_Silo2DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.Silo3Type_Silo3LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve = new ExpandedNodeId(BatchPlant.Objects.Silo3Type_Silo3DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter = new ExpandedNodeId(BatchPlant.Objects.MixerType_LoadcellTransmitter, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerMotor = new ExpandedNodeId(BatchPlant.Objects.MixerType_MixerMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve = new ExpandedNodeId(BatchPlant.Objects.MixerType_MixerDischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator = new ExpandedNodeId(BatchPlant.Objects.PackagingUnitType_PackagingUnitLevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_ConveyorMotor = new ExpandedNodeId(BatchPlant.Objects.ConveyorType_ConveyorMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_PumpMotor = new ExpandedNodeId(BatchPlant.Objects.PumpType_PumpMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1 = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1_Silo1LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1_Silo1DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2 = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2_Silo2LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2_Silo2DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3 = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3_Silo3LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3_Silo3DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_LoadcellTransmitter, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_MixerMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_MixerDischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_PackagingUnit, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Conveyor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Conveyor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Conveyor_ConveyorMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Conveyor_ConveyorMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Pump = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Pump, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Pump_PumpMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Pump_PumpMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1_Silo1LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1_Silo1DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2_Silo2LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2_Silo2DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3_Silo3LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3_Silo3DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_LoadcellTransmitter, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_MixerMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_MixerDischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_PackagingUnit, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Conveyor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Conveyor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Conveyor_ConveyorMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Conveyor_ConveyorMotor, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Pump = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Pump, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Pump_PumpMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Pump_PumpMotor, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(BatchPlant.ObjectTypes.GenericSensorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType = new ExpandedNodeId(BatchPlant.ObjectTypes.GenericActuatorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.GenericMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId LevelIndicatorType = new ExpandedNodeId(BatchPlant.ObjectTypes.LevelIndicatorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId LoadcellTransmitterType = new ExpandedNodeId(BatchPlant.ObjectTypes.LoadcellTransmitterType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ValveType = new ExpandedNodeId(BatchPlant.ObjectTypes.ValveType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.MixerMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.ConveyorMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PumpMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.PumpMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type = new ExpandedNodeId(BatchPlant.ObjectTypes.Silo1Type, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type = new ExpandedNodeId(BatchPlant.ObjectTypes.Silo2Type, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type = new ExpandedNodeId(BatchPlant.ObjectTypes.Silo3Type, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType = new ExpandedNodeId(BatchPlant.ObjectTypes.MixerType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PackagingUnitType = new ExpandedNodeId(BatchPlant.ObjectTypes.PackagingUnitType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType = new ExpandedNodeId(BatchPlant.ObjectTypes.ConveyorType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType = new ExpandedNodeId(BatchPlant.ObjectTypes.PumpType, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType = new ExpandedNodeId(BatchPlant.ObjectTypes.BatchPlantType, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region Variable Node Identifiers
    /// <remarks />
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Output = new ExpandedNodeId(BatchPlant.Variables.GenericSensorType_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericSensorType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericSensorType_Units = new ExpandedNodeId(BatchPlant.Variables.GenericSensorType_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Input = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Output = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericActuatorType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Speed = new ExpandedNodeId(BatchPlant.Variables.GenericMotorType_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId GenericMotorType_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericMotorType_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId LoadcellTransmitterType_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.LoadcellTransmitterType_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId LoadcellTransmitterType_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.LoadcellTransmitterType_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PumpMotorType_Temperature = new ExpandedNodeId(BatchPlant.Variables.PumpMotorType_Temperature, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PumpMotorType_Temperature_EURange = new ExpandedNodeId(BatchPlant.Variables.PumpMotorType_Temperature_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_Output = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_Units = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_ConveyorMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.ConveyorType_ConveyorMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId ConveyorType_ConveyorMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.ConveyorType_ConveyorMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_PumpMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.PumpType_PumpMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_PumpMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.PumpType_PumpMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_PumpMotor_Temperature = new ExpandedNodeId(BatchPlant.Variables.PumpType_PumpMotor_Temperature, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_PumpMotor_Temperature_EURange = new ExpandedNodeId(BatchPlant.Variables.PumpType_PumpMotor_Temperature_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId PumpType_State = new ExpandedNodeId(BatchPlant.Variables.PumpType_State, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo1_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo2_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Silo3_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Mixer_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Conveyor_ConveyorMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Conveyor_ConveyorMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Pump_PumpMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Pump_PumpMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Pump_PumpMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Pump_PumpMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Pump_PumpMotor_Temperature = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Pump_PumpMotor_Temperature, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Pump_PumpMotor_Temperature_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Pump_PumpMotor_Temperature_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlantType_Pump_State = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Pump_State, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo1_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo2_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Silo3_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Mixer_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Conveyor_ConveyorMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Conveyor_ConveyorMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Pump_PumpMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Pump_PumpMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Pump_PumpMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Pump_PumpMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Pump_PumpMotor_Temperature = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Pump_PumpMotor_Temperature, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Pump_PumpMotor_Temperature_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Pump_PumpMotor_Temperature_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <remarks />
        public static readonly ExpandedNodeId BatchPlant1_Pump_State = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Pump_State, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region BrowseName Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <remarks />
        public const string BatchPlant1 = "Batch Plant #1";

        /// <remarks />
        public const string BatchPlantType = "BatchPlantType";

        /// <remarks />
        public const string Conveyor = "ConveyorX001";

        /// <remarks />
        public const string ConveyorMotor = "Motor02";

        /// <remarks />
        public const string ConveyorMotorType = "ConveyorMotorType";

        /// <remarks />
        public const string ConveyorType = "ConveyorType";

        /// <remarks />
        public const string ExcitationVoltage = "ExcitationVoltage";

        /// <remarks />
        public const string GenericActuatorType = "GenericActuatorType";

        /// <remarks />
        public const string GenericMotorType = "GenericMotorType";

        /// <remarks />
        public const string GenericSensorType = "GenericSensorType";

        /// <remarks />
        public const string Input = "Input";

        /// <remarks />
        public const string LevelIndicatorType = "LevelIndicatorType";

        /// <remarks />
        public const string LoadcellTransmitter = "LT001";

        /// <remarks />
        public const string LoadcellTransmitterType = "LoadcellTransmitterType";

        /// <remarks />
        public const string Mixer = "MixerX001";

        /// <remarks />
        public const string MixerDischargeValve = "Valve004";

        /// <remarks />
        public const string MixerMotor = "Motor01";

        /// <remarks />
        public const string MixerMotorType = "MixerMotorType";

        /// <remarks />
        public const string MixerType = "MixerType";

        /// <remarks />
        public const string Output = "Output";

        /// <remarks />
        public const string PackagingUnit = "PackagingUnitX001";

        /// <remarks />
        public const string PackagingUnitLevelIndicator = "LI004";

        /// <remarks />
        public const string PackagingUnitType = "PackagingUnitType";

        /// <remarks />
        public const string Pump = "PumpX001";

        /// <remarks />
        public const string PumpMotor = "Motor03";

        /// <remarks />
        public const string PumpMotorType = "PumpMotorType";

        /// <remarks />
        public const string PumpType = "PumpType";

        /// <remarks />
        public const string Silo1 = "SiloX001";

        /// <remarks />
        public const string Silo1DischargeValve = "Valve001";

        /// <remarks />
        public const string Silo1LevelIndicator = "LI001";

        /// <remarks />
        public const string Silo1Type = "Silo1Type";

        /// <remarks />
        public const string Silo2 = "SiloX002";

        /// <remarks />
        public const string Silo2DischargeValve = "Valve002";

        /// <remarks />
        public const string Silo2LevelIndicator = "LI002";

        /// <remarks />
        public const string Silo2Type = "Silo2Type";

        /// <remarks />
        public const string Silo3 = "SiloX003";

        /// <remarks />
        public const string Silo3DischargeValve = "Valve003";

        /// <remarks />
        public const string Silo3LevelIndicator = "LI003";

        /// <remarks />
        public const string Silo3Type = "Silo3Type";

        /// <remarks />
        public const string Speed = "Speed";

        /// <remarks />
        public const string StartProcess = "StartProcess";

        /// <remarks />
        public const string State = "State";

        /// <remarks />
        public const string StopProcess = "StopProcess";

        /// <remarks />
        public const string Temperature = "Temperature";

        /// <remarks />
        public const string Units = "Units";

        /// <remarks />
        public const string ValveType = "ValveType";
    }
    #endregion

    #region Namespace Declarations
    /// <remarks />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the BatchPlant namespace (.NET code namespace is 'BatchPlant').
        /// </summary>
        public const string BatchPlant = "http://opcfoundation.org/BatchPlant";
    }
    #endregion
}