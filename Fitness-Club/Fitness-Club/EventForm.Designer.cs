namespace Fitness_Club
{
    partial class EventForm
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
            this.lblDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxEvent = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.panelAddEvent = new System.Windows.Forms.Panel();
            this.panelAllEvents = new System.Windows.Forms.Panel();
            this.lblEventslist = new System.Windows.Forms.Label();
            this.panelAddEvent.SuspendLayout();
            this.panelAllEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Location = new System.Drawing.Point(12, 16);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(130, 32);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(18, 101);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 1);
            this.panel1.TabIndex = 23;
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDate.Enabled = false;
            this.txtBoxDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBoxDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBoxDate.Location = new System.Drawing.Point(18, 67);
            this.txtBoxDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(287, 31);
            this.txtBoxDate.TabIndex = 24;
            // 
            // lblEvent
            // 
            this.lblEvent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEvent.Location = new System.Drawing.Point(12, 150);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(165, 32);
            this.lblEvent.TabIndex = 28;
            this.lblEvent.Text = "Event";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(9, 229);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 1);
            this.panel2.TabIndex = 26;
            // 
            // txtBoxEvent
            // 
            this.txtBoxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtBoxEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEvent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBoxEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBoxEvent.Location = new System.Drawing.Point(10, 195);
            this.txtBoxEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEvent.Name = "txtBoxEvent";
            this.txtBoxEvent.Size = new System.Drawing.Size(286, 31);
            this.txtBoxEvent.TabIndex = 27;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(44, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(216, 40);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelAddEvent
            // 
            this.panelAddEvent.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panelAddEvent.Controls.Add(this.lblDate);
            this.panelAddEvent.Controls.Add(this.btnSave);
            this.panelAddEvent.Controls.Add(this.txtBoxEvent);
            this.panelAddEvent.Controls.Add(this.panel2);
            this.panelAddEvent.Controls.Add(this.panel1);
            this.panelAddEvent.Controls.Add(this.lblEvent);
            this.panelAddEvent.Controls.Add(this.txtBoxDate);
            this.panelAddEvent.Location = new System.Drawing.Point(21, 26);
            this.panelAddEvent.Name = "panelAddEvent";
            this.panelAddEvent.Size = new System.Drawing.Size(312, 348);
            this.panelAddEvent.TabIndex = 86;
            // 
            // panelAllEvents
            // 
            this.panelAllEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelAllEvents.Controls.Add(this.lblEventslist);
            this.panelAllEvents.Location = new System.Drawing.Point(358, 52);
            this.panelAllEvents.Name = "panelAllEvents";
            this.panelAllEvents.Size = new System.Drawing.Size(206, 322);
            this.panelAllEvents.TabIndex = 87;
            // 
            // lblEventslist
            // 
            this.lblEventslist.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventslist.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEventslist.Location = new System.Drawing.Point(30, 40);
            this.lblEventslist.Name = "lblEventslist";
            this.lblEventslist.Size = new System.Drawing.Size(158, 198);
            this.lblEventslist.TabIndex = 29;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(603, 410);
            this.Controls.Add(this.panelAllEvents);
            this.Controls.Add(this.panelAddEvent);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.panelAddEvent.ResumeLayout(false);
            this.panelAddEvent.PerformLayout();
            this.panelAllEvents.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxEvent;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelAddEvent;
        private System.Windows.Forms.Panel panelAllEvents;
        private System.Windows.Forms.Label lblEventslist;
    }
}