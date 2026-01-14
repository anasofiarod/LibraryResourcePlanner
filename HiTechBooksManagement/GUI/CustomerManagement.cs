using HiTechBooksManagement.BLL;
using HiTechBooksManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace HiTechBooksManagement.GUI
{
    public partial class CustomerManagement : Form
    {
    private DataTable dtCustomers;
    

    public CustomerManagement()
    {
        InitializeComponent();
    }

    private void CustomerManagement_Load(object sender, EventArgs e)
    {
        dtCustomers = Customer.GetAllCustomers();
        comboBoxQuebecCities.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadQuebecCitiesComboBox();

    }

        private void LoadQuebecCitiesComboBox()
        {
            var cities = DAL.QuebecCitiesDB.GetAllQuebecCities();
            comboBoxQuebecCities.DataSource = cities;
            comboBoxQuebecCities.SelectedIndex = -1;
        }

        private void buttonCListAll_Click(object sender, EventArgs e)
    {
        ClearTextBoxes();
        dtCustomers = Customer.GetAllCustomers();
        dataGridViewCListAll.DataSource = dtCustomers;
    }

    private void buttonCSearch_Click(object sender, EventArgs e)
    {
        if (int.TryParse(textBoxCustomerID.Text, out int custID))
        {
            DataRow row = Customer.SearchCustomer(dtCustomers, custID);
            if (row != null)
            {
                PopulateTextBoxes(row);

                DataTable dtSearch = dtCustomers.Clone();
                dtSearch.ImportRow(row);
                dataGridViewCListAll.DataSource = dtSearch;
            }
            else
            {
                MessageBox.Show("Customer not found!");
            }
        }
        else
            MessageBox.Show("Please enter a valid Customer ID.");
    }

    private void buttonCUpdate_Click(object sender, EventArgs e)
    {
            if (!ValidateCustomerFormForUpdate())
            {
                return;
            }

            if (int.TryParse(textBoxCustomerID.Text, out int custID))
            {
                DataRow row = CustomerDB.SearchRecord(dtCustomers, custID);
                if (row != null)
                {
                    if (comboBoxQuebecCities.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a valid Quebec city.", "Error",
                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                        comboBoxQuebecCities.Focus();
                        return;
                    }

                    Customer updatedCustomer = GetCustomerFromTextBoxes();

                    if (!IsValidQuebecPostalCode(updatedCustomer.PostalCode))
                    {
                        MessageBox.Show("Invalid postal code for Quebec. Quebec postal codes must start with G, H, or J.",
                                       "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxCPostalCode.Focus();
                        return;
                    }

                    row["Name"] = updatedCustomer.Name;
                    row["Street"] = updatedCustomer.Street;
                    row["City"] = updatedCustomer.City;
                    row["PostalCode"] = updatedCustomer.PostalCode;
                    row["Phone"] = updatedCustomer.Phone;
                    row["Fax"] = updatedCustomer.Fax;
                    row["CreditLimit"] = updatedCustomer.CreditLimit;

                    DialogResult result = MessageBox.Show("Do you want to update this customer? ", "Confirmation",
                                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes && row != null)
                    {
                        ClearTextBoxes();
                        MessageBox.Show("Customer updated successfully!");
                        Customer.UpdateAllCustomers(dtCustomers);
                        dataGridViewCListAll.DataSource = dtCustomers;
                    }
                }
            }


        }
    

    private void buttonCDelete_Click(object sender, EventArgs e)
    {
        if (String.IsNullOrEmpty(textBoxCustomerID.Text))
            {
                DialogResult result = MessageBox.Show("Please search a valid customer to delete ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (int.TryParse(textBoxCustomerID.Text, out int custID))
        {
            DataRow row = Customer.SearchCustomer(dtCustomers, custID);
            DialogResult result = MessageBox.Show("Do you want to delete this employee? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes && row != null)
                {
                    ClearTextBoxes();
                    MessageBox.Show("Customer deleted successfully!");
                    Customer.DeleteCustomer(row);
                    Customer.UpdateAllCustomers(dtCustomers);
                    dataGridViewCListAll.Columns.Clear();
                }
        }
    }

    private void PopulateTextBoxes(DataRow row)
    {
        textBoxCustomerID.Text = row["CustomerID"].ToString();
        textBoxCName.Text = row["Name"].ToString();
        textBoxStreet.Text = row["Street"].ToString();
        comboBoxQuebecCities.Text = row["City"].ToString();
        textBoxCPostalCode.Text = row["PostalCode"].ToString();
        maskedTextBox1.Text = row["Phone"].ToString();
        textBoxCFax.Text = row["Fax"].ToString();
        textBoxCreditLimit.Text = row["CreditLimit"].ToString();
    }

    private Customer GetCustomerFromTextBoxes()
    {
        return new Customer
        {
            Name = textBoxCName.Text,
            Street = textBoxStreet.Text,
            City = comboBoxQuebecCities.Text,
            PostalCode = textBoxCPostalCode.Text,
            Phone = maskedTextBox1.Text,
            Fax = textBoxCFax.Text,
            CreditLimit = double.TryParse(textBoxCreditLimit.Text, out double credit) ? credit : 0
        };
    }

    private void ClearTextBoxes()
    {
        textBoxCustomerID.Clear();
        textBoxCName.Clear();
        textBoxStreet.Clear();
        comboBoxQuebecCities.SelectedIndex = -1;
            textBoxCPostalCode.Clear();
        maskedTextBox1.Clear();
        textBoxCFax.Clear();
        textBoxCreditLimit.Clear();
    }

        private void buttonCAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer newCustomer = GetCustomerFromTextBoxes();

                if (string.IsNullOrWhiteSpace(newCustomer.Name))
                {
                    MessageBox.Show("Please type a Customer name.", "Customer Name Required",
                                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (comboBoxQuebecCities.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a Quebec city from the list.", "City Required",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    comboBoxQuebecCities.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(newCustomer.Street))
                {
                    MessageBox.Show("Please enter a valid Street", "Street Required",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }
                if (string.IsNullOrWhiteSpace(textBoxCreditLimit.Text))
                {
                    MessageBox.Show("Credit Limit cannot be empty.", "Credit Limit Required",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCreditLimit.Focus();
                    return;
                }

                if (!double.TryParse(textBoxCreditLimit.Text, out double creditLimit) || creditLimit < 0)
                {
                    MessageBox.Show("Please enter a valid positive number for Credit Limit.",
                                   "Invalid Credit Limit", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCreditLimit.Focus();
                    return;
                }
              
                if (!IsValidQuebecPostalCode(newCustomer.PostalCode))
                {
                    MessageBox.Show("Invalid postal code for Quebec. Quebec postal codes must start with G, H, or J(J2H 0W1).",
                                   "Invalid Postal Code", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxCPostalCode.Focus();
                    return;
                }

                Customer.AddCustomer(dtCustomers, newCustomer);
                Customer.UpdateAllCustomers(dtCustomers);

                dtCustomers = Customer.GetAllCustomers();
                dataGridViewCListAll.DataSource = dtCustomers;

                ClearTextBoxes();
                MessageBox.Show("Customer addedd successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding customer: " + ex.Message);
            }
        }

        private bool IsValidQuebecPostalCode(string postalCode)
        {
            if (string.IsNullOrWhiteSpace(postalCode))
                return false;

            string cleanPostalCode = postalCode.Trim().ToUpper().Replace(" ", "");

            if (cleanPostalCode.Length != 6)
               return false;

            char firstChar = cleanPostalCode[0];
            bool isValidQuebecCode = firstChar == 'G' || firstChar == 'H' || firstChar == 'J';

            bool isValidFormat = Regex.IsMatch(postalCode.Trim().ToUpper(),
                                             @"^[ABCEGHJ-NPRSTVXY]\d[ABCEGHJ-NPRSTV-Z] \d[ABCEGHJ-NPRSTV-Z]\d$");

            return isValidQuebecCode && isValidFormat;
        }

        private bool ValidateCustomerFormForUpdate()
        {
            String[] customerTextboxes = new string[] {
                textBoxCName.Text, textBoxStreet.Text, textBoxCPostalCode.Text,
                maskedTextBox1.Text, textBoxCFax.Text, textBoxCreditLimit.Text
            };

            foreach (string textbox in customerTextboxes)
            {
                if (string.IsNullOrWhiteSpace(textbox))
                {
                    MessageBox.Show("All fields must be filled out to update a customer.", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            if (comboBoxQuebecCities.SelectedIndex == -1 || string.IsNullOrWhiteSpace(comboBoxQuebecCities.Text))
            {
                MessageBox.Show("Please select a Quebec city.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxQuebecCities.Focus();
                return false;
            }

            return true;
        }

        private void textBoxCreditLimit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            dataGridViewCListAll.Columns.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn loginForm = new FormLogIn();
            loginForm.Show();
        }
    }
}
