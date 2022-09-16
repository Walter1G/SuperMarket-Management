namespace SuperMarket
{
    partial class ProductForm
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
            this.manageProductspnl = new System.Windows.Forms.Panel();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ProdDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.categorycombo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.pricelbl = new System.Windows.Forms.Label();
            this.quanititytxt = new System.Windows.Forms.TextBox();
            this.quantitylbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.prodidtxt = new System.Windows.Forms.TextBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sellerbtn = new System.Windows.Forms.Button();
            this.categoriesbtn = new System.Windows.Forms.Button();
            this.sellingbtn = new System.Windows.Forms.Button();
            this.x_exitbtn = new System.Windows.Forms.Button();
            this.manageProductspnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // manageProductspnl
            // 
            this.manageProductspnl.BackColor = System.Drawing.Color.DarkOrange;
            this.manageProductspnl.Controls.Add(this.refreshbtn);
            this.manageProductspnl.Controls.Add(this.comboBox1);
            this.manageProductspnl.Controls.Add(this.ProdDGV);
            this.manageProductspnl.Controls.Add(this.deletebtn);
            this.manageProductspnl.Controls.Add(this.editbtn);
            this.manageProductspnl.Controls.Add(this.addbtn);
            this.manageProductspnl.Controls.Add(this.categorycombo);
            this.manageProductspnl.Controls.Add(this.label5);
            this.manageProductspnl.Controls.Add(this.pricetxt);
            this.manageProductspnl.Controls.Add(this.pricelbl);
            this.manageProductspnl.Controls.Add(this.quanititytxt);
            this.manageProductspnl.Controls.Add(this.quantitylbl);
            this.manageProductspnl.Controls.Add(this.nametxt);
            this.manageProductspnl.Controls.Add(this.namelbl);
            this.manageProductspnl.Controls.Add(this.prodidtxt);
            this.manageProductspnl.Controls.Add(this.idlbl);
            this.manageProductspnl.Controls.Add(this.label1);
            this.manageProductspnl.Location = new System.Drawing.Point(127, 31);
            this.manageProductspnl.Name = "manageProductspnl";
            this.manageProductspnl.Size = new System.Drawing.Size(780, 483);
            this.manageProductspnl.TabIndex = 0;
            // 
            // refreshbtn
            // 
            this.refreshbtn.BackColor = System.Drawing.Color.White;
            this.refreshbtn.FlatAppearance.BorderSize = 0;
            this.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.refreshbtn.Location = new System.Drawing.Point(587, 43);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(77, 24);
            this.refreshbtn.TabIndex = 15;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(422, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "SELECT CATEGORY";
            // 
            // ProdDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ProdDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProdDGV.ColumnHeadersHeight = 26;
            this.ProdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ProdDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProdDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ProdDGV.Location = new System.Drawing.Point(283, 70);
            this.ProdDGV.Name = "ProdDGV";
            this.ProdDGV.Size = new System.Drawing.Size(459, 391);
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
            this.ProdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProdDGV_CellContentClick);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.White;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.deletebtn.Location = new System.Drawing.Point(180, 277);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(86, 36);
            this.deletebtn.TabIndex = 12;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.White;
            this.editbtn.FlatAppearance.BorderSize = 0;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.editbtn.Location = new System.Drawing.Point(95, 277);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(79, 36);
            this.editbtn.TabIndex = 11;
            this.editbtn.Text = "EDIT";
            this.editbtn.UseVisualStyleBackColor = false;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.White;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.addbtn.Location = new System.Drawing.Point(12, 277);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(77, 36);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // categorycombo
            // 
            this.categorycombo.FormattingEnabled = true;
            this.categorycombo.Location = new System.Drawing.Point(107, 228);
            this.categorycombo.Name = "categorycombo";
            this.categorycombo.Size = new System.Drawing.Size(159, 21);
            this.categorycombo.TabIndex = 10;
            this.categorycombo.Text = "SELECT CATEGORY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "CATEGORY";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(107, 191);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(159, 20);
            this.pricetxt.TabIndex = 8;
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelbl.ForeColor = System.Drawing.Color.White;
            this.pricelbl.Location = new System.Drawing.Point(17, 192);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(51, 19);
            this.pricelbl.TabIndex = 7;
            this.pricelbl.Text = "PRICE";
            // 
            // quanititytxt
            // 
            this.quanititytxt.Location = new System.Drawing.Point(107, 154);
            this.quanititytxt.Name = "quanititytxt";
            this.quanititytxt.Size = new System.Drawing.Size(159, 20);
            this.quanititytxt.TabIndex = 6;
            // 
            // quantitylbl
            // 
            this.quantitylbl.AutoSize = true;
            this.quantitylbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitylbl.ForeColor = System.Drawing.Color.White;
            this.quantitylbl.Location = new System.Drawing.Point(17, 152);
            this.quantitylbl.Name = "quantitylbl";
            this.quantitylbl.Size = new System.Drawing.Size(84, 19);
            this.quantitylbl.TabIndex = 5;
            this.quantitylbl.Text = "QUANTITY";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(107, 120);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(159, 20);
            this.nametxt.TabIndex = 4;
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.Color.White;
            this.namelbl.Location = new System.Drawing.Point(17, 118);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(55, 19);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "NAME";
            // 
            // prodidtxt
            // 
            this.prodidtxt.Location = new System.Drawing.Point(107, 88);
            this.prodidtxt.Name = "prodidtxt";
            this.prodidtxt.Size = new System.Drawing.Size(159, 20);
            this.prodidtxt.TabIndex = 2;
            // 
            // idlbl
            // 
            this.idlbl.AutoSize = true;
            this.idlbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlbl.ForeColor = System.Drawing.Color.White;
            this.idlbl.Location = new System.Drawing.Point(17, 86);
            this.idlbl.Name = "idlbl";
            this.idlbl.Size = new System.Drawing.Size(24, 19);
            this.idlbl.TabIndex = 1;
            this.idlbl.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Products";
            // 
            // sellerbtn
            // 
            this.sellerbtn.FlatAppearance.BorderSize = 0;
            this.sellerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellerbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.sellerbtn.Location = new System.Drawing.Point(13, 77);
            this.sellerbtn.Name = "sellerbtn";
            this.sellerbtn.Size = new System.Drawing.Size(108, 36);
            this.sellerbtn.TabIndex = 1;
            this.sellerbtn.Text = "Sellers";
            this.sellerbtn.UseVisualStyleBackColor = true;
            // 
            // categoriesbtn
            // 
            this.categoriesbtn.FlatAppearance.BorderSize = 0;
            this.categoriesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoriesbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriesbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.categoriesbtn.Location = new System.Drawing.Point(5, 119);
            this.categoriesbtn.Name = "categoriesbtn";
            this.categoriesbtn.Size = new System.Drawing.Size(116, 36);
            this.categoriesbtn.TabIndex = 2;
            this.categoriesbtn.Text = "Categories";
            this.categoriesbtn.UseVisualStyleBackColor = true;
            this.categoriesbtn.Click += new System.EventHandler(this.categoriesbtn_Click);
            // 
            // sellingbtn
            // 
            this.sellingbtn.FlatAppearance.BorderSize = 0;
            this.sellingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellingbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.sellingbtn.Location = new System.Drawing.Point(5, 161);
            this.sellingbtn.Name = "sellingbtn";
            this.sellingbtn.Size = new System.Drawing.Size(116, 36);
            this.sellingbtn.TabIndex = 3;
            this.sellingbtn.Text = "Selling";
            this.sellingbtn.UseVisualStyleBackColor = true;
            // 
            // x_exitbtn
            // 
            this.x_exitbtn.FlatAppearance.BorderSize = 0;
            this.x_exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x_exitbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_exitbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.x_exitbtn.Location = new System.Drawing.Point(872, -2);
            this.x_exitbtn.Name = "x_exitbtn";
            this.x_exitbtn.Size = new System.Drawing.Size(35, 27);
            this.x_exitbtn.TabIndex = 4;
            this.x_exitbtn.Text = "X";
            this.x_exitbtn.UseVisualStyleBackColor = true;
            this.x_exitbtn.Click += new System.EventHandler(this.x_exitbtn_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 611);
            this.Controls.Add(this.x_exitbtn);
            this.Controls.Add(this.sellingbtn);
            this.Controls.Add(this.categoriesbtn);
            this.Controls.Add(this.sellerbtn);
            this.Controls.Add(this.manageProductspnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.manageProductspnl.ResumeLayout(false);
            this.manageProductspnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel manageProductspnl;
        private System.Windows.Forms.Button sellerbtn;
        private System.Windows.Forms.Button categoriesbtn;
        private System.Windows.Forms.Button sellingbtn;
        private System.Windows.Forms.Button x_exitbtn;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private Guna.UI2.WinForms.Guna2DataGridView ProdDGV;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.ComboBox categorycombo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.TextBox quanititytxt;
        private System.Windows.Forms.Label quantitylbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox prodidtxt;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label label1;
    }
}