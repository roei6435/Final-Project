namespace Fitness_Club
{
    partial class BubbleOfTweet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BubbleOfTweet));
            this.lblFname = new System.Windows.Forms.Label();
            this.panelBubbleData = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panelLikes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTitleListOfLikes = new System.Windows.Forms.Label();
            this.panelLine = new System.Windows.Forms.Panel();
            this.panelButtons = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.picLikeOn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.hidePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.picLikeOf = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.panelPersonData = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.profilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelBubbleData.SuspendLayout();
            this.panelLikes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLikeOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLikeOf)).BeginInit();
            this.panelPersonData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFname
            // 
            this.lblFname.BackColor = System.Drawing.Color.Transparent;
            this.lblFname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblFname.Location = new System.Drawing.Point(3, 86);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(96, 27);
            this.lblFname.TabIndex = 180;
            this.lblFname.Text = " FName";
            // 
            // panelBubbleData
            // 
            this.panelBubbleData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBubbleData.BorderColor = System.Drawing.Color.RosyBrown;
            this.panelBubbleData.BorderRadius = 40;
            this.panelBubbleData.Controls.Add(this.panelLikes);
            this.panelBubbleData.Controls.Add(this.panelButtons);
            this.panelBubbleData.Controls.Add(this.lblContent);
            this.panelBubbleData.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelBubbleData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBubbleData.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBubbleData.FillColor3 = System.Drawing.Color.Transparent;
            this.panelBubbleData.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBubbleData.Location = new System.Drawing.Point(102, 0);
            this.panelBubbleData.Name = "panelBubbleData";
            this.panelBubbleData.Size = new System.Drawing.Size(734, 111);
            this.panelBubbleData.TabIndex = 178;
  
            // 
            // panelLikes
            // 
            this.panelLikes.AllowDrop = true;
            this.panelLikes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLikes.AutoScroll = true;
            this.panelLikes.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.panelLikes.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.panelLikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelLikes.Controls.Add(this.btnBack);
            this.panelLikes.Controls.Add(this.lblTitleListOfLikes);
            this.panelLikes.Controls.Add(this.panelLine);
            this.panelLikes.Location = new System.Drawing.Point(3, 1);
            this.panelLikes.Name = "panelLikes";
            this.panelLikes.Size = new System.Drawing.Size(728, 107);
            this.panelLikes.TabIndex = 211;
            this.panelLikes.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = global::Fitness_Club.Properties.Resources.back_icon;
            this.btnBack.ImageRotate = 0F;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnBack.Size = new System.Drawing.Size(51, 37);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 198;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitleListOfLikes
            // 
            this.lblTitleListOfLikes.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleListOfLikes.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleListOfLikes.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleListOfLikes.Location = new System.Drawing.Point(60, 0);
            this.lblTitleListOfLikes.Name = "lblTitleListOfLikes";
            this.lblTitleListOfLikes.Size = new System.Drawing.Size(551, 43);
            this.lblTitleListOfLikes.TabIndex = 197;
            this.lblTitleListOfLikes.Text = "Liked this tweet by";
            // 
            // panelLine
            // 
            this.panelLine.BackColor = System.Drawing.Color.White;
            this.panelLine.Location = new System.Drawing.Point(3, 47);
            this.panelLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLine.Name = "panelLine";
            this.panelLine.Size = new System.Drawing.Size(686, 2);
            this.panelLine.TabIndex = 199;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelButtons.BorderColor = System.Drawing.Color.RosyBrown;
            this.panelButtons.BorderRadius = 40;
            this.panelButtons.Controls.Add(this.picLikeOn);
            this.panelButtons.Controls.Add(this.lblTime);
            this.panelButtons.Controls.Add(this.hidePic);
            this.panelButtons.Controls.Add(this.picLikeOf);
            this.panelButtons.Controls.Add(this.lblCounter);
            this.panelButtons.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelButtons.FillColor = System.Drawing.Color.Transparent;
            this.panelButtons.FillColor2 = System.Drawing.Color.Transparent;
            this.panelButtons.FillColor3 = System.Drawing.Color.Transparent;
            this.panelButtons.FillColor4 = System.Drawing.Color.Transparent;
            this.panelButtons.Location = new System.Drawing.Point(3, 48);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(674, 47);
            this.panelButtons.TabIndex = 182;
            // 
            // picLikeOn
            // 
            this.picLikeOn.BackColor = System.Drawing.Color.Transparent;
            this.picLikeOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLikeOn.Image = global::Fitness_Club.Properties.Resources.likeonn;
            this.picLikeOn.ImageRotate = 0F;
            this.picLikeOn.Location = new System.Drawing.Point(560, 2);
            this.picLikeOn.Name = "picLikeOn";
            this.picLikeOn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picLikeOn.Size = new System.Drawing.Size(25, 25);
            this.picLikeOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLikeOn.TabIndex = 187;
            this.picLikeOn.TabStop = false;
            this.picLikeOn.Visible = false;
            this.picLikeOn.Click += new System.EventHandler(this.picLikeOn_Click);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(12, 3);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(60, 27);
            this.lblTime.TabIndex = 173;
            this.lblTime.Text = "20:11";
            // 
            // hidePic
            // 
            this.hidePic.BackColor = System.Drawing.Color.Transparent;
            this.hidePic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hidePic.Image = ((System.Drawing.Image)(resources.GetObject("hidePic.Image")));
            this.hidePic.ImageRotate = 0F;
            this.hidePic.Location = new System.Drawing.Point(590, 3);
            this.hidePic.Name = "hidePic";
            this.hidePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.hidePic.Size = new System.Drawing.Size(27, 27);
            this.hidePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hidePic.TabIndex = 185;
            this.hidePic.TabStop = false;
            this.hidePic.Click += new System.EventHandler(this.hidePic_Click);
            // 
            // picLikeOf
            // 
            this.picLikeOf.BackColor = System.Drawing.Color.Transparent;
            this.picLikeOf.Image = ((System.Drawing.Image)(resources.GetObject("picLikeOf.Image")));
            this.picLikeOf.ImageRotate = 0F;
            this.picLikeOf.Location = new System.Drawing.Point(561, 3);
            this.picLikeOf.Name = "picLikeOf";
            this.picLikeOf.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picLikeOf.Size = new System.Drawing.Size(25, 25);
            this.picLikeOf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLikeOf.TabIndex = 184;
            this.picLikeOf.TabStop = false;
            this.picLikeOf.Click += new System.EventHandler(this.picLikeOf_Click);
            // 
            // lblCounter
            // 
            this.lblCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCounter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCounter.Location = new System.Drawing.Point(563, 26);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(37, 16);
            this.lblCounter.TabIndex = 186;
            this.lblCounter.Text = "4";
            this.lblCounter.Visible = false;
            this.lblCounter.Click += new System.EventHandler(this.lblCounter_Click);
            // 
            // lblContent
            // 
            this.lblContent.BackColor = System.Drawing.Color.Transparent;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblContent.Location = new System.Drawing.Point(27, 9);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(650, 36);
            this.lblContent.TabIndex = 174;
            this.lblContent.Text = "Great news for Hapoel Holon: just before the start off \r\n\r\n\r\n";
            // 
            // panelPersonData
            // 
            this.panelPersonData.BackColor = System.Drawing.Color.Transparent;
            this.panelPersonData.BorderColor = System.Drawing.Color.RosyBrown;
            this.panelPersonData.BorderRadius = 40;
            this.panelPersonData.Controls.Add(this.profilePic);
            this.panelPersonData.Controls.Add(this.lblFname);
            this.panelPersonData.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panelPersonData.FillColor = System.Drawing.Color.Transparent;
            this.panelPersonData.FillColor2 = System.Drawing.Color.Transparent;
            this.panelPersonData.FillColor3 = System.Drawing.Color.Transparent;
            this.panelPersonData.FillColor4 = System.Drawing.Color.Transparent;
            this.panelPersonData.Location = new System.Drawing.Point(3, 0);
            this.panelPersonData.Name = "panelPersonData";
            this.panelPersonData.Size = new System.Drawing.Size(96, 111);
            this.panelPersonData.TabIndex = 183;
       
            // 
            // profilePic
            // 
            this.profilePic.BackColor = System.Drawing.Color.Transparent;
            this.profilePic.Image = ((System.Drawing.Image)(resources.GetObject("profilePic.Image")));
            this.profilePic.ImageRotate = 0F;
            this.profilePic.Location = new System.Drawing.Point(3, 3);
            this.profilePic.Name = "profilePic";
            this.profilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePic.Size = new System.Drawing.Size(96, 87);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 179;
            this.profilePic.TabStop = false;
            // 
            // BubbleOfTweet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.panelPersonData);
            this.Controls.Add(this.panelBubbleData);
            this.Name = "BubbleOfTweet";
            this.Size = new System.Drawing.Size(838, 113);
            this.Load += new System.EventHandler(this.UserControlBubbleSmall_Load);
            this.panelBubbleData.ResumeLayout(false);
            this.panelLikes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLikeOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hidePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLikeOf)).EndInit();
            this.panelPersonData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFname;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePic;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelBubbleData;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblContent;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picLikeOn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picLikeOf;
        private System.Windows.Forms.Label lblCounter;
        private Guna.UI2.WinForms.Guna2CirclePictureBox hidePic;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelButtons;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelPersonData;
        private System.Windows.Forms.FlowLayoutPanel panelLikes;
        private System.Windows.Forms.Label lblTitleListOfLikes;
        private Guna.UI2.WinForms.Guna2CirclePictureBox btnBack;
        private System.Windows.Forms.Panel panelLine;
    }
}
