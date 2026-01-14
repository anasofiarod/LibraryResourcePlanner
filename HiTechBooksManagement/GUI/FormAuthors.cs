using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechBooksManagement.BLL;
using HiTechBooksManagement.DAL;
using HiTechBooksManagement.VALIDATION;
namespace HiTechBooksManagement.GUI
{
    public partial class Authors : Form
    {
        public Authors()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;

        }

        private void Authors_Load(object sender, EventArgs e)
        {

        }

        private void buttonCloseAuthorPopUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            try
            {
                Author author = new Author
                {
                    FirstName = textBoxAuthorFirstName.Text.Trim(),
                    LastName = textBoxAuthorLastName.Text.Trim(),
                    Email = textBoxEmail.Text.Trim(),
                    PhoneNumber = maskedTextBoxPhoneNumber.Text.Trim()
                };
                if (AuthorExists(author.FirstName, author.LastName))
                {
                    MessageBox.Show($"An author named '{author.FirstName} {author.LastName}' already exists.",
                        "Duplicate Author", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int newId = author.SaveAuthor(author);

                if (newId > 0)
                {
                    MessageBox.Show("Author added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadAuthorsIntoGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding author: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthorExists(string firstName, string lastName)
        {
            try
            {
                Author author = new Author();
                return author.GetAllAuthors().Any(a =>
                    a.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&a.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
            }
            catch
            {
                return false;
            }
        }

        private void LoadAuthorsIntoGrid()
        {
            Author author = new Author();
            try
            {
                List<Author> authors = author.GetAllAuthors();
                dataGridViewAllAuthors.DataSource = authors;

                if (dataGridViewAllAuthors.Columns.Count > 0)
                {
                    dataGridViewAllAuthors.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading authors: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBoxAuthorFirstName.Text))
            {
                MessageBox.Show("First Name is required!","Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAuthorFirstName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxAuthorLastName.Text))
            {
                MessageBox.Show("Last Name is required!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAuthorLastName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxEmail.Text))
            {
                MessageBox.Show("Email is required!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return false;
            }

            if (!Validator.IsValidEmail(textBoxEmail.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address!\nExample: name@example.com",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return false;
            }


            string phone = maskedTextBoxPhoneNumber.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Phone Number is required!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBoxPhoneNumber.Focus();
                return false;
            }
            if (!Validator.IsValidPhone(maskedTextBoxPhoneNumber.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid phone number!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                maskedTextBoxPhoneNumber.Focus();
                return false;
            }


            return true;
        }

        private void ClearForm()
        {
            textBoxAuthorID.Clear();
            textBoxAuthorFirstName.Clear();
            textBoxAuthorLastName.Clear();
            textBoxEmail.Clear();
            maskedTextBoxPhoneNumber.Clear();
            dataGridViewAllAuthors.Columns.Clear();
            searchedAuthor = null;
        }

        private void buttonUpdateAuthor_Click(object sender, EventArgs e)
        {
            List<string> formFields = new List<string> {
                textBoxAuthorID.Text,
                textBoxAuthorFirstName.Text,
                textBoxAuthorLastName.Text,
                textBoxEmail.Text,
                maskedTextBoxPhoneNumber.Text
            };
            if (searchedAuthor == null)
            {
                MessageBox.Show("Please search for an author to update first.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (!ValidateForm())
            {
                return;
            }
           
            try
            {
                Author updatedAuthor = new Author
                {
                    AuthorID = Convert.ToInt32(textBoxAuthorID.Text.Trim()),
                    FirstName = textBoxAuthorFirstName.Text.Trim(),
                    LastName = textBoxAuthorLastName.Text.Trim(),
                    Email = textBoxEmail.Text.Trim(),
                    PhoneNumber = maskedTextBoxPhoneNumber.Text.Trim()
                };
                updatedAuthor.UpdateAuthor(updatedAuthor);
                MessageBox.Show("Author updated successfully!",
                          "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                LoadAuthorsIntoGrid();
            } catch
            {
                MessageBox.Show("Author ID must be a valid number.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAuthorID.Focus();
                return;
            }



        }

        private bool formFieldsAreFilled(List<string> fields)
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

        Author searchedAuthor = null;
        private void buttonSearchAuthor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAuthorID.Text))
            {
                MessageBox.Show("Please enter an Author ID to search.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAuthorID.Focus();
                return;
            }

            try
            {
                int authorID = Convert.ToInt32(textBoxAuthorID.Text.Trim());
                Author author = new Author();
                searchedAuthor = author.SearchAuthor(authorID);

                if(searchedAuthor != null)
                {
                    PopulateFormFields(searchedAuthor);
                    dataGridViewAllAuthors.DataSource = new List<Author> { searchedAuthor};
                }
                else
                {
                    MessageBox.Show($"No author found with ID: {authorID}",
                        "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching author!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (!formFieldsAreFilled(new List<string> { textBoxAuthorID.Text }))
            {
                MessageBox.Show("Please search for an author to delete using the ID.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAuthorID.Focus();
                return;
            }

            DialogResult result = MessageBox.Show(
               $"Are you sure you want to delete '{searchedAuthor.FullName}'?",
               "Confirm Delete",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (searchedAuthor.DeleteAuthor(searchedAuthor.AuthorID))
                    {
                        BookAuthors bookAuthors = new BookAuthors();
                        MessageBox.Show("Author deleted successfully!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        LoadAuthorsIntoGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting author: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void PopulateFormFields(Author author)
        {
            textBoxAuthorID.Text = author.AuthorID.ToString();
            textBoxAuthorFirstName.Text = author.FirstName;
            textBoxAuthorLastName.Text = author.LastName;
            textBoxEmail.Text = author.Email;
            maskedTextBoxPhoneNumber.Text = author.PhoneNumber;
        }

        private void buttonViewAllAuthors_Click(object sender, EventArgs e)
        {
            LoadAuthorsIntoGrid();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }
}
