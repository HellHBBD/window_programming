using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace H34111122_practice_7_1
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
        }
        public MyText(Font font, Color color, string text)
        {
            fontFamily = font.FontFamily.Name;
            size = font.Size;
            style = font.Style;
            argb = color.ToArgb();
            this.text = text;
        }

        public void save(string filePath)
        {
            using (var writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                // 序列化 Font
                writer.Write(fontFamily);
                writer.Write(size);
                writer.Write((int)style);

                // 序列化 Color
                writer.Write(argb);

                writer.Write(text);
            }
        }

        public (Font, Color color, string text) load(string filePath)
        {
            using (var reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                // 反序列化 Font
                fontFamily = reader.ReadString();
                size = reader.ReadSingle();
                style = (FontStyle)reader.ReadInt32();

                // 反序列化 Color
                argb = reader.ReadInt32();

                text = reader.ReadString();
            }
            return (new Font(fontFamily, size, style), Color.FromArgb(argb), text);
        }
    }
}
