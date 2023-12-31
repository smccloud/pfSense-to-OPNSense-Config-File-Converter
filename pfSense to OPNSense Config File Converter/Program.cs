
using System.Xml.Serialization;
using System.Text;
using Functions;
using pfSenseConfig;
using OPNSenseConfig;
using System.Runtime.InteropServices;

string license = "Copyright 2023 Shaun McCloud\n\nPermission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:\n\nThe above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.\n\nTHE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.\n";
Console.WriteLine(license);
Console.Write("Use of this software means agreeing to the above license details.  Press any key to continue. :");
Console.ReadKey();

// Initialze pfSense Config Serializer
var serializer = new XmlSerializer(typeof(Pfsense));

// Initialize pfSense Config Opject
var pfSenseConfig = new Pfsense();

// Initialize FileStream
string inputFile = Directory.GetCurrentDirectory() + "/pfSense.xml";
if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) inputFile = Directory.GetCurrentDirectory() + "\\pfSense.xml";
using (var inputFileStream = new FileStream(inputFile, FileMode.Open))
{
    // Deserialze pfSense config
    Console.WriteLine("Reading pfSense config file");
    pfSenseConfig = (Pfsense)serializer.Deserialize(inputFileStream);
}

if (pfSenseConfig.Version != 22.9)
{
    Console.Write("Your current config version " + pfSenseConfig.Version.ToString() + " is not a supported config version, please create an issue or a pull request with a fix.  Press any key to exit. :");
    Console.ReadKey();
}
else
{
    // Initialize OPNSense Config Object
    var OPNSenseConfig = new Opnsense();
    Console.WriteLine("Converting system settings");
    OPNSenseConfig.System = SystemConversion.ConvertAll(pfSenseConfig.System);

    Console.WriteLine("Converting Interface(s)");
    OPNSenseConfig.Interfaces = InterfaceConversion.ConvertAll(pfSenseConfig.Interfaces);

    Console.WriteLine("Converting DHCP server(s)");
    OPNSenseConfig.Dhcpd = DHCPServerConversion.ConvertAll(pfSenseConfig.Dhcpd,
        GetLANIP.GetIP(pfSenseConfig.Interfaces.Lan),
        GetLANIP.GetIP(pfSenseConfig.Interfaces.Opt1),
        GetLANIP.GetIP(pfSenseConfig.Interfaces.Opt2),
        GetLANIP.GetIP(pfSenseConfig.Interfaces.Opt3),
        GetLANIP.GetIP(pfSenseConfig.Interfaces.Opt4),
        GetLANIP.GetIP(pfSenseConfig.Interfaces.Opt5),
        GetLANIP.GetIP(pfSenseConfig.Interfaces.Opt6),
        GetLANIP.GetIP(pfSenseConfig.Interfaces.Opt7),
        GetLANIP.GetIP(pfSenseConfig.Interfaces.Opt8),
        GetLANIP.GetIP(pfSenseConfig.Interfaces.Opt9));

    Console.WriteLine("Converting NAT items");
    OPNSenseConfig.Nat = NATConversion.ConvertAll(pfSenseConfig.Nat);

    Console.WriteLine("Converting filters");
    OPNSenseConfig.Filter = FilterConversion.ConvertAll(pfSenseConfig.Filter);

    OPNSenseConfig.Theme = "opnsense";
    OPNSenseConfig.Sysctl = StaticSysCtlItems.Create();
    OPNSenseConfig.Widgets = new OPNSenseConfig.Widgets();
    OPNSenseConfig.Widgets.Sequence = "system_information-container:00000000-col3:show,services_status-container:00000001-col4:show,gateways-container:00000002-col4:show,interface_list-container:00000003-col4:show";
    OPNSenseConfig.Widgets.ColumnCount = 2;

    // Does not yet work

    serializer = new XmlSerializer(typeof(Opnsense));
    string OPNSenseConfigString = string.Empty;

    using (StringWriter stringWriter = new StringWriter())
    {
        string outputFile = Directory.GetCurrentDirectory() + "/OPNSense.xml";
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) outputFile = Directory.GetCurrentDirectory() + "\\OPNSense.xml";
        using (var outputFileStream = new StreamWriter(outputFile, false, Encoding.UTF8))
        {
            serializer.Serialize(stringWriter, OPNSenseConfig);
            OPNSenseConfigString = stringWriter.ToString();
            OPNSenseConfigString = OPNSenseConfigString.Replace("<opnsense xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">", "<opnsense>");
            OPNSenseConfigString = OPNSenseConfigString.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "<?xml version=\"1.0\"?>");
            outputFileStream.Write(OPNSenseConfigString);
        }
    }

    Console.Write("Done converting config file formats.  Press any key to exit. :");
    Console.ReadKey();
}