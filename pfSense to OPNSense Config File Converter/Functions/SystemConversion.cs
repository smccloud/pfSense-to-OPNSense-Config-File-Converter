namespace Functions
{
    public static class SystemConversion
    {
        /// <summary>
        /// summary>
        /// Entrypoint for the entire class
        /// </summary>
        /// <param name="pfSense"pfSense System Object to convert></param>
        /// <returns>OPNSense system object</returns>
        public static OPNSenseConfig.System ConvertAll(pfSenseConfig.System pfSense)
        {
            OPNSenseConfig.System retVal = new OPNSenseConfig.System();
            retVal.Hostname = pfSense.Hostname;
            retVal.Domain = pfSense.Domain;
            retVal.Nextgid = pfSense.Nextgid;
            retVal.Nextuid = pfSense.Nextuid;
            retVal.Timeservers = pfSense.Timeservers;
            retVal.Webgui = new OPNSenseConfig.Webgui();
            retVal.Webgui.Protocol = pfSense.Webgui.Protocol;
            retVal.PowerdAcMode = pfSense.PowerdAcMode;
            retVal.PowerdBatteryMode = pfSense.PowerdBatteryMode;
            retVal.PowerdAcMode = pfSense.PowerdAcMode;
            retVal.Bogons = new OPNSenseConfig.Bogons();
            retVal.Bogons.Interval = pfSense.Bogons.Interval;
            retVal.Timezone = pfSense.Timezone;
            retVal.Group = new List<OPNSenseConfig.Group>();
            foreach(var group in pfSense.Group)
            {
                OPNSenseConfig.Group temp = new OPNSenseConfig.Group();
                temp.Name = group.Name;
                temp.Description = group.Description.Replace("<![CDATA[", "").Replace("]]", "");
                temp.Scope = group.Scope;
                temp.Gid = group.Gid;
                temp.Priv = group.Priv;
                retVal.Group.Add(temp);
            }
            retVal.User = new List<OPNSenseConfig.User>();
            foreach (var user in pfSense.User)
            {
                OPNSenseConfig.User temp = new OPNSenseConfig.User();
                if (user.Name.ToUpper() == "ADMIN")
                {
                    string choice = string.Empty;
                    do
                    {
                        Console.Write("Keep pfSense admin username of " + user.Name + " or convert to convert to OPNSense standard of \"root\"? (Y/N)");
                        choice = Console.ReadLine().ToUpper();
                        if (choice != "Y" && choice != "N") Console.WriteLine("You entered " + choice + " not Y or N, please enter again");
                    } while ( choice != "Y" && choice != "N");
                    if (choice == "Y") temp.Name = "root";
                }
                else temp.Name = user.Name;
                temp.Descr = user.Descr.Replace("<![CDATA[", "").Replace("]]", "");
                temp.Scope = user.Scope;
                temp.Groupname = user.Groupname;
                temp.Uid = user.Uid;
                Console.Write("\nPlease enter password to use for user \"" + user.Name + "\". :");
                var pass = string.Empty;
                ConsoleKey key;
                do
                {
                    var keyInfo = Console.ReadKey(intercept: true);
                    key = keyInfo.Key;

                    if (key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        Console.Write("\b \b");
                        pass = pass[0..^1];
                    }
                    else if (!char.IsControl(keyInfo.KeyChar))
                    {
                        Console.Write("*");
                        pass += keyInfo.KeyChar;
                    }
                } while (key != ConsoleKey.Enter);
                temp.Password = BCrypt.Net.BCrypt.HashPassword(pass);
                retVal.User.Add(temp);
            }
            return retVal;
        }
    }
}
