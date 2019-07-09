/* ========================================================================
 * Copyright (c) 2005-2013 The OPC Foundation, Inc. All rights reserved.
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
using System.Xml;
using System.IO;
using System.Reflection;
using Opc.Ua;
using Opc.Ua.Sample;

namespace TestData
{
    public partial class MyObjectState
    {
        #region Initialization
        /// <summary>
        /// Initializes the object as a collection of counters which change value on read.
        /// </summary>
        protected override void OnAfterCreate(ISystemContext context, NodeState node)
        {
            base.OnAfterCreate(context, node);

            //OpcVariables v = new OpcVariables();
            //设置各节点的显示名字
            if (node.DisplayName== "MyData1")
            {
                node.DisplayName = OpcVariables.building1name;
                MyValue1.DisplayName = OpcVariables.value1_1name;
                MyValue1.Description = OpcVariables.value1_1class + OpcVariables.value1_1place;//"Power+702";
                SetClassPlaceDisplayName(context, MyValue1, OpcVariables.value1_1class, OpcVariables.value1_1place);

                MyValue2.DisplayName = OpcVariables.value1_2name;
                MyValue2.Description = string.Join("+", OpcVariables.value1_1class, OpcVariables.value1_1place);//"Water+704";
                SetClassPlaceDisplayName(context, MyValue2, OpcVariables.value1_2class, OpcVariables.value1_2place);
            }
            else if (node.DisplayName == "MyData2")
            {
                node.DisplayName = OpcVariables.building2name;
                MyValue1.DisplayName = OpcVariables.value2_1name;
                MyValue1.Description = "Power+802";
                SetClassPlaceDisplayName(context, MyValue1, OpcVariables.value2_1class, OpcVariables.value2_1place);

                MyValue2.DisplayName = OpcVariables.value2_2name;
                MyValue2.Description = "Water+804";
                SetClassPlaceDisplayName(context, MyValue2, OpcVariables.value2_2class, OpcVariables.value2_2place);
            }

            //设置节点的读回调函数
            MyValue1.OnReadValue = MyReadValue;
            MyValue2.OnReadValue = MyReadValue;
            //.....

            //MyValue3.OnSimpleWriteValue = OnWriteValue;   这个语句可以设置对一个变量写数值的回调函数！
        }
        #endregion

        private void SetClassPlaceDisplayName(ISystemContext context, NodeState node, string ClassDisplayName, string PlaceDisplayName)
        {
            List<BaseInstanceState> children = new List<BaseInstanceState>();

            node.GetChildren(context, children);
            if (children.Count>=1)
                children[0].DisplayName = ClassDisplayName;
            if (children.Count >= 2)
                children[1].DisplayName = PlaceDisplayName;
        }

        //MyRreadValue: Read data from device
        private ServiceResult MyReadValue(ISystemContext context,
            NodeState node,
            NumericRange indexRange,
            QualifiedName dataEncoding,
            ref object value,
            ref StatusCode statusCode,
            ref DateTime timestamp)
        {
            BaseVariableState variable = node as BaseVariableState;
            if (variable == null)
            {
                return ServiceResult.Good;
            }

            TestDataSystem system = context.SystemHandle as TestDataSystem;

            if (system == null)
            {
                return StatusCodes.BadOutOfService;
            }

            try
            {
                value = DeviceReadValue(variable);

                statusCode = StatusCodes.Good;
                timestamp = DateTime.UtcNow;

                ServiceResult error = BaseVariableState.ApplyIndexRangeAndDataEncoding(
                    context,
                    indexRange,
                    dataEncoding,
                    ref value);

                if (ServiceResult.IsBad(error))
                {
                    statusCode = error.StatusCode;
                }

                return ServiceResult.Good;
            }
            catch (Exception e)
            {
                return new ServiceResult(e);
            }
        }

        //Read Data From Devices: Entrypoint
       
        private object DeviceReadValue(BaseVariableState variable)
        {
             
            switch (variable.NumericId)
            {
                case TestData.Variables.Data_MyData1_MyValue1_Place:
                    {
                        return 9;
                    }
                case TestData.Variables.Data_MyData1_MyValue1:
                    {
                        return OpcVariables.stringinfo1;
                    }
                case TestData.Variables.Data_MyData1_MyValue2:
                    {
                        return OpcVariables.stringinfo2;
                    }
                case TestData.Variables.Data_MyData2_MyValue1:
                    {
                        return OpcVariables.stringinfo3;
                    }
                case TestData.Variables.Data_MyData2_MyValue2:
                    {
                        return OpcVariables.stringinfo4;
                    }
            }
            return null;
        }
    }
}
