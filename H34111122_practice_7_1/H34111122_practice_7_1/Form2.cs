using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace H34111122_practice_7_1
{
    public partial class Form2 : Form
    {
        string filename = "";
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(string filename)
        {
            InitializeComponent();
            Text = this.filename = filename;
            if (Path.GetExtension(filename) == ".txt")
            {
                textBox.Text = File.ReadAllText(filename);
            }
            else if (Path.GetExtension(filename) == ".mytxt")
            {
                MyText format = new MyText();
                (textBox.Font, textBox.ForeColor, textBox.Text) = format.load(filename);
            }
        }


        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                另存新檔ToolStripMenuItem_Click(sender, e);
                return;
            }
            else if (Path.GetExtension(filename) == ".txt")
            {
                File.WriteAllText(filename, textBox.Text);
            }
            else if (Path.GetExtension(filename) == ".mytxt")
            {
                MyText format = new MyText(textBox.Font, textBox.ForeColor, textBox.Text);
                format.save(filename);
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Text = filename = saveFileDialog.FileName;
                if (Path.GetExtension(filename) == ".txt")
                {
                    File.WriteAllText(filename, textBox.Text);
                }
                else if (Path.GetExtension(filename) == ".mytxt")
                {
                    MyText format = new MyText(textBox.Font, textBox.ForeColor, textBox.Text);
                    format.save(filename);
                }
            }
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.SelectedText != "")
            {
                Clipboard.SetText(textBox.SelectedText);
                textBox.SelectedText = "";
            }
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox.SelectedText != "")
            {
                Clipboard.SetText(textBox.SelectedText);
            }
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox.SelectedText = Clipboard.GetText();
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.Font = fontDialog.Font;
            }
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = colorDialog.Color;
            }
        }

        private void toolStripMenuItem_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
