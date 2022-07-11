namespace Fitness_Club
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnRes = new Guna.UI2.WinForms.Guna2Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxPass = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxUser = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(74, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 1);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(74, 325);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 1);
            this.panel2.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnLogin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(65, 359);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(274, 45);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            // 
            // btnRes
            // 
            this.btnRes.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRes.BorderThickness = 1;
            this.btnRes.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnRes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnRes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRes.Location = new System.Drawing.Point(65, 431);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(274, 45);
            this.btnRes.TabIndex = 8;
            this.btnRes.Text = "Reset";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Location = new System.Drawing.Point(101, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 23);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Email";
            this.textBox1.Click += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Location = new System.Drawing.Point(101, 292);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(229, 23);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Password";
            this.textBox2.Click += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(300, 288);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 27);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 11;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // picBoxPass
            // 
            this.picBoxPass.BackgroundImage = global::Fitness_Club.Properties.Resources.pass1;
            this.picBoxPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxPass.Image = global::Fitness_Club.Properties.Resources.pass;
            this.picBoxPass.ImageRotate = 0F;
            this.picBoxPass.Location = new System.Drawing.Point(74, 293);
            this.picBoxPass.Name = "picBoxPass";
            this.picBoxPass.Size = new System.Drawing.Size(21, 22);
            this.picBoxPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxPass.TabIndex = 3;
            this.picBoxPass.TabStop = false;
            // 
            // picBoxUser
            // 
            this.picBoxUser.BackgroundImage = global::Fitness_Club.Properties.Resources.user2;
            this.picBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxUser.Image = global::Fitness_Club.Properties.Resources.user;
            this.picBoxUser.ImageRotate = 0F;
            this.picBoxUser.Location = new System.Drawing.Point(74, 239);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(21, 21);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUser.TabIndex = 0;
            this.picBoxUser.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(121, 23);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(172, 169);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 6;
            this.guna2PictureBox3.TabStop = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(396, 515);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picBoxPass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.picBoxUser);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox3);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fitness-Club LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox picBoxUser;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxPass;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Button btnRes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}

