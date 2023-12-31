using System.Xml.Serialization;

namespace OPNSenseConfig
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Opnsense));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Opnsense)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "item")]
    public class Item
    {

        [XmlElement(ElementName = "descr")]
        public string Descr { get; set; }

        [XmlElement(ElementName = "tunable")]
        public string Tunable { get; set; }

        [XmlElement(ElementName = "value")]
        public string Value { get; set; }
    }

    [XmlRoot(ElementName = "sysctl")]
    public class Sysctl
    {

        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
    }

    [XmlRoot(ElementName = "group")]
    public class Group
    {

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "scope")]
        public string Scope { get; set; }

        [XmlElement(ElementName = "gid")]
        public int Gid { get; set; }

        [XmlElement(ElementName = "member")]
        public int Member { get; set; }

        [XmlElement(ElementName = "priv")]
        public string Priv { get; set; }
    }

    [XmlRoot(ElementName = "user")]
    public class User
    {

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "descr")]
        public string Descr { get; set; }

        [XmlElement(ElementName = "scope")]
        public string Scope { get; set; }

        [XmlElement(ElementName = "groupname")]
        public string Groupname { get; set; }

        [XmlElement(ElementName = "password")]
        public string Password { get; set; }

        [XmlElement(ElementName = "uid")]
        public int Uid { get; set; }

        [XmlElement(ElementName = "expires")]
        public object Expires { get; set; }

        [XmlElement(ElementName = "authorizedkeys")]
        public object Authorizedkeys { get; set; }

        [XmlElement(ElementName = "otp_seed")]
        public object OtpSeed { get; set; }
    }

    [XmlRoot(ElementName = "webgui")]
    public class Webgui
    {

        [XmlElement(ElementName = "protocol")]
        public string Protocol { get; set; }

        [XmlElement(ElementName = "ssl-certref")]
        public string Sslcertref { get; set; }
    }

    [XmlRoot(ElementName = "bogons")]
    public class Bogons
    {

        [XmlElement(ElementName = "interval")]
        public string Interval { get; set; }
    }

    [XmlRoot(ElementName = "ssh")]
    public class Ssh
    {

        [XmlElement(ElementName = "group")]
        public string Group { get; set; }
    }

    [XmlRoot(ElementName = "firmware")]
    public class Firmware
    {

        [XmlElement(ElementName = "mirror")]
        public object Mirror { get; set; }

        [XmlElement(ElementName = "flavour")]
        public object Flavour { get; set; }

        [XmlElement(ElementName = "plugins")]
        public object Plugins { get; set; }

        [XmlElement(ElementName = "subscription")]
        public object Subscription { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "system")]
    public class System
    {

        [XmlElement(ElementName = "optimization")]
        public string Optimization { get; set; }

        [XmlElement(ElementName = "hostname")]
        public string Hostname { get; set; }

        [XmlElement(ElementName = "domain")]
        public string Domain { get; set; }

        [XmlElement(ElementName = "dnsallowoverride")]
        public int Dnsallowoverride { get; set; }

        [XmlElement(ElementName = "group")]
        public List<Group> Group { get; set; }

        [XmlElement(ElementName = "user")]
        public List<User> User { get; set; }

        [XmlElement(ElementName = "nextuid")]
        public int Nextuid { get; set; }

        [XmlElement(ElementName = "nextgid")]
        public int Nextgid { get; set; }

        [XmlElement(ElementName = "timezone")]
        public string Timezone { get; set; }

        [XmlElement(ElementName = "timeservers")]
        public string Timeservers { get; set; }

        [XmlElement(ElementName = "webgui")]
        public Webgui Webgui { get; set; }

        [XmlElement(ElementName = "disablenatreflection")]
        public string Disablenatreflection { get; set; }

        [XmlElement(ElementName = "usevirtualterminal")]
        public int Usevirtualterminal { get; set; }

        [XmlElement(ElementName = "disableconsolemenu")]
        public object Disableconsolemenu { get; set; }

        [XmlElement(ElementName = "disablevlanhwfilter")]
        public int Disablevlanhwfilter { get; set; }

        [XmlElement(ElementName = "disablechecksumoffloading")]
        public int Disablechecksumoffloading { get; set; }

        [XmlElement(ElementName = "disablesegmentationoffloading")]
        public int Disablesegmentationoffloading { get; set; }

        [XmlElement(ElementName = "disablelargereceiveoffloading")]
        public int Disablelargereceiveoffloading { get; set; }

        [XmlElement(ElementName = "ipv6allow")]
        public object Ipv6allow { get; set; }

        [XmlElement(ElementName = "powerd_ac_mode")]
        public string PowerdAcMode { get; set; }

        [XmlElement(ElementName = "powerd_battery_mode")]
        public string PowerdBatteryMode { get; set; }

        [XmlElement(ElementName = "powerd_normal_mode")]
        public string PowerdNormalMode { get; set; }

        [XmlElement(ElementName = "bogons")]
        public Bogons Bogons { get; set; }

        [XmlElement(ElementName = "pf_share_forward")]
        public int PfShareForward { get; set; }

        [XmlElement(ElementName = "lb_use_sticky")]
        public int LbUseSticky { get; set; }

        [XmlElement(ElementName = "ssh")]
        public Ssh Ssh { get; set; }

        [XmlElement(ElementName = "rrdbackup")]
        public int Rrdbackup { get; set; }

        [XmlElement(ElementName = "netflowbackup")]
        public int Netflowbackup { get; set; }

        [XmlElement(ElementName = "firmware")]
        public Firmware Firmware { get; set; }

        [XmlElement(ElementName = "language")]
        public string Language { get; set; }
    }

    [XmlRoot(ElementName = "wan")]
    public class Wan
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "blockbogons")]
        public int Blockbogons { get; set; }

        [XmlElement(ElementName = "media")]
        public object Media { get; set; }

        [XmlElement(ElementName = "mediaopt")]
        public object Mediaopt { get; set; }

        [XmlElement(ElementName = "dhcp6-ia-pd-len")]
        public int Dhcp6iapdlen { get; set; }
    }

    [XmlRoot(ElementName = "lan")]
    public class Lan
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "subnet")]
        public int Subnet { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "subnetv6")]
        public int Subnetv6 { get; set; }

        [XmlElement(ElementName = "media")]
        public object Media { get; set; }

        [XmlElement(ElementName = "mediaopt")]
        public object Mediaopt { get; set; }

        [XmlElement(ElementName = "track6-interface")]
        public string Track6interface { get; set; }

        [XmlElement(ElementName = "track6-prefix-id")]
        public int Track6prefixid { get; set; }

        [XmlElement(ElementName = "ddnsdomainalgorithm")]
        public string Ddnsdomainalgorithm { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public Numberoptions Numberoptions { get; set; }

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "winsserver")]
        public object Winsserver { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }

        [XmlElement(ElementName = "ntpserver")]
        public object Ntpserver { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }
    }

    [XmlRoot(ElementName = "opt1")]
    public class Opt1
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "subnet")]
        public int Subnet { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "subnetv6")]
        public int Subnetv6 { get; set; }

        [XmlElement(ElementName = "media")]
        public object Media { get; set; }

        [XmlElement(ElementName = "mediaopt")]
        public object Mediaopt { get; set; }

        [XmlElement(ElementName = "track6-interface")]
        public string Track6interface { get; set; }

        [XmlElement(ElementName = "track6-prefix-id")]
        public int Track6prefixid { get; set; }

        [XmlElement(ElementName = "ddnsdomainalgorithm")]
        public string Ddnsdomainalgorithm { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public Numberoptions Numberoptions { get; set; }

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "winsserver")]
        public object Winsserver { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }

        [XmlElement(ElementName = "ntpserver")]
        public object Ntpserver { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }
    }

    [XmlRoot(ElementName = "opt2")]
    public class Opt2
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "subnet")]
        public int Subnet { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "subnetv6")]
        public int Subnetv6 { get; set; }

        [XmlElement(ElementName = "media")]
        public object Media { get; set; }

        [XmlElement(ElementName = "mediaopt")]
        public object Mediaopt { get; set; }

        [XmlElement(ElementName = "track6-interface")]
        public string Track6interface { get; set; }

        [XmlElement(ElementName = "track6-prefix-id")]
        public int Track6prefixid { get; set; }

        [XmlElement(ElementName = "ddnsdomainalgorithm")]
        public string Ddnsdomainalgorithm { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public Numberoptions Numberoptions { get; set; }

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "winsserver")]
        public object Winsserver { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }

        [XmlElement(ElementName = "ntpserver")]
        public object Ntpserver { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }
    }

    [XmlRoot(ElementName = "opt3")]
    public class Opt3
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "subnet")]
        public int Subnet { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "subnetv6")]
        public int Subnetv6 { get; set; }

        [XmlElement(ElementName = "media")]
        public object Media { get; set; }

        [XmlElement(ElementName = "mediaopt")]
        public object Mediaopt { get; set; }

        [XmlElement(ElementName = "track6-interface")]
        public string Track6interface { get; set; }

        [XmlElement(ElementName = "track6-prefix-id")]
        public int Track6prefixid { get; set; }

        [XmlElement(ElementName = "ddnsdomainalgorithm")]
        public string Ddnsdomainalgorithm { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public Numberoptions Numberoptions { get; set; }

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "winsserver")]
        public object Winsserver { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }

        [XmlElement(ElementName = "ntpserver")]
        public object Ntpserver { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }
    }

    [XmlRoot(ElementName = "opt4")]
    public class Opt4
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "subnet")]
        public int Subnet { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "subnetv6")]
        public int Subnetv6 { get; set; }

        [XmlElement(ElementName = "media")]
        public object Media { get; set; }

        [XmlElement(ElementName = "mediaopt")]
        public object Mediaopt { get; set; }

        [XmlElement(ElementName = "track6-interface")]
        public string Track6interface { get; set; }

        [XmlElement(ElementName = "track6-prefix-id")]
        public int Track6prefixid { get; set; }

        [XmlElement(ElementName = "ddnsdomainalgorithm")]
        public string Ddnsdomainalgorithm { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public Numberoptions Numberoptions { get; set; }

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "winsserver")]
        public object Winsserver { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }

        [XmlElement(ElementName = "ntpserver")]
        public object Ntpserver { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }
    }

    [XmlRoot(ElementName = "opt5")]
    public class Opt5
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "subnet")]
        public int Subnet { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "subnetv6")]
        public int Subnetv6 { get; set; }

        [XmlElement(ElementName = "media")]
        public object Media { get; set; }

        [XmlElement(ElementName = "mediaopt")]
        public object Mediaopt { get; set; }

        [XmlElement(ElementName = "track6-interface")]
        public string Track6interface { get; set; }

        [XmlElement(ElementName = "track6-prefix-id")]
        public int Track6prefixid { get; set; }

        [XmlElement(ElementName = "ddnsdomainalgorithm")]
        public string Ddnsdomainalgorithm { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public Numberoptions Numberoptions { get; set; }

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "winsserver")]
        public object Winsserver { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }

        [XmlElement(ElementName = "ntpserver")]
        public object Ntpserver { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }
    }

    [XmlRoot(ElementName = "opt6")]
    public class Opt6
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "subnet")]
        public int Subnet { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "subnetv6")]
        public int Subnetv6 { get; set; }

        [XmlElement(ElementName = "media")]
        public object Media { get; set; }

        [XmlElement(ElementName = "mediaopt")]
        public object Mediaopt { get; set; }

        [XmlElement(ElementName = "track6-interface")]
        public string Track6interface { get; set; }

        [XmlElement(ElementName = "track6-prefix-id")]
        public int Track6prefixid { get; set; }

        [XmlElement(ElementName = "ddnsdomainalgorithm")]
        public string Ddnsdomainalgorithm { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public Numberoptions Numberoptions { get; set; }

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "winsserver")]
        public object Winsserver { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }

        [XmlElement(ElementName = "ntpserver")]
        public object Ntpserver { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }
    }

    [XmlRoot(ElementName = "opt7")]
    public class Opt7
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "subnet")]
        public int Subnet { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "subnetv6")]
        public int Subnetv6 { get; set; }

        [XmlElement(ElementName = "media")]
        public object Media { get; set; }

        [XmlElement(ElementName = "mediaopt")]
        public object Mediaopt { get; set; }

        [XmlElement(ElementName = "track6-interface")]
        public string Track6interface { get; set; }

        [XmlElement(ElementName = "track6-prefix-id")]
        public int Track6prefixid { get; set; }

        [XmlElement(ElementName = "ddnsdomainalgorithm")]
        public string Ddnsdomainalgorithm { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public Numberoptions Numberoptions { get; set; }

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "winsserver")]
        public object Winsserver { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }

        [XmlElement(ElementName = "ntpserver")]
        public object Ntpserver { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }
    }

    [XmlRoot(ElementName = "opt8")]
    public class Opt8
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "subnet")]
        public int Subnet { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "subnetv6")]
        public int Subnetv6 { get; set; }

        [XmlElement(ElementName = "media")]
        public object Media { get; set; }

        [XmlElement(ElementName = "mediaopt")]
        public object Mediaopt { get; set; }

        [XmlElement(ElementName = "track6-interface")]
        public string Track6interface { get; set; }

        [XmlElement(ElementName = "track6-prefix-id")]
        public int Track6prefixid { get; set; }

        [XmlElement(ElementName = "ddnsdomainalgorithm")]
        public string Ddnsdomainalgorithm { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public Numberoptions Numberoptions { get; set; }

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "winsserver")]
        public object Winsserver { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }

        [XmlElement(ElementName = "ntpserver")]
        public object Ntpserver { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }
    }

    [XmlRoot(ElementName = "opt9")]
    public class Opt9
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "subnet")]
        public int Subnet { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "subnetv6")]
        public int Subnetv6 { get; set; }

        [XmlElement(ElementName = "media")]
        public object Media { get; set; }

        [XmlElement(ElementName = "mediaopt")]
        public object Mediaopt { get; set; }

        [XmlElement(ElementName = "track6-interface")]
        public string Track6interface { get; set; }

        [XmlElement(ElementName = "track6-prefix-id")]
        public int Track6prefixid { get; set; }

        [XmlElement(ElementName = "ddnsdomainalgorithm")]
        public string Ddnsdomainalgorithm { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public Numberoptions Numberoptions { get; set; }

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "winsserver")]
        public object Winsserver { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }

        [XmlElement(ElementName = "ntpserver")]
        public object Ntpserver { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }
    }

    [XmlRoot(ElementName = "lo0")]
    public class Lo0
    {

        [XmlElement(ElementName = "internal_dynamic")]
        public int InternalDynamic { get; set; }

        [XmlElement(ElementName = "descr")]
        public string Descr { get; set; }

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "subnet")]
        public int Subnet { get; set; }

        [XmlElement(ElementName = "subnetv6")]
        public int Subnetv6 { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "virtual")]
        public int Virtual { get; set; }
    }

    [XmlRoot(ElementName = "interfaces")]
    public class Interfaces
    {

        [XmlElement(ElementName = "wan")]
        public Wan Wan { get; set; }

        [XmlElement(ElementName = "lan")]
        public Lan Lan { get; set; }

        [XmlElement(ElementName = "opt1")]
        public Opt1 Opt1 { get; set; }

        [XmlElement(ElementName = "opt2")]
        public Opt2 Opt2 { get; set; }

        [XmlElement(ElementName = "opt3")]
        public Opt3 Opt3 { get; set; }

        [XmlElement(ElementName = "opt4")]
        public Opt4 Opt4 { get; set; }

        [XmlElement(ElementName = "opt5")]
        public Opt5 Opt5 { get; set; }

        [XmlElement(ElementName = "opt6")]
        public Opt6 Opt6 { get; set; }

        [XmlElement(ElementName = "opt7")]
        public Opt7 Opt7 { get; set; }

        [XmlElement(ElementName = "opt8")]
        public Opt8 Opt8 { get; set; }

        [XmlElement(ElementName = "opt9")]
        public Opt9 Opt9 { get; set; }

        [XmlElement(ElementName = "lo0")]
        public Lo0 Lo0 { get; set; }
    }

    [XmlRoot(ElementName = "numberoptions")]
    public class Numberoptions
    {

        [XmlElement(ElementName = "item")]
        public object Item { get; set; }
    }

    [XmlRoot(ElementName = "range")]
    public class Range
    {

        [XmlElement(ElementName = "from")]
        public string From { get; set; }

        [XmlElement(ElementName = "to")]
        public string To { get; set; }
    }

    [XmlRoot(ElementName = "staticmap")]
    public class Staticmap
    {

        [XmlElement(ElementName = "mac")]
        public string Mac { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "hostname")]
        public string Hostname { get; set; }

        [XmlElement(ElementName = "winsserver")]
        public object Winsserver { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }

        [XmlElement(ElementName = "ntpserver")]
        public object Ntpserver { get; set; }
    }

    [XmlRoot(ElementName = "dhcpd")]
    public class Dhcpd
    {

        [XmlElement(ElementName = "lan")]
        public Lan Lan { get; set; }

        [XmlElement(ElementName = "opt1")]
        public Opt1 Opt1 { get; set; }

        [XmlElement(ElementName = "opt2")]
        public Opt2 Opt2 { get; set; }

        [XmlElement(ElementName = "opt3")]
        public Opt3 Opt3 { get; set; }

        [XmlElement(ElementName = "opt4")]
        public Opt4 Opt4 { get; set; }

        [XmlElement(ElementName = "opt5")]
        public Opt5 Opt5 { get; set; }

        [XmlElement(ElementName = "opt6")]
        public Opt6 Opt6 { get; set; }

        [XmlElement(ElementName = "opt7")]
        public Opt7 Opt7 { get; set; }

        [XmlElement(ElementName = "opt8")]
        public Opt8 Opt8 { get; set; }

        [XmlElement(ElementName = "opt9")]
        public Opt9 Opt9 { get; set; }
    }

    [XmlRoot(ElementName = "snmpd")]
    public class Snmpd
    {

        [XmlElement(ElementName = "syslocation")]
        public object Syslocation { get; set; }

        [XmlElement(ElementName = "syscontact")]
        public object Syscontact { get; set; }

        [XmlElement(ElementName = "rocommunity")]
        public string Rocommunity { get; set; }
    }

    [XmlRoot(ElementName = "outbound")]
    public class Outbound
    {

        [XmlElement(ElementName = "mode")]
        public string Mode { get; set; }
    }

    [XmlRoot(ElementName = "source")]
    public class Source
    {

        [XmlElement(ElementName = "any")]
        public int Any { get; set; }

        [XmlElement(ElementName = "network")]
        public string Network { get; set; }
    }

    [XmlRoot(ElementName = "destination")]
    public class Destination
    {
        [XmlElement(ElementName = "network")]
        public string Network { get; set; }

        [XmlElement(ElementName = "address")]
        public string Address { get; set; }

        [XmlElement(ElementName = "port")]
        public string Port { get; set; }

        [XmlElement(ElementName = "any")]
        public object Any { get; set; }
    }

    [XmlRoot(ElementName = "updated")]
    public class Updated
    {

        [XmlElement(ElementName = "username")]
        public string Username { get; set; }

        [XmlElement(ElementName = "time")]
        public double Time { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
    }

    [XmlRoot(ElementName = "created")]
    public class Created
    {

        [XmlElement(ElementName = "username")]
        public string Username { get; set; }

        [XmlElement(ElementName = "time")]
        public double Time { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
    }

    [XmlRoot(ElementName = "rule")]
    public class Rule
    {

        [XmlElement(ElementName = "protocol")]
        public string Protocol { get; set; }

        [XmlElement(ElementName = "interface")]
        public string Interface { get; set; }

        [XmlElement(ElementName = "category")]
        public object Category { get; set; }

        [XmlElement(ElementName = "ipprotocol")]
        public string Ipprotocol { get; set; }

        [XmlElement(ElementName = "descr")]
        public object Descr { get; set; }

        [XmlElement(ElementName = "tag")]
        public object Tag { get; set; }

        [XmlElement(ElementName = "tagged")]
        public object Tagged { get; set; }

        [XmlElement(ElementName = "poolopts")]
        public object Poolopts { get; set; }

        [XmlElement(ElementName = "associated-rule-id")]
        public string Associatedruleid { get; set; }

        [XmlElement(ElementName = "target")]
        public string Target { get; set; }

        [XmlElement(ElementName = "local-port")]
        public string Localport { get; set; }

        [XmlElement(ElementName = "source")]
        public Source Source { get; set; }

        [XmlElement(ElementName = "destination")]
        public Destination Destination { get; set; }

        [XmlElement(ElementName = "updated")]
        public Updated Updated { get; set; }

        [XmlElement(ElementName = "created")]
        public Created Created { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "statetype")]
        public string Statetype { get; set; }
    }

    [XmlRoot(ElementName = "nat")]
    public class Nat
    {

        [XmlElement(ElementName = "outbound")]
        public Outbound Outbound { get; set; }

        [XmlElement(ElementName = "rule")]
        public List<Rule> Rule { get; set; }
    }

    [XmlRoot(ElementName = "filter")]
    public class Filter
    {

        [XmlElement(ElementName = "rule")]
        public List<Rule> Rule { get; set; }
    }

    [XmlRoot(ElementName = "rrd")]
    public class Rrd
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }
    }

    [XmlRoot(ElementName = "monitor_type")]
    public class MonitorType
    {

        [XmlElement(ElementName = "options")]
        public Options Options { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "descr")]
        public string Descr { get; set; }
    }

    [XmlRoot(ElementName = "options")]
    public class Options
    {

        [XmlElement(ElementName = "path")]
        public string Path { get; set; }

        [XmlElement(ElementName = "host")]
        public object Host { get; set; }

        [XmlElement(ElementName = "code")]
        public int Code { get; set; }

        [XmlElement(ElementName = "send")]
        public object Send { get; set; }

        [XmlElement(ElementName = "expect")]
        public string Expect { get; set; }
    }

    [XmlRoot(ElementName = "load_balancer")]
    public class LoadBalancer
    {

        [XmlElement(ElementName = "monitor_type")]
        public List<MonitorType> MonitorType { get; set; }
    }

    [XmlRoot(ElementName = "ntpd")]
    public class Ntpd
    {

        [XmlElement(ElementName = "prefer")]
        public string Prefer { get; set; }
    }

    [XmlRoot(ElementName = "widgets")]
    public class Widgets
    {

        [XmlElement(ElementName = "sequence")]
        public string Sequence { get; set; }

        [XmlElement(ElementName = "column_count")]
        public int ColumnCount { get; set; }
    }

    [XmlRoot(ElementName = "revision")]
    public class Revision
    {

        [XmlElement(ElementName = "username")]
        public string Username { get; set; }

        [XmlElement(ElementName = "time")]
        public double Time { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
    }

    [XmlRoot(ElementName = "general")]
    public class General
    {

        [XmlElement(ElementName = "enabled")]
        public object Enabled { get; set; }

        [XmlElement(ElementName = "ips")]
        public int Ips { get; set; }

        [XmlElement(ElementName = "promisc")]
        public int Promisc { get; set; }

        [XmlElement(ElementName = "interfaces")]
        public string Interfaces { get; set; }

        [XmlElement(ElementName = "homenet")]
        public string Homenet { get; set; }

        [XmlElement(ElementName = "defaultPacketSize")]
        public object DefaultPacketSize { get; set; }

        [XmlElement(ElementName = "UpdateCron")]
        public object UpdateCron { get; set; }

        [XmlElement(ElementName = "AlertLogrotate")]
        public string AlertLogrotate { get; set; }

        [XmlElement(ElementName = "AlertSaveLogs")]
        public int AlertSaveLogs { get; set; }

        [XmlElement(ElementName = "MPMAlgo")]
        public string MPMAlgo { get; set; }

        [XmlElement(ElementName = "detect")]
        public Detect Detect { get; set; }

        [XmlElement(ElementName = "syslog")]
        public Syslog Syslog { get; set; }

        [XmlElement(ElementName = "syslog_eve")]
        public int SyslogEve { get; set; }

        [XmlElement(ElementName = "LogPayload")]
        public int LogPayload { get; set; }

        [XmlElement(ElementName = "verbosity")]
        public object Verbosity { get; set; }

        [XmlElement(ElementName = "interval")]
        public int Interval { get; set; }

        [XmlElement(ElementName = "startdelay")]
        public int Startdelay { get; set; }

        [XmlElement(ElementName = "mailserver")]
        public string Mailserver { get; set; }

        [XmlElement(ElementName = "port")]
        public int Port { get; set; }

        [XmlElement(ElementName = "username")]
        public object Username { get; set; }

        [XmlElement(ElementName = "password")]
        public object Password { get; set; }

        [XmlElement(ElementName = "ssl")]
        public int Ssl { get; set; }

        [XmlElement(ElementName = "sslversion")]
        public string Sslversion { get; set; }

        [XmlElement(ElementName = "sslverify")]
        public int Sslverify { get; set; }

        [XmlElement(ElementName = "logfile")]
        public string Logfile { get; set; }

        [XmlElement(ElementName = "statefile")]
        public object Statefile { get; set; }

        [XmlElement(ElementName = "eventqueuePath")]
        public object EventqueuePath { get; set; }

        [XmlElement(ElementName = "eventqueueSlots")]
        public object EventqueueSlots { get; set; }

        [XmlElement(ElementName = "httpdEnabled")]
        public int HttpdEnabled { get; set; }

        [XmlElement(ElementName = "httpdUsername")]
        public string HttpdUsername { get; set; }

        [XmlElement(ElementName = "httpdPassword")]
        public string HttpdPassword { get; set; }

        [XmlElement(ElementName = "httpdPort")]
        public int HttpdPort { get; set; }

        [XmlElement(ElementName = "httpdAllow")]
        public object HttpdAllow { get; set; }

        [XmlElement(ElementName = "mmonitUrl")]
        public object MmonitUrl { get; set; }

        [XmlElement(ElementName = "mmonitTimeout")]
        public int MmonitTimeout { get; set; }

        [XmlElement(ElementName = "mmonitRegisterCredentials")]
        public int MmonitRegisterCredentials { get; set; }

        [XmlElement(ElementName = "error_pages")]
        public string ErrorPages { get; set; }

        [XmlElement(ElementName = "icpPort")]
        public object IcpPort { get; set; }

        [XmlElement(ElementName = "logging")]
        public Logging Logging { get; set; }

        [XmlElement(ElementName = "alternateDNSservers")]
        public object AlternateDNSservers { get; set; }

        [XmlElement(ElementName = "dnsV4First")]
        public int DnsV4First { get; set; }

        [XmlElement(ElementName = "forwardedForHandling")]
        public string ForwardedForHandling { get; set; }

        [XmlElement(ElementName = "uriWhitespaceHandling")]
        public string UriWhitespaceHandling { get; set; }

        [XmlElement(ElementName = "enablePinger")]
        public int EnablePinger { get; set; }

        [XmlElement(ElementName = "useViaHeader")]
        public int UseViaHeader { get; set; }

        [XmlElement(ElementName = "suppressVersion")]
        public int SuppressVersion { get; set; }

        [XmlElement(ElementName = "connecttimeout")]
        public object Connecttimeout { get; set; }

        [XmlElement(ElementName = "VisibleEmail")]
        public string VisibleEmail { get; set; }

        [XmlElement(ElementName = "VisibleHostname")]
        public object VisibleHostname { get; set; }

        [XmlElement(ElementName = "cache")]
        public Cache Cache { get; set; }

        [XmlElement(ElementName = "traffic")]
        public Traffic Traffic { get; set; }

        [XmlElement(ElementName = "parentproxy")]
        public Parentproxy Parentproxy { get; set; }

        [XmlElement(ElementName = "stats")]
        public int Stats { get; set; }

        [XmlElement(ElementName = "active_interface")]
        public object ActiveInterface { get; set; }

        [XmlElement(ElementName = "dnssec")]
        public object Dnssec { get; set; }

        [XmlElement(ElementName = "dns64")]
        public int Dns64 { get; set; }

        [XmlElement(ElementName = "dns64prefix")]
        public string Dns64prefix { get; set; }

        [XmlElement(ElementName = "noarecords")]
        public int Noarecords { get; set; }

        [XmlElement(ElementName = "regdhcp")]
        public int Regdhcp { get; set; }

        [XmlElement(ElementName = "regdhcpdomain")]
        public object Regdhcpdomain { get; set; }

        [XmlElement(ElementName = "regdhcpstatic")]
        public int Regdhcpstatic { get; set; }

        [XmlElement(ElementName = "noreglladdr6")]
        public int Noreglladdr6 { get; set; }

        [XmlElement(ElementName = "noregrecords")]
        public int Noregrecords { get; set; }

        [XmlElement(ElementName = "txtsupport")]
        public int Txtsupport { get; set; }

        [XmlElement(ElementName = "cacheflush")]
        public int Cacheflush { get; set; }

        [XmlElement(ElementName = "local_zone_type")]
        public string LocalZoneType { get; set; }

        [XmlElement(ElementName = "outgoing_interface")]
        public object OutgoingInterface { get; set; }

        [XmlElement(ElementName = "enable_wpad")]
        public int EnableWpad { get; set; }
    }

    [XmlRoot(ElementName = "IPsec")]
    public class IPsec
    {

        [XmlElement(ElementName = "general")]
        public General General { get; set; }

        [XmlElement(ElementName = "keyPairs")]
        public object KeyPairs { get; set; }

        [XmlElement(ElementName = "preSharedKeys")]
        public object PreSharedKeys { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "Swanctl")]
    public class Swanctl
    {

        [XmlElement(ElementName = "Connections")]
        public object Connections { get; set; }

        [XmlElement(ElementName = "locals")]
        public object Locals { get; set; }

        [XmlElement(ElementName = "remotes")]
        public object Remotes { get; set; }

        [XmlElement(ElementName = "children")]
        public object Children { get; set; }

        [XmlElement(ElementName = "Pools")]
        public object Pools { get; set; }

        [XmlElement(ElementName = "VTIs")]
        public object VTIs { get; set; }

        [XmlElement(ElementName = "SPDs")]
        public object SPDs { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "OpenVPNExport")]
    public class OpenVPNExport
    {

        [XmlElement(ElementName = "servers")]
        public object Servers { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "OpenVPN")]
    public class OpenVPN
    {

        [XmlElement(ElementName = "Overwrites")]
        public object Overwrites { get; set; }

        [XmlElement(ElementName = "Instances")]
        public object Instances { get; set; }

        [XmlElement(ElementName = "StaticKeys")]
        public object StaticKeys { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "captiveportal")]
    public class Captiveportal
    {

        [XmlElement(ElementName = "zones")]
        public object Zones { get; set; }

        [XmlElement(ElementName = "templates")]
        public object Templates { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "cron")]
    public class Cron
    {

        [XmlElement(ElementName = "jobs")]
        public object Jobs { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "Lvtemplate")]
    public class Lvtemplate
    {

        [XmlElement(ElementName = "templates")]
        public object Templates { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "geoip")]
    public class Geoip
    {

        [XmlElement(ElementName = "url")]
        public object Url { get; set; }
    }

    [XmlRoot(ElementName = "Alias")]
    public class Alias
    {

        [XmlElement(ElementName = "geoip")]
        public Geoip Geoip { get; set; }

        [XmlElement(ElementName = "aliases")]
        public object Aliases { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "Category")]
    public class Category
    {

        [XmlElement(ElementName = "categories")]
        public object Categories { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "Firewall")]
    public class Firewall
    {

        [XmlElement(ElementName = "Lvtemplate")]
        public Lvtemplate Lvtemplate { get; set; }

        [XmlElement(ElementName = "Alias")]
        public Alias Alias { get; set; }

        [XmlElement(ElementName = "Category")]
        public Category Category { get; set; }
    }

    [XmlRoot(ElementName = "capture")]
    public class Capture
    {

        [XmlElement(ElementName = "interfaces")]
        public object Interfaces { get; set; }

        [XmlElement(ElementName = "egress_only")]
        public object EgressOnly { get; set; }

        [XmlElement(ElementName = "version")]
        public string Version { get; set; }

        [XmlElement(ElementName = "targets")]
        public object Targets { get; set; }
    }

    [XmlRoot(ElementName = "collect")]
    public class Collect
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }
    }

    [XmlRoot(ElementName = "Netflow")]
    public class Netflow
    {

        [XmlElement(ElementName = "capture")]
        public Capture Capture { get; set; }

        [XmlElement(ElementName = "collect")]
        public Collect Collect { get; set; }

        [XmlElement(ElementName = "activeTimeout")]
        public int ActiveTimeout { get; set; }

        [XmlElement(ElementName = "inactiveTimeout")]
        public int InactiveTimeout { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "detect")]
    public class Detect
    {

        [XmlElement(ElementName = "Profile")]
        public string Profile { get; set; }

        [XmlElement(ElementName = "toclient_groups")]
        public object ToclientGroups { get; set; }

        [XmlElement(ElementName = "toserver_groups")]
        public object ToserverGroups { get; set; }
    }

    [XmlRoot(ElementName = "IDS")]
    public class IDS
    {

        [XmlElement(ElementName = "rules")]
        public object Rules { get; set; }

        [XmlElement(ElementName = "policies")]
        public object Policies { get; set; }

        [XmlElement(ElementName = "userDefinedRules")]
        public object UserDefinedRules { get; set; }

        [XmlElement(ElementName = "files")]
        public object Files { get; set; }

        [XmlElement(ElementName = "fileTags")]
        public object FileTags { get; set; }

        [XmlElement(ElementName = "general")]
        public General General { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "loopbacks")]
    public class Loopbacks
    {

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "vxlans")]
    public class Vxlans
    {

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "Interfaces2")]
    public class Interfaces2
    {

        [XmlElement(ElementName = "loopbacks")]
        public Loopbacks Loopbacks { get; set; }

        [XmlElement(ElementName = "vxlans")]
        public Vxlans Vxlans { get; set; }
    }

    [XmlRoot(ElementName = "alert")]
    public class Alert
    {

        [XmlElement(ElementName = "enabled")]
        public int Enabled { get; set; }

        [XmlElement(ElementName = "recipient")]
        public string Recipient { get; set; }

        [XmlElement(ElementName = "noton")]
        public int Noton { get; set; }

        [XmlElement(ElementName = "events")]
        public object Events { get; set; }

        [XmlElement(ElementName = "format")]
        public object Format { get; set; }

        [XmlElement(ElementName = "reminder")]
        public int Reminder { get; set; }

        [XmlElement(ElementName = "description")]
        public object Description { get; set; }

        [XmlAttribute(AttributeName = "uuid")]
        public string Uuid { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "service")]
    public class Service
    {

        [XmlElement(ElementName = "enabled")]
        public int Enabled { get; set; }

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "description")]
        public object Description { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "pidfile")]
        public object Pidfile { get; set; }

        [XmlElement(ElementName = "match")]
        public object Match { get; set; }

        [XmlElement(ElementName = "path")]
        public object Path { get; set; }

        [XmlElement(ElementName = "timeout")]
        public int Timeout { get; set; }

        [XmlElement(ElementName = "starttimeout")]
        public int Starttimeout { get; set; }

        [XmlElement(ElementName = "address")]
        public object Address { get; set; }

        [XmlElement(ElementName = "interface")]
        public object Interface { get; set; }

        [XmlElement(ElementName = "start")]
        public object Start { get; set; }

        [XmlElement(ElementName = "stop")]
        public object Stop { get; set; }

        [XmlElement(ElementName = "tests")]
        public string Tests { get; set; }

        [XmlElement(ElementName = "depends")]
        public object Depends { get; set; }

        [XmlElement(ElementName = "polltime")]
        public object Polltime { get; set; }

        [XmlAttribute(AttributeName = "uuid")]
        public string Uuid { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "test")]
    public class Test
    {

        [XmlElement(ElementName = "name")]
        public string Name { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "condition")]
        public string Condition { get; set; }

        [XmlElement(ElementName = "action")]
        public string Action { get; set; }

        [XmlElement(ElementName = "path")]
        public object Path { get; set; }

        [XmlAttribute(AttributeName = "uuid")]
        public string Uuid { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "monit")]
    public class Monit
    {

        [XmlElement(ElementName = "general")]
        public General General { get; set; }

        [XmlElement(ElementName = "alert")]
        public Alert Alert { get; set; }

        [XmlElement(ElementName = "service")]
        public List<Service> Service { get; set; }

        [XmlElement(ElementName = "test")]
        public List<Test> Test { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "enable")]
    public class Enable
    {

        [XmlElement(ElementName = "accessLog")]
        public int AccessLog { get; set; }

        [XmlElement(ElementName = "storeLog")]
        public int StoreLog { get; set; }
    }

    [XmlRoot(ElementName = "logging")]
    public class Logging
    {

        [XmlElement(ElementName = "enable")]
        public Enable Enable { get; set; }

        [XmlElement(ElementName = "ignoreLogACL")]
        public object IgnoreLogACL { get; set; }

        [XmlElement(ElementName = "target")]
        public object Target { get; set; }
    }

    [XmlRoot(ElementName = "local")]
    public class Local
    {

        [XmlElement(ElementName = "enabled")]
        public int Enabled { get; set; }

        [XmlElement(ElementName = "directory")]
        public string Directory { get; set; }

        [XmlElement(ElementName = "cache_mem")]
        public int CacheMem { get; set; }

        [XmlElement(ElementName = "maximum_object_size")]
        public object MaximumObjectSize { get; set; }

        [XmlElement(ElementName = "maximum_object_size_in_memory")]
        public object MaximumObjectSizeInMemory { get; set; }

        [XmlElement(ElementName = "memory_cache_mode")]
        public string MemoryCacheMode { get; set; }

        [XmlElement(ElementName = "size")]
        public int Size { get; set; }

        [XmlElement(ElementName = "l1")]
        public int L1 { get; set; }

        [XmlElement(ElementName = "l2")]
        public int L2 { get; set; }

        [XmlElement(ElementName = "cache_linux_packages")]
        public int CacheLinuxPackages { get; set; }

        [XmlElement(ElementName = "cache_windows_updates")]
        public int CacheWindowsUpdates { get; set; }
    }

    [XmlRoot(ElementName = "cache")]
    public class Cache
    {

        [XmlElement(ElementName = "local")]
        public Local Local { get; set; }
    }

    [XmlRoot(ElementName = "traffic")]
    public class Traffic
    {

        [XmlElement(ElementName = "enabled")]
        public int Enabled { get; set; }

        [XmlElement(ElementName = "maxDownloadSize")]
        public int MaxDownloadSize { get; set; }

        [XmlElement(ElementName = "maxUploadSize")]
        public int MaxUploadSize { get; set; }

        [XmlElement(ElementName = "OverallBandwidthTrotteling")]
        public int OverallBandwidthTrotteling { get; set; }

        [XmlElement(ElementName = "perHostTrotteling")]
        public int PerHostTrotteling { get; set; }
    }

    [XmlRoot(ElementName = "parentproxy")]
    public class Parentproxy
    {

        [XmlElement(ElementName = "enabled")]
        public int Enabled { get; set; }

        [XmlElement(ElementName = "host")]
        public object Host { get; set; }

        [XmlElement(ElementName = "enableauth")]
        public int Enableauth { get; set; }

        [XmlElement(ElementName = "user")]
        public string User { get; set; }

        [XmlElement(ElementName = "password")]
        public string Password { get; set; }

        [XmlElement(ElementName = "port")]
        public object Port { get; set; }

        [XmlElement(ElementName = "localdomains")]
        public object Localdomains { get; set; }

        [XmlElement(ElementName = "localips")]
        public object Localips { get; set; }
    }

    [XmlRoot(ElementName = "remoteACLs")]
    public class RemoteACLs
    {

        [XmlElement(ElementName = "blacklists")]
        public object Blacklists { get; set; }

        [XmlElement(ElementName = "UpdateCron")]
        public object UpdateCron { get; set; }
    }

    [XmlRoot(ElementName = "acl")]
    public class Acl
    {

        [XmlElement(ElementName = "allowedSubnets")]
        public object AllowedSubnets { get; set; }

        [XmlElement(ElementName = "unrestricted")]
        public object Unrestricted { get; set; }

        [XmlElement(ElementName = "bannedHosts")]
        public object BannedHosts { get; set; }

        [XmlElement(ElementName = "whiteList")]
        public object WhiteList { get; set; }

        [XmlElement(ElementName = "blackList")]
        public object BlackList { get; set; }

        [XmlElement(ElementName = "browser")]
        public object Browser { get; set; }

        [XmlElement(ElementName = "mimeType")]
        public object MimeType { get; set; }

        [XmlElement(ElementName = "googleapps")]
        public object Googleapps { get; set; }

        [XmlElement(ElementName = "youtube")]
        public object Youtube { get; set; }

        [XmlElement(ElementName = "safePorts")]
        public string SafePorts { get; set; }

        [XmlElement(ElementName = "sslPorts")]
        public string SslPorts { get; set; }

        [XmlElement(ElementName = "remoteACLs")]
        public RemoteACLs RemoteACLs { get; set; }
    }

    [XmlRoot(ElementName = "icap")]
    public class Icap
    {

        [XmlElement(ElementName = "enable")]
        public int Enable { get; set; }

        [XmlElement(ElementName = "RequestURL")]
        public string RequestURL { get; set; }

        [XmlElement(ElementName = "ResponseURL")]
        public string ResponseURL { get; set; }

        [XmlElement(ElementName = "SendClientIP")]
        public int SendClientIP { get; set; }

        [XmlElement(ElementName = "SendUsername")]
        public int SendUsername { get; set; }

        [XmlElement(ElementName = "EncodeUsername")]
        public int EncodeUsername { get; set; }

        [XmlElement(ElementName = "UsernameHeader")]
        public string UsernameHeader { get; set; }

        [XmlElement(ElementName = "EnablePreview")]
        public int EnablePreview { get; set; }

        [XmlElement(ElementName = "PreviewSize")]
        public int PreviewSize { get; set; }

        [XmlElement(ElementName = "OptionsTTL")]
        public int OptionsTTL { get; set; }

        [XmlElement(ElementName = "exclude")]
        public object Exclude { get; set; }
    }

    [XmlRoot(ElementName = "authentication")]
    public class Authentication
    {

        [XmlElement(ElementName = "method")]
        public object Method { get; set; }

        [XmlElement(ElementName = "authEnforceGroup")]
        public object AuthEnforceGroup { get; set; }

        [XmlElement(ElementName = "realm")]
        public string Realm { get; set; }

        [XmlElement(ElementName = "credentialsttl")]
        public int Credentialsttl { get; set; }

        [XmlElement(ElementName = "children")]
        public int Children { get; set; }
    }

    [XmlRoot(ElementName = "forward")]
    public class Forward
    {

        [XmlElement(ElementName = "interfaces")]
        public string Interfaces { get; set; }

        [XmlElement(ElementName = "port")]
        public int Port { get; set; }

        [XmlElement(ElementName = "sslbumpport")]
        public int Sslbumpport { get; set; }

        [XmlElement(ElementName = "sslbump")]
        public int Sslbump { get; set; }

        [XmlElement(ElementName = "sslurlonly")]
        public int Sslurlonly { get; set; }

        [XmlElement(ElementName = "sslcertificate")]
        public object Sslcertificate { get; set; }

        [XmlElement(ElementName = "sslnobumpsites")]
        public object Sslnobumpsites { get; set; }

        [XmlElement(ElementName = "ssl_crtd_storage_max_size")]
        public int SslCrtdStorageMaxSize { get; set; }

        [XmlElement(ElementName = "sslcrtd_children")]
        public int SslcrtdChildren { get; set; }

        [XmlElement(ElementName = "snmp_enable")]
        public int SnmpEnable { get; set; }

        [XmlElement(ElementName = "snmp_port")]
        public int SnmpPort { get; set; }

        [XmlElement(ElementName = "snmp_password")]
        public string SnmpPassword { get; set; }

        [XmlElement(ElementName = "ftpInterfaces")]
        public object FtpInterfaces { get; set; }

        [XmlElement(ElementName = "ftpPort")]
        public int FtpPort { get; set; }

        [XmlElement(ElementName = "ftpTransparentMode")]
        public int FtpTransparentMode { get; set; }

        [XmlElement(ElementName = "addACLforInterfaceSubnets")]
        public int AddACLforInterfaceSubnets { get; set; }

        [XmlElement(ElementName = "transparentMode")]
        public int TransparentMode { get; set; }

        [XmlElement(ElementName = "acl")]
        public Acl Acl { get; set; }

        [XmlElement(ElementName = "icap")]
        public Icap Icap { get; set; }

        [XmlElement(ElementName = "authentication")]
        public Authentication Authentication { get; set; }
    }

    [XmlRoot(ElementName = "error_pages")]
    public class ErrorPages
    {

        [XmlElement(ElementName = "template")]
        public object Template { get; set; }
    }

    [XmlRoot(ElementName = "proxy")]
    public class Proxy
    {

        [XmlElement(ElementName = "general")]
        public General General { get; set; }

        [XmlElement(ElementName = "forward")]
        public Forward Forward { get; set; }

        [XmlElement(ElementName = "pac")]
        public object Pac { get; set; }

        [XmlElement(ElementName = "error_pages")]
        public ErrorPages ErrorPages { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Syslog")]
    public class Syslog
    {

        [XmlElement(ElementName = "general")]
        public General General { get; set; }

        [XmlElement(ElementName = "destinations")]
        public object Destinations { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "TrafficShaper")]
    public class TrafficShaper
    {

        [XmlElement(ElementName = "pipes")]
        public object Pipes { get; set; }

        [XmlElement(ElementName = "queues")]
        public object Queues { get; set; }

        [XmlElement(ElementName = "rules")]
        public object Rules { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "advanced")]
    public class Advanced
    {

        [XmlElement(ElementName = "hideidentity")]
        public int Hideidentity { get; set; }

        [XmlElement(ElementName = "hideversion")]
        public int Hideversion { get; set; }

        [XmlElement(ElementName = "prefetch")]
        public int Prefetch { get; set; }

        [XmlElement(ElementName = "prefetchkey")]
        public int Prefetchkey { get; set; }

        [XmlElement(ElementName = "dnssecstripped")]
        public object Dnssecstripped { get; set; }

        [XmlElement(ElementName = "serveexpired")]
        public int Serveexpired { get; set; }

        [XmlElement(ElementName = "serveexpiredreplyttl")]
        public object Serveexpiredreplyttl { get; set; }

        [XmlElement(ElementName = "serveexpiredttl")]
        public object Serveexpiredttl { get; set; }

        [XmlElement(ElementName = "serveexpiredttlreset")]
        public int Serveexpiredttlreset { get; set; }

        [XmlElement(ElementName = "serveexpiredclienttimeout")]
        public object Serveexpiredclienttimeout { get; set; }

        [XmlElement(ElementName = "qnameminstrict")]
        public int Qnameminstrict { get; set; }

        [XmlElement(ElementName = "extendedstatistics")]
        public int Extendedstatistics { get; set; }

        [XmlElement(ElementName = "logqueries")]
        public int Logqueries { get; set; }

        [XmlElement(ElementName = "logreplies")]
        public int Logreplies { get; set; }

        [XmlElement(ElementName = "logtagqueryreply")]
        public int Logtagqueryreply { get; set; }

        [XmlElement(ElementName = "logservfail")]
        public int Logservfail { get; set; }

        [XmlElement(ElementName = "loglocalactions")]
        public int Loglocalactions { get; set; }

        [XmlElement(ElementName = "logverbosity")]
        public int Logverbosity { get; set; }

        [XmlElement(ElementName = "valloglevel")]
        public int Valloglevel { get; set; }

        [XmlElement(ElementName = "privatedomain")]
        public object Privatedomain { get; set; }

        [XmlElement(ElementName = "privateaddress")]
        public string Privateaddress { get; set; }

        [XmlElement(ElementName = "insecuredomain")]
        public object Insecuredomain { get; set; }

        [XmlElement(ElementName = "msgcachesize")]
        public object Msgcachesize { get; set; }

        [XmlElement(ElementName = "rrsetcachesize")]
        public object Rrsetcachesize { get; set; }

        [XmlElement(ElementName = "outgoingnumtcp")]
        public object Outgoingnumtcp { get; set; }

        [XmlElement(ElementName = "incomingnumtcp")]
        public object Incomingnumtcp { get; set; }

        [XmlElement(ElementName = "numqueriesperthread")]
        public object Numqueriesperthread { get; set; }

        [XmlElement(ElementName = "outgoingrange")]
        public object Outgoingrange { get; set; }

        [XmlElement(ElementName = "jostletimeout")]
        public object Jostletimeout { get; set; }

        [XmlElement(ElementName = "cachemaxttl")]
        public object Cachemaxttl { get; set; }

        [XmlElement(ElementName = "cachemaxnegativettl")]
        public object Cachemaxnegativettl { get; set; }

        [XmlElement(ElementName = "cacheminttl")]
        public object Cacheminttl { get; set; }

        [XmlElement(ElementName = "infrahostttl")]
        public object Infrahostttl { get; set; }

        [XmlElement(ElementName = "infrakeepprobing")]
        public int Infrakeepprobing { get; set; }

        [XmlElement(ElementName = "infracachenumhosts")]
        public object Infracachenumhosts { get; set; }

        [XmlElement(ElementName = "unwantedreplythreshold")]
        public object Unwantedreplythreshold { get; set; }
    }

    [XmlRoot(ElementName = "acls")]
    public class Acls
    {

        [XmlElement(ElementName = "default_action")]
        public string DefaultAction { get; set; }
    }

    [XmlRoot(ElementName = "dnsbl")]
    public class Dnsbl
    {

        [XmlElement(ElementName = "enabled")]
        public int Enabled { get; set; }

        [XmlElement(ElementName = "safesearch")]
        public int Safesearch { get; set; }

        [XmlElement(ElementName = "type")]
        public object Type { get; set; }

        [XmlElement(ElementName = "lists")]
        public object Lists { get; set; }

        [XmlElement(ElementName = "whitelists")]
        public object Whitelists { get; set; }

        [XmlElement(ElementName = "blocklists")]
        public object Blocklists { get; set; }

        [XmlElement(ElementName = "wildcards")]
        public object Wildcards { get; set; }

        [XmlElement(ElementName = "address")]
        public object Address { get; set; }

        [XmlElement(ElementName = "nxdomain")]
        public int Nxdomain { get; set; }
    }

    [XmlRoot(ElementName = "forwarding")]
    public class Forwarding
    {

        [XmlElement(ElementName = "enabled")]
        public int Enabled { get; set; }
    }

    [XmlRoot(ElementName = "unboundplus")]
    public class Unboundplus
    {

        [XmlElement(ElementName = "general")]
        public General General { get; set; }

        [XmlElement(ElementName = "advanced")]
        public Advanced Advanced { get; set; }

        [XmlElement(ElementName = "acls")]
        public Acls Acls { get; set; }

        [XmlElement(ElementName = "dnsbl")]
        public Dnsbl Dnsbl { get; set; }

        [XmlElement(ElementName = "forwarding")]
        public Forwarding Forwarding { get; set; }

        [XmlElement(ElementName = "dots")]
        public object Dots { get; set; }

        [XmlElement(ElementName = "hosts")]
        public object Hosts { get; set; }

        [XmlElement(ElementName = "aliases")]
        public object Aliases { get; set; }

        [XmlElement(ElementName = "domains")]
        public object Domains { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "Gateways")]
    public class Gateways
    {

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "OPNsense")]
    public class OPNsense
    {

        [XmlElement(ElementName = "IPsec")]
        public IPsec IPsec { get; set; }

        [XmlElement(ElementName = "Swanctl")]
        public Swanctl Swanctl { get; set; }

        [XmlElement(ElementName = "OpenVPNExport")]
        public OpenVPNExport OpenVPNExport { get; set; }

        [XmlElement(ElementName = "OpenVPN")]
        public OpenVPN OpenVPN { get; set; }

        [XmlElement(ElementName = "captiveportal")]
        public Captiveportal Captiveportal { get; set; }

        [XmlElement(ElementName = "cron")]
        public Cron Cron { get; set; }

        [XmlElement(ElementName = "Firewall")]
        public Firewall Firewall { get; set; }

        [XmlElement(ElementName = "Netflow")]
        public Netflow Netflow { get; set; }

        [XmlElement(ElementName = "IDS")]
        public IDS IDS { get; set; }

        [XmlElement(ElementName = "Interfaces")]
        public Interfaces Interfaces { get; set; }

        [XmlElement(ElementName = "monit")]
        public Monit Monit { get; set; }

        [XmlElement(ElementName = "proxy")]
        public Proxy Proxy { get; set; }

        [XmlElement(ElementName = "Syslog")]
        public Syslog Syslog { get; set; }

        [XmlElement(ElementName = "TrafficShaper")]
        public TrafficShaper TrafficShaper { get; set; }

        [XmlElement(ElementName = "unboundplus")]
        public Unboundplus Unboundplus { get; set; }

        [XmlElement(ElementName = "Gateways")]
        public Gateways Gateways { get; set; }
    }

    [XmlRoot(ElementName = "ifgroups")]
    public class Ifgroups
    {

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "laggs")]
    public class Laggs
    {

        [XmlElement(ElementName = "lagg")]
        public object Lagg { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "virtualip")]
    public class Virtualip
    {

        [XmlElement(ElementName = "vip")]
        public object Vip { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "vlans")]
    public class Vlans
    {

        [XmlElement(ElementName = "vlan")]
        public object Vlan { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "staticroutes")]
    public class Staticroutes
    {

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }
    }

    [XmlRoot(ElementName = "bridges")]
    public class Bridges
    {

        [XmlElement(ElementName = "bridged")]
        public object Bridged { get; set; }
    }

    [XmlRoot(ElementName = "gifs")]
    public class Gifs
    {

        [XmlElement(ElementName = "gif")]
        public object Gif { get; set; }
    }

    [XmlRoot(ElementName = "gres")]
    public class Gres
    {

        [XmlElement(ElementName = "gre")]
        public object Gre { get; set; }
    }

    [XmlRoot(ElementName = "ppps")]
    public class Ppps
    {

        [XmlElement(ElementName = "ppp")]
        public object Ppp { get; set; }
    }

    [XmlRoot(ElementName = "wireless")]
    public class Wireless
    {

        [XmlElement(ElementName = "clone")]
        public object Clone { get; set; }
    }

    [XmlRoot(ElementName = "cert")]
    public class Cert
    {

        [XmlElement(ElementName = "refid")]
        public string Refid { get; set; }

        [XmlElement(ElementName = "descr")]
        public string Descr { get; set; }

        [XmlElement(ElementName = "crt")]
        public string Crt { get; set; }

        [XmlElement(ElementName = "prv")]
        public string Prv { get; set; }
    }

    [XmlRoot(ElementName = "opnsense")]
    public class Opnsense
    {

        [XmlElement(ElementName = "theme")]
        public string Theme { get; set; }

        [XmlElement(ElementName = "sysctl")]
        public Sysctl Sysctl { get; set; }

        [XmlElement(ElementName = "system")]
        public System System { get; set; }

        [XmlElement(ElementName = "interfaces")]
        public Interfaces Interfaces { get; set; }

        [XmlElement(ElementName = "dhcpd")]
        public Dhcpd Dhcpd { get; set; }

        [XmlElement(ElementName = "snmpd")]
        public Snmpd Snmpd { get; set; }

        [XmlElement(ElementName = "nat")]
        public Nat Nat { get; set; }

        [XmlElement(ElementName = "filter")]
        public Filter Filter { get; set; }

        [XmlElement(ElementName = "rrd")]
        public Rrd Rrd { get; set; }

        [XmlElement(ElementName = "load_balancer")]
        public LoadBalancer LoadBalancer { get; set; }

        [XmlElement(ElementName = "ntpd")]
        public Ntpd Ntpd { get; set; }

        [XmlElement(ElementName = "widgets")]
        public Widgets Widgets { get; set; }

        [XmlElement(ElementName = "revision")]
        public Revision Revision { get; set; }

        [XmlElement(ElementName = "OPNsense")]
        public OPNsense OPNsense { get; set; }

        [XmlElement(ElementName = "openvpn")]
        public object Openvpn { get; set; }

        [XmlElement(ElementName = "ifgroups")]
        public Ifgroups Ifgroups { get; set; }

        [XmlElement(ElementName = "laggs")]
        public Laggs Laggs { get; set; }

        [XmlElement(ElementName = "virtualip")]
        public Virtualip Virtualip { get; set; }

        [XmlElement(ElementName = "vlans")]
        public Vlans Vlans { get; set; }

        [XmlElement(ElementName = "staticroutes")]
        public Staticroutes Staticroutes { get; set; }

        [XmlElement(ElementName = "bridges")]
        public Bridges Bridges { get; set; }

        [XmlElement(ElementName = "gifs")]
        public Gifs Gifs { get; set; }

        [XmlElement(ElementName = "gres")]
        public Gres Gres { get; set; }

        [XmlElement(ElementName = "ppps")]
        public Ppps Ppps { get; set; }

        [XmlElement(ElementName = "wireless")]
        public Wireless Wireless { get; set; }

        [XmlElement(ElementName = "ca")]
        public object Ca { get; set; }

        [XmlElement(ElementName = "dhcpdv6")]
        public object Dhcpdv6 { get; set; }

        [XmlElement(ElementName = "cert")]
        public Cert Cert { get; set; }
    }
}