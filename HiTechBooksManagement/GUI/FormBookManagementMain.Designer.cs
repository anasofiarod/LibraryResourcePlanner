namespace HiTechBooksManagement.GUI
{
    partial class FormBookManagementMain
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBoxBooks = new System.Windows.Forms.GroupBox();
            this.checkedListBoxAuthors = new System.Windows.Forms.CheckedListBox();
            this.buttonSearchByISBN = new System.Windows.Forms.Button();
            this.textBoxBookID = new System.Windows.Forms.TextBox();
            this.labelBookID = new System.Windows.Forms.Label();
            this.buttonSearchByBookID = new System.Windows.Forms.Button();
            this.comboBoxPublisher = new System.Windows.Forms.ComboBox();
            this.textBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.labelUnitPrice = new System.Windows.Forms.Label();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.buttonAddPublisher = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.labelAuthorName = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.labelCategoryTitle = new System.Windows.Forms.Label();
            this.textBoxQuantityAvailable = new System.Windows.Forms.TextBox();
            this.labelQuantities = new System.Windows.Forms.Label();
            this.textBoxPublishedYear = new System.Windows.Forms.TextBox();
            this.labelYearPublished = new System.Windows.Forms.Label();
            this.textBoxBookTitle = new System.Windows.Forms.TextBox();
            this.labelBookTitle = new System.Windows.Forms.Label();
            this.textBoxISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.buttonUpdateBook = new System.Windows.Forms.Button();
            this.buttonDeleteBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonListAllBooks = new System.Windows.Forms.Button();
            this.buttonClearForm = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBoxBooks
            // 
            this.groupBoxBooks.Controls.Add(this.checkedListBoxAuthors);
            this.groupBoxBooks.Controls.Add(this.buttonSearchByISBN);
            this.groupBoxBooks.Controls.Add(this.textBoxBookID);
            this.groupBoxBooks.Controls.Add(this.labelBookID);
            this.groupBoxBooks.Controls.Add(this.buttonSearchByBookID);
            this.groupBoxBooks.Controls.Add(this.comboBoxPublisher);
            this.groupBoxBooks.Controls.Add(this.textBoxUnitPrice);
            this.groupBoxBooks.Controls.Add(this.labelUnitPrice);
            this.groupBoxBooks.Controls.Add(this.buttonAddAuthor);
            this.groupBoxBooks.Controls.Add(this.buttonAddPublisher);
            this.groupBoxBooks.Controls.Add(this.buttonAddCategory);
            this.groupBoxBooks.Controls.Add(this.labelAuthorName);
            this.groupBoxBooks.Controls.Add(this.labelPublisher);
            this.groupBoxBooks.Controls.Add(this.comboBoxCategories);
            this.groupBoxBooks.Controls.Add(this.labelCategoryTitle);
            this.groupBoxBooks.Controls.Add(this.textBoxQuantityAvailable);
            this.groupBoxBooks.Controls.Add(this.labelQuantities);
            this.groupBoxBooks.Controls.Add(this.textBoxPublishedYear);
            this.groupBoxBooks.Controls.Add(this.labelYearPublished);
            this.groupBoxBooks.Controls.Add(this.textBoxBookTitle);
            this.groupBoxBooks.Controls.Add(this.labelBookTitle);
            this.groupBoxBooks.Controls.Add(this.textBoxISBN);
            this.groupBoxBooks.Controls.Add(this.labelISBN);
            this.groupBoxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBooks.Location = new System.Drawing.Point(28, 39);
            this.groupBoxBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBooks.Name = "groupBoxBooks";
            this.groupBoxBooks.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxBooks.Size = new System.Drawing.Size(1076, 253);
            this.groupBoxBooks.TabIndex = 3;
            this.groupBoxBooks.TabStop = false;
            this.groupBoxBooks.Text = "Book Information";
            this.groupBoxBooks.Enter += new System.EventHandler(this.groupBoxBooks_Enter);
            // 
            // checkedListBoxAuthors
            // 
            this.checkedListBoxAuthors.FormattingEnabled = true;
            this.checkedListBoxAuthors.Location = new System.Drawing.Point(563, 140);
            this.checkedListBoxAuthors.Name = "checkedListBoxAuthors";
            this.checkedListBoxAuthors.Size = new System.Drawing.Size(262, 94);
            this.checkedListBoxAuthors.TabIndex = 25;
            // 
            // buttonSearchByISBN
            // 
            this.buttonSearchByISBN.Location = new System.Drawing.Point(845, 35);
            this.buttonSearchByISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchByISBN.Name = "buttonSearchByISBN";
            this.buttonSearchByISBN.Size = new System.Drawing.Size(140, 23);
            this.buttonSearchByISBN.TabIndex = 22;
            this.buttonSearchByISBN.Text = "Search by ISBN";
            this.buttonSearchByISBN.UseVisualStyleBackColor = true;
            this.buttonSearchByISBN.Click += new System.EventHandler(this.buttonSearchByISBN_Click);
            // 
            // textBoxBookID
            // 
            this.textBoxBookID.Location = new System.Drawing.Point(99, 33);
            this.textBoxBookID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBookID.Name = "textBoxBookID";
            this.textBoxBookID.Size = new System.Drawing.Size(174, 23);
            this.textBoxBookID.TabIndex = 21;
            // 
            // labelBookID
            // 
            this.labelBookID.AutoSize = true;
            this.labelBookID.Location = new System.Drawing.Point(14, 33);
            this.labelBookID.Name = "labelBookID";
            this.labelBookID.Size = new System.Drawing.Size(64, 17);
            this.labelBookID.TabIndex = 20;
            this.labelBookID.Text = "Book ID";
            // 
            // buttonSearchByBookID
            // 
            this.buttonSearchByBookID.Location = new System.Drawing.Point(279, 32);
            this.buttonSearchByBookID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchByBookID.Name = "buttonSearchByBookID";
            this.buttonSearchByBookID.Size = new System.Drawing.Size(128, 25);
            this.buttonSearchByBookID.TabIndex = 9;
            this.buttonSearchByBookID.Text = "Search by ID";
            this.buttonSearchByBookID.UseVisualStyleBackColor = true;
            this.buttonSearchByBookID.Click += new System.EventHandler(this.buttonSearchBook_Click);
            // 
            // comboBoxPublisher
            // 
            this.comboBoxPublisher.FormattingEnabled = true;
            this.comboBoxPublisher.Location = new System.Drawing.Point(100, 187);
            this.comboBoxPublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPublisher.Name = "comboBoxPublisher";
            this.comboBoxPublisher.Size = new System.Drawing.Size(208, 24);
            this.comboBoxPublisher.TabIndex = 18;
            // 
            // textBoxUnitPrice
            // 
            this.textBoxUnitPrice.Location = new System.Drawing.Point(596, 67);
            this.textBoxUnitPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUnitPrice.Name = "textBoxUnitPrice";
            this.textBoxUnitPrice.Size = new System.Drawing.Size(243, 23);
            this.textBoxUnitPrice.TabIndex = 17;
            // 
            // labelUnitPrice
            // 
            this.labelUnitPrice.AutoSize = true;
            this.labelUnitPrice.Location = new System.Drawing.Point(491, 70);
            this.labelUnitPrice.Name = "labelUnitPrice";
            this.labelUnitPrice.Size = new System.Drawing.Size(79, 17);
            this.labelUnitPrice.TabIndex = 11;
            this.labelUnitPrice.Text = "Unit Price";
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(868, 140);
            this.buttonAddAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(144, 24);
            this.buttonAddAuthor.TabIndex = 15;
            this.buttonAddAuthor.Text = "+ Add Author";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // buttonAddPublisher
            // 
            this.buttonAddPublisher.Location = new System.Drawing.Point(314, 183);
            this.buttonAddPublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPublisher.Name = "buttonAddPublisher";
            this.buttonAddPublisher.Size = new System.Drawing.Size(158, 28);
            this.buttonAddPublisher.TabIndex = 14;
            this.buttonAddPublisher.Text = "+Add Publisher";
            this.buttonAddPublisher.UseVisualStyleBackColor = true;
            this.buttonAddPublisher.Click += new System.EventHandler(this.buttonAddPublisher_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(314, 137);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(158, 27);
            this.buttonAddCategory.TabIndex = 13;
            this.buttonAddCategory.Text = "+ Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // labelAuthorName
            // 
            this.labelAuthorName.AutoSize = true;
            this.labelAuthorName.Location = new System.Drawing.Point(491, 140);
            this.labelAuthorName.Name = "labelAuthorName";
            this.labelAuthorName.Size = new System.Drawing.Size(56, 17);
            this.labelAuthorName.TabIndex = 12;
            this.labelAuthorName.Text = "Author";
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(14, 186);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(76, 17);
            this.labelPublisher.TabIndex = 10;
            this.labelPublisher.Text = "Publisher";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(106, 140);
            this.comboBoxCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(203, 24);
            this.comboBoxCategories.TabIndex = 9;
            // 
            // labelCategoryTitle
            // 
            this.labelCategoryTitle.AutoSize = true;
            this.labelCategoryTitle.Location = new System.Drawing.Point(16, 140);
            this.labelCategoryTitle.Name = "labelCategoryTitle";
            this.labelCategoryTitle.Size = new System.Drawing.Size(73, 17);
            this.labelCategoryTitle.TabIndex = 8;
            this.labelCategoryTitle.Text = "Category";
            // 
            // textBoxQuantityAvailable
            // 
            this.textBoxQuantityAvailable.Location = new System.Drawing.Point(596, 100);
            this.textBoxQuantityAvailable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxQuantityAvailable.Name = "textBoxQuantityAvailable";
            this.textBoxQuantityAvailable.Size = new System.Drawing.Size(174, 23);
            this.textBoxQuantityAvailable.TabIndex = 7;
            // 
            // labelQuantities
            // 
            this.labelQuantities.AutoSize = true;
            this.labelQuantities.Location = new System.Drawing.Point(491, 107);
            this.labelQuantities.Name = "labelQuantities";
            this.labelQuantities.Size = new System.Drawing.Size(104, 17);
            this.labelQuantities.TabIndex = 6;
            this.labelQuantities.Text = "Qty Available";
            // 
            // textBoxPublishedYear
            // 
            this.textBoxPublishedYear.Location = new System.Drawing.Point(155, 99);
            this.textBoxPublishedYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPublishedYear.Name = "textBoxPublishedYear";
            this.textBoxPublishedYear.Size = new System.Drawing.Size(174, 23);
            this.textBoxPublishedYear.TabIndex = 5;
            // 
            // labelYearPublished
            // 
            this.labelYearPublished.AutoSize = true;
            this.labelYearPublished.Location = new System.Drawing.Point(14, 105);
            this.labelYearPublished.Name = "labelYearPublished";
            this.labelYearPublished.Size = new System.Drawing.Size(118, 17);
            this.labelYearPublished.TabIndex = 4;
            this.labelYearPublished.Text = "Year Published";
            // 
            // textBoxBookTitle
            // 
            this.textBoxBookTitle.Location = new System.Drawing.Point(99, 70);
            this.textBoxBookTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBookTitle.Name = "textBoxBookTitle";
            this.textBoxBookTitle.Size = new System.Drawing.Size(308, 23);
            this.textBoxBookTitle.TabIndex = 3;
            // 
            // labelBookTitle
            // 
            this.labelBookTitle.AutoSize = true;
            this.labelBookTitle.Location = new System.Drawing.Point(14, 70);
            this.labelBookTitle.Name = "labelBookTitle";
            this.labelBookTitle.Size = new System.Drawing.Size(81, 17);
            this.labelBookTitle.TabIndex = 2;
            this.labelBookTitle.Text = "Book Title";
            // 
            // textBoxISBN
            // 
            this.textBoxISBN.Location = new System.Drawing.Point(596, 34);
            this.textBoxISBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxISBN.Name = "textBoxISBN";
            this.textBoxISBN.Size = new System.Drawing.Size(243, 23);
            this.textBoxISBN.TabIndex = 1;
            this.textBoxISBN.TextChanged += new System.EventHandler(this.textBoxISBN_TextChanged);
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(491, 35);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(43, 17);
            this.labelISBN.TabIndex = 0;
            this.labelISBN.Text = "ISBN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(22, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Books Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewBooks
            // 
            this.dataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooks.Location = new System.Drawing.Point(28, 340);
            this.dataGridViewBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBooks.Name = "dataGridViewBooks";
            this.dataGridViewBooks.RowHeadersWidth = 62;
            this.dataGridViewBooks.RowTemplate.Height = 28;
            this.dataGridViewBooks.Size = new System.Drawing.Size(1076, 290);
            this.dataGridViewBooks.TabIndex = 5;
            this.dataGridViewBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBooks_CellContentClick);
            // 
            // buttonUpdateBook
            // 
            this.buttonUpdateBook.Location = new System.Drawing.Point(183, 297);
            this.buttonUpdateBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateBook.Name = "buttonUpdateBook";
            this.buttonUpdateBook.Size = new System.Drawing.Size(140, 30);
            this.buttonUpdateBook.TabIndex = 6;
            this.buttonUpdateBook.Text = "Update Book";
            this.buttonUpdateBook.UseVisualStyleBackColor = true;
            this.buttonUpdateBook.Click += new System.EventHandler(this.buttonUpdateBook_Click);
            // 
            // buttonDeleteBook
            // 
            this.buttonDeleteBook.Location = new System.Drawing.Point(328, 297);
            this.buttonDeleteBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteBook.Name = "buttonDeleteBook";
            this.buttonDeleteBook.Size = new System.Drawing.Size(140, 30);
            this.buttonDeleteBook.TabIndex = 7;
            this.buttonDeleteBook.Text = "Delete Book";
            this.buttonDeleteBook.UseVisualStyleBackColor = true;
            this.buttonDeleteBook.Click += new System.EventHandler(this.buttonDeleteBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(28, 297);
            this.buttonAddBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(140, 30);
            this.buttonAddBook.TabIndex = 8;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonListAllBooks
            // 
            this.buttonListAllBooks.Location = new System.Drawing.Point(28, 634);
            this.buttonListAllBooks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonListAllBooks.Name = "buttonListAllBooks";
            this.buttonListAllBooks.Size = new System.Drawing.Size(140, 30);
            this.buttonListAllBooks.TabIndex = 10;
            this.buttonListAllBooks.Text = "Show All";
            this.buttonListAllBooks.UseVisualStyleBackColor = true;
            this.buttonListAllBooks.Click += new System.EventHandler(this.buttonListAllBooks_Click);
            // 
            // buttonClearForm
            // 
            this.buttonClearForm.Location = new System.Drawing.Point(473, 297);
            this.buttonClearForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClearForm.Name = "buttonClearForm";
            this.buttonClearForm.Size = new System.Drawing.Size(140, 30);
            this.buttonClearForm.TabIndex = 11;
            this.buttonClearForm.Text = "Clear Form";
            this.buttonClearForm.UseVisualStyleBackColor = true;
            this.buttonClearForm.Click += new System.EventHandler(this.buttonClearForm_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(964, 633);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(140, 30);
            this.buttonClose.TabIndex = 12;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormBookManagementMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1140, 674);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonClearForm);
            this.Controls.Add(this.buttonListAllBooks);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonDeleteBook);
            this.Controls.Add(this.buttonUpdateBook);
            this.Controls.Add(this.dataGridViewBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxBooks);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormBookManagementMain";
            this.Text = "Hi-Tech Book Management";
            this.Load += new System.EventHandler(this.FormBookManagementMain_Load);
            this.groupBoxBooks.ResumeLayout(false);
            this.groupBoxBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.GroupBox groupBoxBooks;
        private System.Windows.Forms.Label labelBookTitle;
        private System.Windows.Forms.TextBox textBoxISBN;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.Label labelCategoryTitle;
        private System.Windows.Forms.TextBox textBoxQuantityAvailable;
        private System.Windows.Forms.Label labelQuantities;
        private System.Windows.Forms.TextBox textBoxPublishedYear;
        private System.Windows.Forms.Label labelYearPublished;
        private System.Windows.Forms.TextBox textBoxBookTitle;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonAddPublisher;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Label labelAuthorName;
        private System.Windows.Forms.DataGridView dataGridViewBooks;
        private System.Windows.Forms.Button buttonUpdateBook;
        private System.Windows.Forms.Button buttonDeleteBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonSearchByBookID;
        private System.Windows.Forms.Button buttonListAllBooks;
        private System.Windows.Forms.TextBox textBoxUnitPrice;
        private System.Windows.Forms.Label labelUnitPrice;
        private System.Windows.Forms.ComboBox comboBoxPublisher;
        private System.Windows.Forms.TextBox textBoxBookID;
        private System.Windows.Forms.Label labelBookID;
        private System.Windows.Forms.Button buttonSearchByISBN;
        private System.Windows.Forms.Button buttonClearForm;
        private System.Windows.Forms.CheckedListBox checkedListBoxAuthors;
        private System.Windows.Forms.Button buttonClose;
    }
}