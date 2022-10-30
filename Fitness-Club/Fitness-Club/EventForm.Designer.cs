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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxEvent = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAddEv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxHourTo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelAddEvent = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnMyEvents = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxHourFrom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataEvents = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelAllEvent = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblNotEvents = new System.Windows.Forms.Label();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxUser = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.eventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelAddEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEvents)).BeginInit();
            this.panelAllEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(88, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 45);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(82, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 90;
            this.label1.Text = "From";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDate.Enabled = false;
            this.txtBoxDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBoxDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBoxDate.Location = new System.Drawing.Point(372, 108);
            this.txtBoxDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(202, 31);
            this.txtBoxDate.TabIndex = 24;
            // 
            // lblEvent
            // 
            this.lblEvent.BackColor = System.Drawing.Color.Transparent;
            this.lblEvent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEvent.Location = new System.Drawing.Point(88, 71);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(106, 32);
            this.lblEvent.TabIndex = 28;
            this.lblEvent.Text = "Event";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(372, 141);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 1);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(88, 141);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 1);
            this.panel2.TabIndex = 26;
            // 
            // txtBoxEvent
            // 
            this.txtBoxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtBoxEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEvent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBoxEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBoxEvent.Location = new System.Drawing.Point(89, 107);
            this.txtBoxEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEvent.Name = "txtBoxEvent";
            this.txtBoxEvent.Size = new System.Drawing.Size(211, 31);
            this.txtBoxEvent.TabIndex = 27;
            this.txtBoxEvent.Text = "Lasson Rabbi Sandro";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Location = new System.Drawing.Point(366, 71);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 30);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date";
            // 
            // lblAddEv
            // 
            this.lblAddEv.BackColor = System.Drawing.Color.Transparent;
            this.lblAddEv.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEv.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAddEv.Location = new System.Drawing.Point(224, 11);
            this.lblAddEv.Name = "lblAddEv";
            this.lblAddEv.Size = new System.Drawing.Size(196, 48);
            this.lblAddEv.TabIndex = 29;
            this.lblAddEv.Text = "ADD EVENT";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(366, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 31);
            this.label3.TabIndex = 106;
            this.label3.Text = "To";
            // 
            // comboBoxHourTo
            // 
            this.comboBoxHourTo.AllowDrop = true;
            this.comboBoxHourTo.BackColor = System.Drawing.Color.White;
            this.comboBoxHourTo.DisplayMember = "12";
            this.comboBoxHourTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxHourTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHourTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.comboBoxHourTo.FocusedColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxHourTo.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxHourTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHourTo.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxHourTo.FormattingEnabled = true;
            this.comboBoxHourTo.IntegralHeight = false;
            this.comboBoxHourTo.ItemHeight = 30;
            this.comboBoxHourTo.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30",
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30"});
            this.comboBoxHourTo.Location = new System.Drawing.Point(418, 169);
            this.comboBoxHourTo.Name = "comboBoxHourTo";
            this.comboBoxHourTo.Size = new System.Drawing.Size(147, 36);
            this.comboBoxHourTo.StartIndex = 20;
            this.comboBoxHourTo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.comboBoxHourTo.TabIndex = 105;
            // 
            // panelAddEvent
            // 
            this.panelAddEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelAddEvent.BorderRadius = 30;
            this.panelAddEvent.Controls.Add(this.btnMyEvents);
            this.panelAddEvent.Controls.Add(this.label1);
            this.panelAddEvent.Controls.Add(this.txtLocation);
            this.panelAddEvent.Controls.Add(this.btnSave);
            this.panelAddEvent.Controls.Add(this.panel3);
            this.panelAddEvent.Controls.Add(this.label2);
            this.panelAddEvent.Controls.Add(this.lblAddEv);
            this.panelAddEvent.Controls.Add(this.txtBoxEvent);
            this.panelAddEvent.Controls.Add(this.label3);
            this.panelAddEvent.Controls.Add(this.panel2);
            this.panelAddEvent.Controls.Add(this.lblDate);
            this.panelAddEvent.Controls.Add(this.comboBoxHourTo);
            this.panelAddEvent.Controls.Add(this.panel1);
            this.panelAddEvent.Controls.Add(this.lblEvent);
            this.panelAddEvent.Controls.Add(this.comboBoxHourFrom);
            this.panelAddEvent.Controls.Add(this.txtBoxDate);
            this.panelAddEvent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelAddEvent.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelAddEvent.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelAddEvent.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelAddEvent.Location = new System.Drawing.Point(41, 31);
            this.panelAddEvent.Name = "panelAddEvent";
            this.panelAddEvent.Size = new System.Drawing.Size(634, 384);
            this.panelAddEvent.TabIndex = 145;
            // 
            // btnMyEvents
            // 
            this.btnMyEvents.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMyEvents.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnMyEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyEvents.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnMyEvents.ForeColor = System.Drawing.Color.White;
            this.btnMyEvents.Location = new System.Drawing.Point(372, 322);
            this.btnMyEvents.Name = "btnMyEvents";
            this.btnMyEvents.Size = new System.Drawing.Size(180, 45);
            this.btnMyEvents.TabIndex = 110;
            this.btnMyEvents.Text = "My events";
            this.btnMyEvents.UseVisualStyleBackColor = false;
            this.btnMyEvents.Click += new System.EventHandler(this.btnMyEvents_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.txtLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtLocation.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtLocation.Location = new System.Drawing.Point(89, 269);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(476, 31);
            this.txtLocation.TabIndex = 108;
            this.txtLocation.Text = "Hatalmod 30";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(88, 303);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(477, 1);
            this.panel3.TabIndex = 107;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(88, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 109;
            this.label2.Text = "Location";
            // 
            // comboBoxHourFrom
            // 
            this.comboBoxHourFrom.AllowDrop = true;
            this.comboBoxHourFrom.BackColor = System.Drawing.Color.White;
            this.comboBoxHourFrom.BorderColor = System.Drawing.Color.White;
            this.comboBoxHourFrom.DisplayMember = "12";
            this.comboBoxHourFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxHourFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHourFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.comboBoxHourFrom.FocusedColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxHourFrom.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxHourFrom.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.comboBoxHourFrom.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxHourFrom.FormattingEnabled = true;
            this.comboBoxHourFrom.IntegralHeight = false;
            this.comboBoxHourFrom.ItemHeight = 30;
            this.comboBoxHourFrom.Items.AddRange(new object[] {
            "7:00",
            "7:30",
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30",
            "19:00",
            "19:30",
            "20:00",
            "20:30",
            "21:00",
            "21:30",
            "22:00",
            "22:30",
            "23:00",
            "23:30",
            "00:00",
            "00:30",
            "01:00",
            "01:30",
            "02:00",
            "02:30",
            "03:00",
            "03:30",
            "04:00",
            "04:30",
            "05:00",
            "05:30",
            "06:00",
            "06:30"});
            this.comboBoxHourFrom.Location = new System.Drawing.Point(153, 169);
            this.comboBoxHourFrom.Name = "comboBoxHourFrom";
            this.comboBoxHourFrom.Size = new System.Drawing.Size(147, 36);
            this.comboBoxHourFrom.StartIndex = 15;
            this.comboBoxHourFrom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.comboBoxHourFrom.TabIndex = 102;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitle.Location = new System.Drawing.Point(179, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(405, 31);
            this.lblTitle.TabIndex = 30;
            this.lblTitle.Text = "MY EVENTS";
            // 
            // dataEvents
            // 
            this.dataEvents.AllowUserToAddRows = false;
            this.dataEvents.AllowUserToDeleteRows = false;
            this.dataEvents.AllowUserToResizeColumns = false;
            this.dataEvents.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dataEvents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEvents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataEvents.ColumnHeadersHeight = 90;
            this.dataEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventName,
            this.Time,
            this.Location,
            this.idEvent});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataEvents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataEvents.EnableHeadersVisualStyles = false;
            this.dataEvents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataEvents.Location = new System.Drawing.Point(6, 3);
            this.dataEvents.MultiSelect = false;
            this.dataEvents.Name = "dataEvents";
            this.dataEvents.ReadOnly = true;
            this.dataEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataEvents.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataEvents.RowHeadersVisible = false;
            this.dataEvents.RowHeadersWidth = 51;
            this.dataEvents.RowTemplate.Height = 34;
            this.dataEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEvents.Size = new System.Drawing.Size(720, 336);
            this.dataEvents.TabIndex = 34;
            this.dataEvents.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataEvents.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.dataEvents.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dataEvents.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataEvents.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.dataEvents.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.dataEvents.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataEvents.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataEvents.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataEvents.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEvents.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataEvents.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataEvents.ThemeStyle.HeaderStyle.Height = 90;
            this.dataEvents.ThemeStyle.ReadOnly = true;
            this.dataEvents.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataEvents.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataEvents.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEvents.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataEvents.ThemeStyle.RowsStyle.Height = 34;
            this.dataEvents.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dataEvents.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            // 
            // panelAllEvent
            // 
            this.panelAllEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelAllEvent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelAllEvent.Controls.Add(this.lblNotEvents);
            this.panelAllEvent.Controls.Add(this.btnDeleteEvent);
            this.panelAllEvent.Controls.Add(this.btnAddEvent);
            this.panelAllEvent.Controls.Add(this.guna2PictureBox1);
            this.panelAllEvent.Controls.Add(this.lblTitle);
            this.panelAllEvent.Controls.Add(this.picBoxUser);
            this.panelAllEvent.Controls.Add(this.guna2PictureBox2);
            this.panelAllEvent.Controls.Add(this.dataEvents);
            this.panelAllEvent.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelAllEvent.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelAllEvent.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelAllEvent.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelAllEvent.Location = new System.Drawing.Point(6, 17);
            this.panelAllEvent.Name = "panelAllEvent";
            this.panelAllEvent.Size = new System.Drawing.Size(729, 398);
            this.panelAllEvent.TabIndex = 146;
            this.panelAllEvent.Visible = false;
            // 
            // lblNotEvents
            // 
            this.lblNotEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.lblNotEvents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotEvents.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNotEvents.Location = new System.Drawing.Point(179, 157);
            this.lblNotEvents.Name = "lblNotEvents";
            this.lblNotEvents.Size = new System.Drawing.Size(405, 70);
            this.lblNotEvents.TabIndex = 88;
            this.lblNotEvents.Text = "There are currently no events on this day. Click add event to add.";
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteEvent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnDeleteEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEvent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDeleteEvent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEvent.Image = global::Fitness_Club.Properties.Resources.PAH4;
            this.btnDeleteEvent.Location = new System.Drawing.Point(453, 345);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(180, 45);
            this.btnDeleteEvent.TabIndex = 87;
            this.btnDeleteEvent.UseVisualStyleBackColor = false;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnTrhash_Click_1);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddEvent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEvent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddEvent.ForeColor = System.Drawing.Color.White;
            this.btnAddEvent.Location = new System.Drawing.Point(58, 347);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(180, 45);
            this.btnAddEvent.TabIndex = 86;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.Image = global::Fitness_Club.Properties.Resources.TIMESmall;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.InitialImage")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(320, 38);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(45, 47);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 32;
            this.guna2PictureBox1.TabStop = false;
            // 
            // picBoxUser
            // 
            this.picBoxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.picBoxUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxUser.Image = global::Fitness_Club.Properties.Resources.pen1;
            this.picBoxUser.ImageRotate = 0F;
            this.picBoxUser.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxUser.InitialImage")));
            this.picBoxUser.Location = new System.Drawing.Point(84, 38);
            this.picBoxUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxUser.Name = "picBoxUser";
            this.picBoxUser.Size = new System.Drawing.Size(45, 47);
            this.picBoxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxUser.TabIndex = 31;
            this.picBoxUser.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox2.Image = global::Fitness_Club.Properties.Resources.LoacationSmall;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.InitialImage")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(564, 38);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(45, 47);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 33;
            this.guna2PictureBox2.TabStop = false;
            // 
            // eventName
            // 
            this.eventName.HeaderText = "";
            this.eventName.MinimumWidth = 220;
            this.eventName.Name = "eventName";
            this.eventName.ReadOnly = true;
            this.eventName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Time
            // 
            this.Time.HeaderText = "";
            this.Time.MinimumWidth = 140;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Location
            // 
            this.Location.HeaderText = "";
            this.Location.MinimumWidth = 180;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // idEvent
            // 
            this.idEvent.HeaderText = "idEvent";
            this.idEvent.MinimumWidth = 20;
            this.idEvent.Name = "idEvent";
            this.idEvent.ReadOnly = true;
            this.idEvent.Visible = false;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(747, 424);
            this.Controls.Add(this.panelAllEvent);
            this.Controls.Add(this.panelAddEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(765, 471);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.panelAddEvent.ResumeLayout(false);
            this.panelAddEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataEvents)).EndInit();
            this.panelAllEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxEvent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAddEv;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxHourTo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelAddEvent;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxHourFrom;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxUser;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dataEvents;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelAllEvent;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Button btnMyEvents;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Label lblNotEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvent;
    }
}