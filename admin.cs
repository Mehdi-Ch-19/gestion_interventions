using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gestion_des_interventions
{
    public partial class admin : Form
    {
        public string iduser = "";
        public SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=G_intervention;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public DataRow row;
        public static string code = "";
        public admin()
        {
            InitializeComponent();
        }
        public admin(string id)
        {
            InitializeComponent();
            code = id;

        }

        private void admin_Load(object sender, EventArgs e)
        {
            cn.Open();
            cmd.CommandText = "select code,emp_id ,libele,date_inter ,descriptions ,priorite , inter_status from interventiont inner join inter_categorie on interventiont.id_cat = inter_categorie.id_cat";
            cmd.Connection = cn;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@code", code);
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView2.DataSource = dt;
            dataGridView2.CurrentRow.Selected = false;
            comboBox1.Items.Add("En Cours");
            comboBox1.Items.Add("Resolue");
            comboBox1.Items.Add("non affecte");
            comboBox1.Items.Add("Rejete");
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "";
            checkBoxColumn.Width = 10;
            checkBoxColumn.Name = "checkBoxColumn";
             this.dataGridView1.Columns.Insert(0, checkBoxColumn);
         }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        { }

        protected void Binddatagridview()
        {
            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=G_intervention;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT  filname , contentype FROM attachement where inter_id = @code", con))
                {
                    int rowselected = dataGridView2.CurrentRow.Index;
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@code", dataGridView2.Rows[rowselected].Cells[0].Value.ToString());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        this.dataGridView1.DataSource = dt;
                    }
                }
            }

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowselected = dataGridView2.CurrentRow.Index;
            string icode = dataGridView2.Rows[rowselected].Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.Rows[rowselected].Cells[0].Value.ToString();
            textBox4.Text = dataGridView2.Rows[rowselected].Cells[1].Value.ToString();
            textBox5.Text = dataGridView2.Rows[rowselected].Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)dataGridView2.Rows[rowselected].Cells[3].Value;
            textBox1.Text = dataGridView2.Rows[rowselected].Cells[4].Value.ToString();
            textBox6.Text = dataGridView2.Rows[rowselected].Cells[5].Value.ToString();
            comboBox1.SelectedItem = dataGridView2.Rows[rowselected].Cells[6].Value.ToString();
            Binddatagridview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["checkBoxColumn"].Value))
                        {
                            string id = row.Cells[1].Value.ToString();
                            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=G_intervention;Integrated Security=True"))
                            {
                                using (SqlCommand cmd = new SqlCommand("SELECT filname,filedata FROM attachement WHERE inter_id = @Id", con))
                                {
                                    int rowselected = dataGridView2.CurrentRow.Index;
                                    cmd.CommandType = CommandType.Text;
                                    cmd.Parameters.AddWithValue("@Id", dataGridView2.Rows[rowselected].Cells[0].Value.ToString());
                                    con.Open();
                                    using (SqlDataReader sdr = cmd.ExecuteReader())
                                    {
                                        if (sdr.Read())
                                        {
                                            byte[] bytes = (byte[])sdr["filedata"];
                                            string fileName = sdr["filname"].ToString();
                                            string path = Path.Combine(folderBrowserDialog.SelectedPath, fileName);
                                            File.WriteAllBytes(path, bytes);
                                         }
                                    }
                                    con.Close();
                                }
                            }
                        }
                    }

                    MessageBox.Show("File downloaded in folder " + folderBrowserDialog.SelectedPath);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            modificationdemande m = new modificationdemande();
            m.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            multirecherche mr = new multirecherche();
            mr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous Quitter ? ", "Gestion Des Interventions", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            iduser = null;
            this.Hide();
            loginform l = new loginform();
            l.Show();
        }

         
    }
}
