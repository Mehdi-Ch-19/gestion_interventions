using Gestion_des_interventions;
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
using System.Security.Cryptography;
using System.IO;

namespace UI_UX_Dashboard_P1
{
    public partial class Form1 : Form
    {
        public SqlConnection cn = new SqlConnection(@"Data Source=.;Initial Catalog=G_intervention;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();
        public SqlDataReader dr;
        public DataTable dt = new DataTable();
        public DataRow row;
        public static string role = "";
        public static string iduser;
        public static string[] ourfiles;
        public Form1 instance;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(string id, string idutilisateurr)
        {
            InitializeComponent();
            if (id == "2")
            {
                role = "admin";
                //label8.Text = role;
                iduser = idutilisateurr;

            }
            else
            {
                role = "user";
                //label8.Text = role;
                iduser = idutilisateurr;

            }
        }
        public void fillcategorie()
        {
            cn.Open();
            cmd.CommandText = "SELECT id_cat, libele  FROM inter_categorie";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            dt.Load(dr);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "libele";
            comboBox1.ValueMember = "id_cat";


            dr.Close();
            cn.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (role == "admin")
            {
                label8.Text = role + "" + iduser;
            }
            else if (role == "user")
            {
                label8.Text = /*role + "" + iduser;*/ getname(iduser);

            }
            fillcategorie();
            comboBox2.Items.Add("Eleve");
            comboBox2.Items.Add("Normal");
            comboBox2.Items.Add("Imporratnt");
            textBox2.Text = iduser;
            dateTimePicker1.Value = DateTime.Today;
        }
        public string  getname(string id)
        {
            cn.Open();
            cmd.CommandText = "SELECT emp_name  FROM employe where emp_id = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", iduser);
            cmd.Connection = cn;
            string name = (string)cmd.ExecuteScalar();
            cn.Close();
            return name;
        }
        public static string GetUniqueKeyOriginal_BIASED(int size)
        {
            char[] chars =
                "1234567890".ToCharArray();
            byte[] data = new byte[size];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return ("D"+ result.ToString());
        }
        //rejete
        //en cours
        //affecter
       //non affecte
        private void button7_Click(object sender, EventArgs e)
        {
           

        }
        private void button6_Click(object sender, EventArgs e)
        {
            form2 myForm = new form2();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;
            panel4.Controls.RemoveAt(1);
            //myForm.Show();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous Quitter ? ", "Gestion Des Interventions", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //this.Close();
                System.Windows.Forms.Application.Exit();
            }
         }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(iduser);
        }
        public void filesinserted(string[] files , string id_inter)
        {
            if (files.Length>0 && files != null)
            {
                foreach (string fileNames in files)
                {

                    string contentType = "";
                    switch (Path.GetExtension(fileNames).ToLower())
                    {
                        case ".jpg":
                            contentType = "image/jpeg";
                            break;
                        case ".png":
                            contentType = "image/png";
                            break;
                        case ".gif":
                            contentType = "image/gif";
                            break;
                        case ".txt":
                            contentType = "text/plain";
                            break;
                        case ".bmp":
                            contentType = "image/bmp";
                            break;
                        case ".doc":
                            contentType = "application/msword";
                            break;
                        case ".docx":
                            contentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                            break;
                        case ".xls":
                            contentType = "application/vnd.ms-excel";
                            break;
                        case ".xlsx":
                            contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                            break;
                        case ".pdf":
                            contentType = "application/pdf";
                            break;
                        case ".zip":
                            contentType = "application/zip";
                            break;
                        case ".html":
                            contentType = "text/html";
                            break;
                        case ".ppt":
                            contentType = "application/vnd.ms-powerpoint";
                            break;
                        case ".pptx":
                            contentType = "application/vnd.openxmlformats-officedocument.presentationml.presentation";
                            break;
                    }
                    byte[] bytes = File.ReadAllBytes(fileNames);
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO attachement VALUES (@Name,@ContentType,@Data,@id_inter)", cn))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@Name", Path.GetFileName(fileNames));
                        cmd.Parameters.AddWithValue("@ContentType", contentType);
                        cmd.Parameters.AddWithValue("@Data", bytes);
                        cmd.Parameters.AddWithValue("@id_inter", id_inter);
                        cn.Open();
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=G_intervention;Integrated Security=True");
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string files = "";
                    foreach(string item in openFileDialog.FileNames)
                    {
                        files +=( " " +  item);
                    }
                    textBox3.Text = files;
                    //returnfiles(openFileDialog.FileNames);

                    ourfiles = openFileDialog.FileNames;
 
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                 string code = GetUniqueKeyOriginal_BIASED(4);
                cn.Open();
                cmd.CommandText = "insert into interventiont values (@code,@emp_id,@id_cat,@date,@description,@priorite,'non affecte')";
                cmd.Connection = cn;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@code", code);
                cmd.Parameters.AddWithValue("@emp_id", iduser);
                cmd.Parameters.AddWithValue("@id_cat", comboBox1.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@description", textBox1.Text);
                cmd.Parameters.AddWithValue("@priorite", comboBox2.SelectedItem.ToString());
                //MessageBox.Show(code + " " + iduser + " " + comboBox1.SelectedValue + " " + dateTimePicker1.Value + " " + textBox1.Text + " " + comboBox2.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                cn.Close();
                if (textBox3.Text != "")
                {
                    filesinserted(ourfiles, code);

                }
                //cmd.ExecuteNonQuery();
                MessageBox.Show("Votre demande a ete enregistrer ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            instance = null;
             historiques myForm = new historiques(iduser);
            myForm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            iduser = null;
            this.Hide();
            loginform l = new loginform();
            l.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Today;
            comboBox2.SelectedIndex = 0;
            textBox3.Text = "";
        }

        
    }
}
