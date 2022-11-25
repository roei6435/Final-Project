namespace Fitness_Club
{
    partial class DeleteAndUpdateFrom
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
            this.panelLoading = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.circleLoading = new CircularProgressBar.CircularProgressBar();
            this.panelLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(556, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(305, 43);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "delete and update";
            // 
            // panelLoading
            // 
            this.panelLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.panelLoading.BorderRadius = 10;
            this.panelLoading.Controls.Add(this.circleLoading);
            this.panelLoading.FillColor = System.Drawing.Color.Transparent;
            this.panelLoading.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelLoading.FillColor3 = System.Drawing.Color.Transparent;
            this.panelLoading.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelLoading.Location = new System.Drawing.Point(0, 0);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(128, 122);
            this.panelLoading.TabIndex = 203;
            // 
            // circleLoading
            // 
            this.circleLoading.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circleLoading.AnimationSpeed = 2500;
            this.circleLoading.BackColor = System.Drawing.Color.Transparent;
            this.circleLoading.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleLoading.ForeColor = System.Drawing.Color.Gainsboro;
            this.circleLoading.InnerColor = System.Drawing.Color.Transparent;
            this.circleLoading.InnerMargin = 2;
            this.circleLoading.InnerWidth = -1;
            this.circleLoading.Location = new System.Drawing.Point(3, 3);
            this.circleLoading.MarqueeAnimationSpeed = 2500;
            this.circleLoading.Name = "circleLoading";
            this.circleLoading.OuterColor = System.Drawing.Color.Transparent;
            this.circleLoading.OuterMargin = 0;
            this.circleLoading.OuterWidth = 0;
            this.circleLoading.ProgressColor = System.Drawing.Color.Gainsboro;
            this.circleLoading.ProgressWidth = 6;
            this.circleLoading.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleLoading.Size = new System.Drawing.Size(117, 113);
            this.circleLoading.StartAngle = 270;
            this.circleLoading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circleLoading.SubscriptColor = System.Drawing.Color.Transparent;
            this.circleLoading.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.circleLoading.SubscriptText = "";
            this.circleLoading.SuperscriptColor = System.Drawing.Color.Transparent;
            this.circleLoading.SuperscriptMargin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.circleLoading.SuperscriptText = "";
            this.circleLoading.TabIndex = 202;
            this.circleLoading.Text = "...";
            this.circleLoading.TextMargin = new System.Windows.Forms.Padding(0);
            this.circleLoading.Value = 68;
            // 
            // DeleteAndUpdateFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1401, 656);
            this.Controls.Add(this.panelLoading);
            this.Controls.Add(this.lblTitle);
            this.Name = "DeleteAndUpdateFrom";
            this.Text = "DeleteAndUpdateFrom";
            this.Load += new System.EventHandler(this.DeleteAndUpdateFrom_Load);
            this.panelLoading.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelLoading;
        private CircularProgressBar.CircularProgressBar circleLoading;
    }
}