using System.ComponentModel;
using Android.OS;
using Android.Text;
using Android.Widget;
using DisplayHtmlApp.Droid.CustomRenderers;
using DisplayHtmlApp.UserControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(HtmlLabel), typeof(HtmlLabelRenderer))]
namespace DisplayHtmlApp.Droid.CustomRenderers
{

    public class HtmlLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Control?.SetText(GetText(), TextView.BufferType.Spannable);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == Label.TextProperty.PropertyName)
            {
                Control?.SetText(GetText(), TextView.BufferType.Spannable);
            }
        }

        private ISpanned GetText()
        {
            return (int)Build.VERSION.SdkInt >= 24
                ? Html.FromHtml(Element.Text, FromHtmlOptions.ModeLegacy)
                : Html.FromHtml(Element.Text);
        }
    }
}