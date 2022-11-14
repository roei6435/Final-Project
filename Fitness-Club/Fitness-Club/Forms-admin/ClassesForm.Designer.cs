namespace Fitness_Club.Forms_admin
{
    partial class ClassesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClassesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picCompleted = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picBoxEditPicPropfile = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnSendMess = new System.Windows.Forms.Button();
            this.btnBloked = new System.Windows.Forms.Button();
            this.lblDateBornAndAge = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.comboBoxMou = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DataUsersView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ProPic = new System.Windows.Forms.DataGridViewImageColumn();
            this.active = new System.Windows.Forms.DataGridViewImageColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCompleted)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEditPicPropfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataUsersView)).BeginInit();
            this.SuspendLayout();
            // 
            // picCompleted
            // 
            this.picCompleted.Location = new System.Drawing.Point(925, 2);
            this.picCompleted.Name = "picCompleted";
            this.picCompleted.Size = new System.Drawing.Size(508, 658);
            this.picCompleted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCompleted.TabIndex = 173;
            this.picCompleted.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picBoxEditPicPropfile);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblPhone);
            this.panel1.Controls.Add(this.btnSendMess);
            this.panel1.Controls.Add(this.lblDateBornAndAge);
            this.panel1.Controls.Add(this.btnBloked);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Location = new System.Drawing.Point(57, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 241);
            this.panel1.TabIndex = 172;
            // 
            // picBoxEditPicPropfile
            // 
            this.picBoxEditPicPropfile.BackColor = System.Drawing.Color.Transparent;
            this.picBoxEditPicPropfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxEditPicPropfile.Image = global::Fitness_Club.Properties.Resources.pen;
            this.picBoxEditPicPropfile.ImageRotate = 0F;
            this.picBoxEditPicPropfile.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBoxEditPicPropfile.InitialImage")));
            this.picBoxEditPicPropfile.Location = new System.Drawing.Point(11, 4);
            this.picBoxEditPicPropfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxEditPicPropfile.Name = "picBoxEditPicPropfile";
            this.picBoxEditPicPropfile.Size = new System.Drawing.Size(24, 28);
            this.picBoxEditPicPropfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxEditPicPropfile.TabIndex = 174;
            this.picBoxEditPicPropfile.TabStop = false;
            // 
            // btnSendMess
            // 
            this.btnSendMess.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSendMess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnSendMess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMess.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnSendMess.ForeColor = System.Drawing.Color.White;
            this.btnSendMess.Image = global::Fitness_Club.Properties.Resources.messenger;
            this.btnSendMess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendMess.Location = new System.Drawing.Point(528, 104);
            this.btnSendMess.Name = "btnSendMess";
            this.btnSendMess.Size = new System.Drawing.Size(269, 42);
            this.btnSendMess.TabIndex = 173;
            this.btnSendMess.Text = "Users Registor list";
            this.btnSendMess.UseVisualStyleBackColor = false;
            // 
            // btnBloked
            // 
            this.btnBloked.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBloked.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnBloked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBloked.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnBloked.ForeColor = System.Drawing.Color.White;
            this.btnBloked.Image = global::Fitness_Club.Properties.Resources._9110980_circle_block_icon;
            this.btnBloked.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBloked.Location = new System.Drawing.Point(528, 29);
            this.btnBloked.Name = "btnBloked";
            this.btnBloked.Size = new System.Drawing.Size(276, 42);
            this.btnBloked.TabIndex = 172;
            this.btnBloked.Text = "NonActive class";
            this.btnBloked.UseVisualStyleBackColor = false;
            // 
            // lblDateBornAndAge
            // 
            this.lblDateBornAndAge.BackColor = System.Drawing.Color.Transparent;
            this.lblDateBornAndAge.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBornAndAge.ForeColor = System.Drawing.Color.Transparent;
            this.lblDateBornAndAge.Location = new System.Drawing.Point(77, 62);
            this.lblDateBornAndAge.Name = "lblDateBornAndAge";
            this.lblDateBornAndAge.Size = new System.Drawing.Size(239, 34);
            this.lblDateBornAndAge.TabIndex = 181;
            this.lblDateBornAndAge.Text = "17 users register";
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.Color.Transparent;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.Transparent;
            this.lblFullName.Location = new System.Drawing.Point(73, 4);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(257, 58);
            this.lblFullName.TabIndex = 167;
            this.lblFullName.Text = "Soccer";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(77, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(258, 32);
            this.lblEmail.TabIndex = 168;
            this.lblEmail.Text = "Room 3";
            // 
            // lblPhone
            // 
            this.lblPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Transparent;
            this.lblPhone.Location = new System.Drawing.Point(77, 149);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(236, 32);
            this.lblPhone.TabIndex = 170;
            this.lblPhone.Text = "Activity class";
            // 
            // comboBoxMou
            // 
            this.comboBoxMou.AllowDrop = true;
            this.comboBoxMou.BackColor = System.Drawing.Color.White;
            this.comboBoxMou.DisplayMember = "12";
            this.comboBoxMou.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxMou.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMou.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.comboBoxMou.FocusedColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxMou.FocusedState.BorderColor = System.Drawing.Color.RoyalBlue;
            this.comboBoxMou.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMou.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxMou.FormattingEnabled = true;
            this.comboBoxMou.IntegralHeight = false;
            this.comboBoxMou.ItemHeight = 30;
            this.comboBoxMou.Items.AddRange(new object[] {
            "Soccer",
            "Tennis",
            "Basketball",
            "Yoga"});
            this.comboBoxMou.Location = new System.Drawing.Point(57, 29);
            this.comboBoxMou.Name = "comboBoxMou";
            this.comboBoxMou.Size = new System.Drawing.Size(834, 36);
            this.comboBoxMou.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.comboBoxMou.TabIndex = 174;
            // 
            // DataUsersView
            // 
            this.DataUsersView.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DataUsersView.AllowDrop = true;
            this.DataUsersView.AllowUserToAddRows = false;
            this.DataUsersView.AllowUserToDeleteRows = false;
            this.DataUsersView.AllowUserToResizeColumns = false;
            this.DataUsersView.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gold;
            this.DataUsersView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.DataUsersView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataUsersView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DataUsersView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataUsersView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataUsersView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataUsersView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.DataUsersView.ColumnHeadersHeight = 50;
            this.DataUsersView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProPic,
            this.active,
            this.fullName,
            this.userId,
            this.lastUpdate});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataUsersView.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataUsersView.EnableHeadersVisualStyles = false;
            this.DataUsersView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DataUsersView.Location = new System.Drawing.Point(40, 382);
            this.DataUsersView.MultiSelect = false;
            this.DataUsersView.Name = "DataUsersView";
            this.DataUsersView.ReadOnly = true;
            this.DataUsersView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataUsersView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.DataUsersView.RowHeadersVisible = false;
            this.DataUsersView.RowHeadersWidth = 51;
            this.DataUsersView.RowTemplate.Height = 50;
            this.DataUsersView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataUsersView.Size = new System.Drawing.Size(879, 196);
            this.DataUsersView.TabIndex = 176;
            this.DataUsersView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataUsersView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DataUsersView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataUsersView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DataUsersView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
            this.DataUsersView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DataUsersView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.DataUsersView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataUsersView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataUsersView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataUsersView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataUsersView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataUsersView.ThemeStyle.HeaderStyle.Height = 50;
            this.DataUsersView.ThemeStyle.ReadOnly = true;
            this.DataUsersView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataUsersView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataUsersView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataUsersView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataUsersView.ThemeStyle.RowsStyle.Height = 50;
            this.DataUsersView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DataUsersView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(128)))));
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
            // active
            // 
            this.active.FillWeight = 8.51573F;
            this.active.HeaderText = "";
            this.active.MinimumWidth = 6;
            this.active.Name = "active";
            this.active.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.FillWeight = 150.4193F;
            this.fullName.HeaderText = "";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // userId
            // 
            this.userId.HeaderText = "Column1";
            this.userId.MinimumWidth = 6;
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Visible = false;
            // 
            // lastUpdate
            // 
            this.lastUpdate.FillWeight = 92.93832F;
            this.lastUpdate.HeaderText = "";
            this.lastUpdate.MinimumWidth = 6;
            this.lastUpdate.Name = "lastUpdate";
            this.lastUpdate.ReadOnly = true;
            // 
            // btnPrev
            // 
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(12, 584);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(192, 42);
            this.btnPrev.TabIndex = 177;
            this.btnPrev.Text = "Previous";
            this.btnPrev.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(699, 584);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(192, 42);
            this.btnNext.TabIndex = 178;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // ClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1401, 656);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.DataUsersView);
            this.Controls.Add(this.comboBoxMou);
            this.Controls.Add(this.picCompleted);
            this.Controls.Add(this.panel1);
            this.Name = "ClassesForm";
            this.Text = "Classes";
            this.Load += new System.EventHandler(this.Classes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCompleted)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEditPicPropfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataUsersView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDateBornAndAge;
        private System.Windows.Forms.Button btnSendMess;
        private System.Windows.Forms.Button btnBloked;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picCompleted;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxEditPicPropfile;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxMou;
        private Guna.UI2.WinForms.Guna2DataGridView DataUsersView;
        private System.Windows.Forms.DataGridViewImageColumn ProPic;
        private System.Windows.Forms.DataGridViewImageColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdate;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private System.Windows.Forms.Button btnNext;
    }
}