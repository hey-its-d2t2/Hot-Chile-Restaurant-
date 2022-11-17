namespace Hot_Chile_Restaurant
{
    partial class Frm_ChangeAdminPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChangeAdminPass));
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PnlTitleBar = new System.Windows.Forms.Panel();
            this.BtnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.LblChangePassword = new System.Windows.Forms.Label();
            this.BtnSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LblPassNotSameMsg = new System.Windows.Forms.Label();
            this.TxtConfPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LblMsgUID = new System.Windows.Forms.Label();
            this.TxtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TxtUID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblUID = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PnlTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.label2.Location = new System.Drawing.Point(49, 280);
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
            this.PnlTitleBar.Size = new System.Drawing.Size(342, 45);
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
            this.BtnClose.Location = new System.Drawing.Point(289, 5);
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
            // LblChangePassword
            // 
            this.LblChangePassword.AutoSize = true;
            this.LblChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.LblChangePassword.Font = new System.Drawing.Font("Andalus", 14F);
            this.LblChangePassword.ForeColor = System.Drawing.Color.White;
            this.LblChangePassword.Location = new System.Drawing.Point(10, 5);
            this.LblChangePassword.Name = "LblChangePassword";
            this.LblChangePassword.Size = new System.Drawing.Size(199, 38);
            this.LblChangePassword.TabIndex = 114;
            this.LblChangePassword.Text = "Change  password";
            // 
            // BtnSave
            // 
            this.BtnSave.ActiveBorderThickness = 1;
            this.BtnSave.ActiveCornerRadius = 20;
            this.BtnSave.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.BtnSave.ActiveForecolor = System.Drawing.Color.White;
            this.BtnSave.ActiveLineColor = System.Drawing.Color.Tomato;
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.ButtonText = "Save";
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnSave.IdleBorderThickness = 1;
            this.BtnSave.IdleCornerRadius = 30;
            this.BtnSave.IdleFillColor = System.Drawing.Color.White;
            this.BtnSave.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnSave.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnSave.Location = new System.Drawing.Point(103, 402);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(136, 56);
            this.BtnSave.TabIndex = 4;
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // LblPassNotSameMsg
            // 
            this.LblPassNotSameMsg.AutoSize = true;
            this.LblPassNotSameMsg.BackColor = System.Drawing.Color.Transparent;
            this.LblPassNotSameMsg.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassNotSameMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblPassNotSameMsg.Location = new System.Drawing.Point(133, 356);
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
            this.TxtConfPass.Location = new System.Drawing.Point(49, 309);
            this.TxtConfPass.Margin = new System.Windows.Forms.Padding(4);
            this.TxtConfPass.MaxLength = 15;
            this.TxtConfPass.Name = "TxtConfPass";
            this.TxtConfPass.Size = new System.Drawing.Size(225, 43);
            this.TxtConfPass.TabIndex = 3;
            this.TxtConfPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // LblMsgUID
            // 
            this.LblMsgUID.AutoSize = true;
            this.LblMsgUID.BackColor = System.Drawing.Color.Transparent;
            this.LblMsgUID.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsgUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblMsgUID.Location = new System.Drawing.Point(161, 185);
            this.LblMsgUID.Name = "LblMsgUID";
            this.LblMsgUID.Size = new System.Drawing.Size(115, 27);
            this.LblMsgUID.TabIndex = 116;
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
            this.TxtPassword.Location = new System.Drawing.Point(54, 233);
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
            this.LblPassword.Location = new System.Drawing.Point(54, 204);
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
            this.TxtUID.Location = new System.Drawing.Point(54, 138);
            this.TxtUID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtUID.MaxLength = 15;
            this.TxtUID.Name = "TxtUID";
            this.TxtUID.Size = new System.Drawing.Size(225, 43);
            this.TxtUID.TabIndex = 1;
            this.TxtUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LblUID
            // 
            this.LblUID.AutoSize = true;
            this.LblUID.BackColor = System.Drawing.Color.Transparent;
            this.LblUID.Font = new System.Drawing.Font("Andalus", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblUID.Location = new System.Drawing.Point(54, 105);
            this.LblUID.Name = "LblUID";
            this.LblUID.Size = new System.Drawing.Size(65, 27);
            this.LblUID.TabIndex = 115;
            this.LblUID.Text = "User ID";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 489);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 11);
            this.panel1.TabIndex = 112;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Frm_ChangeAdminPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(342, 500);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblPassNotSameMsg);
            this.Controls.Add(this.TxtConfPass);
            this.Controls.Add(this.LblMsgUID);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtUID);
            this.Controls.Add(this.LblUID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PnlTitleBar);
            this.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ChangeAdminPass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ChangeAdminPass";
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
        private Bunifu.Framework.UI.BunifuThinButton2 BtnSave;
        private System.Windows.Forms.Label LblPassNotSameMsg;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtConfPass;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Label LblMsgUID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPassword;
        private System.Windows.Forms.Label LblPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtUID;
        private System.Windows.Forms.Label LblUID;
        private System.Windows.Forms.Label LblChangePassword;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}