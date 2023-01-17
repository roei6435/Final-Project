namespace Fitness_Club
{
    partial class AdminScreen
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminScreen));
            this.panelManu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblUserNameAndStatus = new System.Windows.Forms.Label();
            this.membersContiener = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.penelHome = new System.Windows.Forms.Panel();
            this.btnSenderObject = new System.Windows.Forms.Button();
            this.circleTimer = new CircularProgressBar.CircularProgressBar();
            this.lblTitleWellcome = new System.Windows.Forms.Label();
            this.timerSideManu = new System.Windows.Forms.Timer(this.components);
            this.MembersTimer = new System.Windows.Forms.Timer(this.components);
            this.panelSearch = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelNotFound = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataViewPersons = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxError = new Guna.UI2.WinForms.Guna2PictureBox();
            this.picBoxSharch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAreaClasses = new System.Windows.Forms.Button();
            this.profilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSideManu = new System.Windows.Forms.Button();
            this.btnMyAcc = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnClassesStat = new System.Windows.Forms.Button();
            this.btnDataAnalysis = new System.Windows.Forms.Button();
            this.btnAdminStatistics = new System.Windows.Forms.Button();
            this.btnClientsStat = new System.Windows.Forms.Button();
            this.btnCalendar = new System.Windows.Forms.Button();
            this.pictureInidcation = new System.Windows.Forms.PictureBox();
            this.panelManu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.membersContiener.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.penelHome.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.panelNotFound.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSharch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInidcation)).BeginInit();
            this.SuspendLayout();
            // 
            // panelManu
            // 
            this.panelManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelManu.Controls.Add(this.btnHome);
            this.panelManu.Controls.Add(this.btnAreaClasses);
            this.panelManu.Controls.Add(this.panelLogo);
            this.panelManu.Controls.Add(this.btnLogOut);
            this.panelManu.Controls.Add(this.btnSideManu);
            this.panelManu.Controls.Add(this.btnMyAcc);
            this.panelManu.Controls.Add(this.btnAbout);
            this.panelManu.Controls.Add(this.membersContiener);
            this.panelManu.Controls.Add(this.btnCalendar);
            this.panelManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.panelManu.Location = new System.Drawing.Point(0, 0);
            this.panelManu.Margin = new System.Windows.Forms.Padding(4);
            this.panelManu.MaximumSize = new System.Drawing.Size(227, 800);
            this.panelManu.MinimumSize = new System.Drawing.Size(75, 719);
            this.panelManu.Name = "panelManu";
            this.panelManu.Size = new System.Drawing.Size(75, 719);
            this.panelManu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.profilePic);
            this.panelLogo.Controls.Add(this.lblUserNameAndStatus);
            this.panelLogo.Location = new System.Drawing.Point(0, -7);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(266, 83);
            this.panelLogo.TabIndex = 87;
            // 
            // lblUserNameAndStatus
            // 
            this.lblUserNameAndStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameAndStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserNameAndStatus.Location = new System.Drawing.Point(81, 18);
            this.lblUserNameAndStatus.Name = "lblUserNameAndStatus";
            this.lblUserNameAndStatus.Size = new System.Drawing.Size(146, 57);
            this.lblUserNameAndStatus.TabIndex = 88;
            this.lblUserNameAndStatus.Text = "Roei ben david\r\n         admin\r\n";
            // 
            // membersContiener
            // 
            this.membersContiener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.membersContiener.Controls.Add(this.btnClassesStat);
            this.membersContiener.Controls.Add(this.btnDataAnalysis);
            this.membersContiener.Controls.Add(this.btnAdminStatistics);
            this.membersContiener.Controls.Add(this.btnClientsStat);
            this.membersContiener.Location = new System.Drawing.Point(2, 277);
            this.membersContiener.MaximumSize = new System.Drawing.Size(255, 274);
            this.membersContiener.MinimumSize = new System.Drawing.Size(255, 62);
            this.membersContiener.Name = "membersContiener";
            this.membersContiener.Size = new System.Drawing.Size(255, 79);
            this.membersContiener.TabIndex = 88;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Location = new System.Drawing.Point(73, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1190, 76);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(1072, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(64, 76);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1136, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 76);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // penelHome
            // 
            this.penelHome.AutoSize = true;
            this.penelHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.penelHome.Controls.Add(this.label2);
            this.penelHome.Controls.Add(this.btnSenderObject);
            this.penelHome.Controls.Add(this.circleTimer);
            this.penelHome.Controls.Add(this.lblTitleWellcome);
            this.penelHome.Controls.Add(this.pictureInidcation);
            this.penelHome.Location = new System.Drawing.Point(55, 76);
            this.penelHome.Margin = new System.Windows.Forms.Padding(0);
            this.penelHome.Name = "penelHome";
            this.penelHome.Size = new System.Drawing.Size(1659, 803);
            this.penelHome.TabIndex = 0;

            // 
            // btnSenderObject
            // 
            this.btnSenderObject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSenderObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSenderObject.FlatAppearance.BorderSize = 0;
            this.btnSenderObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSenderObject.Font = new System.Drawing.Font("Segoe UI", 11.8F);
            this.btnSenderObject.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSenderObject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSenderObject.Location = new System.Drawing.Point(50, 492);
            this.btnSenderObject.Margin = new System.Windows.Forms.Padding(4);
            this.btnSenderObject.Name = "btnSenderObject";
            this.btnSenderObject.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSenderObject.Size = new System.Drawing.Size(45, 70);
            this.btnSenderObject.TabIndex = 258;
            this.btnSenderObject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSenderObject.UseVisualStyleBackColor = false;
            this.btnSenderObject.Visible = false;
            // 
            // circleTimer
            // 
            this.circleTimer.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CubicEaseInOut;
            this.circleTimer.AnimationSpeed = 2500;
            this.circleTimer.BackColor = System.Drawing.Color.Transparent;
            this.circleTimer.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.circleTimer.ForeColor = System.Drawing.Color.Gainsboro;
            this.circleTimer.InnerColor = System.Drawing.Color.Transparent;
            this.circleTimer.InnerMargin = 2;
            this.circleTimer.InnerWidth = -1;
            this.circleTimer.Location = new System.Drawing.Point(344, 224);
            this.circleTimer.MarqueeAnimationSpeed = 2500;
            this.circleTimer.Name = "circleTimer";
            this.circleTimer.OuterColor = System.Drawing.Color.Transparent;
            this.circleTimer.OuterMargin = 0;
            this.circleTimer.OuterWidth = 0;
            this.circleTimer.ProgressColor = System.Drawing.Color.Gainsboro;
            this.circleTimer.ProgressWidth = 6;
            this.circleTimer.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleTimer.Size = new System.Drawing.Size(136, 134);
            this.circleTimer.StartAngle = 270;
            this.circleTimer.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circleTimer.SubscriptColor = System.Drawing.Color.Transparent;
            this.circleTimer.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circleTimer.SubscriptText = "";
            this.circleTimer.SuperscriptColor = System.Drawing.Color.Transparent;
            this.circleTimer.SuperscriptMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.circleTimer.SuperscriptText = "";
            this.circleTimer.TabIndex = 256;
            this.circleTimer.TextMargin = new System.Windows.Forms.Padding(0);
            this.circleTimer.Value = 100;
            // 
            // lblTitleWellcome
            // 
            this.lblTitleWellcome.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleWellcome.Font = new System.Drawing.Font("Segoe UI", 34.8F, System.Drawing.FontStyle.Bold);
            this.lblTitleWellcome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleWellcome.Location = new System.Drawing.Point(179, 14);
            this.lblTitleWellcome.Name = "lblTitleWellcome";
            this.lblTitleWellcome.Size = new System.Drawing.Size(511, 89);
            this.lblTitleWellcome.TabIndex = 254;
            this.lblTitleWellcome.Text = "Wellcome Roei!";
            // 
            // timerSideManu
            // 
            this.timerSideManu.Interval = 1;
            this.timerSideManu.Tick += new System.EventHandler(this.timerSideMenu_Tick);
            // 
            // MembersTimer
            // 
            this.MembersTimer.Interval = 1;
            this.MembersTimer.Tick += new System.EventHandler(this.MembersTimer_Tick);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelSearch.BorderColor = System.Drawing.Color.White;
            this.panelSearch.BorderRadius = 40;
            this.panelSearch.Controls.Add(this.panelNotFound);
            this.panelSearch.Controls.Add(this.picBoxSharch);
            this.panelSearch.Controls.Add(this.textBoxFind);
            this.panelSearch.Controls.Add(this.panel1);
            this.panelSearch.Controls.Add(this.DataViewPersons);
            this.panelSearch.Controls.Add(this.btnAddUser);
            this.panelSearch.CustomizableEdges.BottomLeft = false;
            this.panelSearch.CustomizableEdges.BottomRight = false;
            this.panelSearch.CustomizableEdges.TopLeft = false;
            this.panelSearch.CustomizableEdges.TopRight = false;
            this.panelSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelSearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelSearch.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelSearch.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelSearch.Location = new System.Drawing.Point(234, 6);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(447, 62);
            this.panelSearch.TabIndex = 207;
            // 
            // panelNotFound
            // 
            this.panelNotFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelNotFound.Controls.Add(this.picBoxError);
            this.panelNotFound.Controls.Add(this.label1);
            this.panelNotFound.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelNotFound.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelNotFound.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelNotFound.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelNotFound.Location = new System.Drawing.Point(10, 100);
            this.panelNotFound.Name = "panelNotFound";
            this.panelNotFound.Size = new System.Drawing.Size(413, 140);
            this.panelNotFound.TabIndex = 169;
            this.panelNotFound.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(149, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 117);
            this.label1.TabIndex = 173;
            this.label1.Text = "Sorry, The user has not been identified...\r\n";
            // 
            // textBoxFind
            // 
            this.textBoxFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.textBoxFind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFind.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxFind.ForeColor = System.Drawing.Color.Gainsboro;
            this.textBoxFind.Location = new System.Drawing.Point(10, 8);
            this.textBoxFind.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(372, 31);
            this.textBoxFind.TabIndex = 159;
            this.textBoxFind.Text = "Search";
            this.textBoxFind.Click += new System.EventHandler(this.textBoxFind_Click);
            this.textBoxFind.TextChanged += new System.EventHandler(this.textBoxFind_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(3, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 1);
            this.panel1.TabIndex = 158;
            // 
            // DataViewPersons
            // 
            this.DataViewPersons.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DataViewPersons.AllowUserToAddRows = false;
            this.DataViewPersons.AllowUserToDeleteRows = false;
            this.DataViewPersons.AllowUserToResizeColumns = false;
            this.DataViewPersons.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            this.DataViewPersons.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataViewPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataViewPersons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DataViewPersons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataViewPersons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataViewPersons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewPersons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataViewPersons.ColumnHeadersHeight = 5;
            this.DataViewPersons.ColumnHeadersVisible = false;
            this.DataViewPersons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProPic,
            this.fullName,
            this.userId,
            this.lastUpdate});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewPersons.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataViewPersons.EnableHeadersVisualStyles = false;
            this.DataViewPersons.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DataViewPersons.Location = new System.Drawing.Point(10, 86);
            this.DataViewPersons.MultiSelect = false;
            this.DataViewPersons.Name = "DataViewPersons";
            this.DataViewPersons.ReadOnly = true;
            this.DataViewPersons.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewPersons.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataViewPersons.RowHeadersVisible = false;
            this.DataViewPersons.RowHeadersWidth = 51;
            this.DataViewPersons.RowTemplate.Height = 50;
            this.DataViewPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataViewPersons.Size = new System.Drawing.Size(413, 342);
            this.DataViewPersons.TabIndex = 157;
            this.DataViewPersons.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataViewPersons.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DataViewPersons.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataViewPersons.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DataViewPersons.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.DataViewPersons.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DataViewPersons.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DataViewPersons.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataViewPersons.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataViewPersons.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewPersons.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataViewPersons.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataViewPersons.ThemeStyle.HeaderStyle.Height = 5;
            this.DataViewPersons.ThemeStyle.ReadOnly = true;
            this.DataViewPersons.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataViewPersons.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataViewPersons.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewPersons.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataViewPersons.ThemeStyle.RowsStyle.Height = 50;
            this.DataViewPersons.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DataViewPersons.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.DataViewPersons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewPersons_CellClick);
            // 
            // ProPic
            // 
            this.ProPic.FillWeight = 37.78442F;
            this.ProPic.HeaderText = "";
            this.ProPic.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ProPic.MinimumWidth = 6;
            this.ProPic.Name = "ProPic";
            this.ProPic.ReadOnly = true;
            this.ProPic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fullName
            // 
            this.fullName.FillWeight = 150.4193F;
            this.fullName.HeaderText = "";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // userId
            // 
            this.userId.HeaderText = "Column1";
            this.userId.MinimumWidth = 6;
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.userId.Visible = false;
            // 
            // lastUpdate
            // 
            this.lastUpdate.FillWeight = 92.93832F;
            this.lastUpdate.HeaderText = "";
            this.lastUpdate.MinimumWidth = 6;
            this.lastUpdate.Name = "lastUpdate";
            this.lastUpdate.ReadOnly = true;
            this.lastUpdate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(186, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 113);
            this.label2.TabIndex = 259;
            this.label2.Text = "We will start working right away!\r\nBefore that we wish you a pleasant work from o" +
    "ur fitness center!";
            // 
            // picBoxError
            // 
            this.picBoxError.BackColor = System.Drawing.Color.Transparent;
            this.picBoxError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxError.Image = global::Fitness_Club.Properties.Resources._9054327_bx_comment_error_icon__1_;
            this.picBoxError.ImageRotate = 0F;
            this.picBoxError.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxError.InitialImage")));
            this.picBoxError.Location = new System.Drawing.Point(16, 21);
            this.picBoxError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxError.Name = "picBoxError";
            this.picBoxError.Size = new System.Drawing.Size(127, 117);
            this.picBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxError.TabIndex = 169;
            this.picBoxError.TabStop = false;
            // 
            // picBoxSharch
            // 
            this.picBoxSharch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxSharch.Image = global::Fitness_Club.Properties.Resources.serch;
            this.picBoxSharch.ImageRotate = 0F;
            this.picBoxSharch.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxSharch.InitialImage")));
            this.picBoxSharch.Location = new System.Drawing.Point(398, 5);
            this.picBoxSharch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxSharch.Name = "picBoxSharch";
            this.picBoxSharch.Size = new System.Drawing.Size(46, 41);
            this.picBoxSharch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxSharch.TabIndex = 160;
            this.picBoxSharch.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddUser.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Image = global::Fitness_Club.Properties.Resources._2202248_account_add_avatar_human_man_icon;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(3, 428);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAddUser.Size = new System.Drawing.Size(439, 53);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "    Register a new user for the fitness center";
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.Image = global::Fitness_Club.Properties.Resources.JOMEiCON;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(148, 76);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(79, 51);
            this.btnHome.TabIndex = 207;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnAreaClasses
            // 
            this.btnAreaClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAreaClasses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAreaClasses.FlatAppearance.BorderSize = 0;
            this.btnAreaClasses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreaClasses.Font = new System.Drawing.Font("Segoe UI", 11.8F);
            this.btnAreaClasses.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAreaClasses.Image = global::Fitness_Club.Properties.Resources.Clients2;
            this.btnAreaClasses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAreaClasses.Location = new System.Drawing.Point(-4, 355);
            this.btnAreaClasses.Margin = new System.Windows.Forms.Padding(4);
            this.btnAreaClasses.Name = "btnAreaClasses";
            this.btnAreaClasses.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAreaClasses.Size = new System.Drawing.Size(264, 73);
            this.btnAreaClasses.TabIndex = 207;
            this.btnAreaClasses.Text = "        Area classes";
            this.btnAreaClasses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAreaClasses.UseVisualStyleBackColor = false;
            this.btnAreaClasses.Click += new System.EventHandler(this.btnAreaClasses_Click);
            // 
            // profilePic
            // 
            this.profilePic.Image = global::Fitness_Club.Properties.Resources.defult_pro_pic2;
            this.profilePic.ImageRotate = 0F;
            this.profilePic.Location = new System.Drawing.Point(3, 13);
            this.profilePic.Name = "profilePic";
            this.profilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePic.Size = new System.Drawing.Size(69, 65);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 88;
            this.profilePic.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLogOut.Image = global::Fitness_Club.Properties.Resources.LOGOUTT;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(78, 75);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnLogOut.Size = new System.Drawing.Size(72, 52);
            this.btnLogOut.TabIndex = 208;
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSideManu
            // 
            this.btnSideManu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSideManu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideManu.FlatAppearance.BorderSize = 0;
            this.btnSideManu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideManu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSideManu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSideManu.Image = global::Fitness_Club.Properties.Resources.manu2;
            this.btnSideManu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSideManu.Location = new System.Drawing.Point(0, 75);
            this.btnSideManu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSideManu.Name = "btnSideManu";
            this.btnSideManu.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSideManu.Size = new System.Drawing.Size(80, 52);
            this.btnSideManu.TabIndex = 90;
            this.btnSideManu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSideManu.UseVisualStyleBackColor = false;
            this.btnSideManu.Click += new System.EventHandler(this.btnSideManu_Click);
            // 
            // btnMyAcc
            // 
            this.btnMyAcc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnMyAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyAcc.FlatAppearance.BorderSize = 0;
            this.btnMyAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyAcc.Font = new System.Drawing.Font("Segoe UI", 11.8F);
            this.btnMyAcc.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMyAcc.Image = global::Fitness_Club.Properties.Resources.usersMengment2;
            this.btnMyAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyAcc.Location = new System.Drawing.Point(-4, 129);
            this.btnMyAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnMyAcc.Name = "btnMyAcc";
            this.btnMyAcc.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnMyAcc.Size = new System.Drawing.Size(276, 70);
            this.btnMyAcc.TabIndex = 91;
            this.btnMyAcc.Text = "      My account";
            this.btnMyAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyAcc.UseVisualStyleBackColor = false;
            this.btnMyAcc.Click += new System.EventHandler(this.btnMyAcc_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 11.8F);
            this.btnAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(0, 432);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(267, 70);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "        About";
            this.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnClassesStat
            // 
            this.btnClassesStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnClassesStat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClassesStat.FlatAppearance.BorderSize = 0;
            this.btnClassesStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassesStat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClassesStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClassesStat.Image = global::Fitness_Club.Properties.Resources._315755_soccer_court_icon;
            this.btnClassesStat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClassesStat.Location = new System.Drawing.Point(-2, 213);
            this.btnClassesStat.Margin = new System.Windows.Forms.Padding(4);
            this.btnClassesStat.Name = "btnClassesStat";
            this.btnClassesStat.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnClassesStat.Size = new System.Drawing.Size(266, 70);
            this.btnClassesStat.TabIndex = 209;
            this.btnClassesStat.Text = "       Classes";
            this.btnClassesStat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClassesStat.UseVisualStyleBackColor = false;
            this.btnClassesStat.Click += new System.EventHandler(this.btnClassesStat_Click);
            // 
            // btnDataAnalysis
            // 
            this.btnDataAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnDataAnalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDataAnalysis.FlatAppearance.BorderSize = 0;
            this.btnDataAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataAnalysis.Font = new System.Drawing.Font("Segoe UI", 11.8F);
            this.btnDataAnalysis.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDataAnalysis.Image = global::Fitness_Club.Properties.Resources.NEWANALITCS;
            this.btnDataAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataAnalysis.Location = new System.Drawing.Point(-3, 0);
            this.btnDataAnalysis.Margin = new System.Windows.Forms.Padding(4);
            this.btnDataAnalysis.Name = "btnDataAnalysis";
            this.btnDataAnalysis.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDataAnalysis.Size = new System.Drawing.Size(266, 75);
            this.btnDataAnalysis.TabIndex = 6;
            this.btnDataAnalysis.Text = "        Data analysis ▼";
            this.btnDataAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDataAnalysis.UseVisualStyleBackColor = false;
            this.btnDataAnalysis.Click += new System.EventHandler(this.btnUserMengement_Click);
            // 
            // btnAdminStatistics
            // 
            this.btnAdminStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAdminStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminStatistics.FlatAppearance.BorderSize = 0;
            this.btnAdminStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminStatistics.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdminStatistics.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAdminStatistics.Image = global::Fitness_Club.Properties.Resources.MANAGE;
            this.btnAdminStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminStatistics.Location = new System.Drawing.Point(-2, 74);
            this.btnAdminStatistics.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdminStatistics.Name = "btnAdminStatistics";
            this.btnAdminStatistics.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAdminStatistics.Size = new System.Drawing.Size(266, 70);
            this.btnAdminStatistics.TabIndex = 207;
            this.btnAdminStatistics.Text = "       Administrators";
            this.btnAdminStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdminStatistics.UseVisualStyleBackColor = false;
            this.btnAdminStatistics.Click += new System.EventHandler(this.btnAdminStatistics_Click);
            // 
            // btnClientsStat
            // 
            this.btnClientsStat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnClientsStat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientsStat.FlatAppearance.BorderSize = 0;
            this.btnClientsStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientsStat.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnClientsStat.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientsStat.Image = global::Fitness_Club.Properties.Resources._3533397_clients_customer_market_marketing_segment_icon;
            this.btnClientsStat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientsStat.Location = new System.Drawing.Point(-2, 144);
            this.btnClientsStat.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientsStat.Name = "btnClientsStat";
            this.btnClientsStat.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnClientsStat.Size = new System.Drawing.Size(266, 70);
            this.btnClientsStat.TabIndex = 208;
            this.btnClientsStat.Text = "       Clients";
            this.btnClientsStat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientsStat.UseVisualStyleBackColor = false;
            this.btnClientsStat.Click += new System.EventHandler(this.btnClientsStat_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Segoe UI", 11.8F);
            this.btnCalendar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCalendar.Image = global::Fitness_Club.Properties.Resources.calendar;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(-1, 203);
            this.btnCalendar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnCalendar.Size = new System.Drawing.Size(266, 70);
            this.btnCalendar.TabIndex = 89;
            this.btnCalendar.Text = "        Calendar";
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = false;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalandar_Click);
            // 
            // pictureInidcation
            // 
            this.pictureInidcation.Location = new System.Drawing.Point(759, -1);
            this.pictureInidcation.Name = "pictureInidcation";
            this.pictureInidcation.Size = new System.Drawing.Size(449, 625);
            this.pictureInidcation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInidcation.TabIndex = 91;
            this.pictureInidcation.TabStop = false;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1264, 694);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelManu);
            this.Controls.Add(this.penelHome);
            this.Controls.Add(this.panelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1282, 741);
            this.MinimumSize = new System.Drawing.Size(1055, 580);
            this.Name = "AdminScreen";
            this.Padding = new System.Windows.Forms.Padding(255, 0, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin-Screen ";
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.panelManu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.membersContiener.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.penelHome.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelNotFound.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataViewPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSharch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInidcation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelManu;
        private System.Windows.Forms.Button btnDataAnalysis;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel penelHome;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePic;
        private System.Windows.Forms.Label lblUserNameAndStatus;
        private System.Windows.Forms.Timer timerSideManu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel membersContiener;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Timer MembersTimer;
        private System.Windows.Forms.Button btnCalendar;
        private System.Windows.Forms.Button btnMyAcc;
        private System.Windows.Forms.Button btnClassesStat;
        private System.Windows.Forms.Button btnClientsStat;
        private System.Windows.Forms.Button btnAdminStatistics;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelSearch;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelNotFound;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxError;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxSharch;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView DataViewPersons;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSideManu;
        private System.Windows.Forms.Button btnAreaClasses;
        private System.Windows.Forms.DataGridViewImageColumn ProPic;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdate;
        private System.Windows.Forms.Label lblTitleWellcome;
        private CircularProgressBar.CircularProgressBar circleTimer;
        private System.Windows.Forms.Button btnSenderObject;
        private System.Windows.Forms.PictureBox pictureInidcation;
        private System.Windows.Forms.Label label2;
    }
}