using HiTechBooksManagement.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace HiTechBooksManagement.GUI
{
    public partial class FormCategories : Form
    {
        public FormCategories()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonViewAllPublishers_Click(object sender, EventArgs e)
        {
            ClearFormFields();
            LoadGridView();
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {

        }

        private void LoadGridView()
        {
            List<Category> categories = new List<Category>();
            Category category = new Category();
            categories = category.GetAllCategories();

            dataGridViewListAllCategories.DataSource = categories;
        }

        private void ClearGridView()
        {
            dataGridViewListAllCategories.Columns.Clear();
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            Category category = new Category();

            string categoryName = textBoxCategoryTitle.Text.ToString().Trim();
            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a Category name to add.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                textBoxCategoryTitle.Focus();
                return;
            }

            if (category.ExistingCategory(categoryName))
            {
                MessageBox.Show("This category already exists!", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            try
            {
                category.CategoryName = categoryName;
                category.SaveCategory(category);
                MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadaCategoriesIntoGrid();
            } catch(Exception ex)
            {
                MessageBox.Show($"Error adding category: {ex.InnerException?.Message ?? ex.Message}");
            }
            textBoxCategoryID.Clear();


        }

        Category searchedCategory = null;
        private void buttonSearchCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCategoryID.Text))
            {
                MessageBox.Show("Please enter an Category ID to search.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCategoryID.Focus();
                return;
            }

            try
            {
                int categoryID = Convert.ToInt32(textBoxCategoryID.Text.Trim());
                Category category = new Category();
                searchedCategory = category.SearchCategory(categoryID);

                if (searchedCategory != null)
                {
                    PopulateFormFields(searchedCategory);
                    dataGridViewListAllCategories.DataSource = new List<Category>
                    {
                        searchedCategory
                    };
                }
                else
                {
                    MessageBox.Show($"No category with the id {searchedCategory.CategoryID}.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxCategoryID.Focus();
                    dataGridViewListAllCategories.DataSource = null; 
                    ClearFormFields();
                }

            }
            catch 
            {
                MessageBox.Show($"Error searching category!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }


        private void PopulateFormFields(Category category)
        {
            textBoxCategoryID.Text = category.CategoryID.ToString();
            textBoxCategoryTitle.Text = category.CategoryName.ToString();
        }

        private void ClearFormFields()
        {
            textBoxCategoryID.Clear();
            textBoxCategoryTitle.Clear();
            dataGridViewListAllCategories.Columns.Clear();
        }

        private void buttonUpdateCategory_Click(object sender, EventArgs e)
        {
            List<string> formFields = new List<string> {
                textBoxCategoryID.Text,
                textBoxCategoryTitle.Text,
            };

            if (!FormFieldsAreField(formFields))
            {
                MessageBox.Show("Please enter a category name to update!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateForm())
            {
                return;
            }
            if (searchedCategory == null)
            {
                MessageBox.Show("Please search for an author to update first.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                Category updatedCategory = new Category
                {
                    CategoryID = Convert.ToInt32(textBoxCategoryID.Text.Trim()),
                    CategoryName = textBoxCategoryTitle.Text.Trim(),
                  
                };
                updatedCategory.UpdateCategory(updatedCategory);
                MessageBox.Show("Category updated successfully!",
                          "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFormFields();
                LoadaCategoriesIntoGrid();
            }
            catch
            {
                MessageBox.Show("Category ID must be a valid number.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCategoryID.Focus();
                return;
            }
        }

        private bool FormFieldsAreField(List<string> fields)
        {
            foreach (string field in fields)
            {
                if (string.IsNullOrWhiteSpace(field))
                {
                    return false;
                }
            }
            return true;
        }

        private bool ValidateForm()
        {

            if (string.IsNullOrWhiteSpace(textBoxCategoryTitle.Text))
            {
                MessageBox.Show("Category name is required!",
                    "Error Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxCategoryTitle.Focus();
                textBoxCategoryID.Focus();
                return false;
            }

            return true;
        }

        private void LoadaCategoriesIntoGrid()
        {
            Category category = new Category();
            try
            {
                List<Category> categories = category.GetAllCategories();
                dataGridViewListAllCategories.DataSource = categories;

            } catch 
            {
                MessageBox.Show($"Error loading categories", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (searchedCategory == null)
            {
                MessageBox.Show("Please search for a category to delete.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult result = MessageBox.Show(
               $"Are you sure you want to delete '{searchedCategory.CategoryName}'?",
               "Confirm Delete",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try

                {
                    Category category = new Category();
                    category.DeleteCategory((searchedCategory.CategoryID));
                    MessageBox.Show("Category deleted successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    searchedCategory = null;
                    ClearFormFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting category: {ex.InnerException?.Message ?? ex.Message}");

                }
            }
            ClearFormFields();
        }
    }
}
