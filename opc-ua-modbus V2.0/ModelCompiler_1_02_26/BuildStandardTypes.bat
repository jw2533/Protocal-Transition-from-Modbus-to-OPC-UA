@echo off
setlocal

set MODELCOMPILER=..\Bin\Release\Opc.Ua.ModelCompiler.exe
set OUTPUT=..\Published
set ANSIC_TARGET=..\..\uastack\Source\Ansi C Stack\
set DOTNET_TARGET=..\..\uastack\Source\Common\Core\
set DI_TARGET=..\..\uastack\Source\Common\Core\Stack\Generated\
set ADI_TARGET=..\..\uastack\Source\Common\Core\Stack\Generated\

if not exist %OUTPUT% mkdir %OUTPUT%
if not exist %OUTPUT%\Schema mkdir %OUTPUT%\Schema
if not exist %OUTPUT%\DotNet mkdir %OUTPUT%\DotNet
if not exist %OUTPUT%\AnsiC mkdir %OUTPUT%\AnsiC

%MODELCOMPILER% -d2 ".\ModelCompiler\Design\StandardTypes.xml" -d2 ".\ModelCompiler\Design\UA Core Services.xml" -c ".\ModelCompiler\Design\StandardTypes.csv" -o2 "%OUTPUT%\Schema\" -stack "%OUTPUT%\DotNet\" -ansic "%OUTPUT%\AnsiC\"

echo Building Part12
if not exist %OUTPUT%\GDS mkdir %OUTPUT%\Part12
%MODELCOMPILER% -d2 ".\ModelCompiler\Design\OpcUaPart12Model.xml" -cg ".\ModelCompiler\Design\OpcUaPart12Model.csv" -o2 "%OUTPUT%\Part12\"
echo Success!

echo Building GDS
if not exist %OUTPUT%\GDS mkdir %OUTPUT%\GDS
%MODELCOMPILER% -d2 ".\ModelCompiler\Design\OpcUaGdsModel.xml" -cg ".\ModelCompiler\Design\OpcUaGdsModel.csv" -o2 "%OUTPUT%\GDS\"
echo Success!

echo Building DI
if not exist %OUTPUT%\DI mkdir %OUTPUT%\DI
%MODELCOMPILER% -d2 ".\ModelCompiler\Design\OpcUaDiModel.xml" -cg ".\ModelCompiler\Design\OpcUaDiModel.csv" -o2 "%OUTPUT%\DI\"
echo Success!

echo Building ADI
if not exist %OUTPUT%\ADI mkdir %OUTPUT%\ADI
%MODELCOMPILER% -d2 ".\ModelCompiler\Design\OpcUaAdiModel.xml" -cg ".\ModelCompiler\Design\OpcUaAdiModel.csv" -o2 "%OUTPUT%\ADI\"
echo Success!

echo Building FDI
if not exist %OUTPUT%\FDI mkdir %OUTPUT%\FDI
%MODELCOMPILER% -d2 ".\ModelCompiler\Design\OpcUaFdiPart5Model.xml" -cg ".\ModelCompiler\Design\OpcUaFdiPart5Model.csv" -o2 "%OUTPUT%\FDI\"
%MODELCOMPILER% -d2 ".\ModelCompiler\Design\OpcUaFdiPart7Model.xml" -cg ".\ModelCompiler\Design\OpcUaFdiPart7Model.csv" -o2 "%OUTPUT%\FDI\"
echo Success!

echo Building PLCopen
if not exist %OUTPUT%\PLCopen mkdir %OUTPUT%\PLCopen
%MODELCOMPILER% -d2 ".\ModelCompiler\Design\OpcUaPLCopenModel.xml" -cg ".\ModelCompiler\Design\OpcUaPLCopenModel.csv" -o2 "%OUTPUT%\PLCopen\"
echo Success!

copy ".\ModelCompiler\Design\StandardTypes.csv" "%OUTPUT%\Schema\NodeIds.csv"
copy ".\ModelCompiler\Design\UA Attributes.csv" "%OUTPUT%\Schema\AttributeIds.csv"
copy ".\Core\Schema\UANodeSet.xsd" "%OUTPUT%\Schema\UANodeSet.xsd"
copy ".\Core\Schema\SecuredApplication.xsd" "%OUTPUT%\Schema\SecuredApplication.xsd"
copy ".\Core\Types\Schemas\OPCBinarySchema.xsd" "%OUTPUT%\Schema\OPCBinarySchema.xsd"

