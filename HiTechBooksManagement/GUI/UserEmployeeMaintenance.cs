using HiTechBooksManagement.BLL;
using HiTechBooksManagement.DAL;
using HiTechBooksManagement.VALIDATION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace HiTechBooksManagement.GUI
{
    public partial class UserEmployeeMaintenance : Form
    {
        public UserEmployeeMaintenance()
        {
            InitializeComponent();

            textBoxUFirstName.ReadOnly = true;
            textBoxULastName.ReadOnly = true;
            textBoxPassword.UseSystemPasswordChar = true;
            comboBoxEStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

        }

        private void connectDB_Click(object sender, EventArgs e)
        {
            SqlConnection conn = UtilityDB.GetDBConnection();

            MessageBox.Show(conn.State.ToString(), "Database Connection");

            conn.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
   
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn formLogIn = new FormLogIn();
            formLogIn.ShowDialog();
        }

        private void dataGridViewListAllE_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonListAllEmployees_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            dataGridViewListAllE.DataSource = employee.GetAllEmployees();

        }
        private Employee currentEmployee;
        private User currentUser;

        private void buttonSearchEmployee_Click(object sender, EventArgs e)
        {
            dataGridViewListAllE.Columns.Clear();
            if (!int.TryParse(textBoxEEmployeeID.Text.Trim(), out int employeeID))
            {
                MessageBox.Show("Please enter a valid numeric Employee ID to check.", "Invalid Employee ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEEmployeeID.Clear();
                textBoxEEmployeeID.Focus();
                return;
            }

            Employee employee = new Employee();
            employee = employee.SearchEmployee(employeeID);
            if (employee != null )
            {
                textBoxEFirstName.Text = employee.FirstName;
                textBoxELastName.Text = employee.LastName;
                textBoxEEmail.Text = employee.Email;
                maskedTextBoxPhone.Text = employee.PhoneNumber;
                maskedTextBoxDate.Text = employee.HireDate != DateTime.MinValue ? employee.HireDate.ToString("yyyy-MM-dd") : string.Empty;
                textBoxEJobName.Text = employee.JobTitle;
                textBoxERoleID.Text = employee.RoleID.HasValue ? employee.RoleID.Value.ToString() : string.Empty;
                comboBoxEStatus.SelectedItem = employee.Status.ToString().Trim();
                dataGridViewListAllE.DataSource = new List<Employee> { employee };
                currentEmployee = employee;
            }
            else
            {
                MessageBox.Show("Employee not found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                currentEmployee = null;
            }

        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            string firstN = textBoxEFirstName.Text.Trim();
            string lastN = textBoxELastName.Text.Trim();
            if (!Validator.IsValidName(firstN))
            {
                MessageBox.Show("Invalid First Name entered!", "Invalid First Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEFirstName.Text = string.Empty;
                textBoxEFirstName.Focus();
                return;
            }
            if (!Validator.IsValidName(lastN))
            {
                MessageBox.Show("Invalid Last Name entered!", "Invalid Last Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxELastName.Text = string.Empty;
                textBoxELastName.Focus();
                return;
            }
            string email = textBoxEEmail.Text.Trim();


            if (!string.IsNullOrWhiteSpace(email))
            {
                if (Validator.EmailExists(email))
                {
                    MessageBox.Show("There is already an employee with entered email!",
                    "Enter email address again!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    textBoxEEmail.Focus();
                    return;
                }

                else if (!Validator.IsValidEmail(email))
                {
                    MessageBox.Show("Wrong email format entered!",
                        "Missing Email",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    textBoxEEmail.Focus();
                    return;
                }

            }
            else
            {
                MessageBox.Show("Please enter an email address!","Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBoxEEmail.Focus();
                return;
            }

                string phone = maskedTextBoxPhone.Text.Trim();
            if (!Validator.IsValidPhone(phone))
            {
                MessageBox.Show("Invalid phone number", "Invalid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBoxPhone.Text = string.Empty;
                maskedTextBoxPhone.Focus();
                return;
            }

           
        
       
            string jobTitle = textBoxEJobName.Text.Trim();
            if (string.IsNullOrWhiteSpace(jobTitle))
            {
                MessageBox.Show("Job Title is required!",
                    "Missing Job Title",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                textBoxEJobName.Focus();
                return;
            }

            int? roleID = null;
            if (!string.IsNullOrWhiteSpace(textBoxERoleID.Text.Trim()))
            {
                if (int.TryParse(textBoxERoleID.Text.Trim(), out int parsedRoleID))
                {
                    if (RoleDB.RoleExists(parsedRoleID))
                    {
                        roleID = parsedRoleID;
                    }
                    else
                    {
                        MessageBox.Show("The Role ID entered does not exist.", "Invalid Role ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxERoleID.Clear();
                        textBoxERoleID.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Role ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxERoleID.Clear();
                    textBoxERoleID.Focus();
                    return;
                }
            }
            string date = maskedTextBoxDate.Text.Trim();
            if (!Validator.IsValidDate(date))
            {
                MessageBox.Show("Invalid hired date entered", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBoxDate.Text = string.Empty;
                maskedTextBoxDate.Focus();
                return;
            }
            DateTime hireDate = DateTime.Parse(date);

            if (comboBoxEStatus.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the employee status (Active or Inactive).",
                    "Missing Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxEStatus.Focus();
                return;
            }
            EmployeeStatus status = comboBoxEStatus.SelectedIndex == 0
                                    ? EmployeeStatus.Active
                                    : EmployeeStatus.Inactive;

            employee.FirstName = firstN;
            employee.LastName = lastN;
            employee.PhoneNumber = phone;
            employee.Email = textBoxEEmail.Text.Trim();
            employee.HireDate = hireDate;
            employee.JobTitle = jobTitle;
            employee.RoleID = roleID;
            employee.Status = status;

            employee.SaveEmployee(employee);
            MessageBox.Show("Employee has been successfully saved");
            ClearAll();
        }

        private void buttonDeleteEmployee_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            DialogResult result = MessageBox.Show("Do you want to delete this employee? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                employee.DeleteEmployee(Convert.ToInt32(textBoxEEmployeeID.Text));
                MessageBox.Show("Employee deleted successfully!");
                ClearAll();
            }
            dataGridViewListAllE.Columns.Clear();
        }
        private void buttonUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (currentEmployee == null)
            {
                MessageBox.Show("Please search for an employee before updating one.", "No Employee Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentEmployee.FirstName = textBoxEFirstName.Text;
            currentEmployee.LastName = textBoxELastName.Text;
            currentEmployee.Email = textBoxEEmail.Text;
            currentEmployee.PhoneNumber = maskedTextBoxPhone.Text;
            currentEmployee.HireDate = DateTime.TryParse(maskedTextBoxDate.Text, out DateTime hireDate) ? hireDate : DateTime.Today;
            currentEmployee.JobTitle = textBoxEJobName.Text;
            currentEmployee.RoleID = ValidateRoleID(textBoxERoleID.Text);
            if (comboBoxEStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select the employee status.", "Missing Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedStatus = comboBoxEStatus.SelectedItem.ToString().Trim();
            currentEmployee.Status = selectedStatus == "Active"
                                     ? EmployeeStatus.Active
                                     : EmployeeStatus.Inactive;

            DialogResult result = MessageBox.Show("Do you really want to update this employee? ", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                currentEmployee.UpdateEmployee(currentEmployee);
                MessageBox.Show("Employee updated succesfully!");
                ClearAll();
            }

        }



        private void buttonUListAll_Click(object sender, EventArgs e)
        {
            User user = new User();
            dataGridViewUListAll.DataSource = user.ListAllUsers();
        }

        private void buttonUSearch_Click(object sender, EventArgs e)
        {
            dataGridViewUListAll.Columns.Clear();
            if (!int.TryParse(textBoxUserID.Text.Trim(), out int userID))
            {
                MessageBox.Show("Please enter a valid numeric User ID to check.", "Invalid User ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxEEmployeeID.Clear();
                textBoxEEmployeeID.Focus();
                return;
            }

            User user = new User();
            user = user.SearchUser(userID);
            if (user == null)
            {
                MessageBox.Show("User not found. ", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
                return;
            }

            if (user != null)
            {

                Employee employee = new Employee();
                employee = employee.SearchEmployee(user.EmployeeID);
                if (employee != null)
                {

                    textBoxUFirstName.Text = employee.FirstName;
                    textBoxULastName.Text = employee.LastName;
                    textBoxUEmployeeID.Text = employee.EmployeeID.ToString();
                }
                textBoxURoleID.Text = user.RoleID.ToString();
                textBoxUsername.Text = user.Username;
                textBoxPassword.Text = user.Password;
                checkBoxUserIsActive.Checked = user.IsActive;

            
                dataGridViewUListAll.DataSource = new List<User> { user };
                currentUser = user;
            }

        }



        private void ClearAll()
        {
            textBoxEEmployeeID.Clear();
            textBoxEFirstName.Clear();
            textBoxELastName.Clear();
            textBoxEEmail.Clear();
            maskedTextBoxPhone.Clear();
            maskedTextBoxDate.Clear();
            textBoxEJobName.Clear();
            textBoxERoleID.Clear();
            comboBoxEStatus.SelectedIndex = -1;
            textBoxEFirstName.Focus();
            dataGridViewListAllE.Columns.Clear();
            textBoxUEmployeeID.Clear();
            textBoxUFirstName.Clear();
            textBoxULastName.Clear();
            textBoxURoleID.Clear();
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            checkBoxUserIsActive.Checked = false;
            dataGridViewUListAll.Columns.Clear();

        }

        
        private int? ValidateRoleID(string role)
        {
            if (string.IsNullOrWhiteSpace(role))
                return null;

            if (!int.TryParse(role.Trim(), out int parsedRoleID))
            {
                MessageBox.Show("Role ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (!RoleDB.RoleExists(parsedRoleID))
            {
                MessageBox.Show("The Role ID entered does not exist.", "Invalid Role ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return parsedRoleID;
        }

        private void buttonUUpdate_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
            {
                MessageBox.Show("Please search for a user before updating one.", "No User Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
            {
                MessageBox.Show("Please enter a valid username.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Please enter a valid password.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();
                return;
            }

            int roleID;
            if (string.IsNullOrWhiteSpace(textBoxURoleID.Text.Trim()))
            {
                MessageBox.Show("Please enter a Role ID.", "Missing Role ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxURoleID.Focus();
                return;
            }

            if (!int.TryParse(textBoxURoleID.Text.Trim(), out roleID))
            {
                MessageBox.Show("Role ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxURoleID.Focus();
                return;
            }

            if (!RoleDB.RoleExists(roleID))
            {
                MessageBox.Show("No role with the entered Role ID exists.", "Invalid Role ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxURoleID.Focus();
                return;
            }

            currentUser.Username = textBoxUsername.Text.Trim();
            currentUser.Password = textBoxPassword.Text.Trim();
            currentUser.RoleID = roleID;
            currentUser.IsActive = checkBoxUserIsActive.Checked;

            DialogResult result = MessageBox.Show("Do you really want to update this user?",
                                                  "Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UserDB.UpdateRecord(currentUser);  
                MessageBox.Show("User updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAll();
            }

        }

        private void buttonUAdd_Click(object sender, EventArgs e)
        {
            User user = new User();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            bool isActive = Convert.ToBoolean(checkBoxUserIsActive.Checked);

            int employeeID = 0;
            int roleID = 0;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Please enter a valid username", "Invalid username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxUsername.Focus();
                return;
            }

            
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter a valid password", "Invalid password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Focus();

                return;
            }

            if (!string.IsNullOrWhiteSpace(textBoxUEmployeeID.Text.Trim()))
            {
                if (int.TryParse(textBoxUEmployeeID.Text.Trim(), out employeeID))
                {
                    if (!EmployeeDB.EmployeeExists(employeeID))
                    {
                        MessageBox.Show("No employee with the ID entered", "Invalid Employee ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUEmployeeID.Clear();
                        textBoxUEmployeeID.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Employee ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUEmployeeID.Clear();
                    textBoxUEmployeeID.Focus();
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(textBoxURoleID.Text.Trim()))
            {
                if (int.TryParse(textBoxURoleID.Text.Trim(), out roleID))
                {
                    if (!RoleDB.RoleExists(roleID))
                    {
                        MessageBox.Show("No role with the entered role ID entered", "Invalid Role ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxERoleID.Clear();
                        textBoxERoleID.Focus();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Role ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxERoleID.Clear();
                    textBoxERoleID.Focus();
                    return;
                }
            }

            if (UserDB.EmployeeHasUser(employeeID))
            {
                MessageBox.Show("This employee already has a user account assigned.",
                    "Duplicate Employee ID",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


            user.Username = username;
            user.Password = password;
            user.EmployeeID = employeeID;
            user.RoleID = roleID;
            user.IsActive = isActive;

            user.SaveUser(user);

            MessageBox.Show("User has been successfully saved." , "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearAll();
        }

        private void UserEmployeeMaintenance_Load(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void buttonClearUsers_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void tabPageUser_Click(object sender, EventArgs e)
        {

        }

        private void textBoxERoleID_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
    

    
  