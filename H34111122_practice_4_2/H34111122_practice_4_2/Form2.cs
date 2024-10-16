using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H34111122_practice_4_2
{
    public partial class Form2 : Form
    {
        public Color ReturnValue;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            ReturnValue = this.BackColor;
            Close();
        }
    }
}
