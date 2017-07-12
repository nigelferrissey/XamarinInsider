using Android.Graphics;
using FontIconApp.Droid.CustomRenderers;
using FontIconApp.UserControls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FontAwesomeLabel), typeof(FontAwesomeLabelRenderer))]

namespace FontIconApp.Droid.CustomRenderers
{
    public class FontAwesomeLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets,
                    "Fonts/" + FontAwesomeLabel.FontAwesomeName + ".otf");
            }
        }
    }
}