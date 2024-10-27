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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PresentationLayer.Forms
{
    public partial class CategoryForm : Form
    {
        private readonly CategoryService _categoryService;
        private bool isEditing = false;

        public CategoryForm()
        {
            InitializeComponent();
            _categoryService = new CategoryService();

            LoadCategoryData();
        }

        public void LoadCategoryData()
        {
            categoryDataGridView.DataSource = _categoryService.GetAllCategory();
        }

        public void cleanParamenters()
        {
            nameCategoryTextBox.Clear();
            nameCategoryTextBox.Focus();
        }

        private void saveCategoryButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                Category category = new Category();
                category.idCategory = int.Parse(categoryDataGridView.CurrentRow.Cells[0].Value.ToString());
                category.nameCategory = nameCategoryTextBox.Text;
                
                _categoryService.UpdateCategory(category);
                LoadCategoryData();
                cleanParamenters();

                isEditing = false;
            }
            else
            {
                Category category = new Category();
                category.nameCategory = nameCategoryTextBox.Text;
                CategoryValidation categoryValidation = new CategoryValidation();
                ValidationResult result = categoryValidation.Validate(category);

                if (!result.IsValid)
                {
                    foreach (var failure in result.Errors)
                    {
                        MessageBox.Show("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                    }
                }
                else
                {
                    _categoryService.AddCategory(category);
                    LoadCategoryData();
                }
               
                cleanParamenters();
            }
        }

        private void updateCategoryButton_Click(object sender, EventArgs e)
        {
            if (categoryDataGridView.SelectedRows.Count > 0)
            {
                nameCategoryTextBox.Text = categoryDataGridView.CurrentRow.Cells[1].Value.ToString();
                isEditing = true;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila antes de editar");
            }
        }

        private void deleteCategoryButton_Click(object sender, EventArgs e)
        {
            if (categoryDataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Debe sleccionar una fila para eliminar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var deleteConfirm = new DialogResult();
                deleteConfirm = MessageBox.Show("Desea borrar el registro?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (deleteConfirm == DialogResult.Yes)
                {
                    int id = int.Parse(categoryDataGridView.CurrentRow.Cells[0].Value.ToString());
                    _categoryService.DeleteCategory(id);

                    LoadCategoryData();
                    cleanParamenters();
                }
            }
        }
    }
}
