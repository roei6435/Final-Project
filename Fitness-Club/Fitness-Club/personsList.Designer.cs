namespace Fitness_Club
{
    partial class personsList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDateRegistion = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.showOrHideTweetsFromThisAdmin = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.profilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTweet = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateRegistion
            // 
            this.lblDateRegistion.BackColor = System.Drawing.Color.Transparent;
            this.lblDateRegistion.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateRegistion.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDateRegistion.Location = new System.Drawing.Point(108, 41);
            this.lblDateRegistion.Name = "lblDateRegistion";
            this.lblDateRegistion.Size = new System.Drawing.Size(308, 27);
            this.lblDateRegistion.TabIndex = 178;
            this.lblDateRegistion.Text = "Activity adminstor from: 20/09/2022";
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFullName.Location = new System.Drawing.Point(108, 8);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(236, 30);
            this.lblFullName.TabIndex = 199;
            this.lblFullName.Text = "Yuval azulay";
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.ForeColor = System.Drawing.Color.SpringGreen;
            this.lblLevel.Location = new System.Drawing.Point(109, 68);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(263, 27);
            this.lblLevel.TabIndex = 200;
            this.lblLevel.Text = "Beginner";
            // 
            // showOrHideTweetsFromThisAdmin
            // 
            this.showOrHideTweetsFromThisAdmin.Checked = true;
            this.showOrHideTweetsFromThisAdmin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showOrHideTweetsFromThisAdmin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.showOrHideTweetsFromThisAdmin.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.showOrHideTweetsFromThisAdmin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.showOrHideTweetsFromThisAdmin.Location = new System.Drawing.Point(347, 6);
            this.showOrHideTweetsFromThisAdmin.Name = "showOrHideTweetsFromThisAdmin";
            this.showOrHideTweetsFromThisAdmin.Size = new System.Drawing.Size(54, 29);
            this.showOrHideTweetsFromThisAdmin.TabIndex = 201;
            this.showOrHideTweetsFromThisAdmin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showOrHideTweetsFromThisAdmin.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showOrHideTweetsFromThisAdmin.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.showOrHideTweetsFromThisAdmin.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.showOrHideTweetsFromThisAdmin.CheckedChanged += new System.EventHandler(this.showOrHideTweetsFromThisAdmin_CheckedChanged);
            this.showOrHideTweetsFromThisAdmin.MouseLeave += new System.EventHandler(this.showOrHideTweetsFromThisAdmin_MouseLeave);
            this.showOrHideTweetsFromThisAdmin.MouseHover += new System.EventHandler(this.showOrHideTweetsFromThisAdmin_MouseHover);
            // 
            // profilePic
            // 
            this.profilePic.BackColor = System.Drawing.Color.Transparent;
            this.profilePic.Image = global::Fitness_Club.Properties.Resources.defult_pro_pic2;
            this.profilePic.ImageRotate = 0F;
            this.profilePic.Location = new System.Drawing.Point(3, 3);
            this.profilePic.Name = "profilePic";
            this.profilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePic.Size = new System.Drawing.Size(90, 89);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 177;
            this.profilePic.TabStop = false;
            // 
            // lblTweet
            // 
            this.lblTweet.BackColor = System.Drawing.Color.Gainsboro;
            this.lblTweet.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.lblTweet.ForeColor = System.Drawing.Color.Black;
            this.lblTweet.Location = new System.Drawing.Point(109, 38);
            this.lblTweet.Name = "lblTweet";
            this.lblTweet.Size = new System.Drawing.Size(292, 30);
            this.lblTweet.TabIndex = 202;
            this.lblTweet.Text = "Show you tweets from this admin?";
            this.lblTweet.Visible = false;
            // 
            // personsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.lblTweet);
            this.Controls.Add(this.showOrHideTweetsFromThisAdmin);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblDateRegistion);
            this.Controls.Add(this.profilePic);
            this.Name = "personsList";
            this.Size = new System.Drawing.Size(404, 101);
            this.Load += new System.EventHandler(this.personsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePic;
        private System.Windows.Forms.Label lblDateRegistion;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblLevel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch showOrHideTweetsFromThisAdmin;
        private System.Windows.Forms.Label lblTweet;
    }
}
