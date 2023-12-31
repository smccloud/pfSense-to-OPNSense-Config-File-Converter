namespace Functions
{
    public static class FilterConversion
    {
        /// <summary>
        /// Entrypoint for the entire class
        /// </summary>
        /// <param name="pfSense">pfSense Filter object to convert</param>
        /// <returns>OPNSense filter object</returns>
        public static OPNSenseConfig.Filter ConvertAll(pfSenseConfig.Filter pfSense)
        {
            OPNSenseConfig.Filter retVal = new OPNSenseConfig.Filter();
            retVal.Rule = new List<OPNSenseConfig.Rule>();
            foreach (var item in pfSense.Rule)
            {
                OPNSenseConfig.Rule temp = new OPNSenseConfig.Rule();
                temp.Source = new OPNSenseConfig.Source();
                temp.Destination = new OPNSenseConfig.Destination();
                temp.Protocol = item.Protocol;
                temp.Interface = item.Interface;
                if (item.Associatedruleid != null)
                {
                    try { temp.Source.Any = (int)item.Source.Any; } catch { temp.Source.Any = 1; }
                    temp.Destination.Address = item.Destination.Address;
                    temp.Destination.Port = item.Destination.Port;
                    temp.Descr = item.Descr.Replace("<![CDATA[", "").Replace("]]", "");
                    temp.Associatedruleid = item.Associatedruleid;
                    temp.Created = new OPNSenseConfig.Created();
                    temp.Created.Time = item.Created.Time;
                    temp.Created.Username = item.Created.Username.Replace("<![CDATA[", "").Replace("]]", "");
                }
                else
                {
                    temp.Type = item.Type;
                    temp.Descr = item.Descr.Replace("<![CDATA[", "").Replace("]]", "");
                    temp.Source.Network = item.Source.Network;
                    temp.Destination.Any = item.Destination.Any;
                }
                retVal.Rule.Add(temp);
            }
            return retVal;
        }
    }
}