namespace Hot_Chile_Restaurant.UserControles
{
    partial class UC_PlaceOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_PlaceOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.ComoboCategory = new Bunifu.UI.WinForms.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.PnlBackground = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.DataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnRemove = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label11 = new System.Windows.Forms.Label();
            this.LblFinalPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnPrint = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnClearAll = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblMsgPrice = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.NumericUpDown();
            this.BtnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPriceItem = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNameItem = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.TxtSearchItem = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtCustomerEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtCustomerMobile = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtCustomerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.PnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantity)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 45);
            this.label1.TabIndex = 101;
            this.label1.Text = "Place Order";
            // 
            // ComoboCategory
            // 
            this.ComoboCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.ComoboCategory.BorderRadius = 1;
            this.ComoboCategory.Color = System.Drawing.Color.White;
            this.ComoboCategory.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ComoboCategory.DisabledColor = System.Drawing.Color.Gray;
            this.ComoboCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComoboCategory.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.ComoboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComoboCategory.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ComoboCategory.FillDropDown = false;
            this.ComoboCategory.FillIndicator = false;
            this.ComoboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComoboCategory.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComoboCategory.ForeColor = System.Drawing.Color.White;
            this.ComoboCategory.FormattingEnabled = true;
            this.ComoboCategory.Icon = null;
            this.ComoboCategory.IndicatorColor = System.Drawing.Color.White;
            this.ComoboCategory.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ComoboCategory.ItemBackColor = System.Drawing.Color.LightGray;
            this.ComoboCategory.ItemBorderColor = System.Drawing.Color.White;
            this.ComoboCategory.ItemForeColor = System.Drawing.Color.Black;
            this.ComoboCategory.ItemHeight = 26;
            this.ComoboCategory.ItemHighLightColor = System.Drawing.Color.LemonChiffon;
            this.ComoboCategory.Location = new System.Drawing.Point(514, 74);
            this.ComoboCategory.Name = "ComoboCategory";
            this.ComoboCategory.Size = new System.Drawing.Size(263, 32);
            this.ComoboCategory.TabIndex = 9;
            this.ComoboCategory.Text = null;
            this.ComoboCategory.SelectedIndexChanged += new System.EventHandler(this.ComoboCategory_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(508, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 31);
            this.label2.TabIndex = 112;
            this.label2.Text = "Category";
            // 
            // PnlBackground
            // 
            this.PnlBackground.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlBackground.BorderColor = System.Drawing.Color.GhostWhite;
            this.PnlBackground.Controls.Add(this.DataGridView1);
            this.PnlBackground.Controls.Add(this.BtnRemove);
            this.PnlBackground.Controls.Add(this.label11);
            this.PnlBackground.Controls.Add(this.LblFinalPrice);
            this.PnlBackground.Controls.Add(this.label8);
            this.PnlBackground.Controls.Add(this.BtnPrint);
            this.PnlBackground.Controls.Add(this.BtnClearAll);
            this.PnlBackground.Controls.Add(this.label3);
            this.PnlBackground.Controls.Add(this.panel1);
            this.PnlBackground.Controls.Add(this.ItemsListBox);
            this.PnlBackground.Controls.Add(this.TxtSearchItem);
            this.PnlBackground.Controls.Add(this.ComoboCategory);
            this.PnlBackground.Controls.Add(this.label2);
            this.PnlBackground.Controls.Add(this.panel2);
            this.PnlBackground.Controls.Add(this.panel3);
            this.PnlBackground.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlBackground.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.PnlBackground.Location = new System.Drawing.Point(3, 45);
            this.PnlBackground.Name = "PnlBackground";
            this.PnlBackground.PanelColor = System.Drawing.Color.Empty;
            this.PnlBackground.ShadowDept = 1;
            this.PnlBackground.ShadowTopLeftVisible = false;
            this.PnlBackground.Size = new System.Drawing.Size(1539, 853);
            this.PnlBackground.TabIndex = 200;
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
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemPrice,
            this.Quantity,
            this.TotalPrice});
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
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.DataGridView1.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.DataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.DataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridView1.Location = new System.Drawing.Point(831, 43);
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
            this.DataGridView1.RowHeadersWidth = 22;
            this.DataGridView1.RowTemplate.Height = 40;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(663, 632);
            this.DataGridView1.TabIndex = 99;
            this.DataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemPrice
            // 
            this.ItemPrice.HeaderText = "Item Price";
            this.ItemPrice.MinimumWidth = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "Total ";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            // 
            // BtnRemove
            // 
            this.BtnRemove.ActiveBorderThickness = 1;
            this.BtnRemove.ActiveCornerRadius = 20;
            this.BtnRemove.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.BtnRemove.ActiveForecolor = System.Drawing.Color.White;
            this.BtnRemove.ActiveLineColor = System.Drawing.Color.Tomato;
            this.BtnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.BtnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRemove.BackgroundImage")));
            this.BtnRemove.ButtonText = "&Remove";
            this.BtnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemove.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnRemove.IdleBorderThickness = 1;
            this.BtnRemove.IdleCornerRadius = 30;
            this.BtnRemove.IdleFillColor = System.Drawing.Color.White;
            this.BtnRemove.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnRemove.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnRemove.Location = new System.Drawing.Point(286, 771);
            this.BtnRemove.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(151, 54);
            this.BtnRemove.TabIndex = 9;
            this.BtnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 13.8F);
            this.label11.ForeColor = System.Drawing.Color.Turquoise;
            this.label11.Location = new System.Drawing.Point(47, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 31);
            this.label11.TabIndex = 102;
            this.label11.Text = "Customer details";
            // 
            // LblFinalPrice
            // 
            this.LblFinalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblFinalPrice.AutoSize = true;
            this.LblFinalPrice.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFinalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.LblFinalPrice.Location = new System.Drawing.Point(1369, 708);
            this.LblFinalPrice.Name = "LblFinalPrice";
            this.LblFinalPrice.Size = new System.Drawing.Size(79, 45);
            this.LblFinalPrice.TabIndex = 114;
            this.LblFinalPrice.Text = "00.0";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.label8.Location = new System.Drawing.Point(1224, 708);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 45);
            this.label8.TabIndex = 113;
            this.label8.Text = "Total :";
            // 
            // BtnPrint
            // 
            this.BtnPrint.ActiveBorderThickness = 1;
            this.BtnPrint.ActiveCornerRadius = 20;
            this.BtnPrint.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.BtnPrint.ActiveForecolor = System.Drawing.Color.White;
            this.BtnPrint.ActiveLineColor = System.Drawing.Color.Tomato;
            this.BtnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.BtnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPrint.BackgroundImage")));
            this.BtnPrint.ButtonText = "&Print";
            this.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPrint.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnPrint.IdleBorderThickness = 1;
            this.BtnPrint.IdleCornerRadius = 30;
            this.BtnPrint.IdleFillColor = System.Drawing.Color.White;
            this.BtnPrint.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnPrint.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnPrint.Location = new System.Drawing.Point(1297, 771);
            this.BtnPrint.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(151, 54);
            this.BtnPrint.TabIndex = 7;
            this.BtnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnClearAll
            // 
            this.BtnClearAll.ActiveBorderThickness = 1;
            this.BtnClearAll.ActiveCornerRadius = 20;
            this.BtnClearAll.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.BtnClearAll.ActiveForecolor = System.Drawing.Color.White;
            this.BtnClearAll.ActiveLineColor = System.Drawing.Color.Tomato;
            this.BtnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.BtnClearAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClearAll.BackgroundImage")));
            this.BtnClearAll.ButtonText = "All &Clear";
            this.BtnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClearAll.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnClearAll.IdleBorderThickness = 1;
            this.BtnClearAll.IdleCornerRadius = 30;
            this.BtnClearAll.IdleFillColor = System.Drawing.Color.White;
            this.BtnClearAll.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnClearAll.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnClearAll.Location = new System.Drawing.Point(53, 771);
            this.BtnClearAll.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnClearAll.Name = "BtnClearAll";
            this.BtnClearAll.Size = new System.Drawing.Size(151, 54);
            this.BtnClearAll.TabIndex = 10;
            this.BtnClearAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 13.8F);
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(43, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 31);
            this.label3.TabIndex = 106;
            this.label3.Text = "Item details";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblMsgPrice);
            this.panel1.Controls.Add(this.TxtQuantity);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TxtPriceItem);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtNameItem);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(39, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 367);
            this.panel1.TabIndex = 202;
            // 
            // LblMsgPrice
            // 
            this.LblMsgPrice.AutoSize = true;
            this.LblMsgPrice.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsgPrice.Location = new System.Drawing.Point(279, 206);
            this.LblMsgPrice.Name = "LblMsgPrice";
            this.LblMsgPrice.Size = new System.Drawing.Size(80, 37);
            this.LblMsgPrice.TabIndex = 111;
            this.LblMsgPrice.Text = "00.00";
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.BackColor = System.Drawing.Color.SlateGray;
            this.TxtQuantity.Font = new System.Drawing.Font("Palatino Linotype", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TxtQuantity.Location = new System.Drawing.Point(15, 205);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(116, 37);
            this.TxtQuantity.TabIndex = 5;
            this.TxtQuantity.ValueChanged += new System.EventHandler(this.TxtQuantity_ValueChanged);
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
            this.BtnAdd.ButtonText = "&Add";
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnAdd.IdleBorderThickness = 1;
            this.BtnAdd.IdleCornerRadius = 30;
            this.BtnAdd.IdleFillColor = System.Drawing.Color.White;
            this.BtnAdd.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnAdd.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.BtnAdd.Location = new System.Drawing.Point(126, 286);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(151, 54);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 23);
            this.label7.TabIndex = 110;
            this.label7.Text = "Total :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 23);
            this.label6.TabIndex = 109;
            this.label6.Text = "Quantity";
            // 
            // TxtPriceItem
            // 
            this.TxtPriceItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtPriceItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtPriceItem.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtPriceItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPriceItem.Enabled = false;
            this.TxtPriceItem.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPriceItem.ForeColor = System.Drawing.Color.White;
            this.TxtPriceItem.HintForeColor = System.Drawing.Color.White;
            this.TxtPriceItem.HintText = "Price in INR";
            this.TxtPriceItem.isPassword = false;
            this.TxtPriceItem.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.TxtPriceItem.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtPriceItem.LineMouseHoverColor = System.Drawing.Color.White;
            this.TxtPriceItem.LineThickness = 1;
            this.TxtPriceItem.Location = new System.Drawing.Point(13, 127);
            this.TxtPriceItem.Margin = new System.Windows.Forms.Padding(4);
            this.TxtPriceItem.MaxLength = 35;
            this.TxtPriceItem.Name = "TxtPriceItem";
            this.TxtPriceItem.Size = new System.Drawing.Size(156, 37);
            this.TxtPriceItem.TabIndex = 5;
            this.TxtPriceItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 23);
            this.label4.TabIndex = 108;
            this.label4.Text = "Price";
            // 
            // TxtNameItem
            // 
            this.TxtNameItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtNameItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtNameItem.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtNameItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNameItem.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNameItem.ForeColor = System.Drawing.Color.White;
            this.TxtNameItem.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.TxtNameItem.HintText = "Type item name";
            this.TxtNameItem.isPassword = false;
            this.TxtNameItem.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.TxtNameItem.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtNameItem.LineMouseHoverColor = System.Drawing.Color.White;
            this.TxtNameItem.LineThickness = 1;
            this.TxtNameItem.Location = new System.Drawing.Point(13, 52);
            this.TxtNameItem.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNameItem.MaxLength = 35;
            this.TxtNameItem.Name = "TxtNameItem";
            this.TxtNameItem.Size = new System.Drawing.Size(401, 37);
            this.TxtNameItem.TabIndex = 4;
            this.TxtNameItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 23);
            this.label5.TabIndex = 107;
            this.label5.Text = "Item Name";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(67)))), ((int)(((byte)(71)))));
            this.ItemsListBox.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 36;
            this.ItemsListBox.Location = new System.Drawing.Point(514, 180);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(263, 472);
            this.ItemsListBox.TabIndex = 102;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // TxtSearchItem
            // 
            this.TxtSearchItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtSearchItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtSearchItem.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtSearchItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtSearchItem.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearchItem.ForeColor = System.Drawing.Color.White;
            this.TxtSearchItem.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.TxtSearchItem.HintText = "Search item...";
            this.TxtSearchItem.isPassword = false;
            this.TxtSearchItem.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.TxtSearchItem.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtSearchItem.LineMouseHoverColor = System.Drawing.Color.White;
            this.TxtSearchItem.LineThickness = 1;
            this.TxtSearchItem.Location = new System.Drawing.Point(514, 114);
            this.TxtSearchItem.Margin = new System.Windows.Forms.Padding(5);
            this.TxtSearchItem.MaxLength = 15;
            this.TxtSearchItem.Name = "TxtSearchItem";
            this.TxtSearchItem.Size = new System.Drawing.Size(263, 46);
            this.TxtSearchItem.TabIndex = 4;
            this.TxtSearchItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtSearchItem.OnValueChanged += new System.EventHandler(this.TxtSearchItem_OnValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(503, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 632);
            this.panel2.TabIndex = 203;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.TxtCustomerEmail);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.TxtCustomerMobile);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.TxtCustomerName);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(41, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 248);
            this.panel3.TabIndex = 201;
            // 
            // TxtCustomerEmail
            // 
            this.TxtCustomerEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtCustomerEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtCustomerEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtCustomerEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCustomerEmail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerEmail.ForeColor = System.Drawing.Color.White;
            this.TxtCustomerEmail.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.TxtCustomerEmail.HintText = "customer@email.com";
            this.TxtCustomerEmail.isPassword = false;
            this.TxtCustomerEmail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.TxtCustomerEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtCustomerEmail.LineMouseHoverColor = System.Drawing.Color.White;
            this.TxtCustomerEmail.LineThickness = 1;
            this.TxtCustomerEmail.Location = new System.Drawing.Point(13, 188);
            this.TxtCustomerEmail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustomerEmail.MaxLength = 35;
            this.TxtCustomerEmail.Name = "TxtCustomerEmail";
            this.TxtCustomerEmail.Size = new System.Drawing.Size(401, 37);
            this.TxtCustomerEmail.TabIndex = 3;
            this.TxtCustomerEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 165);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 23);
            this.label10.TabIndex = 105;
            this.label10.Text = "Email";
            // 
            // TxtCustomerMobile
            // 
            this.TxtCustomerMobile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtCustomerMobile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtCustomerMobile.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtCustomerMobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCustomerMobile.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerMobile.ForeColor = System.Drawing.Color.White;
            this.TxtCustomerMobile.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.TxtCustomerMobile.HintText = "Mobile no...";
            this.TxtCustomerMobile.isPassword = false;
            this.TxtCustomerMobile.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.TxtCustomerMobile.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtCustomerMobile.LineMouseHoverColor = System.Drawing.Color.White;
            this.TxtCustomerMobile.LineThickness = 1;
            this.TxtCustomerMobile.Location = new System.Drawing.Point(13, 112);
            this.TxtCustomerMobile.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustomerMobile.MaxLength = 35;
            this.TxtCustomerMobile.Name = "TxtCustomerMobile";
            this.TxtCustomerMobile.Size = new System.Drawing.Size(401, 37);
            this.TxtCustomerMobile.TabIndex = 2;
            this.TxtCustomerMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 23);
            this.label12.TabIndex = 104;
            this.label12.Text = "Mobile";
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TxtCustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TxtCustomerName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TxtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCustomerName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCustomerName.ForeColor = System.Drawing.Color.White;
            this.TxtCustomerName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.TxtCustomerName.HintText = "Customer name";
            this.TxtCustomerName.isPassword = false;
            this.TxtCustomerName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(35)))), ((int)(((byte)(31)))));
            this.TxtCustomerName.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtCustomerName.LineMouseHoverColor = System.Drawing.Color.White;
            this.TxtCustomerName.LineThickness = 1;
            this.TxtCustomerName.Location = new System.Drawing.Point(13, 35);
            this.TxtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCustomerName.MaxLength = 35;
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(401, 37);
            this.TxtCustomerName.TabIndex = 1;
            this.TxtCustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 23);
            this.label13.TabIndex = 103;
            this.label13.Text = "Customer name";
            // 
            // UC_PlaceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlBackground);
            this.Name = "UC_PlaceOrder";
            this.Size = new System.Drawing.Size(1560, 912);
            this.Load += new System.EventHandler(this.UC_PlaceOrder_Load);
            this.Leave += new System.EventHandler(this.UC_PlaceOrder_Leave);
            this.PnlBackground.ResumeLayout(false);
            this.PnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuDropdown ComoboCategory;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel PnlBackground;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtSearchItem;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtNameItem;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnAdd;
        private System.Windows.Forms.NumericUpDown TxtQuantity;
        private System.Windows.Forms.Label LblFinalPrice;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnPrint;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnClearAll;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtCustomerEmail;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtCustomerMobile;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtCustomerName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblMsgPrice;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnRemove;
        private Bunifu.UI.WinForms.BunifuDataGridView DataGridView1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtPriceItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
    }
}
