/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
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
    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the BatchPlantType_StartProcess Method.
        /// </summary>
        public const uint BatchPlantType_StartProcess = 323;

        /// <summary>
        /// The identifier for the BatchPlantType_StopProcess Method.
        /// </summary>
        public const uint BatchPlantType_StopProcess = 324;

        /// <summary>
        /// The identifier for the BatchPlant1_StartProcess Method.
        /// </summary>
        public const uint BatchPlant1_StartProcess = 452;

        /// <summary>
        /// The identifier for the BatchPlant1_StopProcess Method.
        /// </summary>
        public const uint BatchPlant1_StopProcess = 453;
    }
    #endregion

    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator Object.
        /// </summary>
        public const uint Silo1Type_Silo1LevelIndicator = 79;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve Object.
        /// </summary>
        public const uint Silo1Type_Silo1DischargeValve = 87;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator Object.
        /// </summary>
        public const uint Silo2Type_Silo2LevelIndicator = 101;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve Object.
        /// </summary>
        public const uint Silo2Type_Silo2DischargeValve = 109;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator Object.
        /// </summary>
        public const uint Silo3Type_Silo3LevelIndicator = 123;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve Object.
        /// </summary>
        public const uint Silo3Type_Silo3DischargeValve = 131;

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter Object.
        /// </summary>
        public const uint MixerType_LoadcellTransmitter = 145;

        /// <summary>
        /// The identifier for the MixerType_MixerMotor Object.
        /// </summary>
        public const uint MixerType_MixerMotor = 159;

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve Object.
        /// </summary>
        public const uint MixerType_MixerDischargeValve = 166;

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator Object.
        /// </summary>
        public const uint PackagingUnitType_PackagingUnitLevelIndicator = 180;

        /// <summary>
        /// The identifier for the ConveyorType_ConveyorMotor Object.
        /// </summary>
        public const uint ConveyorType_ConveyorMotor = 189;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1 Object.
        /// </summary>
        public const uint BatchPlantType_Silo1 = 197;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator Object.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator = 198;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1DischargeValve = 206;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Silo1_DischargeValve = 219;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2 Object.
        /// </summary>
        public const uint BatchPlantType_Silo2 = 221;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator Object.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator = 222;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2DischargeValve = 230;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Silo2_DischargeValve = 243;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3 Object.
        /// </summary>
        public const uint BatchPlantType_Silo3 = 245;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator Object.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator = 246;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3DischargeValve = 254;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Silo3_DischargeValve = 267;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer Object.
        /// </summary>
        public const uint BatchPlantType_Mixer = 269;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter Object.
        /// </summary>
        public const uint BatchPlantType_Mixer_LoadcellTransmitter = 270;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerMotor Object.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerMotor = 284;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerDischargeValve = 291;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_DischargeValve Object.
        /// </summary>
        public const uint BatchPlantType_Mixer_DischargeValve = 304;

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit Object.
        /// </summary>
        public const uint BatchPlantType_PackagingUnit = 306;

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator Object.
        /// </summary>
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator = 307;

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor Object.
        /// </summary>
        public const uint BatchPlantType_Conveyor = 315;

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor_ConveyorMotor Object.
        /// </summary>
        public const uint BatchPlantType_Conveyor_ConveyorMotor = 316;

        /// <summary>
        /// The identifier for the BatchPlant1 Object.
        /// </summary>
        public const uint BatchPlant1 = 325;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1 Object.
        /// </summary>
        public const uint BatchPlant1_Silo1 = 326;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator Object.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator = 327;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1DischargeValve = 335;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Silo1_DischargeValve = 348;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2 Object.
        /// </summary>
        public const uint BatchPlant1_Silo2 = 350;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator Object.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator = 351;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2DischargeValve = 359;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Silo2_DischargeValve = 372;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3 Object.
        /// </summary>
        public const uint BatchPlant1_Silo3 = 374;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator Object.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator = 375;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3DischargeValve = 383;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Silo3_DischargeValve = 396;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer Object.
        /// </summary>
        public const uint BatchPlant1_Mixer = 398;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter Object.
        /// </summary>
        public const uint BatchPlant1_Mixer_LoadcellTransmitter = 399;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerMotor Object.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerMotor = 413;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerDischargeValve = 420;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_DischargeValve Object.
        /// </summary>
        public const uint BatchPlant1_Mixer_DischargeValve = 433;

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit Object.
        /// </summary>
        public const uint BatchPlant1_PackagingUnit = 435;

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator Object.
        /// </summary>
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator = 436;

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor Object.
        /// </summary>
        public const uint BatchPlant1_Conveyor = 444;

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor_ConveyorMotor Object.
        /// </summary>
        public const uint BatchPlant1_Conveyor_ConveyorMotor = 445;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public const uint GenericSensorType = 1;

        /// <summary>
        /// The identifier for the GenericActuatorType ObjectType.
        /// </summary>
        public const uint GenericActuatorType = 9;

        /// <summary>
        /// The identifier for the GenericMotorType ObjectType.
        /// </summary>
        public const uint GenericMotorType = 22;

        /// <summary>
        /// The identifier for the LevelIndicatorType ObjectType.
        /// </summary>
        public const uint LevelIndicatorType = 29;

        /// <summary>
        /// The identifier for the LoadcellTransmitterType ObjectType.
        /// </summary>
        public const uint LoadcellTransmitterType = 37;

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public const uint ValveType = 51;

        /// <summary>
        /// The identifier for the MixerMotorType ObjectType.
        /// </summary>
        public const uint MixerMotorType = 64;

        /// <summary>
        /// The identifier for the ConveyorMotorType ObjectType.
        /// </summary>
        public const uint ConveyorMotorType = 71;

        /// <summary>
        /// The identifier for the Silo1Type ObjectType.
        /// </summary>
        public const uint Silo1Type = 78;

        /// <summary>
        /// The identifier for the Silo2Type ObjectType.
        /// </summary>
        public const uint Silo2Type = 100;

        /// <summary>
        /// The identifier for the Silo3Type ObjectType.
        /// </summary>
        public const uint Silo3Type = 122;

        /// <summary>
        /// The identifier for the MixerType ObjectType.
        /// </summary>
        public const uint MixerType = 144;

        /// <summary>
        /// The identifier for the PackagingUnitType ObjectType.
        /// </summary>
        public const uint PackagingUnitType = 179;

        /// <summary>
        /// The identifier for the ConveyorType ObjectType.
        /// </summary>
        public const uint ConveyorType = 188;

        /// <summary>
        /// The identifier for the BatchPlantType ObjectType.
        /// </summary>
        public const uint BatchPlantType = 196;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the GenericSensorType_Output Variable.
        /// </summary>
        public const uint GenericSensorType_Output = 2;

        /// <summary>
        /// The identifier for the GenericSensorType_Output_EURange Variable.
        /// </summary>
        public const uint GenericSensorType_Output_EURange = 6;

        /// <summary>
        /// The identifier for the GenericSensorType_Units Variable.
        /// </summary>
        public const uint GenericSensorType_Units = 8;

        /// <summary>
        /// The identifier for the GenericActuatorType_Input Variable.
        /// </summary>
        public const uint GenericActuatorType_Input = 10;

        /// <summary>
        /// The identifier for the GenericActuatorType_Input_EURange Variable.
        /// </summary>
        public const uint GenericActuatorType_Input_EURange = 14;

        /// <summary>
        /// The identifier for the GenericActuatorType_Output Variable.
        /// </summary>
        public const uint GenericActuatorType_Output = 16;

        /// <summary>
        /// The identifier for the GenericActuatorType_Output_EURange Variable.
        /// </summary>
        public const uint GenericActuatorType_Output_EURange = 20;

        /// <summary>
        /// The identifier for the GenericMotorType_Speed Variable.
        /// </summary>
        public const uint GenericMotorType_Speed = 23;

        /// <summary>
        /// The identifier for the GenericMotorType_Speed_EURange Variable.
        /// </summary>
        public const uint GenericMotorType_Speed_EURange = 27;

        /// <summary>
        /// The identifier for the LevelIndicatorType_Output_EURange Variable.
        /// </summary>
        public const uint LevelIndicatorType_Output_EURange = 34;

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_Output_EURange Variable.
        /// </summary>
        public const uint LoadcellTransmitterType_Output_EURange = 42;

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_ExcitationVoltage Variable.
        /// </summary>
        public const uint LoadcellTransmitterType_ExcitationVoltage = 45;

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_ExcitationVoltage_EURange Variable.
        /// </summary>
        public const uint LoadcellTransmitterType_ExcitationVoltage_EURange = 49;

        /// <summary>
        /// The identifier for the ValveType_Input_EURange Variable.
        /// </summary>
        public const uint ValveType_Input_EURange = 56;

        /// <summary>
        /// The identifier for the ValveType_Output_EURange Variable.
        /// </summary>
        public const uint ValveType_Output_EURange = 62;

        /// <summary>
        /// The identifier for the MixerMotorType_Speed_EURange Variable.
        /// </summary>
        public const uint MixerMotorType_Speed_EURange = 69;

        /// <summary>
        /// The identifier for the ConveyorMotorType_Speed_EURange Variable.
        /// </summary>
        public const uint ConveyorMotorType_Speed_EURange = 76;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator_Output Variable.
        /// </summary>
        public const uint Silo1Type_Silo1LevelIndicator_Output = 80;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint Silo1Type_Silo1LevelIndicator_Output_EURange = 84;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator_Units Variable.
        /// </summary>
        public const uint Silo1Type_Silo1LevelIndicator_Units = 86;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Input Variable.
        /// </summary>
        public const uint Silo1Type_Silo1DischargeValve_Input = 88;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint Silo1Type_Silo1DischargeValve_Input_EURange = 92;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Output Variable.
        /// </summary>
        public const uint Silo1Type_Silo1DischargeValve_Output = 94;

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint Silo1Type_Silo1DischargeValve_Output_EURange = 98;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator_Output Variable.
        /// </summary>
        public const uint Silo2Type_Silo2LevelIndicator_Output = 102;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint Silo2Type_Silo2LevelIndicator_Output_EURange = 106;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator_Units Variable.
        /// </summary>
        public const uint Silo2Type_Silo2LevelIndicator_Units = 108;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Input Variable.
        /// </summary>
        public const uint Silo2Type_Silo2DischargeValve_Input = 110;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint Silo2Type_Silo2DischargeValve_Input_EURange = 114;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Output Variable.
        /// </summary>
        public const uint Silo2Type_Silo2DischargeValve_Output = 116;

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint Silo2Type_Silo2DischargeValve_Output_EURange = 120;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator_Output Variable.
        /// </summary>
        public const uint Silo3Type_Silo3LevelIndicator_Output = 124;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint Silo3Type_Silo3LevelIndicator_Output_EURange = 128;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator_Units Variable.
        /// </summary>
        public const uint Silo3Type_Silo3LevelIndicator_Units = 130;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Input Variable.
        /// </summary>
        public const uint Silo3Type_Silo3DischargeValve_Input = 132;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint Silo3Type_Silo3DischargeValve_Input_EURange = 136;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Output Variable.
        /// </summary>
        public const uint Silo3Type_Silo3DischargeValve_Output = 138;

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint Silo3Type_Silo3DischargeValve_Output_EURange = 142;

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_Output Variable.
        /// </summary>
        public const uint MixerType_LoadcellTransmitter_Output = 146;

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_Output_EURange Variable.
        /// </summary>
        public const uint MixerType_LoadcellTransmitter_Output_EURange = 150;

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_Units Variable.
        /// </summary>
        public const uint MixerType_LoadcellTransmitter_Units = 152;

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_ExcitationVoltage Variable.
        /// </summary>
        public const uint MixerType_LoadcellTransmitter_ExcitationVoltage = 153;

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_ExcitationVoltage_EURange Variable.
        /// </summary>
        public const uint MixerType_LoadcellTransmitter_ExcitationVoltage_EURange = 157;

        /// <summary>
        /// The identifier for the MixerType_MixerMotor_Speed Variable.
        /// </summary>
        public const uint MixerType_MixerMotor_Speed = 160;

        /// <summary>
        /// The identifier for the MixerType_MixerMotor_Speed_EURange Variable.
        /// </summary>
        public const uint MixerType_MixerMotor_Speed_EURange = 164;

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Input Variable.
        /// </summary>
        public const uint MixerType_MixerDischargeValve_Input = 167;

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint MixerType_MixerDischargeValve_Input_EURange = 171;

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Output Variable.
        /// </summary>
        public const uint MixerType_MixerDischargeValve_Output = 173;

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint MixerType_MixerDischargeValve_Output_EURange = 177;

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Output = 181;

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange = 185;

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public const uint PackagingUnitType_PackagingUnitLevelIndicator_Units = 187;

        /// <summary>
        /// The identifier for the ConveyorType_ConveyorMotor_Speed Variable.
        /// </summary>
        public const uint ConveyorType_ConveyorMotor_Speed = 190;

        /// <summary>
        /// The identifier for the ConveyorType_ConveyorMotor_Speed_EURange Variable.
        /// </summary>
        public const uint ConveyorType_ConveyorMotor_Speed_EURange = 194;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator_Output = 199;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange = 203;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1LevelIndicator_Units = 205;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Input = 207;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange = 211;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Output = 213;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange = 217;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Silo1_DischargeValve_Input = 220;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator_Output = 223;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange = 227;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2LevelIndicator_Units = 229;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Input = 231;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange = 235;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Output = 237;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange = 241;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Silo2_DischargeValve_Input = 244;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator_Output = 247;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange = 251;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3LevelIndicator_Units = 253;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Input = 255;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange = 259;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Output = 261;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange = 265;

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Silo3_DischargeValve_Input = 268;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_Output = 271;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange = 275;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_Units Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_Units = 277;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage = 278;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = 282;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerMotor_Speed Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerMotor_Speed = 285;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerMotor_Speed_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerMotor_Speed_EURange = 289;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Input = 292;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Input_EURange = 296;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Output = 298;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_MixerDischargeValve_Output_EURange = 302;

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlantType_Mixer_DischargeValve_Input = 305;

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output = 308;

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = 312;

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units = 314;

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor_ConveyorMotor_Speed Variable.
        /// </summary>
        public const uint BatchPlantType_Conveyor_ConveyorMotor_Speed = 317;

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange Variable.
        /// </summary>
        public const uint BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange = 321;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator_Output = 328;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange = 332;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1LevelIndicator_Units = 334;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Input = 336;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange = 340;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Output = 342;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange = 346;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Silo1_DischargeValve_Input = 349;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator_Output = 352;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange = 356;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2LevelIndicator_Units = 358;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Input = 360;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange = 364;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Output = 366;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange = 370;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Silo2_DischargeValve_Input = 373;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator_Output = 376;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange = 380;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3LevelIndicator_Units = 382;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Input = 384;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange = 388;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Output = 390;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange = 394;

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Silo3_DischargeValve_Input = 397;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_Output = 400;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange = 404;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_Units Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_Units = 406;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage = 407;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = 411;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerMotor_Speed Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerMotor_Speed = 414;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerMotor_Speed_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerMotor_Speed_EURange = 418;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Input = 421;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Input_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Input_EURange = 425;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Output Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Output = 427;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_MixerDischargeValve_Output_EURange = 431;

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_DischargeValve_Input Variable.
        /// </summary>
        public const uint BatchPlant1_Mixer_DischargeValve_Input = 434;

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output = 437;

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = 441;

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public const uint BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units = 443;

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor_ConveyorMotor_Speed Variable.
        /// </summary>
        public const uint BatchPlant1_Conveyor_ConveyorMotor_Speed = 446;

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange Variable.
        /// </summary>
        public const uint BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange = 450;
    }
    #endregion

    #region Method Node Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class MethodIds
    {
        /// <summary>
        /// The identifier for the BatchPlantType_StartProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_StartProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlantType_StartProcess, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_StopProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_StopProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlantType_StopProcess, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_StartProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_StartProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlant1_StartProcess, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_StopProcess Method.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_StopProcess = new ExpandedNodeId(BatchPlant.Methods.BatchPlant1_StopProcess, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.Silo1Type_Silo1LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve = new ExpandedNodeId(BatchPlant.Objects.Silo1Type_Silo1DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.Silo2Type_Silo2LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve = new ExpandedNodeId(BatchPlant.Objects.Silo2Type_Silo2DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.Silo3Type_Silo3LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve = new ExpandedNodeId(BatchPlant.Objects.Silo3Type_Silo3DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter Object.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter = new ExpandedNodeId(BatchPlant.Objects.MixerType_LoadcellTransmitter, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerMotor Object.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerMotor = new ExpandedNodeId(BatchPlant.Objects.MixerType_MixerMotor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve = new ExpandedNodeId(BatchPlant.Objects.MixerType_MixerDischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator = new ExpandedNodeId(BatchPlant.Objects.PackagingUnitType_PackagingUnitLevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ConveyorType_ConveyorMotor Object.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorType_ConveyorMotor = new ExpandedNodeId(BatchPlant.Objects.ConveyorType_ConveyorMotor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1 = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1_Silo1LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1_Silo1DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo1_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2 = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2_Silo2LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2_Silo2DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo2_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3 = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3_Silo3LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3_Silo3DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Silo3_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_LoadcellTransmitter, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerMotor Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_MixerMotor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_MixerDischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Mixer_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_PackagingUnit, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Conveyor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Conveyor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor_ConveyorMotor Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Conveyor_ConveyorMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlantType_Conveyor_ConveyorMotor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1_Silo1LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1_Silo1DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo1_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2_Silo2LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2_Silo2DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo2_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3 Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3 = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3_Silo3LevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3_Silo3DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Silo3_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_LoadcellTransmitter, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerMotor Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_MixerMotor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_MixerDischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_DischargeValve Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_DischargeValve = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Mixer_DischargeValve, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_PackagingUnit, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Conveyor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Conveyor, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor_ConveyorMotor Object.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Conveyor_ConveyorMotor = new ExpandedNodeId(BatchPlant.Objects.BatchPlant1_Conveyor_ConveyorMotor, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the GenericSensorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType = new ExpandedNodeId(BatchPlant.ObjectTypes.GenericSensorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericActuatorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType = new ExpandedNodeId(BatchPlant.ObjectTypes.GenericActuatorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericMotorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.GenericMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the LevelIndicatorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LevelIndicatorType = new ExpandedNodeId(BatchPlant.ObjectTypes.LevelIndicatorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the LoadcellTransmitterType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId LoadcellTransmitterType = new ExpandedNodeId(BatchPlant.ObjectTypes.LoadcellTransmitterType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ValveType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ValveType = new ExpandedNodeId(BatchPlant.ObjectTypes.ValveType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerMotorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MixerMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.MixerMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ConveyorMotorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorMotorType = new ExpandedNodeId(BatchPlant.ObjectTypes.ConveyorMotorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type = new ExpandedNodeId(BatchPlant.ObjectTypes.Silo1Type, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type = new ExpandedNodeId(BatchPlant.ObjectTypes.Silo2Type, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type = new ExpandedNodeId(BatchPlant.ObjectTypes.Silo3Type, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MixerType = new ExpandedNodeId(BatchPlant.ObjectTypes.MixerType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the PackagingUnitType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType = new ExpandedNodeId(BatchPlant.ObjectTypes.PackagingUnitType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ConveyorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorType = new ExpandedNodeId(BatchPlant.ObjectTypes.ConveyorType, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType = new ExpandedNodeId(BatchPlant.ObjectTypes.BatchPlantType, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the GenericSensorType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Output = new ExpandedNodeId(BatchPlant.Variables.GenericSensorType_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericSensorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericSensorType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericSensorType_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericSensorType_Units = new ExpandedNodeId(BatchPlant.Variables.GenericSensorType_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericActuatorType_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Input = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericActuatorType_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericActuatorType_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Output = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericActuatorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericActuatorType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericActuatorType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericMotorType_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericMotorType_Speed = new ExpandedNodeId(BatchPlant.Variables.GenericMotorType_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the GenericMotorType_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericMotorType_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.GenericMotorType_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the LevelIndicatorType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId LevelIndicatorType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.LevelIndicatorType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadcellTransmitterType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.LoadcellTransmitterType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_ExcitationVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadcellTransmitterType_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.LoadcellTransmitterType_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the LoadcellTransmitterType_ExcitationVoltage_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId LoadcellTransmitterType_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.LoadcellTransmitterType_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ValveType_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ValveType_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.ValveType_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ValveType_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ValveType_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.ValveType_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerMotorType_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerMotorType_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerMotorType_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ConveyorMotorType_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorMotorType_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.ConveyorMotorType_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo1Type_Silo1DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo1Type_Silo1DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo1Type_Silo1DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo2Type_Silo2DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo2Type_Silo2DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo2Type_Silo2DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the Silo3Type_Silo3DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Silo3Type_Silo3DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.Silo3Type_Silo3DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_Output = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_Units = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_ExcitationVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_LoadcellTransmitter_ExcitationVoltage_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_LoadcellTransmitter_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_LoadcellTransmitter_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerMotor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerMotor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the MixerType_MixerDischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId MixerType_MixerDischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.MixerType_MixerDischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the PackagingUnitType_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId PackagingUnitType_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.PackagingUnitType_PackagingUnitLevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ConveyorType_ConveyorMotor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorType_ConveyorMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.ConveyorType_ConveyorMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the ConveyorType_ConveyorMotor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId ConveyorType_ConveyorMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.ConveyorType_ConveyorMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_Silo1DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo1_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo1_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo1_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_Silo2DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo2_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo2_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo2_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_Silo3DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Silo3_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Silo3_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Silo3_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerMotor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerMotor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_MixerDischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_MixerDischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_MixerDischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Mixer_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Mixer_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Mixer_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_PackagingUnit_PackagingUnitLevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor_ConveyorMotor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Conveyor_ConveyorMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Conveyor_ConveyorMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlantType_Conveyor_ConveyorMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_Silo1DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo1_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo1_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo1_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_Silo2DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo2_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo2_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo2_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3LevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3LevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3LevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3LevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3LevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_Silo3DischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Silo3_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Silo3_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Silo3_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_LoadcellTransmitter_ExcitationVoltage_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerMotor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerMotor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Input_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Input_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Input_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_MixerDischargeValve_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_MixerDischargeValve_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_MixerDischargeValve_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Mixer_DischargeValve_Input Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Mixer_DischargeValve_Input = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Mixer_DischargeValve_Input, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Output_EURange, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_PackagingUnit_PackagingUnitLevelIndicator_Units, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor_ConveyorMotor_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Conveyor_ConveyorMotor_Speed = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Conveyor_ConveyorMotor_Speed, BatchPlant.Namespaces.BatchPlant);

        /// <summary>
        /// The identifier for the BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange = new ExpandedNodeId(BatchPlant.Variables.BatchPlant1_Conveyor_ConveyorMotor_Speed_EURange, BatchPlant.Namespaces.BatchPlant);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the BatchPlant1 component.
        /// </summary>
        public const string BatchPlant1 = "Batch Plant #1";

        /// <summary>
        /// The BrowseName for the BatchPlantType component.
        /// </summary>
        public const string BatchPlantType = "BatchPlantType";

        /// <summary>
        /// The BrowseName for the Conveyor component.
        /// </summary>
        public const string Conveyor = "ConveyorX001";

        /// <summary>
        /// The BrowseName for the ConveyorMotor component.
        /// </summary>
        public const string ConveyorMotor = "Motor02";

        /// <summary>
        /// The BrowseName for the ConveyorMotorType component.
        /// </summary>
        public const string ConveyorMotorType = "ConveyorMotorType";

        /// <summary>
        /// The BrowseName for the ConveyorType component.
        /// </summary>
        public const string ConveyorType = "ConveyorType";

        /// <summary>
        /// The BrowseName for the ExcitationVoltage component.
        /// </summary>
        public const string ExcitationVoltage = "ExcitationVoltage";

        /// <summary>
        /// The BrowseName for the GenericActuatorType component.
        /// </summary>
        public const string GenericActuatorType = "GenericActuatorType";

        /// <summary>
        /// The BrowseName for the GenericMotorType component.
        /// </summary>
        public const string GenericMotorType = "GenericMotorType";

        /// <summary>
        /// The BrowseName for the GenericSensorType component.
        /// </summary>
        public const string GenericSensorType = "GenericSensorType";

        /// <summary>
        /// The BrowseName for the Input component.
        /// </summary>
        public const string Input = "Input";

        /// <summary>
        /// The BrowseName for the LevelIndicatorType component.
        /// </summary>
        public const string LevelIndicatorType = "LevelIndicatorType";

        /// <summary>
        /// The BrowseName for the LoadcellTransmitter component.
        /// </summary>
        public const string LoadcellTransmitter = "LT001";

        /// <summary>
        /// The BrowseName for the LoadcellTransmitterType component.
        /// </summary>
        public const string LoadcellTransmitterType = "LoadcellTransmitterType";

        /// <summary>
        /// The BrowseName for the Mixer component.
        /// </summary>
        public const string Mixer = "MixerX001";

        /// <summary>
        /// The BrowseName for the MixerDischargeValve component.
        /// </summary>
        public const string MixerDischargeValve = "Valve004";

        /// <summary>
        /// The BrowseName for the MixerMotor component.
        /// </summary>
        public const string MixerMotor = "Motor01";

        /// <summary>
        /// The BrowseName for the MixerMotorType component.
        /// </summary>
        public const string MixerMotorType = "MixerMotorType";

        /// <summary>
        /// The BrowseName for the MixerType component.
        /// </summary>
        public const string MixerType = "MixerType";

        /// <summary>
        /// The BrowseName for the Output component.
        /// </summary>
        public const string Output = "Output";

        /// <summary>
        /// The BrowseName for the PackagingUnit component.
        /// </summary>
        public const string PackagingUnit = "PackagingUnitX001";

        /// <summary>
        /// The BrowseName for the PackagingUnitLevelIndicator component.
        /// </summary>
        public const string PackagingUnitLevelIndicator = "LI004";

        /// <summary>
        /// The BrowseName for the PackagingUnitType component.
        /// </summary>
        public const string PackagingUnitType = "PackagingUnitType";

        /// <summary>
        /// The BrowseName for the Silo1 component.
        /// </summary>
        public const string Silo1 = "SiloX001";

        /// <summary>
        /// The BrowseName for the Silo1DischargeValve component.
        /// </summary>
        public const string Silo1DischargeValve = "Valve001";

        /// <summary>
        /// The BrowseName for the Silo1LevelIndicator component.
        /// </summary>
        public const string Silo1LevelIndicator = "LI001";

        /// <summary>
        /// The BrowseName for the Silo1Type component.
        /// </summary>
        public const string Silo1Type = "Silo1Type";

        /// <summary>
        /// The BrowseName for the Silo2 component.
        /// </summary>
        public const string Silo2 = "SiloX002";

        /// <summary>
        /// The BrowseName for the Silo2DischargeValve component.
        /// </summary>
        public const string Silo2DischargeValve = "Valve002";

        /// <summary>
        /// The BrowseName for the Silo2LevelIndicator component.
        /// </summary>
        public const string Silo2LevelIndicator = "LI002";

        /// <summary>
        /// The BrowseName for the Silo2Type component.
        /// </summary>
        public const string Silo2Type = "Silo2Type";

        /// <summary>
        /// The BrowseName for the Silo3 component.
        /// </summary>
        public const string Silo3 = "SiloX003";

        /// <summary>
        /// The BrowseName for the Silo3DischargeValve component.
        /// </summary>
        public const string Silo3DischargeValve = "Valve003";

        /// <summary>
        /// The BrowseName for the Silo3LevelIndicator component.
        /// </summary>
        public const string Silo3LevelIndicator = "LI003";

        /// <summary>
        /// The BrowseName for the Silo3Type component.
        /// </summary>
        public const string Silo3Type = "Silo3Type";

        /// <summary>
        /// The BrowseName for the Speed component.
        /// </summary>
        public const string Speed = "Speed";

        /// <summary>
        /// The BrowseName for the StartProcess component.
        /// </summary>
        public const string StartProcess = "StartProcess";

        /// <summary>
        /// The BrowseName for the StopProcess component.
        /// </summary>
        public const string StopProcess = "StopProcess";

        /// <summary>
        /// The BrowseName for the Units component.
        /// </summary>
        public const string Units = "Units";

        /// <summary>
        /// The BrowseName for the ValveType component.
        /// </summary>
        public const string ValveType = "ValveType";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
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

    #region GenericSensorState Class
    #if (!OPCUA_EXCLUDE_GenericSensorState)
    /// <summary>
    /// Stores an instance of the GenericSensorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericSensorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericSensorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.GenericSensorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
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
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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
    /// <summary>
    /// Stores an instance of the GenericActuatorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericActuatorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericActuatorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.GenericActuatorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
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
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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
    /// <summary>
    /// Stores an instance of the GenericMotorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericMotorState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericMotorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.GenericMotorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
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
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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
    /// <summary>
    /// Stores an instance of the LevelIndicatorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LevelIndicatorState : GenericSensorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LevelIndicatorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.LevelIndicatorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGgAA" +
           "AExldmVsSW5kaWNhdG9yVHlwZUluc3RhbmNlAQEdAAEBHQAdAAAA/////wIAAAAVYIkKAgAAAAEABgAA" +
           "AE91dHB1dAEBHgAALwEAQAkeAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB" +
           "IgAALgBEIgAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBASQAAC4ARCQAAAAA" +
           "DP////8DA/////8AAAAA";
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
    /// <summary>
    /// Stores an instance of the LoadcellTransmitterType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LoadcellTransmitterState : GenericSensorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LoadcellTransmitterState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.LoadcellTransmitterType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAHwAA" +
           "AExvYWRjZWxsVHJhbnNtaXR0ZXJUeXBlSW5zdGFuY2UBASUAAQElACUAAAD/////AwAAABVgiQoCAAAA" +
           "AQAGAAAAT3V0cHV0AQEmAAAvAQBACSYAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJh" +
           "bmdlAQEqAAAuAEQqAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBLAAALgBE" +
           "LAAAAAAM/////wMD/////wAAAAAVYIkKAgAAAAEAEQAAAEV4Y2l0YXRpb25Wb2x0YWdlAQEtAAAvAQBA" +
           "CS0AAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQExAAAuAEQxAAAAAQB0A///" +
           "//8BAf////8AAAAA";
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
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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

    #region ValveState Class
    #if (!OPCUA_EXCLUDE_ValveState)
    /// <summary>
    /// Stores an instance of the ValveType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ValveState : GenericActuatorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ValveState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.ValveType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AFZhbHZlVHlwZUluc3RhbmNlAQEzAAEBMwAzAAAA/////wIAAAAVYIkKAgAAAAEABQAAAElucHV0AQE0" +
           "AAAvAQBACTQAAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQE4AAAuAEQ4AAAA" +
           "AQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAToAAC8BAEAJOgAAAAAL/////wMD" +
           "/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAT4AAC4ARD4AAAABAHQD/////wEB/////wAAAAA=";
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
    /// <summary>
    /// Stores an instance of the MixerMotorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MixerMotorState : GenericMotorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MixerMotorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.MixerMotorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAFgAA" +
           "AE1peGVyTW90b3JUeXBlSW5zdGFuY2UBAUAAAQFAAEAAAAD/////AQAAABVgiQoCAAAAAQAFAAAAU3Bl" +
           "ZWQBAUEAAC8BAEAJQQAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAUUAAC4A" +
           "REUAAAABAHQD/////wEB/////wAAAAA=";
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
    /// <summary>
    /// Stores an instance of the ConveyorMotorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConveyorMotorState : GenericMotorState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConveyorMotorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.ConveyorMotorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGQAA" +
           "AENvbnZleW9yTW90b3JUeXBlSW5zdGFuY2UBAUcAAQFHAEcAAAD/////AQAAABVgiQoCAAAAAQAFAAAA" +
           "U3BlZWQBAUgAAC8BAEAJSAAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAUwA" +
           "AC4AREwAAAABAHQD/////wEB/////wAAAAA=";
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

    #region Silo1State Class
    #if (!OPCUA_EXCLUDE_Silo1State)
    /// <summary>
    /// Stores an instance of the Silo1Type ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Silo1State : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Silo1State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.Silo1Type, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AFNpbG8xVHlwZUluc3RhbmNlAQFOAAEBTgBOAAAAAQAAAAAwAAEBTwACAAAAhGDACgEAAAATAAAAU2ls" +
           "bzFMZXZlbEluZGljYXRvcgEABQAAAExJMDAxAQFPAAAvAQEdAE8AAAABAQAAAAAwAQEBTgACAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAVAAAC8BAEAJUAAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAVQAAC4ARFQAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQFW" +
           "AAAuAERWAAAAAAz/////AwP/////AAAAAIRgwAoBAAAAEwAAAFNpbG8xRGlzY2hhcmdlVmFsdmUBAAgA" +
           "AABWYWx2ZTAwMQEBVwAALwEBMwBXAAAAAf////8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBWAAALwEA" +
           "QAlYAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBXAAALgBEXAAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQFeAAAvAQBACV4AAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQFiAAAuAERiAAAAAQB0A/////8BAf////8AAAAA";
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
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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
    /// <summary>
    /// Stores an instance of the Silo2Type ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Silo2State : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Silo2State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.Silo2Type, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AFNpbG8yVHlwZUluc3RhbmNlAQFkAAEBZABkAAAAAQAAAAAwAAEBZQACAAAAhGDACgEAAAATAAAAU2ls" +
           "bzJMZXZlbEluZGljYXRvcgEABQAAAExJMDAyAQFlAAAvAQEdAGUAAAABAQAAAAAwAQEBZAACAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAWYAAC8BAEAJZgAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAWoAAC4ARGoAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQFs" +
           "AAAuAERsAAAAAAz/////AwP/////AAAAAIRgwAoBAAAAEwAAAFNpbG8yRGlzY2hhcmdlVmFsdmUBAAgA" +
           "AABWYWx2ZTAwMgEBbQAALwEBMwBtAAAAAf////8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBbgAALwEA" +
           "QAluAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBcgAALgBEcgAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQF0AAAvAQBACXQAAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQF4AAAuAER4AAAAAQB0A/////8BAf////8AAAAA";
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
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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
    /// <summary>
    /// Stores an instance of the Silo3Type ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class Silo3State : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public Silo3State(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.Silo3Type, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AFNpbG8zVHlwZUluc3RhbmNlAQF6AAEBegB6AAAAAQAAAAAwAAEBewACAAAAhGDACgEAAAATAAAAU2ls" +
           "bzNMZXZlbEluZGljYXRvcgEABQAAAExJMDAzAQF7AAAvAQEdAHsAAAABAQAAAAAwAQEBegACAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAXwAAC8BAEAJfAAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAYAAAC4ARIAAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQGC" +
           "AAAuAESCAAAAAAz/////AwP/////AAAAAIRgwAoBAAAAEwAAAFNpbG8zRGlzY2hhcmdlVmFsdmUBAAgA" +
           "AABWYWx2ZTAwMwEBgwAALwEBMwCDAAAAAf////8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBhAAALwEA" +
           "QAmEAAAAAAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBiAAALgBEiAAAAAEAdAP/" +
           "////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQGKAAAvAQBACYoAAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGOAAAuAESOAAAAAQB0A/////8BAf////8AAAAA";
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
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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

    #region MixerState Class
    #if (!OPCUA_EXCLUDE_MixerState)
    /// <summary>
    /// Stores an instance of the MixerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MixerState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MixerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.MixerType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAEQAA" +
           "AE1peGVyVHlwZUluc3RhbmNlAQGQAAEBkACQAAAAAQAAAAAwAAEBkQADAAAAhGDACgEAAAATAAAATG9h" +
           "ZGNlbGxUcmFuc21pdHRlcgEABQAAAExUMDAxAQGRAAAvAQElAJEAAAABAQAAAAAwAQEBkAADAAAAFWCJ" +
           "CgIAAAABAAYAAABPdXRwdXQBAZIAAC8BAEAJkgAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAA" +
           "AEVVUmFuZ2UBAZYAAC4ARJYAAAABAHQD/////wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQGY" +
           "AAAuAESYAAAAAAz/////AwP/////AAAAABVgiQoCAAAAAQARAAAARXhjaXRhdGlvblZvbHRhZ2UBAZkA" +
           "AC8BAEAJmQAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAZ0AAC4ARJ0AAAAB" +
           "AHQD/////wEB/////wAAAACEYMAKAQAAAAoAAABNaXhlck1vdG9yAQAHAAAATW90b3IwMQEBnwAALwEB" +
           "QACfAAAAAf////8BAAAAFWCJCgIAAAABAAUAAABTcGVlZAEBoAAALwEAQAmgAAAAAAv/////AwP/////" +
           "AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBpAAALgBEpAAAAAEAdAP/////AQH/////AAAAAIRgwAoB" +
           "AAAAEwAAAE1peGVyRGlzY2hhcmdlVmFsdmUBAAgAAABWYWx2ZTAwNAEBpgAALwEBMwCmAAAAAf////8C" +
           "AAAAFWCJCgIAAAABAAUAAABJbnB1dAEBpwAALwEAQAmnAAAAAAv/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBqwAALgBEqwAAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAAT3V0" +
           "cHV0AQGtAAAvAQBACa0AAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQGxAAAu" +
           "AESxAAAAAQB0A/////8BAf////8AAAAA";
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
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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
    /// <summary>
    /// Stores an instance of the PackagingUnitType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class PackagingUnitState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public PackagingUnitState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.PackagingUnitType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAGQAA" +
           "AFBhY2thZ2luZ1VuaXRUeXBlSW5zdGFuY2UBAbMAAQGzALMAAAABAAAAADAAAQG0AAEAAACEYMAKAQAA" +
           "ABsAAABQYWNrYWdpbmdVbml0TGV2ZWxJbmRpY2F0b3IBAAUAAABMSTAwNAEBtAAALwEBHQC0AAAAAQEA" +
           "AAAAMAEBAbMAAgAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQG1AAAvAQBACbUAAAAAC/////8BAf////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQG5AAAuAES5AAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAUAAABVbml0cwEBuwAALgBEuwAAAAAM/////wMD/////wAAAAA=";
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
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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
    /// <summary>
    /// Stores an instance of the ConveyorType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ConveyorState : FolderState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ConveyorState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.ConveyorType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////8EYIACAQAAAAEAFAAA" +
           "AENvbnZleW9yVHlwZUluc3RhbmNlAQG8AAEBvAC8AAAAAQAAAAAwAAEBvQABAAAAhGDACgEAAAANAAAA" +
           "Q29udmV5b3JNb3RvcgEABwAAAE1vdG9yMDIBAb0AAC8BAUcAvQAAAAEBAAAAADABAQG8AAEAAAAVYIkK" +
           "AgAAAAEABQAAAFNwZWVkAQG+AAAvAQBACb4AAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABF" +
           "VVJhbmdlAQHCAAAuAETCAAAAAQB0A/////8BAf////8AAAAA";
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
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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
    /// <summary>
    /// Stores an instance of the BatchPlantType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BatchPlantState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public BatchPlantState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(BatchPlant.ObjectTypes.BatchPlantType, BatchPlant.Namespaces.BatchPlant, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAACMAAABodHRwOi8vb3BjZm91bmRhdGlvbi5vcmcvQmF0Y2hQbGFudP////+EYIACAQAAAAEAFgAA" +
           "AEJhdGNoUGxhbnRUeXBlSW5zdGFuY2UBAcQAAQHEAMQAAAABBgAAAAAwAAEBxQAAMAABAd0AADAAAQH1" +
           "AAAwAAEBDQEAMAABATIBADAAAQE7AQgAAACEYMAKAQAAAAUAAABTaWxvMQEACAAAAFNpbG9YMDAxAQHF" +
           "AAAvAQFOAMUAAAABAgAAAAAwAQEBxAAAMAABAcYAAwAAAIRgwAoBAAAAEwAAAFNpbG8xTGV2ZWxJbmRp" +
           "Y2F0b3IBAAUAAABMSTAwMQEBxgAALwEBHQDGAAAAAQEAAAAAMAEBAcUAAgAAABVgiQoCAAAAAQAGAAAA" +
           "T3V0cHV0AQHHAAAvAQBACccAAAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHL" +
           "AAAuAETLAAAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAABAAUAAABVbml0cwEBzQAALgBEzQAAAAAM" +
           "/////wMD/////wAAAACEYMAKAQAAABMAAABTaWxvMURpc2NoYXJnZVZhbHZlAQAIAAAAVmFsdmUwMDEB" +
           "Ac4AAC8BATMAzgAAAAH/////AgAAABVgiQoCAAAAAQAFAAAASW5wdXQBAc8AAC8BAEAJzwAAAAAL////" +
           "/wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAdMAAC4ARNMAAAABAHQD/////wEB/////wAA" +
           "AAAVYIkKAgAAAAEABgAAAE91dHB1dAEB1QAALwEAQAnVAAAAAAv/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEB2QAALgBE2QAAAAEAdAP/////AQH/////AAAAAARggAoBAAAAAQAOAAAARGlz" +
           "Y2hhcmdlVmFsdmUBAdsAAC8AOtsAAAD/////AQAAABVgiQoCAAAAAQAFAAAASW5wdXQBAdwAAC8AP9wA" +
           "AAAAGP////8BAf////8AAAAAhGDACgEAAAAFAAAAU2lsbzIBAAgAAABTaWxvWDAwMgEB3QAALwEBZADd" +
           "AAAAAQIAAAAAMAEBAcQAADAAAQHeAAMAAACEYMAKAQAAABMAAABTaWxvMkxldmVsSW5kaWNhdG9yAQAF" +
           "AAAATEkwMDIBAd4AAC8BAR0A3gAAAAEBAAAAADABAQHdAAIAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEB" +
           "3wAALwEAQAnfAAAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEB4wAALgBE4wAA" +
           "AAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBAeUAAC4AROUAAAAADP////8DA///" +
           "//8AAAAAhGDACgEAAAATAAAAU2lsbzJEaXNjaGFyZ2VWYWx2ZQEACAAAAFZhbHZlMDAyAQHmAAAvAQEz" +
           "AOYAAAAB/////wIAAAAVYIkKAgAAAAEABQAAAElucHV0AQHnAAAvAQBACecAAAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQHrAAAuAETrAAAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAABAAYAAABPdXRwdXQBAe0AAC8BAEAJ7QAAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAABwAAAEVV" +
           "UmFuZ2UBAfEAAC4ARPEAAAABAHQD/////wEB/////wAAAAAEYIAKAQAAAAEADgAAAERpc2NoYXJnZVZh" +
           "bHZlAQHzAAAvADrzAAAA/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQH0AAAvAD/0AAAAABj/////" +
           "AQH/////AAAAAIRgwAoBAAAABQAAAFNpbG8zAQAIAAAAU2lsb1gwMDMBAfUAAC8BAXoA9QAAAAECAAAA" +
           "ADABAQHEAAAwAAEB9gADAAAAhGDACgEAAAATAAAAU2lsbzNMZXZlbEluZGljYXRvcgEABQAAAExJMDAz" +
           "AQH2AAAvAQEdAPYAAAABAQAAAAAwAQEB9QACAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBAfcAAC8BAEAJ" +
           "9wAAAAAL/////wEB/////wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAfsAAC4ARPsAAAABAHQD////" +
           "/wEB/////wAAAAAVYIkKAgAAAAEABQAAAFVuaXRzAQH9AAAuAET9AAAAAAz/////AwP/////AAAAAIRg" +
           "wAoBAAAAEwAAAFNpbG8zRGlzY2hhcmdlVmFsdmUBAAgAAABWYWx2ZTAwMwEB/gAALwEBMwD+AAAAAf//" +
           "//8CAAAAFWCJCgIAAAABAAUAAABJbnB1dAEB/wAALwEAQAn/AAAAAAv/////AwP/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQEBAwEALgBEAwEAAAEAdAP/////AQH/////AAAAABVgiQoCAAAAAQAGAAAA" +
           "T3V0cHV0AQEFAQAvAQBACQUBAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEJ" +
           "AQAuAEQJAQAAAQB0A/////8BAf////8AAAAABGCACgEAAAABAA4AAABEaXNjaGFyZ2VWYWx2ZQEBCwEA" +
           "LwA6CwEAAP////8BAAAAFWCJCgIAAAABAAUAAABJbnB1dAEBDAEALwA/DAEAAAAY/////wEB/////wAA" +
           "AACEYMAKAQAAAAUAAABNaXhlcgEACQAAAE1peGVyWDAwMQEBDQEALwEBkAANAQAAAQIAAAAAMAEBAcQA" +
           "ADAAAQEOAQQAAACEYMAKAQAAABMAAABMb2FkY2VsbFRyYW5zbWl0dGVyAQAFAAAATFQwMDEBAQ4BAC8B" +
           "ASUADgEAAAEBAAAAADABAQENAQMAAAAVYIkKAgAAAAEABgAAAE91dHB1dAEBDwEALwEAQAkPAQAAAAv/" +
           "////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQEBEwEALgBEEwEAAAEAdAP/////AQH/////" +
           "AAAAABVgiQoCAAAAAQAFAAAAVW5pdHMBARUBAC4ARBUBAAAADP////8DA/////8AAAAAFWCJCgIAAAAB" +
           "ABEAAABFeGNpdGF0aW9uVm9sdGFnZQEBFgEALwEAQAkWAQAAAAv/////AwP/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQEBGgEALgBEGgEAAAEAdAP/////AQH/////AAAAAIRgwAoBAAAACgAAAE1peGVy" +
           "TW90b3IBAAcAAABNb3RvcjAxAQEcAQAvAQFAABwBAAAB/////wEAAAAVYIkKAgAAAAEABQAAAFNwZWVk" +
           "AQEdAQAvAQBACR0BAAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEhAQAuAEQh" +
           "AQAAAQB0A/////8BAf////8AAAAAhGDACgEAAAATAAAATWl4ZXJEaXNjaGFyZ2VWYWx2ZQEACAAAAFZh" +
           "bHZlMDA0AQEjAQAvAQEzACMBAAAB/////wIAAAAVYIkKAgAAAAEABQAAAElucHV0AQEkAQAvAQBACSQB" +
           "AAAAC/////8DA/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQEoAQAuAEQoAQAAAQB0A/////8B" +
           "Af////8AAAAAFWCJCgIAAAABAAYAAABPdXRwdXQBASoBAC8BAEAJKgEAAAAL/////wMD/////wEAAAAV" +
           "YIkKAgAAAAAABwAAAEVVUmFuZ2UBAS4BAC4ARC4BAAABAHQD/////wEB/////wAAAAAEYIAKAQAAAAEA" +
           "DgAAAERpc2NoYXJnZVZhbHZlAQEwAQAvADowAQAA/////wEAAAAVYIkKAgAAAAEABQAAAElucHV0AQEx" +
           "AQAvAD8xAQAAABj/////AQH/////AAAAAIRgwAoBAAAADQAAAFBhY2thZ2luZ1VuaXQBABEAAABQYWNr" +
           "YWdpbmdVbml0WDAwMQEBMgEALwEBswAyAQAAAQIAAAAAMAEBAcQAADAAAQEzAQEAAACEYMAKAQAAABsA" +
           "AABQYWNrYWdpbmdVbml0TGV2ZWxJbmRpY2F0b3IBAAUAAABMSTAwNAEBMwEALwEBHQAzAQAAAQEAAAAA" +
           "MAEBATIBAgAAABVgiQoCAAAAAQAGAAAAT3V0cHV0AQE0AQAvAQBACTQBAAAAC/////8BAf////8BAAAA" +
           "FWCJCgIAAAAAAAcAAABFVVJhbmdlAQE4AQAuAEQ4AQAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAAB" +
           "AAUAAABVbml0cwEBOgEALgBEOgEAAAAM/////wMD/////wAAAACEYMAKAQAAAAgAAABDb252ZXlvcgEA" +
           "DAAAAENvbnZleW9yWDAwMQEBOwEALwEBvAA7AQAAAQIAAAAAMAEBAcQAADAAAQE8AQEAAACEYMAKAQAA" +
           "AA0AAABDb252ZXlvck1vdG9yAQAHAAAATW90b3IwMgEBPAEALwEBRwA8AQAAAQEAAAAAMAEBATsBAQAA" +
           "ABVgiQoCAAAAAQAFAAAAU3BlZWQBAT0BAC8BAEAJPQEAAAAL/////wMD/////wEAAAAVYIkKAgAAAAAA" +
           "BwAAAEVVUmFuZ2UBAUEBAC4AREEBAAABAHQD/////wEB/////wAAAAAEYYIKBAAAAAEADAAAAFN0YXJ0" +
           "UHJvY2VzcwEBQwEALwEBQwFDAQAAAQH/////AAAAAARhggoEAAAAAQALAAAAU3RvcFByb2Nlc3MBAUQB" +
           "AC8BAUQBRAEAAAEB/////wAAAAA=";
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
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
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

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
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
        private MixerState m_mixer;
        private PackagingUnitState m_packagingUnit;
        private ConveyorState m_conveyor;
        private MethodState m_startProcessMethod;
        private MethodState m_stopProcessMethod;
        #endregion
    }
    #endif
    #endregion
}