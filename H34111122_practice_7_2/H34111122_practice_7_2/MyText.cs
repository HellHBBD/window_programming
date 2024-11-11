namespace H34111122_practice_7_2
{
    [Serializable]
    internal class MyText
    {
        public string fontFamily;
        public float size;
        public FontStyle style;
        public int argb;
        public string text;

        public MyText()
        {
            fontFamily = "";
            text = "";
        }
        public MyText(Font font, Color color, string text)
        {
            fontFamily = font.FontFamily.Name;
            size = font.Size;
            style = font.Style;
            argb = color.ToArgb();
            this.text = text;
        }

        public (Font, Color, string) get()
        {
            return (new Font(fontFamily, size, style), Color.FromArgb(argb), text);
        }
    }
}
