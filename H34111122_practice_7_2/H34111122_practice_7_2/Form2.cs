using Newtonsoft.Json;
using System.Text;
/*using System.Collections.Generic;*/

namespace H34111122_practice_7_2
{
    public partial class Form2 : Form
    {
        string filename = "";
        bool change = false;
        bool push = true;
        Stack<(string, int)> history = new Stack<(string, int)>();
        Stack<(string, int)> undoList = new Stack<(string, int)>();
        string previousString = "";
        int previousCursor;

        public Form2(string filename)
        {
            InitializeComponent();
            if (Path.GetExtension(filename) == ".txt")
            {
                textBox.Text = File.ReadAllText(filename);
            }
            else if (Path.GetExtension(filename) == ".mytxt")
            {
                string json_string = File.ReadAllText(filename, Encoding.UTF8);
                MyText? format = JsonConvert.DeserializeObject<MyText>(json_string);
                if (format != null)
                {
                    (textBox.Font, textBox.ForeColor, textBox.Text) = format.get();
                }
            }

            change = false;
            Text = this.filename = filename;
            KeyPreview = true;
            previousString = textBox.Text;
            previousCursor = textBox.SelectionStart;
            timer.Start();
        }

        private void save()
        {
            change = false;
            Text = Text.TrimStart('*');
            if (Path.GetExtension(filename) == ".txt")
            {
                File.WriteAllText(filename, textBox.Text);
            }
            else if (Path.GetExtension(filename) == ".mytxt")
            {

                MyText format = new MyText(textBox.Font, textBox.ForeColor, textBox.Text);
                string json_string = JsonConvert.SerializeObject(format);
                File.WriteAllText(filename, json_string, Encoding.UTF8);
            }
        }

        private void save_as()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                change = false;
                Text = Text.TrimStart('*');
                Text = filename = saveFileDialog.FileName;
                if (Path.GetExtension(filename) == ".txt")
                {
                    File.WriteAllText(filename, textBox.Text);
                }
                else if (Path.GetExtension(filename) == ".mytxt")
                {
                    MyText format = new MyText(textBox.Font, textBox.ForeColor, textBox.Text);
                    string json_string = JsonConvert.SerializeObject(format);
                    File.WriteAllText(filename, json_string, Encoding.UTF8);
                }
            }
        }

        private void cut()
        {
            if (textBox.SelectedText != "")
            {
                Clipboard.SetText(textBox.SelectedText);
                textBox.SelectedText = "";
            }
        }

        private void copy()
        {
            if (textBox.SelectedText != "")
            {
                Clipboard.SetText(textBox.SelectedText);
            }
        }

        private void paste()
        {
            textBox.SelectedText = Clipboard.GetText();
        }

        private void undo()
        {
            undoList.Push((textBox.Text, textBox.SelectionStart));
            push = false;
            (textBox.Text, textBox.SelectionStart) = history.Pop();
            push = true;
        }

        private void redo()
        {
            if (undoList.Count == 0)
            {
                (string text, int start) = history.Peek();
                MessageBox.Show(start + " " + textBox.SelectionStart);
                //string part = text.Substring(start, textBox.SelectionStart - start);  // 擷取從第2個字符開始的2個字符
                //textBox.Text = text.Insert(start, part);  // 在第3個位置插入 "bc"
            }
            else
            {
                history.Push((textBox.Text, textBox.SelectionStart));
                push = false;
                (textBox.Text, textBox.SelectionStart) = undoList.Pop();
                push = true;
            }
        }

        private void count()
        {
            MessageBox.Show("字數: " + textBox.Text.Length, "字數統計", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void search()
        {
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename == "untitled")
            {
                save_as();
                return;
            }
            else
            {
                save();
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_as();
        }

        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cut();
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            paste();
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

        private void 字數統計ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            save();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!change)
            {
                change = true;
                Text = "*" + Text;
            }
            if (push)
            {
                history.Push(((previousString, previousCursor)));
                (previousString, previousCursor) = (textBox.Text, textBox.SelectionStart);
                undoList.Clear();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redo();
        }
    }
}
