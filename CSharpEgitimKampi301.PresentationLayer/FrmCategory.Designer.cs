namespace CSharpEgitimKampi301.PresentationLayer
{
    partial class FrmCategory
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
            this.txt_CategoryId = new System.Windows.Forms.TextBox();
            this.btn_List = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_CategoryName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtn_Active = new System.Windows.Forms.RadioButton();
            this.rdbtn_Passive = new System.Windows.Forms.RadioButton();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_GetById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORY ID:";
            // 
            // txt_CategoryId
            // 
            this.txt_CategoryId.Location = new System.Drawing.Point(161, 63);
            this.txt_CategoryId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CategoryId.Name = "txt_CategoryId";
            this.txt_CategoryId.Size = new System.Drawing.Size(235, 22);
            this.txt_CategoryId.TabIndex = 1;
            // 
            // btn_List
            // 
            this.btn_List.Location = new System.Drawing.Point(128, 233);
            this.btn_List.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(269, 52);
            this.btn_List.TabIndex = 2;
            this.btn_List.Text = "LİSTELE";
            this.btn_List.UseVisualStyleBackColor = true;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(423, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(867, 522);
            this.dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "CATEGORY ADI:";
            // 
            // txt_CategoryName
            // 
            this.txt_CategoryName.Location = new System.Drawing.Point(161, 105);
            this.txt_CategoryName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CategoryName.Name = "txt_CategoryName";
            this.txt_CategoryName.Size = new System.Drawing.Size(235, 22);
            this.txt_CategoryName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-12, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "CATEGORY DURUM:";
            // 
            // rdbtn_Active
            // 
            this.rdbtn_Active.AutoSize = true;
            this.rdbtn_Active.Location = new System.Drawing.Point(161, 161);
            this.rdbtn_Active.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtn_Active.Name = "rdbtn_Active";
            this.rdbtn_Active.Size = new System.Drawing.Size(65, 20);
            this.rdbtn_Active.TabIndex = 4;
            this.rdbtn_Active.TabStop = true;
            this.rdbtn_Active.Text = "Active";
            this.rdbtn_Active.UseVisualStyleBackColor = true;
            // 
            // rdbtn_Passive
            // 
            this.rdbtn_Passive.AutoSize = true;
            this.rdbtn_Passive.Location = new System.Drawing.Point(304, 161);
            this.rdbtn_Passive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbtn_Passive.Name = "rdbtn_Passive";
            this.rdbtn_Passive.Size = new System.Drawing.Size(77, 20);
            this.rdbtn_Passive.TabIndex = 4;
            this.rdbtn_Passive.TabStop = true;
            this.rdbtn_Passive.Text = "Passive";
            this.rdbtn_Passive.UseVisualStyleBackColor = true;
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(128, 292);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(269, 52);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "GÜNCELLE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(128, 351);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(269, 52);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "EKLE";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(128, 410);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(269, 52);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "SİL";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_GetById
            // 
            this.btn_GetById.Location = new System.Drawing.Point(128, 469);
            this.btn_GetById.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_GetById.Name = "btn_GetById";
            this.btn_GetById.Size = new System.Drawing.Size(269, 52);
            this.btn_GetById.TabIndex = 2;
            this.btn_GetById.Text = "ID\'YE GÖRE GETİR";
            this.btn_GetById.UseVisualStyleBackColor = true;
            this.btn_GetById.Click += new System.EventHandler(this.btn_GetById_Click);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 554);
            this.Controls.Add(this.rdbtn_Passive);
            this.Controls.Add(this.rdbtn_Active);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_GetById);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_CategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_CategoryId);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCategory";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CategoryId;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_CategoryName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbtn_Active;
        private System.Windows.Forms.RadioButton rdbtn_Passive;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_GetById;
    }
}

