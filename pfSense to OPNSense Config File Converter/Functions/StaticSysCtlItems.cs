namespace Functions
{
    public static class StaticSysCtlItems
    {
        public static OPNSenseConfig.Sysctl Create()
        {
            OPNSenseConfig.Sysctl retVal = new OPNSenseConfig.Sysctl();
            retVal.Item = new List<OPNSenseConfig.Item>();
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Increase UFS read-ahead speeds to match the state of hard drives and NCQ.",
                Tunable = "vfs.read_max",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Set the ephemeral port range to be lower.",
                Tunable = "net.inet.ip.portrange.first",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Drop packets to closed TCP ports without returning a RST",
                Tunable = "net.inet.tcp.blackhole",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Do not send ICMP port unreachable messages for closed UDP ports",
                Tunable = "net.inet.udp.blackhole",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Randomize the ID field in IP packets",
                Tunable = "net.inet.ip.random_id",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Source routing is another way for an attacker to try to reach non-routable addresses behind your box.\r\n\t\t\t\tIt can also be used to probe for information about your internal networks. These functions come enabled\r\n\t\t\t\tas part of the standard FreeBSD core system.",
                Tunable = "net.inet.ip.sourceroute",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Source routing is another way for an attacker to try to reach non-routable addresses behind your box.\r\n\t\t\t\tIt can also be used to probe for information about your internal networks. These functions come enabled\r\n\t\t\t\tas part of the standard FreeBSD core system.",
                Tunable = "net.inet.ip.accept_sourceroute",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "This option turns off the logging of redirect packets because there is no limit and this could fill\r\n\t\t\t\tup your logs consuming your whole hard drive.",
                Tunable = "net.inet.icmp.log_redirect",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Drop SYN-FIN packets (breaks RFC1379, but nobody uses it anyway)",
                Tunable = "net.inet.tcp.drop_synfin",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Enable sending IPv6 redirects",
                Tunable = "net.inet6.ip6.redirect",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Enable privacy settings for IPv6 (RFC 4941)",
                Tunable = "net.inet6.ip6.use_tempaddr",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Prefer privacy addresses and use them over the normal addresses",
                Tunable = "net.inet6.ip6.prefer_tempaddr",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Generate SYN cookies for outbound SYN-ACK packets",
                Tunable = "net.inet.tcp.syncookies",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Maximum incoming/outgoing TCP datagram size (receive)",
                Tunable = "net.inet.tcp.recvspace",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Maximum incoming/outgoing TCP datagram size (send)",
                Tunable = "net.inet.tcp.sendspace",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Do not delay ACK to try and piggyback it onto a data packet",
                Tunable = "net.inet.tcp.delayed_ack",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Maximum outgoing UDP datagram size",
                Tunable = "net.inet.udp.maxdgram",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Handling of non-IP packets which are not passed to pfil (see if_bridge(4))",
                Tunable = "net.link.bridge.pfil_onlyip",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Set to 1 to additionally filter on the physical interface for locally destined packets",
                Tunable = "net.link.bridge.pfil_local_phys",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Set to 0 to disable filtering on the incoming and outgoing member interfaces.",
                Tunable = "net.link.bridge.pfil_member",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Set to 1 to enable filtering on the bridge interface",
                Tunable = "net.link.bridge.pfil_bridge",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Allow unprivileged access to tap(4) device nodes",
                Tunable = "net.link.tap.user_open",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Randomize PID's (see src/sys/kern/kern_fork.c: sysctl_kern_randompid())",
                Tunable = "kern.randompid",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Disable CTRL+ALT+Delete reboot from keyboard.",
                Tunable = "hw.syscons.kbd_reboot",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Enable TCP extended debugging",
                Tunable = "net.inet.tcp.log_debug",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Set ICMP Limits",
                Tunable = "net.inet.icmp.icmplim",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "TCP Offload Engine",
                Tunable = "net.inet.tcp.tso",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "UDP Checksums",
                Tunable = "net.inet.udp.checksum",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Maximum socket buffer size",
                Tunable = "kern.ipc.maxsockbuf",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Page Table Isolation (Meltdown mitigation, requires reboot.)",
                Tunable = "vm.pmap.pti",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Disable Indirect Branch Restricted Speculation (Spectre V2 mitigation)",
                Tunable = "hw.ibrs_disable",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Hide processes running as other groups",
                Tunable = "security.bsd.see_other_gids",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Hide processes running as other users",
                Tunable = "security.bsd.see_other_uids",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Enable/disable sending of ICMP redirects in response to IP packets for which a better,\r\n\t\t\t\tand for the sender directly reachable, route and next hop is known.",
                Tunable = "net.inet.ip.redirect",
                Value = "default"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Redirect attacks are the purposeful mass-issuing of ICMP type 5 packets. In a normal network, redirects\r\n\t\t\t\tto the end stations should not be required. This option enables the NIC to drop all inbound ICMP redirect\r\n\t\t\t\tpackets without returning a response.",
                Tunable = "net.inet.icmp.drop_redirect",
                Value = "1"
            });
            retVal.Item.Add(new OPNSenseConfig.Item
            {
                Descr = "Maximum outgoing UDP datagram size",
                Tunable = "net.local.dgram.maxdgram",
                Value = "default"
            });
            return retVal;
        }
    }
}
