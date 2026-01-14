using HiTechBooksManagement.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiTechBooksManagement.Data;
using System.Data.Entity;
using HiTechBooksManagement.DAL;

namespace HiTechBooksManagement.GUI
{
    public partial class FormOrders : Form
    {
        private List<OrderDisplayViewModel> tempOrderDetails = new List<OrderDisplayViewModel>();

        public FormOrders()
        {
            InitializeComponent();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
           
            LoadUsers();
            LoadCustomers();
            LoadBooks();
            LoadAllOrders();
            ClearOrderFields();
            comboBoxBook.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            
        }

        private void LoadUsers()
        {
            var user = new BLL.User();

            var clerks = user.ListOrderClerks();

            comboBoxUser.DataSource = clerks;
            comboBoxUser.DisplayMember = "Username";
            comboBoxUser.ValueMember = "UserID";
            

        }



        private void LoadCustomers()
        {
            var customers = CustomerDB.GetAllRecords();
            comboBoxCustomer.DataSource = customers;
            comboBoxCustomer.DisplayMember = "Name";
            comboBoxCustomer.ValueMember = "CustomerID";
            comboBoxCustomer.SelectedIndex = -1;
        }

        private void LoadBooks()
        {
            var book = new BLL.Book();
            comboBoxBook.DataSource = book.GetAllBook();
            comboBoxBook.DisplayMember = "Title";
            comboBoxBook.ValueMember = "BookID";
            comboBoxBook.SelectedIndex = -1;
        }

        private void LoadAllOrders()
        {
            var order = new OrderController();
            dataGridViewAllOrders.DataSource = order.GetOrders();
        }

        private void buttonViewAll_Click(object sender, EventArgs e)
        {

            var orderController = new OrderController();

            var orders = orderController.GetOrders()
                .Select(o => new
                {
                    OrderID = o.OrderID,
                    OrderDate = o.OrderDate,
                    UserID = o.UserID,
                    CustomerID = o.CustomerID,
                    TotalAmount = o.TotalAmount
                })
                .ToList();

            dataGridViewAllOrders.DataSource = orders;

        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadCustomers();
            LoadBooks();
            LoadAllOrders();
            ClearOrderFields();
        }


        private void buttonSearchOrder_Click(object sender, EventArgs e)
        {
            string searchID = textBoxSearchOrder.Text.Trim();
            if (string.IsNullOrEmpty(searchID))
            {
                MessageBox.Show("Please enter an Order ID");
                return;
            }

            if(!int.TryParse(searchID, out  int orderID)){
                MessageBox.Show("Please enter a valid Order ID (numbers only).");
                return;
            }

            var orderController = new OrderController();
            var orderDetailController = new OrderDetailController();
            var displayData = orderController.SearchOrderByID(orderID);
            var detailDisplayData = orderDetailController.SearchOrderDetailsByOrderID(orderID);

            if (displayData == null)
            {
                MessageBox.Show($"No order found with ID: {orderID}");
                return;
            }
            if(detailDisplayData == null)
            {
                MessageBox.Show($"No details for the order with ID: {orderID}");
                return ;
            }

            tempOrderDetails.Clear();
            textBOxrderID.Text = displayData.OrderID.ToString();
            dateTimePickerOrderDate.Value = displayData.OrderDate;
            comboBoxUser.SelectedValue = displayData.UserID;
            comboBoxCustomer.SelectedValue = displayData.CustomerID;
            textBoxTotalAmount.Text = displayData.TotalAmount.ToString("CAD");


            if (detailDisplayData != null && detailDisplayData.Any())
            {
                var bookController = new BLL.Book();

                foreach (var detail in detailDisplayData)
                {
                    var book = bookController.SearchBook(detail.BookID);
                    tempOrderDetails.Add(new OrderDisplayViewModel
                    {
                        OrderID = detail.OrderID,
                        BookID = detail.BookID,
                        BookTitle = book?.Title ?? "Unknown",
                        Quantity = detail.Quantity,
                        UnitPrice = detail.UnitPrice,
                        TotalAmount = detail.Quantity * detail.UnitPrice
                    });
                }

                RefreshOrderDetailsGrid();
            }
            else
            {
                MessageBox.Show($"No order details found for order ID: {orderID}");
                dataGridViewOrderDetails.DataSource = null;
            }

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if(ValidateBookInput(out int bookID, out string bookTitle, out int quantity, out decimal unitPrice))
            {
                AddBookToOrder(bookID,bookTitle, quantity, unitPrice);
                RefreshOrderDetailsGrid();
                UpdateTotalAmount();
                ClearBookInputFields();
            }


          
        }

