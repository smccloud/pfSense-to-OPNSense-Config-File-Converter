namespace Functions
{
    public static class NATConversion
    {
        /// <summary>
        /// Converters pfSense NAT rules to OPNSense NAT rules
        /// </summary>
        /// <param name="pfSense">pfSense NAT object to convert</param>
        /// <returns>OPNSense NAT object</returns>
        public static OPNSenseConfig.Nat ConvertAll(pfSenseConfig.Nat pfSense)
        {
            OPNSenseConfig.Nat retVal = new OPNSenseConfig.Nat();
            retVal.Outbound = new OPNSenseConfig.Outbound();
            retVal.Outbound.Mode = pfSense.Outbound.Mode;
            retVal.Rule = new List<OPNSenseConfig.Rule>();
            foreach (var item in pfSense.Rule)
            {
                OPNSenseConfig.Rule temp = new OPNSenseConfig.Rule();
                temp.Source = new OPNSenseConfig.Source();
                try { temp.Source.Any = (int)item.Source.Any; } catch { temp.Source.Any = 1; }
                temp.Destination = new OPNSenseConfig.Destination();
                temp.Destination.Port = item.Destination.Port;
                temp.Destination.Network = item.Destination.Network;
                temp.Ipprotocol = item.Ipprotocol;
                temp.Protocol = item.Protocol;
                temp.Target = item.Target;
                temp.Localport = item.Localport;
                temp.Interface = item.Interface;
                temp.Descr = item.Descr.Replace("<![CDATA[", "").Replace("]]", "");
                temp.Associatedruleid = item.Associatedruleid; // may not work?
                temp.Updated = new OPNSenseConfig.Updated();
                temp.Updated.Time = item.Updated.Time;
                temp.Updated.Username = item.Updated.Username.Replace("<![CDATA[", "").Replace("]]", "");
                temp.Created = new OPNSenseConfig.Created();
                temp.Created.Time = item.Created.Time;
                temp.Created.Username = item.Created.Username.Replace("<![CDATA[", "").Replace("]]", "");
                retVal.Rule.Add(temp);
            }
            return retVal;
        }
    }
}
