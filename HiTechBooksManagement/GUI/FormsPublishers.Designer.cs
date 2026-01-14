namespace HiTechBooksManagement.GUI
{
    partial class FormsPublishers
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
            this.buttonViewAllPublishers = new System.Windows.Forms.Button();
            this.buttonClosePublisherPopUp = new System.Windows.Forms.Button();
            this.dataGridViewAllPublishers = new System.Windows.Forms.DataGridView();
            this.groupBoxPublisherDetails = new System.Windows.Forms.GroupBox();
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxState = new System.Windows.Forms.TextBox();
            this.labelState = new System.Windows.Forms.Label();
            this.labelCity = new System.Windows.Forms.Label();
            this.maskedTextBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPublisherFirstName = new System.Windows.Forms.TextBox();
            this.textboxPublisherID = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPublisherName = new System.Windows.Forms.Label();
            this.labelAuthorID = new System.Windows.Forms.Label();
            this.buttonSearchPublisher = new System.Windows.Forms.Button();
            this.bottonUpdatePublisher = new System.Windows.Forms.Button();
            this.buttonDeletePublisher = new System.Windows.Forms.Button();
            this.buttonAddPublisher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClearForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllPublishers)).BeginInit();
            this.groupBoxPublisherDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonViewAllPublishers
            // 
            this.buttonViewAllPublishers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewAllPublishers.Location = new System.Drawing.Point(25, 602);
            this.buttonViewAllPublishers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonViewAllPublishers.Name = "buttonViewAllPublishers";
            this.buttonViewAllPublishers.Size = new System.Drawing.Size(112, 31);
            this.buttonViewAllPublishers.TabIndex = 18;
            this.buttonViewAllPublishers.Text = "Show All";
            this.buttonViewAllPublishers.UseVisualStyleBackColor = true;
            this.buttonViewAllPublishers.Click += new System.EventHandler(this.buttonViewAllPublishers_Click);
            // 
            // buttonClosePublisherPopUp
            // 
            this.buttonClosePublisherPopUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClosePublisherPopUp.Location = new System.Drawing.Point(818, 602);
            this.buttonClosePublisherPopUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClosePublisherPopUp.Name = "buttonClosePublisherPopUp";
            this.buttonClosePublisherPopUp.Size = new System.Drawing.Size(112, 31);
            this.buttonClosePublisherPopUp.TabIndex = 17;
            this.buttonClosePublisherPopUp.Text = "Close";
            this.buttonClosePublisherPopUp.UseVisualStyleBackColor = true;
            this.buttonClosePublisherPopUp.Click += new System.EventHandler(this.buttonClosePublisherPopUp_Click_1);
            // 
            // dataGridViewAllPublishers
            // 
            this.dataGridViewAllPublishers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllPublishers.Location = new System.Drawing.Point(363, 38);
            this.dataGridViewAllPublishers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewAllPublishers.Name = "dataGridViewAllPublishers";
            this.dataGridViewAllPublishers.RowHeadersWidth = 62;
            this.dataGridViewAllPublishers.RowTemplate.Height = 28;
            this.dataGridViewAllPublishers.Size = new System.Drawing.Size(499, 425);
            this.dataGridViewAllPublishers.TabIndex = 16;
            this.dataGridViewAllPublishers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAllPublishers_CellContentClick);
            // 
            // groupBoxPublisherDetails
            // 
            this.groupBoxPublisherDetails.Controls.Add(this.comboBoxCities);
            this.groupBoxPublisherDetails.Controls.Add(this.textBoxAddress);
            this.groupBoxPublisherDetails.Controls.Add(this.labelAddress);
            this.groupBoxPublisherDetails.Controls.Add(this.dataGridViewAllPublishers);
            this.groupBoxPublisherDetails.Controls.Add(this.textBoxState);
            this.groupBoxPublisherDetails.Controls.Add(this.labelState);
            this.groupBoxPublisherDetails.Controls.Add(this.labelCity);
            this.groupBoxPublisherDetails.Controls.Add(this.maskedTextBoxPhoneNumber);
            this.groupBoxPublisherDetails.Controls.Add(this.textBoxEmail);
            this.groupBoxPublisherDetails.Controls.Add(this.textBoxPublisherFirstName);
            this.groupBoxPublisherDetails.Controls.Add(this.textboxPublisherID);
            this.groupBoxPublisherDetails.Controls.Add(this.labelPhone);
            this.groupBoxPublisherDetails.Controls.Add(this.labelEmail);
            this.groupBoxPublisherDetails.Controls.Add(this.labelLastName);
            this.groupBoxPublisherDetails.Controls.Add(this.labelPublisherName);
            this.groupBoxPublisherDetails.Controls.Add(this.labelAuthorID);
            this.groupBoxPublisherDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPublisherDetails.Location = new System.Drawing.Point(25, 58);
            this.groupBoxPublisherDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPublisherDetails.Name = "groupBoxPublisherDetails";
            this.groupBoxPublisherDetails.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPublisherDetails.Size = new System.Drawing.Size(905, 521);
            this.groupBoxPublisherDetails.TabIndex = 15;
            this.groupBoxPublisherDetails.TabStop = false;
            this.groupBoxPublisherDetails.Text = "Publisher Details";
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(32, 332);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(196, 28);
            this.comboBoxCities.TabIndex = 20;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(26, 472);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(202, 27);
            this.textBoxAddress.TabIndex = 19;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(24, 450);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(71, 20);
            this.labelAddress.TabIndex = 18;
            this.labelAddress.Text = "Address";
            // 
            // textBoxState
            // 
            this.textBoxState.Location = new System.Drawing.Point(30, 403);
            this.textBoxState.Name = "textBoxState";
            this.textBoxState.Size = new System.Drawing.Size(198, 27);
            this.textBoxState.TabIndex = 17;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Location = new System.Drawing.Point(28, 380);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(48, 20);
            this.labelState.TabIndex = 15;
            this.labelState.Text = "State";
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(26, 309);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(38, 20);
            this.labelCity.TabIndex = 14;
            this.labelCity.Text = "City";
            // 
            // maskedTextBoxPhoneNumber
            // 
            this.maskedTextBoxPhoneNumber.Location = new System.Drawing.Point(30, 260);
            this.maskedTextBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxPhoneNumber.Mask = "(999) 000-0000";
            this.maskedTextBoxPhoneNumber.Name = "maskedTextBoxPhoneNumber";
            this.maskedTextBoxPhoneNumber.Size = new System.Drawing.Size(198, 27);
            this.maskedTextBoxPhoneNumber.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(26, 190);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(202, 27);
            this.textBoxEmail.TabIndex = 7;
            // 
            // textBoxPublisherFirstName
            // 
            this.textBoxPublisherFirstName.Location = new System.Drawing.Point(26, 123);
            this.textBoxPublisherFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPublisherFirstName.Name = "textBoxPublisherFirstName";
            this.textBoxPublisherFirstName.Size = new System.Drawing.Size(202, 27);
            this.textBoxPublisherFirstName.TabIndex = 6;
            // 
            // textboxPublisherID
            // 
            this.textboxPublisherID.Location = new System.Drawing.Point(26, 56);
            this.textboxPublisherID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textboxPublisherID.Name = "textboxPublisherID";
            this.textboxPublisherID.Size = new System.Drawing.Size(85, 27);
            this.textboxPublisherID.TabIndex = 5;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(26, 238);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(56, 20);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "Phone";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(28, 168);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(51, 20);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Email";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(26, 101);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(53, 20);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Name";
            this.labelLastName.Click += new System.EventHandler(this.labelLastName_Click);
            // 
            // labelPublisherName
            // 
            this.labelPublisherName.AutoSize = true;
            this.labelPublisherName.Location = new System.Drawing.Point(23, 179);
            this.labelPublisherName.Name = "labelPublisherName";
            this.labelPublisherName.Size = new System.Drawing.Size(0, 20);
            this.labelPublisherName.TabIndex = 1;
            // 
            // labelAuthorID
            // 
            this.labelAuthorID.AutoSize = true;
            this.labelAuthorID.Location = new System.Drawing.Point(22, 34);
            this.labelAuthorID.Name = "labelAuthorID";
            this.labelAuthorID.Size = new System.Drawing.Size(26, 20);
            this.labelAuthorID.TabIndex = 0;
            this.labelAuthorID.Text = "ID";
            // 
            // buttonSearchPublisher
            // 
            this.buttonSearchPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearchPublisher.Location = new System.Drawing.Point(550, 602);
            this.buttonSearchPublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchPublisher.Name = "buttonSearchPublisher";
            this.buttonSearchPublisher.Size = new System.Drawing.Size(125, 31);
            this.buttonSearchPublisher.TabIndex = 13;
            this.buttonSearchPublisher.Text = "Search Publisher";
            this.buttonSearchPublisher.UseVisualStyleBackColor = true;
            this.buttonSearchPublisher.Click += new System.EventHandler(this.buttonSearchPublisher_Click);
            // 
            // bottonUpdatePublisher
            // 
            this.bottonUpdatePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottonUpdatePublisher.Location = new System.Drawing.Point(419, 602);
            this.bottonUpdatePublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bottonUpdatePublisher.Name = "bottonUpdatePublisher";
            this.bottonUpdatePublisher.Size = new System.Drawing.Size(125, 31);
            this.bottonUpdatePublisher.TabIndex = 12;
            this.bottonUpdatePublisher.Text = "Update Publisher";
            this.bottonUpdatePublisher.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePublisher
            // 
            this.buttonDeletePublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeletePublisher.Location = new System.Drawing.Point(288, 602);
            this.buttonDeletePublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeletePublisher.Name = "buttonDeletePublisher";
            this.buttonDeletePublisher.Size = new System.Drawing.Size(125, 31);
            this.buttonDeletePublisher.TabIndex = 11;
            this.buttonDeletePublisher.Text = "Delete Publisher";
            this.buttonDeletePublisher.UseVisualStyleBackColor = true;
            this.buttonDeletePublisher.Click += new System.EventHandler(this.buttonDeletePublisher_Click);
            // 
            // buttonAddPublisher
            // 
            this.buttonAddPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddPublisher.Location = new System.Drawing.Point(143, 602);
            this.buttonAddPublisher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPublisher.Name = "buttonAddPublisher";
            this.buttonAddPublisher.Size = new System.Drawing.Size(125, 31);
            this.buttonAddPublisher.TabIndex = 10;
            this.buttonAddPublisher.Text = "Add";
            this.buttonAddPublisher.UseVisualStyleBackColor = true;
            this.buttonAddPublisher.Click += new System.EventHandler(this.buttonAddPublisher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Publishers Management";
            // 
            // buttonClearForm
            // 
            this.buttonClearForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearForm.Location = new System.Drawing.Point(812, 23);
            this.buttonClearForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClearForm.Name = "buttonClearForm";
            this.buttonClearForm.Size = new System.Drawing.Size(112, 31);
            this.buttonClearForm.TabIndex = 19;
            this.buttonClearForm.Text = "Clear";
            this.buttonClearForm.UseVisualStyleBackColor = true;
            // 
            // FormsPublishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(949, 655);
            this.Controls.Add(this.buttonClearForm);
            this.Controls.Add(this.buttonViewAllPublishers);
            this.Controls.Add(this.buttonClosePublisherPopUp);
            this.Controls.Add(this.groupBoxPublisherDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearchPublisher);
            this.Controls.Add(this.buttonAddPublisher);
            this.Controls.Add(this.bottonUpdatePublisher);
            this.Controls.Add(this.buttonDeletePublisher);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormsPublishers";
            this.Text = "Publishers";
            this.Load += new System.EventHandler(this.FormsPublishers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllPublishers)).EndInit();
            this.groupBoxPublisherDetails.ResumeLayout(false);
            this.groupBoxPublisherDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonViewAllPublishers;
        private System.Windows.Forms.Button buttonClosePublisherPopUp;
        private System.Windows.Forms.DataGridView dataGridViewAllPublishers;
        private System.Windows.Forms.GroupBox groupBoxPublisherDetails;
        private System.Windows.Forms.Button buttonSearchPublisher;
        private System.Windows.Forms.Button bottonUpdatePublisher;
        private System.Windows.Forms.Button buttonDeletePublisher;
        private System.Windows.Forms.Button buttonAddPublisher;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPublisherFirstName;
        private System.Windows.Forms.TextBox textboxPublisherID;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPublisherName;
        private System.Windows.Forms.Label labelAuthorID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxState;
        private System.Windows.Forms.Label labelState;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Button buttonClearForm;
        private System.Windows.Forms.ComboBox comboBoxCities;
    }
}