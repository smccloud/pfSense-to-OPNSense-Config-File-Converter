rmdir  /s /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\win-x64"
rmdir  /s /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\win-x86"
rmdir  /s /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\win-arm"
rmdir  /s /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\win-arm64"
rmdir  /s /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\osx-x64"
rmdir  /s /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\osx-arm64"
rmdir  /s /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\linux-x64"
rmdir  /s /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\linux-arm"
rmdir  /s /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\linux-arm64"
rmdir  /s /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\publish"
del /q *.zip
dotnet publish -f net6.0 -r win-x64 -c Release /p:PublishSingleFile=true
del /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\win-x64\publish\*.pdb"
7za.exe a -mx9 "..\windows-x64 - %1.zip" ".\pfSense to OPNSense Config File Converter\bin\Release\net6.0\win-x64\publish\*"
dotnet publish -f net6.0 -r win-x86 -c Release /p:PublishSingleFile=true
del /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\win-x86\publish\*.pdb"
7za.exe a -mx9 "..\windows-x86 - %1.zip" ".\pfSense to OPNSense Config File Converter\bin\Release\net6.0\win-x86\publish\*"
dotnet publish -f net6.0 -r win-arm -c Release /p:PublishSingleFile=true
del /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\win-arm\publish\*.pdb"
7za.exe a -mx9 "..\windows-arm - %1.zip" ".\pfSense to OPNSense Config File Converter\bin\Release\net6.0\win-arm\publish\*"
dotnet publish -f net6.0 -r win-arm64 -c Release /p:PublishSingleFile=true
del /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\win-arm64\publish\*.pdb"
7za.exe a -mx9 "..\windows-arm64 - %1.zip" ".\pfSense to OPNSense Config File Converter\bin\Release\net6.0\win-arm64\publish\*"
dotnet publish -f net6.0 -r osx-x64 -c Release /p:PublishSingleFile=true
del /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\osx-x64\publish\*.pdb"
7za.exe a -mx9 "..\osx-x64 - %1.zip" ".\pfSense to OPNSense Config File Converter\bin\Release\net6.0\osx-x64\publish\*"
dotnet publish -f net6.0 -r osx-arm64 -c Release /p:PublishSingleFile=true
del /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\osx-arm64\publish\*.pdb"
7za.exe a -mx9 "..\osx-arm64 - %1.zip" ".\pfSense to OPNSense Config File Converter\bin\Release\net6.0\osx-arm64\publish\*"
dotnet publish -f net6.0 -r linux-x64 -c Release /p:PublishSingleFile=true
del /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\linux-x64\publish\*.pdb"
7za.exe a -mx9 "..\linux-x64 - %1.zip" ".\pfSense to OPNSense Config File Converter\bin\Release\net6.0\linux-x64\publish\*"
dotnet publish -f net6.0 -r linux-arm -c Release /p:PublishSingleFile=true
del /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\linux-arm\publish\*.pdb"
7za.exe a -mx9 "..\linux-arm - %1.zip" ".\pfSense to OPNSense Config File Converter\bin\Release\net6.0\linux-arm\publish\*"
dotnet publish -f net6.0 -r linux-arm64 -c Release /p:PublishSingleFile=true
del /q "pfSense to OPNSense Config File Converter\bin\Release\net6.0\linux-arm64\publish\*.pdb"
7za.exe a -mx9 "..\linux-arm64 - %1.zip" ".\pfSense to OPNSense Config File Converter\bin\Release\net6.0\linux-arm64\publish\*"