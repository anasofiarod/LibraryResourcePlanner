namespace HiTechBooksManagement.GUI
{
    partial class CustomerManagement
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
            this.buttonCAdd = new System.Windows.Forms.Button();
            this.dataGridViewCListAll = new System.Windows.Forms.DataGridView();
            this.buttonCDelete = new System.Windows.Forms.Button();
            this.buttonCUpdate = new System.Windows.Forms.Button();
            this.buttonCSearch = new System.Windows.Forms.Button();
            this.buttonCListAll = new System.Windows.Forms.Button();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.comboBoxQuebecCities = new System.Windows.Forms.ComboBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textBoxCreditLimit = new System.Windows.Forms.TextBox();
            this.labelCreditLimit = new System.Windows.Forms.Label();
            this.textBoxCFax = new System.Windows.Forms.TextBox();
            this.labelCFax = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelCPhone = new System.Windows.Forms.Label();
            this.textBoxCPostalCode = new System.Windows.Forms.TextBox();
            this.textBoxCustomerID = new System.Windows.Forms.TextBox();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.labelCPostalCode = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelCName = new System.Windows.Forms.Label();
            this.labelCustomerID = new System.Windows.Forms.Label();
            this.labelCustomerManagement = new System.Windows.Forms.Label();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCListAll)).BeginInit();
            this.groupBoxCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCAdd
            // 
            this.buttonCAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCAdd.Location = new System.Drawing.Point(541, 73);
            this.buttonCAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCAdd.Name = "buttonCAdd";
            this.buttonCAdd.Size = new System.Drawing.Size(121, 43);
            this.buttonCAdd.TabIndex = 23;
            this.buttonCAdd.Text = "Add";
            this.buttonCAdd.UseVisualStyleBackColor = true;
            this.buttonCAdd.Click += new System.EventHandler(this.buttonCAdd_Click);
            // 
            // dataGridViewCListAll
            // 
            this.dataGridViewCListAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCListAll.Location = new System.Drawing.Point(721, 134);
            this.dataGridViewCListAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewCListAll.Name = "dataGridViewCListAll";
            this.dataGridViewCListAll.RowHeadersWidth = 62;
            this.dataGridViewCListAll.RowTemplate.Height = 28;
            this.dataGridViewCListAll.Size = new System.Drawing.Size(548, 458);
            this.dataGridViewCListAll.TabIndex = 22;
            // 
            // buttonCDelete
            // 
            this.buttonCDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCDelete.Location = new System.Drawing.Point(284, 73);
            this.buttonCDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCDelete.Name = "buttonCDelete";
            this.buttonCDelete.Size = new System.Drawing.Size(121, 43);
            this.buttonCDelete.TabIndex = 21;
            this.buttonCDelete.Text = "Delete";
            this.buttonCDelete.UseVisualStyleBackColor = true;
            this.buttonCDelete.Click += new System.EventHandler(this.buttonCDelete_Click);
            // 
            // buttonCUpdate
            // 
            this.buttonCUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCUpdate.Location = new System.Drawing.Point(158, 73);
            this.buttonCUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCUpdate.Name = "buttonCUpdate";
            this.buttonCUpdate.Size = new System.Drawing.Size(121, 43);
            this.buttonCUpdate.TabIndex = 20;
            this.buttonCUpdate.Text = "Update";
            this.buttonCUpdate.UseVisualStyleBackColor = true;
            this.buttonCUpdate.Click += new System.EventHandler(this.buttonCUpdate_Click);
            // 
            // buttonCSearch
            // 
            this.buttonCSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCSearch.Location = new System.Drawing.Point(412, 73);
            this.buttonCSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCSearch.Name = "buttonCSearch";
            this.buttonCSearch.Size = new System.Drawing.Size(121, 43);
            this.buttonCSearch.TabIndex = 19;
            this.buttonCSearch.Text = "Search";
            this.buttonCSearch.UseVisualStyleBackColor = true;
            this.buttonCSearch.Click += new System.EventHandler(this.buttonCSearch_Click);
            // 
            // buttonCListAll
            // 
            this.buttonCListAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCListAll.Location = new System.Drawing.Point(30, 73);
            this.buttonCListAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCListAll.Name = "buttonCListAll";
            this.buttonCListAll.Size = new System.Drawing.Size(121, 43);
            this.buttonCListAll.TabIndex = 18;
            this.buttonCListAll.Text = "List All";
            this.buttonCListAll.UseVisualStyleBackColor = true;
            this.buttonCListAll.Click += new System.EventHandler(this.buttonCListAll_Click);
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxCustomer.Controls.Add(this.comboBoxQuebecCities);
            this.groupBoxCustomer.Controls.Add(this.labelCity);
            this.groupBoxCustomer.Controls.Add(this.textBoxCreditLimit);
            this.groupBoxCustomer.Controls.Add(this.labelCreditLimit);
            this.groupBoxCustomer.Controls.Add(this.textBoxCFax);
            this.groupBoxCustomer.Controls.Add(this.labelCFax);
            this.groupBoxCustomer.Controls.Add(this.maskedTextBox1);
            this.groupBoxCustomer.Controls.Add(this.labelCPhone);
            this.groupBoxCustomer.Controls.Add(this.textBoxCPostalCode);
            this.groupBoxCustomer.Controls.Add(this.textBoxCustomerID);
            this.groupBoxCustomer.Controls.Add(this.textBoxCName);
            this.groupBoxCustomer.Controls.Add(this.textBoxStreet);
            this.groupBoxCustomer.Controls.Add(this.labelCPostalCode);
            this.groupBoxCustomer.Controls.Add(this.labelPassword);
            this.groupBoxCustomer.Controls.Add(this.labelCName);
            this.groupBoxCustomer.Controls.Add(this.labelCustomerID);
            this.groupBoxCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCustomer.Location = new System.Drawing.Point(30, 134);
            this.groupBoxCustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxCustomer.Size = new System.Drawing.Size(669, 472);
            this.groupBoxCustomer.TabIndex = 17;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer Information";
            // 
            // comboBoxQuebecCities
            // 
            this.comboBoxQuebecCities.FormattingEnabled = true;
            this.comboBoxQuebecCities.Location = new System.Drawing.Point(25, 289);
            this.comboBoxQuebecCities.Name = "comboBoxQuebecCities";
            this.comboBoxQuebecCities.Size = new System.Drawing.Size(137, 30);
            this.comboBoxQuebecCities.TabIndex = 20;
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(25, 263);
            this.labelCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(41, 22);
            this.labelCity.TabIndex = 19;
            this.labelCity.Text = "City";
            // 
            // textBoxCreditLimit
            // 
            this.textBoxCreditLimit.Location = new System.Drawing.Point(449, 64);
            this.textBoxCreditLimit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCreditLimit.Name = "textBoxCreditLimit";
            this.textBoxCreditLimit.Size = new System.Drawing.Size(122, 28);
            this.textBoxCreditLimit.TabIndex = 18;
            this.textBoxCreditLimit.TextChanged += new System.EventHandler(this.textBoxCreditLimit_TextChanged);
            // 
            // labelCreditLimit
            // 
            this.labelCreditLimit.AutoSize = true;
            this.labelCreditLimit.Location = new System.Drawing.Point(445, 39);
            this.labelCreditLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreditLimit.Name = "labelCreditLimit";
            this.labelCreditLimit.Size = new System.Drawing.Size(100, 22);
            this.labelCreditLimit.TabIndex = 17;
            this.labelCreditLimit.Text = "Credit Limit";
            // 
            // textBoxCFax
            // 
            this.textBoxCFax.Location = new System.Drawing.Point(30, 430);
            this.textBoxCFax.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCFax.Name = "textBoxCFax";
            this.textBoxCFax.Size = new System.Drawing.Size(132, 28);
            this.textBoxCFax.TabIndex = 16;
            // 
            // labelCFax
            // 
            this.labelCFax.AutoSize = true;
            this.labelCFax.Location = new System.Drawing.Point(26, 407);
            this.labelCFax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCFax.Name = "labelCFax";
            this.labelCFax.Size = new System.Drawing.Size(40, 22);
            this.labelCFax.TabIndex = 15;
            this.labelCFax.Text = "Fax";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(29, 361);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(133, 28);
            this.maskedTextBox1.TabIndex = 14;
            // 
            // labelCPhone
            // 
            this.labelCPhone.AutoSize = true;
            this.labelCPhone.Location = new System.Drawing.Point(25, 336);
            this.labelCPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPhone.Name = "labelCPhone";
            this.labelCPhone.Size = new System.Drawing.Size(62, 22);
            this.labelCPhone.TabIndex = 13;
            this.labelCPhone.Text = "Phone";
            // 
            // textBoxCPostalCode
            // 
            this.textBoxCPostalCode.Location = new System.Drawing.Point(185, 289);
            this.textBoxCPostalCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCPostalCode.Name = "textBoxCPostalCode";
            this.textBoxCPostalCode.Size = new System.Drawing.Size(124, 28);
            this.textBoxCPostalCode.TabIndex = 10;
            // 
            // textBoxCustomerID
            // 
            this.textBoxCustomerID.Location = new System.Drawing.Point(25, 74);
            this.textBoxCustomerID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCustomerID.Name = "textBoxCustomerID";
            this.textBoxCustomerID.Size = new System.Drawing.Size(122, 28);
            this.textBoxCustomerID.TabIndex = 9;
            // 
            // textBoxCName
            // 
            this.textBoxCName.Location = new System.Drawing.Point(29, 140);
            this.textBoxCName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.Size = new System.Drawing.Size(122, 28);
            this.textBoxCName.TabIndex = 8;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(29, 210);
            this.textBoxStreet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(280, 28);
            this.textBoxStreet.TabIndex = 7;
            // 
            // labelCPostalCode
            // 
            this.labelCPostalCode.AutoSize = true;
            this.labelCPostalCode.Location = new System.Drawing.Point(181, 263);
            this.labelCPostalCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPostalCode.Name = "labelCPostalCode";
            this.labelCPostalCode.Size = new System.Drawing.Size(108, 22);
            this.labelCPostalCode.TabIndex = 4;
            this.labelCPostalCode.Text = "Postal Code";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(25, 185);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(58, 22);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Street";
            // 
            // labelCName
            // 
            this.labelCName.AutoSize = true;
            this.labelCName.Location = new System.Drawing.Point(25, 115);
            this.labelCName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCName.Name = "labelCName";
            this.labelCName.Size = new System.Drawing.Size(57, 22);
            this.labelCName.TabIndex = 2;
            this.labelCName.Text = "Name";
            // 
            // labelCustomerID
            // 
            this.labelCustomerID.AutoSize = true;
            this.labelCustomerID.Location = new System.Drawing.Point(21, 43);
            this.labelCustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerID.Name = "labelCustomerID";
            this.labelCustomerID.Size = new System.Drawing.Size(109, 22);
            this.labelCustomerID.TabIndex = 1;
            this.labelCustomerID.Text = "Customer ID";
            // 
            // labelCustomerManagement
            // 
            this.labelCustomerManagement.AutoSize = true;
            this.labelCustomerManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerManagement.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCustomerManagement.Location = new System.Drawing.Point(40, 28);
            this.labelCustomerManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerManagement.Name = "labelCustomerManagement";
            this.labelCustomerManagement.Size = new System.Drawing.Size(376, 38);
            this.labelCustomerManagement.TabIndex = 24;
            this.labelCustomerManagement.Text = "Customer Management";
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearFields.Location = new System.Drawing.Point(1032, 73);
            this.buttonClearFields.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(121, 43);
            this.buttonClearFields.TabIndex = 21;
            this.buttonClearFields.Text = "Clear";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(1161, 73);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(121, 43);
            this.buttonClose.TabIndex = 25;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // CustomerManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1311, 614);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.labelCustomerManagement);
            this.Controls.Add(this.buttonCAdd);
            this.Controls.Add(this.dataGridViewCListAll);
            this.Controls.Add(this.buttonCDelete);
            this.Controls.Add(this.buttonCUpdate);
            this.Controls.Add(this.buttonCSearch);
            this.Controls.Add(this.buttonCListAll);
            this.Controls.Add(this.groupBoxCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CustomerManagement";
            this.Text = "Customer Management";
            this.Load += new System.EventHandler(this.CustomerManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCListAll)).EndInit();
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCAdd;
        private System.Windows.Forms.DataGridView dataGridViewCListAll;
        private System.Windows.Forms.Button buttonCDelete;
        private System.Windows.Forms.Button buttonCUpdate;
        private System.Windows.Forms.Button buttonCSearch;
        private System.Windows.Forms.Button buttonCListAll;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.TextBox textBoxCPostalCode;
        private System.Windows.Forms.TextBox textBoxCustomerID;
        private System.Windows.Forms.TextBox textBoxCName;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label labelCPostalCode;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelCName;
        private System.Windows.Forms.Label labelCustomerID;
        private System.Windows.Forms.Label labelCreditLimit;
        private System.Windows.Forms.TextBox textBoxCFax;
        private System.Windows.Forms.Label labelCFax;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labelCPhone;
        private System.Windows.Forms.TextBox textBoxCreditLimit;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelCustomerManagement;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.ComboBox comboBoxQuebecCities;
        private System.Windows.Forms.Button buttonClose;
    }
}