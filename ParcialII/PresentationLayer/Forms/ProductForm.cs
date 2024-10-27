using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Services;
using CommonLayer.Entities;
using FluentValidation.Results;
using PresentationLayer.Validations;

namespace PresentationLayer.Forms
{
    public partial class ProductForm : Form
    {
        private readonly ProductService _productService;
        private readonly CategoryService _categoryService;
        private bool isEditing = false;
        public ProductForm()
        {
            InitializeComponent();
            _productService = new ProductService();
            _categoryService = new CategoryService();

            LoadProductData();
            LoadCategoryComboBox();
        }
        public void LoadProductData()
        {
           listProdutDataGridView.DataSource = _productService.GetProduct();
        }

        public void cleanParamenters()
        {
            nameProductTextBox.Clear();
            stockTextBox.Clear();
            priceProductTextBox.Clear();
            categoryProductComboBox.SelectedValue = 0;
            nameProductTextBox.Focus();
        }

        public void LoadCategoryComboBox()
        {
            categoryProductComboBox.DataSource = _categoryService.GetAllCategory();
            categoryProductComboBox.DisplayMember = "nameCategory";
            categoryProductComboBox.ValueMember = "idCategory";
        }


        private void saveProductButton_Click(object sender, EventArgs e)
        {
            
            if (isEditing)
            {
                Product product = new Product();
                product.idProduct = int.Parse(listProdutDataGridView.CurrentRow.Cells[0].Value.ToString());
                product.nameProducto = nameProductTextBox.Text;
                product.stock = Convert.ToInt32(stockTextBox.Text);
                product.price = Convert.ToDecimal(priceProductTextBox.Text);
                product.idCategory = Convert.ToInt32(categoryProductComboBox.SelectedValue);

                _productService.EditProduct(product);
                LoadProductData();
                isEditing = false;
            }
            else
            {
                Product product = new Product();


                product.nameProducto = nameProductTextBox.Text;
                product.stock = Convert.ToInt32(stockTextBox.Text);
                product.price = Convert.ToDecimal(priceProductTextBox.Text);
                product.idCategory = Convert.ToInt32(categoryProductComboBox.SelectedValue);
              
                    

                ProductValidation productValidation = new ProductValidation();
                ValidationResult result = productValidation.Validate(product);

                if (!result.IsValid)
                {
                    foreach (var failure in result.Errors)
                    {
                        MessageBox.Show("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                    }
                }
                else
                {
                    _productService.AddProduct(product);
                    LoadProductData();
                }

            }
            
            cleanParamenters();
        }


        private void updateProductButton_Click(object sender, EventArgs e)
        {
            if (listProdutDataGridView.SelectedRows.Count > 0)
            {
                nameProductTextBox.Text = listProdutDataGridView.CurrentRow.Cells[1].Value.ToString();
                stockTextBox.Text = listProdutDataGridView.CurrentRow.Cells[2].Value.ToString();
                priceProductTextBox.Text = listProdutDataGridView.CurrentRow.Cells[3].Value.ToString();
                categoryProductComboBox.Text = listProdutDataGridView.CurrentRow.Cells[4].Value.ToString();
                isEditing = true;

            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            if (listProdutDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe sekeccionar una fila a eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                var deleteConfirm = new DialogResult();

                deleteConfirm = MessageBox.Show("Esta seguro que desea eliminar este dato? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = int.Parse(listProdutDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _productService.DeleteProduct(id);
                }
            }
        }

        private void viewCategoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm career = new CategoryForm();
            career.FormClosed += (s, args) => LoadCategoryComboBox();
            career.ShowDialog();
        }
    }
}