        private bool ValidateBookInput(out int bookID, out string bookTitle, out int quantity, out decimal unitPrice)
        {
            bookID = 0;
            bookTitle = string.Empty;
            quantity = 0;
            unitPrice = 0;

            if (comboBoxBook.SelectedValue == null)
            {
                MessageBox.Show("Please selected a book.");
                return false;
            }

            if (numericUpDownQuantity.Value <= 0)
            {
                MessageBox.Show("Please enter a valid number of books");
                return false;
            }

           if(string.IsNullOrEmpty(textBoxUnitPrice.Text) || !decimal.TryParse(textBoxUnitPrice.Text, out unitPrice))
            {
                MessageBox.Show("Please enter a valit unit price");
            }

            bookID = (int)comboBoxBook.SelectedValue;
            bookTitle = comboBoxBook.Text;
            quantity = (int)numericUpDownQuantity.Value;

            return true;            

        }

        private bool ValidateOrderInput()
        {
            return ValidOrderDate(dateTimePickerOrderDate) && ValidCustomer(comboBoxCustomer) && ValidUser(comboBoxUser);

        }

        private bool ValidOrderDate(DateTimePicker pickerDate) 
        {
            if(!pickerDate.Checked || pickerDate.Value == DateTime.MinValue)
            {
                MessageBox.Show("Please pick a valid date for your order");
                return false;
            }

            if(pickerDate.Value > DateTime.Now)
            {
                MessageBox.Show("Order date cannot be in the future.");
                return false;
            }

            return true;

        }

        private bool ValidCustomer(ComboBox customerOptions)
        {
            if(customerOptions.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer from the list");
                return false;
            }
            return true;
        }

        private bool ValidUser(ComboBox userOption)
        {
            if (userOption.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a user from the list");
                return false;
            }
            return true;
        }
        private bool ValidateRowSelection()
        {
            if (dataGridViewOrderDetails.CurrentRow == null)
            {
                MessageBox.Show("Please select a row to remove.");
                return false;
            }
            return true;
        }

        private bool ValidOrderForSaving()
        {
            if (comboBoxUser.SelectedValue == null)
            {
                MessageBox.Show("Please select a user.");
                return false;
            }

            if (comboBoxCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer.");
                return false;
            }

            if (tempOrderDetails.Count == 0)
            {
                MessageBox.Show("Please add at least one book to the order.");
                return false;
            }
            if (!CheckCreditLimit())
            {
                return false;
            }

            return true;
        }