copy "%OUTPUT%\AnsiC\opcua_statuscodes.h" "%ANSIC_TARGET%\core\"
copy "%OUTPUT%\AnsiC\opcua_attributes.h" "%ANSIC_TARGET%\stackcore\"
copy "%OUTPUT%\AnsiC\opcua_browsenames.h" "%ANSIC_TARGET%\stackcore\"
copy "%OUTPUT%\AnsiC\opcua_identifiers.h" "%ANSIC_TARGET%\stackcore\"
copy "%OUTPUT%\AnsiC\opcua_types.c" "%ANSIC_TARGET%\stackcore\"
copy "%OUTPUT%\AnsiC\opcua_types.h" "%ANSIC_TARGET%\stackcore\"
copy "%OUTPUT%\AnsiC\opcua_clientapi.h" "%ANSIC_TARGET%\proxystub\clientproxy\"
copy "%OUTPUT%\AnsiC\opcua_clientapi.c" "%ANSIC_TARGET%\proxystub\clientproxy\"
copy "%OUTPUT%\AnsiC\opcua_serverapi.h" "%ANSIC_TARGET%\proxystub\serverstub\"
copy "%OUTPUT%\AnsiC\opcua_serverapi.c" "%ANSIC_TARGET%\proxystub\serverstub\"

copy "%OUTPUT%\Schema\AttributeIds.csv" "%DOTNET_TARGET%\Schema\AttributeIds.csv"
copy "%OUTPUT%\Schema\NodeIds.csv" "%DOTNET_TARGET%\Schema\NodeIds.csv"
copy "%OUTPUT%\Schema\Opc.Ua.NodeSet.xml" "%DOTNET_TARGET%\Schema\Opc.Ua.NodeSet.xml"
copy "%OUTPUT%\Schema\Opc.Ua.NodeSet2.xml" "%DOTNET_TARGET%\Schema\Opc.Ua.NodeSet2.xml"
copy "%OUTPUT%\Schema\Opc.Ua.Types.bsd" "%DOTNET_TARGET%\Schema\Opc.Ua.Types.bsd"
copy "%OUTPUT%\Schema\Opc.Ua.Types.xsd" "%DOTNET_TARGET%\Schema\Opc.Ua.Types.xsd"
copy "%OUTPUT%\DotNet\Opc.Ua.Endpoints.wsdl" "%DOTNET_TARGET%\Schema\Opc.Ua.Endpoints.wsdl"
copy "%OUTPUT%\DotNet\Opc.Ua.Services.wsdl" "%DOTNET_TARGET%\Schema\Opc.Ua.Services.wsdl"

copy "%OUTPUT%\DotNet\Opc.Ua.Channels.cs" "%DOTNET_TARGET%\Stack\Generated\Opc.Ua.Channels.cs"
copy "%OUTPUT%\DotNet\Opc.Ua.Client.cs" "%DOTNET_TARGET%\Stack\Generated\Opc.Ua.Client.cs"
copy "%OUTPUT%\DotNet\Opc.Ua.Endpoints.cs" "%DOTNET_TARGET%\Stack\Generated\Opc.Ua.Endpoints.cs"
copy "%OUTPUT%\DotNet\Opc.Ua.Interfaces.cs" "%DOTNET_TARGET%\Stack\Generated\Opc.Ua.Interfaces.cs"
copy "%OUTPUT%\DotNet\Opc.Ua.Messages.cs" "%DOTNET_TARGET%\Stack\Generated\Opc.Ua.Messages.cs"
copy "%OUTPUT%\DotNet\Opc.Ua.ServerBase.cs" "%DOTNET_TARGET%\Stack\Generated\Opc.Ua.ServerBase.cs"
copy "%OUTPUT%\DotNet\Opc.Ua.StatusCodes.cs" "%DOTNET_TARGET%\Types\Generated\Opc.Ua.StatusCodes.cs"
copy "%OUTPUT%\DotNet\Opc.Ua.Attributes.cs" "%DOTNET_TARGET%\Types\Generated\Opc.Ua.Attributes.cs"
copy "%OUTPUT%\Schema\Opc.Ua.Classes.cs" "%DOTNET_TARGET%\Stack\Generated\Opc.Ua.Classes.cs"
copy "%OUTPUT%\Schema\Opc.Ua.Constants.cs" "%DOTNET_TARGET%\Stack\Generated\Opc.Ua.Constants.cs"
copy "%OUTPUT%\Schema\Opc.Ua.DataTypes.cs" "%DOTNET_TARGET%\Stack\Generated\Opc.Ua.DataTypes.cs"
copy "%OUTPUT%\Schema\Opc.Ua.PredefinedNodes.uanodes" "%DOTNET_TARGET%\Stack\Generated\Opc.Ua.PredefinedNodes.uanodes"
copy "%OUTPUT%\Schema\Opc.Ua.PredefinedNodes.xml" "%DOTNET_TARGET%\Stack\Generated\Opc.Ua.PredefinedNodes.xml"

REM copy "%OUTPUT%\DI\*.*" "%DI_TARGET%"
REM copy "%OUTPUT%\ADI\*.*" "%ADI_TARGET%"
REM copy "%OUTPUT%\ADI\*.*" "%PLCOPEN_TARGET%"

