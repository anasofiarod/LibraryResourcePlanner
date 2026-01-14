using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechBooksManagement.DAL;
using HiTechBooksManagement.BLL;
using HiTechBooksManagement.VALIDATION;

namespace HiTechBooksManagement.GUI
{
    public partial class FormsPublishers : Form
    {

        private List<string> quebecCities = QuebecCitiesDB.GetAllQuebecCities();
    
        public FormsPublishers()
        {
            InitializeComponent();
        }

        private void buttonClosePublisherPopUp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        Publisher searchedPublisher = null;

        private void buttonSearchPublisher_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textboxPublisherID.Text))
            {
                MessageBox.Show("Please enter a Publisher ID to search.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textboxPublisherID.Focus();
                return;
            }

            try
            {
                int publisherID = Convert.ToInt32(textboxPublisherID.Text.Trim());
                Publisher publisher = new Publisher();
                searchedPublisher = publisher.SearchPublisher(publisherID);

                if (searchedPublisher != null)
                {
                    PopulateFormFields(searchedPublisher);
                    dataGridViewAllPublishers.DataSource = new List<Publisher> { searchedPublisher};
                }
                else
                {
                    {
                        MessageBox.Show($"No publisher found with ID: {publisherID}",
                            "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric Publisher ID.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textboxPublisherID.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching publisher! {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormsPublishers_Load(object sender, EventArgs e)
        {
            ClearForm();
            comboBoxCities.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadQuebecCitiesComboBox();
        }

        private void LoadQuebecCitiesComboBox()
        {
            try
            {
                comboBoxCities.DataSource = quebecCities;
                comboBoxCities.DropDownStyle = ComboBoxStyle.DropDownList;
                comboBoxCities.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading cities: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonViewAllPublishers_Click(object sender, EventArgs e)
        {
            LoadPublishersIntoGrid();
        }

        private void LoadPublishersIntoGrid()
        {
            Publisher publisher= new Publisher();
            try
            {
                List<Publisher> publishers = publisher.GetAllPublishers();
                dataGridViewAllPublishers.DataSource = publishers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading publishers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridViewAllPublishers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadPublishersIntoGrid();
        }

        private bool ValidateForm()
        {
            string error; 
            if (!Validator.IsNotEmpty(textBoxPublisherFirstName.Text, out error, "Publisher Name"))
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPublisherFirstName.Focus();
                return false;
            }

            if (!Validator.IsNotEmpty(textBoxEmail.Text, out error, "Email"))
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return false;
            }

            if (!Validator.IsValidEmail(textBoxEmail.Text.Trim()))
            {
                MessageBox.Show("Please enter a valid email address!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return false;
            }

            if (Validator.EmailExists(textBoxEmail.Text.Trim()))
            {
                MessageBox.Show("This email address is already registered!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return false;
            }

            if (!Validator.IsNotEmpty(maskedTextBoxPhoneNumber.Text, out error, "Phone Number"))
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            // Check Address
            if (!Validator.IsNotEmpty(textBoxAddress.Text, out error, "Address"))
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAddress.Focus();
                return false;
            }

            if (!QuebecCitiesDB.IsValidQuebecCity(comboBoxCities.Text))
            {
                MessageBox.Show("Please select a valid Quebec city from the list.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxCities.Focus();
                return false;
            }

            string state = textBoxState.Text.Trim();
            if (state.Length != 2 || !state.All(char.IsLetter) || !state.All(char.IsUpper))
            {
                MessageBox.Show("State must be exactly 2 capital letters (e.g., QC for Quebec)!",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxState.Focus();
                return false;
            }
            if (state != "QC")
            {
                MessageBox.Show("Publisher must be located in Quebec (State must be QC).",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxState.Focus();
                return false;
            }

            return true;
        }

        private void PopulateFormFields(Publisher publisher)
        {
            textboxPublisherID.Text = publisher.PublisherID.ToString();
            textBoxPublisherFirstName.Text = publisher.PublisherName;
            textBoxEmail.Text = publisher.Email;
            maskedTextBoxPhoneNumber.Text = publisher.Phone;
            comboBoxCities.Text = publisher.City;
            textBoxState.Text = publisher.State;
            textBoxAddress.Text = publisher.Address;
        }

        private void buttonAddPublisher_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }
            try
            {
                Publisher publisher = new Publisher
                {
                    PublisherName = textBoxPublisherFirstName.Text.Trim(),
                    Email = textBoxEmail.Text.Trim(),
                    Phone = maskedTextBoxPhoneNumber.Text.Trim(),
                    City = comboBoxCities.Text.Trim(),
                    State = textBoxState.Text.Trim(),
                    Address = textBoxAddress.Text.Trim()
                };

                int newId = publisher.SavePublisher(publisher);

                if (newId > 0)
                {
                    MessageBox.Show($"Publisher '{publisher.PublisherName}' added successfully!",
                      "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    LoadPublishersIntoGrid();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding publisher!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            textboxPublisherID.Clear();
            textBoxPublisherFirstName.Clear();
            textBoxEmail.Clear();
            maskedTextBoxPhoneNumber.Clear();
            comboBoxCities.SelectedIndex = -1;
            textBoxState.Clear();
            textBoxAddress.Clear();
            dataGridViewAllPublishers.Columns.Clear();
        }

        private void buttonDeletePublisher_Click(object sender, EventArgs e)
        {
            if (searchedPublisher == null || searchedPublisher.PublisherID == 0)
            {
                MessageBox.Show("Please search for a publisher first.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textboxPublisherID.Focus();
                return;
            }

            DialogResult result = MessageBox.Show(
               $"Are you sure you want to delete '{searchedPublisher.PublisherName}'?",
               "Confirm Delete",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    Publisher publisher = new Publisher();
                    bool deleted = publisher.DeletePublisher(searchedPublisher.PublisherID);

                    if (deleted)
                    {
                        MessageBox.Show($"Publisher '{searchedPublisher.PublisherName}' deleted successfully!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearForm();
                        searchedPublisher = null;
                        LoadPublishersIntoGrid();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting publisher!",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool FormFieldsAreFilled(List<string> fields)
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

        private void buttonClosePublisherPopUp_Click_1(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn mainForm = new FormLogIn();
            mainForm.Show();
        }
    }
}
