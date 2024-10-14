namespace H34111122_practice_4_1;

public partial class Form1 : Form
{
    internal List<string> record = new List<string>();
    public Color color1, color2;

    public Form1()
    {
        InitializeComponent();
    }

    private void chat_dou()
    {
        BackColor = color1;
        richTextBox_dou.Clear();
        foreach (var item in record)
        {
            richTextBox_dou.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox_dou.AppendText("楷特:" + item + "\n");
            richTextBox_dou.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox_dou.AppendText("斗哥:汪!\n");
        }
    }

    private void char_kai()
    {
        BackColor = color2;
        richTextBox_kai.Clear();
        foreach (var item in record)
        {
            richTextBox_kai.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox_kai.AppendText("楷特:" + item + "\n");
            richTextBox_kai.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox_kai.AppendText("斗哥:汪!\n");
        }
    }

    public void change_color(Color color)
    {
        this.BackColor = color;
    }

    private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControl.SelectedTab == tabPage_dou)
        {
            textBox_chat.Enabled = false;
            button_send.Enabled = false;

            // print chat record
            chat_dou();
        }
        if (tabControl.SelectedTab == tabPage_kai)
        {
            textBox_chat.Enabled = true;
            button_send.Enabled = true;

            // print chat record
            char_kai();
        }
    }

    private void button_send_Click(object sender, EventArgs e)
    {
        if (textBox_chat.Text != "")
        {
            record.Add(textBox_chat.Text);
            textBox_chat.Clear();
            char_kai();
        }
    }

    private void panel1_DoubleClick(object sender, EventArgs e)
    {
        Form2 f = new Form2();
        f.Visible = true;
        f.Name = "顏色選擇";
    }
}
