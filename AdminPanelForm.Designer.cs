namespace Hot_Chile_Restaurant
{
    partial class AdminPanelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelForm));
            this.PnlTitleBar = new System.Windows.Forms.Panel();
            this.ImgAppIcon = new System.Windows.Forms.PictureBox();
            this.BtnMin = new Bunifu.UI.WinForms.BunifuImageButton();
            this.BtnMax = new Bunifu.UI.WinForms.BunifuImageButton();
            this.BtnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnAbout = new Bunifu.UI.WinForms.BunifuImageButton();
            this.BtnAdmin = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnRemoveItem = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnUpdateItem = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnAddItem = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnHome = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnLogout = new Bunifu.UI.WinForms.BunifuImageButton();
            this.BtnOrderPlace = new Bunifu.Framework.UI.BunifuTileButton();
            this.PanelControle = new System.Windows.Forms.Panel();
            this.uC_Home1 = new Hot_Chile_Restaurant.UserControles.UC_Home();
            this.uC_AdminControleForm1 = new Hot_Chile_Restaurant.UserControles.UC_AdminControleForm();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.uC_RemoveItem1 = new Hot_Chile_Restaurant.UserControles.UC_RemoveItem();
            this.uC_UpdateItem1 = new Hot_Chile_Restaurant.UserControles.UC_UpdateItem();
            this.uC_PlaceOrder1 = new Hot_Chile_Restaurant.UserControles.UC_PlaceOrder();
            this.uC_AddItem1 = new Hot_Chile_Restaurant.UserControles.UC_AddItem();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.PnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAppIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelControle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTitleBar
            // 
            this.PnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.PnlTitleBar.Controls.Add(this.ImgAppIcon);
            this.PnlTitleBar.Controls.Add(this.BtnMin);
            this.PnlTitleBar.Controls.Add(this.BtnMax);
            this.PnlTitleBar.Controls.Add(this.BtnClose);
            this.PnlTitleBar.Controls.Add(this.LblTitle);
            this.PnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTitleBar.Name = "PnlTitleBar";
            this.PnlTitleBar.Size = new System.Drawing.Size(1550, 45);
            this.PnlTitleBar.TabIndex = 101;
            this.PnlTitleBar.DoubleClick += new System.EventHandler(this.PnlTitleBar_DoubleClick);
            // 
            // ImgAppIcon
            // 
            this.ImgAppIcon.Image = ((System.Drawing.Image)(resources.GetObject("ImgAppIcon.Image")));
            this.ImgAppIcon.Location = new System.Drawing.Point(-6, -5);
            this.ImgAppIcon.Name = "ImgAppIcon";
            this.ImgAppIcon.Size = new System.Drawing.Size(61, 53);
            this.ImgAppIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgAppIcon.TabIndex = 18;
            this.ImgAppIcon.TabStop = false;
            // 
            // BtnMin
            // 
            this.BtnMin.ActiveImage = null;
            this.BtnMin.AllowAnimations = true;
            this.BtnMin.AllowBuffering = false;
            this.BtnMin.AllowZooming = true;
            this.BtnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMin.BackColor = System.Drawing.Color.Transparent;
            this.BtnMin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnMin.ErrorImage")));
            this.BtnMin.FadeWhenInactive = false;
            this.BtnMin.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnMin.Image = ((System.Drawing.Image)(resources.GetObject("BtnMin.Image")));
            this.BtnMin.ImageActive = null;
            this.BtnMin.ImageLocation = null;
            this.BtnMin.ImageMargin = 5;
            this.BtnMin.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnMin.ImageZoomSize = new System.Drawing.Size(35, 35);
            this.BtnMin.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnMin.InitialImage")));
            this.BtnMin.Location = new System.Drawing.Point(1401, 5);
            this.BtnMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Rotation = 0;
            this.BtnMin.ShowActiveImage = true;
            this.BtnMin.ShowCursorChanges = true;
            this.BtnMin.ShowImageBorders = true;
            this.BtnMin.ShowSizeMarkers = false;
            this.BtnMin.Size = new System.Drawing.Size(35, 35);
            this.BtnMin.TabIndex = 16;
            this.BtnMin.ToolTipText = "Minimize";
            this.BtnMin.WaitOnLoad = false;
            this.BtnMin.Zoom = 5;
            this.BtnMin.ZoomSpeed = 10;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.ActiveImage = null;
            this.BtnMax.AllowAnimations = true;
            this.BtnMax.AllowBuffering = false;
            this.BtnMax.AllowZooming = true;
            this.BtnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMax.BackColor = System.Drawing.Color.Transparent;
            this.BtnMax.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnMax.ErrorImage")));
            this.BtnMax.FadeWhenInactive = false;
            this.BtnMax.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnMax.Image = ((System.Drawing.Image)(resources.GetObject("BtnMax.Image")));
            this.BtnMax.ImageActive = null;
            this.BtnMax.ImageLocation = null;
            this.BtnMax.ImageMargin = 5;
            this.BtnMax.ImageSize = new System.Drawing.Size(30, 30);
            this.BtnMax.ImageZoomSize = new System.Drawing.Size(35, 35);
            this.BtnMax.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnMax.InitialImage")));
            this.BtnMax.Location = new System.Drawing.Point(1449, 5);
            this.BtnMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Rotation = 0;
            this.BtnMax.ShowActiveImage = true;
            this.BtnMax.ShowCursorChanges = true;
            this.BtnMax.ShowImageBorders = true;
            this.BtnMax.ShowSizeMarkers = false;
            this.BtnMax.Size = new System.Drawing.Size(35, 35);
            this.BtnMax.TabIndex = 15;
            this.BtnMax.ToolTipText = "Maximize";
            this.BtnMax.WaitOnLoad = false;
            this.BtnMax.Zoom = 5;
            this.BtnMax.ZoomSpeed = 10;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
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
            this.BtnClose.Location = new System.Drawing.Point(1497, 5);
            this.BtnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Rotation = 0;
            this.BtnClose.ShowActiveImage = true;
            this.BtnClose.ShowCursorChanges = true;
            this.BtnClose.ShowImageBorders = true;
            this.BtnClose.ShowSizeMarkers = false;
            this.BtnClose.Size = new System.Drawing.Size(35, 35);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.ToolTipText = "Close";
            this.BtnClose.WaitOnLoad = false;
            this.BtnClose.Zoom = 5;
            this.BtnClose.ZoomSpeed = 10;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblTitle.Font = new System.Drawing.Font("Athletic Outfit", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.PapayaWhip;
            this.LblTitle.Location = new System.Drawing.Point(47, 5);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(138, 42);
            this.LblTitle.TabIndex = 100;
            this.LblTitle.Text = "Hot Chilli";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.BtnAbout);
            this.panel2.Controls.Add(this.BtnAdmin);
            this.panel2.Controls.Add(this.BtnRemoveItem);
            this.panel2.Controls.Add(this.BtnUpdateItem);
            this.panel2.Controls.Add(this.BtnAddItem);
            this.panel2.Controls.Add(this.BtnHome);
            this.panel2.Controls.Add(this.BtnLogout);
            this.panel2.Controls.Add(this.BtnOrderPlace);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(117, 824);
            this.panel2.TabIndex = 3;
            // 
            // BtnAbout
            // 
            this.BtnAbout.ActiveImage = null;
            this.BtnAbout.AllowAnimations = true;
            this.BtnAbout.AllowBuffering = false;
            this.BtnAbout.AllowZooming = true;
            this.BtnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAbout.BackColor = System.Drawing.Color.Transparent;
            this.BtnAbout.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnAbout.ErrorImage")));
            this.BtnAbout.FadeWhenInactive = false;
            this.BtnAbout.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnAbout.Image = ((System.Drawing.Image)(resources.GetObject("BtnAbout.Image")));
            this.BtnAbout.ImageActive = null;
            this.BtnAbout.ImageLocation = null;
            this.BtnAbout.ImageMargin = 5;
            this.BtnAbout.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnAbout.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.BtnAbout.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnAbout.InitialImage")));
            this.BtnAbout.Location = new System.Drawing.Point(38, 760);
            this.BtnAbout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Rotation = 0;
            this.BtnAbout.ShowActiveImage = true;
            this.BtnAbout.ShowCursorChanges = true;
            this.BtnAbout.ShowImageBorders = true;
            this.BtnAbout.ShowSizeMarkers = false;
            this.BtnAbout.Size = new System.Drawing.Size(40, 40);
            this.BtnAbout.TabIndex = 8;
            this.BtnAbout.ToolTipText = "About ";
            this.BtnAbout.WaitOnLoad = false;
            this.BtnAbout.Zoom = 5;
            this.BtnAbout.ZoomSpeed = 10;
            this.BtnAbout.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // BtnAdmin
            // 
            this.BtnAdmin.AutoSize = true;
            this.BtnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdmin.color = System.Drawing.Color.Transparent;
            this.BtnAdmin.colorActive = System.Drawing.Color.Crimson;
            this.BtnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdmin.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdmin.ForeColor = System.Drawing.Color.White;
            this.BtnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdmin.Image")));
            this.BtnAdmin.ImagePosition = 9;
            this.BtnAdmin.ImageZoom = 40;
            this.BtnAdmin.LabelPosition = 31;
            this.BtnAdmin.LabelText = "Admin";
            this.BtnAdmin.Location = new System.Drawing.Point(6, 528);
            this.BtnAdmin.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnAdmin.Name = "BtnAdmin";
            this.BtnAdmin.Size = new System.Drawing.Size(102, 89);
            this.BtnAdmin.TabIndex = 6;
            this.BtnAdmin.Click += new System.EventHandler(this.BtnAdmin_Click);
            // 
            // BtnRemoveItem
            // 
            this.BtnRemoveItem.AutoSize = true;
            this.BtnRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this.BtnRemoveItem.color = System.Drawing.Color.Transparent;
            this.BtnRemoveItem.colorActive = System.Drawing.Color.Crimson;
            this.BtnRemoveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoveItem.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.BtnRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnRemoveItem.Image")));
            this.BtnRemoveItem.ImagePosition = 9;
            this.BtnRemoveItem.ImageZoom = 40;
            this.BtnRemoveItem.LabelPosition = 31;
            this.BtnRemoveItem.LabelText = "Remove Item";
            this.BtnRemoveItem.Location = new System.Drawing.Point(7, 425);
            this.BtnRemoveItem.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnRemoveItem.Name = "BtnRemoveItem";
            this.BtnRemoveItem.Size = new System.Drawing.Size(102, 89);
            this.BtnRemoveItem.TabIndex = 5;
            this.BtnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);
            // 
            // BtnUpdateItem
            // 
            this.BtnUpdateItem.AutoSize = true;
            this.BtnUpdateItem.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateItem.color = System.Drawing.Color.Transparent;
            this.BtnUpdateItem.colorActive = System.Drawing.Color.Crimson;
            this.BtnUpdateItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateItem.Font = new System.Drawing.Font("Palatino Linotype", 10.8F);
            this.BtnUpdateItem.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpdateItem.Image")));
            this.BtnUpdateItem.ImagePosition = 10;
            this.BtnUpdateItem.ImageZoom = 40;
            this.BtnUpdateItem.LabelPosition = 31;
            this.BtnUpdateItem.LabelText = "Update Item";
            this.BtnUpdateItem.Location = new System.Drawing.Point(7, 323);
            this.BtnUpdateItem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnUpdateItem.Name = "BtnUpdateItem";
            this.BtnUpdateItem.Size = new System.Drawing.Size(102, 89);
            this.BtnUpdateItem.TabIndex = 4;
            this.BtnUpdateItem.Click += new System.EventHandler(this.BtnUpdateItem_Click);
            // 
            // BtnAddItem
            // 
            this.BtnAddItem.AutoSize = true;
            this.BtnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddItem.color = System.Drawing.Color.Transparent;
            this.BtnAddItem.colorActive = System.Drawing.Color.Crimson;
            this.BtnAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddItem.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddItem.ForeColor = System.Drawing.Color.White;
            this.BtnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("BtnAddItem.Image")));
            this.BtnAddItem.ImagePosition = 9;
            this.BtnAddItem.ImageZoom = 40;
            this.BtnAddItem.LabelPosition = 31;
            this.BtnAddItem.LabelText = "Add Item";
            this.BtnAddItem.Location = new System.Drawing.Point(7, 221);
            this.BtnAddItem.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnAddItem.Name = "BtnAddItem";
            this.BtnAddItem.Size = new System.Drawing.Size(102, 89);
            this.BtnAddItem.TabIndex = 3;
            this.BtnAddItem.Click += new System.EventHandler(this.BtnAddItem_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.AutoSize = true;
            this.BtnHome.BackColor = System.Drawing.Color.Transparent;
            this.BtnHome.color = System.Drawing.Color.Transparent;
            this.BtnHome.colorActive = System.Drawing.Color.Crimson;
            this.BtnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHome.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.White;
            this.BtnHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnHome.Image")));
            this.BtnHome.ImagePosition = 12;
            this.BtnHome.ImageZoom = 35;
            this.BtnHome.LabelPosition = 31;
            this.BtnHome.LabelText = "Home";
            this.BtnHome.Location = new System.Drawing.Point(6, 15);
            this.BtnHome.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(102, 89);
            this.BtnHome.TabIndex = 1;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.ActiveImage = null;
            this.BtnLogout.AllowAnimations = true;
            this.BtnLogout.AllowBuffering = false;
            this.BtnLogout.AllowZooming = true;
            this.BtnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogout.ErrorImage = ((System.Drawing.Image)(resources.GetObject("BtnLogout.ErrorImage")));
            this.BtnLogout.FadeWhenInactive = false;
            this.BtnLogout.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.BtnLogout.Image = ((System.Drawing.Image)(resources.GetObject("BtnLogout.Image")));
            this.BtnLogout.ImageActive = null;
            this.BtnLogout.ImageLocation = null;
            this.BtnLogout.ImageMargin = 5;
            this.BtnLogout.ImageSize = new System.Drawing.Size(35, 35);
            this.BtnLogout.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.BtnLogout.InitialImage = ((System.Drawing.Image)(resources.GetObject("BtnLogout.InitialImage")));
            this.BtnLogout.Location = new System.Drawing.Point(38, 677);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Rotation = 0;
            this.BtnLogout.ShowActiveImage = true;
            this.BtnLogout.ShowCursorChanges = true;
            this.BtnLogout.ShowImageBorders = true;
            this.BtnLogout.ShowSizeMarkers = false;
            this.BtnLogout.Size = new System.Drawing.Size(40, 40);
            this.BtnLogout.TabIndex = 7;
            this.BtnLogout.ToolTipText = "Logout";
            this.BtnLogout.WaitOnLoad = false;
            this.BtnLogout.Zoom = 5;
            this.BtnLogout.ZoomSpeed = 10;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnOrderPlace
            // 
            this.BtnOrderPlace.AutoSize = true;
            this.BtnOrderPlace.BackColor = System.Drawing.Color.Transparent;
            this.BtnOrderPlace.color = System.Drawing.Color.Transparent;
            this.BtnOrderPlace.colorActive = System.Drawing.Color.Crimson;
            this.BtnOrderPlace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrderPlace.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrderPlace.ForeColor = System.Drawing.Color.White;
            this.BtnOrderPlace.Image = ((System.Drawing.Image)(resources.GetObject("BtnOrderPlace.Image")));
            this.BtnOrderPlace.ImagePosition = 9;
            this.BtnOrderPlace.ImageZoom = 40;
            this.BtnOrderPlace.LabelPosition = 31;
            this.BtnOrderPlace.LabelText = "Place Order";
            this.BtnOrderPlace.Location = new System.Drawing.Point(9, 118);
            this.BtnOrderPlace.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnOrderPlace.Name = "BtnOrderPlace";
            this.BtnOrderPlace.Size = new System.Drawing.Size(102, 89);
            this.BtnOrderPlace.TabIndex = 2;
            this.BtnOrderPlace.Click += new System.EventHandler(this.BtnOrderPlace_Click);
            // 
            // PanelControle
            // 
            this.PanelControle.Controls.Add(this.uC_Home1);
            this.PanelControle.Controls.Add(this.uC_AdminControleForm1);
            this.PanelControle.Controls.Add(this.panel1);
            this.PanelControle.Controls.Add(this.uC_RemoveItem1);
            this.PanelControle.Controls.Add(this.uC_UpdateItem1);
            this.PanelControle.Controls.Add(this.uC_PlaceOrder1);
            this.PanelControle.Controls.Add(this.uC_AddItem1);
            this.PanelControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelControle.Location = new System.Drawing.Point(117, 45);
            this.PanelControle.Name = "PanelControle";
            this.PanelControle.Size = new System.Drawing.Size(1433, 824);
            this.PanelControle.TabIndex = 4;
            // 
            // uC_Home1
            // 
            this.uC_Home1.BackColor = System.Drawing.Color.Black;
            this.uC_Home1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Home1.Location = new System.Drawing.Point(0, 0);
            this.uC_Home1.Name = "uC_Home1";
            this.uC_Home1.Size = new System.Drawing.Size(1433, 784);
            this.uC_Home1.TabIndex = 24;
            // 
            // uC_AdminControleForm1
            // 
            this.uC_AdminControleForm1.BackColor = System.Drawing.Color.Black;
            this.uC_AdminControleForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_AdminControleForm1.Location = new System.Drawing.Point(0, 0);
            this.uC_AdminControleForm1.Name = "uC_AdminControleForm1";
            this.uC_AdminControleForm1.Size = new System.Drawing.Size(1433, 784);
            this.uC_AdminControleForm1.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 784);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1433, 40);
            this.panel1.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(424, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "@Copyright resurved - developers.02.92, 2022  contact : developers0292@gmail.com\r" +
    "\n";
            // 
            // uC_RemoveItem1
            // 
            this.uC_RemoveItem1.BackColor = System.Drawing.Color.Black;
            this.uC_RemoveItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_RemoveItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_RemoveItem1.Name = "uC_RemoveItem1";
            this.uC_RemoveItem1.Size = new System.Drawing.Size(1433, 824);
            this.uC_RemoveItem1.TabIndex = 3;
            // 
            // uC_UpdateItem1
            // 
            this.uC_UpdateItem1.BackColor = System.Drawing.Color.Black;
            this.uC_UpdateItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_UpdateItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_UpdateItem1.Name = "uC_UpdateItem1";
            this.uC_UpdateItem1.Size = new System.Drawing.Size(1433, 824);
            this.uC_UpdateItem1.TabIndex = 2;
            // 
            // uC_PlaceOrder1
            // 
            this.uC_PlaceOrder1.BackColor = System.Drawing.Color.Black;
            this.uC_PlaceOrder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_PlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.uC_PlaceOrder1.Name = "uC_PlaceOrder1";
            this.uC_PlaceOrder1.Size = new System.Drawing.Size(1433, 824);
            this.uC_PlaceOrder1.TabIndex = 1;
            // 
            // uC_AddItem1
            // 
            this.uC_AddItem1.BackColor = System.Drawing.Color.Black;
            this.uC_AddItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.uC_AddItem1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_AddItem1.Location = new System.Drawing.Point(0, 0);
            this.uC_AddItem1.Name = "uC_AddItem1";
            this.uC_AddItem1.Size = new System.Drawing.Size(1433, 824);
            this.uC_AddItem1.TabIndex = 0;
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
            this.bunifuDragControl2.TargetControl = this.LblTitle;
            this.bunifuDragControl2.Vertical = true;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1550, 869);
            this.Controls.Add(this.PanelControle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PnlTitleBar);
            this.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPanelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanelForm";
            this.PnlTitleBar.ResumeLayout(false);
            this.PnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAppIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelControle.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitleBar;
        private System.Windows.Forms.PictureBox ImgAppIcon;
        private Bunifu.UI.WinForms.BunifuImageButton BtnMin;
        private Bunifu.UI.WinForms.BunifuImageButton BtnMax;
        private Bunifu.UI.WinForms.BunifuImageButton BtnClose;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton BtnHome;
        private Bunifu.UI.WinForms.BunifuImageButton BtnLogout;
        private Bunifu.Framework.UI.BunifuTileButton BtnOrderPlace;
        private Bunifu.Framework.UI.BunifuTileButton BtnRemoveItem;
        private Bunifu.Framework.UI.BunifuTileButton BtnUpdateItem;
        private Bunifu.Framework.UI.BunifuTileButton BtnAddItem;
        private System.Windows.Forms.Panel PanelControle;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private UserControles.UC_AddItem uC_AddItem1;
        private UserControles.UC_PlaceOrder uC_PlaceOrder1;
        private UserControles.UC_UpdateItem uC_UpdateItem1;
        private UserControles.UC_RemoveItem uC_RemoveItem1;
        private Bunifu.Framework.UI.BunifuTileButton BtnAdmin;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton BtnAbout;
        private UserControles.UC_AdminControleForm adminControleForm1;
        private UserControles.UC_AdminControleForm uC_AdminControleForm1;
        private UserControles.UC_Home uC_Home1;
        private System.Windows.Forms.Label label1;
    }
}