        private bool CheckCreditLimit()
        {
            if (!decimal.TryParse(textBoxCreditLimit.Text, out decimal creditLimit))
            {
                MessageBox.Show("Invalid credit limit for the selected customer.");
                return false;
            }

            decimal totalAmount = CalculateTotalAmount();

            if (totalAmount > creditLimit)
            {
                MessageBox.Show(
                    $"Order exceeds the customer's credit limit.\n\n" +
                    $"Credit Limit: {creditLimit:C}\n" +
                    $"Order Total: {totalAmount:C}",
                    "Credit Limit Exceeded",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            return true;
        }

        private void AddBookToOrder(int bookID, string bookTitle, int quantity, decimal unitPrice)
        {
            decimal total = quantity * unitPrice;

            tempOrderDetails.Add(new OrderDisplayViewModel
            {
                BookID = bookID,
                BookTitle = bookTitle,
                Quantity = quantity,
                UnitPrice = unitPrice,
                TotalAmount = total
            });
        }

        private void RemoveSelectedBook()
        {
            int index = dataGridViewOrderDetails.CurrentRow.Index;
            tempOrderDetails.RemoveAt(index);
        }

        private void SaveOrderToDatabase()
        {
            try
            {
                var orderController = new OrderController();
                var orderDetailController = new OrderDetailController();
                var newOrder = CreateNewOrder();
                orderController.SaveOrder(newOrder);
                int newOrderID = newOrder.OrderID;

                foreach (var detail in tempOrderDetails)
                {
                    var orderDetail = new OrderDetail
                    {
                        OrderID = newOrderID,
                        BookID = detail.BookID,
                        Quantity = detail.Quantity,
                        UnitPrice = detail.UnitPrice
                    };

                    orderDetailController.SaveOrderDetail(orderDetail);
                }


                ShowSuccessMessage(newOrderID);
                ResetFormAfterSave();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving order: {ex.Message}");
            }
        }

        private Order CreateNewOrder()
        {
            return new Order
            {
                OrderDate = dateTimePickerOrderDate.Value,
                UserID = (int)comboBoxUser.SelectedValue,
                CustomerID = (int)comboBoxCustomer.SelectedValue,
                TotalAmount = CalculateTotalAmount()
            };
        }

        private void RefreshOrderDetailsGrid()
        {
            dataGridViewOrderDetails.DataSource = null;
            dataGridViewOrderDetails.DataSource = tempOrderDetails;
        }

        private void UpdateTotalAmount()
        {
            decimal totalAmount = CalculateTotalAmount();
            textBoxTotalAmount.Text = totalAmount.ToString("C");
        }

        private decimal CalculateTotalAmount()
        {
            return tempOrderDetails.Sum(od => od.TotalAmount);
        }

        private void ClearBookInputFields()
        {
            comboBoxBook.SelectedIndex = -1;
            numericUpDownQuantity.Value = 1;
            textBoxUnitPrice.Clear();
        }

        private void ClearOrderFields()
        {
            textBOxrderID.Clear();
            dateTimePickerOrderDate.Value = DateTime.Now;
            comboBoxUser.SelectedIndex = -1;
            comboBoxCustomer.SelectedIndex = -1;
            textBoxTotalAmount.Text = "$0.00";

            ClearBookInputFields();

            tempOrderDetails.Clear();
            dataGridViewOrderDetails.DataSource = null;
            textBoxCreditLimit.Clear();
        }

        private void ShowSuccessMessage(int orderID)
        {
            MessageBox.Show($"Order #{orderID} saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResetFormAfterSave()
        {
            ClearOrderFields();
            tempOrderDetails.Clear();
            LoadAllOrders();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonRemoveSelected_Click(object sender, EventArgs e)
        {
            if (!ValidateRowSelection())
                return;

            RemoveSelectedBook();
            RefreshOrderDetailsGrid();
            UpdateTotalAmount();
        }

        private void buttonSaveOrder_Click(object sender, EventArgs e)
        {
            if (!ValidOrderForSaving())
                return;

            SaveOrderToDatabase();
        }

        private void buttonNewOrder_Click(object sender, EventArgs e)
        {
            ClearOrderFields();
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateOrderForDeletion())
                return;

            if (!ConfirmDeletion())
                return;

            DeleteOrderUsingControllers();
        }

        private bool ValidateOrderForDeletion()
        {
            if (string.IsNullOrEmpty(textBOxrderID.Text))
            {
                MessageBox.Show("Please search for an order first before deleting.");
                return false;
            }

            if (!int.TryParse(textBOxrderID.Text, out int orderID))
            {
                MessageBox.Show("Invalid Order ID.");
                return false;
            }

            return true;
        }

        private bool ConfirmDeletion()
        {
            var result = MessageBox.Show(
                $"Are you sure you want to delete Order #{textBOxrderID.Text}?\n\nThis will also delete all order details associated with this order.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            return result == DialogResult.Yes;
        }

        private void DeleteOrderUsingControllers()
        {
            int orderID = int.Parse(textBOxrderID.Text);

            try
            {
                var orderController = new OrderController();
                var orderDetailController = new OrderDetailController();

                var orderDetails = orderDetailController.SearchOrderDetailsByOrderID(orderID).ToList();

                foreach(var detail in orderDetails)
                {
                    orderDetailController.RemoveOrderDetail(detail.OrderDetailsID);
                }

                orderController.RemoveOrder(orderID);

                MessageBox.Show(
                      $"Order #{orderID} and all related details have been deleted.",
                      "Success",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information
                  );

                ResetFormAfterDelete();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void ResetFormAfterDelete()
        {
            ClearOrderFields();
            tempOrderDetails.Clear();
            LoadAllOrders();
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            if (!ValidateOrderForUpdate())
                return;

            if (!ConfirmUpdate())
                return;

            UpdateOrderInDatabase();
        }

        private bool ValidateOrderForUpdate()
        {
            if (string.IsNullOrEmpty(textBOxrderID.Text))
            {
                MessageBox.Show("Please search for an order first before updating.");
                return false;
            }

            if (!int.TryParse(textBOxrderID.Text, out int orderID))
            {
                MessageBox.Show("Invalid Order ID.");
                return false;
            }

            if (comboBoxUser.SelectedValue == null)
            {
                MessageBox.Show("Please select a user.");
                return false;
            }

            if (comboBoxCustomer.SelectedValue == null)
            {
                MessageBox.Show("Please select a customer.");
                return false;
            }

            if (tempOrderDetails.Count == 0)
            {
                MessageBox.Show("Please add at least one book to the order.");
                return false;
            }

            if(!CheckCreditLimit())
            {
                return false;
            }
            

            return true;
        }

        private bool ConfirmUpdate()
        {
            var result = MessageBox.Show(
                $"Are you sure you want to update Order #{textBOxrderID.Text}?",
                "Confirm Update",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            return result == DialogResult.Yes;
        }

        private void UpdateOrderInDatabase()
        {
            int orderID = int.Parse(textBOxrderID.Text);

            try
            {
                var orderController = new OrderController();
                var detailController = new OrderDetailController();

                var existingOrder = orderController.SearchOrderByID(orderID);

                if (existingOrder == null)
                {
                    MessageBox.Show("Order not found.");
                    return;
                }

                existingOrder.OrderDate = dateTimePickerOrderDate.Value;
                existingOrder.UserID = (int)comboBoxUser.SelectedValue;
                existingOrder.CustomerID = (int)comboBoxCustomer.SelectedValue;
                existingOrder.TotalAmount = CalculateTotalAmount();

                orderController.UpdateOrder(existingOrder);

                var oldDetails = detailController.SearchOrderDetailsByOrderID(orderID).ToList();

                foreach (var old in oldDetails)
                {
                    detailController.RemoveOrderDetail(old.OrderDetailsID);
                }

                foreach (var detail in tempOrderDetails)
                {
                    var newDetail = new OrderDetail
                    {
                        OrderID = orderID,
                        BookID = detail.BookID,
                        Quantity = detail.Quantity,
                        UnitPrice = detail.UnitPrice
                    };

                    detailController.SaveOrderDetail(newDetail);
                }

                MessageBox.Show($"Order #{orderID} updated successfully.", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                ResetFormAfterUpdate();
                LoadAllOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error updating order: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void UpdateOrderProperties(Order order)
        {
            order.OrderDate = dateTimePickerOrderDate.Value;
            order.UserID = (int)comboBoxUser.SelectedValue;
            order.CustomerID = (int)comboBoxCustomer.SelectedValue;
            order.TotalAmount = CalculateTotalAmount();
        }

        private void DeleteExistingOrderDetails(HiTechBooksDBModel context, int orderID)
        {
            var existingDetails = context.OrderDetails.Where(od => od.OrderID == orderID).ToList();
            foreach (var detail in existingDetails)
            {
                context.OrderDetails.Remove(detail);
            }
        }

        private void AddUpdatedOrderDetails(HiTechBooksDBModel context, int orderID)
        {
            foreach (var detail in tempOrderDetails)
            {
                var orderDetail = new OrderDetail
                {
                    OrderID = orderID,
                    BookID = detail.BookID,
                    Quantity = detail.Quantity,
                    UnitPrice = detail.UnitPrice
                };

                context.OrderDetails.Add(orderDetail);
            }
        }

        private void ShowUpdateSuccessMessage(int orderID)
        {
            MessageBox.Show(
                $"Order #{orderID} has been successfully updated.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ResetFormAfterUpdate()
        {
            ClearOrderFields();
            tempOrderDetails.Clear();
            LoadAllOrders();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogIn loginForm = new FormLogIn();
            loginForm.Show();
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCustomer.SelectedIndex >= 0)
            {
                DataRowView drv = comboBoxCustomer.SelectedItem as DataRowView;
                if (drv != null)
                {
                    textBoxCreditLimit.Text = drv["CreditLimit"].ToString();
                }
            }
            else
            {
                textBoxCreditLimit.Clear();
            }
        }
    }
}
