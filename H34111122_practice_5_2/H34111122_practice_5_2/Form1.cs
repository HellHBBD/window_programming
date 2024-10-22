namespace H34111122_practice_5_2;

public partial class Form1 : Form
{
    Dictionary<string, bool> agentSelect = new Dictionary<string, bool>();
    public Form1()
    {
        InitializeComponent();
        agentSelect["Cardigan"] = false;
        agentSelect["Myrtle"] = false;
        agentSelect["Melantha"] = false;
    }

    private void button_start_Click(object sender, EventArgs e)
    {
        panel_start.Visible = false;
        panel_choose.Visible = true;
    }

    private void button_add_Click(object sender, EventArgs e)
    {
        if (listBox_list.SelectedItem == null)
        {
            MessageBox.Show("請選擇角色");
            return;
        }
        string name = listBox_list.SelectedItem.ToString();
        if (agentSelect[name] == true)
        {
            MessageBox.Show("請勿重複選擇角色");
            return;
        }
        agentSelect[name] = true;
        listBox_selected.Items.Add(name);
        listBox_list.ClearSelected();
    }

    private void button_remove_Click(object sender, EventArgs e)
    {
        if (listBox_selected.SelectedItem == null)
        {
            MessageBox.Show("請選擇要移除的角色");
            return;
        }
        string name = listBox_selected.SelectedItem.ToString();
        agentSelect[name] = false;
        listBox_selected.Items.Remove(name);
        listBox_selected.ClearSelected();
    }

    private void button_action_Click(object sender, EventArgs e)
    {
        if (listBox_selected.Items.Count == 0)
        {
            MessageBox.Show("至少選擇一個角色");
            return;
        }
        panel_choose.Visible = false;
        panel_game.Visible = true;
    }
}
