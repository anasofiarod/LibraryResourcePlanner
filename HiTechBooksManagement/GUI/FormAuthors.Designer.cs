namespace HiTechBooksManagement.GUI
{
    partial class Authors
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.buttonSearchAuthor = new System.Windows.Forms.Button();
            this.buttonUpdateAuthor = new System.Windows.Forms.Button();
            this.buttonDeleteAuthor = new System.Windows.Forms.Button();
            this.buttonAddAuthor = new System.Windows.Forms.Button();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxAuthorLastName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorFirstName = new System.Windows.Forms.TextBox();
            this.textBoxAuthorID = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAuthorID = new System.Windows.Forms.Label();
            this.dataGridViewAllAuthors = new System.Windows.Forms.DataGridView();
            this.buttonCloseAuthorPopUp = new System.Windows.Forms.Button();
            this.buttonViewAllAuthors = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Authors Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonClearFields);
            this.groupBox1.Controls.Add(this.buttonSearchAuthor);
            this.groupBox1.Controls.Add(this.buttonUpdateAuthor);
            this.groupBox1.Controls.Add(this.buttonDeleteAuthor);
            this.groupBox1.Controls.Add(this.buttonAddAuthor);
            this.groupBox1.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textBoxAuthorLastName);
            this.groupBox1.Controls.Add(this.textBoxAuthorFirstName);
            this.groupBox1.Controls.Add(this.textBoxAuthorID);
            this.groupBox1.Controls.Add(this.labelPhone);
            this.groupBox1.Controls.Add(this.labelEmail);
            this.groupBox1.Controls.Add(this.labelLastName);
            this.groupBox1.Controls.Add(this.labelFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelAuthorID);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(495, 285);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Author Details";
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(337, 253);
            this.buttonClearFields.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(135, 23);
            this.buttonClearFields.TabIndex = 14;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // buttonSearchAuthor
            // 
            this.buttonSearchAuthor.Location = new System.Drawing.Point(360, 183);
            this.buttonSearchAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchAuthor.Name = "buttonSearchAuthor";
            this.buttonSearchAuthor.Size = new System.Drawing.Size(112, 38);
            this.buttonSearchAuthor.TabIndex = 13;
            this.buttonSearchAuthor.Text = "Search Author";
            this.buttonSearchAuthor.UseVisualStyleBackColor = true;
            this.buttonSearchAuthor.Click += new System.EventHandler(this.buttonSearchAuthor_Click);
            // 
            // buttonUpdateAuthor
            // 
            this.buttonUpdateAuthor.Location = new System.Drawing.Point(360, 128);
            this.buttonUpdateAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateAuthor.Name = "buttonUpdateAuthor";
            this.buttonUpdateAuthor.Size = new System.Drawing.Size(112, 38);
            this.buttonUpdateAuthor.TabIndex = 12;
            this.buttonUpdateAuthor.Text = "Update Author";
            this.buttonUpdateAuthor.UseVisualStyleBackColor = true;
            this.buttonUpdateAuthor.Click += new System.EventHandler(this.buttonUpdateAuthor_Click);
            // 
            // buttonDeleteAuthor
            // 
            this.buttonDeleteAuthor.Location = new System.Drawing.Point(360, 77);
            this.buttonDeleteAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteAuthor.Name = "buttonDeleteAuthor";
            this.buttonDeleteAuthor.Size = new System.Drawing.Size(112, 38);
            this.buttonDeleteAuthor.TabIndex = 11;
            this.buttonDeleteAuthor.Text = "Delete Author";
            this.buttonDeleteAuthor.UseVisualStyleBackColor = true;
            this.buttonDeleteAuthor.Click += new System.EventHandler(this.buttonDeleteAuthor_Click);
            // 
            // buttonAddAuthor
            // 
            this.buttonAddAuthor.Location = new System.Drawing.Point(360, 30);
            this.buttonAddAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddAuthor.Name = "buttonAddAuthor";
            this.buttonAddAuthor.Size = new System.Drawing.Size(112, 31);
            this.buttonAddAuthor.TabIndex = 10;
            this.buttonAddAuthor.Text = "Add Author";
            this.buttonAddAuthor.UseVisualStyleBackColor = true;
            this.buttonAddAuthor.Click += new System.EventHandler(this.buttonAddAuthor_Click);
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(88, 238);
            this.maskedTextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxPhoneNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(146, 23);
            this.maskedTextBoxPhoneNumber.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(88, 181);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(146, 23);
            this.textBoxEmail.TabIndex = 8;
            // 
            // textBoxAuthorLastName
            // 
            this.textBoxAuthorLastName.Location = new System.Drawing.Point(114, 126);
            this.textBoxAuthorLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAuthorLastName.Name = "textBoxAuthorLastName";
            this.textBoxAuthorLastName.Size = new System.Drawing.Size(120, 23);
            this.textBoxAuthorLastName.TabIndex = 7;
            // 
            // textBoxAuthorFirstName
            // 
            this.textBoxAuthorFirstName.Location = new System.Drawing.Point(114, 74);
            this.textBoxAuthorFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAuthorFirstName.Name = "textBoxAuthorFirstName";
            this.textBoxAuthorFirstName.Size = new System.Drawing.Size(120, 23);
            this.textBoxAuthorFirstName.TabIndex = 6;
            // 
            // textBoxAuthorID
            // 
            this.textBoxAuthorID.Location = new System.Drawing.Point(73, 34);
            this.textBoxAuthorID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAuthorID.Name = "textBoxAuthorID";
            this.textBoxAuthorID.Size = new System.Drawing.Size(120, 23);
            this.textBoxAuthorID.TabIndex = 5;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(23, 238);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(54, 17);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(23, 183);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(47, 17);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(23, 128);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(85, 17);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(23, 77);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 17);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // labelAuthorID
            // 
            this.labelAuthorID.AutoSize = true;
            this.labelAuthorID.Location = new System.Drawing.Point(23, 34);
            this.labelAuthorID.Name = "labelAuthorID";
            this.labelAuthorID.Size = new System.Drawing.Size(23, 17);
            this.labelAuthorID.TabIndex = 0;
            this.labelAuthorID.Text = "ID";
            // 
            // dataGridViewAllAuthors
            // 
            this.dataGridViewAllAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllAuthors.Location = new System.Drawing.Point(24, 366);
            this.dataGridViewAllAuthors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAllAuthors.Name = "dataGridViewAllAuthors";
            this.dataGridViewAllAuthors.RowHeadersWidth = 62;
            this.dataGridViewAllAuthors.RowTemplate.Height = 28;
            this.dataGridViewAllAuthors.Size = new System.Drawing.Size(495, 159);
            this.dataGridViewAllAuthors.TabIndex = 2;
            // 
            // buttonCloseAuthorPopUp
            // 
            this.buttonCloseAuthorPopUp.Location = new System.Drawing.Point(407, 542);
            this.buttonCloseAuthorPopUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCloseAuthorPopUp.Name = "buttonCloseAuthorPopUp";
            this.buttonCloseAuthorPopUp.Size = new System.Drawing.Size(112, 31);
            this.buttonCloseAuthorPopUp.TabIndex = 3;
            this.buttonCloseAuthorPopUp.Text = "Close";
            this.buttonCloseAuthorPopUp.UseVisualStyleBackColor = true;
            this.buttonCloseAuthorPopUp.Click += new System.EventHandler(this.buttonCloseAuthorPopUp_Click);
            // 
            // buttonViewAllAuthors
            // 
            this.buttonViewAllAuthors.Location = new System.Drawing.Point(24, 542);
            this.buttonViewAllAuthors.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewAllAuthors.Name = "buttonViewAllAuthors";
            this.buttonViewAllAuthors.Size = new System.Drawing.Size(112, 31);
            this.buttonViewAllAuthors.TabIndex = 13;
            this.buttonViewAllAuthors.Text = "Show All";
            this.buttonViewAllAuthors.UseVisualStyleBackColor = true;
            this.buttonViewAllAuthors.Click += new System.EventHandler(this.buttonViewAllAuthors_Click);
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(559, 594);
            this.Controls.Add(this.buttonViewAllAuthors);
            this.Controls.Add(this.buttonCloseAuthorPopUp);
            this.Controls.Add(this.dataGridViewAllAuthors);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Authors";
            this.Text = "FormAuthors";
            this.Load += new System.EventHandler(this.Authors_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllAuthors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAuthorID;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxAuthorLastName;
        private System.Windows.Forms.TextBox textBoxAuthorFirstName;
        private System.Windows.Forms.TextBox textBoxAuthorID;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewAllAuthors;
        private System.Windows.Forms.Button buttonViewAllAuthors;
        private System.Windows.Forms.Button buttonUpdateAuthor;
        private System.Windows.Forms.Button buttonDeleteAuthor;
        private System.Windows.Forms.Button buttonAddAuthor;
        private System.Windows.Forms.Button buttonCloseAuthorPopUp;
        private System.Windows.Forms.Button buttonSearchAuthor;
        private System.Windows.Forms.Button buttonClearFields;
    }
}