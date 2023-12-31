namespace Functions
{
    public class InterfaceConversion
    {
        /// <summary>
        /// Entrypoint for the entire class
        /// </summary>
        /// <param name="pfSense">pfSense Interface object</param>
        /// <returns>OPNSense interface object</returns>
        public static OPNSenseConfig.Interfaces ConvertAll(pfSenseConfig.Interfaces pfSense)
        {
            OPNSenseConfig.Interfaces retVal = new OPNSenseConfig.Interfaces();
            if (pfSense.Wan != null) retVal.Wan = WAN(pfSense.Wan);
            if (pfSense.Lan != null) retVal.Lan = LAN(pfSense.Lan);
            if (pfSense.Opt1 != null) retVal.Opt1 = OPT1(pfSense.Opt1);
            if (pfSense.Opt2 != null) retVal.Opt2 = OPT2(pfSense.Opt2);
            if (pfSense.Opt3 != null) retVal.Opt3 = OPT3(pfSense.Opt3);
            if (pfSense.Opt4 != null) retVal.Opt4 = OPT4(pfSense.Opt4);
            if (pfSense.Opt5 != null) retVal.Opt5 = OPT5(pfSense.Opt5);
            if (pfSense.Opt6 != null) retVal.Opt6 = OPT6(pfSense.Opt6);
            if (pfSense.Opt7 != null) retVal.Opt7 = OPT7(pfSense.Opt7);
            if (pfSense.Opt8 != null) retVal.Opt8 = OPT8(pfSense.Opt8);
            if (pfSense.Opt9 != null) retVal.Opt9 = OPT9(pfSense.Opt9);
            return retVal;
        }

        /// <summary>
        /// Convert from a pfSense WAN settings class to an OPNSense WAN settings class
        /// </summary>
        /// <param name="wan">Input pfSense WAN settings class</param>
        /// <returns>OPNSense WAN settings class</returns>
        private static OPNSenseConfig.Wan WAN(pfSenseConfig.Wan wan)
        {
            Console.WriteLine("Converting WAN interface");
            OPNSenseConfig.Wan retVal = new OPNSenseConfig.Wan();
            retVal.If = wan.If;
            retVal.Ipaddr = wan.Ipaddr;
            retVal.Ipaddrv6 = wan.Ipaddrv6;
            retVal.Dhcp6iapdlen = wan.Dhcp6iapdlen;
            try { retVal.Enable = (int)wan.Enable; }
            catch { retVal.Enable = 1; }
            try { retVal.Blockbogons = Convert.ToInt16(wan.Blockbogons); }
            catch { retVal.Blockbogons = 1; }
            return retVal;
        }

        /// <summary>
        /// Convert from a pfSense LAN settings class to an OPNSense LAN settings class
        /// </summary>
        /// <param name="lan">Input pfSense LAN settings class</param>
        /// <returns>OPNSense LAN settings class</returns>
        private static OPNSenseConfig.Lan LAN(pfSenseConfig.Lan lan)
        {
            Console.WriteLine("Converting LAN interface");
            OPNSenseConfig.Lan retVal = new OPNSenseConfig.Lan();
            retVal.If = lan.If;
            retVal.Ipaddr = lan.Ipaddr;
            retVal.Subnet = lan.Subnet;
            retVal.Ipaddrv6 = lan.Ipaddrv6;
            retVal.Track6interface = lan.Track6interface;
            retVal.Track6prefixid = lan.Track6prefixid;
            try { retVal.Enable = (int)lan.Enable; }
            catch { retVal.Enable = 1; }
            retVal.Subnetv6 = 64; // pfSense does not have this.  User can change it later.
            return retVal;
        }

        /// <summary>
        /// Convert from a pfSense OPT1 settings class to an OPNSense OPT1 settings class
        /// </summary>
        /// <param name="opt1">Input pfSense OPT1 settings class</param>
        /// <returns>OPNSense OPT1 settings class</returns>
        private static OPNSenseConfig.Opt1 OPT1(pfSenseConfig.Opt1 opt1)
        {
            Console.WriteLine("Converting OPT1 interface");
            OPNSenseConfig.Opt1 retVal = new OPNSenseConfig.Opt1();
            retVal.If = opt1.If;
            retVal.Ipaddr = opt1.Ipaddr;
            retVal.Subnet = opt1.Subnet;
            retVal.Ipaddrv6 = opt1.Ipaddrv6;
            retVal.Track6interface = opt1.Track6interface;
            retVal.Track6prefixid = opt1.Track6prefixid;
            try { retVal.Enable = (int)opt1.Enable; }
            catch { retVal.Enable = 1; }
            retVal.Subnetv6 = 64; // pfSense does not have this.  User can change it later.
            return retVal;
        }

        /// <summary>
        /// Convert from a pfSense OPT2 settings class to an OPNSense OPT2 settings class
        /// </summary>
        /// <param name="opt2">Input pfSense OPT2 settings class</param>
        /// <returns>OPNSense OPT2 settings class</returns>
        private static OPNSenseConfig.Opt2 OPT2(pfSenseConfig.Opt2 opt2)
        {
            Console.WriteLine("Converting OPT2 interface");
            OPNSenseConfig.Opt2 retVal = new OPNSenseConfig.Opt2();
            retVal.If = opt2.If;
            retVal.Ipaddr = opt2.Ipaddr;
            retVal.Subnet = opt2.Subnet;
            retVal.Ipaddrv6 = opt2.Ipaddrv6;
            retVal.Track6interface = opt2.Track6interface;
            retVal.Track6prefixid = opt2.Track6prefixid;
            try { retVal.Enable = (int)opt2.Enable; }
            catch { retVal.Enable = 1; }
            retVal.Subnetv6 = 64; // pfSense does not have this.  User can change it later.
            return retVal;
        }

        /// <summary>
        /// Convert from a pfSense OPT3 settings class to an OPNSense OPT3 settings class
        /// </summary>
        /// <param name="opt3">Input pfSense OPT3 settings class</param>
        /// <returns>OPNSense OPT3 settings class</returns>
        private static OPNSenseConfig.Opt3 OPT3(pfSenseConfig.Opt3 opt3)
        {
            Console.WriteLine("Converting OPT3 interface");
            OPNSenseConfig.Opt3 retVal = new OPNSenseConfig.Opt3();
            retVal.If = opt3.If;
            retVal.Ipaddr = opt3.Ipaddr;
            retVal.Subnet = opt3.Subnet;
            retVal.Ipaddrv6 = opt3.Ipaddrv6;
            retVal.Track6interface = opt3.Track6interface;
            retVal.Track6prefixid = opt3.Track6prefixid;
            try { retVal.Enable = (int)opt3.Enable; }
            catch { retVal.Enable = 1; }
            retVal.Subnetv6 = 64; // pfSense does not have this.  User can change it later.
            return retVal;
        }

        /// <summary>
        /// Convert from a pfSense OPT4 settings class to an OPNSense OPT4 settings class
        /// </summary>
        /// <param name="opt4">Input pfSense OPT4 settings class</param>
        /// <returns>OPNSense OPT4 settings class</returns>
        private static OPNSenseConfig.Opt4 OPT4(pfSenseConfig.Opt4 opt4)
        {
            Console.WriteLine("Converting OPT4 interface");
            OPNSenseConfig.Opt4 retVal = new OPNSenseConfig.Opt4();
            retVal.If = opt4.If;
            retVal.Ipaddr = opt4.Ipaddr;
            retVal.Subnet = opt4.Subnet;
            retVal.Ipaddrv6 = opt4.Ipaddrv6;
            retVal.Track6interface = opt4.Track6interface;
            retVal.Track6prefixid = opt4.Track6prefixid;
            try { retVal.Enable = (int)opt4.Enable; }
            catch { retVal.Enable = 1; }
            retVal.Subnetv6 = 64; // pfSense does not have this.  User can change it later.
            return retVal;
        }

        /// <summary>
        /// Convert from a pfSense OPT5 settings class to an OPNSense OPT5 settings class
        /// </summary>
        /// <param name="opt5">Input pfSense OPT5 settings class</param>
        /// <returns>OPNSense OPT5 settings class</returns>
        private static OPNSenseConfig.Opt5 OPT5(pfSenseConfig.Opt5 opt5)
        {
            Console.WriteLine("Converting OPT5 interface");
            OPNSenseConfig.Opt5 retVal = new OPNSenseConfig.Opt5();
            retVal.If = opt5.If;
            retVal.Ipaddr = opt5.Ipaddr;
            retVal.Subnet = opt5.Subnet;
            retVal.Ipaddrv6 = opt5.Ipaddrv6;
            retVal.Track6interface = opt5.Track6interface;
            retVal.Track6prefixid = opt5.Track6prefixid;
            try { retVal.Enable = (int)opt5.Enable; }
            catch { retVal.Enable = 1; }
            retVal.Subnetv6 = 64; // pfSense does not have this.  User can change it later.
            return retVal;
        }

        /// <summary>
        /// Convert from a pfSense OPT6 settings class to an OPNSense OPT6 settings class
        /// </summary>
        /// <param name="opt6">Input pfSense OPT6 settings class</param>
        /// <returns>OPNSense OPT6 settings class</returns>
        private static OPNSenseConfig.Opt6 OPT6(pfSenseConfig.Opt6 opt6)
        {
            Console.WriteLine("Converting OPT6 interface");
            OPNSenseConfig.Opt6 retVal = new OPNSenseConfig.Opt6();
            retVal.If = opt6.If;
            retVal.Ipaddr = opt6.Ipaddr;
            retVal.Subnet = opt6.Subnet;
            retVal.Ipaddrv6 = opt6.Ipaddrv6;
            retVal.Track6interface = opt6.Track6interface;
            retVal.Track6prefixid = opt6.Track6prefixid;
            try { retVal.Enable = (int)opt6.Enable; }
            catch { retVal.Enable = 1; }
            retVal.Subnetv6 = 64; // pfSense does not have this.  User can change it later.
            return retVal;
        }

        /// <summary>
        /// Convert from a pfSense OPT7 settings class to an OPNSense OPT7 settings class
        /// </summary>
        /// <param name="opt7">Input pfSense OPT7 settings class</param>
        /// <returns>OPNSense OPT7 settings class</returns>
        private static OPNSenseConfig.Opt7 OPT7(pfSenseConfig.Opt7 opt7)
        {
            Console.WriteLine("Converting OPT7 interface");
            OPNSenseConfig.Opt7 retVal = new OPNSenseConfig.Opt7();
            retVal.If = opt7.If;
            retVal.Ipaddr = opt7.Ipaddr;
            retVal.Subnet = opt7.Subnet;
            retVal.Ipaddrv6 = opt7.Ipaddrv6;
            retVal.Track6interface = opt7.Track6interface;
            retVal.Track6prefixid = opt7.Track6prefixid;
            try { retVal.Enable = (int)opt7.Enable; }
            catch { retVal.Enable = 1; }
            retVal.Subnetv6 = 64; // pfSense does not have this.  User can change it later.
            return retVal;
        }

        /// <summary>
        /// Convert from a pfSense OPT8 settings class to an OPNSense OPT8 settings class
        /// </summary>
        /// <param name="opt8">Input pfSense OPT8 settings class</param>
        /// <returns>OPNSense OPT8 settings class</returns>
        private static OPNSenseConfig.Opt8 OPT8(pfSenseConfig.Opt8 opt8)
        {
            Console.WriteLine("Converting OPT8 interface");
            OPNSenseConfig.Opt8 retVal = new OPNSenseConfig.Opt8();
            retVal.If = opt8.If;
            retVal.Ipaddr = opt8.Ipaddr;
            retVal.Subnet = opt8.Subnet;
            retVal.Ipaddrv6 = opt8.Ipaddrv6;
            retVal.Track6interface = opt8.Track6interface;
            retVal.Track6prefixid = opt8.Track6prefixid;
            try { retVal.Enable = (int)opt8.Enable; }
            catch { retVal.Enable = 1; }
            retVal.Subnetv6 = 64; // pfSense does not have this.  User can change it later.
            return retVal;
        }

        /// <summary>
        /// Convert from a pfSense OPT9 settings class to an OPNSense OPT9 settings class
        /// </summary>
        /// <param name="opt9">Input pfSense OPT9 settings class</param>
        /// <returns>OPNSense OPT9 settings class</returns>
        private static OPNSenseConfig.Opt9 OPT9(pfSenseConfig.Opt9 opt9)
        {
            Console.WriteLine("Converting OPT9 interface");
            OPNSenseConfig.Opt9 retVal = new OPNSenseConfig.Opt9();
            retVal.If = opt9.If;
            retVal.Ipaddr = opt9.Ipaddr;
            retVal.Subnet = opt9.Subnet;
            retVal.Ipaddrv6 = opt9.Ipaddrv6;
            retVal.Track6interface = opt9.Track6interface;
            retVal.Track6prefixid = opt9.Track6prefixid;
            try { retVal.Enable = (int)opt9.Enable; }
            catch { retVal.Enable = 1; }
            retVal.Subnetv6 = 64; // pfSense does not have this.  User can change it later.
            return retVal;
        }
    }
}