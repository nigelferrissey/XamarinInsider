using System.Net;
using DependencyApp.Core.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(DependencyApp.Android.Dependencies.IpAddressManager))]
namespace DependencyApp.Android.Dependencies
{
    internal class IpAddressManager : IIpAddressManager
    {
        public string GetIpAddress()
        {
            var addresses = Dns.GetHostAddresses(Dns.GetHostName());

            return addresses?[0] +  " from Android";
        }
    }
}
