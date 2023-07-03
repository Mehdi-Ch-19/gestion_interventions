 
using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_UX_Dashboard_P1;

namespace Gestion_des_interventions
{
    public partial class loginform : Form
    {
        public static String query = "";
        public SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=G_intervention;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public DataRow row;
        public string idutilisateur;
        public loginform()
        {
            InitializeComponent();
            
        }

        private void loginform_Load(object sender, EventArgs e)
        {
            
        }
        public int checkuser()
        {
            cn.Open();
            cmd.CommandText = "SELECT emp_id, emp_name,role_id FROM employe where emp_login = @user and emp_pass = @pass";
            cmd.Connection = cn;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@user", login.Text);
            cmd.Parameters.AddWithValue("@pass", pass.Text);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    idutilisateur = dr["emp_id"].ToString();
                }
                dr.Close();
                cn.Close();
                return 1;
            }
            else
            {
                dr.Close();
                cn.Close();
                return -1;
            }
        }
        public int checkadmin()
        {
            cn.Open();
            cmd.CommandText = "SELECT code_inter, nom,roleid FROM intervenant where inter_login = @user and inter_pass = @pass";
            cmd.Connection = cn;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@user", login.Text);
            cmd.Parameters.AddWithValue("@pass", pass.Text);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    idutilisateur = dr["code_inter"].ToString();
                }
                dr.Close();
                cn.Close();
                return 2;
            }
            else
            {
                dr.Close();
                cn.Close();
                return -1;
            }
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            int user = checkuser();
            int admin = checkadmin();
            if (user != -1 && user != 2)
            {
                //this.Hide();
                //Dashboard d = new Dashboard("1");
                //d.Show();
                //return;
                 this.Hide();
                Form1 f = new Form1("1", idutilisateur);
                f.Show();
                return;
            }
            if (admin != -1)
            {
                //this.Hide();
                //Dashboard d = new Dashboard("2");
                //d.Show();
                //return;
                 this.Hide();
                admin a = new admin(idutilisateur);
                a.Show();
                //Form1 f = new Form1("2", idutilisateur);
                //f.Show();
                return;
            }
            //while (dr.Read() )
            //{
            //    this.Hide();
            //    Dashboard d = new Dashboard(dr["role_id"].ToString());
            //    d.Show();
            //    //MessageBox.Show(dr["role_id"].ToString());
            //    //'moa25','charimoni' admin 
            //    dr.Close();
            //    cn.Close();
            //    return;
            //}
             
             MessageBox.Show("Email ou Mot de passe est incorrect");
             login.Text = "";
             pass.Text = "";
            cn.Close();
             
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous Quitter ? ", "Gestion Des Interventions",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();

            }
        }
    }
}
