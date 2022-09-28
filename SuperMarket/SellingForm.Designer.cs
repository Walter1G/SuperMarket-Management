namespace SuperMarket
{
    partial class SellingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.manageProductspnl = new System.Windows.Forms.Panel();
            this.saleslistlbl = new System.Windows.Forms.Label();
            this.orderDVG = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantiy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billamountlbl = new System.Windows.Forms.Label();
            this.amountlbl = new System.Windows.Forms.Label();
            this.addProductbtn = new System.Windows.Forms.Button();
            this.sellerlbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.deletebtn = new System.Windows.Forms.Button();
            this.printbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.prodDVG1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ProdDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.categorycombo = new System.Windows.Forms.ComboBox();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.pricelbl = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.prodidtxt = new System.Windows.Forms.TextBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.x_exitbtn = new System.Windows.Forms.Button();
            this.manageProductspnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDVG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDVG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // manageProductspnl
            // 
            this.manageProductspnl.BackColor = System.Drawing.Color.DarkOrange;
            this.manageProductspnl.Controls.Add(this.saleslistlbl);
            this.manageProductspnl.Controls.Add(this.orderDVG);
            this.manageProductspnl.Controls.Add(this.billamountlbl);
            this.manageProductspnl.Controls.Add(this.amountlbl);
            this.manageProductspnl.Controls.Add(this.addProductbtn);
            this.manageProductspnl.Controls.Add(this.sellerlbl);
            this.manageProductspnl.Controls.Add(this.datelbl);
            this.manageProductspnl.Controls.Add(this.deletebtn);
            this.manageProductspnl.Controls.Add(this.printbtn);
            this.manageProductspnl.Controls.Add(this.addbtn);
            this.manageProductspnl.Controls.Add(this.button1);
            this.manageProductspnl.Controls.Add(this.prodDVG1);
            this.manageProductspnl.Controls.Add(this.refreshbtn);
            this.manageProductspnl.Controls.Add(this.comboBox1);
            this.manageProductspnl.Controls.Add(this.ProdDGV);
            this.manageProductspnl.Controls.Add(this.categorycombo);
            this.manageProductspnl.Controls.Add(this.quantitytxt);
            this.manageProductspnl.Controls.Add(this.pricelbl);
            this.manageProductspnl.Controls.Add(this.pricetxt);
            this.manageProductspnl.Controls.Add(this.quantitylbl);
            this.manageProductspnl.Controls.Add(this.nametxt);
            this.manageProductspnl.Controls.Add(this.namelbl);
            this.manageProductspnl.Controls.Add(this.prodidtxt);
            this.manageProductspnl.Controls.Add(this.idlbl);
            this.manageProductspnl.Controls.Add(this.label1);
            this.manageProductspnl.Location = new System.Drawing.Point(57, 28);
            this.manageProductspnl.Name = "manageProductspnl";
            this.manageProductspnl.Size = new System.Drawing.Size(905, 601);
            this.manageProductspnl.TabIndex = 1;
            this.manageProductspnl.Paint += new System.Windows.Forms.PaintEventHandler(this.manageProductspnl_Paint);
            // 
            // saleslistlbl
            // 
            this.saleslistlbl.AutoSize = true;
            this.saleslistlbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleslistlbl.ForeColor = System.Drawing.Color.White;
            this.saleslistlbl.Location = new System.Drawing.Point(361, 329);
            this.saleslistlbl.Name = "saleslistlbl";
            this.saleslistlbl.Size = new System.Drawing.Size(124, 28);
            this.saleslistlbl.TabIndex = 27;
            this.saleslistlbl.Text = "SALES LIST";
            this.saleslistlbl.UseMnemonic = false;
            // 
            // orderDVG
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.orderDVG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.orderDVG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.orderDVG.ColumnHeadersHeight = 26;
            this.orderDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderDVG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.prodName,
            this.price,
            this.quantiy,
            this.total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.orderDVG.DefaultCellStyle = dataGridViewCellStyle3;
            this.orderDVG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderDVG.Location = new System.Drawing.Point(357, 103);
            this.orderDVG.Name = "orderDVG";
            this.orderDVG.RowHeadersVisible = false;
            this.orderDVG.Size = new System.Drawing.Size(511, 169);
            this.orderDVG.TabIndex = 26;
            this.orderDVG.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.orderDVG.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.orderDVG.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.orderDVG.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.orderDVG.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.orderDVG.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.orderDVG.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderDVG.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.orderDVG.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.orderDVG.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDVG.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.orderDVG.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.orderDVG.ThemeStyle.HeaderStyle.Height = 26;
            this.orderDVG.ThemeStyle.ReadOnly = false;
            this.orderDVG.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.orderDVG.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.orderDVG.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDVG.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.orderDVG.ThemeStyle.RowsStyle.Height = 22;
            this.orderDVG.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.orderDVG.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // id
            // 
            this.id.HeaderText = "ProdID";
            this.id.Name = "id";
            // 
            // prodName
            // 
            this.prodName.HeaderText = "ProdName";
            this.prodName.Name = "prodName";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // quantiy
            // 
            this.quantiy.HeaderText = "Quantity";
            this.quantiy.Name = "quantiy";
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // billamountlbl
            // 
            this.billamountlbl.AutoSize = true;
            this.billamountlbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billamountlbl.ForeColor = System.Drawing.Color.White;
            this.billamountlbl.Location = new System.Drawing.Point(534, 275);
            this.billamountlbl.Name = "billamountlbl";
            this.billamountlbl.Size = new System.Drawing.Size(32, 28);
            this.billamountlbl.TabIndex = 25;
            this.billamountlbl.Text = "--";
            // 
            // amountlbl
            // 
            this.amountlbl.AutoSize = true;
            this.amountlbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountlbl.ForeColor = System.Drawing.Color.White;
            this.amountlbl.Location = new System.Drawing.Point(425, 275);
            this.amountlbl.Name = "amountlbl";
            this.amountlbl.Size = new System.Drawing.Size(103, 28);
            this.amountlbl.TabIndex = 24;
            this.amountlbl.Text = "Amount";
            this.amountlbl.UseMnemonic = false;
            // 
            // addProductbtn
            // 
            this.addProductbtn.BackColor = System.Drawing.Color.White;
            this.addProductbtn.FlatAppearance.BorderSize = 0;
            this.addProductbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.addProductbtn.Location = new System.Drawing.Point(141, 168);
            this.addProductbtn.Name = "addProductbtn";
            this.addProductbtn.Size = new System.Drawing.Size(158, 36);
            this.addProductbtn.TabIndex = 23;
            this.addProductbtn.Text = "Add Product";
            this.addProductbtn.UseVisualStyleBackColor = false;
            this.addProductbtn.Click += new System.EventHandler(this.addProductbtn_Click);
            // 
            // sellerlbl
            // 
            this.sellerlbl.AutoSize = true;
            this.sellerlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerlbl.ForeColor = System.Drawing.Color.White;
            this.sellerlbl.Location = new System.Drawing.Point(3, 11);
            this.sellerlbl.Name = "sellerlbl";
            this.sellerlbl.Size = new System.Drawing.Size(56, 19);
            this.sellerlbl.TabIndex = 22;
            this.sellerlbl.Text = "SELLER";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.ForeColor = System.Drawing.Color.White;
            this.datelbl.Location = new System.Drawing.Point(716, 11);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(47, 19);
            this.datelbl.TabIndex = 21;
            this.datelbl.Text = "DATE";
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.White;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.deletebtn.Location = new System.Drawing.Point(616, 535);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(86, 36);
            this.deletebtn.TabIndex = 20;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.Color.White;
            this.printbtn.FlatAppearance.BorderSize = 0;
            this.printbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.printbtn.Location = new System.Drawing.Point(511, 535);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(79, 36);
            this.printbtn.TabIndex = 19;
            this.printbtn.Text = "PRINT";
            this.printbtn.UseVisualStyleBackColor = false;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.White;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.addbtn.Location = new System.Drawing.Point(396, 535);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(77, 36);
            this.addbtn.TabIndex = 18;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(186, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // prodDVG1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.prodDVG1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodDVG1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.prodDVG1.ColumnHeadersHeight = 26;
            this.prodDVG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prodDVG1.DefaultCellStyle = dataGridViewCellStyle6;
            this.prodDVG1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDVG1.Location = new System.Drawing.Point(3, 244);
            this.prodDVG1.Name = "prodDVG1";
            this.prodDVG1.RowHeadersVisible = false;
            this.prodDVG1.Size = new System.Drawing.Size(303, 327);
            this.prodDVG1.TabIndex = 16;
            this.prodDVG1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.prodDVG1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.prodDVG1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.prodDVG1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.prodDVG1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.prodDVG1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.prodDVG1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDVG1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.prodDVG1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.prodDVG1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDVG1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.prodDVG1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.prodDVG1.ThemeStyle.HeaderStyle.Height = 26;
            this.prodDVG1.ThemeStyle.ReadOnly = false;
            this.prodDVG1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.prodDVG1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.prodDVG1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodDVG1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodDVG1.ThemeStyle.RowsStyle.Height = 22;
            this.prodDVG1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.prodDVG1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.prodDVG1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodDVG1_CellContentClick);
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.White;
            this.refreshbtn.FlatAppearance.BorderSize = 0;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.refreshbtn.Location = new System.Drawing.Point(647, 68);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(77, 24);
            this.refreshbtn.TabIndex = 15;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(467, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 29);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "SELECT CATEGORY";
            // 
            // ProdDGV
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ProdDGV.ColumnHeadersHeight = 26;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle9;
            this.ProdDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.Location = new System.Drawing.Point(357, 360);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.RowHeadersVisible = false;
            this.ProdDGV.Size = new System.Drawing.Size(511, 169);
            this.ProdDGV.TabIndex = 13;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ProdDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ProdDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ProdDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ProdDGV.ThemeStyle.HeaderStyle.Height = 26;
            this.ProdDGV.ThemeStyle.ReadOnly = false;
            this.ProdDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ProdDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ProdDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ProdDGV.ThemeStyle.RowsStyle.Height = 22;
            this.ProdDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // categorycombo
            // 
            this.categorycombo.FormattingEnabled = true;
            this.categorycombo.Location = new System.Drawing.Point(7, 209);
            this.categorycombo.Name = "categorycombo";
            this.categorycombo.Size = new System.Drawing.Size(159, 29);
            this.categorycombo.TabIndex = 10;
            this.categorycombo.Text = "SELECT CATEGORY";
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(95, 136);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(204, 27);
            this.quantitytxt.TabIndex = 8;
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.ForeColor = System.Drawing.Color.White;
            this.pricelbl.Location = new System.Drawing.Point(17, 136);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(74, 19);
            this.pricelbl.TabIndex = 7;
            this.pricelbl.Text = "Quantity";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(95, 103);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.ReadOnly = true;
            this.pricetxt.Size = new System.Drawing.Size(204, 27);
            this.pricetxt.TabIndex = 6;
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitylbl.ForeColor = System.Drawing.Color.White;
            this.quantitylbl.Location = new System.Drawing.Point(42, 103);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(47, 19);
            this.quantitylbl.TabIndex = 5;
            this.quantitylbl.Text = "Price";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(95, 71);
            this.nametxt.Name = "nametxt";
            this.nametxt.ReadOnly = true;
            this.nametxt.Size = new System.Drawing.Size(204, 27);
            this.nametxt.TabIndex = 4;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.Color.White;
            this.namelbl.Location = new System.Drawing.Point(-2, 71);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(93, 19);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "ProdName";
            // 
            // prodidtxt
            // 
            this.prodidtxt.Location = new System.Drawing.Point(95, 40);
            this.prodidtxt.Name = "prodidtxt";
            this.prodidtxt.Size = new System.Drawing.Size(204, 27);
            this.prodidtxt.TabIndex = 2;
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.ForeColor = System.Drawing.Color.White;
            this.idlbl.Location = new System.Drawing.Point(17, 43);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(55, 19);
            this.idlbl.TabIndex = 1;
            this.idlbl.Text = "BILL ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(391, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLING";
            // 
            // x_exitbtn
            // 
            this.x_exitbtn.FlatAppearance.BorderSize = 0;
            this.x_exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x_exitbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_exitbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.x_exitbtn.Location = new System.Drawing.Point(956, 1);
            this.x_exitbtn.Name = "x_exitbtn";
            this.x_exitbtn.Size = new System.Drawing.Size(35, 27);
            this.x_exitbtn.TabIndex = 5;
            this.x_exitbtn.Text = "X";
            this.x_exitbtn.UseVisualStyleBackColor = true;
            this.x_exitbtn.Click += new System.EventHandler(this.x_exitbtn_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 611);
            this.Controls.Add(this.x_exitbtn);
            this.Controls.Add(this.manageProductspnl);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.manageProductspnl.ResumeLayout(false);
            this.manageProductspnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderDVG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDVG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel manageProductspnl;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2DataGridView ProdDGV;
        private System.Windows.Forms.ComboBox categorycombo;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox prodidtxt;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView prodDVG1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button x_exitbtn;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label sellerlbl;
        private System.Windows.Forms.Button addProductbtn;
        private System.Windows.Forms.Label billamountlbl;
        private System.Windows.Forms.Label amountlbl;
        private System.Windows.Forms.Label saleslistlbl;
        private Guna.UI2.WinForms.Guna2DataGridView orderDVG;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantiy;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}