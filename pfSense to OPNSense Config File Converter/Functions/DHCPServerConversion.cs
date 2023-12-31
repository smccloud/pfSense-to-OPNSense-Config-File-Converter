namespace Functions
{
    public static class DHCPServerConversion
    {
        /// <summary>
        /// Entrypoint for the entire class
        /// </summary>
        /// <param name="pfSense">Input pfSense DHCPD object</param>
        /// <returns>OPNSense DHCPD Object</returns>
        public static OPNSenseConfig.Dhcpd ConvertAll(pfSenseConfig.Dhcpd pfSense, string lanIP, string opt1IP, string opt2IP, string opt3IP, string opt4IP, string opt5IP, string opt6IP, string opt7IP, string opt8IP, string opt9IP)
        {
            OPNSenseConfig.Dhcpd retval = new OPNSenseConfig.Dhcpd();
            if (pfSense.Lan != null) retval.Lan = LAN(pfSense, lanIP).Lan;
            if (pfSense.Opt1 != null) retval.Opt1 = OPT1(pfSense, opt1IP).Opt1;
            if (pfSense.Opt2 != null) retval.Opt2 = OPT2(pfSense, opt2IP).Opt2;
            if (pfSense.Opt3 != null) retval.Opt3 = OPT3(pfSense, opt3IP).Opt3;
            if (pfSense.Opt4 != null) retval.Opt4 = OPT4(pfSense, opt4IP).Opt4;
            if (pfSense.Opt5 != null) retval.Opt5 = OPT5(pfSense, opt5IP).Opt5;
            if (pfSense.Opt6 != null) retval.Opt6 = OPT6(pfSense, opt6IP).Opt6;
            if (pfSense.Opt7 != null) retval.Opt7 = OPT7(pfSense, opt7IP).Opt7;
            if (pfSense.Opt8 != null) retval.Opt8 = OPT8(pfSense, opt8IP).Opt8;
            if (pfSense.Opt9 != null) retval.Opt9 = OPT9(pfSense, opt9IP).Opt9;
            return retval;
        }

        /// <summary>
        /// Converts the LAN DHCPD server from pfSense to OPNSense
        /// </summary>
        /// <param name="lan">pfSense LAN DHCPD server</param>
        /// <returns>OPNSense LAN DHCPD server</returns>
        private static OPNSenseConfig.Dhcpd LAN(pfSenseConfig.Dhcpd lan, string IP)
        {
            OPNSenseConfig.Dhcpd retval = new OPNSenseConfig.Dhcpd();
            retval.Lan = new OPNSenseConfig.Lan();
            retval.Lan.Enable = 1;
            retval.Lan.Range = new OPNSenseConfig.Range();
            retval.Lan.Range.From = lan.Lan.Range.From;
            retval.Lan.Range.To = lan.Lan.Range.To;
            if (lan.Lan.Dnsserver == null || lan.Lan.Dnsserver == string.Empty) retval.Lan.Dnsserver = IP;
            else retval.Lan.Dnsserver = lan.Lan.Dnsserver;
            if (lan.Lan.Staticmap != null)
            {
                retval.Lan.Staticmap = new List<OPNSenseConfig.Staticmap>();
                foreach (var item in lan.Lan.Staticmap)
                {
                    OPNSenseConfig.Staticmap temp = new OPNSenseConfig.Staticmap();
                    temp.Mac = item.Mac;
                    temp.Ipaddr = item.Ipaddr;
                    temp.Hostname = item.Hostname;
                    retval.Lan.Staticmap.Add(temp);
                }
            }
            return retval;
        }

        /// <summary>
        /// Converts the OPT1 DHCPD server from pfSense to OPNSense
        /// </summary>
        /// <param name="opt1">pfSense OPT1 DHCPD server</param>
        /// <returns>OPNSense OPT1 DHCPD server</returns>
        private static OPNSenseConfig.Dhcpd OPT1(pfSenseConfig.Dhcpd opt1, string IP)
        {
            OPNSenseConfig.Dhcpd retval = new OPNSenseConfig.Dhcpd();
            retval.Opt1 = new OPNSenseConfig.Opt1();
            retval.Opt1.Enable = 1;
            retval.Opt1.Range = new OPNSenseConfig.Range();
            retval.Opt1.Range.From = opt1.Opt1.Range.From;
            retval.Opt1.Range.To = opt1.Opt1.Range.To;
            if (opt1.Opt1.Dnsserver == null || opt1.Opt1.Dnsserver == string.Empty) retval.Opt1.Dnsserver = IP;
            else retval.Opt1.Dnsserver = opt1.Opt1.Dnsserver;
            if (opt1.Opt1.Staticmap != null)
            {
                retval.Opt1.Staticmap = new List<OPNSenseConfig.Staticmap>();
                foreach (var item in opt1.Opt1.Staticmap)
                {
                    OPNSenseConfig.Staticmap temp = new OPNSenseConfig.Staticmap();
                    temp.Mac = item.Mac;
                    temp.Ipaddr = item.Ipaddr;
                    temp.Hostname = item.Hostname;
                    retval.Opt1.Staticmap.Add(temp);
                }
            }
            return retval;
        }

        /// <summary>
        /// Converts the OPT2 DHCPD server from pfSense to OPNSense
        /// </summary>
        /// <param name="opt2">pfSense OPT2 DHCPD server</param>
        /// <returns>OPNSense OPT2 DHCPD server</returns>
        private static OPNSenseConfig.Dhcpd OPT2(pfSenseConfig.Dhcpd opt2, string IP)
        {
            OPNSenseConfig.Dhcpd retval = new OPNSenseConfig.Dhcpd();
            retval.Opt2 = new OPNSenseConfig.Opt2();
            retval.Opt2.Enable = 1;
            retval.Opt2.Range = new OPNSenseConfig.Range();
            retval.Opt2.Range.From = opt2.Opt2.Range.From;
            retval.Opt2.Range.To = opt2.Opt2.Range.To;
            if (opt2.Opt2.Dnsserver == null || opt2.Opt2.Dnsserver == string.Empty) retval.Opt2.Dnsserver = IP;
            else retval.Opt2.Dnsserver = opt2.Opt2.Dnsserver;
            if (opt2.Opt2.Staticmap != null)
            {
                retval.Opt2.Staticmap = new List<OPNSenseConfig.Staticmap>();
                foreach (var item in opt2.Opt2.Staticmap)
                {
                    OPNSenseConfig.Staticmap temp = new OPNSenseConfig.Staticmap();
                    temp.Mac = item.Mac;
                    temp.Ipaddr = item.Ipaddr;
                    temp.Hostname = item.Hostname;
                    retval.Opt2.Staticmap.Add(temp);
                }
            }
            return retval;
        }

        /// <summary>
        /// Converts the OPT3 DHCPD server from pfSense to OPNSense
        /// </summary>
        /// <param name="opt3">pfSense OPT3 DHCPD server</param>
        /// <returns>OPNSense OPT3 DHCPD server</returns>
        private static OPNSenseConfig.Dhcpd OPT3(pfSenseConfig.Dhcpd opt3, string IP)
        {
            OPNSenseConfig.Dhcpd retval = new OPNSenseConfig.Dhcpd();
            retval.Opt3 = new OPNSenseConfig.Opt3();
            retval.Opt3.Enable = 1;
            retval.Opt3.Range = new OPNSenseConfig.Range();
            retval.Opt3.Range.From = opt3.Opt3.Range.From;
            retval.Opt3.Range.To = opt3.Opt3.Range.To;
            if (opt3.Opt3.Dnsserver == null || opt3.Opt3.Dnsserver == string.Empty) retval.Opt3.Dnsserver = IP;
            else retval.Opt3.Dnsserver = opt3.Opt3.Dnsserver;
            if (opt3.Opt3.Staticmap != null)
            {
                retval.Opt3.Staticmap = new List<OPNSenseConfig.Staticmap>();
                foreach (var item in opt3.Opt3.Staticmap)
                {
                    OPNSenseConfig.Staticmap temp = new OPNSenseConfig.Staticmap();
                    temp.Mac = item.Mac;
                    temp.Ipaddr = item.Ipaddr;
                    temp.Hostname = item.Hostname;
                    retval.Opt3.Staticmap.Add(temp);
                }
            }
            return retval;
        }

        /// <summary>
        /// Converts the OPT4 DHCPD server from pfSense to OPNSense
        /// </summary>
        /// <param name="opt4">pfSense OPT4 DHCPD server</param>
        /// <returns>OPNSense OPT4 DHCPD server</returns>
        private static OPNSenseConfig.Dhcpd OPT4(pfSenseConfig.Dhcpd opt4, string IP)
        {
            OPNSenseConfig.Dhcpd retval = new OPNSenseConfig.Dhcpd();
            retval.Opt4 = new OPNSenseConfig.Opt4();
            retval.Opt4.Enable = 1;
            retval.Opt4.Range = new OPNSenseConfig.Range();
            retval.Opt4.Range.From = opt4.Opt4.Range.From;
            retval.Opt4.Range.To = opt4.Opt4.Range.To;
            if (opt4.Opt4.Dnsserver == null || opt4.Opt4.Dnsserver == string.Empty) retval.Opt4.Dnsserver = IP;
            else retval.Opt4.Dnsserver = opt4.Opt4.Dnsserver;
            if (opt4.Opt4.Staticmap != null)
            {
                retval.Opt4.Staticmap = new List<OPNSenseConfig.Staticmap>();
                foreach (var item in opt4.Opt4.Staticmap)
                {
                    OPNSenseConfig.Staticmap temp = new OPNSenseConfig.Staticmap();
                    temp.Mac = item.Mac;
                    temp.Ipaddr = item.Ipaddr;
                    temp.Hostname = item.Hostname;
                    retval.Opt4.Staticmap.Add(temp);
                }
            }
            return retval;
        }

        /// <summary>
        /// Converts the OPT5 DHCPD server from pfSense to OPNSense
        /// </summary>
        /// <param name="opt5">pfSense OPT5 DHCPD server</param>
        /// <returns>OPNSense OPT5 DHCPD server</returns>
        private static OPNSenseConfig.Dhcpd OPT5(pfSenseConfig.Dhcpd opt5, string IP)
        {
            OPNSenseConfig.Dhcpd retval = new OPNSenseConfig.Dhcpd();
            retval.Opt5 = new OPNSenseConfig.Opt5();
            retval.Opt5.Enable = 1;
            retval.Opt5.Range = new OPNSenseConfig.Range();
            retval.Opt5.Range.From = opt5.Opt5.Range.From;
            retval.Opt5.Range.To = opt5.Opt5.Range.To;
            if (opt5.Opt5.Dnsserver == null || opt5.Opt5.Dnsserver == string.Empty) retval.Opt5.Dnsserver = IP;
            else retval.Opt5.Dnsserver = opt5.Opt5.Dnsserver;
            if (opt5.Opt5.Staticmap != null)
            {
                retval.Opt5.Staticmap = new List<OPNSenseConfig.Staticmap>();
                foreach (var item in opt5.Opt5.Staticmap)
                {
                    OPNSenseConfig.Staticmap temp = new OPNSenseConfig.Staticmap();
                    temp.Mac = item.Mac;
                    temp.Ipaddr = item.Ipaddr;
                    temp.Hostname = item.Hostname;
                    retval.Opt5.Staticmap.Add(temp);
                }
            }
            return retval;
        }

        /// <summary>
        /// Converts the OPT6 DHCPD server from pfSense to OPNSense
        /// </summary>
        /// <param name="opt6">pfSense OPT6 DHCPD server</param>
        /// <returns>OPNSense OPT6 DHCPD server</returns>
        private static OPNSenseConfig.Dhcpd OPT6(pfSenseConfig.Dhcpd opt6, string IP)
        {
            OPNSenseConfig.Dhcpd retval = new OPNSenseConfig.Dhcpd();
            retval.Opt6 = new OPNSenseConfig.Opt6();
            retval.Opt6.Enable = 1;
            retval.Opt6.Range = new OPNSenseConfig.Range();
            retval.Opt6.Range.From = opt6.Opt6.Range.From;
            retval.Opt6.Range.To = opt6.Opt6.Range.To;
            if (opt6.Opt6.Dnsserver == null || opt6.Opt6.Dnsserver == string.Empty) retval.Opt6.Dnsserver = IP;
            else retval.Opt6.Dnsserver = opt6.Opt6.Dnsserver;
            if (opt6.Opt6.Staticmap != null)
            {
                retval.Opt6.Staticmap = new List<OPNSenseConfig.Staticmap>();
                foreach (var item in opt6.Opt6.Staticmap)
                {
                    OPNSenseConfig.Staticmap temp = new OPNSenseConfig.Staticmap();
                    temp.Mac = item.Mac;
                    temp.Ipaddr = item.Ipaddr;
                    temp.Hostname = item.Hostname;
                    retval.Opt6.Staticmap.Add(temp);
                }
            }
            return retval;
        }

        /// <summary>
        /// Converts the OPT7 DHCPD server from pfSense to OPNSense
        /// </summary>
        /// <param name="opt7">pfSense OPT7 DHCPD server</param>
        /// <returns>OPNSense OPT7 DHCPD server</returns>
        private static OPNSenseConfig.Dhcpd OPT7(pfSenseConfig.Dhcpd opt7, string IP)
        {
            OPNSenseConfig.Dhcpd retval = new OPNSenseConfig.Dhcpd();
            retval.Opt7 = new OPNSenseConfig.Opt7();
            retval.Opt7.Enable = 1;
            retval.Opt7.Range = new OPNSenseConfig.Range();
            retval.Opt7.Range.From = opt7.Opt7.Range.From;
            retval.Opt7.Range.To = opt7.Opt7.Range.To;
            if (opt7.Opt7.Dnsserver == null || opt7.Opt7.Dnsserver == string.Empty) retval.Opt7.Dnsserver = IP;
            else retval.Opt7.Dnsserver = opt7.Opt7.Dnsserver;
            if (opt7.Opt7.Staticmap != null)
            {
                retval.Opt7.Staticmap = new List<OPNSenseConfig.Staticmap>();
                foreach (var item in opt7.Opt7.Staticmap)
                {
                    OPNSenseConfig.Staticmap temp = new OPNSenseConfig.Staticmap();
                    temp.Mac = item.Mac;
                    temp.Ipaddr = item.Ipaddr;
                    temp.Hostname = item.Hostname;
                    retval.Opt7.Staticmap.Add(temp);
                }
            }
            return retval;
        }

        /// <summary>
        /// Converts the OPT8 DHCPD server from pfSense to OPNSense
        /// </summary>
        /// <param name="opt8">pfSense OPT8 DHCPD server</param>
        /// <returns>OPNSense OPT8 DHCPD server</returns>
        private static OPNSenseConfig.Dhcpd OPT8(pfSenseConfig.Dhcpd opt8, string IP)
        {
            OPNSenseConfig.Dhcpd retval = new OPNSenseConfig.Dhcpd();
            retval.Opt8 = new OPNSenseConfig.Opt8();
            retval.Opt8.Enable = 1;
            retval.Opt8.Range = new OPNSenseConfig.Range();
            retval.Opt8.Range.From = opt8.Opt8.Range.From;
            retval.Opt8.Range.To = opt8.Opt8.Range.To;
            if (opt8.Opt8.Dnsserver == null || opt8.Opt8.Dnsserver == string.Empty) retval.Opt8.Dnsserver = IP;
            else retval.Opt8.Dnsserver = opt8.Opt8.Dnsserver;
            if (opt8.Opt8.Staticmap != null)
            {
                retval.Opt8.Staticmap = new List<OPNSenseConfig.Staticmap>();
                foreach (var item in opt8.Opt8.Staticmap)
                {
                    OPNSenseConfig.Staticmap temp = new OPNSenseConfig.Staticmap();
                    temp.Mac = item.Mac;
                    temp.Ipaddr = item.Ipaddr;
                    temp.Hostname = item.Hostname;
                    retval.Opt8.Staticmap.Add(temp);
                }
            }
            return retval;
        }

        /// <summary>
        /// Converts the OPT9 DHCPD server from pfSense to OPNSense
        /// </summary>
        /// <param name="opt9">pfSense OPT9 DHCPD server</param>
        /// <returns>OPNSense OPT9 DHCPD server</returns>
        private static OPNSenseConfig.Dhcpd OPT9(pfSenseConfig.Dhcpd opt9, string IP)
        {
            OPNSenseConfig.Dhcpd retval = new OPNSenseConfig.Dhcpd();
            retval.Opt9 = new OPNSenseConfig.Opt9();
            retval.Opt9.Enable = 1;
            retval.Opt9.Range = new OPNSenseConfig.Range();
            retval.Opt9.Range.From = opt9.Opt9.Range.From;
            retval.Opt9.Range.To = opt9.Opt9.Range.To;
            if (opt9.Opt9.Dnsserver == null || opt9.Opt9.Dnsserver == string.Empty) retval.Opt9.Dnsserver = IP;
            else retval.Opt9.Dnsserver = opt9.Opt9.Dnsserver;
            if (opt9.Opt9.Staticmap != null)
            {
                retval.Opt9.Staticmap = new List<OPNSenseConfig.Staticmap>();
                foreach (var item in opt9.Opt9.Staticmap)
                {
                    OPNSenseConfig.Staticmap temp = new OPNSenseConfig.Staticmap();
                    temp.Mac = item.Mac;
                    temp.Ipaddr = item.Ipaddr;
                    temp.Hostname = item.Hostname;
                    retval.Opt9.Staticmap.Add(temp);
                }
            }
            return retval;
        }
    }
}