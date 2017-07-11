using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DependencyApp.Core.Interfaces;
using Xamarin.Forms;

namespace DependencyApp.Core
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            IpLabel.Text = DependencyService.Get<IIpAddressManager>().GetIpAddress();
        }
    }
}
