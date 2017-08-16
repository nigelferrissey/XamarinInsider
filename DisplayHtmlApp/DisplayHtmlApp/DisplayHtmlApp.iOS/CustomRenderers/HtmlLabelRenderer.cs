using System.ComponentModel;
using DisplayHtmlApp.iOS.CustomRenderers;
using DisplayHtmlApp.UserControls;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HtmlLabel), typeof(HtmlLabelRenderer))]
namespace DisplayHtmlApp.iOS.CustomRenderers
{
    public class HtmlLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            UpdateElement();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == Label.TextProperty.PropertyName)
            {
                UpdateElement();
            }
        }

        private void UpdateElement()
        {
            if (Control != null && Element != null && !string.IsNullOrWhiteSpace(Element.Text))
            {
                var attr = new NSAttributedStringDocumentAttributes();
                var nsError = new NSError();
                attr.DocumentType = NSDocumentType.HTML;

                var myHtmlData = NSData.FromString(Element.Text, NSStringEncoding.Unicode);
                Control.Lines = 0;
                Control.AttributedText = new NSAttributedString(myHtmlData, attr, ref nsError);
            }
        }
    }
}