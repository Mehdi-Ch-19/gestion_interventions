using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_des_interventions
{
    public partial class multirecherche : Form
    {
        public string iduser = "";
        public SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=G_intervention;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public DataRow row;
        public multirecherche()
        {
            InitializeComponent();
        }

        private void multirecherche_Load(object sender, EventArgs e)
        {
             
            comboBox2.Items.Add("En Cours");
            comboBox2.Items.Add("Resolue");
            comboBox2.Items.Add("non affecte");
            comboBox2.Items.Add("Rejete");
            remplirgrid();
            remplirprobleme();
            //comboBox2.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            comboBox3.Items.Add("Eleve");
            comboBox3.Items.Add("Normal");
            comboBox3.Items.Add("Imporratnt");

        }
        public void remplirgrid()
        {
            cn.Open();
            cmd.CommandText = "select code,emp_id ,libele,date_inter ,descriptions ,priorite , inter_status from interventiont inner join inter_categorie on interventiont.id_cat = inter_categorie.id_cat";
            cmd.Connection = cn;
            cmd.Parameters.Clear();
             dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cn.Close();
            dr.Close();
        }
        public void remplirprobleme()
        {
            cn.Open();
            cmd.CommandText = "SELECT id_cat, libele  FROM inter_categorie";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr);
            comboBox1.DataSource = dt2;
            comboBox1.DisplayMember = "libele";
            comboBox1.ValueMember = "id_cat";
            dr.Close();
            cn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //rechercher();
           // MessageBox.Show(comboBox1.SelectedText);
            rechercher2();
            //if (dateTimePicker1.Text != "")
            //{
            //    MessageBox.Show(dateTimePicker1.Text);

            //}
            //MessageBox.Show(DateTime.Now.ToString("d"));
        }
        public void rechercher()
        {
            cn.Open();
            dt.Rows.Clear();
           // cmd.CommandText = "select code,emp_id ,libele,date_inter ,descriptions ,priorite , inter_status from interventiont inner join inter_categorie on interventiont.id_cat = inter_categorie.id_cat where ((code = '') or (code = @code)  ) and ((emp_id = '') or (emp_id = @emp_id)) and ((interventiont.id_cat = '') or (interventiont.id_cat = @id_cat)) and  ((date_inter = '') or (date_inter = @date_inter)) and ((inter_status = '') or (inter_status = @inter_status))  ";
            cmd.CommandText = "select code,emp_id ,libele,date_inter ,descriptions ,priorite , inter_status from interventiont inner join inter_categorie on interventiont.id_cat = inter_categorie.id_cat where (( @code = '') or (code = @code)  ) and ((@emp_id = '') or (emp_id = @emp_id)) and (( @id_cat = '' ) or (interventiont.id_cat = @id_cat)) and  (( @date_inter = '') or (date_inter = @date_inter)) and (( @inter_status = '') or (inter_status = @inter_status))  ";
            cmd.Connection = cn;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", textBox2.Text);
            cmd.Parameters.AddWithValue("@emp_id", textBox1.Text);
            int idcat = -1;
            if (comboBox1.SelectedIndex != -1)
            {
                idcat = int.Parse(comboBox1.SelectedValue.ToString());
            }
            cmd.Parameters.AddWithValue("@id_cat",idcat);
            cmd.Parameters.AddWithValue("@date_inter", dateTimePicker1.Value.ToString());
            string status = "";
            if  (comboBox2.SelectedIndex != -1)
            {
                status = comboBox2.SelectedItem.ToString();
            }
            cmd.Parameters.AddWithValue("@inter_status", status);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cn.Close();
            dr.Close();
        }
        public static int idcat = -1;
        public static string status = "";
        private void button2_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "";
            //textBox1.Text = "";
            //comboBox1.SelectedIndex = -1;
            //dateTimePicker1.CustomFormat = " ";
           // dateTimePicker1.Format = DateTimePickerFormat.Custom;
             //dateTimePicker1.Value = " ";
            //comboBox2.SelectedItem = 0;
            dt.Rows.Clear();
            remplirgrid();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           // dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            //dateTimePicker1.Tag = 1;
        }
        public void rechercher2()
        {
            cn.Open();
            dt.Rows.Clear();
            // cmd.CommandText = "select code,emp_id ,libele,date_inter ,descriptions ,priorite , inter_status from interventiont inner join inter_categorie on interventiont.id_cat = inter_categorie.id_cat where ((code = '') or (code = @code)  ) and ((emp_id = '') or (emp_id = @emp_id)) and ((interventiont.id_cat = '') or (interventiont.id_cat = @id_cat)) and  ((date_inter = '') or (date_inter = @date_inter)) and ((inter_status = '') or (inter_status = @inter_status))  ";
            //cmd.CommandText = "select code,emp_id ,libele,date_inter ,descriptions ,priorite , inter_status from interventiont inner join inter_categorie on interventiont.id_cat = inter_categorie.id_cat where (( @code = '') or (code = @code)  ) and ((@emp_id = '') or (emp_id = @emp_id)) and (( @id_cat = '' ) or (interventiont.id_cat = @id_cat)) and  (( @date_inter = '') or (date_inter = @date_inter)) and (( @inter_status = '') or (inter_status = @inter_status))  ";
            string query = "Select code,emp_id ,libele,date_inter ,descriptions ,priorite , inter_status from interventiont inner join inter_categorie on interventiont.id_cat = inter_categorie.id_cat where 1=1  ";
            if (textBox2.Text != "")
            {
                string subquery = " and code = '" + textBox2.Text + "'";
                query += subquery;
            }
            if (textBox1.Text != "")
            {
                string subquery = " and emp_id = '" + textBox1.Text + "'";
                query += subquery;
            }
            if (comboBox1.SelectedIndex != -1)
            {
                idcat = (int)comboBox1.SelectedValue;
                string subquery = " and  interventiont.id_cat = '" + idcat+ "'";
                query += subquery;
            }
            if (comboBox2.SelectedIndex != - 1)
            {
                status = (string)comboBox2.SelectedItem;
                string subquery = " and inter_status  = '" + status + "'";
                query += subquery;
                
            }
            if (comboBox3.SelectedIndex != -1)
            {
                 string subquery = " and priorite  = '" + comboBox3.SelectedItem + "'";
                query += subquery;

            }
            if (dateTimePicker1.Checked)
            {
                string subquery = " and date_inter  = '" + dateTimePicker1.Text + "'";
                query += subquery;

            }
             cmd.Connection = cn;
            cmd.CommandText = query;
            cmd.Parameters.Clear();
           // cmd.Parameters.AddWithValue("@code", textBox2.Text);
            //cmd.Parameters.AddWithValue("@emp_id", textBox1.Text);
           // cmd.Parameters.AddWithValue("@id_cat", idcat);
           // cmd.Parameters.AddWithValue("@date_inter", dateTimePicker1.Text);
            //cmd.Parameters.AddWithValue("@inter_status", status);
            ///MessageBox.Show(query);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                
            }
            else
            {
                MessageBox.Show("Inteventions Introuvable");
            }
            cn.Close();
            dr.Close();

        }

        private void dateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete) )
            {
                dateTimePicker1.CustomFormat = " ";
            }
        }
    }
}
