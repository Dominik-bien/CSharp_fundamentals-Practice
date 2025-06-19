using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseNr1
{
    public partial class Main : Form
    {
        private JsonFileHelper<List<Product>> _fileHelper = new JsonFileHelper<List<Product>>(Program.FilePath);
        public Main()
        {
           
            InitializeComponent();
            RefreshDiary();
        }
        private void RefreshDiary()
        {
            var products = _fileHelper.DeserializeFromFile();
            dgvDiary.DataSource = products;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addEditProductForm = new AddEditProductForm();
            addEditProductForm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product, when you want to edit");
                return;
            }

            var addEditProduct = new AddEditProductForm(Convert.ToInt32(dgvDiary.SelectedRows[0].Cells[0].Value));
            addEditProduct.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDiary.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product, when you want to delete");
                return;
            }
            var selectedProduct = dgvDiary.SelectedRows[0];

            var confirmDelete = MessageBox.Show($"Do you want remove product " +
                $"{(selectedProduct.Cells[1].Value.ToString() + " " + selectedProduct.Cells[2].Value.ToString()).Trim()}",
                "Remove Product", MessageBoxButtons.OKCancel);

            if (confirmDelete == DialogResult.OK)
            {
                deleteProduct(Convert.ToInt32(selectedProduct.Cells[0].Value));
                RefreshDiary();
            }

           
        }
        private void deleteProduct(int id)
        {
            var products = _fileHelper.DeserializeFromFile();
            products.RemoveAll(x => x.Id == id);
            _fileHelper.SerializeToFile(products);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDiary();
        }
    }
}
