namespace Hot_Chile_Restaurant
{
    partial class Frm_ViewDelCustomerData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ViewDelCustomerData));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PnlTitleBar = new System.Windows.Forms.Panel();
            this.LblChangePassword = new System.Windows.Forms.Label();
            this.BtnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label19 = new System.Windows.Forms.Label();
            this.PnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.PnlTitleBar.Controls.Add(this.LblChangePassword);
            this.PnlTitleBar.Controls.Add(this.BtnClose);
            this.PnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTitleBar.Name = "PnlTitleBar";
            this.PnlTitleBar.Size = new System.Drawing.Size(1252, 45);
            this.PnlTitleBar.TabIndex = 142;
            // 
            // LblChangePassword
            // 
            this.LblChangePassword.AutoSize = true;
            this.LblChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.LblChangePassword.Font = new System.Drawing.Font("Andalus", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblChangePassword.ForeColor = System.Drawing.Color.White;
            this.LblChangePassword.Location = new System.Drawing.Point(482, -1);
            this.LblChangePassword.Name = "LblChangePassword";
            this.LblChangePassword.Size = new System.Drawing.Size(271, 46);
            this.LblChangePassword.TabIndex = 129;
            this.LblChangePassword.Text = "All Customer Details";
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
            this.BtnClose.Location = new System.Drawing.Point(1199, 5);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 772);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 11);
            this.panel1.TabIndex = 141;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = null;
            this.bunifuDragControl2.Vertical = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowCustomTheming = false;
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.SlateGray;
            this.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 40;
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.DataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView1.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.DataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.DataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.DataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.Name = null;
            this.DataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.DataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.DataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.DataGridView1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.DataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridView1.Location = new System.Drawing.Point(27, 150);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 54;
            this.DataGridView1.RowTemplate.Height = 40;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(1196, 532);
            this.DataGridView1.TabIndex = 143;
            this.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(524, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 144;
            this.pictureBox1.TabStop = false;
            // 
            // BtnPrint
            // 
            this.BtnPrint.ActiveBorderThickness = 1;
            this.BtnPrint.ActiveCornerRadius = 20;
            this.BtnPrint.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.BtnPrint.ActiveForecolor = System.Drawing.Color.White;
            this.BtnPrint.ActiveLineColor = System.Drawing.Color.Tomato;
            this.BtnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.BtnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPrint.BackgroundImage")));
            this.BtnPrint.ButtonText = "Print";
            this.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnPrint.IdleBorderThickness = 1;
            this.BtnPrint.IdleCornerRadius = 30;
            this.BtnPrint.IdleFillColor = System.Drawing.Color.White;
            this.BtnPrint.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnPrint.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnPrint.Location = new System.Drawing.Point(547, 692);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(164, 56);
            this.BtnPrint.TabIndex = 145;
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(33, 704);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(303, 31);
            this.label19.TabIndex = 146;
            this.label19.Text = "Click on row tto delete data.";
            // 
            // Frm_ViewDelCustomerData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1252, 783);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.PnlTitleBar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ViewDelCustomerData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ViewDelCustomerData";
            this.Load += new System.EventHandler(this.Frm_ViewDelCustomerData_Load);
            this.PnlTitleBar.ResumeLayout(false);
            this.PnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel PnlTitleBar;
        private Bunifu.UI.WinForms.BunifuImageButton BtnClose;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnPrint;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label LblChangePassword;
    }
}