using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEFProjectdbEntities db = new EgitimKampiEFProjectdbEntities();
        private void btn_List_Click(object sender, EventArgs e)
        {
           
            var values=db.Guides.ToList();
            dataGridView1.DataSource = values;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
         
            Guide guide = new Guide();
            guide.GuideSurname = txt_Surname.Text;
            guide.GuideName= txt_Name.Text;
            db.Guides.Add(guide);
            db.SaveChanges();
            MessageBox.Show("Başarıyla eklendi",  "bildirim",MessageBoxButtons.OK,MessageBoxIcon.Information  );

        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txt_GuideId.Text);
                var RemoveValues = db.Guides.Find(id);
                db.Guides.Remove(RemoveValues);
                db.SaveChanges();
                MessageBox.Show("Başarıyla silindi", "bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           catch { MessageBox.Show("Hata oluştu idyi kontrol et", "bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_GuideId.Text);
            var UpdatedValue = db.Guides.Find(id);
            UpdatedValue.GuideName=txt_Name.Text;
            UpdatedValue.GuideSurname=txt_Surname.Text;
            db.SaveChanges();
            MessageBox.Show("Başarıyla güncellendi", "bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_GetById_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txt_GuideId.Text);
                var Values = db.Guides.Where(x => x.GuideId == id).ToList();
                dataGridView1.DataSource = Values;
            }
        

             catch { MessageBox.Show("Hata oluştu idyi kontrol et", "bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
    
}
