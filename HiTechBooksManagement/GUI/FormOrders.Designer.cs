namespace HiTechBooksManagement.GUI
{
    partial class FormOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOrderManagement = new System.Windows.Forms.Label();
            this.groupBoxOrderInformation = new System.Windows.Forms.GroupBox();
            this.textBoxCreditLimit = new System.Windows.Forms.TextBox();
            this.labelCreditLimit = new System.Windows.Forms.Label();
            this.buttonUpdateOrder = new System.Windows.Forms.Button();
            this.buttonDeleteOrder = new System.Windows.Forms.Button();
            this.buttonNewOrder = new System.Windows.Forms.Button();
            this.buttonSaveOrder = new System.Windows.Forms.Button();
            this.textBoxTotalAmount = new System.Windows.Forms.TextBox();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.textBOxrderID = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrderDate = new System.Windows.Forms.DateTimePicker();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelOrderDate = new System.Windows.Forms.Label();
            this.labelOrderID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.comboBoxBook = new System.Windows.Forms.ComboBox();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelBook = new System.Windows.Forms.Label();
            this.buttonSearchOrder = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearchOrder = new System.Windows.Forms.TextBox();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.labelOrderDetails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAllOrders = new System.Windows.Forms.DataGridView();
            this.buttonViewAll = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxOrderInformation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOrderManagement
            // 
            this.labelOrderManagement.AutoSize = true;
            this.labelOrderManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderManagement.ForeColor = System.Drawing.Color.Maroon;
            this.labelOrderManagement.Location = new System.Drawing.Point(12, 9);
            this.labelOrderManagement.Name = "labelOrderManagement";
            this.labelOrderManagement.Size = new System.Drawing.Size(263, 31);
            this.labelOrderManagement.TabIndex = 5;
            this.labelOrderManagement.Text = "Order Management";
            // 
            // groupBoxOrderInformation
            // 
            this.groupBoxOrderInformation.Controls.Add(this.textBoxCreditLimit);
            this.groupBoxOrderInformation.Controls.Add(this.labelCreditLimit);
            this.groupBoxOrderInformation.Controls.Add(this.buttonUpdateOrder);
            this.groupBoxOrderInformation.Controls.Add(this.buttonDeleteOrder);
            this.groupBoxOrderInformation.Controls.Add(this.buttonNewOrder);
            this.groupBoxOrderInformation.Controls.Add(this.buttonSaveOrder);
            this.groupBoxOrderInformation.Controls.Add(this.textBoxTotalAmount);
            this.groupBoxOrderInformation.Controls.Add(this.comboBoxCustomer);
            this.groupBoxOrderInformation.Controls.Add(this.comboBoxUser);
            this.groupBoxOrderInformation.Controls.Add(this.textBOxrderID);
            this.groupBoxOrderInformation.Controls.Add(this.dateTimePickerOrderDate);
            this.groupBoxOrderInformation.Controls.Add(this.labelTotalAmount);
            this.groupBoxOrderInformation.Controls.Add(this.labelCustomer);
            this.groupBoxOrderInformation.Controls.Add(this.labelUser);
            this.groupBoxOrderInformation.Controls.Add(this.labelOrderDate);
            this.groupBoxOrderInformation.Controls.Add(this.labelOrderID);
            this.groupBoxOrderInformation.Location = new System.Drawing.Point(18, 101);
            this.groupBoxOrderInformation.Name = "groupBoxOrderInformation";
            this.groupBoxOrderInformation.Size = new System.Drawing.Size(745, 229);
            this.groupBoxOrderInformation.TabIndex = 6;
            this.groupBoxOrderInformation.TabStop = false;
            this.groupBoxOrderInformation.Text = "Order Information";
            // 
            // textBoxCreditLimit
            // 
            this.textBoxCreditLimit.Location = new System.Drawing.Point(413, 120);
            this.textBoxCreditLimit.Name = "textBoxCreditLimit";
            this.textBoxCreditLimit.ReadOnly = true;
            this.textBoxCreditLimit.Size = new System.Drawing.Size(155, 22);
            this.textBoxCreditLimit.TabIndex = 13;
            // 
            // labelCreditLimit
            // 
            this.labelCreditLimit.AutoSize = true;
            this.labelCreditLimit.Location = new System.Drawing.Point(332, 123);
            this.labelCreditLimit.Name = "labelCreditLimit";
            this.labelCreditLimit.Size = new System.Drawing.Size(75, 16);
            this.labelCreditLimit.TabIndex = 12;
            this.labelCreditLimit.Text = "Credit Limit:";
            // 
            // buttonUpdateOrder
            // 
            this.buttonUpdateOrder.Location = new System.Drawing.Point(491, 181);
            this.buttonUpdateOrder.Name = "buttonUpdateOrder";
            this.buttonUpdateOrder.Size = new System.Drawing.Size(133, 36);
            this.buttonUpdateOrder.TabIndex = 11;
            this.buttonUpdateOrder.Text = "Update Order";
            this.buttonUpdateOrder.UseVisualStyleBackColor = true;
            this.buttonUpdateOrder.Click += new System.EventHandler(this.buttonUpdateOrder_Click);
            // 
            // buttonDeleteOrder
            // 
            this.buttonDeleteOrder.Location = new System.Drawing.Point(335, 181);
            this.buttonDeleteOrder.Name = "buttonDeleteOrder";
            this.buttonDeleteOrder.Size = new System.Drawing.Size(128, 36);
            this.buttonDeleteOrder.TabIndex = 10;
            this.buttonDeleteOrder.Text = "Delete Order";
            this.buttonDeleteOrder.UseVisualStyleBackColor = true;
            this.buttonDeleteOrder.Click += new System.EventHandler(this.buttonDeleteOrder_Click);
            // 
            // buttonNewOrder
            // 
            this.buttonNewOrder.Location = new System.Drawing.Point(169, 181);
            this.buttonNewOrder.Name = "buttonNewOrder";
            this.buttonNewOrder.Size = new System.Drawing.Size(130, 36);
            this.buttonNewOrder.TabIndex = 9;
            this.buttonNewOrder.Text = "New Order";
            this.buttonNewOrder.UseVisualStyleBackColor = true;
            this.buttonNewOrder.Click += new System.EventHandler(this.buttonNewOrder_Click);
            // 
            // buttonSaveOrder
            // 
            this.buttonSaveOrder.Location = new System.Drawing.Point(25, 181);
            this.buttonSaveOrder.Name = "buttonSaveOrder";
            this.buttonSaveOrder.Size = new System.Drawing.Size(108, 36);
            this.buttonSaveOrder.TabIndex = 7;
            this.buttonSaveOrder.Text = "Save Order";
            this.buttonSaveOrder.UseVisualStyleBackColor = true;
            this.buttonSaveOrder.Click += new System.EventHandler(this.buttonSaveOrder_Click);
            // 
            // textBoxTotalAmount
            // 
            this.textBoxTotalAmount.Location = new System.Drawing.Point(120, 150);
            this.textBoxTotalAmount.Name = "textBoxTotalAmount";
            this.textBoxTotalAmount.ReadOnly = true;
            this.textBoxTotalAmount.Size = new System.Drawing.Size(200, 22);
            this.textBoxTotalAmount.TabIndex = 7;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(120, 114);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCustomer.TabIndex = 8;
            this.comboBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomer_SelectedIndexChanged);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(120, 84);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(200, 24);
            this.comboBoxUser.TabIndex = 7;
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            // 
            // textBOxrderID
            // 
            this.textBOxrderID.Location = new System.Drawing.Point(115, 32);
            this.textBOxrderID.Name = "textBOxrderID";
            this.textBOxrderID.ReadOnly = true;
            this.textBOxrderID.Size = new System.Drawing.Size(200, 22);
            this.textBOxrderID.TabIndex = 6;
            // 
            // dateTimePickerOrderDate
            // 
            this.dateTimePickerOrderDate.Location = new System.Drawing.Point(120, 56);
            this.dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            this.dateTimePickerOrderDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerOrderDate.TabIndex = 5;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Location = new System.Drawing.Point(22, 153);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(92, 16);
            this.labelTotalAmount.TabIndex = 4;
            this.labelTotalAmount.Text = "Total Amount: ";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(22, 117);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(67, 16);
            this.labelCustomer.TabIndex = 3;
            this.labelCustomer.Text = "Customer:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(22, 89);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(39, 16);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "User:";
            // 
            // labelOrderDate
            // 
            this.labelOrderDate.AutoSize = true;
            this.labelOrderDate.Location = new System.Drawing.Point(22, 61);
            this.labelOrderDate.Name = "labelOrderDate";
            this.labelOrderDate.Size = new System.Drawing.Size(76, 16);
            this.labelOrderDate.TabIndex = 1;
            this.labelOrderDate.Text = "Order Date:";
            // 
            // labelOrderID
            // 
            this.labelOrderID.AutoSize = true;
            this.labelOrderID.Location = new System.Drawing.Point(22, 35);
            this.labelOrderID.Name = "labelOrderID";
            this.labelOrderID.Size = new System.Drawing.Size(63, 16);
            this.labelOrderID.TabIndex = 0;
            this.labelOrderID.Text = "Order ID: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownQuantity);
            this.groupBox1.Controls.Add(this.textBoxUnitPrice);
            this.groupBox1.Controls.Add(this.comboBoxBook);
            this.groupBox1.Controls.Add(this.buttonRemoveSelected);
            this.groupBox1.Controls.Add(this.buttonAddBook);
            this.groupBox1.Controls.Add(this.labelUnitPrice);
            this.groupBox1.Controls.Add(this.labelQuantity);
            this.groupBox1.Controls.Add(this.labelBook);
            this.groupBox1.Location = new System.Drawing.Point(18, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Location = new System.Drawing.Point(120, 55);
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(200, 22);
            this.numericUpDownQuantity.TabIndex = 18;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(120, 84);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(200, 22);
            this.textBoxUnitPrice.TabIndex = 13;
            // 
            // comboBoxBook
            // 
            this.comboBoxBook.FormattingEnabled = true;
            this.comboBoxBook.Location = new System.Drawing.Point(120, 28);
            this.comboBoxBook.Name = "comboBoxBook";
            this.comboBoxBook.Size = new System.Drawing.Size(200, 24);
            this.comboBoxBook.TabIndex = 11;
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Location = new System.Drawing.Point(150, 125);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(149, 36);
            this.buttonRemoveSelected.TabIndex = 9;
            this.buttonRemoveSelected.Text = "Remove Selected";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(25, 125);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(108, 36);
            this.buttonAddBook.TabIndex = 7;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(22, 87);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(67, 16);
            this.labelUnitPrice.TabIndex = 2;
            this.labelUnitPrice.Text = "Unit Price:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(22, 61);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(58, 16);
            this.labelQuantity.TabIndex = 1;
            this.labelQuantity.Text = "Quantity:";
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Location = new System.Drawing.Point(22, 31);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(42, 16);
            this.labelBook.TabIndex = 0;
            this.labelBook.Text = "Book:";
            // 
            // buttonSearchOrder
            // 
            this.buttonSearchOrder.Location = new System.Drawing.Point(353, 62);
            this.buttonSearchOrder.Name = "buttonSearchOrder";
            this.buttonSearchOrder.Size = new System.Drawing.Size(133, 33);
            this.buttonSearchOrder.TabIndex = 12;
            this.buttonSearchOrder.Text = "Search Order";
            this.buttonSearchOrder.UseVisualStyleBackColor = true;
            this.buttonSearchOrder.Click += new System.EventHandler(this.buttonSearchOrder_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(40, 67);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(87, 16);
            this.labelSearch.TabIndex = 13;
            this.labelSearch.Text = "Search Order";
            // 
            // textBoxSearchOrder
            // 
            this.textBoxSearchOrder.Location = new System.Drawing.Point(133, 67);
            this.textBoxSearchOrder.Name = "textBoxSearchOrder";
            this.textBoxSearchOrder.Size = new System.Drawing.Size(205, 22);
            this.textBoxSearchOrder.TabIndex = 13;
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(18, 567);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.RowHeadersWidth = 51;
            this.dataGridViewOrderDetails.RowTemplate.Height = 24;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(745, 160);
            this.dataGridViewOrderDetails.TabIndex = 14;
            // 
            // labelOrderDetails
            // 
            this.labelOrderDetails.AutoSize = true;
            this.labelOrderDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderDetails.Location = new System.Drawing.Point(19, 539);
            this.labelOrderDetails.Name = "labelOrderDetails";
            this.labelOrderDetails.Size = new System.Drawing.Size(139, 25);
            this.labelOrderDetails.TabIndex = 15;
            this.labelOrderDetails.Text = "Order Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 730);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "All Orders";
            // 
            // dataGridViewAllOrders
            // 
            this.dataGridViewAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllOrders.Location = new System.Drawing.Point(18, 758);
            this.dataGridViewAllOrders.Name = "dataGridViewAllOrders";
            this.dataGridViewAllOrders.RowHeadersWidth = 51;
            this.dataGridViewAllOrders.RowTemplate.Height = 24;
            this.dataGridViewAllOrders.Size = new System.Drawing.Size(745, 160);
            this.dataGridViewAllOrders.TabIndex = 17;
            // 
            // buttonViewAll
            // 
            this.buttonViewAll.Location = new System.Drawing.Point(24, 924);
            this.buttonViewAll.Name = "buttonViewAll";
            this.buttonViewAll.Size = new System.Drawing.Size(108, 36);
            this.buttonViewAll.TabIndex = 14;
            this.buttonViewAll.Text = "View All";
            this.buttonViewAll.UseVisualStyleBackColor = true;
            this.buttonViewAll.Click += new System.EventHandler(this.buttonViewAll_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(655, 924);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(108, 36);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(807, 969);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonViewAll);
            this.Controls.Add(this.dataGridViewAllOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOrderDetails);
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Controls.Add(this.textBoxSearchOrder);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.buttonSearchOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxOrderInformation);
            this.Controls.Add(this.labelOrderManagement);
            this.Name = "FormOrders";
            this.Text = "FormOrders";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.groupBoxOrderInformation.ResumeLayout(false);
            this.groupBoxOrderInformation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrderManagement;
        private System.Windows.Forms.GroupBox groupBoxOrderInformation;
        private System.Windows.Forms.TextBox textBOxrderID;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelOrderDate;
        private System.Windows.Forms.Label labelOrderID;
        private System.Windows.Forms.TextBox textBoxTotalAmount;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Button buttonDeleteOrder;
        private System.Windows.Forms.Button buttonNewOrder;
        private System.Windows.Forms.Button buttonSaveOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBook;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.Button buttonUpdateOrder;
        private System.Windows.Forms.Button buttonSearchOrder;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearchOrder;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Label labelOrderDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAllOrders;
        private System.Windows.Forms.Button buttonViewAll;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxCreditLimit;
        private System.Windows.Forms.Label labelCreditLimit;
    }
}