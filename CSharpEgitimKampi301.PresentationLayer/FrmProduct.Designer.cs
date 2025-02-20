namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmProduct
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
            this.rdbtn_Active = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_GetById = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_List1 = new System.Windows.Forms.Button();
            this.txt_ProductName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ProductId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.cmb_Product = new System.Windows.Forms.ComboBox();
            this.btn_list2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ProductDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbtn_Active
            // 
            this.rdbtn_Active.AutoSize = true;
            this.rdbtn_Active.Location = new System.Drawing.Point(-78, 97);
            this.rdbtn_Active.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtn_Active.Name = "rdbtn_Active";
            this.rdbtn_Active.Size = new System.Drawing.Size(65, 20);
            this.rdbtn_Active.TabIndex = 17;
            this.rdbtn_Active.Text = "Active";
            this.rdbtn_Active.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-251, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "CATEGORY DURUM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-214, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "CATEGORY ADI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-204, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "CATEGORY ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(443, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(867, 522);
            this.dataGridView1.TabIndex = 28;
        
            // 
            // btn_GetById
            // 
            this.btn_GetById.Location = new System.Drawing.Point(157, 506);
            this.btn_GetById.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GetById.Name = "btn_GetById";
            this.btn_GetById.Size = new System.Drawing.Size(189, 32);
            this.btn_GetById.TabIndex = 23;
            this.btn_GetById.Text = "ID\'YE GÖRE GETİR";
            this.btn_GetById.UseVisualStyleBackColor = true;
            this.btn_GetById.Click += new System.EventHandler(this.btn_GetById_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(157, 466);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(189, 32);
            this.btn_Delete.TabIndex = 24;
            this.btn_Delete.Text = "SİL";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(157, 426);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(189, 32);
            this.btn_Add.TabIndex = 25;
            this.btn_Add.Text = "EKLE";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(157, 386);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(189, 32);
            this.btn_Update.TabIndex = 26;
            this.btn_Update.Text = "GÜNCELLE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_List1
            // 
            this.btn_List1.Location = new System.Drawing.Point(157, 340);
            this.btn_List1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_List1.Name = "btn_List1";
            this.btn_List1.Size = new System.Drawing.Size(95, 32);
            this.btn_List1.TabIndex = 27;
            this.btn_List1.Text = "LİSTELE1";
            this.btn_List1.UseVisualStyleBackColor = true;
            this.btn_List1.Click += new System.EventHandler(this.btn_List1_Click);
            // 
            // txt_ProductName
            // 
            this.txt_ProductName.Location = new System.Drawing.Point(181, 101);
            this.txt_ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductName.Name = "txt_ProductName";
            this.txt_ProductName.Size = new System.Drawing.Size(235, 22);
            this.txt_ProductName.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Product NAME:";
            // 
            // txt_ProductId
            // 
            this.txt_ProductId.Location = new System.Drawing.Point(181, 59);
            this.txt_ProductId.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductId.Name = "txt_ProductId";
            this.txt_ProductId.Size = new System.Drawing.Size(235, 22);
            this.txt_ProductId.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Product ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Product STOCK:";
            // 
            // txt_Stock
            // 
            this.txt_Stock.Location = new System.Drawing.Point(182, 144);
            this.txt_Stock.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(235, 22);
            this.txt_Stock.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Product PRİCE:";
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(182, 184);
            this.txt_Price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(235, 22);
            this.txt_Price.TabIndex = 21;
            // 
            // cmb_Product
            // 
            this.cmb_Product.FormattingEnabled = true;
            this.cmb_Product.Location = new System.Drawing.Point(182, 223);
            this.cmb_Product.Name = "cmb_Product";
            this.cmb_Product.Size = new System.Drawing.Size(203, 24);
            this.cmb_Product.TabIndex = 29;
            // 
            // btn_list2
            // 
            this.btn_list2.Location = new System.Drawing.Point(251, 340);
            this.btn_list2.Margin = new System.Windows.Forms.Padding(4);
            this.btn_list2.Name = "btn_list2";
            this.btn_list2.Size = new System.Drawing.Size(95, 32);
            this.btn_list2.TabIndex = 27;
            this.btn_list2.Text = "LİSTELE2";
            this.btn_list2.UseVisualStyleBackColor = true;
            this.btn_list2.Click += new System.EventHandler(this.btn_list2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(108, 231);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Category:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(95, 267);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Description:";
            // 
            // txt_ProductDescription
            // 
            this.txt_ProductDescription.Location = new System.Drawing.Point(181, 267);
            this.txt_ProductDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ProductDescription.Multiline = true;
            this.txt_ProductDescription.Name = "txt_ProductDescription";
            this.txt_ProductDescription.Size = new System.Drawing.Size(234, 65);
            this.txt_ProductDescription.TabIndex = 21;
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1318, 571);
            this.Controls.Add(this.cmb_Product);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_GetById);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_list2);
            this.Controls.Add(this.btn_List1);
            this.Controls.Add(this.txt_ProductDescription);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_ProductName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_ProductId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdbtn_Active);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmProduct";
            this.Text = "FrmProduct";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbtn_Active;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_GetById;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_List1;
        private System.Windows.Forms.TextBox txt_ProductName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ProductId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.ComboBox cmb_Product;
        private System.Windows.Forms.Button btn_list2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_ProductDescription;
    }
}