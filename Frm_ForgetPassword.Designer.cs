namespace Hot_Chile_Restaurant
{
    partial class Frm_ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ForgetPassword));
            this.BtnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.PnlTitleBar = new System.Windows.Forms.Panel();
            this.LblChangePassword = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LblMsgUID = new System.Windows.Forms.Label();
            this.TxtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtUID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblUID = new System.Windows.Forms.Label();
            this.TxtConfPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblPassNotSameMsg = new System.Windows.Forms.Label();
            this.BtnContinue = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.PnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClose
            // 
            this.BtnClose.ActiveImage = null;
            this.BtnClose.AllowAnimations = true;
            this.BtnClose.AllowBuffering = false;
            this.BtnClose.AllowZooming = true;
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.BackColor = System.Drawing.Color.Transparent;
            this.BtnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.ErrorImage")));
            this.BtnClose.FadeWhenInactive = false;
            this.BtnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageActive = null;
            this.BtnClose.ImageLocation = null;
            this.BtnClose.ImageMargin = 5;
            this.BtnClose.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnClose.ImageZoomSize = new System.Drawing.Size(35, 35);
            this.BtnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnClose.InitialImage")));
            this.BtnClose.Location = new System.Drawing.Point(277, 5);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0;
            this.BtnClose.ShowActiveImage = true;
            this.BtnClose.ShowCursorChanges = true;
            this.BtnClose.ShowImageBorders = true;
            this.BtnClose.ShowSizeMarkers = false;
            this.BtnClose.Size = new System.Drawing.Size(35, 35);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.ToolTipText = "Back";
            this.BtnClose.WaitOnLoad = false;
            this.BtnClose.Zoom = 5;
            this.BtnClose.ZoomSpeed = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // PnlTitleBar
            // 
            this.PnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.PnlTitleBar.Controls.Add(this.BtnClose);
            this.PnlTitleBar.Controls.Add(this.LblChangePassword);
            this.PnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTitleBar.Name = "PnlTitleBar";
            this.PnlTitleBar.Size = new System.Drawing.Size(330, 45);
            this.PnlTitleBar.TabIndex = 101;
            // 
            // LblChangePassword
            // 
            this.LblChangePassword.AutoSize = true;
            this.LblChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.LblChangePassword.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangePassword.ForeColor = System.Drawing.Color.White;
            this.LblChangePassword.Location = new System.Drawing.Point(3, 0);
            this.LblChangePassword.Name = "LblChangePassword";
            this.LblChangePassword.Size = new System.Drawing.Size(224, 46);
            this.LblChangePassword.TabIndex = 102;
            this.LblChangePassword.Text = "Forgot password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 477);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 11);
            this.panel1.TabIndex = 22;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LblMsgUID
            // 
            this.LblMsgUID.AutoSize = true;
            this.LblMsgUID.BackColor = System.Drawing.Color.Transparent;
            this.LblMsgUID.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsgUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblMsgUID.Location = new System.Drawing.Point(161, 178);
            this.LblMsgUID.Name = "LblMsgUID";
            this.LblMsgUID.Size = new System.Drawing.Size(115, 27);
            this.LblMsgUID.TabIndex = 104;
            this.LblMsgUID.Text = "Invalid user ID";
            this.LblMsgUID.Visible = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.ForeColor = System.Drawing.Color.White;
            this.TxtPassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.TxtPassword.HintText = "Enter password";
            this.TxtPassword.isPassword = true;
            this.TxtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.TxtPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtPassword.LineMouseHoverColor = System.Drawing.Color.White;
            this.TxtPassword.LineThickness = 1;
            this.TxtPassword.Location = new System.Drawing.Point(54, 221);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.MaxLength = 15;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(225, 43);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblPassword.Location = new System.Drawing.Point(54, 192);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(77, 27);
            this.LblPassword.TabIndex = 105;
            this.LblPassword.Text = "Password";
            // 
            // TxtUID
            // 
            this.TxtUID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtUID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtUID.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtUID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUID.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUID.ForeColor = System.Drawing.Color.White;
            this.TxtUID.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.TxtUID.HintText = "Enter user ID";
            this.TxtUID.isPassword = false;
            this.TxtUID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.TxtUID.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtUID.LineMouseHoverColor = System.Drawing.Color.White;
            this.TxtUID.LineThickness = 1;
            this.TxtUID.Location = new System.Drawing.Point(54, 131);
            this.TxtUID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUID.MaxLength = 15;
            this.TxtUID.Name = "TxtUID";
            this.TxtUID.Size = new System.Drawing.Size(225, 43);
            this.TxtUID.TabIndex = 1;
            this.TxtUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtUID.Click += new System.EventHandler(this.TxtUID_Click);
            // 
            // LblUID
            // 
            this.LblUID.AutoSize = true;
            this.LblUID.BackColor = System.Drawing.Color.Transparent;
            this.LblUID.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblUID.Location = new System.Drawing.Point(54, 98);
            this.LblUID.Name = "LblUID";
            this.LblUID.Size = new System.Drawing.Size(65, 27);
            this.LblUID.TabIndex = 103;
            this.LblUID.Text = "User ID";
            // 
            // TxtConfPass
            // 
            this.TxtConfPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtConfPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtConfPass.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtConfPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtConfPass.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfPass.ForeColor = System.Drawing.Color.White;
            this.TxtConfPass.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.TxtConfPass.HintText = "Enter password";
            this.TxtConfPass.isPassword = true;
            this.TxtConfPass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.TxtConfPass.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtConfPass.LineMouseHoverColor = System.Drawing.Color.White;
            this.TxtConfPass.LineThickness = 1;
            this.TxtConfPass.Location = new System.Drawing.Point(54, 295);
            this.TxtConfPass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConfPass.MaxLength = 15;
            this.TxtConfPass.Name = "TxtConfPass";
            this.TxtConfPass.Size = new System.Drawing.Size(225, 43);
            this.TxtConfPass.TabIndex = 3;
            this.TxtConfPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LblPassNotSameMsg
            // 
            this.LblPassNotSameMsg.AutoSize = true;
            this.LblPassNotSameMsg.BackColor = System.Drawing.Color.Transparent;
            this.LblPassNotSameMsg.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassNotSameMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblPassNotSameMsg.Location = new System.Drawing.Point(138, 342);
            this.LblPassNotSameMsg.Name = "LblPassNotSameMsg";
            this.LblPassNotSameMsg.Size = new System.Drawing.Size(138, 27);
            this.LblPassNotSameMsg.TabIndex = 107;
            this.LblPassNotSameMsg.Text = "Not same as above";
            this.LblPassNotSameMsg.Visible = false;
            // 
            // BtnContinue
            // 
            this.BtnContinue.ActiveBorderThickness = 1;
            this.BtnContinue.ActiveCornerRadius = 20;
            this.BtnContinue.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.BtnContinue.ActiveForecolor = System.Drawing.Color.White;
            this.BtnContinue.ActiveLineColor = System.Drawing.Color.Tomato;
            this.BtnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.BtnContinue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnContinue.BackgroundImage")));
            this.BtnContinue.ButtonText = "Continue";
            this.BtnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnContinue.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnContinue.IdleBorderThickness = 1;
            this.BtnContinue.IdleCornerRadius = 30;
            this.BtnContinue.IdleFillColor = System.Drawing.Color.White;
            this.BtnContinue.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnContinue.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnContinue.Location = new System.Drawing.Point(103, 396);
            this.BtnContinue.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnContinue.Name = "BtnContinue";
            this.BtnContinue.Size = new System.Drawing.Size(136, 56);
            this.BtnContinue.TabIndex = 4;
            this.BtnContinue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnContinue.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PnlTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(54, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 106;
            this.label2.Text = "Confirm password";
            this.label2.Visible = false;
            // 
            // Frm_ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(330, 488);
            this.Controls.Add(this.BtnContinue);
            this.Controls.Add(this.LblPassNotSameMsg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtConfPass);
            this.Controls.Add(this.LblMsgUID);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtUID);
            this.Controls.Add(this.LblUID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitleBar);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ForgetPassword";
            this.PnlTitleBar.ResumeLayout(false);
            this.PnlTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuImageButton BtnClose;
        private System.Windows.Forms.Panel PnlTitleBar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnContinue;
        private System.Windows.Forms.Label LblPassNotSameMsg;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtConfPass;
        private System.Windows.Forms.Label LblMsgUID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUID;
        private System.Windows.Forms.Label LblUID;
        private System.Windows.Forms.Label LblChangePassword;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label label2;
    }
}