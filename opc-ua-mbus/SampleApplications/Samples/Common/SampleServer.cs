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

#define CUSTOM_NODE_MANAGER

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.ServiceModel;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel.Security;
using System.IdentityModel.Selectors;
using System.Xml;
using Opc.Ua;
using Opc.Ua.Server;
using System.Threading;
using System.Net;
using System.Net.Sockets;



namespace Opc.Ua.Sample
{
    public static class OpcVariables
    {
        public static string stringinfo;
        public static string ipadd;
        public static int port;
        public static byte[] order = new byte[11];
        #region building1
        public static string building1name;

        public static string value1_1name;
        public static string value1_1address;
        public static string value1_1class;
        public static string value1_1place;

        public static string value1_2name;
        public static string value1_2address;
        public static string value1_2class;
        public static string value1_2place;
        #endregion building1

        #region building2
        public static string building2name;

        public static string value2_1name;
        public static string value2_1address;
        public static string value2_1class;
        public static string value2_1place;

        public static string value2_2name;
        public static string value2_2address;
        public static string value2_2class;
        public static string value2_2place;
        #endregion building2
    }
    public class DeviceAddress
    {
           //配置发送指令
            byte[] bytes1 = new byte[] { 0xFE, 0x10, 0x40 };
            byte[] bytes2 = new byte[] { 0x16 };
            byte[] byteaddress = new byte[7];
            byte[] order = new byte[11];
            public byte[] deviceaddress(string add)
            {
                string[] strArr = add.Trim().Split(' ');
                for (int i = 0; i < 7; i++)
                {
                    byteaddress[i] = Convert.ToByte(strArr[i], 16);
                }
                for (int i = 0; i < 11; i++)
                {
                    if (i <= 2)
                    {
                        order[i] = bytes1[i];
                    }
                    else if (i <= 9)
                    {
                        order[i] = byteaddress[i - 3];
                    }
                    else
                    {
                        order[i] = bytes2[i - 10];
                    }
                }
                return order;
            }
    }
    /// <summary>
    /// A class which implements an instance of a UA server.
    /// </summary>
    public partial class SampleServer : StandardServer
    {
        #region Overridden Methods
        /// <summary>
        /// Initializes the server before it starts up.
        /// </summary>
        /// <remarks>
        /// This method is called before any startup processing occurs. The sub-class may update the 
        /// configuration object or do any other application specific startup tasks.
        /// </remarks>
        protected override void OnServerStarting(ApplicationConfiguration configuration)
        {
            readxml();

            Opc.Ua.Com.ComUtils.InitializeSecurity();

            Utils.Trace("The server is starting.");

            base.OnServerStarting(configuration);     
            
            // it is up to the application to decide how to validate user identity tokens.
            // this function creates validators for SAML and X509 identity tokens.
            CreateUserIdentityValidators(configuration);
        }
        public void readxml()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("send.xml");
            XmlElement root = doc.DocumentElement;
            XmlNodeList xnl = root.ChildNodes;
            OpcVariables.ipadd = xnl.Item(0).InnerText;
            OpcVariables.port = Convert.ToInt16(xnl.Item(1).InnerText);
            int SampleInterval = Convert.ToInt16(xnl.Item(2).InnerText);
            #region building1
            //building1
            XmlNode building1 = root.SelectSingleNode("Building1");
            XmlNodeList list1 = building1.ChildNodes;
            OpcVariables.building1name = list1.Item(0).InnerText;
            //value1
            XmlNode value1_1 = list1.Item(1);
            XmlNodeList list1_1 = value1_1.ChildNodes;
            OpcVariables.value1_1name = list1_1.Item(0).InnerText;
            OpcVariables.value1_1address = list1_1.Item(1).InnerText;
            OpcVariables.value1_1class = list1_1.Item(2).InnerText;
            OpcVariables.value1_1place = list1_1.Item(3).InnerText;
            //value2
            XmlNode value1_2 = list1.Item(2);
            XmlNodeList list1_2 = value1_2.ChildNodes;
            OpcVariables.value1_2name = list1_2.Item(0).InnerText;
            OpcVariables.value1_2address = list1_2.Item(1).InnerText;
            OpcVariables.value1_2class = list1_2.Item(2).InnerText;
            OpcVariables.value1_2place = list1_2.Item(3).InnerText;
            #endregion building1

