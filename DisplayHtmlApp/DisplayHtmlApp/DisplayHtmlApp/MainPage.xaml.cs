using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DisplayHtmlApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MyWebView.Source = new HtmlWebViewSource
            {
                Html = @"<html><body>An html string</body></html>"
            };

            MyHtmlLabel.Text = "<h1>Hello world!, <br/> <span style='color:blue'>1</span> <span style='color:red'>2</span> <span style='color:yellow'>3</span></h1>";
        }
    }
}
