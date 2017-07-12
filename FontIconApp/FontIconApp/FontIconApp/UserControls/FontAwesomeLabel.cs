using Xamarin.Forms;

namespace FontIconApp.UserControls
{
    public class FontAwesomeLabel : Label
    {
        public static readonly string FontAwesomeName = "FontAwesome";

        //Parameterless constructor for XAML
        public FontAwesomeLabel()
        {
            FontFamily = FontAwesomeName;
        }

        public FontAwesomeLabel(string fontAwesomeLabel = null)
        {
            FontFamily = FontAwesomeName;
            Text = fontAwesomeLabel;
        }
    }

    // https://github.com/neilkennedy/FontAwesome.Xamarin/blob/master/FontAwesome.Xamarin/FontAwesome.cs
    // For a huge list of icon codes
    public static class Icon
    {
        public static readonly string FAGlass = "\uf000";
        public static readonly string FAMusic = "\uf001";
        public static readonly string FASearch = "\uf002";
        public static readonly string FAEnvelopeO = "\uf003";
    }
}