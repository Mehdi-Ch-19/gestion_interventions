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
    public partial class historiques : Form
    {
        public string iduser = "";
        public SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=G_intervention;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public DataRow row;
        public historiques()
        {
            InitializeComponent();
        }
        public historiques(string id)
        {
            InitializeComponent();
            iduser = id;
        }
        private void historiques_Load(object sender, EventArgs e)
        {
            //cn.Open();
            //cmd.CommandText = "select code,emp_id ,libele,date_inter ,descriptions ,priorite , inter_status from interventiont inner join inter_categorie on interventiont.id_cat = inter_categorie.id_cat where emp_id = @iduser";
            //cmd.Connection = cn;
            //cmd.Parameters.Clear();
            //cmd.Parameters.AddWithValue("@iduser", iduser);
            //dr = cmd.ExecuteReader();
            //dt.Load(dr);
            //dataGridView1.DataSource = dt;
            remplirgrid();
            comboBox1.Items.Add("En cours");
            comboBox1.Items.Add("Resolue");
            comboBox1.Items.Add("non affecte");
            comboBox1.Items.Add("Rejete");
         }
        public void remplirgrid()
        {
            cn.Open();
            cmd.CommandText = "select code,emp_id ,libele,date_inter ,descriptions ,priorite , inter_status from interventiont inner join inter_categorie on interventiont.id_cat = inter_categorie.id_cat where emp_id = @iduser";
            cmd.Connection = cn;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@iduser", iduser);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cn.Close();
            dr.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cn.Open();
                cmd.CommandText = "select code,emp_id ,libele,date_inter ,descriptions ,priorite , inter_status from interventiont inner join inter_categorie on interventiont.id_cat = inter_categorie.id_cat where emp_id = @iduser and inter_status = @status";
                cmd.Connection = cn;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@iduser", iduser);
                cmd.Parameters.AddWithValue("@status", comboBox1.SelectedItem.ToString());
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dt.Rows.Clear();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
 
                }
                else
                {
                    MessageBox.Show("il exist aucun intervention avec ces criters");
                }
                cn.Close();
                dr.Close();
            }
            if (radioButton2.Checked)
            {
                cn.Open();
                cmd.CommandText = "select code,emp_id ,libele,date_inter ,descriptions ,priorite , inter_status from interventiont inner join inter_categorie on interventiont.id_cat = inter_categorie.id_cat where emp_id = @iduser and date_inter = @date";
                cmd.Connection = cn;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@iduser", iduser);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dt.Rows.Clear();
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("il exist aucun intervention avec ces criters");
                }
                cn.Close();
                dr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            remplirgrid();
        }
    }
}
