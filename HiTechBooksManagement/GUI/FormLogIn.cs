using HiTechBooksManagement.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HiTechBooksManagement.GUI
{
    public partial class FormLogIn : Form
    {
       

        public FormLogIn()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            if (UserDB.validCredentials(username, password))
            {
                var user = new BLL.User();

                string role = UserDB.GetUserRole(username);

                switch (role)
                {
                    case "MIS Manager":
                        UserEmployeeMaintenance userEmployeeForm = new UserEmployeeMaintenance();
                        userEmployeeForm.Show();
                        break;

                    case "Sales Manager":
                        CustomerManagement customerForms = new CustomerManagement();
                        customerForms.Show();
                        break;

                    case "Inventory Controller":
                        FormBookManagementMain bookManagement = new FormBookManagementMain();
                        bookManagement.Show();
                        break;

                    case "Order Clerk":
                        FormOrders orderForm = new FormOrders();
                        orderForm.Show();
                        break;

                    default:
                        MessageBox.Show("Unknown role. Cannot open form.");
                        return;
                }

                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Please enter a valid username or password.", "Invalid Credentials",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearAll();
            }

        }

        private void ClearAll()
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();


        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
