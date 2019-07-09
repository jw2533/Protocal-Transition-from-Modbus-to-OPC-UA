
 OPC UA 1.02 .NET StackAndSamples [336.0]
 
 DESCRIPTION
 -----------
 Thank you for downloading and evaluating the OPC UA 1.02 .NET Stack and
 Samples.
 
 The OPC UA API is a set of interfaces, libraries and executables that allow 
 developers to quickly create UA applications with the .NET programming 
 environment. The UA API includes:
 - Implementation of the XML Web Services and UA Native Binary stack profiles;
 - Server and Client development toolkits; 
 - Sample Applications; 
 - Configuration Tool 
 
 The UA .NET Stack and the samples are available as source code.

 The samples serve a simple purpose which is to  provide you with
 a suite of applications that demonstrate the power and flexibility of 
 OPC Unified Architecture technology. All samples within this package 
 are provided as-is, without warranty, without support, and are intended for 
 educational purposes, or as a means to evaluate the technology.
 
 OVERVIEW
 --------
  
 The OPC UA 1.02 .NET StackAndSamples [336.0] package is structured
 in the following folders:
 
 ComInterop - COM Interoperability provides seamless interoperability between
              OPC UA and legacy OPC Classic products by using a Gateway,
              otherwise known as the COM Proxy/Wrapper
 
 ConfigurationTool - Configuration Utility for configuring UA application
                     security and COM/Interoperability etc.
 
 Help - OPCUASDKHelp.chm : an OPC UA API Introduction and Reference Manual (more info below)
      - Sample Applications Overview documentation
      
 SampleApplications\Samples - Generic UA Client and Generic UA Server sample
                                applications source code
 
 SampleApplications\SDK - Client, Server and Configuration sample libraries
                          that allow developers to quickly create UA applications
                            
 SampleApplications\Workshop - several application samples to demonstrate the
                               use of OPC UA technology, including:
                                
    - DataAccess         : A client and a server designed to showcase the Data Access
                           feature/functionality
                            
    - HistoricalAccess   : A client and a server designed to showcase
                           Historical Data feature/functionality.

    - HistoricalEvents   : A client and a server designed to showcase the 
                           Historical Events feature/functionality.

    - AlarmCondition     : A client and a server designed to showcase the     
                           Alarms & Conditions feature/functionality
                        
    - Methods            : A client and a server designed to showcase the  
                           UA Methods feature/functionality
                        
    - UserAuthentication : A client and a server designed to showcase the 
                           UA User Authentication feature/functionality
                        
 Stack - OPC UA Stack library implementation in .NET
 
 ModelCompiler_1_02_xx.zip - ModelCompiler application source code
    
 The root folder contains VisualStudio 2008 solution files for convenience.
 
 
=============================================
OPCUASDKHelp.chm
=============================================
On Windows 7 and newer operating systems the help documentation may not open due to security concerns and
the defense mechanisms now built into Windows. The OPC Foundation assures that the help documentation is safe.
To "unblock" the help file:
 1. Open Windows Explorer and locate the help file (OPC UA 1.02 .NET StackAndSamples [xxx]\Help\OPCUASDKHelp.chm)
 2. Right-click on the file, and then choose PROPERTIES from the menu.
 3. In the GENERAL tab, click on the UNBLOCK button which is at the bottom of the dialog.
 4. Click OK to close the file properties window; the Help should now be accessible.