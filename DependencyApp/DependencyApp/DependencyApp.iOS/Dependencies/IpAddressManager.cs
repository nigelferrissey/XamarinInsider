using System.Net.NetworkInformation;
using System.Net.Sockets;
using DependencyApp.Core.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(DependencyApp.iOS.Dependencies.IpAddressManager))]
namespace DependencyApp.iOS.Dependencies
{
    internal class IpAddressManager : IIpAddressManager
    {
        public string GetIpAddress()
        {
            var ipAddress = "";

            foreach (var netInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (netInterface.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 ||
                    netInterface.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (var addrInfo in netInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (addrInfo.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            ipAddress = addrInfo.Address.ToString();

                        }
                    }
                }
            }

            return ipAddress + " from iOS";
        }
    }
}
