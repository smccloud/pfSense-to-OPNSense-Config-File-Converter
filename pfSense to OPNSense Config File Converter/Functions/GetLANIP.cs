using pfSenseConfig;

namespace Functions
{
    public static class GetLANIP
    {
        /// <summary>
        /// Gets the IP of the LAN Interface
        /// </summary>
        /// <param name="inInterface">The interface to get the IP of</param>
        /// <returns>The IP</returns>
        public static string GetIP(Lan inInterface)
        {
            string retVal = "";
            try { if (inInterface.Ipaddr != null) retVal = inInterface.Ipaddr; } catch { }
            return retVal;
        }

        /// <summary>
        /// Gets the IP of the OPT1 Interface
        /// </summary>
        /// <param name="inInterface">The interface to get the IP of</param>
        /// <returns>The IP</returns>
        public static string GetIP(Opt1 inInterface)
        {
            string retVal = "";
            try { if (inInterface.Ipaddr != null) retVal = inInterface.Ipaddr; } catch { }
            return retVal;
        }

        /// <summary>
        /// Gets the IP of the OPT2 Interface
        /// </summary>
        /// <param name="inInterface">The interface to get the IP of</param>
        /// <returns>The IP</returns>
        public static string GetIP(Opt2 inInterface)
        {
            string retVal = "";
            try { if (inInterface.Ipaddr != null) retVal = inInterface.Ipaddr; } catch { }
            return retVal;
        }

        /// <summary>
        /// Gets the IP of the OPT3 Interface
        /// </summary>
        /// <param name="inInterface">The interface to get the IP of</param>
        /// <returns>The IP</returns>
        public static string GetIP(Opt3 inInterface)
        {
            string retVal = "";
            try { if (inInterface.Ipaddr != null) retVal = inInterface.Ipaddr; } catch { }
            return retVal;
        }

        /// <summary>
        /// Gets the IP of the OPT4 Interface
        /// </summary>
        /// <param name="inInterface">The interface to get the IP of</param>
        /// <returns>The IP</returns>
        public static string GetIP(Opt4 inInterface)
        {
            string retVal = "";
            try { if (inInterface.Ipaddr != null) retVal = inInterface.Ipaddr; } catch { }
            return retVal;
        }

        /// <summary>
        /// Gets the IP of the OPT5 Interface
        /// </summary>
        /// <param name="inInterface">The interface to get the IP of</param>
        /// <returns>The IP</returns>
        public static string GetIP(Opt5 inInterface)
        {
            string retVal = "";
            try { if (inInterface.Ipaddr != null) retVal = inInterface.Ipaddr; } catch { }
            return retVal;
        }

        /// <summary>
        /// Gets the IP of the OPT6 Interface
        /// </summary>
        /// <param name="inInterface">The interface to get the IP of</param>
        /// <returns>The IP</returns>
        public static string GetIP(Opt6 inInterface)
        {
            string retVal = "";
            try { if (inInterface.Ipaddr != null) retVal = inInterface.Ipaddr; } catch { }
            return retVal;
        }

        /// <summary>
        /// Gets the IP of the OPT7 Interface
        /// </summary>
        /// <param name="inInterface">The interface to get the IP of</param>
        /// <returns>The IP</returns>
        public static string GetIP(Opt7 inInterface)
        {
            string retVal = "";
            try { if (inInterface.Ipaddr != null) retVal = inInterface.Ipaddr; } catch { }
            return retVal;
        }

        /// <summary>
        /// Gets the IP of the OPT8 Interface
        /// </summary>
        /// <param name="inInterface">The interface to get the IP of</param>
        /// <returns>The IP</returns>
        public static string GetIP(Opt8 inInterface)
        {
            string retVal = "";
            try { if (inInterface.Ipaddr != null) retVal = inInterface.Ipaddr; } catch { }
            return retVal;
        }

        /// <summary>
        /// Gets the IP of the OPT9 Interface
        /// </summary>
        /// <param name="inInterface">The interface to get the IP of</param>
        /// <returns>The IP</returns>
        public static string GetIP(Opt9 inInterface)
        {
            string retVal = "";
            try { if (inInterface.Ipaddr != null) retVal = inInterface.Ipaddr; } catch { }
            return retVal;
        }
    }
}
