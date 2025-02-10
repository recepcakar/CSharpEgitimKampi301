namespace CSharpEgitimKampi301.EFProject
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_GuideId = new System.Windows.Forms.TextBox();
            this.btn_List = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.Btn_GetById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "GuideId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "GuideSurname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "GuideName";
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(113, 100);
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(140, 22);
            this.txt_Surname.TabIndex = 1;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(113, 62);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(140, 22);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_GuideId
            // 
            this.txt_GuideId.Location = new System.Drawing.Point(113, 27);
            this.txt_GuideId.Name = "txt_GuideId";
            this.txt_GuideId.Size = new System.Drawing.Size(140, 22);
            this.txt_GuideId.TabIndex = 1;
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_List.Location = new System.Drawing.Point(113, 153);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(140, 45);
            this.btn_List.TabIndex = 2;
            this.btn_List.Text = "Listele";
            this.btn_List.UseVisualStyleBackColor = false;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(259, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(764, 375);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_ekle.Location = new System.Drawing.Point(113, 204);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(140, 45);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_update.Location = new System.Drawing.Point(113, 255);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(140, 45);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_Remove.Location = new System.Drawing.Point(113, 306);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(140, 45);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Sil";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // Btn_GetById
            // 
            this.Btn_GetById.BackColor = System.Drawing.Color.SandyBrown;
            this.Btn_GetById.Location = new System.Drawing.Point(113, 357);
            this.Btn_GetById.Name = "Btn_GetById";
            this.Btn_GetById.Size = new System.Drawing.Size(140, 45);
            this.Btn_GetById.TabIndex = 2;
            this.Btn_GetById.Text = "Id\'ye göre getir";
            this.Btn_GetById.UseVisualStyleBackColor = false;
            this.Btn_GetById.Click += new System.EventHandler(this.Btn_GetById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 415);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Btn_GetById);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.txt_GuideId);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Surname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Rehber İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_GuideId;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button Btn_GetById;
    }
}

