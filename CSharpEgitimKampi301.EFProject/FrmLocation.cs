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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEFProjectdbEntities db=new EgitimKampiEFProjectdbEntities();

        private void btn_List_Click(object sender, EventArgs e)
        {
            var values =db.Locations.ToList();  
            dataGridView1.DataSource = values;

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                Location location = new Location();
                location.Capacity = byte.Parse(nmrud_Capasity.Value.ToString());
                location.City = txt_City.Text;
                location.Country = txt_Country.Text;
                location.Price = decimal.Parse(txt_Price.Text);
                location.DayNight = txt_DayNight.Text;
                location.GuideId = int.Parse(cmbbox_Contacts.SelectedValue.ToString());
                db.Locations.Add(location);
                db.SaveChanges();
                MessageBox.Show("Ekleme işlemi başarılı");

            }
             catch { MessageBox.Show("Ekleme işlemi başarısız "); }
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {  //x=> çok işe yarıyor mantığını iyice kavra!!!!!!!!!!!11

            var values = db.Guides.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId,
            }).ToList();
            cmbbox_Contacts.DisplayMember = "FullName";
            cmbbox_Contacts.ValueMember = "GuideId";
            cmbbox_Contacts.DataSource = values;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txt_LocationId.Text);
                var updatedValue = db.Locations.Find(id);
                updatedValue.DayNight = txt_DayNight.Text;
                updatedValue.Capacity = byte.Parse(nmrud_Capasity.Value.ToString());
                updatedValue.Price = decimal.Parse( txt_Price.Text);
                updatedValue.Country = txt_Country.Text;
                updatedValue.City= txt_City.Text;
                updatedValue.GuideId=int.Parse(cmbbox_Contacts.SelectedValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Güncelleme işlemi başarılı");
            }
            catch {
                MessageBox.Show("güncelleme işlemi başarısız ");
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_LocationId.Text);
            var deleteLocation = db.Locations.Find(id);
            db.Locations.Remove(deleteLocation);
            db.SaveChanges();
            MessageBox.Show("silme işlemi başarılı ");
        }
    }
}
