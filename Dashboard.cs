using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1;

namespace Gestion_des_interventions
{
    public partial class Dashboard : Form
    {
        public static string role = "";
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(string id)
        {
            InitializeComponent();
            if (id == "2")
            {
                role = "admin";
                label2.Visible = false;
            }
            else
            {
                role = "user";
                label1.Visible = false;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
