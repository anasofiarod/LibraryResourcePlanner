namespace HiTechBooksManagement.GUI
{
    partial class FormCategories
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
            this.labelCateogry = new System.Windows.Forms.Label();
            this.groupBoxCategory = new System.Windows.Forms.GroupBox();
            this.buttonSearchCategory = new System.Windows.Forms.Button();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.buttonUpdateCategory = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.textBoxCategoryTitle = new System.Windows.Forms.TextBox();
            this.textBoxCategoryID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.dataGridViewListAllCategories = new System.Windows.Forms.DataGridView();
            this.buttonViewAllCategories = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAllCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCateogry
            // 
            this.labelCateogry.AutoSize = true;
            this.labelCateogry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCateogry.ForeColor = System.Drawing.Color.DarkRed;
            this.labelCateogry.Location = new System.Drawing.Point(20, 22);
            this.labelCateogry.Name = "labelCateogry";
            this.labelCateogry.Size = new System.Drawing.Size(275, 29);
            this.labelCateogry.TabIndex = 0;
            this.labelCateogry.Text = "Category Management";
            // 
            // groupBoxCategory
            // 
            this.groupBoxCategory.Controls.Add(this.buttonSearchCategory);
            this.groupBoxCategory.Controls.Add(this.buttonDeleteCategory);
            this.groupBoxCategory.Controls.Add(this.buttonUpdateCategory);
            this.groupBoxCategory.Controls.Add(this.buttonAddCategory);
            this.groupBoxCategory.Controls.Add(this.textBoxCategoryTitle);
            this.groupBoxCategory.Controls.Add(this.textBoxCategoryID);
            this.groupBoxCategory.Controls.Add(this.label1);
            this.groupBoxCategory.Controls.Add(this.labelID);
            this.groupBoxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCategory.Location = new System.Drawing.Point(25, 66);
            this.groupBoxCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCategory.Name = "groupBoxCategory";
            this.groupBoxCategory.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCategory.Size = new System.Drawing.Size(352, 282);
            this.groupBoxCategory.TabIndex = 1;
            this.groupBoxCategory.TabStop = false;
            this.groupBoxCategory.Text = " ";
            // 
            // buttonSearchCategory
            // 
            this.buttonSearchCategory.Location = new System.Drawing.Point(89, 166);
            this.buttonSearchCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchCategory.Name = "buttonSearchCategory";
            this.buttonSearchCategory.Size = new System.Drawing.Size(164, 30);
            this.buttonSearchCategory.TabIndex = 7;
            this.buttonSearchCategory.Text = "Search Category";
            this.buttonSearchCategory.UseVisualStyleBackColor = true;
            this.buttonSearchCategory.Click += new System.EventHandler(this.buttonSearchCategory_Click);
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.Location = new System.Drawing.Point(89, 234);
            this.buttonDeleteCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(164, 29);
            this.buttonDeleteCategory.TabIndex = 6;
            this.buttonDeleteCategory.Text = "Delete Category";
            this.buttonDeleteCategory.UseVisualStyleBackColor = true;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // buttonUpdateCategory
            // 
            this.buttonUpdateCategory.Location = new System.Drawing.Point(89, 201);
            this.buttonUpdateCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateCategory.Name = "buttonUpdateCategory";
            this.buttonUpdateCategory.Size = new System.Drawing.Size(164, 30);
            this.buttonUpdateCategory.TabIndex = 5;
            this.buttonUpdateCategory.Text = "Update Category";
            this.buttonUpdateCategory.UseVisualStyleBackColor = true;
            this.buttonUpdateCategory.Click += new System.EventHandler(this.buttonUpdateCategory_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.Location = new System.Drawing.Point(89, 134);
            this.buttonAddCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(164, 27);
            this.buttonAddCategory.TabIndex = 4;
            this.buttonAddCategory.Text = "Add Category";
            this.buttonAddCategory.UseVisualStyleBackColor = true;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // textBoxCategoryTitle
            // 
            this.textBoxCategoryTitle.Location = new System.Drawing.Point(130, 86);
            this.textBoxCategoryTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCategoryTitle.Name = "textBoxCategoryTitle";
            this.textBoxCategoryTitle.Size = new System.Drawing.Size(124, 23);
            this.textBoxCategoryTitle.TabIndex = 3;
            // 
            // textBoxCategoryID
            // 
            this.textBoxCategoryID.Location = new System.Drawing.Point(130, 50);
            this.textBoxCategoryID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCategoryID.Name = "textBoxCategoryID";
            this.textBoxCategoryID.Size = new System.Drawing.Size(124, 23);
            this.textBoxCategoryID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(99, 50);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 17);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // dataGridViewListAllCategories
            // 
            this.dataGridViewListAllCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAllCategories.Location = new System.Drawing.Point(25, 367);
            this.dataGridViewListAllCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListAllCategories.Name = "dataGridViewListAllCategories";
            this.dataGridViewListAllCategories.RowHeadersWidth = 62;
            this.dataGridViewListAllCategories.RowTemplate.Height = 28;
            this.dataGridViewListAllCategories.Size = new System.Drawing.Size(352, 120);
            this.dataGridViewListAllCategories.TabIndex = 2;
            // 
            // buttonViewAllCategories
            // 
            this.buttonViewAllCategories.Location = new System.Drawing.Point(25, 515);
            this.buttonViewAllCategories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewAllCategories.Name = "buttonViewAllCategories";
            this.buttonViewAllCategories.Size = new System.Drawing.Size(124, 37);
            this.buttonViewAllCategories.TabIndex = 6;
            this.buttonViewAllCategories.Text = "View All";
            this.buttonViewAllCategories.UseVisualStyleBackColor = true;
            this.buttonViewAllCategories.Click += new System.EventHandler(this.buttonViewAllPublishers_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(253, 515);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(124, 37);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(404, 571);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonViewAllCategories);
            this.Controls.Add(this.dataGridViewListAllCategories);
            this.Controls.Add(this.groupBoxCategory);
            this.Controls.Add(this.labelCateogry);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCategories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.FormCategories_Load);
            this.groupBoxCategory.ResumeLayout(false);
            this.groupBoxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAllCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCateogry;
        private System.Windows.Forms.GroupBox groupBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonSearchCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.Button buttonUpdateCategory;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.TextBox textBoxCategoryTitle;
        private System.Windows.Forms.TextBox textBoxCategoryID;
        private System.Windows.Forms.DataGridView dataGridViewListAllCategories;
        private System.Windows.Forms.Button buttonViewAllCategories;
        private System.Windows.Forms.Button buttonClose;
    }
}