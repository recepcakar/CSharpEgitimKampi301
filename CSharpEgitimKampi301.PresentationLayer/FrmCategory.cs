using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.BusinessLayer.Concreate;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmCategory : Form
    { 
        private readonly ICategoryService _categoryService;

        public FrmCategory() //ctor yapıyoruz
        {
            
            _categoryService = new CategoryManager(new EFCategoryDal() );
            InitializeComponent();
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            var categoryValues = _categoryService.TgetAll();
            dataGridView1.DataSource = categoryValues;  
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.CatogoryName=txt_CategoryName.Text;
            category.CatogoryStatus=true;
            _categoryService.Tinsert(category);
            MessageBox.Show("eklendi","bilgi");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txt_CategoryId.Text);
            var deletedValues = _categoryService.TGetById(id);
            _categoryService.Tdelete(deletedValues);
            MessageBox.Show("Silindi    ", "bilgi");


        }

        private void btn_GetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_CategoryId.Text);
            var GetByIdValues=_categoryService.TGetById(id);
            dataGridView1.DataSource=GetByIdValues;

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(txt_CategoryId.Text);
            var categoryValues = _categoryService.TGetById(id);
            categoryValues.CatogoryName = txt_CategoryName.Text;
            categoryValues.CatogoryStatus=true;
            _categoryService.Tupdate(categoryValues);
            MessageBox.Show("Güncellendi    ", "bilgi");
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {

        }
    }
}
