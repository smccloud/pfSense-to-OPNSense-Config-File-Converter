using System.Xml.Serialization;

namespace pfSenseConfig
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Pfsense));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Pfsense)serializer.Deserialize(reader);
    // }

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

        [XmlElement(ElementName = "uid")]
        public int Uid { get; set; }

        [XmlElement(ElementName = "priv")]
        public string Priv { get; set; }

        [XmlElement(ElementName = "bcrypt-hash")]
        public string Bcrypthash { get; set; }

        [XmlElement(ElementName = "expires")]
        public object Expires { get; set; }

        [XmlElement(ElementName = "dashboardcolumns")]
        public int Dashboardcolumns { get; set; }

        [XmlElement(ElementName = "authorizedkeys")]
        public object Authorizedkeys { get; set; }

        [XmlElement(ElementName = "ipsecpsk")]
        public object Ipsecpsk { get; set; }

        [XmlElement(ElementName = "webguicss")]
        public string Webguicss { get; set; }
    }

    [XmlRoot(ElementName = "webgui")]
    public class Webgui
    {

        [XmlElement(ElementName = "protocol")]
        public string Protocol { get; set; }

        [XmlElement(ElementName = "loginautocomplete")]
        public object Loginautocomplete { get; set; }

        [XmlElement(ElementName = "ssl-certref")]
        public string Sslcertref { get; set; }

        [XmlElement(ElementName = "althostnames")]
        public object Althostnames { get; set; }

        [XmlElement(ElementName = "dashboardcolumns")]
        public int Dashboardcolumns { get; set; }
    }

    [XmlRoot(ElementName = "bogons")]
    public class Bogons
    {

        [XmlElement(ElementName = "interval")]
        public string Interval { get; set; }
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
        public string Dnsallowoverride { get; set; }

        [XmlElement(ElementName = "group")]
        public List<Group> Group { get; set; }

        [XmlElement(ElementName = "user")]
        public List<User> User { get; set; }

        [XmlElement(ElementName = "nextuid")]
        public int Nextuid { get; set; }

        [XmlElement(ElementName = "nextgid")]
        public int Nextgid { get; set; }

        [XmlElement(ElementName = "timeservers")]
        public string Timeservers { get; set; }

        [XmlElement(ElementName = "webgui")]
        public Webgui Webgui { get; set; }

        [XmlElement(ElementName = "disablenatreflection")]
        public string Disablenatreflection { get; set; }

        [XmlElement(ElementName = "disablesegmentationoffloading")]
        public object Disablesegmentationoffloading { get; set; }

        [XmlElement(ElementName = "disablelargereceiveoffloading")]
        public object Disablelargereceiveoffloading { get; set; }

        [XmlElement(ElementName = "ipv6allow")]
        public object Ipv6allow { get; set; }

        [XmlElement(ElementName = "maximumtableentries")]
        public int Maximumtableentries { get; set; }

        [XmlElement(ElementName = "powerd_ac_mode")]
        public string PowerdAcMode { get; set; }

        [XmlElement(ElementName = "powerd_battery_mode")]
        public string PowerdBatteryMode { get; set; }

        [XmlElement(ElementName = "powerd_normal_mode")]
        public string PowerdNormalMode { get; set; }

        [XmlElement(ElementName = "bogons")]
        public Bogons Bogons { get; set; }

        [XmlElement(ElementName = "hn_altq_enable")]
        public object HnAltqEnable { get; set; }

        [XmlElement(ElementName = "already_run_config_upgrade")]
        public object AlreadyRunConfigUpgrade { get; set; }

        [XmlElement(ElementName = "ssh")]
        public object Ssh { get; set; }

        [XmlElement(ElementName = "timezone")]
        public string Timezone { get; set; }
    }

    [XmlRoot(ElementName = "wan")]
    public class Wan
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }

        [XmlElement(ElementName = "if")]
        public string If { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "blockbogons")]
        public string Blockbogons { get; set; }

        [XmlElement(ElementName = "media")]
        public object Media { get; set; }

        [XmlElement(ElementName = "mediaopt")]
        public object Mediaopt { get; set; }

        [XmlElement(ElementName = "dhcp6-duid")]
        public object Dhcp6duid { get; set; }

        [XmlElement(ElementName = "dhcp6-ia-pd-len")]
        public int Dhcp6iapdlen { get; set; }
    }

    [XmlRoot(ElementName = "lan")]
    public class Lan
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }

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

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "failover_peerip")]
        public object FailoverPeerip { get; set; }

        [XmlElement(ElementName = "defaultleasetime")]
        public object Defaultleasetime { get; set; }

        [XmlElement(ElementName = "maxleasetime")]
        public object Maxleasetime { get; set; }

        [XmlElement(ElementName = "netmask")]
        public object Netmask { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "domain")]
        public object Domain { get; set; }

        [XmlElement(ElementName = "domainsearchlist")]
        public object Domainsearchlist { get; set; }

        [XmlElement(ElementName = "ddnsdomain")]
        public object Ddnsdomain { get; set; }

        [XmlElement(ElementName = "ddnsdomainprimary")]
        public object Ddnsdomainprimary { get; set; }

        [XmlElement(ElementName = "ddnsdomainsecondary")]
        public object Ddnsdomainsecondary { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyname")]
        public object Ddnsdomainkeyname { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyalgorithm")]
        public string Ddnsdomainkeyalgorithm { get; set; }

        [XmlElement(ElementName = "ddnsdomainkey")]
        public object Ddnsdomainkey { get; set; }

        [XmlElement(ElementName = "mac_allow")]
        public object MacAllow { get; set; }

        [XmlElement(ElementName = "mac_deny")]
        public object MacDeny { get; set; }

        [XmlElement(ElementName = "ddnsclientupdates")]
        public string Ddnsclientupdates { get; set; }

        [XmlElement(ElementName = "tftp")]
        public object Tftp { get; set; }

        [XmlElement(ElementName = "ldap")]
        public object Ldap { get; set; }

        [XmlElement(ElementName = "nextserver")]
        public object Nextserver { get; set; }

        [XmlElement(ElementName = "filename")]
        public object Filename { get; set; }

        [XmlElement(ElementName = "filename32")]
        public object Filename32 { get; set; }

        [XmlElement(ElementName = "filename64")]
        public object Filename64 { get; set; }

        [XmlElement(ElementName = "filename32arm")]
        public object Filename32arm { get; set; }

        [XmlElement(ElementName = "filename64arm")]
        public object Filename64arm { get; set; }

        [XmlElement(ElementName = "uefihttpboot")]
        public object Uefihttpboot { get; set; }

        [XmlElement(ElementName = "rootpath")]
        public object Rootpath { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public object Numberoptions { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }

        [XmlElement(ElementName = "ramode")]
        public string Ramode { get; set; }

        [XmlElement(ElementName = "rapriority")]
        public string Rapriority { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }
    }

    [XmlRoot(ElementName = "opt1")]
    public class Opt1
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }

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

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "failover_peerip")]
        public object FailoverPeerip { get; set; }

        [XmlElement(ElementName = "defaultleasetime")]
        public object Defaultleasetime { get; set; }

        [XmlElement(ElementName = "maxleasetime")]
        public object Maxleasetime { get; set; }

        [XmlElement(ElementName = "netmask")]
        public object Netmask { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "domain")]
        public object Domain { get; set; }

        [XmlElement(ElementName = "domainsearchlist")]
        public object Domainsearchlist { get; set; }

        [XmlElement(ElementName = "ddnsdomain")]
        public object Ddnsdomain { get; set; }

        [XmlElement(ElementName = "ddnsdomainprimary")]
        public object Ddnsdomainprimary { get; set; }

        [XmlElement(ElementName = "ddnsdomainsecondary")]
        public object Ddnsdomainsecondary { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyname")]
        public object Ddnsdomainkeyname { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyalgorithm")]
        public string Ddnsdomainkeyalgorithm { get; set; }

        [XmlElement(ElementName = "ddnsdomainkey")]
        public object Ddnsdomainkey { get; set; }

        [XmlElement(ElementName = "mac_allow")]
        public object MacAllow { get; set; }

        [XmlElement(ElementName = "mac_deny")]
        public object MacDeny { get; set; }

        [XmlElement(ElementName = "ddnsclientupdates")]
        public string Ddnsclientupdates { get; set; }

        [XmlElement(ElementName = "tftp")]
        public object Tftp { get; set; }

        [XmlElement(ElementName = "ldap")]
        public object Ldap { get; set; }

        [XmlElement(ElementName = "nextserver")]
        public object Nextserver { get; set; }

        [XmlElement(ElementName = "filename")]
        public object Filename { get; set; }

        [XmlElement(ElementName = "filename32")]
        public object Filename32 { get; set; }

        [XmlElement(ElementName = "filename64")]
        public object Filename64 { get; set; }

        [XmlElement(ElementName = "filename32arm")]
        public object Filename32arm { get; set; }

        [XmlElement(ElementName = "filename64arm")]
        public object Filename64arm { get; set; }

        [XmlElement(ElementName = "uefihttpboot")]
        public object Uefihttpboot { get; set; }

        [XmlElement(ElementName = "rootpath")]
        public object Rootpath { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public object Numberoptions { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }

        [XmlElement(ElementName = "ramode")]
        public string Ramode { get; set; }

        [XmlElement(ElementName = "rapriority")]
        public string Rapriority { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }
    }

    [XmlRoot(ElementName = "opt2")]
    public class Opt2
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }

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

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "failover_peerip")]
        public object FailoverPeerip { get; set; }

        [XmlElement(ElementName = "defaultleasetime")]
        public object Defaultleasetime { get; set; }

        [XmlElement(ElementName = "maxleasetime")]
        public object Maxleasetime { get; set; }

        [XmlElement(ElementName = "netmask")]
        public object Netmask { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "domain")]
        public object Domain { get; set; }

        [XmlElement(ElementName = "domainsearchlist")]
        public object Domainsearchlist { get; set; }

        [XmlElement(ElementName = "ddnsdomain")]
        public object Ddnsdomain { get; set; }

        [XmlElement(ElementName = "ddnsdomainprimary")]
        public object Ddnsdomainprimary { get; set; }

        [XmlElement(ElementName = "ddnsdomainsecondary")]
        public object Ddnsdomainsecondary { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyname")]
        public object Ddnsdomainkeyname { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyalgorithm")]
        public string Ddnsdomainkeyalgorithm { get; set; }

        [XmlElement(ElementName = "ddnsdomainkey")]
        public object Ddnsdomainkey { get; set; }

        [XmlElement(ElementName = "mac_allow")]
        public object MacAllow { get; set; }

        [XmlElement(ElementName = "mac_deny")]
        public object MacDeny { get; set; }

        [XmlElement(ElementName = "ddnsclientupdates")]
        public string Ddnsclientupdates { get; set; }

        [XmlElement(ElementName = "tftp")]
        public object Tftp { get; set; }

        [XmlElement(ElementName = "ldap")]
        public object Ldap { get; set; }

        [XmlElement(ElementName = "nextserver")]
        public object Nextserver { get; set; }

        [XmlElement(ElementName = "filename")]
        public object Filename { get; set; }

        [XmlElement(ElementName = "filename32")]
        public object Filename32 { get; set; }

        [XmlElement(ElementName = "filename64")]
        public object Filename64 { get; set; }

        [XmlElement(ElementName = "filename32arm")]
        public object Filename32arm { get; set; }

        [XmlElement(ElementName = "filename64arm")]
        public object Filename64arm { get; set; }

        [XmlElement(ElementName = "uefihttpboot")]
        public object Uefihttpboot { get; set; }

        [XmlElement(ElementName = "rootpath")]
        public object Rootpath { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public object Numberoptions { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }

        [XmlElement(ElementName = "ramode")]
        public string Ramode { get; set; }

        [XmlElement(ElementName = "rapriority")]
        public string Rapriority { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }
    }

    [XmlRoot(ElementName = "opt3")]
    public class Opt3
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }

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

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "failover_peerip")]
        public object FailoverPeerip { get; set; }

        [XmlElement(ElementName = "defaultleasetime")]
        public object Defaultleasetime { get; set; }

        [XmlElement(ElementName = "maxleasetime")]
        public object Maxleasetime { get; set; }

        [XmlElement(ElementName = "netmask")]
        public object Netmask { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "domain")]
        public object Domain { get; set; }

        [XmlElement(ElementName = "domainsearchlist")]
        public object Domainsearchlist { get; set; }

        [XmlElement(ElementName = "ddnsdomain")]
        public object Ddnsdomain { get; set; }

        [XmlElement(ElementName = "ddnsdomainprimary")]
        public object Ddnsdomainprimary { get; set; }

        [XmlElement(ElementName = "ddnsdomainsecondary")]
        public object Ddnsdomainsecondary { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyname")]
        public object Ddnsdomainkeyname { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyalgorithm")]
        public string Ddnsdomainkeyalgorithm { get; set; }

        [XmlElement(ElementName = "ddnsdomainkey")]
        public object Ddnsdomainkey { get; set; }

        [XmlElement(ElementName = "mac_allow")]
        public object MacAllow { get; set; }

        [XmlElement(ElementName = "mac_deny")]
        public object MacDeny { get; set; }

        [XmlElement(ElementName = "ddnsclientupdates")]
        public string Ddnsclientupdates { get; set; }

        [XmlElement(ElementName = "tftp")]
        public object Tftp { get; set; }

        [XmlElement(ElementName = "ldap")]
        public object Ldap { get; set; }

        [XmlElement(ElementName = "nextserver")]
        public object Nextserver { get; set; }

        [XmlElement(ElementName = "filename")]
        public object Filename { get; set; }

        [XmlElement(ElementName = "filename32")]
        public object Filename32 { get; set; }

        [XmlElement(ElementName = "filename64")]
        public object Filename64 { get; set; }

        [XmlElement(ElementName = "filename32arm")]
        public object Filename32arm { get; set; }

        [XmlElement(ElementName = "filename64arm")]
        public object Filename64arm { get; set; }

        [XmlElement(ElementName = "uefihttpboot")]
        public object Uefihttpboot { get; set; }

        [XmlElement(ElementName = "rootpath")]
        public object Rootpath { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public object Numberoptions { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }

        [XmlElement(ElementName = "ramode")]
        public string Ramode { get; set; }

        [XmlElement(ElementName = "rapriority")]
        public string Rapriority { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }
    }

    [XmlRoot(ElementName = "opt4")]
    public class Opt4
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }

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

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "failover_peerip")]
        public object FailoverPeerip { get; set; }

        [XmlElement(ElementName = "defaultleasetime")]
        public object Defaultleasetime { get; set; }

        [XmlElement(ElementName = "maxleasetime")]
        public object Maxleasetime { get; set; }

        [XmlElement(ElementName = "netmask")]
        public object Netmask { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "domain")]
        public object Domain { get; set; }

        [XmlElement(ElementName = "domainsearchlist")]
        public object Domainsearchlist { get; set; }

        [XmlElement(ElementName = "ddnsdomain")]
        public object Ddnsdomain { get; set; }

        [XmlElement(ElementName = "ddnsdomainprimary")]
        public object Ddnsdomainprimary { get; set; }

        [XmlElement(ElementName = "ddnsdomainsecondary")]
        public object Ddnsdomainsecondary { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyname")]
        public object Ddnsdomainkeyname { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyalgorithm")]
        public string Ddnsdomainkeyalgorithm { get; set; }

        [XmlElement(ElementName = "ddnsdomainkey")]
        public object Ddnsdomainkey { get; set; }

        [XmlElement(ElementName = "mac_allow")]
        public object MacAllow { get; set; }

        [XmlElement(ElementName = "mac_deny")]
        public object MacDeny { get; set; }

        [XmlElement(ElementName = "ddnsclientupdates")]
        public string Ddnsclientupdates { get; set; }

        [XmlElement(ElementName = "tftp")]
        public object Tftp { get; set; }

        [XmlElement(ElementName = "ldap")]
        public object Ldap { get; set; }

        [XmlElement(ElementName = "nextserver")]
        public object Nextserver { get; set; }

        [XmlElement(ElementName = "filename")]
        public object Filename { get; set; }

        [XmlElement(ElementName = "filename32")]
        public object Filename32 { get; set; }

        [XmlElement(ElementName = "filename64")]
        public object Filename64 { get; set; }

        [XmlElement(ElementName = "filename32arm")]
        public object Filename32arm { get; set; }

        [XmlElement(ElementName = "filename64arm")]
        public object Filename64arm { get; set; }

        [XmlElement(ElementName = "uefihttpboot")]
        public object Uefihttpboot { get; set; }

        [XmlElement(ElementName = "rootpath")]
        public object Rootpath { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public object Numberoptions { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }

        [XmlElement(ElementName = "ramode")]
        public string Ramode { get; set; }

        [XmlElement(ElementName = "rapriority")]
        public string Rapriority { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }
    }

    [XmlRoot(ElementName = "opt5")]
    public class Opt5
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }

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

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "failover_peerip")]
        public object FailoverPeerip { get; set; }

        [XmlElement(ElementName = "defaultleasetime")]
        public object Defaultleasetime { get; set; }

        [XmlElement(ElementName = "maxleasetime")]
        public object Maxleasetime { get; set; }

        [XmlElement(ElementName = "netmask")]
        public object Netmask { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "domain")]
        public object Domain { get; set; }

        [XmlElement(ElementName = "domainsearchlist")]
        public object Domainsearchlist { get; set; }

        [XmlElement(ElementName = "ddnsdomain")]
        public object Ddnsdomain { get; set; }

        [XmlElement(ElementName = "ddnsdomainprimary")]
        public object Ddnsdomainprimary { get; set; }

        [XmlElement(ElementName = "ddnsdomainsecondary")]
        public object Ddnsdomainsecondary { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyname")]
        public object Ddnsdomainkeyname { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyalgorithm")]
        public string Ddnsdomainkeyalgorithm { get; set; }

        [XmlElement(ElementName = "ddnsdomainkey")]
        public object Ddnsdomainkey { get; set; }

        [XmlElement(ElementName = "mac_allow")]
        public object MacAllow { get; set; }

        [XmlElement(ElementName = "mac_deny")]
        public object MacDeny { get; set; }

        [XmlElement(ElementName = "ddnsclientupdates")]
        public string Ddnsclientupdates { get; set; }

        [XmlElement(ElementName = "tftp")]
        public object Tftp { get; set; }

        [XmlElement(ElementName = "ldap")]
        public object Ldap { get; set; }

        [XmlElement(ElementName = "nextserver")]
        public object Nextserver { get; set; }

        [XmlElement(ElementName = "filename")]
        public object Filename { get; set; }

        [XmlElement(ElementName = "filename32")]
        public object Filename32 { get; set; }

        [XmlElement(ElementName = "filename64")]
        public object Filename64 { get; set; }

        [XmlElement(ElementName = "filename32arm")]
        public object Filename32arm { get; set; }

        [XmlElement(ElementName = "filename64arm")]
        public object Filename64arm { get; set; }

        [XmlElement(ElementName = "uefihttpboot")]
        public object Uefihttpboot { get; set; }

        [XmlElement(ElementName = "rootpath")]
        public object Rootpath { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public object Numberoptions { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }

        [XmlElement(ElementName = "ramode")]
        public string Ramode { get; set; }

        [XmlElement(ElementName = "rapriority")]
        public string Rapriority { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }
    }

    [XmlRoot(ElementName = "opt6")]
    public class Opt6
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }

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

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "failover_peerip")]
        public object FailoverPeerip { get; set; }

        [XmlElement(ElementName = "defaultleasetime")]
        public object Defaultleasetime { get; set; }

        [XmlElement(ElementName = "maxleasetime")]
        public object Maxleasetime { get; set; }

        [XmlElement(ElementName = "netmask")]
        public object Netmask { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "domain")]
        public object Domain { get; set; }

        [XmlElement(ElementName = "domainsearchlist")]
        public object Domainsearchlist { get; set; }

        [XmlElement(ElementName = "ddnsdomain")]
        public object Ddnsdomain { get; set; }

        [XmlElement(ElementName = "ddnsdomainprimary")]
        public object Ddnsdomainprimary { get; set; }

        [XmlElement(ElementName = "ddnsdomainsecondary")]
        public object Ddnsdomainsecondary { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyname")]
        public object Ddnsdomainkeyname { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyalgorithm")]
        public string Ddnsdomainkeyalgorithm { get; set; }

        [XmlElement(ElementName = "ddnsdomainkey")]
        public object Ddnsdomainkey { get; set; }

        [XmlElement(ElementName = "mac_allow")]
        public object MacAllow { get; set; }

        [XmlElement(ElementName = "mac_deny")]
        public object MacDeny { get; set; }

        [XmlElement(ElementName = "ddnsclientupdates")]
        public string Ddnsclientupdates { get; set; }

        [XmlElement(ElementName = "tftp")]
        public object Tftp { get; set; }

        [XmlElement(ElementName = "ldap")]
        public object Ldap { get; set; }

        [XmlElement(ElementName = "nextserver")]
        public object Nextserver { get; set; }

        [XmlElement(ElementName = "filename")]
        public object Filename { get; set; }

        [XmlElement(ElementName = "filename32")]
        public object Filename32 { get; set; }

        [XmlElement(ElementName = "filename64")]
        public object Filename64 { get; set; }

        [XmlElement(ElementName = "filename32arm")]
        public object Filename32arm { get; set; }

        [XmlElement(ElementName = "filename64arm")]
        public object Filename64arm { get; set; }

        [XmlElement(ElementName = "uefihttpboot")]
        public object Uefihttpboot { get; set; }

        [XmlElement(ElementName = "rootpath")]
        public object Rootpath { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public object Numberoptions { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }

        [XmlElement(ElementName = "ramode")]
        public string Ramode { get; set; }

        [XmlElement(ElementName = "rapriority")]
        public string Rapriority { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }
    }

    [XmlRoot(ElementName = "opt7")]
    public class Opt7
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }

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

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "failover_peerip")]
        public object FailoverPeerip { get; set; }

        [XmlElement(ElementName = "defaultleasetime")]
        public object Defaultleasetime { get; set; }

        [XmlElement(ElementName = "maxleasetime")]
        public object Maxleasetime { get; set; }

        [XmlElement(ElementName = "netmask")]
        public object Netmask { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "domain")]
        public object Domain { get; set; }

        [XmlElement(ElementName = "domainsearchlist")]
        public object Domainsearchlist { get; set; }

        [XmlElement(ElementName = "ddnsdomain")]
        public object Ddnsdomain { get; set; }

        [XmlElement(ElementName = "ddnsdomainprimary")]
        public object Ddnsdomainprimary { get; set; }

        [XmlElement(ElementName = "ddnsdomainsecondary")]
        public object Ddnsdomainsecondary { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyname")]
        public object Ddnsdomainkeyname { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyalgorithm")]
        public string Ddnsdomainkeyalgorithm { get; set; }

        [XmlElement(ElementName = "ddnsdomainkey")]
        public object Ddnsdomainkey { get; set; }

        [XmlElement(ElementName = "mac_allow")]
        public object MacAllow { get; set; }

        [XmlElement(ElementName = "mac_deny")]
        public object MacDeny { get; set; }

        [XmlElement(ElementName = "ddnsclientupdates")]
        public string Ddnsclientupdates { get; set; }

        [XmlElement(ElementName = "tftp")]
        public object Tftp { get; set; }

        [XmlElement(ElementName = "ldap")]
        public object Ldap { get; set; }

        [XmlElement(ElementName = "nextserver")]
        public object Nextserver { get; set; }

        [XmlElement(ElementName = "filename")]
        public object Filename { get; set; }

        [XmlElement(ElementName = "filename32")]
        public object Filename32 { get; set; }

        [XmlElement(ElementName = "filename64")]
        public object Filename64 { get; set; }

        [XmlElement(ElementName = "filename32arm")]
        public object Filename32arm { get; set; }

        [XmlElement(ElementName = "filename64arm")]
        public object Filename64arm { get; set; }

        [XmlElement(ElementName = "uefihttpboot")]
        public object Uefihttpboot { get; set; }

        [XmlElement(ElementName = "rootpath")]
        public object Rootpath { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public object Numberoptions { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }

        [XmlElement(ElementName = "ramode")]
        public string Ramode { get; set; }

        [XmlElement(ElementName = "rapriority")]
        public string Rapriority { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }
    }

    [XmlRoot(ElementName = "opt8")]
    public class Opt8
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }

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

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "failover_peerip")]
        public object FailoverPeerip { get; set; }

        [XmlElement(ElementName = "defaultleasetime")]
        public object Defaultleasetime { get; set; }

        [XmlElement(ElementName = "maxleasetime")]
        public object Maxleasetime { get; set; }

        [XmlElement(ElementName = "netmask")]
        public object Netmask { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "domain")]
        public object Domain { get; set; }

        [XmlElement(ElementName = "domainsearchlist")]
        public object Domainsearchlist { get; set; }

        [XmlElement(ElementName = "ddnsdomain")]
        public object Ddnsdomain { get; set; }

        [XmlElement(ElementName = "ddnsdomainprimary")]
        public object Ddnsdomainprimary { get; set; }

        [XmlElement(ElementName = "ddnsdomainsecondary")]
        public object Ddnsdomainsecondary { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyname")]
        public object Ddnsdomainkeyname { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyalgorithm")]
        public string Ddnsdomainkeyalgorithm { get; set; }

        [XmlElement(ElementName = "ddnsdomainkey")]
        public object Ddnsdomainkey { get; set; }

        [XmlElement(ElementName = "mac_allow")]
        public object MacAllow { get; set; }

        [XmlElement(ElementName = "mac_deny")]
        public object MacDeny { get; set; }

        [XmlElement(ElementName = "ddnsclientupdates")]
        public string Ddnsclientupdates { get; set; }

        [XmlElement(ElementName = "tftp")]
        public object Tftp { get; set; }

        [XmlElement(ElementName = "ldap")]
        public object Ldap { get; set; }

        [XmlElement(ElementName = "nextserver")]
        public object Nextserver { get; set; }

        [XmlElement(ElementName = "filename")]
        public object Filename { get; set; }

        [XmlElement(ElementName = "filename32")]
        public object Filename32 { get; set; }

        [XmlElement(ElementName = "filename64")]
        public object Filename64 { get; set; }

        [XmlElement(ElementName = "filename32arm")]
        public object Filename32arm { get; set; }

        [XmlElement(ElementName = "filename64arm")]
        public object Filename64arm { get; set; }

        [XmlElement(ElementName = "uefihttpboot")]
        public object Uefihttpboot { get; set; }

        [XmlElement(ElementName = "rootpath")]
        public object Rootpath { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public object Numberoptions { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }

        [XmlElement(ElementName = "ramode")]
        public string Ramode { get; set; }

        [XmlElement(ElementName = "rapriority")]
        public string Rapriority { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }
    }

    [XmlRoot(ElementName = "opt9")]
    public class Opt9
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }

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

        [XmlElement(ElementName = "range")]
        public Range Range { get; set; }

        [XmlElement(ElementName = "failover_peerip")]
        public object FailoverPeerip { get; set; }

        [XmlElement(ElementName = "defaultleasetime")]
        public object Defaultleasetime { get; set; }

        [XmlElement(ElementName = "maxleasetime")]
        public object Maxleasetime { get; set; }

        [XmlElement(ElementName = "netmask")]
        public object Netmask { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "domain")]
        public object Domain { get; set; }

        [XmlElement(ElementName = "domainsearchlist")]
        public object Domainsearchlist { get; set; }

        [XmlElement(ElementName = "ddnsdomain")]
        public object Ddnsdomain { get; set; }

        [XmlElement(ElementName = "ddnsdomainprimary")]
        public object Ddnsdomainprimary { get; set; }

        [XmlElement(ElementName = "ddnsdomainsecondary")]
        public object Ddnsdomainsecondary { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyname")]
        public object Ddnsdomainkeyname { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyalgorithm")]
        public string Ddnsdomainkeyalgorithm { get; set; }

        [XmlElement(ElementName = "ddnsdomainkey")]
        public object Ddnsdomainkey { get; set; }

        [XmlElement(ElementName = "mac_allow")]
        public object MacAllow { get; set; }

        [XmlElement(ElementName = "mac_deny")]
        public object MacDeny { get; set; }

        [XmlElement(ElementName = "ddnsclientupdates")]
        public string Ddnsclientupdates { get; set; }

        [XmlElement(ElementName = "tftp")]
        public object Tftp { get; set; }

        [XmlElement(ElementName = "ldap")]
        public object Ldap { get; set; }

        [XmlElement(ElementName = "nextserver")]
        public object Nextserver { get; set; }

        [XmlElement(ElementName = "filename")]
        public object Filename { get; set; }

        [XmlElement(ElementName = "filename32")]
        public object Filename32 { get; set; }

        [XmlElement(ElementName = "filename64")]
        public object Filename64 { get; set; }

        [XmlElement(ElementName = "filename32arm")]
        public object Filename32arm { get; set; }

        [XmlElement(ElementName = "filename64arm")]
        public object Filename64arm { get; set; }

        [XmlElement(ElementName = "uefihttpboot")]
        public object Uefihttpboot { get; set; }

        [XmlElement(ElementName = "rootpath")]
        public object Rootpath { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public object Numberoptions { get; set; }

        [XmlElement(ElementName = "staticmap")]
        public List<Staticmap> Staticmap { get; set; }

        [XmlElement(ElementName = "ramode")]
        public string Ramode { get; set; }

        [XmlElement(ElementName = "rapriority")]
        public string Rapriority { get; set; }

        [XmlElement(ElementName = "dnsserver")]
        public string Dnsserver { get; set; }
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

        [XmlElement(ElementName = "cid")]
        public object Cid { get; set; }

        [XmlElement(ElementName = "ipaddr")]
        public string Ipaddr { get; set; }

        [XmlElement(ElementName = "hostname")]
        public string Hostname { get; set; }

        [XmlElement(ElementName = "descr")]
        public object Descr { get; set; }

        [XmlElement(ElementName = "filename")]
        public object Filename { get; set; }

        [XmlElement(ElementName = "rootpath")]
        public object Rootpath { get; set; }

        [XmlElement(ElementName = "defaultleasetime")]
        public object Defaultleasetime { get; set; }

        [XmlElement(ElementName = "maxleasetime")]
        public object Maxleasetime { get; set; }

        [XmlElement(ElementName = "gateway")]
        public object Gateway { get; set; }

        [XmlElement(ElementName = "domain")]
        public object Domain { get; set; }

        [XmlElement(ElementName = "domainsearchlist")]
        public object Domainsearchlist { get; set; }

        [XmlElement(ElementName = "ddnsdomain")]
        public object Ddnsdomain { get; set; }

        [XmlElement(ElementName = "ddnsdomainprimary")]
        public object Ddnsdomainprimary { get; set; }

        [XmlElement(ElementName = "ddnsdomainsecondary")]
        public object Ddnsdomainsecondary { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyname")]
        public object Ddnsdomainkeyname { get; set; }

        [XmlElement(ElementName = "ddnsdomainkeyalgorithm")]
        public string Ddnsdomainkeyalgorithm { get; set; }

        [XmlElement(ElementName = "ddnsdomainkey")]
        public object Ddnsdomainkey { get; set; }

        [XmlElement(ElementName = "tftp")]
        public object Tftp { get; set; }

        [XmlElement(ElementName = "ldap")]
        public object Ldap { get; set; }

        [XmlElement(ElementName = "nextserver")]
        public object Nextserver { get; set; }

        [XmlElement(ElementName = "filename32")]
        public object Filename32 { get; set; }

        [XmlElement(ElementName = "filename64")]
        public object Filename64 { get; set; }

        [XmlElement(ElementName = "filename32arm")]
        public object Filename32arm { get; set; }

        [XmlElement(ElementName = "filename64arm")]
        public object Filename64arm { get; set; }

        [XmlElement(ElementName = "uefihttpboot")]
        public object Uefihttpboot { get; set; }

        [XmlElement(ElementName = "numberoptions")]
        public object Numberoptions { get; set; }
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

    [XmlRoot(ElementName = "dhcpdv6")]
    public class Dhcpdv6
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

    [XmlRoot(ElementName = "ipv6nat")]
    public class Ipv6nat
    {

        [XmlElement(ElementName = "ipaddr")]
        public object Ipaddr { get; set; }
    }

    [XmlRoot(ElementName = "diag")]
    public class Diag
    {

        [XmlElement(ElementName = "ipv6nat")]
        public Ipv6nat Ipv6nat { get; set; }
    }

    [XmlRoot(ElementName = "syslog")]
    public class Syslog
    {

        [XmlElement(ElementName = "filterdescriptions")]
        public int Filterdescriptions { get; set; }
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
        public object Any { get; set; }

        [XmlElement(ElementName = "network")]
        public string Network { get; set; }
    }

    [XmlRoot(ElementName = "destination")]
    public class Destination
    {

        [XmlElement(ElementName = "network")]
        public string Network { get; set; }

        [XmlElement(ElementName = "port")]
        public string Port { get; set; }

        [XmlElement(ElementName = "any")]
        public object Any { get; set; }

        [XmlElement(ElementName = "address")]
        public string Address { get; set; }
    }

    [XmlRoot(ElementName = "updated")]
    public class Updated
    {

        [XmlElement(ElementName = "time")]
        public int Time { get; set; }

        [XmlElement(ElementName = "username")]
        public string Username { get; set; }
    }

    [XmlRoot(ElementName = "created")]
    public class Created
    {

        [XmlElement(ElementName = "time")]
        public int Time { get; set; }

        [XmlElement(ElementName = "username")]
        public string Username { get; set; }
    }

    [XmlRoot(ElementName = "rule")]
    public class Rule
    {

        [XmlElement(ElementName = "source")]
        public Source Source { get; set; }

        [XmlElement(ElementName = "destination")]
        public Destination Destination { get; set; }

        [XmlElement(ElementName = "ipprotocol")]
        public string Ipprotocol { get; set; }

        [XmlElement(ElementName = "protocol")]
        public string Protocol { get; set; }

        [XmlElement(ElementName = "target")]
        public string Target { get; set; }

        [XmlElement(ElementName = "local-port")]
        public string Localport { get; set; }

        [XmlElement(ElementName = "interface")]
        public string Interface { get; set; }

        [XmlElement(ElementName = "descr")]
        public string Descr { get; set; }

        [XmlElement(ElementName = "associated-rule-id")]
        public string Associatedruleid { get; set; }

        [XmlElement(ElementName = "updated")]
        public Updated Updated { get; set; }

        [XmlElement(ElementName = "created")]
        public Created Created { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "tracker")]
        public int Tracker { get; set; }
    }

    [XmlRoot(ElementName = "nat")]
    public class Nat
    {

        [XmlElement(ElementName = "outbound")]
        public Outbound Outbound { get; set; }

        [XmlElement(ElementName = "separator")]
        public object Separator { get; set; }

        [XmlElement(ElementName = "rule")]
        public List<Rule> Rule { get; set; }
    }

    [XmlRoot(ElementName = "filter")]
    public class Filter
    {

        [XmlElement(ElementName = "rule")]
        public List<Rule> Rule { get; set; }
    }

    [XmlRoot(ElementName = "ipsec")]
    public class Ipsec
    {

        [XmlElement(ElementName = "client")]
        public object Client { get; set; }
    }

    [XmlRoot(ElementName = "item")]
    public class Item
    {

        [XmlElement(ElementName = "minute")]
        public string Minute { get; set; }

        [XmlElement(ElementName = "hour")]
        public string Hour { get; set; }

        [XmlElement(ElementName = "mday")]
        public string Mday { get; set; }

        [XmlElement(ElementName = "month")]
        public string Month { get; set; }

        [XmlElement(ElementName = "wday")]
        public string Wday { get; set; }

        [XmlElement(ElementName = "who")]
        public string Who { get; set; }

        [XmlElement(ElementName = "command")]
        public string Command { get; set; }
    }

    [XmlRoot(ElementName = "cron")]
    public class Cron
    {

        [XmlElement(ElementName = "item")]
        public List<Item> Item { get; set; }
    }

    [XmlRoot(ElementName = "rrd")]
    public class Rrd
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }
    }

    [XmlRoot(ElementName = "widgets")]
    public class Widgets
    {

        [XmlElement(ElementName = "sequence")]
        public string Sequence { get; set; }

        [XmlElement(ElementName = "period")]
        public int Period { get; set; }
    }

    [XmlRoot(ElementName = "unbound")]
    public class Unbound
    {

        [XmlElement(ElementName = "enable")]
        public object Enable { get; set; }

        [XmlElement(ElementName = "dnssec")]
        public object Dnssec { get; set; }

        [XmlElement(ElementName = "active_interface")]
        public object ActiveInterface { get; set; }

        [XmlElement(ElementName = "outgoing_interface")]
        public object OutgoingInterface { get; set; }

        [XmlElement(ElementName = "custom_options")]
        public object CustomOptions { get; set; }

        [XmlElement(ElementName = "hideidentity")]
        public object Hideidentity { get; set; }

        [XmlElement(ElementName = "hideversion")]
        public object Hideversion { get; set; }

        [XmlElement(ElementName = "dnssecstripped")]
        public object Dnssecstripped { get; set; }
    }

    [XmlRoot(ElementName = "revision")]
    public class Revision
    {

        [XmlElement(ElementName = "time")]
        public int Time { get; set; }

        [XmlElement(ElementName = "description")]
        public string Description { get; set; }

        [XmlElement(ElementName = "username")]
        public string Username { get; set; }
    }

    [XmlRoot(ElementName = "ntpd")]
    public class Ntpd
    {

        [XmlElement(ElementName = "gps")]
        public object Gps { get; set; }
    }

    [XmlRoot(ElementName = "cert")]
    public class Cert
    {

        [XmlElement(ElementName = "refid")]
        public string Refid { get; set; }

        [XmlElement(ElementName = "descr")]
        public string Descr { get; set; }

        [XmlElement(ElementName = "type")]
        public string Type { get; set; }

        [XmlElement(ElementName = "crt")]
        public string Crt { get; set; }

        [XmlElement(ElementName = "prv")]
        public string Prv { get; set; }
    }

    [XmlRoot(ElementName = "pfsense")]
    public class Pfsense
    {

        [XmlElement(ElementName = "version")]
        public double Version { get; set; }

        [XmlElement(ElementName = "lastchange")]
        public object Lastchange { get; set; }

        [XmlElement(ElementName = "system")]
        public System System { get; set; }

        [XmlElement(ElementName = "interfaces")]
        public Interfaces Interfaces { get; set; }

        [XmlElement(ElementName = "staticroutes")]
        public object Staticroutes { get; set; }

        [XmlElement(ElementName = "dhcpd")]
        public Dhcpd Dhcpd { get; set; }

        [XmlElement(ElementName = "dhcpdv6")]
        public Dhcpdv6 Dhcpdv6 { get; set; }

        [XmlElement(ElementName = "snmpd")]
        public Snmpd Snmpd { get; set; }

        [XmlElement(ElementName = "diag")]
        public Diag Diag { get; set; }

        [XmlElement(ElementName = "syslog")]
        public Syslog Syslog { get; set; }

        [XmlElement(ElementName = "nat")]
        public Nat Nat { get; set; }

        [XmlElement(ElementName = "filter")]
        public Filter Filter { get; set; }

        [XmlElement(ElementName = "shaper")]
        public object Shaper { get; set; }

        [XmlElement(ElementName = "ipsec")]
        public Ipsec Ipsec { get; set; }

        [XmlElement(ElementName = "aliases")]
        public object Aliases { get; set; }

        [XmlElement(ElementName = "proxyarp")]
        public object Proxyarp { get; set; }

        [XmlElement(ElementName = "cron")]
        public Cron Cron { get; set; }

        [XmlElement(ElementName = "wol")]
        public object Wol { get; set; }

        [XmlElement(ElementName = "rrd")]
        public Rrd Rrd { get; set; }

        [XmlElement(ElementName = "widgets")]
        public Widgets Widgets { get; set; }

        [XmlElement(ElementName = "openvpn")]
        public object Openvpn { get; set; }

        [XmlElement(ElementName = "dnshaper")]
        public object Dnshaper { get; set; }

        [XmlElement(ElementName = "unbound")]
        public Unbound Unbound { get; set; }

        [XmlElement(ElementName = "vlans")]
        public object Vlans { get; set; }

        [XmlElement(ElementName = "qinqs")]
        public object Qinqs { get; set; }

        [XmlElement(ElementName = "revision")]
        public Revision Revision { get; set; }

        [XmlElement(ElementName = "gateways")]
        public object Gateways { get; set; }

        [XmlElement(ElementName = "captiveportal")]
        public object Captiveportal { get; set; }

        [XmlElement(ElementName = "dnsmasq")]
        public object Dnsmasq { get; set; }

        [XmlElement(ElementName = "ntpd")]
        public Ntpd Ntpd { get; set; }

        [XmlElement(ElementName = "cert")]
        public Cert Cert { get; set; }

        [XmlElement(ElementName = "ppps")]
        public object Ppps { get; set; }
    }
}