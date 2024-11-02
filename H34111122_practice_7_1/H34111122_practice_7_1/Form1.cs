namespace H34111122_practice_7_1;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void toolStripMenuItem_exit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ∑sºWToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Form2 f = new Form2();
        f.ShowDialog();
    }

    private void ∂}±“¬¬¿…ToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            Form2 f = new Form2(openFileDialog.FileName);
            f.ShowDialog();
        }
    }
}
