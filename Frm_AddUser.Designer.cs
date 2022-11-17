namespace Hot_Chile_Restaurant
{
    partial class Frm_AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AddUser));
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PnlTitleBar = new System.Windows.Forms.Panel();
            this.BtnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.LblChangePassword = new System.Windows.Forms.Label();
            this.BtnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LblPassNotSameMsg = new System.Windows.Forms.Label();
            this.TxtConfPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TxtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtUID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblUID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.TxtKey = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblMsg_InvalidKey = new System.Windows.Forms.Label();
            this.TxtUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(323, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 27);
            this.label2.TabIndex = 118;
            this.label2.Text = "Confirm password";
            this.label2.Visible = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.PnlTitleBar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PnlTitleBar
            // 
            this.PnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.PnlTitleBar.Controls.Add(this.BtnClose);
            this.PnlTitleBar.Controls.Add(this.LblChangePassword);
            this.PnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTitleBar.Name = "PnlTitleBar";
            this.PnlTitleBar.Size = new System.Drawing.Size(593, 45);
            this.PnlTitleBar.TabIndex = 113;
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
            this.BtnClose.Location = new System.Drawing.Point(540, 5);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0;
            this.BtnClose.ShowActiveImage = true;
            this.BtnClose.ShowCursorChanges = true;
            this.BtnClose.ShowImageBorders = true;
            this.BtnClose.ShowSizeMarkers = false;
            this.BtnClose.Size = new System.Drawing.Size(35, 35);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.ToolTipText = "Back";
            this.BtnClose.WaitOnLoad = false;
            this.BtnClose.Zoom = 5;
            this.BtnClose.ZoomSpeed = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblChangePassword
            // 
            this.LblChangePassword.AutoSize = true;
            this.LblChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.LblChangePassword.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangePassword.ForeColor = System.Drawing.Color.White;
            this.LblChangePassword.Location = new System.Drawing.Point(183, 0);
            this.LblChangePassword.Name = "LblChangePassword";
            this.LblChangePassword.Size = new System.Drawing.Size(216, 46);
            this.LblChangePassword.TabIndex = 114;
            this.LblChangePassword.Text = "Add AdminUser";
            // 
            // BtnAdd
            // 
            this.BtnAdd.ActiveBorderThickness = 1;
            this.BtnAdd.ActiveCornerRadius = 20;
            this.BtnAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.BtnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.BtnAdd.ActiveLineColor = System.Drawing.Color.Tomato;
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.BtnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.BackgroundImage")));
            this.BtnAdd.ButtonText = "Add";
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnAdd.IdleBorderThickness = 1;
            this.BtnAdd.IdleCornerRadius = 30;
            this.BtnAdd.IdleFillColor = System.Drawing.Color.White;
            this.BtnAdd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnAdd.Location = new System.Drawing.Point(239, 404);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(136, 56);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // LblPassNotSameMsg
            // 
            this.LblPassNotSameMsg.AutoSize = true;
            this.LblPassNotSameMsg.BackColor = System.Drawing.Color.Transparent;
            this.LblPassNotSameMsg.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassNotSameMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblPassNotSameMsg.Location = new System.Drawing.Point(407, 367);
            this.LblPassNotSameMsg.Name = "LblPassNotSameMsg";
            this.LblPassNotSameMsg.Size = new System.Drawing.Size(138, 27);
            this.LblPassNotSameMsg.TabIndex = 119;
            this.LblPassNotSameMsg.Text = "Not same as above";
            this.LblPassNotSameMsg.Visible = false;
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
            this.TxtConfPass.Location = new System.Drawing.Point(323, 320);
            this.TxtConfPass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConfPass.MaxLength = 15;
            this.TxtConfPass.Name = "TxtConfPass";
            this.TxtConfPass.Size = new System.Drawing.Size(225, 43);
            this.TxtConfPass.TabIndex = 5;
            this.TxtConfPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtConfPass.Click += new System.EventHandler(this.TxtConfPass_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
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
            this.TxtPassword.Location = new System.Drawing.Point(54, 320);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPassword.MaxLength = 15;
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(225, 43);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.BackColor = System.Drawing.Color.Transparent;
            this.LblPassword.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblPassword.Location = new System.Drawing.Point(54, 291);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(77, 27);
            this.LblPassword.TabIndex = 117;
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
            this.TxtUID.Location = new System.Drawing.Point(323, 244);
            this.TxtUID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUID.MaxLength = 15;
            this.TxtUID.Name = "TxtUID";
            this.TxtUID.Size = new System.Drawing.Size(225, 43);
            this.TxtUID.TabIndex = 3;
            this.TxtUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LblUID
            // 
            this.LblUID.AutoSize = true;
            this.LblUID.BackColor = System.Drawing.Color.Transparent;
            this.LblUID.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblUID.Location = new System.Drawing.Point(323, 211);
            this.LblUID.Name = "LblUID";
            this.LblUID.Size = new System.Drawing.Size(65, 27);
            this.LblUID.TabIndex = 115;
            this.LblUID.Text = "User ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 11);
            this.panel1.TabIndex = 112;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // TxtKey
            // 
            this.TxtKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtKey.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtKey.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtKey.ForeColor = System.Drawing.Color.White;
            this.TxtKey.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.TxtKey.HintText = "Enter key...";
            this.TxtKey.isPassword = false;
            this.TxtKey.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.TxtKey.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtKey.LineMouseHoverColor = System.Drawing.Color.White;
            this.TxtKey.LineThickness = 1;
            this.TxtKey.Location = new System.Drawing.Point(186, 97);
            this.TxtKey.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKey.MaxLength = 15;
            this.TxtKey.Name = "TxtKey";
            this.TxtKey.Size = new System.Drawing.Size(225, 43);
            this.TxtKey.TabIndex = 1;
            this.TxtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtKey.Click += new System.EventHandler(this.bunifuMaterialTextbox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(186, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 122;
            this.label1.Text = "Secret key";
            // 
            // LblMsg_InvalidKey
            // 
            this.LblMsg_InvalidKey.AutoSize = true;
            this.LblMsg_InvalidKey.BackColor = System.Drawing.Color.Transparent;
            this.LblMsg_InvalidKey.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsg_InvalidKey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblMsg_InvalidKey.Location = new System.Drawing.Point(310, 142);
            this.LblMsg_InvalidKey.Name = "LblMsg_InvalidKey";
            this.LblMsg_InvalidKey.Size = new System.Drawing.Size(98, 27);
            this.LblMsg_InvalidKey.TabIndex = 123;
            this.LblMsg_InvalidKey.Text = "Invalid key...";
            this.LblMsg_InvalidKey.Visible = false;
            // 
            // TxtUserName
            // 
            this.TxtUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtUserName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.ForeColor = System.Drawing.Color.White;
            this.TxtUserName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.TxtUserName.HintText = "Enter user name";
            this.TxtUserName.isPassword = false;
            this.TxtUserName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.TxtUserName.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtUserName.LineMouseHoverColor = System.Drawing.Color.White;
            this.TxtUserName.LineThickness = 1;
            this.TxtUserName.Location = new System.Drawing.Point(54, 244);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUserName.MaxLength = 15;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(225, 43);
            this.TxtUserName.TabIndex = 2;
            this.TxtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.label3.Location = new System.Drawing.Point(54, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 27);
            this.label3.TabIndex = 125;
            this.label3.Text = "User name";
            // 
            // Frm_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(593, 496);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblMsg_InvalidKey);
            this.Controls.Add(this.TxtKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblPassNotSameMsg);
            this.Controls.Add(this.TxtConfPass);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtUID);
            this.Controls.Add(this.LblUID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_AddUser";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AddUser";
            this.PnlTitleBar.ResumeLayout(false);
            this.PnlTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel PnlTitleBar;
        private Bunifu.UI.WinForms.BunifuImageButton BtnClose;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnAdd;
        private System.Windows.Forms.Label LblPassNotSameMsg;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtConfPass;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUID;
        private System.Windows.Forms.Label LblUID;
        private System.Windows.Forms.Label LblChangePassword;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label LblMsg_InvalidKey;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtKey;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUserName;
        private System.Windows.Forms.Label label3;
    }
}