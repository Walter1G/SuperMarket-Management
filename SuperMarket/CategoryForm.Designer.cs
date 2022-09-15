namespace SuperMarket
{
    partial class CategoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.manageCategoriespnl = new System.Windows.Forms.Panel();
            this.CatDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.editbtn = new System.Windows.Forms.Button();
            this.addbtn = new System.Windows.Forms.Button();
            this.catdescriptiontxt = new System.Windows.Forms.TextBox();
            this.agelbl = new System.Windows.Forms.Label();
            this.catnametxt = new System.Windows.Forms.TextBox();
            this.namelbl = new System.Windows.Forms.Label();
            this.catidtxt = new System.Windows.Forms.TextBox();
            this.idlbl = new System.Windows.Forms.Label();
            this.managecategorylbl = new System.Windows.Forms.Label();
            this.sellingbtn = new System.Windows.Forms.Button();
            this.productsbtn = new System.Windows.Forms.Button();
            this.sellerbtn = new System.Windows.Forms.Button();
            this.x_exitbtn = new System.Windows.Forms.Button();
            this.manageCategoriespnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // manageCategoriespnl
            // 
            this.manageCategoriespnl.BackColor = System.Drawing.Color.DarkOrange;
            this.manageCategoriespnl.Controls.Add(this.CatDGV);
            this.manageCategoriespnl.Controls.Add(this.deletebtn);
            this.manageCategoriespnl.Controls.Add(this.editbtn);
            this.manageCategoriespnl.Controls.Add(this.addbtn);
            this.manageCategoriespnl.Controls.Add(this.catdescriptiontxt);
            this.manageCategoriespnl.Controls.Add(this.agelbl);
            this.manageCategoriespnl.Controls.Add(this.catnametxt);
            this.manageCategoriespnl.Controls.Add(this.namelbl);
            this.manageCategoriespnl.Controls.Add(this.catidtxt);
            this.manageCategoriespnl.Controls.Add(this.idlbl);
            this.manageCategoriespnl.Controls.Add(this.managecategorylbl);
            this.manageCategoriespnl.Location = new System.Drawing.Point(182, 51);
            this.manageCategoriespnl.Name = "manageCategoriespnl";
            this.manageCategoriespnl.Size = new System.Drawing.Size(780, 483);
            this.manageCategoriespnl.TabIndex = 2;
            // 
            // CatDGV
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.CatDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CatDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.CatDGV.ColumnHeadersHeight = 30;
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CatDGV.DefaultCellStyle = dataGridViewCellStyle12;
            this.CatDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.Location = new System.Drawing.Point(289, 70);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersVisible = false;
            this.CatDGV.Size = new System.Drawing.Size(459, 391);
            this.CatDGV.TabIndex = 13;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CatDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.OrangeRed;
            this.CatDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CatDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.CatDGV.ThemeStyle.HeaderStyle.Height = 30;
            this.CatDGV.ThemeStyle.ReadOnly = false;
            this.CatDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CatDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CatDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatDGV.ThemeStyle.RowsStyle.Height = 22;
            this.CatDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CatDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CatDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CatDGV_CellContentClick);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.White;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.deletebtn.Location = new System.Drawing.Point(188, 233);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(86, 36);
            this.deletebtn.TabIndex = 12;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // editbtn
            // 
            this.editbtn.BackColor = System.Drawing.Color.White;
            this.editbtn.FlatAppearance.BorderSize = 0;
            this.editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.editbtn.Location = new System.Drawing.Point(103, 233);
            this.editbtn.Name = "editbtn";
            this.editbtn.Size = new System.Drawing.Size(79, 36);
            this.editbtn.TabIndex = 11;
            this.editbtn.Text = "EDIT";
            this.editbtn.UseVisualStyleBackColor = false;
            this.editbtn.Click += new System.EventHandler(this.editbtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.White;
            this.addbtn.FlatAppearance.BorderSize = 0;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.addbtn.Location = new System.Drawing.Point(20, 233);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(77, 36);
            this.addbtn.TabIndex = 5;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // catdescriptiontxt
            // 
            this.catdescriptiontxt.Location = new System.Drawing.Point(115, 153);
            this.catdescriptiontxt.Name = "catdescriptiontxt";
            this.catdescriptiontxt.Size = new System.Drawing.Size(159, 20);
            this.catdescriptiontxt.TabIndex = 6;
            // 
            // agelbl
            // 
            this.agelbl.AutoSize = true;
            this.agelbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelbl.ForeColor = System.Drawing.Color.White;
            this.agelbl.Location = new System.Drawing.Point(3, 154);
            this.agelbl.Name = "agelbl";
            this.agelbl.Size = new System.Drawing.Size(106, 19);
            this.agelbl.TabIndex = 5;
            this.agelbl.Text = "DESCRIPTION";
            // 
            // catnametxt
            // 
            this.catnametxt.Location = new System.Drawing.Point(115, 119);
            this.catnametxt.Name = "catnametxt";
            this.catnametxt.Size = new System.Drawing.Size(159, 20);
            this.catnametxt.TabIndex = 4;
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
            // catidtxt
            // 
            this.catidtxt.Location = new System.Drawing.Point(115, 87);
            this.catidtxt.Name = "catidtxt";
            this.catidtxt.Size = new System.Drawing.Size(159, 20);
            this.catidtxt.TabIndex = 2;
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
            // managecategorylbl
            // 
            this.managecategorylbl.AutoSize = true;
            this.managecategorylbl.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managecategorylbl.ForeColor = System.Drawing.Color.White;
            this.managecategorylbl.Location = new System.Drawing.Point(262, 10);
            this.managecategorylbl.Name = "managecategorylbl";
            this.managecategorylbl.Size = new System.Drawing.Size(271, 28);
            this.managecategorylbl.TabIndex = 0;
            this.managecategorylbl.Text = "MANAGE CATEGORIES";
            // 
            // sellingbtn
            // 
            this.sellingbtn.FlatAppearance.BorderSize = 0;
            this.sellingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellingbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellingbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.sellingbtn.Location = new System.Drawing.Point(25, 246);
            this.sellingbtn.Name = "sellingbtn";
            this.sellingbtn.Size = new System.Drawing.Size(116, 36);
            this.sellingbtn.TabIndex = 16;
            this.sellingbtn.Text = "Selling";
            this.sellingbtn.UseVisualStyleBackColor = true;
            // 
            // productsbtn
            // 
            this.productsbtn.FlatAppearance.BorderSize = 0;
            this.productsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productsbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.productsbtn.Location = new System.Drawing.Point(25, 204);
            this.productsbtn.Name = "productsbtn";
            this.productsbtn.Size = new System.Drawing.Size(116, 36);
            this.productsbtn.TabIndex = 15;
            this.productsbtn.Text = "Products";
            this.productsbtn.UseVisualStyleBackColor = true;
            // 
            // sellerbtn
            // 
            this.sellerbtn.FlatAppearance.BorderSize = 0;
            this.sellerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sellerbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellerbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.sellerbtn.Location = new System.Drawing.Point(33, 162);
            this.sellerbtn.Name = "sellerbtn";
            this.sellerbtn.Size = new System.Drawing.Size(108, 36);
            this.sellerbtn.TabIndex = 14;
            this.sellerbtn.Text = "Sellers";
            this.sellerbtn.UseVisualStyleBackColor = true;
            // 
            // x_exitbtn
            // 
            this.x_exitbtn.FlatAppearance.BorderSize = 0;
            this.x_exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x_exitbtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x_exitbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.x_exitbtn.Location = new System.Drawing.Point(924, 18);
            this.x_exitbtn.Name = "x_exitbtn";
            this.x_exitbtn.Size = new System.Drawing.Size(35, 27);
            this.x_exitbtn.TabIndex = 17;
            this.x_exitbtn.Text = "X";
            this.x_exitbtn.UseVisualStyleBackColor = true;
            this.x_exitbtn.Click += new System.EventHandler(this.x_exitbtn_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 611);
            this.Controls.Add(this.x_exitbtn);
            this.Controls.Add(this.sellingbtn);
            this.Controls.Add(this.manageCategoriespnl);
            this.Controls.Add(this.productsbtn);
            this.Controls.Add(this.sellerbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.manageCategoriespnl.ResumeLayout(false);
            this.manageCategoriespnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel manageCategoriespnl;
        private Guna.UI2.WinForms.Guna2DataGridView CatDGV;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Button editbtn;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox catdescriptiontxt;
        private System.Windows.Forms.Label agelbl;
        private System.Windows.Forms.TextBox catnametxt;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.TextBox catidtxt;
        private System.Windows.Forms.Label idlbl;
        private System.Windows.Forms.Label managecategorylbl;
        private System.Windows.Forms.Button sellingbtn;
        private System.Windows.Forms.Button productsbtn;
        private System.Windows.Forms.Button sellerbtn;
        private System.Windows.Forms.Button x_exitbtn;
    }
}