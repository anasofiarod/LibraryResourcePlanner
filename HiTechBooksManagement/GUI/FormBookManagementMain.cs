using HiTechBooksManagement.BLL;
using HiTechBooksManagement.DAL;
using HiTechBooksManagement.VALIDATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HiTechBooksManagement.GUI
{
    public partial class FormBookManagementMain : Form
    {
    public FormBookManagementMain()

        {
            InitializeComponent();
        }

        private void textBoxISBN_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            using(FormCategories categoryForm = new FormCategories())
            {
                categoryForm.FormClosed += CategoryForm_FormClosed;
                categoryForm.ShowDialog();
            }
        }

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            List<string> formFields = new List<string>
            {
                textBoxISBN.Text,
                textBoxBookTitle.Text,
                textBoxUnitPrice.Text,
                textBoxPublishedYear.Text,
                textBoxQuantityAvailable.Text,
                comboBoxCategories.Text,
                comboBoxPublisher.Text
            };
            if (!formFieldsAreFilled(formFields))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!ValidBookForm())
            {
                return;
            }

            if (searchedBook == null)
            {
                MessageBox.Show("Please search for a book to update first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string selectedCategory = comboBoxCategories.Text.Trim();
                string selectedPublisher = comboBoxPublisher.Text.Trim();
                var selectedAuthor = checkedListBoxAuthors.CheckedItems.Cast<string>().ToList();

                int categoryID = CategoryDB.GetCategoryID(selectedCategory);
                int publisherID = PublisherDB.GetPublisherID(selectedPublisher);
                string cleanISBN = Validator.CleanISBN(textBoxISBN.Text.Trim());

                if(checkedListBoxAuthors.CheckedIndices.Count == 0)
                {
                    MessageBox.Show("Please select an author.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                if (categoryID == 0 || publisherID == 0)
                {
                    MessageBox.Show("Invalid category, publisher, or author.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Book updatedBook = new Book
                {
                    BookID = searchedBook.BookID,
                    ISBN = cleanISBN,
                    Title = textBoxBookTitle.Text.Trim(),
                    UnitPrice = decimal.Parse(textBoxUnitPrice.Text.Trim()),
                    YearPublished = int.Parse(textBoxPublishedYear.Text.Trim()),
                    QuantityAvailable = int.Parse(textBoxQuantityAvailable.Text.Trim()),
                    CategoryID = categoryID,
                    PublisherID = publisherID
                };

                DialogResult result = MessageBox.Show("Do you want to update this book? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(result != DialogResult.Yes)
                {
                    return;
                }

                updatedBook.UpdateBook(updatedBook);

             
                BookAuthors bookAuthor = new BookAuthors();
                bookAuthor.RemoveAllAuthorsFromBook(updatedBook.BookID);
                foreach (string authorName in selectedAuthor)
                {
                    int authorID = AuthorDB.GetAuthorID(authorName);
                    if (authorID > 0)
                    {
                        bookAuthor.AddBookAuthor(updatedBook.BookID, authorID);
                    }
                }

                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBooksIntoGrid();
                ClearBookForm();
                searchedBook = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book:\n" + ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }


        private static bool formFieldsAreFilled(List<string> formFields)
        {
            foreach (var field in formFields)
            {
                if (string.IsNullOrWhiteSpace(field))
                {
                    return false;
                }
            }
            return true;
        }


        private bool ValidBookForm()
        {
            int yearPublished, quantityAvailable;

            if (string.IsNullOrWhiteSpace(textBoxISBN.Text))
            {
                MessageBox.Show("Please enter an ISBN to add the new book.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxISBN.Focus();
                return false;
            }


            if (!Validator.IsValidISBN(textBoxISBN.Text.Trim()))
            {
                MessageBox.Show("Invalid ISBN. It must start with 9 and be 10 or 13 digits.",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxISBN.Focus();
                return false;
            }
            if (textBoxISBN.Text.Contains("-"))
            {
                MessageBox.Show("Please enter ISBN without dashes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxISBN.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(textBoxBookTitle.Text))
            {
                MessageBox.Show("Please enter a Book Title.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxBookTitle.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxUnitPrice.Text))
            {
                MessageBox.Show("Please enter a Unit Price.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUnitPrice.Focus();
                return false;
            }

            if (!decimal.TryParse(textBoxUnitPrice.Text, out decimal unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Unit Price must be a valid non-negative decimal number.\nExample: 29.99",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUnitPrice.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxPublishedYear.Text))
            {
                MessageBox.Show("Please enter a Year Published.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPublishedYear.Focus();
                return false;
            }

            if (!int.TryParse(textBoxPublishedYear.Text, out yearPublished))
            {
                MessageBox.Show("Year Published must be a valid number.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPublishedYear.Focus();
                return false;
            }

            if (yearPublished < 0 || yearPublished > DateTime.Now.Year)
            {
                MessageBox.Show($"Year Published must be between 0 and {DateTime.Now.Year}.",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPublishedYear.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxQuantityAvailable.Text))
            {
                MessageBox.Show("Please enter a Quantity Available.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQuantityAvailable.Focus();
                return false;
            }

            if (!int.TryParse(textBoxQuantityAvailable.Text, out quantityAvailable))
            {
                MessageBox.Show("Quantity Available must be a valid whole number.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQuantityAvailable.Focus();
                return false;
            }

            if (quantityAvailable < 0)
            {
                MessageBox.Show("Quantity Available cannot be negative.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxQuantityAvailable.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboBoxCategories.Text) ||
                comboBoxCategories.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Category from the list.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCategories.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(comboBoxPublisher.Text) ||
                comboBoxPublisher.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Publisher from the list.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxPublisher.Focus();
                return false;
            }

            if (checkedListBoxAuthors.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select at least one Author from the list.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkedListBoxAuthors.Focus();
                return false;
            }

            return true;
        }
        private void FormBookManagementMain_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadPublishers();
            LoadAuthors();
            dataGridViewBooks.AutoGenerateColumns = true;
            comboBoxCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPublisher.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonListAllBooks_Click(object sender, EventArgs e)
        {
            LoadBooksIntoGrid();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if(!ValidBookForm())
            {
                return;
            }
          

            string selectedCategory = comboBoxCategories.Text.Trim();
            string selectedPublisher = comboBoxPublisher.Text.Trim();
            string selectedAuthor = checkedListBoxAuthors.Text.Trim();
            int categoryID = CategoryDB.GetCategoryID(selectedCategory);
            int publisherID = PublisherDB.GetPublisherID(selectedPublisher);

            if (categoryID == 0)
            {
                MessageBox.Show("Selected category does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxCategories.Focus();
                return;
            }

            if (publisherID == 0)
            {
                MessageBox.Show("Selected publisher does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxPublisher.Focus();
                return;
            }

            Book newBook = new Book
            {
                ISBN = textBoxISBN.Text.Trim(),
                Title = textBoxBookTitle.Text.Trim(),
                UnitPrice = decimal.Parse(textBoxUnitPrice.Text.Trim()),
                YearPublished = int.Parse(textBoxPublishedYear.Text.Trim()),
                QuantityAvailable = int.Parse(textBoxQuantityAvailable.Text.Trim()),
                CategoryID = categoryID,
                PublisherID = publisherID
            };

            try
            {
               int bookID = newBook.SaveBook(newBook);
                int authorID = AuthorDB.GetAuthorID(selectedAuthor);

                if (authorID == 0)
                {
                    MessageBox.Show("Selected author does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    checkedListBoxAuthors.Focus();
                    return;
                }
                BookAuthors bookAuthors = new BookAuthors();
                bookAuthors.AddBookAuthor(bookID, authorID);


                MessageBox.Show("Book saved successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book:\n" + ex.ToString(), "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearBookForm();
            LoadBooksIntoGrid();        

        }

        private void LoadCategories()
        {
            var categoryNames = CategoryDB.ListAllCategoryNames();
            comboBoxCategories.DataSource = categoryNames;
            comboBoxCategories.SelectedIndex = -1;
        }
    

        private void ClearBookForm()
        {
            textBoxBookID.Clear();
            textBoxISBN.Clear();
            textBoxBookTitle.Clear();
            textBoxUnitPrice.Clear();
            textBoxPublishedYear.Clear();
            textBoxQuantityAvailable.Clear();

            comboBoxCategories.SelectedIndex = -1; 
            comboBoxPublisher.SelectedIndex = -1; 

            textBoxISBN.Focus();

            ClearAuthorView();
            textBoxBookID.Focus();
        }
        
        private void ClearAuthorView()
        {
            foreach (int i in checkedListBoxAuthors.CheckedIndices)
            {
                checkedListBoxAuthors.SetItemChecked(i, false);
            }
        }


        private void LoadBooksIntoGrid()
        {
            try
            {
                List<BookDisplay> displayBooks = BookDB.GetDisplayRecords();
                dataGridViewBooks.DataSource = displayBooks;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading books: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadPublishers()
        {
            List<string> publisherNames = PublisherDB.ListAllPublisherNames();
            comboBoxPublisher.DataSource = publisherNames;
            comboBoxPublisher.SelectedIndex = -1;
        }

        private void LoadAuthors()
        {
            checkedListBoxAuthors.Items.Clear();
            List<string> authors = AuthorDB.ListAllAuthorNames();

            foreach(var author in authors)
            {
                checkedListBoxAuthors.Items.Add(author);
            }

        }

    
        

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }


        Book searchedBook = null;
        private void buttonSearchBook_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxBookID.Text.ToString()))
            {
                MessageBox.Show("Please enter a Book ID to search.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int bookID = Convert.ToInt32(textBoxBookID.Text);
            Book book = new Book();

            try
            {

                searchedBook = book.SearchBook(bookID);

                if (searchedBook != null)
                {
                    textBoxBookID.Text = searchedBook.BookID.ToString();
                    textBoxISBN.Text = Validator.FormatISBN(searchedBook.ISBN);
                    textBoxBookTitle.Text = searchedBook.Title;
                    textBoxUnitPrice.Text = searchedBook.UnitPrice.ToString("0.00");
                    textBoxPublishedYear.Text = searchedBook.YearPublished.ToString();
                    textBoxQuantityAvailable.Text = searchedBook.QuantityAvailable.ToString();

                    string categoryName = "Uncategorized";
                    string publisherName = "Publisher Unknown";

                    if (searchedBook.CategoryID != null)
                    {
                        categoryName = CategoryDB.GetCategoryNameByID(searchedBook.CategoryID.Value);
                    }

                    if (searchedBook.PublisherID != null)
                    {
                        publisherName = PublisherDB.GetPublisherNameByID(searchedBook.PublisherID.Value);
                    }

                    comboBoxCategories.Text = categoryName;
                    comboBoxPublisher.Text = publisherName;


                    foreach(int i in checkedListBoxAuthors.CheckedIndices)
                    {
                        checkedListBoxAuthors.SetItemChecked(i, false);
                    }

                    List<string> authors = BookAuthorsDB.GetAuthorsByBookID(searchedBook.BookID);
                    foreach(string authorName in authors)
                    {
                        for (int i = 0; i < checkedListBoxAuthors.Items.Count; i++)
                        {
                            if (checkedListBoxAuthors.Items[i].ToString() == authorName)
                            {
                                checkedListBoxAuthors.SetItemChecked(i, true);
                            }
                        }
                    }
                    var displayBook = new BookDisplay
                    {
                        BookID = searchedBook.BookID,
                        ISBN = searchedBook.ISBN,
                        Title = searchedBook.Title,
                        UnitPrice = searchedBook.UnitPrice,
                        YearPublished = searchedBook.YearPublished,
                        QuantityAvailable = searchedBook.QuantityAvailable,
                        Category = categoryName,   
                        Publisher = publisherName 
                    };
                    dataGridViewBooks.DataSource = new List<BookDisplay> { displayBook }; MessageBox.Show("Book found!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No book found with Book ID: {bookID}",
                        "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearBookForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching book: {ex.Message}\n\nFull Error:\n{ex}",
     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClearForm_Click(object sender, EventArgs e)
        {
            ClearBookForm();
            dataGridViewBooks.Columns.Clear();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            
            using (Authors authorForm = new Authors())
            {
                authorForm.FormClosed += AuthorForm_FormClosed; ;
                authorForm.ShowDialog();
            }
        }

        private void AuthorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadAuthors();
        }

        private void CategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            LoadCategories();
        }

        private void PublisherForm_FormClosed(object sender, FormClosedEventArgs e)
        {

            LoadCategories();
        }
        private void buttonSearchByISBN_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxISBN.Text.ToString()))
            {
                MessageBox.Show("Please enter an ISBN to search.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string isbn = textBoxISBN.Text.Trim();
            Book book = new Book();

            try
            {

                searchedBook = book.SearchBook(isbn);

                if (searchedBook != null)
                {
                    textBoxBookID.Text = searchedBook.BookID.ToString();
                    //textBoxISBN.Text = Validator.FormatISBN(searchedBook.ISBN);
                    textBoxBookTitle.Text = searchedBook.Title;
                    textBoxUnitPrice.Text = searchedBook.UnitPrice.ToString("0.00");
                    textBoxPublishedYear.Text = searchedBook.YearPublished.ToString();
                    textBoxQuantityAvailable.Text = searchedBook.QuantityAvailable.ToString();

                    string categoryName = "Uncategorized";
                    string publisherName = "Publisher Unknown";

                    if (searchedBook.CategoryID != null)
                    {
                        categoryName = CategoryDB.GetCategoryNameByID(searchedBook.CategoryID.Value);
                    }

                    if (searchedBook.PublisherID != null)
                    {
                        publisherName = PublisherDB.GetPublisherNameByID(searchedBook.PublisherID.Value);
                    }

                    comboBoxCategories.Text = categoryName;
                    comboBoxPublisher.Text = publisherName;

                    foreach (int i in checkedListBoxAuthors.CheckedIndices)
                    {
                        checkedListBoxAuthors.SetItemChecked(i, false);
                    }

                    List<string> authors = BookAuthorsDB.GetAuthorsByBookID(searchedBook.BookID);
                    foreach (string authorName in authors)
                    {
                        for (int i = 0; i < checkedListBoxAuthors.Items.Count; i++)
                        {
                            if (checkedListBoxAuthors.Items[i].ToString() == authorName)
                            {
                                checkedListBoxAuthors.SetItemChecked(i, true);
                            }
                        }
                    }
                    var displayBook = new BookDisplay
                    {
                        BookID = searchedBook.BookID,
                        ISBN = searchedBook.ISBN,
                        Title = searchedBook.Title,
                        UnitPrice = searchedBook.UnitPrice,
                        YearPublished = searchedBook.YearPublished,
                        QuantityAvailable = searchedBook.QuantityAvailable,
                        Category = categoryName,
                        Publisher = publisherName
                    };
                    dataGridViewBooks.DataSource = new List<BookDisplay> { displayBook };
                    MessageBox.Show("Book found!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"No book found with ISBN: {isbn}",
                        "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearBookForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching book: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            using (FormsPublishers publisherForm = new FormsPublishers())
            {
                publisherForm.FormClosed += PublisherForm_FormClosed; ;
                publisherForm.ShowDialog();
            }
        }

        private void listBoxAuthorList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxBookID.Text, out int bookID))
            {
                MessageBox.Show("Please enter a valid Book ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Book book = new Book();
                Book bookToDelete = book.SearchBook(bookID);

                if (bookToDelete == null)
                {
                    MessageBox.Show($"No book found with Book ID: {bookID}", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the book {bookToDelete.Title}", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result != DialogResult.Yes)
                {
                    return;
                }

                BookAuthors bookAuthors = new BookAuthors();
                bookAuthors.RemoveAllAuthorsFromBook(bookID);

                bookToDelete.DeleteBook(bookID);

                MessageBox.Show("Book delete successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearBookForm();
                LoadBooksIntoGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void groupBoxBooks_Enter(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn loginForm = new FormLogIn();
            loginForm.Show();
        }
    }
}
    