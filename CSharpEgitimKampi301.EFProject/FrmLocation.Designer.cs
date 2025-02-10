namespace CSharpEgitimKampi301.EFProject
{
    partial class FrmLocation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_List = new System.Windows.Forms.Button();
            this.txt_LocationId = new System.Windows.Forms.TextBox();
            this.txt_City = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Country = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_DayNight = new System.Windows.Forms.TextBox();
            this.nmrud_Capasity = new System.Windows.Forms.NumericUpDown();
            this.cmbbox_Contacts = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrud_Capasity)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(240, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 375);
            this.dataGridView1.TabIndex = 15;
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_Remove.Location = new System.Drawing.Point(94, 445);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(139, 45);
            this.btn_Remove.TabIndex = 11;
            this.btn_Remove.Text = "Sil";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_update.Location = new System.Drawing.Point(94, 394);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(139, 45);
            this.btn_update.TabIndex = 12;
            this.btn_update.Text = "Güncelle";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_ekle.Location = new System.Drawing.Point(94, 343);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(139, 45);
            this.btn_ekle.TabIndex = 13;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.SandyBrown;
            this.btn_List.Location = new System.Drawing.Point(94, 292);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(139, 45);
            this.btn_List.TabIndex = 14;
            this.btn_List.Text = "Listele";
            this.btn_List.UseVisualStyleBackColor = false;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // txt_LocationId
            // 
            this.txt_LocationId.Location = new System.Drawing.Point(87, 57);
            this.txt_LocationId.Name = "txt_LocationId";
            this.txt_LocationId.Size = new System.Drawing.Size(139, 22);
            this.txt_LocationId.TabIndex = 7;
            // 
            // txt_City
            // 
            this.txt_City.Location = new System.Drawing.Point(87, 95);
            this.txt_City.Name = "txt_City";
            this.txt_City.Size = new System.Drawing.Size(139, 22);
            this.txt_City.TabIndex = 8;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(87, 168);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(139, 22);
            this.txt_Price.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şehir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fiyat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "LocationId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ülke";
            // 
            // txt_Country
            // 
            this.txt_Country.Location = new System.Drawing.Point(87, 133);
            this.txt_Country.Name = "txt_Country";
            this.txt_Country.Size = new System.Drawing.Size(139, 22);
            this.txt_Country.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kapasite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Rehber";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Gün Gece";
            // 
            // txt_DayNight
            // 
            this.txt_DayNight.Location = new System.Drawing.Point(87, 236);
            this.txt_DayNight.Name = "txt_DayNight";
            this.txt_DayNight.Size = new System.Drawing.Size(139, 22);
            this.txt_DayNight.TabIndex = 9;
            // 
            // nmrud_Capasity
            // 
            this.nmrud_Capasity.Location = new System.Drawing.Point(87, 204);
            this.nmrud_Capasity.Name = "nmrud_Capasity";
            this.nmrud_Capasity.Size = new System.Drawing.Size(139, 22);
            this.nmrud_Capasity.TabIndex = 16;
            // 
            // cmbbox_Contacts
            // 
            this.cmbbox_Contacts.FormattingEnabled = true;
            this.cmbbox_Contacts.Location = new System.Drawing.Point(87, 267);
            this.cmbbox_Contacts.Name = "cmbbox_Contacts";
            this.cmbbox_Contacts.Size = new System.Drawing.Size(139, 24);
            this.cmbbox_Contacts.TabIndex = 17;
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 675);
            this.Controls.Add(this.cmbbox_Contacts);
            this.Controls.Add(this.nmrud_Capasity);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.txt_LocationId);
            this.Controls.Add(this.txt_City);
            this.Controls.Add(this.txt_DayNight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Country);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLocation";
            this.Text = "FrmLocation";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrud_Capasity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.TextBox txt_LocationId;
        private System.Windows.Forms.TextBox txt_City;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Country;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_DayNight;
        private System.Windows.Forms.NumericUpDown nmrud_Capasity;
        private System.Windows.Forms.ComboBox cmbbox_Contacts;
    }
}