            #region building2
            //building2
            XmlNode building2 = root.SelectSingleNode("Building2");
            XmlNodeList list2 = building2.ChildNodes;
            OpcVariables.building2name = list2.Item(0).InnerText;
            //value1
            XmlNode value2_1 = list2.Item(1);
            XmlNodeList list2_1 = value2_1.ChildNodes;
            OpcVariables.value2_1name = list2_1.Item(0).InnerText;
            OpcVariables.value2_1address = list2_1.Item(1).InnerText;
            OpcVariables.value2_1class = list2_1.Item(2).InnerText;
            OpcVariables.value2_1place = list2_1.Item(3).InnerText;
            //value2
            XmlNode value2_2 = list2.Item(2);
            XmlNodeList list2_2 = value2_2.ChildNodes;
            OpcVariables.value2_2name = list2_2.Item(0).InnerText;
            OpcVariables.value2_2address = list2_2.Item(1).InnerText;
            OpcVariables.value2_2class = list2_2.Item(2).InnerText;
            OpcVariables.value2_2place = list2_2.Item(3).InnerText;
            #endregion building2

            //配置发送指令
            byte[] bytes1 = new byte[] { 0xFE, 0x10, 0x40 };
            byte[] bytes2 = new byte[] { 0x16 };
            byte[] byteaddress = new byte[7];
            string[] strArr = OpcVariables.value1_1address.Trim().Split(' ');
            for (int i = 0; i < 7; i++)
            {
                byteaddress[i] = Convert.ToByte(strArr[i], 16);
            }
            for (int i = 0; i < 11; i++)
            {
                if (i <= 2)
                {
                    OpcVariables.order[i] = bytes1[i];
                }
                else if (i <= 9)
                {
                    OpcVariables.order[i] = byteaddress[i - 3];
                }
                else
                {
                    OpcVariables.order[i] = bytes2[i - 10];
                }
            }
        }
        private void TestMethod()
        {
            byte[] result = new byte[1024];
            //设定服务器IP地址  
            IPAddress ip = IPAddress.Parse(OpcVariables.ipadd);
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                //clientSocket.Connect(new IPEndPoint(ip, OpcVariables.port)); //配置服务器IP与端口  
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            DeviceAddress da1 = new DeviceAddress();
            byte[] order1 = da1.deviceaddress(OpcVariables.value1_1address);
            clientSocket.Send(da1.deviceaddress(OpcVariables.value1_1address));
           // int isecond = Convert.ToInt16(xnl.Item(2).InnerText);
            while (true)
            {

                int receiveLength = clientSocket.Receive(result);
                OpcVariables.stringinfo = Encoding.ASCII.GetString(result, 0, receiveLength);
            }
        }

        /// <summary>
        /// Called after the server has been started.
        /// </summary>
        protected override void OnServerStarted(IServerInternal server)
        {
            Thread t1 = new Thread(new ThreadStart(TestMethod));
            t1.IsBackground = true;
            t1.Start();
            base.OnServerStarted(server);
            
            // request notifications when the user identity is changed. all valid users are accepted by default.
            server.SessionManager.ImpersonateUser += new ImpersonateEventHandler(SessionManager_ImpersonateUser);
        }

        /// <summary>
        /// Cleans up before the server shuts down.
        /// </summary>
        /// <remarks>
        /// This method is called before any shutdown processing occurs.
        /// </remarks>
        protected override void OnServerStopping()
        {
            Console.WriteLine("The Server is stopping.");

            base.OnServerStopping();
            
            #if INCLUDE_Sample
            CleanSampleModel();
            #endif
        }
        
