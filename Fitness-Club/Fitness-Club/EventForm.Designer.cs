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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.btnSave = new System.Windows.Forms.Button();
            this.panelAllEvents = new System.Windows.Forms.Panel();
            this.lblEventslist = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.lblEvent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxEvent = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAddEv = new System.Windows.Forms.Label();
            this.panelAddEvent = new System.Windows.Forms.Panel();
            this.comboBoxHourFrom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxHourTo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblMyEvents = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.lblEventsList2 = new System.Windows.Forms.RichTextBox();
            this.panelAllEvents.SuspendLayout();
            this.panelAddEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(187, 258);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(193, 40);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelAllEvents
            // 
            this.panelAllEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.panelAllEvents.Controls.Add(this.lblMyEvents);
            this.panelAllEvents.Controls.Add(this.lblEventslist);
            this.panelAllEvents.Location = new System.Drawing.Point(602, 121);
            this.panelAllEvents.Name = "panelAllEvents";
            this.panelAllEvents.Size = new System.Drawing.Size(652, 240);
            this.panelAllEvents.TabIndex = 87;
            this.panelAllEvents.Visible = false;
            // 
            // lblEventslist
            // 
            this.lblEventslist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.lblEventslist.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventslist.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEventslist.Location = new System.Drawing.Point(3, 62);
            this.lblEventslist.Name = "lblEventslist";
            this.lblEventslist.Size = new System.Drawing.Size(618, 135);
            this.lblEventslist.TabIndex = 29;
            this.lblEventslist.Text = "• Lasson Rabbi sandro | 18:00-19:00          | hatalmod 30\r\n\r\n";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(54, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 90;
            this.label1.Text = "Hour";
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.txtBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDate.Enabled = false;
            this.txtBoxDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBoxDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBoxDate.Location = new System.Drawing.Point(343, 110);
            this.txtBoxDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(170, 31);
            this.txtBoxDate.TabIndex = 24;
            // 
            // lblEvent
            // 
            this.lblEvent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEvent.Location = new System.Drawing.Point(59, 74);
            this.lblEvent.Name = "lblEvent";
            this.lblEvent.Size = new System.Drawing.Size(106, 32);
            this.lblEvent.TabIndex = 28;
            this.lblEvent.Text = "Event";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(343, 144);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 1);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(59, 144);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 1);
            this.panel2.TabIndex = 26;
            // 
            // txtBoxEvent
            // 
            this.txtBoxEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.txtBoxEvent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEvent.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtBoxEvent.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtBoxEvent.Location = new System.Drawing.Point(60, 110);
            this.txtBoxEvent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEvent.Name = "txtBoxEvent";
            this.txtBoxEvent.Size = new System.Drawing.Size(200, 31);
            this.txtBoxEvent.TabIndex = 27;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDate.Location = new System.Drawing.Point(337, 76);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 30);
            this.lblDate.TabIndex = 25;
            this.lblDate.Text = "Date";
            // 
            // lblAddEv
            // 
            this.lblAddEv.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEv.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAddEv.Location = new System.Drawing.Point(203, 9);
            this.lblAddEv.Name = "lblAddEv";
            this.lblAddEv.Size = new System.Drawing.Size(196, 48);
            this.lblAddEv.TabIndex = 29;
            this.lblAddEv.Text = "ADD EVENT";
            // 
            // panelAddEvent
            // 
            this.panelAddEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.panelAddEvent.Controls.Add(this.label3);
            this.panelAddEvent.Controls.Add(this.comboBoxHourTo);
            this.panelAddEvent.Controls.Add(this.label1);
            this.panelAddEvent.Controls.Add(this.comboBoxHourFrom);
            this.panelAddEvent.Controls.Add(this.lblAddEv);
            this.panelAddEvent.Controls.Add(this.lblDate);
            this.panelAddEvent.Controls.Add(this.txtBoxEvent);
            this.panelAddEvent.Controls.Add(this.panel2);
            this.panelAddEvent.Controls.Add(this.panel1);
            this.panelAddEvent.Controls.Add(this.lblEvent);
            this.panelAddEvent.Controls.Add(this.txtBoxDate);
            this.panelAddEvent.Location = new System.Drawing.Point(3, 3);
            this.panelAddEvent.Name = "panelAddEvent";
            this.panelAddEvent.Size = new System.Drawing.Size(578, 249);
            this.panelAddEvent.TabIndex = 86;
            // 
            // comboBoxHourFrom
            // 
            this.comboBoxHourFrom.AllowDrop = true;
            this.comboBoxHourFrom.BackColor = System.Drawing.Color.White;
            this.comboBoxHourFrom.DisplayMember = "12";
            this.comboBoxHourFrom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxHourFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHourFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.comboBoxHourFrom.FocusedColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxHourFrom.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxHourFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboBoxHourFrom.Location = new System.Drawing.Point(124, 172);
            this.comboBoxHourFrom.Name = "comboBoxHourFrom";
            this.comboBoxHourFrom.Size = new System.Drawing.Size(147, 36);
            this.comboBoxHourFrom.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.comboBoxHourFrom.TabIndex = 102;
            // 
            // comboBoxHourTo
            // 
            this.comboBoxHourTo.AllowDrop = true;
            this.comboBoxHourTo.BackColor = System.Drawing.Color.White;
            this.comboBoxHourTo.DisplayMember = "12";
            this.comboBoxHourTo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxHourTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHourTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
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
            this.comboBoxHourTo.Location = new System.Drawing.Point(343, 172);
            this.comboBoxHourTo.Name = "comboBoxHourTo";
            this.comboBoxHourTo.Size = new System.Drawing.Size(179, 36);
            this.comboBoxHourTo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.comboBoxHourTo.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(287, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 31);
            this.label3.TabIndex = 106;
            this.label3.Text = "to";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox1.Image = global::Fitness_Club.Properties.Resources.Delete;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.InitialImage")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(68, 331);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(66, 30);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 107;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblMyEvents
            // 
            this.lblMyEvents.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyEvents.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMyEvents.Location = new System.Drawing.Point(173, -3);
            this.lblMyEvents.Name = "lblMyEvents";
            this.lblMyEvents.Size = new System.Drawing.Size(399, 48);
            this.lblMyEvents.TabIndex = 30;
            this.lblMyEvents.Text = "MY EVENTS ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(726, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 40);
            this.button1.TabIndex = 108;
            this.button1.Text = "Add event";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.InitialImage")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(405, 56);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(78, 51);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox2.TabIndex = 110;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.InitialImage")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(679, 56);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(78, 51);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox3.TabIndex = 111;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.InitialImage")));
            this.guna2PictureBox4.Location = new System.Drawing.Point(100, 56);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(78, 51);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.guna2PictureBox4.TabIndex = 112;
            this.guna2PictureBox4.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEventsList2);
            this.groupBox1.Controls.Add(this.listBox4);
            this.groupBox1.Controls.Add(this.guna2PictureBox4);
            this.groupBox1.Controls.Add(this.listBox3);
            this.groupBox1.Controls.Add(this.guna2PictureBox2);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.guna2PictureBox3);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Location = new System.Drawing.Point(162, 400);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(927, 336);
            this.groupBox1.TabIndex = 114;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MY EVENTS ";
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Enabled = false;
            this.listBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.listBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 31;
            this.listBox2.Items.AddRange(new object[] {
            "• Lasson Rabbi sandro\t\t",
            "• Hapoel game\t\t"});
            this.listBox2.Location = new System.Drawing.Point(21, 114);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(285, 217);
            this.listBox2.TabIndex = 115;
            // 
            // listBox3
            // 
            this.listBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.listBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox3.Enabled = false;
            this.listBox3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.listBox3.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBox3.ItemHeight = 31;
            this.listBox3.Items.AddRange(new object[] {
            "18:00-19:00",
            "21:00-23:00\t"});
            this.listBox3.Location = new System.Drawing.Point(366, 114);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(253, 217);
            this.listBox3.TabIndex = 116;
            // 
            // listBox4
            // 
            this.listBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.listBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.listBox4.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 31;
            this.listBox4.Items.AddRange(new object[] {
            "Hatalmod 30",
            "Terrner stadium"});
            this.listBox4.Location = new System.Drawing.Point(625, 114);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(266, 217);
            this.listBox4.TabIndex = 117;
            // 
            // lblEventsList2
            // 
            this.lblEventsList2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.lblEventsList2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblEventsList2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblEventsList2.Location = new System.Drawing.Point(366, 74);
            this.lblEventsList2.Name = "lblEventsList2";
            this.lblEventsList2.Size = new System.Drawing.Size(580, 273);
            this.lblEventsList2.TabIndex = 115;
            this.lblEventsList2.Text = "ok\nok";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1317, 1055);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelAllEvents);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelAddEvent);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.panelAllEvents.ResumeLayout(false);
            this.panelAddEvent.ResumeLayout(false);
            this.panelAddEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelAllEvents;
        private System.Windows.Forms.Label lblEventslist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label lblEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxEvent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAddEv;
        private System.Windows.Forms.Panel panelAddEvent;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxHourFrom;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxHourTo;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lblMyEvents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RichTextBox lblEventsList2;
    }
}