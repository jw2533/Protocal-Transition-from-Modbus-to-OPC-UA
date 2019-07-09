/* ========================================================================
 * Copyright (c) 2005-2011 The OPC Foundation, Inc. All rights reserved.
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

namespace TestData
{
    #region DataType Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypes
    {
        /// <summary>
        /// The identifier for the ScalarValueDataType DataType.
        /// </summary>
        public const uint ScalarValueDataType = 11749;

        /// <summary>
        /// The identifier for the ArrayValueDataType DataType.
        /// </summary>
        public const uint ArrayValueDataType = 9669;

        /// <summary>
        /// The identifier for the BooleanDataType DataType.
        /// </summary>
        public const uint BooleanDataType = 9898;

        /// <summary>
        /// The identifier for the SByteDataType DataType.
        /// </summary>
        public const uint SByteDataType = 9899;

        /// <summary>
        /// The identifier for the ByteDataType DataType.
        /// </summary>
        public const uint ByteDataType = 9900;

        /// <summary>
        /// The identifier for the Int16DataType DataType.
        /// </summary>
        public const uint Int16DataType = 9901;

        /// <summary>
        /// The identifier for the UInt16DataType DataType.
        /// </summary>
        public const uint UInt16DataType = 9902;

        /// <summary>
        /// The identifier for the Int32DataType DataType.
        /// </summary>
        public const uint Int32DataType = 9903;

        /// <summary>
        /// The identifier for the UInt32DataType DataType.
        /// </summary>
        public const uint UInt32DataType = 9904;

        /// <summary>
        /// The identifier for the Int64DataType DataType.
        /// </summary>
        public const uint Int64DataType = 9905;

        /// <summary>
        /// The identifier for the UInt64DataType DataType.
        /// </summary>
        public const uint UInt64DataType = 9906;

        /// <summary>
        /// The identifier for the FloatDataType DataType.
        /// </summary>
        public const uint FloatDataType = 9907;

        /// <summary>
        /// The identifier for the DoubleDataType DataType.
        /// </summary>
        public const uint DoubleDataType = 9908;

        /// <summary>
        /// The identifier for the StringDataType DataType.
        /// </summary>
        public const uint StringDataType = 9909;

        /// <summary>
        /// The identifier for the DateTimeDataType DataType.
        /// </summary>
        public const uint DateTimeDataType = 9910;

        /// <summary>
        /// The identifier for the GuidDataType DataType.
        /// </summary>
        public const uint GuidDataType = 9911;

        /// <summary>
        /// The identifier for the ByteStringDataType DataType.
        /// </summary>
        public const uint ByteStringDataType = 9912;

        /// <summary>
        /// The identifier for the XmlElementDataType DataType.
        /// </summary>
        public const uint XmlElementDataType = 9913;

        /// <summary>
        /// The identifier for the NodeIdDataType DataType.
        /// </summary>
        public const uint NodeIdDataType = 9914;

        /// <summary>
        /// The identifier for the ExpandedNodeIdDataType DataType.
        /// </summary>
        public const uint ExpandedNodeIdDataType = 9915;

        /// <summary>
        /// The identifier for the QualifiedNameDataType DataType.
        /// </summary>
        public const uint QualifiedNameDataType = 9916;

        /// <summary>
        /// The identifier for the LocalizedTextDataType DataType.
        /// </summary>
        public const uint LocalizedTextDataType = 9917;

        /// <summary>
        /// The identifier for the StatusCodeDataType DataType.
        /// </summary>
        public const uint StatusCodeDataType = 9918;

        /// <summary>
        /// The identifier for the VariantDataType DataType.
        /// </summary>
        public const uint VariantDataType = 9919;

        /// <summary>
        /// The identifier for the UserScalarValueDataType DataType.
        /// </summary>
        public const uint UserScalarValueDataType = 9920;

        /// <summary>
        /// The identifier for the UserArrayValueDataType DataType.
        /// </summary>
        public const uint UserArrayValueDataType = 10006;
    }
    #endregion

    #region Method Identifiers
    /// <summary>
    /// A class that declares constants for all Methods in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Methods
    {
        /// <summary>
        /// The identifier for the TestDataObjectType_GenerateValues Method.
        /// </summary>
        public const uint TestDataObjectType_GenerateValues = 9385;

        /// <summary>
        /// The identifier for the TestDataObjectType_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint TestDataObjectType_CycleComplete_Acknowledge = 9436;

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod1 Method.
        /// </summary>
        public const uint MethodTestType_ScalarMethod1 = 10093;

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod2 Method.
        /// </summary>
        public const uint MethodTestType_ScalarMethod2 = 10096;

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod3 Method.
        /// </summary>
        public const uint MethodTestType_ScalarMethod3 = 10099;

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod1 Method.
        /// </summary>
        public const uint MethodTestType_ArrayMethod1 = 10102;

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod2 Method.
        /// </summary>
        public const uint MethodTestType_ArrayMethod2 = 10105;

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod3 Method.
        /// </summary>
        public const uint MethodTestType_ArrayMethod3 = 10108;

        /// <summary>
        /// The identifier for the MethodTestType_UserScalarMethod1 Method.
        /// </summary>
        public const uint MethodTestType_UserScalarMethod1 = 10111;

        /// <summary>
        /// The identifier for the MethodTestType_UserScalarMethod2 Method.
        /// </summary>
        public const uint MethodTestType_UserScalarMethod2 = 10114;

        /// <summary>
        /// The identifier for the MethodTestType_UserArrayMethod1 Method.
        /// </summary>
        public const uint MethodTestType_UserArrayMethod1 = 10117;

        /// <summary>
        /// The identifier for the MethodTestType_UserArrayMethod2 Method.
        /// </summary>
        public const uint MethodTestType_UserArrayMethod2 = 10120;
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
        /// The identifier for the TestDataObjectType_CycleComplete Object.
        /// </summary>
        public const uint TestDataObjectType_CycleComplete = 9387;

        /// <summary>
        /// The identifier for the Data Object.
        /// </summary>
        public const uint Data = 10157;

        /// <summary>
        /// The identifier for the Data_MyData1 Object.
        /// </summary>
        public const uint Data_MyData1 = 12893;

        /// <summary>
        /// The identifier for the Data_MyData2 Object.
        /// </summary>
        public const uint Data_MyData2 = 12900;

        /// <summary>
        /// The identifier for the ScalarValueDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ScalarValueDataType_Encoding_DefaultXml = 11992;

        /// <summary>
        /// The identifier for the ArrayValueDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint ArrayValueDataType_Encoding_DefaultXml = 11419;

        /// <summary>
        /// The identifier for the UserScalarValueDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint UserScalarValueDataType_Encoding_DefaultXml = 11420;

        /// <summary>
        /// The identifier for the UserArrayValueDataType_Encoding_DefaultXml Object.
        /// </summary>
        public const uint UserArrayValueDataType_Encoding_DefaultXml = 11421;

        /// <summary>
        /// The identifier for the ScalarValueDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ScalarValueDataType_Encoding_DefaultBinary = 11996;

        /// <summary>
        /// The identifier for the ArrayValueDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint ArrayValueDataType_Encoding_DefaultBinary = 11438;

        /// <summary>
        /// The identifier for the UserScalarValueDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint UserScalarValueDataType_Encoding_DefaultBinary = 11439;

        /// <summary>
        /// The identifier for the UserArrayValueDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public const uint UserArrayValueDataType_Encoding_DefaultBinary = 11440;
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
        /// The identifier for the GenerateValuesEventType ObjectType.
        /// </summary>
        public const uint GenerateValuesEventType = 9371;

        /// <summary>
        /// The identifier for the TestDataObjectType ObjectType.
        /// </summary>
        public const uint TestDataObjectType = 9383;

        /// <summary>
        /// The identifier for the ScalarValueObjectType ObjectType.
        /// </summary>
        public const uint ScalarValueObjectType = 9450;

        /// <summary>
        /// The identifier for the MyObjectType ObjectType.
        /// </summary>
        public const uint MyObjectType = 11674;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType ObjectType.
        /// </summary>
        public const uint AnalogScalarValueObjectType = 9534;

        /// <summary>
        /// The identifier for the ArrayValueObjectType ObjectType.
        /// </summary>
        public const uint ArrayValueObjectType = 9679;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType ObjectType.
        /// </summary>
        public const uint AnalogArrayValueObjectType = 9763;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType ObjectType.
        /// </summary>
        public const uint UserScalarValueObjectType = 9921;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType ObjectType.
        /// </summary>
        public const uint UserArrayValueObjectType = 10007;

        /// <summary>
        /// The identifier for the MethodTestType ObjectType.
        /// </summary>
        public const uint MethodTestType = 10092;

        /// <summary>
        /// The identifier for the TestSystemConditionType ObjectType.
        /// </summary>
        public const uint TestSystemConditionType = 10123;
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
        /// The identifier for the GenerateValuesEventType_Iterations Variable.
        /// </summary>
        public const uint GenerateValuesEventType_Iterations = 9381;

        /// <summary>
        /// The identifier for the GenerateValuesEventType_NewValueCount Variable.
        /// </summary>
        public const uint GenerateValuesEventType_NewValueCount = 9382;

        /// <summary>
        /// The identifier for the TestDataObjectType_SimulationActive Variable.
        /// </summary>
        public const uint TestDataObjectType_SimulationActive = 9384;

        /// <summary>
        /// The identifier for the TestDataObjectType_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint TestDataObjectType_GenerateValues_InputArguments = 9386;

        /// <summary>
        /// The identifier for the TestDataObjectType_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint TestDataObjectType_CycleComplete_AckedState = 9420;

        /// <summary>
        /// The identifier for the TestDataObjectType_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint TestDataObjectType_CycleComplete_Acknowledge_InputArguments = 9437;

        /// <summary>
        /// The identifier for the TestDataObjectType_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint TestDataObjectType_CycleComplete_Confirm_InputArguments = 9439;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_BooleanValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_BooleanValue = 11647;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_SByteValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_SByteValue = 11648;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_ByteValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_ByteValue = 11649;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_Int16Value Variable.
        /// </summary>
        public const uint ScalarValueObjectType_Int16Value = 11650;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_UInt16Value Variable.
        /// </summary>
        public const uint ScalarValueObjectType_UInt16Value = 11651;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_Int32Value Variable.
        /// </summary>
        public const uint ScalarValueObjectType_Int32Value = 11652;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_UInt32Value Variable.
        /// </summary>
        public const uint ScalarValueObjectType_UInt32Value = 11653;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_Int64Value Variable.
        /// </summary>
        public const uint ScalarValueObjectType_Int64Value = 11654;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_UInt64Value Variable.
        /// </summary>
        public const uint ScalarValueObjectType_UInt64Value = 11655;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_FloatValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_FloatValue = 11656;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_DoubleValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_DoubleValue = 11657;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_StringValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_StringValue = 11658;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_DateTimeValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_DateTimeValue = 11659;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_GuidValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_GuidValue = 11660;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_ByteStringValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_ByteStringValue = 11661;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_XmlElementValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_XmlElementValue = 11662;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_NodeIdValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_NodeIdValue = 11663;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_ExpandedNodeIdValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_ExpandedNodeIdValue = 11664;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_QualifiedNameValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_QualifiedNameValue = 11665;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_LocalizedTextValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_LocalizedTextValue = 11666;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_StatusCodeValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_StatusCodeValue = 11667;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_VariantValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_VariantValue = 11668;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_EnumerationValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_EnumerationValue = 11669;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_StructureValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_StructureValue = 11670;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_NumberValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_NumberValue = 11671;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_IntegerValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_IntegerValue = 11672;

        /// <summary>
        /// The identifier for the ScalarValueObjectType_UIntegerValue Variable.
        /// </summary>
        public const uint ScalarValueObjectType_UIntegerValue = 11673;

        /// <summary>
        /// The identifier for the MyObjectType_MyValue1 Variable.
        /// </summary>
        public const uint MyObjectType_MyValue1 = 12887;

        /// <summary>
        /// The identifier for the MyObjectType_MyValue1_Class Variable.
        /// </summary>
        public const uint MyObjectType_MyValue1_Class = 12888;

        /// <summary>
        /// The identifier for the MyObjectType_MyValue1_Place Variable.
        /// </summary>
        public const uint MyObjectType_MyValue1_Place = 12889;

        /// <summary>
        /// The identifier for the MyObjectType_MyValue2 Variable.
        /// </summary>
        public const uint MyObjectType_MyValue2 = 12890;

        /// <summary>
        /// The identifier for the MyObjectType_MyValue2_Class Variable.
        /// </summary>
        public const uint MyObjectType_MyValue2_Class = 12891;

        /// <summary>
        /// The identifier for the MyObjectType_MyValue2_Place Variable.
        /// </summary>
        public const uint MyObjectType_MyValue2_Place = 12892;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_SByteValue Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_SByteValue = 9591;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_SByteValue_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_SByteValue_EURange = 9594;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_ByteValue Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_ByteValue = 9597;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_ByteValue_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_ByteValue_EURange = 9600;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_Int16Value Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_Int16Value = 9603;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_Int16Value_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_Int16Value_EURange = 9606;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UInt16Value Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_UInt16Value = 9609;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UInt16Value_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_UInt16Value_EURange = 9612;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_Int32Value Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_Int32Value = 9615;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_Int32Value_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_Int32Value_EURange = 9618;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UInt32Value Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_UInt32Value = 9621;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UInt32Value_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_UInt32Value_EURange = 9624;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_Int64Value Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_Int64Value = 9627;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_Int64Value_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_Int64Value_EURange = 9630;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UInt64Value Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_UInt64Value = 9633;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UInt64Value_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_UInt64Value_EURange = 9636;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_FloatValue Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_FloatValue = 9639;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_FloatValue_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_FloatValue_EURange = 9642;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_DoubleValue Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_DoubleValue = 9645;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_DoubleValue_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_DoubleValue_EURange = 9648;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_NumberValue Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_NumberValue = 9651;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_NumberValue_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_NumberValue_EURange = 9654;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_IntegerValue Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_IntegerValue = 9657;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_IntegerValue_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_IntegerValue_EURange = 9660;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UIntegerValue Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_UIntegerValue = 9663;

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UIntegerValue_EURange Variable.
        /// </summary>
        public const uint AnalogScalarValueObjectType_UIntegerValue_EURange = 9666;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_BooleanValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_BooleanValue = 9736;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_SByteValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_SByteValue = 9737;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_ByteValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_ByteValue = 9738;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_Int16Value Variable.
        /// </summary>
        public const uint ArrayValueObjectType_Int16Value = 9739;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_UInt16Value Variable.
        /// </summary>
        public const uint ArrayValueObjectType_UInt16Value = 9740;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_Int32Value Variable.
        /// </summary>
        public const uint ArrayValueObjectType_Int32Value = 9741;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_UInt32Value Variable.
        /// </summary>
        public const uint ArrayValueObjectType_UInt32Value = 9742;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_Int64Value Variable.
        /// </summary>
        public const uint ArrayValueObjectType_Int64Value = 9743;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_UInt64Value Variable.
        /// </summary>
        public const uint ArrayValueObjectType_UInt64Value = 9744;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_FloatValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_FloatValue = 9745;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_DoubleValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_DoubleValue = 9746;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_StringValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_StringValue = 9747;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_DateTimeValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_DateTimeValue = 9748;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_GuidValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_GuidValue = 9749;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_ByteStringValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_ByteStringValue = 9750;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_XmlElementValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_XmlElementValue = 9751;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_NodeIdValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_NodeIdValue = 9752;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_ExpandedNodeIdValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_ExpandedNodeIdValue = 9753;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_QualifiedNameValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_QualifiedNameValue = 9754;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_LocalizedTextValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_LocalizedTextValue = 9755;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_StatusCodeValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_StatusCodeValue = 9756;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_VariantValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_VariantValue = 9757;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_EnumerationValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_EnumerationValue = 9758;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_StructureValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_StructureValue = 9759;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_NumberValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_NumberValue = 9760;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_IntegerValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_IntegerValue = 9761;

        /// <summary>
        /// The identifier for the ArrayValueObjectType_UIntegerValue Variable.
        /// </summary>
        public const uint ArrayValueObjectType_UIntegerValue = 9762;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_SByteValue Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_SByteValue = 9820;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_SByteValue_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_SByteValue_EURange = 9823;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_ByteValue Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_ByteValue = 9826;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_ByteValue_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_ByteValue_EURange = 9829;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_Int16Value Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_Int16Value = 9832;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_Int16Value_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_Int16Value_EURange = 9835;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UInt16Value Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_UInt16Value = 9838;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UInt16Value_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_UInt16Value_EURange = 9841;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_Int32Value Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_Int32Value = 9844;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_Int32Value_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_Int32Value_EURange = 9847;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UInt32Value Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_UInt32Value = 9850;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UInt32Value_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_UInt32Value_EURange = 9853;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_Int64Value Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_Int64Value = 9856;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_Int64Value_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_Int64Value_EURange = 9859;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UInt64Value Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_UInt64Value = 9862;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UInt64Value_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_UInt64Value_EURange = 9865;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_FloatValue Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_FloatValue = 9868;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_FloatValue_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_FloatValue_EURange = 9871;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_DoubleValue Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_DoubleValue = 9874;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_DoubleValue_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_DoubleValue_EURange = 9877;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_NumberValue Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_NumberValue = 9880;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_NumberValue_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_NumberValue_EURange = 9883;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_IntegerValue Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_IntegerValue = 9886;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_IntegerValue_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_IntegerValue_EURange = 9889;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UIntegerValue Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_UIntegerValue = 9892;

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UIntegerValue_EURange Variable.
        /// </summary>
        public const uint AnalogArrayValueObjectType_UIntegerValue_EURange = 9895;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_BooleanValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_BooleanValue = 9978;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_SByteValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_SByteValue = 9979;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_ByteValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_ByteValue = 9980;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_Int16Value Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_Int16Value = 9981;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_UInt16Value Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_UInt16Value = 9982;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_Int32Value Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_Int32Value = 9983;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_UInt32Value Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_UInt32Value = 9984;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_Int64Value Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_Int64Value = 9985;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_UInt64Value Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_UInt64Value = 9986;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_FloatValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_FloatValue = 9987;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_DoubleValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_DoubleValue = 9988;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_StringValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_StringValue = 9989;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_DateTimeValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_DateTimeValue = 9990;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_GuidValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_GuidValue = 9991;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_ByteStringValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_ByteStringValue = 9992;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_XmlElementValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_XmlElementValue = 9993;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_NodeIdValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_NodeIdValue = 9994;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_ExpandedNodeIdValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_ExpandedNodeIdValue = 9995;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_QualifiedNameValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_QualifiedNameValue = 9996;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_LocalizedTextValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_LocalizedTextValue = 9997;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_StatusCodeValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_StatusCodeValue = 9998;

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_VariantValue Variable.
        /// </summary>
        public const uint UserScalarValueObjectType_VariantValue = 9999;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_BooleanValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_BooleanValue = 10064;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_SByteValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_SByteValue = 10065;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_ByteValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_ByteValue = 10066;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_Int16Value Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_Int16Value = 10067;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_UInt16Value Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_UInt16Value = 10068;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_Int32Value Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_Int32Value = 10069;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_UInt32Value Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_UInt32Value = 10070;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_Int64Value Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_Int64Value = 10071;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_UInt64Value Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_UInt64Value = 10072;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_FloatValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_FloatValue = 10073;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_DoubleValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_DoubleValue = 10074;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_StringValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_StringValue = 10075;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_DateTimeValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_DateTimeValue = 10076;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_GuidValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_GuidValue = 10077;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_ByteStringValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_ByteStringValue = 10078;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_XmlElementValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_XmlElementValue = 10079;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_NodeIdValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_NodeIdValue = 10080;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_ExpandedNodeIdValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_ExpandedNodeIdValue = 10081;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_QualifiedNameValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_QualifiedNameValue = 10082;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_LocalizedTextValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_LocalizedTextValue = 10083;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_StatusCodeValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_StatusCodeValue = 10084;

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_VariantValue Variable.
        /// </summary>
        public const uint UserArrayValueObjectType_VariantValue = 10085;

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod1_InputArguments Variable.
        /// </summary>
        public const uint MethodTestType_ScalarMethod1_InputArguments = 10094;

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod1_OutputArguments Variable.
        /// </summary>
        public const uint MethodTestType_ScalarMethod1_OutputArguments = 10095;

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod2_InputArguments Variable.
        /// </summary>
        public const uint MethodTestType_ScalarMethod2_InputArguments = 10097;

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod2_OutputArguments Variable.
        /// </summary>
        public const uint MethodTestType_ScalarMethod2_OutputArguments = 10098;

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod3_InputArguments Variable.
        /// </summary>
        public const uint MethodTestType_ScalarMethod3_InputArguments = 10100;

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod3_OutputArguments Variable.
        /// </summary>
        public const uint MethodTestType_ScalarMethod3_OutputArguments = 10101;

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod1_InputArguments Variable.
        /// </summary>
        public const uint MethodTestType_ArrayMethod1_InputArguments = 10103;

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod1_OutputArguments Variable.
        /// </summary>
        public const uint MethodTestType_ArrayMethod1_OutputArguments = 10104;

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod2_InputArguments Variable.
        /// </summary>
        public const uint MethodTestType_ArrayMethod2_InputArguments = 10106;

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod2_OutputArguments Variable.
        /// </summary>
        public const uint MethodTestType_ArrayMethod2_OutputArguments = 10107;

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod3_InputArguments Variable.
        /// </summary>
        public const uint MethodTestType_ArrayMethod3_InputArguments = 10109;

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod3_OutputArguments Variable.
        /// </summary>
        public const uint MethodTestType_ArrayMethod3_OutputArguments = 10110;

        /// <summary>
        /// The identifier for the MethodTestType_UserScalarMethod1_InputArguments Variable.
        /// </summary>
        public const uint MethodTestType_UserScalarMethod1_InputArguments = 10112;

        /// <summary>
        /// The identifier for the MethodTestType_UserScalarMethod1_OutputArguments Variable.
        /// </summary>
        public const uint MethodTestType_UserScalarMethod1_OutputArguments = 10113;

        /// <summary>
        /// The identifier for the MethodTestType_UserScalarMethod2_InputArguments Variable.
        /// </summary>
        public const uint MethodTestType_UserScalarMethod2_InputArguments = 10115;

        /// <summary>
        /// The identifier for the MethodTestType_UserScalarMethod2_OutputArguments Variable.
        /// </summary>
        public const uint MethodTestType_UserScalarMethod2_OutputArguments = 10116;

        /// <summary>
        /// The identifier for the MethodTestType_UserArrayMethod1_InputArguments Variable.
        /// </summary>
        public const uint MethodTestType_UserArrayMethod1_InputArguments = 10118;

        /// <summary>
        /// The identifier for the MethodTestType_UserArrayMethod1_OutputArguments Variable.
        /// </summary>
        public const uint MethodTestType_UserArrayMethod1_OutputArguments = 10119;

        /// <summary>
        /// The identifier for the MethodTestType_UserArrayMethod2_InputArguments Variable.
        /// </summary>
        public const uint MethodTestType_UserArrayMethod2_InputArguments = 10121;

        /// <summary>
        /// The identifier for the MethodTestType_UserArrayMethod2_OutputArguments Variable.
        /// </summary>
        public const uint MethodTestType_UserArrayMethod2_OutputArguments = 10122;

        /// <summary>
        /// The identifier for the TestSystemConditionType_MonitoredNodeCount Variable.
        /// </summary>
        public const uint TestSystemConditionType_MonitoredNodeCount = 10156;

        /// <summary>
        /// The identifier for the Data_MyData1_MyValue1 Variable.
        /// </summary>
        public const uint Data_MyData1_MyValue1 = 12894;

        /// <summary>
        /// The identifier for the Data_MyData1_MyValue1_Class Variable.
        /// </summary>
        public const uint Data_MyData1_MyValue1_Class = 12895;

        /// <summary>
        /// The identifier for the Data_MyData1_MyValue1_Place Variable.
        /// </summary>
        public const uint Data_MyData1_MyValue1_Place = 12896;

        /// <summary>
        /// The identifier for the Data_MyData1_MyValue2 Variable.
        /// </summary>
        public const uint Data_MyData1_MyValue2 = 12897;

        /// <summary>
        /// The identifier for the Data_MyData1_MyValue2_Class Variable.
        /// </summary>
        public const uint Data_MyData1_MyValue2_Class = 12898;

        /// <summary>
        /// The identifier for the Data_MyData1_MyValue2_Place Variable.
        /// </summary>
        public const uint Data_MyData1_MyValue2_Place = 12899;

        /// <summary>
        /// The identifier for the Data_MyData2_MyValue1 Variable.
        /// </summary>
        public const uint Data_MyData2_MyValue1 = 12901;

        /// <summary>
        /// The identifier for the Data_MyData2_MyValue1_Class Variable.
        /// </summary>
        public const uint Data_MyData2_MyValue1_Class = 12902;

        /// <summary>
        /// The identifier for the Data_MyData2_MyValue1_Place Variable.
        /// </summary>
        public const uint Data_MyData2_MyValue1_Place = 12903;

        /// <summary>
        /// The identifier for the Data_MyData2_MyValue2 Variable.
        /// </summary>
        public const uint Data_MyData2_MyValue2 = 12904;

        /// <summary>
        /// The identifier for the Data_MyData2_MyValue2_Class Variable.
        /// </summary>
        public const uint Data_MyData2_MyValue2_Class = 12905;

        /// <summary>
        /// The identifier for the Data_MyData2_MyValue2_Place Variable.
        /// </summary>
        public const uint Data_MyData2_MyValue2_Place = 12906;

        /// <summary>
        /// The identifier for the TestData_XmlSchema Variable.
        /// </summary>
        public const uint TestData_XmlSchema = 11441;

        /// <summary>
        /// The identifier for the TestData_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public const uint TestData_XmlSchema_NamespaceUri = 11443;

        /// <summary>
        /// The identifier for the TestData_XmlSchema_ScalarValueDataType Variable.
        /// </summary>
        public const uint TestData_XmlSchema_ScalarValueDataType = 11993;

        /// <summary>
        /// The identifier for the TestData_XmlSchema_ArrayValueDataType Variable.
        /// </summary>
        public const uint TestData_XmlSchema_ArrayValueDataType = 11447;

        /// <summary>
        /// The identifier for the TestData_XmlSchema_UserScalarValueDataType Variable.
        /// </summary>
        public const uint TestData_XmlSchema_UserScalarValueDataType = 11450;

        /// <summary>
        /// The identifier for the TestData_XmlSchema_UserArrayValueDataType Variable.
        /// </summary>
        public const uint TestData_XmlSchema_UserArrayValueDataType = 11453;

        /// <summary>
        /// The identifier for the TestData_BinarySchema Variable.
        /// </summary>
        public const uint TestData_BinarySchema = 11422;

        /// <summary>
        /// The identifier for the TestData_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public const uint TestData_BinarySchema_NamespaceUri = 11424;

        /// <summary>
        /// The identifier for the TestData_BinarySchema_ScalarValueDataType Variable.
        /// </summary>
        public const uint TestData_BinarySchema_ScalarValueDataType = 11997;

        /// <summary>
        /// The identifier for the TestData_BinarySchema_ArrayValueDataType Variable.
        /// </summary>
        public const uint TestData_BinarySchema_ArrayValueDataType = 11428;

        /// <summary>
        /// The identifier for the TestData_BinarySchema_UserScalarValueDataType Variable.
        /// </summary>
        public const uint TestData_BinarySchema_UserScalarValueDataType = 11431;

        /// <summary>
        /// The identifier for the TestData_BinarySchema_UserArrayValueDataType Variable.
        /// </summary>
        public const uint TestData_BinarySchema_UserArrayValueDataType = 11434;
    }
    #endregion

    #region DataType Node Identifiers
    /// <summary>
    /// A class that declares constants for all DataTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class DataTypeIds
    {
        /// <summary>
        /// The identifier for the ScalarValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueDataType = new ExpandedNodeId(TestData.DataTypes.ScalarValueDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueDataType = new ExpandedNodeId(TestData.DataTypes.ArrayValueDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the BooleanDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId BooleanDataType = new ExpandedNodeId(TestData.DataTypes.BooleanDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the SByteDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId SByteDataType = new ExpandedNodeId(TestData.DataTypes.SByteDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ByteDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ByteDataType = new ExpandedNodeId(TestData.DataTypes.ByteDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Int16DataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId Int16DataType = new ExpandedNodeId(TestData.DataTypes.Int16DataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UInt16DataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId UInt16DataType = new ExpandedNodeId(TestData.DataTypes.UInt16DataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Int32DataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId Int32DataType = new ExpandedNodeId(TestData.DataTypes.Int32DataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UInt32DataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId UInt32DataType = new ExpandedNodeId(TestData.DataTypes.UInt32DataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Int64DataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId Int64DataType = new ExpandedNodeId(TestData.DataTypes.Int64DataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UInt64DataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId UInt64DataType = new ExpandedNodeId(TestData.DataTypes.UInt64DataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the FloatDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId FloatDataType = new ExpandedNodeId(TestData.DataTypes.FloatDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the DoubleDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId DoubleDataType = new ExpandedNodeId(TestData.DataTypes.DoubleDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the StringDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId StringDataType = new ExpandedNodeId(TestData.DataTypes.StringDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the DateTimeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId DateTimeDataType = new ExpandedNodeId(TestData.DataTypes.DateTimeDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the GuidDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId GuidDataType = new ExpandedNodeId(TestData.DataTypes.GuidDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ByteStringDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ByteStringDataType = new ExpandedNodeId(TestData.DataTypes.ByteStringDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the XmlElementDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId XmlElementDataType = new ExpandedNodeId(TestData.DataTypes.XmlElementDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the NodeIdDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId NodeIdDataType = new ExpandedNodeId(TestData.DataTypes.NodeIdDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ExpandedNodeIdDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId ExpandedNodeIdDataType = new ExpandedNodeId(TestData.DataTypes.ExpandedNodeIdDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the QualifiedNameDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId QualifiedNameDataType = new ExpandedNodeId(TestData.DataTypes.QualifiedNameDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the LocalizedTextDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId LocalizedTextDataType = new ExpandedNodeId(TestData.DataTypes.LocalizedTextDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the StatusCodeDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId StatusCodeDataType = new ExpandedNodeId(TestData.DataTypes.StatusCodeDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the VariantDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId VariantDataType = new ExpandedNodeId(TestData.DataTypes.VariantDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueDataType = new ExpandedNodeId(TestData.DataTypes.UserScalarValueDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueDataType DataType.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueDataType = new ExpandedNodeId(TestData.DataTypes.UserArrayValueDataType, TestData.Namespaces.TestData);
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
        /// The identifier for the TestDataObjectType_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId TestDataObjectType_GenerateValues = new ExpandedNodeId(TestData.Methods.TestDataObjectType_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestDataObjectType_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId TestDataObjectType_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.TestDataObjectType_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod1 Method.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ScalarMethod1 = new ExpandedNodeId(TestData.Methods.MethodTestType_ScalarMethod1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod2 Method.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ScalarMethod2 = new ExpandedNodeId(TestData.Methods.MethodTestType_ScalarMethod2, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod3 Method.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ScalarMethod3 = new ExpandedNodeId(TestData.Methods.MethodTestType_ScalarMethod3, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod1 Method.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ArrayMethod1 = new ExpandedNodeId(TestData.Methods.MethodTestType_ArrayMethod1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod2 Method.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ArrayMethod2 = new ExpandedNodeId(TestData.Methods.MethodTestType_ArrayMethod2, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod3 Method.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ArrayMethod3 = new ExpandedNodeId(TestData.Methods.MethodTestType_ArrayMethod3, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_UserScalarMethod1 Method.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_UserScalarMethod1 = new ExpandedNodeId(TestData.Methods.MethodTestType_UserScalarMethod1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_UserScalarMethod2 Method.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_UserScalarMethod2 = new ExpandedNodeId(TestData.Methods.MethodTestType_UserScalarMethod2, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_UserArrayMethod1 Method.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_UserArrayMethod1 = new ExpandedNodeId(TestData.Methods.MethodTestType_UserArrayMethod1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_UserArrayMethod2 Method.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_UserArrayMethod2 = new ExpandedNodeId(TestData.Methods.MethodTestType_UserArrayMethod2, TestData.Namespaces.TestData);
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
        /// The identifier for the TestDataObjectType_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId TestDataObjectType_CycleComplete = new ExpandedNodeId(TestData.Objects.TestDataObjectType_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data Object.
        /// </summary>
        public static readonly ExpandedNodeId Data = new ExpandedNodeId(TestData.Objects.Data, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData1 Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData1 = new ExpandedNodeId(TestData.Objects.Data_MyData1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData2 Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData2 = new ExpandedNodeId(TestData.Objects.Data_MyData2, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueDataType_Encoding_DefaultXml = new ExpandedNodeId(TestData.Objects.ScalarValueDataType_Encoding_DefaultXml, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueDataType_Encoding_DefaultXml = new ExpandedNodeId(TestData.Objects.ArrayValueDataType_Encoding_DefaultXml, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueDataType_Encoding_DefaultXml = new ExpandedNodeId(TestData.Objects.UserScalarValueDataType_Encoding_DefaultXml, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueDataType_Encoding_DefaultXml Object.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueDataType_Encoding_DefaultXml = new ExpandedNodeId(TestData.Objects.UserArrayValueDataType_Encoding_DefaultXml, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueDataType_Encoding_DefaultBinary = new ExpandedNodeId(TestData.Objects.ScalarValueDataType_Encoding_DefaultBinary, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueDataType_Encoding_DefaultBinary = new ExpandedNodeId(TestData.Objects.ArrayValueDataType_Encoding_DefaultBinary, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueDataType_Encoding_DefaultBinary = new ExpandedNodeId(TestData.Objects.UserScalarValueDataType_Encoding_DefaultBinary, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueDataType_Encoding_DefaultBinary Object.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueDataType_Encoding_DefaultBinary = new ExpandedNodeId(TestData.Objects.UserArrayValueDataType_Encoding_DefaultBinary, TestData.Namespaces.TestData);
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
        /// The identifier for the GenerateValuesEventType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenerateValuesEventType = new ExpandedNodeId(TestData.ObjectTypes.GenerateValuesEventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestDataObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TestDataObjectType = new ExpandedNodeId(TestData.ObjectTypes.TestDataObjectType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType = new ExpandedNodeId(TestData.ObjectTypes.ScalarValueObjectType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MyObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MyObjectType = new ExpandedNodeId(TestData.ObjectTypes.MyObjectType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType = new ExpandedNodeId(TestData.ObjectTypes.AnalogScalarValueObjectType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType = new ExpandedNodeId(TestData.ObjectTypes.ArrayValueObjectType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType = new ExpandedNodeId(TestData.ObjectTypes.AnalogArrayValueObjectType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType = new ExpandedNodeId(TestData.ObjectTypes.UserScalarValueObjectType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType = new ExpandedNodeId(TestData.ObjectTypes.UserArrayValueObjectType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType = new ExpandedNodeId(TestData.ObjectTypes.MethodTestType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestSystemConditionType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId TestSystemConditionType = new ExpandedNodeId(TestData.ObjectTypes.TestSystemConditionType, TestData.Namespaces.TestData);
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
        /// The identifier for the GenerateValuesEventType_Iterations Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenerateValuesEventType_Iterations = new ExpandedNodeId(TestData.Variables.GenerateValuesEventType_Iterations, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the GenerateValuesEventType_NewValueCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenerateValuesEventType_NewValueCount = new ExpandedNodeId(TestData.Variables.GenerateValuesEventType_NewValueCount, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestDataObjectType_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestDataObjectType_SimulationActive = new ExpandedNodeId(TestData.Variables.TestDataObjectType_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestDataObjectType_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestDataObjectType_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.TestDataObjectType_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestDataObjectType_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestDataObjectType_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.TestDataObjectType_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestDataObjectType_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestDataObjectType_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.TestDataObjectType_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestDataObjectType_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestDataObjectType_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.TestDataObjectType_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_BooleanValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_BooleanValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_BooleanValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_SByteValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_ByteValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_Int16Value = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_UInt16Value = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_Int32Value = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_UInt32Value = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_Int64Value = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_UInt64Value = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_FloatValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_DoubleValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_StringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_StringValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_StringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_DateTimeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_DateTimeValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_DateTimeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_GuidValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_GuidValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_GuidValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_ByteStringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_ByteStringValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_ByteStringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_XmlElementValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_XmlElementValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_XmlElementValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_NodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_NodeIdValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_NodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_ExpandedNodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_ExpandedNodeIdValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_ExpandedNodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_QualifiedNameValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_QualifiedNameValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_QualifiedNameValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_LocalizedTextValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_LocalizedTextValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_LocalizedTextValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_StatusCodeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_StatusCodeValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_StatusCodeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_VariantValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_VariantValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_VariantValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_EnumerationValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_EnumerationValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_EnumerationValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_StructureValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_StructureValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_StructureValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_NumberValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_NumberValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_NumberValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_IntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_IntegerValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_IntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ScalarValueObjectType_UIntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ScalarValueObjectType_UIntegerValue = new ExpandedNodeId(TestData.Variables.ScalarValueObjectType_UIntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MyObjectType_MyValue1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyObjectType_MyValue1 = new ExpandedNodeId(TestData.Variables.MyObjectType_MyValue1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MyObjectType_MyValue1_Class Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyObjectType_MyValue1_Class = new ExpandedNodeId(TestData.Variables.MyObjectType_MyValue1_Class, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MyObjectType_MyValue1_Place Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyObjectType_MyValue1_Place = new ExpandedNodeId(TestData.Variables.MyObjectType_MyValue1_Place, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MyObjectType_MyValue2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyObjectType_MyValue2 = new ExpandedNodeId(TestData.Variables.MyObjectType_MyValue2, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MyObjectType_MyValue2_Class Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyObjectType_MyValue2_Class = new ExpandedNodeId(TestData.Variables.MyObjectType_MyValue2_Class, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MyObjectType_MyValue2_Place Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyObjectType_MyValue2_Place = new ExpandedNodeId(TestData.Variables.MyObjectType_MyValue2_Place, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_SByteValue = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_SByteValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_SByteValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_SByteValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_ByteValue = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_ByteValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_ByteValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_ByteValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_Int16Value = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_Int16Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_Int16Value_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_Int16Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_UInt16Value = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UInt16Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_UInt16Value_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_UInt16Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_Int32Value = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_Int32Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_Int32Value_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_Int32Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_UInt32Value = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UInt32Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_UInt32Value_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_UInt32Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_Int64Value = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_Int64Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_Int64Value_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_Int64Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_UInt64Value = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UInt64Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_UInt64Value_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_UInt64Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_FloatValue = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_FloatValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_FloatValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_FloatValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_DoubleValue = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_DoubleValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_DoubleValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_DoubleValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_NumberValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_NumberValue = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_NumberValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_NumberValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_NumberValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_NumberValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_IntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_IntegerValue = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_IntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_IntegerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_IntegerValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_IntegerValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UIntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_UIntegerValue = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_UIntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogScalarValueObjectType_UIntegerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogScalarValueObjectType_UIntegerValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogScalarValueObjectType_UIntegerValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_BooleanValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_BooleanValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_BooleanValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_SByteValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_ByteValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_Int16Value = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_UInt16Value = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_Int32Value = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_UInt32Value = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_Int64Value = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_UInt64Value = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_FloatValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_DoubleValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_StringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_StringValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_StringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_DateTimeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_DateTimeValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_DateTimeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_GuidValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_GuidValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_GuidValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_ByteStringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_ByteStringValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_ByteStringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_XmlElementValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_XmlElementValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_XmlElementValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_NodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_NodeIdValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_NodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_ExpandedNodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_ExpandedNodeIdValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_ExpandedNodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_QualifiedNameValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_QualifiedNameValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_QualifiedNameValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_LocalizedTextValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_LocalizedTextValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_LocalizedTextValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_StatusCodeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_StatusCodeValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_StatusCodeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_VariantValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_VariantValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_VariantValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_EnumerationValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_EnumerationValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_EnumerationValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_StructureValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_StructureValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_StructureValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_NumberValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_NumberValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_NumberValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_IntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_IntegerValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_IntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the ArrayValueObjectType_UIntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId ArrayValueObjectType_UIntegerValue = new ExpandedNodeId(TestData.Variables.ArrayValueObjectType_UIntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_SByteValue = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_SByteValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_SByteValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_SByteValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_ByteValue = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_ByteValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_ByteValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_ByteValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_Int16Value = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_Int16Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_Int16Value_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_Int16Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_UInt16Value = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UInt16Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_UInt16Value_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_UInt16Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_Int32Value = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_Int32Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_Int32Value_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_Int32Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_UInt32Value = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UInt32Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_UInt32Value_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_UInt32Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_Int64Value = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_Int64Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_Int64Value_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_Int64Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_UInt64Value = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UInt64Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_UInt64Value_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_UInt64Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_FloatValue = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_FloatValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_FloatValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_FloatValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_DoubleValue = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_DoubleValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_DoubleValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_DoubleValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_NumberValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_NumberValue = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_NumberValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_NumberValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_NumberValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_NumberValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_IntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_IntegerValue = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_IntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_IntegerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_IntegerValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_IntegerValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UIntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_UIntegerValue = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_UIntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the AnalogArrayValueObjectType_UIntegerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId AnalogArrayValueObjectType_UIntegerValue_EURange = new ExpandedNodeId(TestData.Variables.AnalogArrayValueObjectType_UIntegerValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_BooleanValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_BooleanValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_BooleanValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_SByteValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_ByteValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_Int16Value = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_UInt16Value = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_Int32Value = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_UInt32Value = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_Int64Value = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_UInt64Value = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_FloatValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_DoubleValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_StringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_StringValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_StringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_DateTimeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_DateTimeValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_DateTimeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_GuidValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_GuidValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_GuidValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_ByteStringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_ByteStringValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_ByteStringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_XmlElementValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_XmlElementValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_XmlElementValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_NodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_NodeIdValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_NodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_ExpandedNodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_ExpandedNodeIdValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_ExpandedNodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_QualifiedNameValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_QualifiedNameValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_QualifiedNameValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_LocalizedTextValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_LocalizedTextValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_LocalizedTextValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_StatusCodeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_StatusCodeValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_StatusCodeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserScalarValueObjectType_VariantValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserScalarValueObjectType_VariantValue = new ExpandedNodeId(TestData.Variables.UserScalarValueObjectType_VariantValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_BooleanValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_BooleanValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_BooleanValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_SByteValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_ByteValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_Int16Value = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_UInt16Value = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_Int32Value = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_UInt32Value = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_Int64Value = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_UInt64Value = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_FloatValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_DoubleValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_StringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_StringValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_StringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_DateTimeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_DateTimeValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_DateTimeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_GuidValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_GuidValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_GuidValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_ByteStringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_ByteStringValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_ByteStringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_XmlElementValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_XmlElementValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_XmlElementValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_NodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_NodeIdValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_NodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_ExpandedNodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_ExpandedNodeIdValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_ExpandedNodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_QualifiedNameValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_QualifiedNameValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_QualifiedNameValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_LocalizedTextValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_LocalizedTextValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_LocalizedTextValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_StatusCodeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_StatusCodeValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_StatusCodeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the UserArrayValueObjectType_VariantValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId UserArrayValueObjectType_VariantValue = new ExpandedNodeId(TestData.Variables.UserArrayValueObjectType_VariantValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod1_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ScalarMethod1_InputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_ScalarMethod1_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod1_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ScalarMethod1_OutputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_ScalarMethod1_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ScalarMethod2_InputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_ScalarMethod2_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod2_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ScalarMethod2_OutputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_ScalarMethod2_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod3_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ScalarMethod3_InputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_ScalarMethod3_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ScalarMethod3_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ScalarMethod3_OutputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_ScalarMethod3_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod1_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ArrayMethod1_InputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_ArrayMethod1_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod1_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ArrayMethod1_OutputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_ArrayMethod1_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ArrayMethod2_InputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_ArrayMethod2_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod2_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ArrayMethod2_OutputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_ArrayMethod2_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod3_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ArrayMethod3_InputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_ArrayMethod3_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_ArrayMethod3_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_ArrayMethod3_OutputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_ArrayMethod3_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_UserScalarMethod1_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_UserScalarMethod1_InputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_UserScalarMethod1_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_UserScalarMethod1_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_UserScalarMethod1_OutputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_UserScalarMethod1_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_UserScalarMethod2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_UserScalarMethod2_InputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_UserScalarMethod2_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_UserScalarMethod2_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_UserScalarMethod2_OutputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_UserScalarMethod2_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_UserArrayMethod1_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_UserArrayMethod1_InputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_UserArrayMethod1_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_UserArrayMethod1_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_UserArrayMethod1_OutputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_UserArrayMethod1_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_UserArrayMethod2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_UserArrayMethod2_InputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_UserArrayMethod2_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the MethodTestType_UserArrayMethod2_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId MethodTestType_UserArrayMethod2_OutputArguments = new ExpandedNodeId(TestData.Variables.MethodTestType_UserArrayMethod2_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestSystemConditionType_MonitoredNodeCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestSystemConditionType_MonitoredNodeCount = new ExpandedNodeId(TestData.Variables.TestSystemConditionType_MonitoredNodeCount, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData1_MyValue1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData1_MyValue1 = new ExpandedNodeId(TestData.Variables.Data_MyData1_MyValue1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData1_MyValue1_Class Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData1_MyValue1_Class = new ExpandedNodeId(TestData.Variables.Data_MyData1_MyValue1_Class, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData1_MyValue1_Place Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData1_MyValue1_Place = new ExpandedNodeId(TestData.Variables.Data_MyData1_MyValue1_Place, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData1_MyValue2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData1_MyValue2 = new ExpandedNodeId(TestData.Variables.Data_MyData1_MyValue2, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData1_MyValue2_Class Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData1_MyValue2_Class = new ExpandedNodeId(TestData.Variables.Data_MyData1_MyValue2_Class, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData1_MyValue2_Place Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData1_MyValue2_Place = new ExpandedNodeId(TestData.Variables.Data_MyData1_MyValue2_Place, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData2_MyValue1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData2_MyValue1 = new ExpandedNodeId(TestData.Variables.Data_MyData2_MyValue1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData2_MyValue1_Class Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData2_MyValue1_Class = new ExpandedNodeId(TestData.Variables.Data_MyData2_MyValue1_Class, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData2_MyValue1_Place Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData2_MyValue1_Place = new ExpandedNodeId(TestData.Variables.Data_MyData2_MyValue1_Place, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData2_MyValue2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData2_MyValue2 = new ExpandedNodeId(TestData.Variables.Data_MyData2_MyValue2, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData2_MyValue2_Class Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData2_MyValue2_Class = new ExpandedNodeId(TestData.Variables.Data_MyData2_MyValue2_Class, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_MyData2_MyValue2_Place Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_MyData2_MyValue2_Place = new ExpandedNodeId(TestData.Variables.Data_MyData2_MyValue2_Place, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestData_XmlSchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestData_XmlSchema = new ExpandedNodeId(TestData.Variables.TestData_XmlSchema, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestData_XmlSchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestData_XmlSchema_NamespaceUri = new ExpandedNodeId(TestData.Variables.TestData_XmlSchema_NamespaceUri, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestData_XmlSchema_ScalarValueDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestData_XmlSchema_ScalarValueDataType = new ExpandedNodeId(TestData.Variables.TestData_XmlSchema_ScalarValueDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestData_XmlSchema_ArrayValueDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestData_XmlSchema_ArrayValueDataType = new ExpandedNodeId(TestData.Variables.TestData_XmlSchema_ArrayValueDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestData_XmlSchema_UserScalarValueDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestData_XmlSchema_UserScalarValueDataType = new ExpandedNodeId(TestData.Variables.TestData_XmlSchema_UserScalarValueDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestData_XmlSchema_UserArrayValueDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestData_XmlSchema_UserArrayValueDataType = new ExpandedNodeId(TestData.Variables.TestData_XmlSchema_UserArrayValueDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestData_BinarySchema Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestData_BinarySchema = new ExpandedNodeId(TestData.Variables.TestData_BinarySchema, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestData_BinarySchema_NamespaceUri Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestData_BinarySchema_NamespaceUri = new ExpandedNodeId(TestData.Variables.TestData_BinarySchema_NamespaceUri, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestData_BinarySchema_ScalarValueDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestData_BinarySchema_ScalarValueDataType = new ExpandedNodeId(TestData.Variables.TestData_BinarySchema_ScalarValueDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestData_BinarySchema_ArrayValueDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestData_BinarySchema_ArrayValueDataType = new ExpandedNodeId(TestData.Variables.TestData_BinarySchema_ArrayValueDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestData_BinarySchema_UserScalarValueDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestData_BinarySchema_UserScalarValueDataType = new ExpandedNodeId(TestData.Variables.TestData_BinarySchema_UserScalarValueDataType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the TestData_BinarySchema_UserArrayValueDataType Variable.
        /// </summary>
        public static readonly ExpandedNodeId TestData_BinarySchema_UserArrayValueDataType = new ExpandedNodeId(TestData.Variables.TestData_BinarySchema_UserArrayValueDataType, TestData.Namespaces.TestData);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the AnalogArrayValueObjectType component.
        /// </summary>
        public const string AnalogArrayValueObjectType = "AnalogArrayValueObjectType";

        /// <summary>
        /// The BrowseName for the AnalogScalarValueObjectType component.
        /// </summary>
        public const string AnalogScalarValueObjectType = "AnalogScalarValueObjectType";

        /// <summary>
        /// The BrowseName for the ArrayMethod1 component.
        /// </summary>
        public const string ArrayMethod1 = "ArrayMethod1";

        /// <summary>
        /// The BrowseName for the ArrayMethod2 component.
        /// </summary>
        public const string ArrayMethod2 = "ArrayMethod2";

        /// <summary>
        /// The BrowseName for the ArrayMethod3 component.
        /// </summary>
        public const string ArrayMethod3 = "ArrayMethod3";

        /// <summary>
        /// The BrowseName for the ArrayValueDataType component.
        /// </summary>
        public const string ArrayValueDataType = "ArrayValueDataType";

        /// <summary>
        /// The BrowseName for the ArrayValueObjectType component.
        /// </summary>
        public const string ArrayValueObjectType = "ArrayValueObjectType";

        /// <summary>
        /// The BrowseName for the BooleanDataType component.
        /// </summary>
        public const string BooleanDataType = "BooleanDataType";

        /// <summary>
        /// The BrowseName for the BooleanValue component.
        /// </summary>
        public const string BooleanValue = "BooleanValue";

        /// <summary>
        /// The BrowseName for the ByteDataType component.
        /// </summary>
        public const string ByteDataType = "ByteDataType";

        /// <summary>
        /// The BrowseName for the ByteStringDataType component.
        /// </summary>
        public const string ByteStringDataType = "ByteStringDataType";

        /// <summary>
        /// The BrowseName for the ByteStringValue component.
        /// </summary>
        public const string ByteStringValue = "ByteStringValue";

        /// <summary>
        /// The BrowseName for the ByteValue component.
        /// </summary>
        public const string ByteValue = "ByteValue";

        /// <summary>
        /// The BrowseName for the CycleComplete component.
        /// </summary>
        public const string CycleComplete = "CycleComplete";

        /// <summary>
        /// The BrowseName for the Data component.
        /// </summary>
        public const string Data = "Data";

        /// <summary>
        /// The BrowseName for the DateTimeDataType component.
        /// </summary>
        public const string DateTimeDataType = "DateTimeDataType";

        /// <summary>
        /// The BrowseName for the DateTimeValue component.
        /// </summary>
        public const string DateTimeValue = "DateTimeValue";

        /// <summary>
        /// The BrowseName for the DoubleDataType component.
        /// </summary>
        public const string DoubleDataType = "DoubleDataType";

        /// <summary>
        /// The BrowseName for the DoubleValue component.
        /// </summary>
        public const string DoubleValue = "DoubleValue";

        /// <summary>
        /// The BrowseName for the EnumerationValue component.
        /// </summary>
        public const string EnumerationValue = "EnumerationValue";

        /// <summary>
        /// The BrowseName for the ExpandedNodeIdDataType component.
        /// </summary>
        public const string ExpandedNodeIdDataType = "ExpandedNodeIdDataType";

        /// <summary>
        /// The BrowseName for the ExpandedNodeIdValue component.
        /// </summary>
        public const string ExpandedNodeIdValue = "ExpandedNodeIdValue";

        /// <summary>
        /// The BrowseName for the FloatDataType component.
        /// </summary>
        public const string FloatDataType = "FloatDataType";

        /// <summary>
        /// The BrowseName for the FloatValue component.
        /// </summary>
        public const string FloatValue = "FloatValue";

        /// <summary>
        /// The BrowseName for the GenerateValues component.
        /// </summary>
        public const string GenerateValues = "GenerateValues";

        /// <summary>
        /// The BrowseName for the GenerateValuesEventType component.
        /// </summary>
        public const string GenerateValuesEventType = "GenerateValuesEventType";

        /// <summary>
        /// The BrowseName for the GuidDataType component.
        /// </summary>
        public const string GuidDataType = "GuidDataType";

        /// <summary>
        /// The BrowseName for the GuidValue component.
        /// </summary>
        public const string GuidValue = "GuidValue";

        /// <summary>
        /// The BrowseName for the Int16DataType component.
        /// </summary>
        public const string Int16DataType = "Int16DataType";

        /// <summary>
        /// The BrowseName for the Int16Value component.
        /// </summary>
        public const string Int16Value = "Int16Value";

        /// <summary>
        /// The BrowseName for the Int32DataType component.
        /// </summary>
        public const string Int32DataType = "Int32DataType";

        /// <summary>
        /// The BrowseName for the Int32Value component.
        /// </summary>
        public const string Int32Value = "Int32Value";

        /// <summary>
        /// The BrowseName for the Int64DataType component.
        /// </summary>
        public const string Int64DataType = "Int64DataType";

        /// <summary>
        /// The BrowseName for the Int64Value component.
        /// </summary>
        public const string Int64Value = "Int64Value";

        /// <summary>
        /// The BrowseName for the IntegerValue component.
        /// </summary>
        public const string IntegerValue = "IntegerValue";

        /// <summary>
        /// The BrowseName for the Iterations component.
        /// </summary>
        public const string Iterations = "Iterations";

        /// <summary>
        /// The BrowseName for the LocalizedTextDataType component.
        /// </summary>
        public const string LocalizedTextDataType = "LocalizedTextDataType";

        /// <summary>
        /// The BrowseName for the LocalizedTextValue component.
        /// </summary>
        public const string LocalizedTextValue = "LocalizedTextValue";

        /// <summary>
        /// The BrowseName for the MethodTestType component.
        /// </summary>
        public const string MethodTestType = "MethodTestType";

        /// <summary>
        /// The BrowseName for the MonitoredNodeCount component.
        /// </summary>
        public const string MonitoredNodeCount = "MonitoredNodeCount";

        /// <summary>
        /// The BrowseName for the MyData1 component.
        /// </summary>
        public const string MyData1 = "MyData1";

        /// <summary>
        /// The BrowseName for the MyData2 component.
        /// </summary>
        public const string MyData2 = "MyData2";

        /// <summary>
        /// The BrowseName for the MyObjectType component.
        /// </summary>
        public const string MyObjectType = "MyObjectType";

        /// <summary>
        /// The BrowseName for the MyValue1 component.
        /// </summary>
        public const string MyValue1 = "MyValue1";

        /// <summary>
        /// The BrowseName for the MyValue2 component.
        /// </summary>
        public const string MyValue2 = "MyValue2";

        /// <summary>
        /// The BrowseName for the NewValueCount component.
        /// </summary>
        public const string NewValueCount = "NewValueCount";

        /// <summary>
        /// The BrowseName for the NodeIdDataType component.
        /// </summary>
        public const string NodeIdDataType = "NodeIdDataType";

        /// <summary>
        /// The BrowseName for the NodeIdValue component.
        /// </summary>
        public const string NodeIdValue = "NodeIdValue";

        /// <summary>
        /// The BrowseName for the NumberValue component.
        /// </summary>
        public const string NumberValue = "NumberValue";

        /// <summary>
        /// The BrowseName for the QualifiedNameDataType component.
        /// </summary>
        public const string QualifiedNameDataType = "QualifiedNameDataType";

        /// <summary>
        /// The BrowseName for the QualifiedNameValue component.
        /// </summary>
        public const string QualifiedNameValue = "QualifiedNameValue";

        /// <summary>
        /// The BrowseName for the SByteDataType component.
        /// </summary>
        public const string SByteDataType = "SByteDataType";

        /// <summary>
        /// The BrowseName for the SByteValue component.
        /// </summary>
        public const string SByteValue = "SByteValue";

        /// <summary>
        /// The BrowseName for the ScalarMethod1 component.
        /// </summary>
        public const string ScalarMethod1 = "ScalarMethod1";

        /// <summary>
        /// The BrowseName for the ScalarMethod2 component.
        /// </summary>
        public const string ScalarMethod2 = "ScalarMethod2";

        /// <summary>
        /// The BrowseName for the ScalarMethod3 component.
        /// </summary>
        public const string ScalarMethod3 = "ScalarMethod3";

        /// <summary>
        /// The BrowseName for the ScalarValueDataType component.
        /// </summary>
        public const string ScalarValueDataType = "ScalarValueDataType";

        /// <summary>
        /// The BrowseName for the ScalarValueObjectType component.
        /// </summary>
        public const string ScalarValueObjectType = "ScalarValueObjectType";

        /// <summary>
        /// The BrowseName for the SimulationActive component.
        /// </summary>
        public const string SimulationActive = "SimulationActive";

        /// <summary>
        /// The BrowseName for the StatusCodeDataType component.
        /// </summary>
        public const string StatusCodeDataType = "StatusCodeDataType";

        /// <summary>
        /// The BrowseName for the StatusCodeValue component.
        /// </summary>
        public const string StatusCodeValue = "StatusCodeValue";

        /// <summary>
        /// The BrowseName for the StringDataType component.
        /// </summary>
        public const string StringDataType = "StringDataType";

        /// <summary>
        /// The BrowseName for the StringValue component.
        /// </summary>
        public const string StringValue = "StringValue";

        /// <summary>
        /// The BrowseName for the StructureValue component.
        /// </summary>
        public const string StructureValue = "StructureValue";

        /// <summary>
        /// The BrowseName for the TestData_BinarySchema component.
        /// </summary>
        public const string TestData_BinarySchema = "TestData";

        /// <summary>
        /// The BrowseName for the TestData_XmlSchema component.
        /// </summary>
        public const string TestData_XmlSchema = "TestData";

        /// <summary>
        /// The BrowseName for the TestDataObjectType component.
        /// </summary>
        public const string TestDataObjectType = "TestDataObjectType";

        /// <summary>
        /// The BrowseName for the TestSystemConditionType component.
        /// </summary>
        public const string TestSystemConditionType = "TestSystemConditionType";

        /// <summary>
        /// The BrowseName for the UInt16DataType component.
        /// </summary>
        public const string UInt16DataType = "UInt16DataType";

        /// <summary>
        /// The BrowseName for the UInt16Value component.
        /// </summary>
        public const string UInt16Value = "UInt16Value";

        /// <summary>
        /// The BrowseName for the UInt32DataType component.
        /// </summary>
        public const string UInt32DataType = "UInt32DataType";

        /// <summary>
        /// The BrowseName for the UInt32Value component.
        /// </summary>
        public const string UInt32Value = "UInt32Value";

        /// <summary>
        /// The BrowseName for the UInt64DataType component.
        /// </summary>
        public const string UInt64DataType = "UInt64DataType";

        /// <summary>
        /// The BrowseName for the UInt64Value component.
        /// </summary>
        public const string UInt64Value = "UInt64Value";

        /// <summary>
        /// The BrowseName for the UIntegerValue component.
        /// </summary>
        public const string UIntegerValue = "UIntegerValue";

        /// <summary>
        /// The BrowseName for the UserArrayMethod1 component.
        /// </summary>
        public const string UserArrayMethod1 = "UserArrayMethod1";

        /// <summary>
        /// The BrowseName for the UserArrayMethod2 component.
        /// </summary>
        public const string UserArrayMethod2 = "UserArrayMethod2";

        /// <summary>
        /// The BrowseName for the UserArrayValueDataType component.
        /// </summary>
        public const string UserArrayValueDataType = "UserArrayValueDataType";

        /// <summary>
        /// The BrowseName for the UserArrayValueObjectType component.
        /// </summary>
        public const string UserArrayValueObjectType = "UserArrayValueObjectType";

        /// <summary>
        /// The BrowseName for the UserScalarMethod1 component.
        /// </summary>
        public const string UserScalarMethod1 = "UserScalarMethod1";

        /// <summary>
        /// The BrowseName for the UserScalarMethod2 component.
        /// </summary>
        public const string UserScalarMethod2 = "UserScalarMethod2";

        /// <summary>
        /// The BrowseName for the UserScalarValueDataType component.
        /// </summary>
        public const string UserScalarValueDataType = "UserScalarValueDataType";

        /// <summary>
        /// The BrowseName for the UserScalarValueObjectType component.
        /// </summary>
        public const string UserScalarValueObjectType = "UserScalarValueObjectType";

        /// <summary>
        /// The BrowseName for the VariantDataType component.
        /// </summary>
        public const string VariantDataType = "VariantDataType";

        /// <summary>
        /// The BrowseName for the VariantValue component.
        /// </summary>
        public const string VariantValue = "VariantValue";

        /// <summary>
        /// The BrowseName for the XmlElementDataType component.
        /// </summary>
        public const string XmlElementDataType = "XmlElementDataType";

        /// <summary>
        /// The BrowseName for the XmlElementValue component.
        /// </summary>
        public const string XmlElementValue = "XmlElementValue";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
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
        /// The URI for the TestData namespace (.NET code namespace is 'TestData').
        /// </summary>
        public const string TestData = "http://test.org/UA/Data/";
    }
    #endregion
}