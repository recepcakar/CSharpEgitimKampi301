using CSharpEgitimKampi301.BusinessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CSharpEgitimKampi301.BusinessLayer.Concreate;
using CSharpEgitimKampi301.DataAccessLayer.EntityFramework;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System.Windows.Markup;
using CSharpEgitimKampi301.DataAccessLayer.Context;
namespace CSharpEgitimKampi301.PresentationLayer
{
    public partial class FrmProduct : Form
    {
        private readonly IProductService _productService; //Bu satırı silip productmanageri class seviyesinde tanımlayabiliriz
        private readonly ICategoryService _categoryService;
        public FrmProduct()
        {
            InitializeComponent();
            _productService = new ProductManger(new EFProductDal());
            _categoryService = new CategoryManager(new EFCategoryDal()); //içerideki methodalra erişmek için kullanırız
        }
        
        private void btn_List1_Click(object sender, EventArgs e)
        {
            var values = _productService.TgetAll();
            dataGridView1.DataSource = values;

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var id=int.Parse(txt_ProductId.Text);
            var DeletedValues = _productService.TGetById(id);
            _productService.Tdelete(DeletedValues);
            MessageBox.Show("Silindi ", "bilgi");
        }

        private void btn_GetById_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txt_ProductId.Text);
            var GetByIdValues = _productService.TGetById(id);
            dataGridView1.DataSource = GetByIdValues;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductDescription=txt_ProductDescription.Text;
            product.ProductPrice=Convert.ToDecimal(txt_Price.Text);
            product.ProductStock=Convert.ToInt32(txt_Stock.Text);
            product.ProductName=txt_ProductName.Text;
            product.CategoryId=int.Parse(cmb_Product.SelectedValue.ToString());
            _productService.Tinsert(product);
            MessageBox.Show("ekleme yapıldı", "Bilgilendirme");

        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {

            var values = _categoryService.TgetAll();
            cmb_Product.DataSource = values;
            cmb_Product.DisplayMember = "CatogoryName";
            cmb_Product.ValueMember = "CategoryId";
        
          


        }

        private void btn_list2_Click(object sender, EventArgs e)
        {
            var values = _productService.TGetProductsWithCategory();
            dataGridView1 .DataSource = values;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id= int.Parse(txt_ProductId.Text);
            var value = _productService.TGetById(id);
            value.ProductName=txt_ProductName.Text;
            value.ProductPrice = Convert.ToDecimal(txt_Price.Text);
            value.ProductDescription=txt_ProductDescription.Text;
            value.ProductStock= Convert.ToInt32(txt_Stock.Text);
            value.CategoryId=int.Parse(cmb_Product.SelectedValue.ToString());
            _productService.Tupdate(value);
            MessageBox.Show("guncelleme yapıldı", "Bilgilendirme");
        }

     
        
    }
} 
