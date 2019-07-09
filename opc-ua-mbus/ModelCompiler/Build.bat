echo Building TestData
Opc.Ua.ModelCompiler.exe -d2 ".\TestData\TestDataDesign.xml" -cg ".\TestData\TestDataDesign.csv" -o2 ".\TestData" -useXmlInitializers
echo Success!