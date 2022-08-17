namespace Fitness_Club
{
    partial class UserControlDays
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
            this.components = new System.ComponentModel.Container();
            this.timerEvent = new System.Windows.Forms.Timer(this.components);
            this.btnDay = new System.Windows.Forms.Button();
            this.ringPic = new System.Windows.Forms.PictureBox();
            this.CounterEvents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ringPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDay
            // 
            this.btnDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDay.Location = new System.Drawing.Point(0, 0);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(127, 69);
            this.btnDay.TabIndex = 91;
            this.btnDay.Text = "00";
            this.btnDay.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // ringPic
            // 
            this.ringPic.Image = global::Fitness_Club.Properties.Resources.ring;
            this.ringPic.Location = new System.Drawing.Point(88, 32);
            this.ringPic.Name = "ringPic";
            this.ringPic.Size = new System.Drawing.Size(25, 24);
            this.ringPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ringPic.TabIndex = 92;
            this.ringPic.TabStop = false;
            this.ringPic.Visible = false;
            // 
            // CounterEvents
            // 
            this.CounterEvents.BackColor = System.Drawing.Color.Red;
            this.CounterEvents.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CounterEvents.Location = new System.Drawing.Point(85, 17);
            this.CounterEvents.Name = "CounterEvents";
            this.CounterEvents.Size = new System.Drawing.Size(15, 20);
            this.CounterEvents.TabIndex = 93;
            this.CounterEvents.Text = "2";
            this.CounterEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CounterEvents.Visible = false;
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.CounterEvents);
            this.Controls.Add(this.ringPic);
            this.Controls.Add(this.btnDay);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(127, 69);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ringPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerEvent;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.PictureBox ringPic;
        private System.Windows.Forms.Label CounterEvents;
    }
}