        #if CUSTOM_NODE_MANAGER
        /// <summary>
        /// Creates the node managers for the server.
        /// </summary>
        /// <remarks>
        /// This method allows the sub-class create any additional node managers which it uses. The SDK
        /// always creates a CoreNodeManager which handles the built-in nodes defined by the specification.
        /// Any additional NodeManagers are expected to handle application specific nodes.
        /// 
        /// Applications with small address spaces do not need to create their own NodeManagers and can add any
        /// application specific nodes to the CoreNodeManager. Applications should use custom NodeManagers when
        /// the structure of the address space is stored in another system or when the address space is too large
        /// to keep in memory.
        /// </remarks>
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            Console.WriteLine("Creating the Node Managers.");

            List<INodeManager> nodeManagers = new List<INodeManager>();

            // create the custom node managers.
            nodeManagers.Add(new global::TestData.TestDataNodeManager(server, configuration));            
            nodeManagers.Add(new global::MemoryBuffer.MemoryBufferNodeManager(server, configuration));
            nodeManagers.Add(new global::Boiler.BoilerNodeManager(server, configuration));
            //nodeManagers.Add(new global::FileSystem.FileSystemNodeManager(server, "%LocalApplicationData%\\OPC Foundation\\Samples\\FileSystem"));
            
            // create master node manager.
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }
        #endif

        /// <summary>
        /// Loads the non-configurable properties for the application.
        /// </summary>
        /// <remarks>
        /// These properties are exposed by the server but cannot be changed by administrators.
        /// </remarks>
        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties();

            properties.ManufacturerName = "OPC Foundation";
            properties.ProductName      = "OPC UA SDK Samples";
            properties.ProductUri       = "http://opcfoundation.org/UA/Samples/v1.0";
            properties.SoftwareVersion  = Utils.GetAssemblySoftwareVersion();
            properties.BuildNumber      = Utils.GetAssemblyBuildNumber();
            properties.BuildDate        = Utils.GetAssemblyTimestamp();

            // TBD - All applications have software certificates that need to added to the properties.

            // for (int ii = 0; ii < certificates.Count; ii++)
            // {
            //    properties.SoftwareCertificates.Add(certificates[ii]);
            // }

            return properties; 
        }

        /// <summary>
        /// Initializes the address space after the NodeManagers have started.
        /// </summary>
        /// <remarks>
        /// This method can be used to create any initialization that requires access to node managers.
        /// </remarks>
        protected override void OnNodeManagerStarted(IServerInternal server)
        {
            Console.WriteLine("The NodeManagers have started.");

            // allow base class processing to happen first.
            base.OnNodeManagerStarted(server); 
            
            // adds the sample information models to the core node manager. 
            #if INCLUDE_Sample
            InitializeSampleModel();
            #endif
        }
                
        #if USER_AUTHENTICATION
        /// <summary>
        /// Creates the resource manager for the server.
        /// </summary>
        protected override ResourceManager CreateResourceManager(IServerInternal server, ApplicationConfiguration configuration)
        {
            ResourceManager resourceManager = new ResourceManager(server, configuration);
            
            // add some localized strings to the resource manager to demonstrate that localization occurs.
            resourceManager.Add("InvalidPassword", "de-DE", "Das Passwort ist nicht gültig für Konto '{0}'.");
            resourceManager.Add("InvalidPassword", "es-ES", "La contraseña no es válida para la cuenta de '{0}'.");

            resourceManager.Add("UnexpectedUserTokenError", "fr-FR", "Une erreur inattendue s'est produite lors de la validation utilisateur.");
            resourceManager.Add("UnexpectedUserTokenError", "de-DE", "Ein unerwarteter Fehler ist aufgetreten während des Anwenders.");
           
            return resourceManager;
        }
        #endif
        #endregion
    }
}
