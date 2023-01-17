namespace Fitness_Club
{
    partial class Error
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureInidcation = new System.Windows.Forms.PictureBox();
            this.lblTitleWhtsHot = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInidcation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(620, -66);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 33);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "ADD-Members";
            // 
            // pictureInidcation
            // 
            this.pictureInidcation.Image = global::Fitness_Club.Properties.Resources.Error;
            this.pictureInidcation.Location = new System.Drawing.Point(874, -5);
            this.pictureInidcation.Name = "pictureInidcation";
            this.pictureInidcation.Size = new System.Drawing.Size(564, 667);
            this.pictureInidcation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInidcation.TabIndex = 92;
            this.pictureInidcation.TabStop = false;
            // 
            // lblTitleWhtsHot
            // 
            this.lblTitleWhtsHot.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleWhtsHot.Font = new System.Drawing.Font("Segoe UI", 30.8F, System.Drawing.FontStyle.Bold);
            this.lblTitleWhtsHot.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleWhtsHot.Location = new System.Drawing.Point(178, 58);
            this.lblTitleWhtsHot.Name = "lblTitleWhtsHot";
            this.lblTitleWhtsHot.Size = new System.Drawing.Size(649, 95);
            this.lblTitleWhtsHot.TabIndex = 198;
            this.lblTitleWhtsHot.Text = "Oops somthing worng...";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.8F);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(155, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(713, 139);
            this.label4.TabIndex = 200;
            this.label4.Text = "Unfortunately, something seems to have gone wrong, please try the action you want" +
    "ed again and we will handle it properly.\r\n";
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1401, 656);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTitleWhtsHot);
            this.Controls.Add(this.pictureInidcation);
            this.Controls.Add(this.lblTitle);
            this.Name = "Error";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.addMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInidcation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureInidcation;
        private System.Windows.Forms.Label lblTitleWhtsHot;
        private System.Windows.Forms.Label label4;
    }
}