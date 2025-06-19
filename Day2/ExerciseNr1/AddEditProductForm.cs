using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseNr1
{
    public partial class AddEditProductForm : Form
    {

        private JsonFileHelper<List<Product>> _fileHelper = new JsonFileHelper<List<Product>>(Program.FilePath);
        private int _productId;
        private Product _product;

        public AddEditProductForm(int id = 0)
        {
           
            InitializeComponent();
            _productId = id;

            getProductData();

            tbProductName.Select();
        }

       private void getProductData()
        {
            if (_productId != 0 )
            {
                Text = "Edit Product";
                var products = _fileHelper.DeserializeFromFile();
                _product = products.FirstOrDefault(x => x.Id == _productId);

                if (_product == null)
                    throw new Exception("no product with specified ID");

                fillTextboxes();
            }
        }
        private void fillTextboxes()
        {
            tbId.Text = _product.Id.ToString();
            tbProductName.Text = _product.ProductName;
            tbSku.Text = _product.Sku;
            tbQuantity.Text = _product.Quantity;
            tbPrice.Text = _product.Price;
        }
        private void AssignToNewProduct(List<Product> products)
        {
            var productsWithHighestId = products.OrderByDescending(x => x.Id).FirstOrDefault();
            _productId = productsWithHighestId == null ? 1 : productsWithHighestId.Id + 1;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            var products = _fileHelper.DeserializeFromFile();

            if (_productId != 0)
                products.RemoveAll(x => x.Id ==  _productId);
            else 
                AssignToNewProduct(products);

            AddNewProductToList(products);

            _fileHelper.SerializeToFile(products);
            Close();
        }

        private void AddNewProductToList(List<Product> products)
        {
            var product = new Product
            {
                Id = _productId,
                ProductName = tbProductName.Text,
                Sku = tbSku.Text,
                Quantity = tbQuantity.Text,
                Price = tbPrice.Text

            };
            products.Add(product);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
