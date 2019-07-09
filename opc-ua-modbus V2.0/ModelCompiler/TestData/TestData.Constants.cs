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

        /// <summary>
        /// The identifier for the Data_Mydata_GenerateValues Method.
        /// </summary>
        public const uint Data_Mydata_GenerateValues = 12139;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Disable = 12172;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Enable = 12173;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_AddComment = 12174;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Acknowledge = 12194;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_GenerateValues Method.
        /// </summary>
        public const uint Data_Static_Scalar_GenerateValues = 12209;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Disable = 12242;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Enable = 12243;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_AddComment = 12244;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Acknowledge = 12264;

        /// <summary>
        /// The identifier for the Data_Static_Array_GenerateValues Method.
        /// </summary>
        public const uint Data_Static_Array_GenerateValues = 12297;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Disable = 12330;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Enable = 12331;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_AddComment = 12332;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Acknowledge = 12352;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_GenerateValues Method.
        /// </summary>
        public const uint Data_Static_UserScalar_GenerateValues = 12385;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Disable = 12418;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Enable = 12419;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_AddComment = 12420;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Acknowledge = 12440;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_GenerateValues Method.
        /// </summary>
        public const uint Data_Static_UserArray_GenerateValues = 12468;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Disable = 12501;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Enable = 12502;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_AddComment = 12503;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Acknowledge = 12523;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_GenerateValues Method.
        /// </summary>
        public const uint Data_Static_AnalogScalar_GenerateValues = 12551;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Disable = 12584;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Enable = 12585;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_AddComment = 12586;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Acknowledge = 12606;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_GenerateValues Method.
        /// </summary>
        public const uint Data_Static_AnalogArray_GenerateValues = 12690;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Disable = 12723;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Enable = 12724;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_AddComment = 12725;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Acknowledge = 12745;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod1 Method.
        /// </summary>
        public const uint Data_Static_MethodTest_ScalarMethod1 = 12828;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod2 Method.
        /// </summary>
        public const uint Data_Static_MethodTest_ScalarMethod2 = 12831;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod3 Method.
        /// </summary>
        public const uint Data_Static_MethodTest_ScalarMethod3 = 12834;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod1 Method.
        /// </summary>
        public const uint Data_Static_MethodTest_ArrayMethod1 = 12837;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod2 Method.
        /// </summary>
        public const uint Data_Static_MethodTest_ArrayMethod2 = 12840;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod3 Method.
        /// </summary>
        public const uint Data_Static_MethodTest_ArrayMethod3 = 12843;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserScalarMethod1 Method.
        /// </summary>
        public const uint Data_Static_MethodTest_UserScalarMethod1 = 12846;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserScalarMethod2 Method.
        /// </summary>
        public const uint Data_Static_MethodTest_UserScalarMethod2 = 12849;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserArrayMethod1 Method.
        /// </summary>
        public const uint Data_Static_MethodTest_UserArrayMethod1 = 12852;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserArrayMethod2 Method.
        /// </summary>
        public const uint Data_Static_MethodTest_UserArrayMethod2 = 12855;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_GenerateValues Method.
        /// </summary>
        public const uint Data_Dynamic_Scalar_GenerateValues = 12861;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Disable = 12894;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Enable = 12895;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_AddComment = 12896;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Acknowledge = 12916;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_GenerateValues Method.
        /// </summary>
        public const uint Data_Dynamic_Array_GenerateValues = 12949;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Disable = 12982;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Enable = 12983;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_AddComment = 12984;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Acknowledge = 13004;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_GenerateValues Method.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_GenerateValues = 13037;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Disable = 13070;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Enable = 13071;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_AddComment = 13072;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Acknowledge = 13092;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_GenerateValues Method.
        /// </summary>
        public const uint Data_Dynamic_UserArray_GenerateValues = 13120;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Disable = 13153;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Enable = 13154;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_AddComment = 13155;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Acknowledge = 13175;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_GenerateValues Method.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_GenerateValues = 13203;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Disable = 13236;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Enable = 13237;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_AddComment = 13238;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Acknowledge = 13258;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_GenerateValues Method.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_GenerateValues = 13342;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Disable Method.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Disable = 13375;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Enable Method.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Enable = 13376;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_AddComment Method.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_AddComment = 13377;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Acknowledge Method.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Acknowledge = 13397;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Disable Method.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_Disable = 13511;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Enable Method.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_Enable = 13512;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_AddComment Method.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_AddComment = 13513;
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
        /// The identifier for the Data_Mydata Object.
        /// </summary>
        public const uint Data_Mydata = 12137;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete Object.
        /// </summary>
        public const uint Data_Mydata_CycleComplete = 12141;

        /// <summary>
        /// The identifier for the Data_Static Object.
        /// </summary>
        public const uint Data_Static = 12206;

        /// <summary>
        /// The identifier for the Data_Static_Scalar Object.
        /// </summary>
        public const uint Data_Static_Scalar = 12207;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete Object.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete = 12211;

        /// <summary>
        /// The identifier for the Data_Static_Array Object.
        /// </summary>
        public const uint Data_Static_Array = 12295;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete Object.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete = 12299;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar Object.
        /// </summary>
        public const uint Data_Static_UserScalar = 12383;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete Object.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete = 12387;

        /// <summary>
        /// The identifier for the Data_Static_UserArray Object.
        /// </summary>
        public const uint Data_Static_UserArray = 12466;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete Object.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete = 12470;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar Object.
        /// </summary>
        public const uint Data_Static_AnalogScalar = 12549;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete Object.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete = 12553;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray Object.
        /// </summary>
        public const uint Data_Static_AnalogArray = 12688;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete Object.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete = 12692;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest Object.
        /// </summary>
        public const uint Data_Static_MethodTest = 12827;

        /// <summary>
        /// The identifier for the Data_Dynamic Object.
        /// </summary>
        public const uint Data_Dynamic = 12858;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar Object.
        /// </summary>
        public const uint Data_Dynamic_Scalar = 12859;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete Object.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete = 12863;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array Object.
        /// </summary>
        public const uint Data_Dynamic_Array = 12947;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete Object.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete = 12951;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar Object.
        /// </summary>
        public const uint Data_Dynamic_UserScalar = 13035;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete Object.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete = 13039;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray Object.
        /// </summary>
        public const uint Data_Dynamic_UserArray = 13118;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete Object.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete = 13122;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar Object.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar = 13201;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete Object.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete = 13205;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray Object.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray = 13340;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete Object.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete = 13344;

        /// <summary>
        /// The identifier for the Data_Conditions Object.
        /// </summary>
        public const uint Data_Conditions = 13479;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus Object.
        /// </summary>
        public const uint Data_Conditions_SystemStatus = 13480;

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
        public const uint MyObjectType_MyValue1 = 11675;

        /// <summary>
        /// The identifier for the MyObjectType_MyValue2 Variable.
        /// </summary>
        public const uint MyObjectType_MyValue2 = 11676;

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
        /// The identifier for the Data_Mydata_SimulationActive Variable.
        /// </summary>
        public const uint Data_Mydata_SimulationActive = 12138;

        /// <summary>
        /// The identifier for the Data_Mydata_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Mydata_GenerateValues_InputArguments = 12140;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_EventId = 12142;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_EventType = 12143;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_SourceNode = 12144;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_SourceName = 12145;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Time = 12146;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_ReceiveTime = 12147;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_LocalTime = 12148;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Message = 12149;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Severity = 12150;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_ConditionClassId = 12151;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_ConditionClassName = 12152;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_ConditionName = 12153;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_BranchId = 12154;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Retain = 12155;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_EnabledState = 12156;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_EnabledState_Id = 12157;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Quality = 12165;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Quality_SourceTimestamp = 12166;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_LastSeverity = 12167;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_LastSeverity_SourceTimestamp = 12168;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Comment = 12169;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Comment_SourceTimestamp = 12170;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_ClientUserId = 12171;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_AddComment_InputArguments = 12175;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_AckedState = 12176;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_AckedState_Id = 12177;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_ConfirmedState_Id = 12186;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Acknowledge_InputArguments = 12195;

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Mydata_CycleComplete_Confirm_InputArguments = 12197;

        /// <summary>
        /// The identifier for the Data_Mydata_MyValue1 Variable.
        /// </summary>
        public const uint Data_Mydata_MyValue1 = 12198;

        /// <summary>
        /// The identifier for the Data_Mydata_MyValue2 Variable.
        /// </summary>
        public const uint Data_Mydata_MyValue2 = 12199;

        /// <summary>
        /// The identifier for the Data_Mydata_MyValue1_Class Variable.
        /// </summary>
        public const uint Data_Mydata_MyValue1_Class = 12201;

        /// <summary>
        /// The identifier for the Data_Mydata_MyValue1_Place Variable.
        /// </summary>
        public const uint Data_Mydata_MyValue1_Place = 12202;

        /// <summary>
        /// The identifier for the Data_Mydata_MyValue2_Class Variable.
        /// </summary>
        public const uint Data_Mydata_MyValue2_Class = 12204;

        /// <summary>
        /// The identifier for the Data_Mydata_MyValue2_Place Variable.
        /// </summary>
        public const uint Data_Mydata_MyValue2_Place = 12205;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_SimulationActive Variable.
        /// </summary>
        public const uint Data_Static_Scalar_SimulationActive = 12208;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_Scalar_GenerateValues_InputArguments = 12210;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_EventId = 12212;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_EventType = 12213;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_SourceNode = 12214;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_SourceName = 12215;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Time = 12216;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_ReceiveTime = 12217;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_LocalTime = 12218;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Message = 12219;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Severity = 12220;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_ConditionClassId = 12221;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_ConditionClassName = 12222;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_ConditionName = 12223;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_BranchId = 12224;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Retain = 12225;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_EnabledState = 12226;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_EnabledState_Id = 12227;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Quality = 12235;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Quality_SourceTimestamp = 12236;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_LastSeverity = 12237;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_LastSeverity_SourceTimestamp = 12238;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Comment = 12239;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Comment_SourceTimestamp = 12240;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_ClientUserId = 12241;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_AddComment_InputArguments = 12245;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_AckedState = 12246;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_AckedState_Id = 12247;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_ConfirmedState_Id = 12256;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Acknowledge_InputArguments = 12265;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_Scalar_CycleComplete_Confirm_InputArguments = 12267;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_BooleanValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_BooleanValue = 12268;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_SByteValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_SByteValue = 12269;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_ByteValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_ByteValue = 12270;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_Int16Value Variable.
        /// </summary>
        public const uint Data_Static_Scalar_Int16Value = 12271;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_UInt16Value Variable.
        /// </summary>
        public const uint Data_Static_Scalar_UInt16Value = 12272;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_Int32Value Variable.
        /// </summary>
        public const uint Data_Static_Scalar_Int32Value = 12273;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_UInt32Value Variable.
        /// </summary>
        public const uint Data_Static_Scalar_UInt32Value = 12274;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_Int64Value Variable.
        /// </summary>
        public const uint Data_Static_Scalar_Int64Value = 12275;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_UInt64Value Variable.
        /// </summary>
        public const uint Data_Static_Scalar_UInt64Value = 12276;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_FloatValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_FloatValue = 12277;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_DoubleValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_DoubleValue = 12278;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_StringValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_StringValue = 12279;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_DateTimeValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_DateTimeValue = 12280;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_GuidValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_GuidValue = 12281;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_ByteStringValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_ByteStringValue = 12282;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_XmlElementValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_XmlElementValue = 12283;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_NodeIdValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_NodeIdValue = 12284;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_ExpandedNodeIdValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_ExpandedNodeIdValue = 12285;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_QualifiedNameValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_QualifiedNameValue = 12286;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_LocalizedTextValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_LocalizedTextValue = 12287;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_StatusCodeValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_StatusCodeValue = 12288;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_VariantValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_VariantValue = 12289;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_EnumerationValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_EnumerationValue = 12290;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_StructureValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_StructureValue = 12291;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_NumberValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_NumberValue = 12292;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_IntegerValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_IntegerValue = 12293;

        /// <summary>
        /// The identifier for the Data_Static_Scalar_UIntegerValue Variable.
        /// </summary>
        public const uint Data_Static_Scalar_UIntegerValue = 12294;

        /// <summary>
        /// The identifier for the Data_Static_Array_SimulationActive Variable.
        /// </summary>
        public const uint Data_Static_Array_SimulationActive = 12296;

        /// <summary>
        /// The identifier for the Data_Static_Array_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_Array_GenerateValues_InputArguments = 12298;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_EventId = 12300;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_EventType = 12301;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_SourceNode = 12302;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_SourceName = 12303;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Time = 12304;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_ReceiveTime = 12305;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_LocalTime = 12306;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Message = 12307;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Severity = 12308;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_ConditionClassId = 12309;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_ConditionClassName = 12310;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_ConditionName = 12311;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_BranchId = 12312;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Retain = 12313;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_EnabledState = 12314;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_EnabledState_Id = 12315;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Quality = 12323;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Quality_SourceTimestamp = 12324;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_LastSeverity = 12325;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_LastSeverity_SourceTimestamp = 12326;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Comment = 12327;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Comment_SourceTimestamp = 12328;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_ClientUserId = 12329;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_AddComment_InputArguments = 12333;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_AckedState = 12334;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_AckedState_Id = 12335;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_ConfirmedState_Id = 12344;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Acknowledge_InputArguments = 12353;

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_Array_CycleComplete_Confirm_InputArguments = 12355;

        /// <summary>
        /// The identifier for the Data_Static_Array_BooleanValue Variable.
        /// </summary>
        public const uint Data_Static_Array_BooleanValue = 12356;

        /// <summary>
        /// The identifier for the Data_Static_Array_SByteValue Variable.
        /// </summary>
        public const uint Data_Static_Array_SByteValue = 12357;

        /// <summary>
        /// The identifier for the Data_Static_Array_ByteValue Variable.
        /// </summary>
        public const uint Data_Static_Array_ByteValue = 12358;

        /// <summary>
        /// The identifier for the Data_Static_Array_Int16Value Variable.
        /// </summary>
        public const uint Data_Static_Array_Int16Value = 12359;

        /// <summary>
        /// The identifier for the Data_Static_Array_UInt16Value Variable.
        /// </summary>
        public const uint Data_Static_Array_UInt16Value = 12360;

        /// <summary>
        /// The identifier for the Data_Static_Array_Int32Value Variable.
        /// </summary>
        public const uint Data_Static_Array_Int32Value = 12361;

        /// <summary>
        /// The identifier for the Data_Static_Array_UInt32Value Variable.
        /// </summary>
        public const uint Data_Static_Array_UInt32Value = 12362;

        /// <summary>
        /// The identifier for the Data_Static_Array_Int64Value Variable.
        /// </summary>
        public const uint Data_Static_Array_Int64Value = 12363;

        /// <summary>
        /// The identifier for the Data_Static_Array_UInt64Value Variable.
        /// </summary>
        public const uint Data_Static_Array_UInt64Value = 12364;

        /// <summary>
        /// The identifier for the Data_Static_Array_FloatValue Variable.
        /// </summary>
        public const uint Data_Static_Array_FloatValue = 12365;

        /// <summary>
        /// The identifier for the Data_Static_Array_DoubleValue Variable.
        /// </summary>
        public const uint Data_Static_Array_DoubleValue = 12366;

        /// <summary>
        /// The identifier for the Data_Static_Array_StringValue Variable.
        /// </summary>
        public const uint Data_Static_Array_StringValue = 12367;

        /// <summary>
        /// The identifier for the Data_Static_Array_DateTimeValue Variable.
        /// </summary>
        public const uint Data_Static_Array_DateTimeValue = 12368;

        /// <summary>
        /// The identifier for the Data_Static_Array_GuidValue Variable.
        /// </summary>
        public const uint Data_Static_Array_GuidValue = 12369;

        /// <summary>
        /// The identifier for the Data_Static_Array_ByteStringValue Variable.
        /// </summary>
        public const uint Data_Static_Array_ByteStringValue = 12370;

        /// <summary>
        /// The identifier for the Data_Static_Array_XmlElementValue Variable.
        /// </summary>
        public const uint Data_Static_Array_XmlElementValue = 12371;

        /// <summary>
        /// The identifier for the Data_Static_Array_NodeIdValue Variable.
        /// </summary>
        public const uint Data_Static_Array_NodeIdValue = 12372;

        /// <summary>
        /// The identifier for the Data_Static_Array_ExpandedNodeIdValue Variable.
        /// </summary>
        public const uint Data_Static_Array_ExpandedNodeIdValue = 12373;

        /// <summary>
        /// The identifier for the Data_Static_Array_QualifiedNameValue Variable.
        /// </summary>
        public const uint Data_Static_Array_QualifiedNameValue = 12374;

        /// <summary>
        /// The identifier for the Data_Static_Array_LocalizedTextValue Variable.
        /// </summary>
        public const uint Data_Static_Array_LocalizedTextValue = 12375;

        /// <summary>
        /// The identifier for the Data_Static_Array_StatusCodeValue Variable.
        /// </summary>
        public const uint Data_Static_Array_StatusCodeValue = 12376;

        /// <summary>
        /// The identifier for the Data_Static_Array_VariantValue Variable.
        /// </summary>
        public const uint Data_Static_Array_VariantValue = 12377;

        /// <summary>
        /// The identifier for the Data_Static_Array_EnumerationValue Variable.
        /// </summary>
        public const uint Data_Static_Array_EnumerationValue = 12378;

        /// <summary>
        /// The identifier for the Data_Static_Array_StructureValue Variable.
        /// </summary>
        public const uint Data_Static_Array_StructureValue = 12379;

        /// <summary>
        /// The identifier for the Data_Static_Array_NumberValue Variable.
        /// </summary>
        public const uint Data_Static_Array_NumberValue = 12380;

        /// <summary>
        /// The identifier for the Data_Static_Array_IntegerValue Variable.
        /// </summary>
        public const uint Data_Static_Array_IntegerValue = 12381;

        /// <summary>
        /// The identifier for the Data_Static_Array_UIntegerValue Variable.
        /// </summary>
        public const uint Data_Static_Array_UIntegerValue = 12382;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_SimulationActive Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_SimulationActive = 12384;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_GenerateValues_InputArguments = 12386;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_EventId = 12388;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_EventType = 12389;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_SourceNode = 12390;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_SourceName = 12391;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Time = 12392;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_ReceiveTime = 12393;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_LocalTime = 12394;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Message = 12395;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Severity = 12396;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_ConditionClassId = 12397;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_ConditionClassName = 12398;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_ConditionName = 12399;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_BranchId = 12400;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Retain = 12401;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_EnabledState = 12402;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_EnabledState_Id = 12403;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Quality = 12411;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Quality_SourceTimestamp = 12412;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_LastSeverity = 12413;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_LastSeverity_SourceTimestamp = 12414;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Comment = 12415;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Comment_SourceTimestamp = 12416;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_ClientUserId = 12417;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_AddComment_InputArguments = 12421;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_AckedState = 12422;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_AckedState_Id = 12423;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_ConfirmedState_Id = 12432;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Acknowledge_InputArguments = 12441;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_CycleComplete_Confirm_InputArguments = 12443;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_BooleanValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_BooleanValue = 12444;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_SByteValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_SByteValue = 12445;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_ByteValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_ByteValue = 12446;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_Int16Value Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_Int16Value = 12447;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_UInt16Value Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_UInt16Value = 12448;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_Int32Value Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_Int32Value = 12449;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_UInt32Value Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_UInt32Value = 12450;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_Int64Value Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_Int64Value = 12451;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_UInt64Value Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_UInt64Value = 12452;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_FloatValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_FloatValue = 12453;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_DoubleValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_DoubleValue = 12454;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_StringValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_StringValue = 12455;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_DateTimeValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_DateTimeValue = 12456;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_GuidValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_GuidValue = 12457;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_ByteStringValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_ByteStringValue = 12458;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_XmlElementValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_XmlElementValue = 12459;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_NodeIdValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_NodeIdValue = 12460;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_ExpandedNodeIdValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_ExpandedNodeIdValue = 12461;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_QualifiedNameValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_QualifiedNameValue = 12462;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_LocalizedTextValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_LocalizedTextValue = 12463;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_StatusCodeValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_StatusCodeValue = 12464;

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_VariantValue Variable.
        /// </summary>
        public const uint Data_Static_UserScalar_VariantValue = 12465;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_SimulationActive Variable.
        /// </summary>
        public const uint Data_Static_UserArray_SimulationActive = 12467;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_UserArray_GenerateValues_InputArguments = 12469;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_EventId = 12471;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_EventType = 12472;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_SourceNode = 12473;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_SourceName = 12474;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Time = 12475;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_ReceiveTime = 12476;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_LocalTime = 12477;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Message = 12478;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Severity = 12479;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_ConditionClassId = 12480;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_ConditionClassName = 12481;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_ConditionName = 12482;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_BranchId = 12483;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Retain = 12484;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_EnabledState = 12485;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_EnabledState_Id = 12486;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Quality = 12494;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Quality_SourceTimestamp = 12495;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_LastSeverity = 12496;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_LastSeverity_SourceTimestamp = 12497;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Comment = 12498;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Comment_SourceTimestamp = 12499;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_ClientUserId = 12500;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_AddComment_InputArguments = 12504;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_AckedState = 12505;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_AckedState_Id = 12506;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_ConfirmedState_Id = 12515;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Acknowledge_InputArguments = 12524;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_UserArray_CycleComplete_Confirm_InputArguments = 12526;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_BooleanValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_BooleanValue = 12527;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_SByteValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_SByteValue = 12528;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_ByteValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_ByteValue = 12529;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_Int16Value Variable.
        /// </summary>
        public const uint Data_Static_UserArray_Int16Value = 12530;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_UInt16Value Variable.
        /// </summary>
        public const uint Data_Static_UserArray_UInt16Value = 12531;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_Int32Value Variable.
        /// </summary>
        public const uint Data_Static_UserArray_Int32Value = 12532;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_UInt32Value Variable.
        /// </summary>
        public const uint Data_Static_UserArray_UInt32Value = 12533;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_Int64Value Variable.
        /// </summary>
        public const uint Data_Static_UserArray_Int64Value = 12534;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_UInt64Value Variable.
        /// </summary>
        public const uint Data_Static_UserArray_UInt64Value = 12535;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_FloatValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_FloatValue = 12536;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_DoubleValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_DoubleValue = 12537;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_StringValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_StringValue = 12538;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_DateTimeValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_DateTimeValue = 12539;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_GuidValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_GuidValue = 12540;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_ByteStringValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_ByteStringValue = 12541;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_XmlElementValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_XmlElementValue = 12542;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_NodeIdValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_NodeIdValue = 12543;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_ExpandedNodeIdValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_ExpandedNodeIdValue = 12544;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_QualifiedNameValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_QualifiedNameValue = 12545;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_LocalizedTextValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_LocalizedTextValue = 12546;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_StatusCodeValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_StatusCodeValue = 12547;

        /// <summary>
        /// The identifier for the Data_Static_UserArray_VariantValue Variable.
        /// </summary>
        public const uint Data_Static_UserArray_VariantValue = 12548;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_SimulationActive Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_SimulationActive = 12550;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_GenerateValues_InputArguments = 12552;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_EventId = 12554;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_EventType = 12555;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_SourceNode = 12556;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_SourceName = 12557;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Time = 12558;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_ReceiveTime = 12559;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_LocalTime = 12560;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Message = 12561;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Severity = 12562;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_ConditionClassId = 12563;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_ConditionClassName = 12564;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_ConditionName = 12565;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_BranchId = 12566;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Retain = 12567;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_EnabledState = 12568;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_EnabledState_Id = 12569;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Quality = 12577;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Quality_SourceTimestamp = 12578;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_LastSeverity = 12579;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_LastSeverity_SourceTimestamp = 12580;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Comment = 12581;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Comment_SourceTimestamp = 12582;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_ClientUserId = 12583;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_AddComment_InputArguments = 12587;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_AckedState = 12588;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_AckedState_Id = 12589;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_ConfirmedState_Id = 12598;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Acknowledge_InputArguments = 12607;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_CycleComplete_Confirm_InputArguments = 12609;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_SByteValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_SByteValue = 12610;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_SByteValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_SByteValue_EURange = 12614;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_ByteValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_ByteValue = 12616;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_ByteValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_ByteValue_EURange = 12620;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_Int16Value Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_Int16Value = 12622;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_Int16Value_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_Int16Value_EURange = 12626;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UInt16Value Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_UInt16Value = 12628;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UInt16Value_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_UInt16Value_EURange = 12632;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_Int32Value Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_Int32Value = 12634;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_Int32Value_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_Int32Value_EURange = 12638;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UInt32Value Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_UInt32Value = 12640;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UInt32Value_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_UInt32Value_EURange = 12644;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_Int64Value Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_Int64Value = 12646;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_Int64Value_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_Int64Value_EURange = 12650;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UInt64Value Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_UInt64Value = 12652;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UInt64Value_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_UInt64Value_EURange = 12656;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_FloatValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_FloatValue = 12658;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_FloatValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_FloatValue_EURange = 12662;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_DoubleValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_DoubleValue = 12664;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_DoubleValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_DoubleValue_EURange = 12668;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_NumberValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_NumberValue = 12670;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_NumberValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_NumberValue_EURange = 12674;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_IntegerValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_IntegerValue = 12676;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_IntegerValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_IntegerValue_EURange = 12680;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UIntegerValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_UIntegerValue = 12682;

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UIntegerValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogScalar_UIntegerValue_EURange = 12686;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_SimulationActive Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_SimulationActive = 12689;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_GenerateValues_InputArguments = 12691;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_EventId = 12693;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_EventType = 12694;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_SourceNode = 12695;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_SourceName = 12696;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Time = 12697;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_ReceiveTime = 12698;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_LocalTime = 12699;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Message = 12700;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Severity = 12701;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_ConditionClassId = 12702;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_ConditionClassName = 12703;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_ConditionName = 12704;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_BranchId = 12705;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Retain = 12706;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_EnabledState = 12707;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_EnabledState_Id = 12708;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Quality = 12716;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Quality_SourceTimestamp = 12717;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_LastSeverity = 12718;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_LastSeverity_SourceTimestamp = 12719;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Comment = 12720;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Comment_SourceTimestamp = 12721;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_ClientUserId = 12722;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_AddComment_InputArguments = 12726;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_AckedState = 12727;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_AckedState_Id = 12728;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_ConfirmedState_Id = 12737;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Acknowledge_InputArguments = 12746;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_CycleComplete_Confirm_InputArguments = 12748;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_SByteValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_SByteValue = 12749;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_SByteValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_SByteValue_EURange = 12753;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_ByteValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_ByteValue = 12755;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_ByteValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_ByteValue_EURange = 12759;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_Int16Value Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_Int16Value = 12761;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_Int16Value_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_Int16Value_EURange = 12765;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UInt16Value Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_UInt16Value = 12767;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UInt16Value_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_UInt16Value_EURange = 12771;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_Int32Value Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_Int32Value = 12773;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_Int32Value_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_Int32Value_EURange = 12777;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UInt32Value Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_UInt32Value = 12779;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UInt32Value_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_UInt32Value_EURange = 12783;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_Int64Value Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_Int64Value = 12785;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_Int64Value_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_Int64Value_EURange = 12789;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UInt64Value Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_UInt64Value = 12791;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UInt64Value_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_UInt64Value_EURange = 12795;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_FloatValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_FloatValue = 12797;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_FloatValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_FloatValue_EURange = 12801;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_DoubleValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_DoubleValue = 12803;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_DoubleValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_DoubleValue_EURange = 12807;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_NumberValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_NumberValue = 12809;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_NumberValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_NumberValue_EURange = 12813;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_IntegerValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_IntegerValue = 12815;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_IntegerValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_IntegerValue_EURange = 12819;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UIntegerValue Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_UIntegerValue = 12821;

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UIntegerValue_EURange Variable.
        /// </summary>
        public const uint Data_Static_AnalogArray_UIntegerValue_EURange = 12825;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod1_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_ScalarMethod1_InputArguments = 12829;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod1_OutputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_ScalarMethod1_OutputArguments = 12830;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod2_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_ScalarMethod2_InputArguments = 12832;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod2_OutputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_ScalarMethod2_OutputArguments = 12833;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod3_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_ScalarMethod3_InputArguments = 12835;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod3_OutputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_ScalarMethod3_OutputArguments = 12836;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod1_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_ArrayMethod1_InputArguments = 12838;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod1_OutputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_ArrayMethod1_OutputArguments = 12839;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod2_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_ArrayMethod2_InputArguments = 12841;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod2_OutputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_ArrayMethod2_OutputArguments = 12842;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod3_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_ArrayMethod3_InputArguments = 12844;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod3_OutputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_ArrayMethod3_OutputArguments = 12845;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserScalarMethod1_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_UserScalarMethod1_InputArguments = 12847;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserScalarMethod1_OutputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_UserScalarMethod1_OutputArguments = 12848;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserScalarMethod2_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_UserScalarMethod2_InputArguments = 12850;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserScalarMethod2_OutputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_UserScalarMethod2_OutputArguments = 12851;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserArrayMethod1_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_UserArrayMethod1_InputArguments = 12853;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserArrayMethod1_OutputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_UserArrayMethod1_OutputArguments = 12854;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserArrayMethod2_InputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_UserArrayMethod2_InputArguments = 12856;

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserArrayMethod2_OutputArguments Variable.
        /// </summary>
        public const uint Data_Static_MethodTest_UserArrayMethod2_OutputArguments = 12857;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_SimulationActive Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_SimulationActive = 12860;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_GenerateValues_InputArguments = 12862;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_EventId = 12864;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_EventType = 12865;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_SourceNode = 12866;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_SourceName = 12867;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Time = 12868;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_ReceiveTime = 12869;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_LocalTime = 12870;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Message = 12871;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Severity = 12872;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_ConditionClassId = 12873;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_ConditionClassName = 12874;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_ConditionName = 12875;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_BranchId = 12876;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Retain = 12877;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_EnabledState = 12878;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_EnabledState_Id = 12879;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Quality = 12887;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Quality_SourceTimestamp = 12888;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_LastSeverity = 12889;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_LastSeverity_SourceTimestamp = 12890;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Comment = 12891;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Comment_SourceTimestamp = 12892;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_ClientUserId = 12893;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_AddComment_InputArguments = 12897;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_AckedState = 12898;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_AckedState_Id = 12899;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_ConfirmedState_Id = 12908;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Acknowledge_InputArguments = 12917;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_CycleComplete_Confirm_InputArguments = 12919;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_BooleanValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_BooleanValue = 12920;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_SByteValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_SByteValue = 12921;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_ByteValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_ByteValue = 12922;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_Int16Value Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_Int16Value = 12923;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_UInt16Value Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_UInt16Value = 12924;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_Int32Value Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_Int32Value = 12925;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_UInt32Value Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_UInt32Value = 12926;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_Int64Value Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_Int64Value = 12927;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_UInt64Value Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_UInt64Value = 12928;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_FloatValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_FloatValue = 12929;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_DoubleValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_DoubleValue = 12930;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_StringValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_StringValue = 12931;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_DateTimeValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_DateTimeValue = 12932;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_GuidValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_GuidValue = 12933;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_ByteStringValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_ByteStringValue = 12934;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_XmlElementValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_XmlElementValue = 12935;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_NodeIdValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_NodeIdValue = 12936;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_ExpandedNodeIdValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_ExpandedNodeIdValue = 12937;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_QualifiedNameValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_QualifiedNameValue = 12938;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_LocalizedTextValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_LocalizedTextValue = 12939;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_StatusCodeValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_StatusCodeValue = 12940;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_VariantValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_VariantValue = 12941;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_EnumerationValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_EnumerationValue = 12942;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_StructureValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_StructureValue = 12943;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_NumberValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_NumberValue = 12944;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_IntegerValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_IntegerValue = 12945;

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_UIntegerValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Scalar_UIntegerValue = 12946;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_SimulationActive Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_SimulationActive = 12948;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_GenerateValues_InputArguments = 12950;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_EventId = 12952;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_EventType = 12953;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_SourceNode = 12954;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_SourceName = 12955;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Time = 12956;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_ReceiveTime = 12957;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_LocalTime = 12958;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Message = 12959;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Severity = 12960;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_ConditionClassId = 12961;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_ConditionClassName = 12962;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_ConditionName = 12963;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_BranchId = 12964;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Retain = 12965;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_EnabledState = 12966;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_EnabledState_Id = 12967;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Quality = 12975;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Quality_SourceTimestamp = 12976;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_LastSeverity = 12977;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_LastSeverity_SourceTimestamp = 12978;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Comment = 12979;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Comment_SourceTimestamp = 12980;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_ClientUserId = 12981;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_AddComment_InputArguments = 12985;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_AckedState = 12986;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_AckedState_Id = 12987;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_ConfirmedState_Id = 12996;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Acknowledge_InputArguments = 13005;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_CycleComplete_Confirm_InputArguments = 13007;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_BooleanValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_BooleanValue = 13008;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_SByteValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_SByteValue = 13009;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_ByteValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_ByteValue = 13010;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_Int16Value Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_Int16Value = 13011;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_UInt16Value Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_UInt16Value = 13012;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_Int32Value Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_Int32Value = 13013;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_UInt32Value Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_UInt32Value = 13014;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_Int64Value Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_Int64Value = 13015;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_UInt64Value Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_UInt64Value = 13016;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_FloatValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_FloatValue = 13017;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_DoubleValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_DoubleValue = 13018;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_StringValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_StringValue = 13019;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_DateTimeValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_DateTimeValue = 13020;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_GuidValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_GuidValue = 13021;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_ByteStringValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_ByteStringValue = 13022;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_XmlElementValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_XmlElementValue = 13023;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_NodeIdValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_NodeIdValue = 13024;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_ExpandedNodeIdValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_ExpandedNodeIdValue = 13025;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_QualifiedNameValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_QualifiedNameValue = 13026;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_LocalizedTextValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_LocalizedTextValue = 13027;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_StatusCodeValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_StatusCodeValue = 13028;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_VariantValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_VariantValue = 13029;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_EnumerationValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_EnumerationValue = 13030;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_StructureValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_StructureValue = 13031;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_NumberValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_NumberValue = 13032;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_IntegerValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_IntegerValue = 13033;

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_UIntegerValue Variable.
        /// </summary>
        public const uint Data_Dynamic_Array_UIntegerValue = 13034;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_SimulationActive Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_SimulationActive = 13036;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_GenerateValues_InputArguments = 13038;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_EventId = 13040;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_EventType = 13041;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_SourceNode = 13042;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_SourceName = 13043;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Time = 13044;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_ReceiveTime = 13045;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_LocalTime = 13046;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Message = 13047;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Severity = 13048;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_ConditionClassId = 13049;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_ConditionClassName = 13050;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_ConditionName = 13051;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_BranchId = 13052;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Retain = 13053;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_EnabledState = 13054;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_EnabledState_Id = 13055;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Quality = 13063;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Quality_SourceTimestamp = 13064;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_LastSeverity = 13065;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_LastSeverity_SourceTimestamp = 13066;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Comment = 13067;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Comment_SourceTimestamp = 13068;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_ClientUserId = 13069;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_AddComment_InputArguments = 13073;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_AckedState = 13074;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_AckedState_Id = 13075;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_ConfirmedState_Id = 13084;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Acknowledge_InputArguments = 13093;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_CycleComplete_Confirm_InputArguments = 13095;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_BooleanValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_BooleanValue = 13096;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_SByteValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_SByteValue = 13097;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_ByteValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_ByteValue = 13098;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_Int16Value Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_Int16Value = 13099;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_UInt16Value Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_UInt16Value = 13100;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_Int32Value Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_Int32Value = 13101;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_UInt32Value Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_UInt32Value = 13102;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_Int64Value Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_Int64Value = 13103;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_UInt64Value Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_UInt64Value = 13104;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_FloatValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_FloatValue = 13105;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_DoubleValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_DoubleValue = 13106;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_StringValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_StringValue = 13107;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_DateTimeValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_DateTimeValue = 13108;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_GuidValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_GuidValue = 13109;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_ByteStringValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_ByteStringValue = 13110;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_XmlElementValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_XmlElementValue = 13111;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_NodeIdValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_NodeIdValue = 13112;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_ExpandedNodeIdValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_ExpandedNodeIdValue = 13113;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_QualifiedNameValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_QualifiedNameValue = 13114;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_LocalizedTextValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_LocalizedTextValue = 13115;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_StatusCodeValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_StatusCodeValue = 13116;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_VariantValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserScalar_VariantValue = 13117;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_SimulationActive Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_SimulationActive = 13119;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_GenerateValues_InputArguments = 13121;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_EventId = 13123;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_EventType = 13124;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_SourceNode = 13125;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_SourceName = 13126;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Time = 13127;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_ReceiveTime = 13128;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_LocalTime = 13129;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Message = 13130;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Severity = 13131;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_ConditionClassId = 13132;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_ConditionClassName = 13133;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_ConditionName = 13134;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_BranchId = 13135;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Retain = 13136;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_EnabledState = 13137;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_EnabledState_Id = 13138;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Quality = 13146;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Quality_SourceTimestamp = 13147;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_LastSeverity = 13148;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_LastSeverity_SourceTimestamp = 13149;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Comment = 13150;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Comment_SourceTimestamp = 13151;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_ClientUserId = 13152;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_AddComment_InputArguments = 13156;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_AckedState = 13157;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_AckedState_Id = 13158;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_ConfirmedState_Id = 13167;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Acknowledge_InputArguments = 13176;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_CycleComplete_Confirm_InputArguments = 13178;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_BooleanValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_BooleanValue = 13179;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_SByteValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_SByteValue = 13180;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_ByteValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_ByteValue = 13181;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_Int16Value Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_Int16Value = 13182;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_UInt16Value Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_UInt16Value = 13183;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_Int32Value Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_Int32Value = 13184;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_UInt32Value Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_UInt32Value = 13185;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_Int64Value Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_Int64Value = 13186;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_UInt64Value Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_UInt64Value = 13187;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_FloatValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_FloatValue = 13188;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_DoubleValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_DoubleValue = 13189;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_StringValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_StringValue = 13190;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_DateTimeValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_DateTimeValue = 13191;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_GuidValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_GuidValue = 13192;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_ByteStringValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_ByteStringValue = 13193;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_XmlElementValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_XmlElementValue = 13194;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_NodeIdValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_NodeIdValue = 13195;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_ExpandedNodeIdValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_ExpandedNodeIdValue = 13196;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_QualifiedNameValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_QualifiedNameValue = 13197;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_LocalizedTextValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_LocalizedTextValue = 13198;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_StatusCodeValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_StatusCodeValue = 13199;

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_VariantValue Variable.
        /// </summary>
        public const uint Data_Dynamic_UserArray_VariantValue = 13200;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_SimulationActive Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_SimulationActive = 13202;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_GenerateValues_InputArguments = 13204;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_EventId = 13206;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_EventType = 13207;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_SourceNode = 13208;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_SourceName = 13209;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Time = 13210;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_ReceiveTime = 13211;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_LocalTime = 13212;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Message = 13213;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Severity = 13214;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_ConditionClassId = 13215;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_ConditionClassName = 13216;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_ConditionName = 13217;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_BranchId = 13218;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Retain = 13219;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_EnabledState = 13220;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_EnabledState_Id = 13221;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Quality = 13229;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Quality_SourceTimestamp = 13230;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_LastSeverity = 13231;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_LastSeverity_SourceTimestamp = 13232;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Comment = 13233;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Comment_SourceTimestamp = 13234;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_ClientUserId = 13235;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_AddComment_InputArguments = 13239;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_AckedState = 13240;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_AckedState_Id = 13241;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_ConfirmedState_Id = 13250;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Acknowledge_InputArguments = 13259;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_CycleComplete_Confirm_InputArguments = 13261;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_SByteValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_SByteValue = 13262;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_SByteValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_SByteValue_EURange = 13266;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_ByteValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_ByteValue = 13268;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_ByteValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_ByteValue_EURange = 13272;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_Int16Value Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_Int16Value = 13274;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_Int16Value_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_Int16Value_EURange = 13278;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UInt16Value Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_UInt16Value = 13280;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UInt16Value_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_UInt16Value_EURange = 13284;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_Int32Value Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_Int32Value = 13286;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_Int32Value_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_Int32Value_EURange = 13290;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UInt32Value Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_UInt32Value = 13292;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UInt32Value_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_UInt32Value_EURange = 13296;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_Int64Value Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_Int64Value = 13298;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_Int64Value_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_Int64Value_EURange = 13302;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UInt64Value Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_UInt64Value = 13304;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UInt64Value_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_UInt64Value_EURange = 13308;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_FloatValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_FloatValue = 13310;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_FloatValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_FloatValue_EURange = 13314;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_DoubleValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_DoubleValue = 13316;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_DoubleValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_DoubleValue_EURange = 13320;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_NumberValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_NumberValue = 13322;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_NumberValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_NumberValue_EURange = 13326;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_IntegerValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_IntegerValue = 13328;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_IntegerValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_IntegerValue_EURange = 13332;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UIntegerValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_UIntegerValue = 13334;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UIntegerValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogScalar_UIntegerValue_EURange = 13338;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_SimulationActive Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_SimulationActive = 13341;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_GenerateValues_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_GenerateValues_InputArguments = 13343;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_EventId Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_EventId = 13345;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_EventType Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_EventType = 13346;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_SourceNode Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_SourceNode = 13347;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_SourceName Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_SourceName = 13348;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Time Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Time = 13349;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_ReceiveTime = 13350;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_LocalTime Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_LocalTime = 13351;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Message Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Message = 13352;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Severity Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Severity = 13353;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_ConditionClassId = 13354;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_ConditionClassName = 13355;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_ConditionName Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_ConditionName = 13356;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_BranchId Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_BranchId = 13357;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Retain Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Retain = 13358;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_EnabledState Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_EnabledState = 13359;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_EnabledState_Id = 13360;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Quality Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Quality = 13368;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Quality_SourceTimestamp = 13369;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_LastSeverity Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_LastSeverity = 13370;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_LastSeverity_SourceTimestamp = 13371;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Comment Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Comment = 13372;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Comment_SourceTimestamp = 13373;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_ClientUserId Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_ClientUserId = 13374;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_AddComment_InputArguments = 13378;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_AckedState Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_AckedState = 13379;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_AckedState_Id = 13380;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_ConfirmedState_Id = 13389;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Acknowledge_InputArguments = 13398;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_CycleComplete_Confirm_InputArguments = 13400;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_SByteValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_SByteValue = 13401;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_SByteValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_SByteValue_EURange = 13405;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_ByteValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_ByteValue = 13407;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_ByteValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_ByteValue_EURange = 13411;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_Int16Value Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_Int16Value = 13413;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_Int16Value_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_Int16Value_EURange = 13417;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UInt16Value Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_UInt16Value = 13419;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UInt16Value_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_UInt16Value_EURange = 13423;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_Int32Value Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_Int32Value = 13425;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_Int32Value_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_Int32Value_EURange = 13429;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UInt32Value Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_UInt32Value = 13431;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UInt32Value_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_UInt32Value_EURange = 13435;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_Int64Value Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_Int64Value = 13437;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_Int64Value_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_Int64Value_EURange = 13441;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UInt64Value Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_UInt64Value = 13443;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UInt64Value_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_UInt64Value_EURange = 13447;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_FloatValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_FloatValue = 13449;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_FloatValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_FloatValue_EURange = 13453;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_DoubleValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_DoubleValue = 13455;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_DoubleValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_DoubleValue_EURange = 13459;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_NumberValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_NumberValue = 13461;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_NumberValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_NumberValue_EURange = 13465;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_IntegerValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_IntegerValue = 13467;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_IntegerValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_IntegerValue_EURange = 13471;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UIntegerValue Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_UIntegerValue = 13473;

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UIntegerValue_EURange Variable.
        /// </summary>
        public const uint Data_Dynamic_AnalogArray_UIntegerValue_EURange = 13477;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_EventId Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_EventId = 13481;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_EventType Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_EventType = 13482;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_SourceNode Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_SourceNode = 13483;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_SourceName Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_SourceName = 13484;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Time Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_Time = 13485;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_ReceiveTime Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_ReceiveTime = 13486;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_LocalTime Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_LocalTime = 13487;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Message Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_Message = 13488;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Severity Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_Severity = 13489;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_ConditionClassId Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_ConditionClassId = 13490;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_ConditionClassName Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_ConditionClassName = 13491;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_ConditionName Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_ConditionName = 13492;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_BranchId Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_BranchId = 13493;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Retain Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_Retain = 13494;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_EnabledState Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_EnabledState = 13495;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_EnabledState_Id Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_EnabledState_Id = 13496;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Quality Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_Quality = 13504;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Quality_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_Quality_SourceTimestamp = 13505;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_LastSeverity Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_LastSeverity = 13506;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_LastSeverity_SourceTimestamp = 13507;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Comment Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_Comment = 13508;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Comment_SourceTimestamp Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_Comment_SourceTimestamp = 13509;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_ClientUserId Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_ClientUserId = 13510;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_AddComment_InputArguments Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_AddComment_InputArguments = 13514;

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_MonitoredNodeCount Variable.
        /// </summary>
        public const uint Data_Conditions_SystemStatus_MonitoredNodeCount = 13515;

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

        /// <summary>
        /// The identifier for the Data_Mydata_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Mydata_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Mydata_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Mydata_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Mydata_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Mydata_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Static_Scalar_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Static_Scalar_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Static_Scalar_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Static_Scalar_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Static_Scalar_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Static_Array_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Static_Array_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Static_Array_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Static_Array_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Static_Array_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Static_UserScalar_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Static_UserScalar_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Static_UserScalar_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Static_UserScalar_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Static_UserScalar_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Static_UserArray_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Static_UserArray_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Static_UserArray_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Static_UserArray_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Static_UserArray_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Static_AnalogScalar_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Static_AnalogScalar_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Static_AnalogScalar_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Static_AnalogScalar_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Static_AnalogScalar_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Static_AnalogArray_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Static_AnalogArray_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Static_AnalogArray_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Static_AnalogArray_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Static_AnalogArray_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod1 Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ScalarMethod1 = new ExpandedNodeId(TestData.Methods.Data_Static_MethodTest_ScalarMethod1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod2 Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ScalarMethod2 = new ExpandedNodeId(TestData.Methods.Data_Static_MethodTest_ScalarMethod2, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod3 Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ScalarMethod3 = new ExpandedNodeId(TestData.Methods.Data_Static_MethodTest_ScalarMethod3, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod1 Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ArrayMethod1 = new ExpandedNodeId(TestData.Methods.Data_Static_MethodTest_ArrayMethod1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod2 Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ArrayMethod2 = new ExpandedNodeId(TestData.Methods.Data_Static_MethodTest_ArrayMethod2, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod3 Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ArrayMethod3 = new ExpandedNodeId(TestData.Methods.Data_Static_MethodTest_ArrayMethod3, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserScalarMethod1 Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_UserScalarMethod1 = new ExpandedNodeId(TestData.Methods.Data_Static_MethodTest_UserScalarMethod1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserScalarMethod2 Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_UserScalarMethod2 = new ExpandedNodeId(TestData.Methods.Data_Static_MethodTest_UserScalarMethod2, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserArrayMethod1 Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_UserArrayMethod1 = new ExpandedNodeId(TestData.Methods.Data_Static_MethodTest_UserArrayMethod1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserArrayMethod2 Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_UserArrayMethod2 = new ExpandedNodeId(TestData.Methods.Data_Static_MethodTest_UserArrayMethod2, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Dynamic_Scalar_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Dynamic_Scalar_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Dynamic_Scalar_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Dynamic_Scalar_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Dynamic_Scalar_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Dynamic_Array_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Dynamic_Array_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Dynamic_Array_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Dynamic_Array_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Dynamic_Array_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Dynamic_UserScalar_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Dynamic_UserScalar_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Dynamic_UserScalar_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Dynamic_UserScalar_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Dynamic_UserScalar_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Dynamic_UserArray_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Dynamic_UserArray_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Dynamic_UserArray_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Dynamic_UserArray_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Dynamic_UserArray_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Dynamic_AnalogScalar_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Dynamic_AnalogScalar_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Dynamic_AnalogScalar_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Dynamic_AnalogScalar_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Dynamic_AnalogScalar_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_GenerateValues Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_GenerateValues = new ExpandedNodeId(TestData.Methods.Data_Dynamic_AnalogArray_GenerateValues, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Disable = new ExpandedNodeId(TestData.Methods.Data_Dynamic_AnalogArray_CycleComplete_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Enable = new ExpandedNodeId(TestData.Methods.Data_Dynamic_AnalogArray_CycleComplete_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_AddComment = new ExpandedNodeId(TestData.Methods.Data_Dynamic_AnalogArray_CycleComplete_AddComment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Acknowledge Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Acknowledge = new ExpandedNodeId(TestData.Methods.Data_Dynamic_AnalogArray_CycleComplete_Acknowledge, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Disable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_Disable = new ExpandedNodeId(TestData.Methods.Data_Conditions_SystemStatus_Disable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Enable Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_Enable = new ExpandedNodeId(TestData.Methods.Data_Conditions_SystemStatus_Enable, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_AddComment Method.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_AddComment = new ExpandedNodeId(TestData.Methods.Data_Conditions_SystemStatus_AddComment, TestData.Namespaces.TestData);
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
        /// The identifier for the Data_Mydata Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata = new ExpandedNodeId(TestData.Objects.Data_Mydata, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Mydata_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static = new ExpandedNodeId(TestData.Objects.Data_Static, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar = new ExpandedNodeId(TestData.Objects.Data_Static_Scalar, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Static_Scalar_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array = new ExpandedNodeId(TestData.Objects.Data_Static_Array, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Static_Array_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar = new ExpandedNodeId(TestData.Objects.Data_Static_UserScalar, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Static_UserScalar_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray = new ExpandedNodeId(TestData.Objects.Data_Static_UserArray, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Static_UserArray_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar = new ExpandedNodeId(TestData.Objects.Data_Static_AnalogScalar, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Static_AnalogScalar_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray = new ExpandedNodeId(TestData.Objects.Data_Static_AnalogArray, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Static_AnalogArray_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest = new ExpandedNodeId(TestData.Objects.Data_Static_MethodTest, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic = new ExpandedNodeId(TestData.Objects.Data_Dynamic, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar = new ExpandedNodeId(TestData.Objects.Data_Dynamic_Scalar, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Dynamic_Scalar_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array = new ExpandedNodeId(TestData.Objects.Data_Dynamic_Array, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Dynamic_Array_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar = new ExpandedNodeId(TestData.Objects.Data_Dynamic_UserScalar, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Dynamic_UserScalar_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray = new ExpandedNodeId(TestData.Objects.Data_Dynamic_UserArray, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Dynamic_UserArray_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar = new ExpandedNodeId(TestData.Objects.Data_Dynamic_AnalogScalar, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Dynamic_AnalogScalar_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray = new ExpandedNodeId(TestData.Objects.Data_Dynamic_AnalogArray, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete = new ExpandedNodeId(TestData.Objects.Data_Dynamic_AnalogArray_CycleComplete, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions = new ExpandedNodeId(TestData.Objects.Data_Conditions, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus Object.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus = new ExpandedNodeId(TestData.Objects.Data_Conditions_SystemStatus, TestData.Namespaces.TestData);

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
        /// The identifier for the MyObjectType_MyValue2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId MyObjectType_MyValue2 = new ExpandedNodeId(TestData.Variables.MyObjectType_MyValue2, TestData.Namespaces.TestData);

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
        /// The identifier for the Data_Mydata_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Mydata_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Mydata_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Mydata_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_MyValue1 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_MyValue1 = new ExpandedNodeId(TestData.Variables.Data_Mydata_MyValue1, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_MyValue2 Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_MyValue2 = new ExpandedNodeId(TestData.Variables.Data_Mydata_MyValue2, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_MyValue1_Class Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_MyValue1_Class = new ExpandedNodeId(TestData.Variables.Data_Mydata_MyValue1_Class, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_MyValue1_Place Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_MyValue1_Place = new ExpandedNodeId(TestData.Variables.Data_Mydata_MyValue1_Place, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_MyValue2_Class Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_MyValue2_Class = new ExpandedNodeId(TestData.Variables.Data_Mydata_MyValue2_Class, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Mydata_MyValue2_Place Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Mydata_MyValue2_Place = new ExpandedNodeId(TestData.Variables.Data_Mydata_MyValue2_Place, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_BooleanValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_BooleanValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_BooleanValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_SByteValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_ByteValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_Int16Value = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_UInt16Value = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_Int32Value = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_UInt32Value = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_Int64Value = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_UInt64Value = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_FloatValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_DoubleValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_StringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_StringValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_StringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_DateTimeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_DateTimeValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_DateTimeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_GuidValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_GuidValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_GuidValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_ByteStringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_ByteStringValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_ByteStringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_XmlElementValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_XmlElementValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_XmlElementValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_NodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_NodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_NodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_ExpandedNodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_ExpandedNodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_ExpandedNodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_QualifiedNameValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_QualifiedNameValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_QualifiedNameValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_LocalizedTextValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_LocalizedTextValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_LocalizedTextValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_StatusCodeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_StatusCodeValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_StatusCodeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_VariantValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_VariantValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_VariantValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_EnumerationValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_EnumerationValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_EnumerationValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_StructureValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_StructureValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_StructureValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_NumberValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_NumberValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_NumberValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_IntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_IntegerValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_IntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Scalar_UIntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Scalar_UIntegerValue = new ExpandedNodeId(TestData.Variables.Data_Static_Scalar_UIntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Static_Array_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_Array_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_Array_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_BooleanValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_BooleanValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_BooleanValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_SByteValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_ByteValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_Int16Value = new ExpandedNodeId(TestData.Variables.Data_Static_Array_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_UInt16Value = new ExpandedNodeId(TestData.Variables.Data_Static_Array_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_Int32Value = new ExpandedNodeId(TestData.Variables.Data_Static_Array_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_UInt32Value = new ExpandedNodeId(TestData.Variables.Data_Static_Array_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_Int64Value = new ExpandedNodeId(TestData.Variables.Data_Static_Array_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_UInt64Value = new ExpandedNodeId(TestData.Variables.Data_Static_Array_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_FloatValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_DoubleValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_StringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_StringValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_StringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_DateTimeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_DateTimeValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_DateTimeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_GuidValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_GuidValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_GuidValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_ByteStringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_ByteStringValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_ByteStringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_XmlElementValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_XmlElementValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_XmlElementValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_NodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_NodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_NodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_ExpandedNodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_ExpandedNodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_ExpandedNodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_QualifiedNameValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_QualifiedNameValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_QualifiedNameValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_LocalizedTextValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_LocalizedTextValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_LocalizedTextValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_StatusCodeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_StatusCodeValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_StatusCodeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_VariantValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_VariantValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_VariantValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_EnumerationValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_EnumerationValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_EnumerationValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_StructureValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_StructureValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_StructureValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_NumberValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_NumberValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_NumberValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_IntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_IntegerValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_IntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_Array_UIntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_Array_UIntegerValue = new ExpandedNodeId(TestData.Variables.Data_Static_Array_UIntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_BooleanValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_BooleanValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_BooleanValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_SByteValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_ByteValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_Int16Value = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_UInt16Value = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_Int32Value = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_UInt32Value = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_Int64Value = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_UInt64Value = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_FloatValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_DoubleValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_StringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_StringValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_StringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_DateTimeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_DateTimeValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_DateTimeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_GuidValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_GuidValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_GuidValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_ByteStringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_ByteStringValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_ByteStringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_XmlElementValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_XmlElementValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_XmlElementValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_NodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_NodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_NodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_ExpandedNodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_ExpandedNodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_ExpandedNodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_QualifiedNameValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_QualifiedNameValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_QualifiedNameValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_LocalizedTextValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_LocalizedTextValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_LocalizedTextValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_StatusCodeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_StatusCodeValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_StatusCodeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserScalar_VariantValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserScalar_VariantValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserScalar_VariantValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_BooleanValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_BooleanValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_BooleanValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_SByteValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_ByteValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_Int16Value = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_UInt16Value = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_Int32Value = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_UInt32Value = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_Int64Value = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_UInt64Value = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_FloatValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_DoubleValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_StringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_StringValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_StringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_DateTimeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_DateTimeValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_DateTimeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_GuidValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_GuidValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_GuidValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_ByteStringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_ByteStringValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_ByteStringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_XmlElementValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_XmlElementValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_XmlElementValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_NodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_NodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_NodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_ExpandedNodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_ExpandedNodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_ExpandedNodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_QualifiedNameValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_QualifiedNameValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_QualifiedNameValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_LocalizedTextValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_LocalizedTextValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_LocalizedTextValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_StatusCodeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_StatusCodeValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_StatusCodeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_UserArray_VariantValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_UserArray_VariantValue = new ExpandedNodeId(TestData.Variables.Data_Static_UserArray_VariantValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_SByteValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_SByteValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_SByteValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_SByteValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_ByteValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_ByteValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_ByteValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_ByteValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_Int16Value = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_Int16Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_Int16Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_Int16Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_UInt16Value = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UInt16Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_UInt16Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_UInt16Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_Int32Value = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_Int32Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_Int32Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_Int32Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_UInt32Value = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UInt32Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_UInt32Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_UInt32Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_Int64Value = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_Int64Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_Int64Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_Int64Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_UInt64Value = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UInt64Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_UInt64Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_UInt64Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_FloatValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_FloatValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_FloatValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_FloatValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_DoubleValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_DoubleValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_DoubleValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_DoubleValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_NumberValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_NumberValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_NumberValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_NumberValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_NumberValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_NumberValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_IntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_IntegerValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_IntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_IntegerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_IntegerValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_IntegerValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UIntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_UIntegerValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_UIntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogScalar_UIntegerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogScalar_UIntegerValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogScalar_UIntegerValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_SByteValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_SByteValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_SByteValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_SByteValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_ByteValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_ByteValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_ByteValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_ByteValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_Int16Value = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_Int16Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_Int16Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_Int16Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_UInt16Value = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UInt16Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_UInt16Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_UInt16Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_Int32Value = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_Int32Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_Int32Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_Int32Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_UInt32Value = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UInt32Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_UInt32Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_UInt32Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_Int64Value = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_Int64Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_Int64Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_Int64Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_UInt64Value = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UInt64Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_UInt64Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_UInt64Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_FloatValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_FloatValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_FloatValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_FloatValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_DoubleValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_DoubleValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_DoubleValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_DoubleValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_NumberValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_NumberValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_NumberValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_NumberValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_NumberValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_NumberValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_IntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_IntegerValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_IntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_IntegerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_IntegerValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_IntegerValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UIntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_UIntegerValue = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_UIntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_AnalogArray_UIntegerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_AnalogArray_UIntegerValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Static_AnalogArray_UIntegerValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod1_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ScalarMethod1_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_ScalarMethod1_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod1_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ScalarMethod1_OutputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_ScalarMethod1_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ScalarMethod2_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_ScalarMethod2_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod2_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ScalarMethod2_OutputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_ScalarMethod2_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod3_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ScalarMethod3_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_ScalarMethod3_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ScalarMethod3_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ScalarMethod3_OutputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_ScalarMethod3_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod1_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ArrayMethod1_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_ArrayMethod1_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod1_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ArrayMethod1_OutputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_ArrayMethod1_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ArrayMethod2_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_ArrayMethod2_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod2_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ArrayMethod2_OutputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_ArrayMethod2_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod3_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ArrayMethod3_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_ArrayMethod3_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_ArrayMethod3_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_ArrayMethod3_OutputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_ArrayMethod3_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserScalarMethod1_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_UserScalarMethod1_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_UserScalarMethod1_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserScalarMethod1_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_UserScalarMethod1_OutputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_UserScalarMethod1_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserScalarMethod2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_UserScalarMethod2_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_UserScalarMethod2_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserScalarMethod2_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_UserScalarMethod2_OutputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_UserScalarMethod2_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserArrayMethod1_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_UserArrayMethod1_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_UserArrayMethod1_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserArrayMethod1_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_UserArrayMethod1_OutputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_UserArrayMethod1_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserArrayMethod2_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_UserArrayMethod2_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_UserArrayMethod2_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Static_MethodTest_UserArrayMethod2_OutputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Static_MethodTest_UserArrayMethod2_OutputArguments = new ExpandedNodeId(TestData.Variables.Data_Static_MethodTest_UserArrayMethod2_OutputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_BooleanValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_BooleanValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_BooleanValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_SByteValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_ByteValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_Int16Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_UInt16Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_Int32Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_UInt32Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_Int64Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_UInt64Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_FloatValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_DoubleValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_StringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_StringValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_StringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_DateTimeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_DateTimeValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_DateTimeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_GuidValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_GuidValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_GuidValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_ByteStringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_ByteStringValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_ByteStringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_XmlElementValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_XmlElementValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_XmlElementValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_NodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_NodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_NodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_ExpandedNodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_ExpandedNodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_ExpandedNodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_QualifiedNameValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_QualifiedNameValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_QualifiedNameValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_LocalizedTextValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_LocalizedTextValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_LocalizedTextValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_StatusCodeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_StatusCodeValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_StatusCodeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_VariantValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_VariantValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_VariantValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_EnumerationValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_EnumerationValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_EnumerationValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_StructureValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_StructureValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_StructureValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_NumberValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_NumberValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_NumberValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_IntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_IntegerValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_IntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Scalar_UIntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Scalar_UIntegerValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Scalar_UIntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_BooleanValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_BooleanValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_BooleanValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_SByteValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_ByteValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_Int16Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_UInt16Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_Int32Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_UInt32Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_Int64Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_UInt64Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_FloatValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_DoubleValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_StringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_StringValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_StringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_DateTimeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_DateTimeValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_DateTimeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_GuidValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_GuidValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_GuidValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_ByteStringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_ByteStringValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_ByteStringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_XmlElementValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_XmlElementValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_XmlElementValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_NodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_NodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_NodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_ExpandedNodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_ExpandedNodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_ExpandedNodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_QualifiedNameValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_QualifiedNameValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_QualifiedNameValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_LocalizedTextValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_LocalizedTextValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_LocalizedTextValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_StatusCodeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_StatusCodeValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_StatusCodeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_VariantValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_VariantValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_VariantValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_EnumerationValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_EnumerationValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_EnumerationValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_StructureValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_StructureValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_StructureValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_NumberValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_NumberValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_NumberValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_IntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_IntegerValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_IntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_Array_UIntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_Array_UIntegerValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_Array_UIntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_BooleanValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_BooleanValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_BooleanValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_SByteValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_ByteValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_Int16Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_UInt16Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_Int32Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_UInt32Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_Int64Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_UInt64Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_FloatValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_DoubleValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_StringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_StringValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_StringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_DateTimeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_DateTimeValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_DateTimeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_GuidValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_GuidValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_GuidValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_ByteStringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_ByteStringValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_ByteStringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_XmlElementValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_XmlElementValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_XmlElementValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_NodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_NodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_NodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_ExpandedNodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_ExpandedNodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_ExpandedNodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_QualifiedNameValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_QualifiedNameValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_QualifiedNameValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_LocalizedTextValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_LocalizedTextValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_LocalizedTextValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_StatusCodeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_StatusCodeValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_StatusCodeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserScalar_VariantValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserScalar_VariantValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserScalar_VariantValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_BooleanValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_BooleanValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_BooleanValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_SByteValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_ByteValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_Int16Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_UInt16Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_Int32Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_UInt32Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_Int64Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_UInt64Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_FloatValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_DoubleValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_StringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_StringValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_StringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_DateTimeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_DateTimeValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_DateTimeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_GuidValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_GuidValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_GuidValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_ByteStringValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_ByteStringValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_ByteStringValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_XmlElementValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_XmlElementValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_XmlElementValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_NodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_NodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_NodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_ExpandedNodeIdValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_ExpandedNodeIdValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_ExpandedNodeIdValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_QualifiedNameValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_QualifiedNameValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_QualifiedNameValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_LocalizedTextValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_LocalizedTextValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_LocalizedTextValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_StatusCodeValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_StatusCodeValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_StatusCodeValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_UserArray_VariantValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_UserArray_VariantValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_UserArray_VariantValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_SByteValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_SByteValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_SByteValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_SByteValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_ByteValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_ByteValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_ByteValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_ByteValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_Int16Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_Int16Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_Int16Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_Int16Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_UInt16Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UInt16Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_UInt16Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_UInt16Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_Int32Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_Int32Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_Int32Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_Int32Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_UInt32Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UInt32Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_UInt32Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_UInt32Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_Int64Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_Int64Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_Int64Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_Int64Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_UInt64Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UInt64Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_UInt64Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_UInt64Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_FloatValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_FloatValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_FloatValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_FloatValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_DoubleValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_DoubleValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_DoubleValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_DoubleValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_NumberValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_NumberValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_NumberValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_NumberValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_NumberValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_NumberValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_IntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_IntegerValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_IntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_IntegerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_IntegerValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_IntegerValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UIntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_UIntegerValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_UIntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogScalar_UIntegerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogScalar_UIntegerValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogScalar_UIntegerValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_SimulationActive Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_SimulationActive = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_SimulationActive, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_GenerateValues_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_GenerateValues_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_GenerateValues_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_EventId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_EventType = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_SourceName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Time = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Message = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Severity = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_BranchId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Retain = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Quality = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Comment = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_AckedState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_AckedState = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_AckedState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_AckedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_AckedState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_AckedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_ConfirmedState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_ConfirmedState_Id = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_ConfirmedState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Acknowledge_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Acknowledge_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_Acknowledge_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_CycleComplete_Confirm_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_CycleComplete_Confirm_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_CycleComplete_Confirm_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_SByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_SByteValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_SByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_SByteValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_SByteValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_SByteValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_ByteValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_ByteValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_ByteValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_ByteValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_ByteValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_ByteValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_Int16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_Int16Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_Int16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_Int16Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_Int16Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_Int16Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UInt16Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_UInt16Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_UInt16Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UInt16Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_UInt16Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_UInt16Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_Int32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_Int32Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_Int32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_Int32Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_Int32Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_Int32Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UInt32Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_UInt32Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_UInt32Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UInt32Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_UInt32Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_UInt32Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_Int64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_Int64Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_Int64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_Int64Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_Int64Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_Int64Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UInt64Value Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_UInt64Value = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_UInt64Value, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UInt64Value_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_UInt64Value_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_UInt64Value_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_FloatValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_FloatValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_FloatValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_FloatValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_FloatValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_FloatValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_DoubleValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_DoubleValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_DoubleValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_DoubleValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_DoubleValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_DoubleValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_NumberValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_NumberValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_NumberValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_NumberValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_NumberValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_NumberValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_IntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_IntegerValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_IntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_IntegerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_IntegerValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_IntegerValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UIntegerValue Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_UIntegerValue = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_UIntegerValue, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Dynamic_AnalogArray_UIntegerValue_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Dynamic_AnalogArray_UIntegerValue_EURange = new ExpandedNodeId(TestData.Variables.Data_Dynamic_AnalogArray_UIntegerValue_EURange, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_EventId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_EventId = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_EventId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_EventType Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_EventType = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_EventType, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_SourceNode Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_SourceNode = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_SourceNode, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_SourceName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_SourceName = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_SourceName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Time Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_Time = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_Time, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_ReceiveTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_ReceiveTime = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_ReceiveTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_LocalTime Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_LocalTime = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_LocalTime, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Message Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_Message = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_Message, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Severity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_Severity = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_Severity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_ConditionClassId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_ConditionClassId = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_ConditionClassId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_ConditionClassName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_ConditionClassName = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_ConditionClassName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_ConditionName Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_ConditionName = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_ConditionName, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_BranchId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_BranchId = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_BranchId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Retain Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_Retain = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_Retain, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_EnabledState Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_EnabledState = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_EnabledState, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_EnabledState_Id Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_EnabledState_Id = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_EnabledState_Id, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Quality Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_Quality = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_Quality, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Quality_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_Quality_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_Quality_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_LastSeverity Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_LastSeverity = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_LastSeverity, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_LastSeverity_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_LastSeverity_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_LastSeverity_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Comment Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_Comment = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_Comment, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_Comment_SourceTimestamp Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_Comment_SourceTimestamp = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_Comment_SourceTimestamp, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_ClientUserId Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_ClientUserId = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_ClientUserId, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_AddComment_InputArguments Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_AddComment_InputArguments = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_AddComment_InputArguments, TestData.Namespaces.TestData);

        /// <summary>
        /// The identifier for the Data_Conditions_SystemStatus_MonitoredNodeCount Variable.
        /// </summary>
        public static readonly ExpandedNodeId Data_Conditions_SystemStatus_MonitoredNodeCount = new ExpandedNodeId(TestData.Variables.Data_Conditions_SystemStatus_MonitoredNodeCount, TestData.Namespaces.TestData);

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
        /// The BrowseName for the Conditions component.
        /// </summary>
        public const string Conditions = "Conditions";

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
        /// The BrowseName for the Dynamic component.
        /// </summary>
        public const string Dynamic = "Dynamic";

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
        /// The BrowseName for the Mydata component.
        /// </summary>
        public const string Mydata = "Mydata";

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
        /// The BrowseName for the Static component.
        /// </summary>
        public const string Static = "Static";

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