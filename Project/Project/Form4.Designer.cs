namespace Project
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sprice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.pprice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.qty = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.name = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.id = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Product_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnview = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnupdate = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btndelete = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnclose = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ctg = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.category = new MaterialSkin.Controls.MaterialLabel();
            this.Product_Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialRaisedButton3 = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 44;
            this.label1.Text = "ADD NEW Product";
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialRaisedButton1.Location = new System.Drawing.Point(18, 403);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(193, 56);
            this.materialRaisedButton1.TabIndex = 41;
            this.materialRaisedButton1.Text = "Insert";
            this.materialRaisedButton1.UseVisualStyleBackColor = false;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // sprice
            // 
            this.sprice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sprice.Depth = 0;
            this.sprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sprice.Hint = "";
            this.sprice.Location = new System.Drawing.Point(128, 324);
            this.sprice.MouseState = MaterialSkin.MouseState.HOVER;
            this.sprice.Name = "sprice";
            this.sprice.PasswordChar = '\0';
            this.sprice.SelectedText = "";
            this.sprice.SelectionLength = 0;
            this.sprice.SelectionStart = 0;
            this.sprice.Size = new System.Drawing.Size(166, 23);
            this.sprice.TabIndex = 36;
            this.sprice.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(14, 324);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(88, 19);
            this.materialLabel6.TabIndex = 30;
            this.materialLabel6.Text = "Sale-Price  :";
            // 
            // pprice
            // 
            this.pprice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pprice.Depth = 0;
            this.pprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pprice.Hint = "";
            this.pprice.Location = new System.Drawing.Point(128, 281);
            this.pprice.MouseState = MaterialSkin.MouseState.HOVER;
            this.pprice.Name = "pprice";
            this.pprice.PasswordChar = '\0';
            this.pprice.SelectedText = "";
            this.pprice.SelectionLength = 0;
            this.pprice.SelectionStart = 0;
            this.pprice.Size = new System.Drawing.Size(166, 23);
            this.pprice.TabIndex = 37;
            this.pprice.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(14, 281);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(51, 19);
            this.materialLabel5.TabIndex = 31;
            this.materialLabel5.Text = "Price :";
            // 
            // qty
            // 
            this.qty.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.qty.Depth = 0;
            this.qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty.Hint = "";
            this.qty.Location = new System.Drawing.Point(128, 237);
            this.qty.MouseState = MaterialSkin.MouseState.HOVER;
            this.qty.Name = "qty";
            this.qty.PasswordChar = '\0';
            this.qty.SelectedText = "";
            this.qty.SelectionLength = 0;
            this.qty.SelectionStart = 0;
            this.qty.Size = new System.Drawing.Size(166, 23);
            this.qty.TabIndex = 38;
            this.qty.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(14, 237);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 19);
            this.materialLabel3.TabIndex = 33;
            this.materialLabel3.Text = "Quantity  :";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.name.Depth = 0;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Hint = "";
            this.name.Location = new System.Drawing.Point(128, 189);
            this.name.MouseState = MaterialSkin.MouseState.HOVER;
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.SelectedText = "";
            this.name.SelectionLength = 0;
            this.name.SelectionStart = 0;
            this.name.Size = new System.Drawing.Size(166, 23);
            this.name.TabIndex = 39;
            this.name.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(14, 189);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 34;
            this.materialLabel2.Text = "Name  :";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.id.Depth = 0;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Hint = "";
            this.id.Location = new System.Drawing.Point(128, 144);
            this.id.MouseState = MaterialSkin.MouseState.HOVER;
            this.id.Name = "id";
            this.id.PasswordChar = '\0';
            this.id.SelectedText = "";
            this.id.SelectionLength = 0;
            this.id.SelectionStart = 0;
            this.id.Size = new System.Drawing.Size(166, 23);
            this.id.TabIndex = 40;
            this.id.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(14, 148);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(35, 19);
            this.materialLabel1.TabIndex = 35;
            this.materialLabel1.Text = "ID  :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_ID,
            this.Product_Name,
            this.Quantity,
            this.Price,
            this.Sale_Price,
            this.Product_Category});
            this.dataGridView1.Location = new System.Drawing.Point(10, 474);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 247);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Product_ID
            // 
            this.Product_ID.HeaderText = "Product_ID";
            this.Product_ID.Name = "Product_ID";
            // 
            // Product_Name
            // 
            this.Product_Name.HeaderText = "Product_Name";
            this.Product_Name.Name = "Product_Name";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Sale_Price
            // 
            this.Sale_Price.HeaderText = "Sale_Price";
            this.Sale_Price.Name = "Sale_Price";
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnview.Depth = 0;
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(507, 114);
            this.btnview.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnview.Name = "btnview";
            this.btnview.Primary = true;
            this.btnview.Size = new System.Drawing.Size(125, 58);
            this.btnview.TabIndex = 46;
            this.btnview.Text = "Show All Products";
            this.btnview.UseVisualStyleBackColor = false;
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnupdate.Depth = 0;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(507, 194);
            this.btnupdate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Primary = true;
            this.btnupdate.Size = new System.Drawing.Size(125, 59);
            this.btnupdate.TabIndex = 46;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndelete.Depth = 0;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(507, 270);
            this.btndelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btndelete.Name = "btndelete";
            this.btndelete.Primary = true;
            this.btndelete.Size = new System.Drawing.Size(125, 59);
            this.btndelete.TabIndex = 46;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnclose.Depth = 0;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(507, 426);
            this.btnclose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnclose.Name = "btnclose";
            this.btnclose.Primary = true;
            this.btnclose.Size = new System.Drawing.Size(125, 33);
            this.btnclose.TabIndex = 46;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // ctg
            // 
            this.ctg.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ctg.Depth = 0;
            this.ctg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctg.Hint = "";
            this.ctg.Location = new System.Drawing.Point(128, 369);
            this.ctg.MouseState = MaterialSkin.MouseState.HOVER;
            this.ctg.Name = "ctg";
            this.ctg.PasswordChar = '\0';
            this.ctg.SelectedText = "";
            this.ctg.SelectionLength = 0;
            this.ctg.SelectionStart = 0;
            this.ctg.Size = new System.Drawing.Size(166, 23);
            this.ctg.TabIndex = 36;
            this.ctg.UseSystemPasswordChar = false;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.category.Depth = 0;
            this.category.Font = new System.Drawing.Font("Roboto", 11F);
            this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.category.Location = new System.Drawing.Point(14, 369);
            this.category.MouseState = MaterialSkin.MouseState.HOVER;
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(81, 19);
            this.category.TabIndex = 30;
            this.category.Text = "Category  :";
            // 
            // Product_Category
            // 
            this.Product_Category.HeaderText = "Product_Category";
            this.Product_Category.Name = "Product_Category";
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Location = new System.Drawing.Point(507, 369);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(125, 34);
            this.materialRaisedButton2.TabIndex = 47;
            this.materialRaisedButton2.Text = "BACK";
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            this.materialRaisedButton2.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // materialRaisedButton3
            // 
            this.materialRaisedButton3.Depth = 0;
            this.materialRaisedButton3.Location = new System.Drawing.Point(219, 403);
            this.materialRaisedButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton3.Name = "materialRaisedButton3";
            this.materialRaisedButton3.Primary = true;
            this.materialRaisedButton3.Size = new System.Drawing.Size(75, 56);
            this.materialRaisedButton3.TabIndex = 48;
            this.materialRaisedButton3.Text = "REFRESH";
            this.materialRaisedButton3.UseVisualStyleBackColor = true;
            this.materialRaisedButton3.Click += new System.EventHandler(this.materialRaisedButton3_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 728);
            this.Controls.Add(this.materialRaisedButton3);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.ctg);
            this.Controls.Add(this.sprice);
            this.Controls.Add(this.category);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.pprice);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.id);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form4";
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField sprice;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField pprice;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField qty;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialSingleLineTextField name;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField id;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Price;
        private MaterialSkin.Controls.MaterialRaisedButton btnview;
        private MaterialSkin.Controls.MaterialRaisedButton btnupdate;
        private MaterialSkin.Controls.MaterialRaisedButton btndelete;
        private MaterialSkin.Controls.MaterialRaisedButton btnclose;
        private MaterialSkin.Controls.MaterialSingleLineTextField ctg;
        private MaterialSkin.Controls.MaterialLabel category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Category;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton3;
    }
}