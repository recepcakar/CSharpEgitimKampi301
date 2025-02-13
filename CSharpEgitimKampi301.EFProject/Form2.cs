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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        EgitimKampiEFProjectdbEntities db =new EgitimKampiEFProjectdbEntities();

        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_LocationCount.Text=db.Locations.Count().ToString();
            lbl_TotalCapacity.Text=db.Locations.Sum(x=>x.Capacity).ToString();
            lbl_GuideCount.Text=db.Guides.Count().ToString();
            lbl_AvarageCapasitiy.Text = db.Locations.Average(x=> (double)x.Capacity).ToString("0");
            lbl_AveragePrice.Text = db.Locations.
                Average(x =>x.Price)?.ToString("0.0")
                ;
            var LastCountryId=db.Locations.Max(x=>x.LocationId);

            lbl_LastCountry.Text = db.Locations.Where(x => x.LocationId == LastCountryId)
                                       .Select(x => x.Country) //country seç 
                                       .FirstOrDefault(); // bütün liste değil 1 tane 
            lbl_TourCapasitiyOfTurkey.Text = db.Locations.Where(x => x.Country == "Türkiye").
                Sum(x => x.Capacity).ToString();
           
            lbl_AvarageofTourCapasity.Text=db.Locations.Where(x=> x.Country =="Türkiye").Average(x=>(double)x.Capacity).ToString("0.0");

            var İstanbulGuideId = db.Locations.Where(x => x.City=="İstanbul").Select(y=>y.GuideId).FirstOrDefault();
            lbl_GuıdeName.Text = db.Guides
                .Where(x => x.GuideId == İstanbulGuideId)
                .Select(y => y.GuideName + " " + y.GuideSurname)
                .FirstOrDefault()
                .ToString();
            var maxkapasiteid= db.Locations.Max(x=>x.Capacity);
            lbl_MaxCapasityLocation.Text=db.Locations.Where(x=>x.Capacity==maxkapasiteid).Select(y=>y.City).FirstOrDefault().ToString();

            var maxPrice = db.Locations.Max(x => x.Price);
            lbl_MaxPrice.Text=db.Locations.Where(x=>x.Price==maxPrice).Select(y=>y.City).FirstOrDefault().ToString();

            var GuideIdAliKara = db.Guides.Where(x => x.GuideName == "Ali" && x.GuideSurname == "Kara").Select(x => x.GuideId).FirstOrDefault();
            lbl_aliTur.Text = db.Locations.Where(x => x.GuideId == GuideIdAliKara).Count().ToString();
        }

     
    }
}
