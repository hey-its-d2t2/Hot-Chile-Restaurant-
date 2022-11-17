namespace Hot_Chile_Restaurant
{
    partial class AdminLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginForm));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BtnExit = new Bunifu.UI.WinForms.BunifuImageButton();
            this.LbloginAdmin = new System.Windows.Forms.Label();
            this.LblUID = new System.Windows.Forms.Label();
            this.TxtUID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BtnLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LblMsgUID = new System.Windows.Forms.Label();
            this.LblMsgPass = new System.Windows.Forms.Label();
            this.LblRetailAssistant = new System.Windows.Forms.Label();
            this.LblForgotPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // BtnExit
            // 
            this.BtnExit.ActiveImage = null;
            this.BtnExit.AllowAnimations = true;
            this.BtnExit.AllowBuffering = false;
            this.BtnExit.AllowZooming = true;
            this.BtnExit.BackColor = System.Drawing.Color.Black;
            this.BtnExit.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.ErrorImage")));
            this.BtnExit.FadeWhenInactive = false;
            this.BtnExit.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageActive = null;
            this.BtnExit.ImageLocation = null;
            this.BtnExit.ImageMargin = 5;
            this.BtnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnExit.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.BtnExit.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnExit.InitialImage")));
            this.BtnExit.Location = new System.Drawing.Point(869, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Rotation = 0;
            this.BtnExit.ShowActiveImage = true;
            this.BtnExit.ShowCursorChanges = true;
            this.BtnExit.ShowImageBorders = true;
            this.BtnExit.ShowSizeMarkers = false;
            this.BtnExit.Size = new System.Drawing.Size(40, 40);
            this.BtnExit.TabIndex = 6;
            this.BtnExit.ToolTipText = "Exit";
            this.BtnExit.WaitOnLoad = false;
            this.BtnExit.Zoom = 5;
            this.BtnExit.ZoomSpeed = 10;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LbloginAdmin
            // 
            this.LbloginAdmin.AutoSize = true;
            this.LbloginAdmin.BackColor = System.Drawing.Color.Transparent;
            this.LbloginAdmin.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbloginAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LbloginAdmin.Location = new System.Drawing.Point(163, 53);
            this.LbloginAdmin.Name = "LbloginAdmin";
            this.LbloginAdmin.Size = new System.Drawing.Size(153, 46);
            this.LbloginAdmin.TabIndex = 101;
            this.LbloginAdmin.Text = "Get started";
            // 
            // LblUID
            // 
            this.LblUID.AutoSize = true;
            this.LblUID.BackColor = System.Drawing.Color.Transparent;
            this.LblUID.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblUID.Location = new System.Drawing.Point(64, 134);
            this.LblUID.Name = "LblUID";
            this.LblUID.Size = new System.Drawing.Size(65, 27);
            this.LblUID.TabIndex = 102;
            this.LblUID.Text = "User ID";
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
            this.TxtUID.Location = new System.Drawing.Point(70, 159);
            this.TxtUID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUID.MaxLength = 15;
            this.TxtUID.Name = "TxtUID";
            this.TxtUID.Size = new System.Drawing.Size(306, 43);
            this.TxtUID.TabIndex = 1;
            this.TxtUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblPassword.Location = new System.Drawing.Point(64, 226);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(77, 27);
            this.LblPassword.TabIndex = 104;
            this.LblPassword.Text = "Password";
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
            this.TxtPassword.Location = new System.Drawing.Point(66, 251);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.MaxLength = 15;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(306, 43);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BtnLogin
            // 
            this.BtnLogin.ActiveBorderThickness = 1;
            this.BtnLogin.ActiveCornerRadius = 20;
            this.BtnLogin.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.BtnLogin.ActiveForecolor = System.Drawing.Color.White;
            this.BtnLogin.ActiveLineColor = System.Drawing.Color.Tomato;
            this.BtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.BtnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLogin.BackgroundImage")));
            this.BtnLogin.ButtonText = "Login";
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnLogin.IdleBorderThickness = 1;
            this.BtnLogin.IdleCornerRadius = 30;
            this.BtnLogin.IdleFillColor = System.Drawing.Color.White;
            this.BtnLogin.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnLogin.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnLogin.Location = new System.Drawing.Point(171, 330);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(120, 56);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LblMsgUID
            // 
            this.LblMsgUID.AutoSize = true;
            this.LblMsgUID.BackColor = System.Drawing.Color.Transparent;
            this.LblMsgUID.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsgUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblMsgUID.Location = new System.Drawing.Point(258, 203);
            this.LblMsgUID.Name = "LblMsgUID";
            this.LblMsgUID.Size = new System.Drawing.Size(115, 27);
            this.LblMsgUID.TabIndex = 103;
            this.LblMsgUID.Text = "Invalid user ID";
            this.LblMsgUID.Visible = false;
            // 
            // LblMsgPass
            // 
            this.LblMsgPass.AutoSize = true;
            this.LblMsgPass.BackColor = System.Drawing.Color.Transparent;
            this.LblMsgPass.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsgPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblMsgPass.Location = new System.Drawing.Point(243, 299);
            this.LblMsgPass.Name = "LblMsgPass";
            this.LblMsgPass.Size = new System.Drawing.Size(131, 27);
            this.LblMsgPass.TabIndex = 105;
            this.LblMsgPass.Text = "Invalid password";
            this.LblMsgPass.Visible = false;
            // 
            // LblRetailAssistant
            // 
            this.LblRetailAssistant.AutoSize = true;
            this.LblRetailAssistant.BackColor = System.Drawing.Color.Transparent;
            this.LblRetailAssistant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblRetailAssistant.Font = new System.Drawing.Font("Andalus", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRetailAssistant.ForeColor = System.Drawing.Color.DarkGray;
            this.LblRetailAssistant.Location = new System.Drawing.Point(40, 466);
            this.LblRetailAssistant.Name = "LblRetailAssistant";
            this.LblRetailAssistant.Size = new System.Drawing.Size(147, 34);
            this.LblRetailAssistant.TabIndex = 5;
            this.LblRetailAssistant.Text = "Retail Assistant";
            this.LblRetailAssistant.Click += new System.EventHandler(this.LblRetailAssistant_Click);
            this.LblRetailAssistant.MouseLeave += new System.EventHandler(this.LblForgotPass_MouseLeave);
            this.LblRetailAssistant.MouseHover += new System.EventHandler(this.LblAdmin_MouseHover);
            // 
            // LblForgotPass
            // 
            this.LblForgotPass.AutoSize = true;
            this.LblForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.LblForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblForgotPass.Font = new System.Drawing.Font("Andalus", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblForgotPass.ForeColor = System.Drawing.Color.DarkGray;
            this.LblForgotPass.Location = new System.Drawing.Point(242, 466);
            this.LblForgotPass.Name = "LblForgotPass";
            this.LblForgotPass.Size = new System.Drawing.Size(163, 34);
            this.LblForgotPass.TabIndex = 4;
            this.LblForgotPass.Text = "Forgot password";
            this.LblForgotPass.Click += new System.EventHandler(this.LblForgotPass_Click);
            this.LblForgotPass.MouseLeave += new System.EventHandler(this.LblForgotPass_MouseLeave_1);
            this.LblForgotPass.MouseHover += new System.EventHandler(this.LblForgotPass_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(12, 534);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 106;
            this.label1.Text = "V-02.92";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(618, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 23);
            this.label2.TabIndex = 107;
            this.label2.Text = "copyright 2022 - developers.02.92";
            // 
            // AdminLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(908, 566);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblForgotPass);
            this.Controls.Add(this.LblRetailAssistant);
            this.Controls.Add(this.LblMsgPass);
            this.Controls.Add(this.LblMsgUID);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtUID);
            this.Controls.Add(this.LblUID);
            this.Controls.Add(this.LbloginAdmin);
            this.Controls.Add(this.BtnExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminLoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label LblForgotPass;
        private System.Windows.Forms.Label LblRetailAssistant;
        private System.Windows.Forms.Label LblMsgPass;
        private System.Windows.Forms.Label LblMsgUID;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUID;
        private System.Windows.Forms.Label LblUID;
        private System.Windows.Forms.Label LbloginAdmin;
        private Bunifu.UI.WinForms.BunifuImageButton BtnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}