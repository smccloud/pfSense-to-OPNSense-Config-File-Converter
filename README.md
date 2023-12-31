# pfSense to OPNSense Config File Converter

Used to convert a pfSense configuration backup to OPNSense

## Other
* For everyone that has stared this, please use issues to list items you wanted converted. otherwise I'm going to go in a random order that makes no sense. 

## Description

This project was started due to Netgate's decision to remove the free home & lab pfSense+ licensing that I was running.  I could convert my home pfSense+ instance to OPNSense without issue, but I have multiple ones to do so I figured I'd work on automating it and hope others can benefit from it.

* Known working items
  * Interfaces (WAN, LAN, OPT(1-9))
  * Users, prompts for password, asks to convert admin to root
  * DHCP servers, including static leases (LAN, OPT(1-9))
  * Filters
  * NAT
  * Basic system data
  * Default dashboard
  * Default sysctl values

* Known items to work on (not a priority list)
  * VLANs
  * OpenVPN
  * IPSEC
  * Aliases
  * LAGGs

## Getting Started

1. Extract the zip file
2. Backup your pfSense installation, do not backup package information (not converted so not needed)
3. Copy pfSense configuration file to working folder named pfSense.xml
4. Run the executable
  1. For Windows just run as is
  2. For Linux or macOS follow below
	1. Run chmod +x pfSense-to-OPNSense-Config-File-Converter to make executable
	2. Execute with ./pfSense-to-OPNSense-Config-File-Converter
5. Follow the prompts
6. Install OPNSense
7. Skip the first run wizard in OPNSense
8. Restore the OPNSense config file you just generated
9. Celebrate

### Dependencies

* pfSense configuration backup file

## Authors

Contributors names and contact info

Shaun McCloud
https://smccloud.com

## Version History

* 0.1
  * Initial release, there may (probably are) bugs

## License

This project is licensed under the MIT License - see the LICENSE.txt file for details