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
            this.picCompleted = new System.Windows.Forms.PictureBox();
            this.lblTitleWhtsHot = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCompleted)).BeginInit();
            this.SuspendLayout();
            // 
            // picCompleted
            // 
            this.picCompleted.Image = global::Fitness_Club.Properties.Resources.Error;
            this.picCompleted.Location = new System.Drawing.Point(893, -2);
            this.picCompleted.Name = "picCompleted";
            this.picCompleted.Size = new System.Drawing.Size(539, 658);
            this.picCompleted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompleted.TabIndex = 164;
            this.picCompleted.TabStop = false;
            // 
            // lblTitleWhtsHot
            // 
            this.lblTitleWhtsHot.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleWhtsHot.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleWhtsHot.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleWhtsHot.Location = new System.Drawing.Point(190, 140);
            this.lblTitleWhtsHot.Name = "lblTitleWhtsHot";
            this.lblTitleWhtsHot.Size = new System.Drawing.Size(537, 60);
            this.lblTitleWhtsHot.TabIndex = 198;
            this.lblTitleWhtsHot.Text = "Opps somthing worng...";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.8F);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(182, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(577, 164);
            this.label4.TabIndex = 199;
            this.label4.Text = "We\'re sorry, but the operation you tried to perform encountered an unexpected err" +
    "or...\r\nPlease try again.\r\n";
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1401, 656);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTitleWhtsHot);
            this.Controls.Add(this.picCompleted);
            this.Name = "Error";
            this.Text = "Error";
            this.Load += new System.EventHandler(this.Error_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCompleted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picCompleted;
        private System.Windows.Forms.Label lblTitleWhtsHot;
        private System.Windows.Forms.Label label4;
    }
}