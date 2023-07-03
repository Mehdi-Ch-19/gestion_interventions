using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_interventions
{
    public partial class modificationdemande : Form
    {
        public string iduser = "";
        public SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=G_intervention;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public modificationdemande()
        {
            InitializeComponent();
        }

        private void modificationdemande_Load(object sender, EventArgs e)
        {
            remplirgrid();
            comboBox1.Items.Add("En Cours");
            comboBox1.Items.Add("Resolue");
            comboBox1.Items.Add("non affecte");
            comboBox1.Items.Add("Rejete");
             
        }
        public void remplirgrid()
        {
            dt.Rows.Clear();
            cn.Open();
            cmd.CommandText = "select code,emp_id ,libele,date_inter ,descriptions ,priorite , inter_status from interventiont inner join inter_categorie on interventiont.id_cat = inter_categorie.id_cat ";
            cmd.Connection = cn;
            cmd.Parameters.Clear();
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            cn.Close();
            dr.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int rowselected = dataGridView1.CurrentRow.Index;
                string icode = dataGridView1.Rows[rowselected].Cells[0].Value.ToString();
                cn.Open();
                cmd.CommandText = "update interventiont set inter_status = @cs where code = @code";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@cs", comboBox1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@code", icode);
                cmd.ExecuteNonQuery();
                cn.Close();
                remplirgrid();
                MessageBox.Show("Modification avec succes");
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowselected = dataGridView1.CurrentRow.Index;
            comboBox1.SelectedItem = dataGridView1.Rows[rowselected].Cells[6].Value.ToString();
        }
    }
}
