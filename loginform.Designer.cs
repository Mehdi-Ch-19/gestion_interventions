
namespace Gestion_des_interventions
{
    partial class loginform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.login = new MaterialSkin.Controls.MaterialTextBox2();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.pass = new MaterialSkin.Controls.MaterialTextBox2();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 593);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(187, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "El Mahdi Chiheb";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(218, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Devolllop by";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkKhaki;
            this.label2.Location = new System.Drawing.Point(105, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Service APP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(158, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_des_interventions.Properties.Resources.settings_5_128;
            this.pictureBox1.Location = new System.Drawing.Point(102, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 156);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Olive;
            this.label5.Location = new System.Drawing.Point(511, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 37);
            this.label5.TabIndex = 1;
            this.label5.Text = "Se Connecter";
            // 
            // login
            // 
            this.login.AnimateReadOnly = false;
            this.login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.login.Depth = 0;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.login.HideSelection = true;
            this.login.LeadingIcon = null;
            this.login.Location = new System.Drawing.Point(468, 288);
            this.login.MaxLength = 32767;
            this.login.MouseState = MaterialSkin.MouseState.OUT;
            this.login.Name = "login";
            this.login.PasswordChar = '\0';
            this.login.PrefixSuffixText = null;
            this.login.ReadOnly = false;
            this.login.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.login.SelectedText = "";
            this.login.SelectionLength = 0;
            this.login.SelectionStart = 0;
            this.login.ShortcutsEnabled = true;
            this.login.Size = new System.Drawing.Size(330, 48);
            this.login.TabIndex = 5;
            this.login.TabStop = false;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.login.TrailingIcon = null;
            this.login.UseSystemPasswordChar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(578, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Login";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(566, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 30);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mot Passe";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton1.Depth = 0;
            this.materialButton1.ForeColor = System.Drawing.Color.Sienna;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(571, 499);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(107, 36);
            this.materialButton1.TabIndex = 9;
            this.materialButton1.Text = "Connecter";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton2.Depth = 0;
            this.materialButton2.ForeColor = System.Drawing.Color.Sienna;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(726, 15);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(81, 36);
            this.materialButton2.TabIndex = 10;
            this.materialButton2.Text = "Quitter";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // pass
            // 
            this.pass.AnimateReadOnly = false;
            this.pass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.pass.Depth = 0;
            this.pass.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.HideSelection = true;
            this.pass.LeadingIcon = null;
            this.pass.Location = new System.Drawing.Point(468, 395);
            this.pass.MaxLength = 32767;
            this.pass.MouseState = MaterialSkin.MouseState.OUT;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '\0';
            this.pass.PrefixSuffixText = null;
            this.pass.ReadOnly = false;
            this.pass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pass.SelectedText = "";
            this.pass.SelectionLength = 0;
            this.pass.SelectionStart = 0;
            this.pass.ShortcutsEnabled = true;
            this.pass.Size = new System.Drawing.Size(330, 48);
            this.pass.TabIndex = 7;
            this.pass.TabStop = false;
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.pass.TrailingIcon = null;
            this.pass.UseSystemPasswordChar = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestion_des_interventions.Properties.Resources.profile_user;
            this.pictureBox2.Location = new System.Drawing.Point(583, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 84);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 593);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.loginform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialTextBox2 login;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MaterialSkin.Controls.MaterialTextBox2 pass;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}