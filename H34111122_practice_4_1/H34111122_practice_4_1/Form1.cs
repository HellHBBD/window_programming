namespace H34111122_practice_4_1;

public partial class Form1 : Form
{
    internal List<string> record = new List<string>();
    public Color color1, color2;

    public Form1()
    {
        InitializeComponent();
    }

    private void chat1()
    {
        BackColor = color1;
        richTextBox_left.Clear();
        foreach (var item in record)
        {
            richTextBox_left.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox_left.AppendText("楷特:" + item + "\n");
            richTextBox_left.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox_left.AppendText("斗哥:汪!\n");
        }
    }

    private void chat2()
    {
        BackColor = color2;
        richTextBox_left.Clear();
        foreach (var item in record)
        {
            richTextBox_left.SelectionAlignment = HorizontalAlignment.Left;
            richTextBox_left.AppendText("斗哥:汪!\n");
            richTextBox_left.SelectionAlignment = HorizontalAlignment.Right;
            richTextBox_left.AppendText("楷特:" + item + "\n");
        }
    }

    public void change_color(Color color)
    {
        this.BackColor = color;
    }

    private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (tabControl.SelectedTab == tabPage1)
        {
            textBox_chat.Enabled = false;
            button_send.Enabled = false;

            // print chat record
            chat1();
        }
        if (tabControl.SelectedTab == tabPage2)
        {
            textBox_chat.Enabled = true;
            button_send.Enabled = true;

            // print chat record
            chat2();
        }
    }

    private void button_send_Click(object sender, EventArgs e)
    {
        if (textBox_chat.Text != "")
        {
            record.Add(textBox_chat.Text);
            textBox_chat.Clear();
            chat2();
        }
    }

    private void panel1_DoubleClick(object sender, EventArgs e)
    {
        Form2 f = new Form2();
        f.Visible = true;
        f.Name = "顏色選擇";
    }
}
