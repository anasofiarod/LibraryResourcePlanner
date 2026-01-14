namespace HiTechBooksManagement.GUI
{
    partial class UserEmployeeMaintenance
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.labelEmployeeM = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.dataGridViewListAllE = new System.Windows.Forms.DataGridView();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.buttonSearchEmployee = new System.Windows.Forms.Button();
            this.buttonListAllEmployees = new System.Windows.Forms.Button();
            this.groupBoxPersonalInformation = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEEmail = new System.Windows.Forms.TextBox();
            this.textBoxELastName = new System.Windows.Forms.TextBox();
            this.textBoxEFirstName = new System.Windows.Forms.TextBox();
            this.labelEPhone = new System.Windows.Forms.Label();
            this.labelEEmail = new System.Windows.Forms.Label();
            this.labelELastName = new System.Windows.Forms.Label();
            this.labelEFirstName = new System.Windows.Forms.Label();
            this.groupBoxJobInformation = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxEStatus = new System.Windows.Forms.ComboBox();
            this.textBoxEJobName = new System.Windows.Forms.TextBox();
            this.textBoxEEmployeeID = new System.Windows.Forms.TextBox();
            this.textBoxERoleID = new System.Windows.Forms.TextBox();
            this.labelEStatus = new System.Windows.Forms.Label();
            this.labelEHireDate = new System.Windows.Forms.Label();
            this.labelERoleID = new System.Windows.Forms.Label();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.labelETitle = new System.Windows.Forms.Label();
            this.tabPageUser = new System.Windows.Forms.TabPage();
            this.labelUserM = new System.Windows.Forms.Label();
            this.buttonClearUsers = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxUFirstName = new System.Windows.Forms.TextBox();
            this.textBoxULastName = new System.Windows.Forms.TextBox();
            this.labelULastName = new System.Windows.Forms.Label();
            this.labelUFirstName = new System.Windows.Forms.Label();
            this.buttonUAdd = new System.Windows.Forms.Button();
            this.dataGridViewUListAll = new System.Windows.Forms.DataGridView();
            this.buttonUDelete = new System.Windows.Forms.Button();
            this.buttonUUpdate = new System.Windows.Forms.Button();
            this.buttonUSearch = new System.Windows.Forms.Button();
            this.buttonUListAll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxUserIsActive = new System.Windows.Forms.CheckBox();
            this.textBoxURoleID = new System.Windows.Forms.TextBox();
            this.textBoxUEmployeeID = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelURoleID = new System.Windows.Forms.Label();
            this.labelUEmployeeID = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAllE)).BeginInit();
            this.groupBoxPersonalInformation.SuspendLayout();
            this.groupBoxJobInformation.SuspendLayout();
            this.tabPageUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUListAll)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEmployee);
            this.tabControl1.Controls.Add(this.tabPageUser);
            this.tabControl1.Location = new System.Drawing.Point(8, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 832);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.labelEmployeeM);
            this.tabPageEmployee.Controls.Add(this.buttonClose);
            this.tabPageEmployee.Controls.Add(this.buttonClear);
            this.tabPageEmployee.Controls.Add(this.buttonAddEmployee);
            this.tabPageEmployee.Controls.Add(this.dataGridViewListAllE);
            this.tabPageEmployee.Controls.Add(this.buttonDeleteEmployee);
            this.tabPageEmployee.Controls.Add(this.buttonUpdateEmployee);
            this.tabPageEmployee.Controls.Add(this.buttonSearchEmployee);
            this.tabPageEmployee.Controls.Add(this.buttonListAllEmployees);
            this.tabPageEmployee.Controls.Add(this.groupBoxPersonalInformation);
            this.tabPageEmployee.Controls.Add(this.groupBoxJobInformation);
            this.tabPageEmployee.Font = new System.Drawing.Font("Segoe UI Symbol", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 26);
            this.tabPageEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageEmployee.Size = new System.Drawing.Size(638, 802);
            this.tabPageEmployee.TabIndex = 0;
            this.tabPageEmployee.Text = "Employee";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            this.tabPageEmployee.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // labelEmployeeM
            // 
            this.labelEmployeeM.AutoSize = true;
            this.labelEmployeeM.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeM.ForeColor = System.Drawing.Color.DarkRed;
            this.labelEmployeeM.Location = new System.Drawing.Point(26, 19);
            this.labelEmployeeM.Name = "labelEmployeeM";
            this.labelEmployeeM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelEmployeeM.Size = new System.Drawing.Size(329, 38);
            this.labelEmployeeM.TabIndex = 19;
            this.labelEmployeeM.Text = "Employee Management";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(401, 79);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(83, 33);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(484, 79);
            this.buttonAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(82, 33);
            this.buttonAddEmployee.TabIndex = 7;
            this.buttonAddEmployee.Text = "Add";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            this.buttonAddEmployee.Click += new System.EventHandler(this.buttonAddEmployee_Click);
            // 
            // dataGridViewListAllE
            // 
            this.dataGridViewListAllE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListAllE.Location = new System.Drawing.Point(23, 642);
            this.dataGridViewListAllE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListAllE.Name = "dataGridViewListAllE";
            this.dataGridViewListAllE.RowHeadersWidth = 62;
            this.dataGridViewListAllE.RowTemplate.Height = 28;
            this.dataGridViewListAllE.Size = new System.Drawing.Size(543, 143);
            this.dataGridViewListAllE.TabIndex = 6;
            this.dataGridViewListAllE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewListAllE_CellContentClick);
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(220, 79);
            this.buttonDeleteEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(82, 33);
            this.buttonDeleteEmployee.TabIndex = 5;
            this.buttonDeleteEmployee.Text = "Delete";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            this.buttonDeleteEmployee.Click += new System.EventHandler(this.buttonDeleteEmployee_Click);
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(127, 79);
            this.buttonUpdateEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(82, 33);
            this.buttonUpdateEmployee.TabIndex = 4;
            this.buttonUpdateEmployee.Text = "Update";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = true;
            this.buttonUpdateEmployee.Click += new System.EventHandler(this.buttonUpdateEmployee_Click);
            // 
            // buttonSearchEmployee
            // 
            this.buttonSearchEmployee.Location = new System.Drawing.Point(313, 79);
            this.buttonSearchEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSearchEmployee.Name = "buttonSearchEmployee";
            this.buttonSearchEmployee.Size = new System.Drawing.Size(82, 33);
            this.buttonSearchEmployee.TabIndex = 3;
            this.buttonSearchEmployee.Text = "Search";
            this.buttonSearchEmployee.UseVisualStyleBackColor = true;
            this.buttonSearchEmployee.Click += new System.EventHandler(this.buttonSearchEmployee_Click);
            // 
            // buttonListAllEmployees
            // 
            this.buttonListAllEmployees.Location = new System.Drawing.Point(33, 79);
            this.buttonListAllEmployees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonListAllEmployees.Name = "buttonListAllEmployees";
            this.buttonListAllEmployees.Size = new System.Drawing.Size(82, 33);
            this.buttonListAllEmployees.TabIndex = 2;
            this.buttonListAllEmployees.Text = "List All";
            this.buttonListAllEmployees.UseVisualStyleBackColor = true;
            this.buttonListAllEmployees.Click += new System.EventHandler(this.buttonListAllEmployees_Click);
            // 
            // groupBoxPersonalInformation
            // 
            this.groupBoxPersonalInformation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxPersonalInformation.Controls.Add(this.maskedTextBoxPhone);
            this.groupBoxPersonalInformation.Controls.Add(this.textBoxEEmail);
            this.groupBoxPersonalInformation.Controls.Add(this.textBoxELastName);
            this.groupBoxPersonalInformation.Controls.Add(this.textBoxEFirstName);
            this.groupBoxPersonalInformation.Controls.Add(this.labelEPhone);
            this.groupBoxPersonalInformation.Controls.Add(this.labelEEmail);
            this.groupBoxPersonalInformation.Controls.Add(this.labelELastName);
            this.groupBoxPersonalInformation.Controls.Add(this.labelEFirstName);
            this.groupBoxPersonalInformation.Location = new System.Drawing.Point(23, 128);
            this.groupBoxPersonalInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPersonalInformation.Name = "groupBoxPersonalInformation";
            this.groupBoxPersonalInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPersonalInformation.Size = new System.Drawing.Size(543, 180);
            this.groupBoxPersonalInformation.TabIndex = 1;
            this.groupBoxPersonalInformation.TabStop = false;
            this.groupBoxPersonalInformation.Text = "Personal Information";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(22, 135);
            this.maskedTextBoxPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(93, 25);
            this.maskedTextBoxPhone.TabIndex = 13;
            // 
            // textBoxEEmail
            // 
            this.textBoxEEmail.Location = new System.Drawing.Point(22, 82);
            this.textBoxEEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEEmail.Name = "textBoxEEmail";
            this.textBoxEEmail.Size = new System.Drawing.Size(98, 25);
            this.textBoxEEmail.TabIndex = 12;
            // 
            // textBoxELastName
            // 
            this.textBoxELastName.Location = new System.Drawing.Point(221, 39);
            this.textBoxELastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxELastName.Name = "textBoxELastName";
            this.textBoxELastName.Size = new System.Drawing.Size(98, 25);
            this.textBoxELastName.TabIndex = 11;
            // 
            // textBoxEFirstName
            // 
            this.textBoxEFirstName.Location = new System.Drawing.Point(22, 39);
            this.textBoxEFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEFirstName.Name = "textBoxEFirstName";
            this.textBoxEFirstName.Size = new System.Drawing.Size(98, 25);
            this.textBoxEFirstName.TabIndex = 10;
            // 
            // labelEPhone
            // 
            this.labelEPhone.AutoSize = true;
            this.labelEPhone.Location = new System.Drawing.Point(24, 116);
            this.labelEPhone.Name = "labelEPhone";
            this.labelEPhone.Size = new System.Drawing.Size(89, 17);
            this.labelEPhone.TabIndex = 3;
            this.labelEPhone.Text = "Mobile Phone";
            // 
            // labelEEmail
            // 
            this.labelEEmail.AutoSize = true;
            this.labelEEmail.Location = new System.Drawing.Point(19, 66);
            this.labelEEmail.Name = "labelEEmail";
            this.labelEEmail.Size = new System.Drawing.Size(39, 17);
            this.labelEEmail.TabIndex = 2;
            this.labelEEmail.Text = "Email";
            // 
            // labelELastName
            // 
            this.labelELastName.AutoSize = true;
            this.labelELastName.Location = new System.Drawing.Point(221, 20);
            this.labelELastName.Name = "labelELastName";
            this.labelELastName.Size = new System.Drawing.Size(70, 17);
            this.labelELastName.TabIndex = 1;
            this.labelELastName.Text = "Last Name";
            // 
            // labelEFirstName
            // 
            this.labelEFirstName.AutoSize = true;
            this.labelEFirstName.Location = new System.Drawing.Point(19, 20);
            this.labelEFirstName.Name = "labelEFirstName";
            this.labelEFirstName.Size = new System.Drawing.Size(71, 17);
            this.labelEFirstName.TabIndex = 0;
            this.labelEFirstName.Text = "First Name";
            // 
            // groupBoxJobInformation
            // 
            this.groupBoxJobInformation.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxJobInformation.Controls.Add(this.maskedTextBoxDate);
            this.groupBoxJobInformation.Controls.Add(this.comboBoxEStatus);
            this.groupBoxJobInformation.Controls.Add(this.textBoxEJobName);
            this.groupBoxJobInformation.Controls.Add(this.textBoxEEmployeeID);
            this.groupBoxJobInformation.Controls.Add(this.textBoxERoleID);
            this.groupBoxJobInformation.Controls.Add(this.labelEStatus);
            this.groupBoxJobInformation.Controls.Add(this.labelEHireDate);
            this.groupBoxJobInformation.Controls.Add(this.labelERoleID);
            this.groupBoxJobInformation.Controls.Add(this.labelEmployeeID);
            this.groupBoxJobInformation.Controls.Add(this.labelETitle);
            this.groupBoxJobInformation.Location = new System.Drawing.Point(23, 312);
            this.groupBoxJobInformation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxJobInformation.Name = "groupBoxJobInformation";
            this.groupBoxJobInformation.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxJobInformation.Size = new System.Drawing.Size(543, 326);
            this.groupBoxJobInformation.TabIndex = 0;
            this.groupBoxJobInformation.TabStop = false;
            this.groupBoxJobInformation.Text = "Job Information";
            // 
            // maskedTextBoxDate
            // 
            this.maskedTextBoxDate.Location = new System.Drawing.Point(17, 224);
            this.maskedTextBoxDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maskedTextBoxDate.Mask = "0000/00/00";
            this.maskedTextBoxDate.Name = "maskedTextBoxDate";
            this.maskedTextBoxDate.Size = new System.Drawing.Size(98, 25);
            this.maskedTextBoxDate.TabIndex = 11;
            this.maskedTextBoxDate.ValidatingType = typeof(System.DateTime);
            // 
            // comboBoxEStatus
            // 
            this.comboBoxEStatus.FormattingEnabled = true;
            this.comboBoxEStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.comboBoxEStatus.Location = new System.Drawing.Point(16, 280);
            this.comboBoxEStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEStatus.Name = "comboBoxEStatus";
            this.comboBoxEStatus.Size = new System.Drawing.Size(117, 25);
            this.comboBoxEStatus.TabIndex = 10;
            this.comboBoxEStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxEStatus_SelectedIndexChanged);
            // 
            // textBoxEJobName
            // 
            this.textBoxEJobName.Location = new System.Drawing.Point(17, 50);
            this.textBoxEJobName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEJobName.Name = "textBoxEJobName";
            this.textBoxEJobName.Size = new System.Drawing.Size(98, 25);
            this.textBoxEJobName.TabIndex = 9;
            // 
            // textBoxEEmployeeID
            // 
            this.textBoxEEmployeeID.Location = new System.Drawing.Point(16, 111);
            this.textBoxEEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEEmployeeID.Name = "textBoxEEmployeeID";
            this.textBoxEEmployeeID.Size = new System.Drawing.Size(98, 25);
            this.textBoxEEmployeeID.TabIndex = 8;
            // 
            // textBoxERoleID
            // 
            this.textBoxERoleID.Location = new System.Drawing.Point(15, 167);
            this.textBoxERoleID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxERoleID.Name = "textBoxERoleID";
            this.textBoxERoleID.Size = new System.Drawing.Size(98, 25);
            this.textBoxERoleID.TabIndex = 7;
            this.textBoxERoleID.TextChanged += new System.EventHandler(this.textBoxERoleID_TextChanged);
            // 
            // labelEStatus
            // 
            this.labelEStatus.AutoSize = true;
            this.labelEStatus.Location = new System.Drawing.Point(14, 261);
            this.labelEStatus.Name = "labelEStatus";
            this.labelEStatus.Size = new System.Drawing.Size(46, 17);
            this.labelEStatus.TabIndex = 5;
            this.labelEStatus.Text = "Status:";
            // 
            // labelEHireDate
            // 
            this.labelEHireDate.AutoSize = true;
            this.labelEHireDate.Location = new System.Drawing.Point(14, 205);
            this.labelEHireDate.Name = "labelEHireDate";
            this.labelEHireDate.Size = new System.Drawing.Size(70, 17);
            this.labelEHireDate.TabIndex = 4;
            this.labelEHireDate.Text = "Hire Date: ";
            // 
            // labelERoleID
            // 
            this.labelERoleID.AutoSize = true;
            this.labelERoleID.Location = new System.Drawing.Point(14, 148);
            this.labelERoleID.Name = "labelERoleID";
            this.labelERoleID.Size = new System.Drawing.Size(57, 17);
            this.labelERoleID.TabIndex = 3;
            this.labelERoleID.Text = "Role ID: ";
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Location = new System.Drawing.Point(14, 92);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(88, 17);
            this.labelEmployeeID.TabIndex = 2;
            this.labelEmployeeID.Text = "Employee ID: ";
            // 
            // labelETitle
            // 
            this.labelETitle.AutoSize = true;
            this.labelETitle.Location = new System.Drawing.Point(13, 31);
            this.labelETitle.Name = "labelETitle";
            this.labelETitle.Size = new System.Drawing.Size(39, 17);
            this.labelETitle.TabIndex = 1;
            this.labelETitle.Text = "Title: ";
            // 
            // tabPageUser
            // 
            this.tabPageUser.Controls.Add(this.labelUserM);
            this.tabPageUser.Controls.Add(this.buttonClearUsers);
            this.tabPageUser.Controls.Add(this.groupBox1);
            this.tabPageUser.Controls.Add(this.buttonUAdd);
            this.tabPageUser.Controls.Add(this.dataGridViewUListAll);
            this.tabPageUser.Controls.Add(this.buttonUDelete);
            this.tabPageUser.Controls.Add(this.buttonUUpdate);
            this.tabPageUser.Controls.Add(this.buttonUSearch);
            this.tabPageUser.Controls.Add(this.buttonUListAll);
            this.tabPageUser.Controls.Add(this.groupBox2);
            this.tabPageUser.Location = new System.Drawing.Point(4, 26);
            this.tabPageUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageUser.Name = "tabPageUser";
            this.tabPageUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageUser.Size = new System.Drawing.Size(638, 802);
            this.tabPageUser.TabIndex = 1;
            this.tabPageUser.Text = "User";
            this.tabPageUser.UseVisualStyleBackColor = true;
            this.tabPageUser.Click += new System.EventHandler(this.tabPageUser_Click);
            // 
            // labelUserM
            // 
            this.labelUserM.AutoSize = true;
            this.labelUserM.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserM.ForeColor = System.Drawing.Color.DarkRed;
            this.labelUserM.Location = new System.Drawing.Point(14, 13);
            this.labelUserM.Name = "labelUserM";
            this.labelUserM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelUserM.Size = new System.Drawing.Size(260, 38);
            this.labelUserM.TabIndex = 18;
            this.labelUserM.Text = "User Management";
            // 
            // buttonClearUsers
            // 
            this.buttonClearUsers.Location = new System.Drawing.Point(410, 66);
            this.buttonClearUsers.Name = "buttonClearUsers";
            this.buttonClearUsers.Size = new System.Drawing.Size(75, 33);
            this.buttonClearUsers.TabIndex = 17;
            this.buttonClearUsers.Text = "Clear";
            this.buttonClearUsers.UseVisualStyleBackColor = true;
            this.buttonClearUsers.Click += new System.EventHandler(this.buttonClearUsers_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.textBoxUFirstName);
            this.groupBox1.Controls.Add(this.textBoxULastName);
            this.groupBox1.Controls.Add(this.labelULastName);
            this.groupBox1.Controls.Add(this.labelUFirstName);
            this.groupBox1.Location = new System.Drawing.Point(21, 104);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(556, 139);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Personal Information";
            // 
            // textBoxUFirstName
            // 
            this.textBoxUFirstName.Location = new System.Drawing.Point(18, 39);
            this.textBoxUFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUFirstName.Name = "textBoxUFirstName";
            this.textBoxUFirstName.Size = new System.Drawing.Size(98, 25);
            this.textBoxUFirstName.TabIndex = 9;
            // 
            // textBoxULastName
            // 
            this.textBoxULastName.Location = new System.Drawing.Point(18, 82);
            this.textBoxULastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxULastName.Name = "textBoxULastName";
            this.textBoxULastName.Size = new System.Drawing.Size(98, 25);
            this.textBoxULastName.TabIndex = 8;
            // 
            // labelULastName
            // 
            this.labelULastName.AutoSize = true;
            this.labelULastName.Location = new System.Drawing.Point(15, 63);
            this.labelULastName.Name = "labelULastName";
            this.labelULastName.Size = new System.Drawing.Size(77, 17);
            this.labelULastName.TabIndex = 2;
            this.labelULastName.Text = "Last Name: ";
            // 
            // labelUFirstName
            // 
            this.labelUFirstName.AutoSize = true;
            this.labelUFirstName.Location = new System.Drawing.Point(15, 20);
            this.labelUFirstName.Name = "labelUFirstName";
            this.labelUFirstName.Size = new System.Drawing.Size(78, 17);
            this.labelUFirstName.TabIndex = 1;
            this.labelUFirstName.Text = "First Name: ";
            // 
            // buttonUAdd
            // 
            this.buttonUAdd.Location = new System.Drawing.Point(495, 66);
            this.buttonUAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUAdd.Name = "buttonUAdd";
            this.buttonUAdd.Size = new System.Drawing.Size(82, 33);
            this.buttonUAdd.TabIndex = 15;
            this.buttonUAdd.Text = "Add";
            this.buttonUAdd.UseVisualStyleBackColor = true;
            this.buttonUAdd.Click += new System.EventHandler(this.buttonUAdd_Click);
            // 
            // dataGridViewUListAll
            // 
            this.dataGridViewUListAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUListAll.Location = new System.Drawing.Point(21, 567);
            this.dataGridViewUListAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUListAll.Name = "dataGridViewUListAll";
            this.dataGridViewUListAll.RowHeadersWidth = 62;
            this.dataGridViewUListAll.RowTemplate.Height = 28;
            this.dataGridViewUListAll.Size = new System.Drawing.Size(556, 205);
            this.dataGridViewUListAll.TabIndex = 14;
            // 
            // buttonUDelete
            // 
            this.buttonUDelete.Location = new System.Drawing.Point(228, 66);
            this.buttonUDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUDelete.Name = "buttonUDelete";
            this.buttonUDelete.Size = new System.Drawing.Size(82, 33);
            this.buttonUDelete.TabIndex = 13;
            this.buttonUDelete.Text = "Delete";
            this.buttonUDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUUpdate
            // 
            this.buttonUUpdate.Location = new System.Drawing.Point(135, 66);
            this.buttonUUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUUpdate.Name = "buttonUUpdate";
            this.buttonUUpdate.Size = new System.Drawing.Size(82, 33);
            this.buttonUUpdate.TabIndex = 12;
            this.buttonUUpdate.Text = "Update";
            this.buttonUUpdate.UseVisualStyleBackColor = true;
            this.buttonUUpdate.Click += new System.EventHandler(this.buttonUUpdate_Click);
            // 
            // buttonUSearch
            // 
            this.buttonUSearch.Location = new System.Drawing.Point(322, 66);
            this.buttonUSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUSearch.Name = "buttonUSearch";
            this.buttonUSearch.Size = new System.Drawing.Size(82, 33);
            this.buttonUSearch.TabIndex = 11;
            this.buttonUSearch.Text = "Search";
            this.buttonUSearch.UseVisualStyleBackColor = true;
            this.buttonUSearch.Click += new System.EventHandler(this.buttonUSearch_Click);
            // 
            // buttonUListAll
            // 
            this.buttonUListAll.Location = new System.Drawing.Point(42, 66);
            this.buttonUListAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUListAll.Name = "buttonUListAll";
            this.buttonUListAll.Size = new System.Drawing.Size(82, 33);
            this.buttonUListAll.TabIndex = 10;
            this.buttonUListAll.Text = "List All";
            this.buttonUListAll.UseVisualStyleBackColor = true;
            this.buttonUListAll.Click += new System.EventHandler(this.buttonUListAll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.checkBoxUserIsActive);
            this.groupBox2.Controls.Add(this.textBoxURoleID);
            this.groupBox2.Controls.Add(this.textBoxUEmployeeID);
            this.groupBox2.Controls.Add(this.textBoxUserID);
            this.groupBox2.Controls.Add(this.textBoxUsername);
            this.groupBox2.Controls.Add(this.textBoxPassword);
            this.groupBox2.Controls.Add(this.labelURoleID);
            this.groupBox2.Controls.Add(this.labelUEmployeeID);
            this.groupBox2.Controls.Add(this.labelPassword);
            this.groupBox2.Controls.Add(this.labelUsername);
            this.groupBox2.Controls.Add(this.labelUserID);
            this.groupBox2.Location = new System.Drawing.Point(21, 247);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(556, 305);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Information";
            // 
            // checkBoxUserIsActive
            // 
            this.checkBoxUserIsActive.AutoSize = true;
            this.checkBoxUserIsActive.Location = new System.Drawing.Point(200, 54);
            this.checkBoxUserIsActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBoxUserIsActive.Name = "checkBoxUserIsActive";
            this.checkBoxUserIsActive.Size = new System.Drawing.Size(77, 21);
            this.checkBoxUserIsActive.TabIndex = 12;
            this.checkBoxUserIsActive.Text = "Is Active";
            this.checkBoxUserIsActive.UseVisualStyleBackColor = true;
            // 
            // textBoxURoleID
            // 
            this.textBoxURoleID.Location = new System.Drawing.Point(24, 269);
            this.textBoxURoleID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxURoleID.Name = "textBoxURoleID";
            this.textBoxURoleID.Size = new System.Drawing.Size(98, 25);
            this.textBoxURoleID.TabIndex = 11;
            // 
            // textBoxUEmployeeID
            // 
            this.textBoxUEmployeeID.Location = new System.Drawing.Point(24, 210);
            this.textBoxUEmployeeID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUEmployeeID.Name = "textBoxUEmployeeID";
            this.textBoxUEmployeeID.Size = new System.Drawing.Size(98, 25);
            this.textBoxUEmployeeID.TabIndex = 10;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(24, 50);
            this.textBoxUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(98, 25);
            this.textBoxUserID.TabIndex = 9;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(24, 101);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(98, 25);
            this.textBoxUsername.TabIndex = 8;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(24, 156);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(98, 25);
            this.textBoxPassword.TabIndex = 7;
            // 
            // labelURoleID
            // 
            this.labelURoleID.AutoSize = true;
            this.labelURoleID.Location = new System.Drawing.Point(21, 250);
            this.labelURoleID.Name = "labelURoleID";
            this.labelURoleID.Size = new System.Drawing.Size(57, 17);
            this.labelURoleID.TabIndex = 5;
            this.labelURoleID.Text = "Role ID: ";
            // 
            // labelUEmployeeID
            // 
            this.labelUEmployeeID.AutoSize = true;
            this.labelUEmployeeID.Location = new System.Drawing.Point(21, 184);
            this.labelUEmployeeID.Name = "labelUEmployeeID";
            this.labelUEmployeeID.Size = new System.Drawing.Size(88, 17);
            this.labelUEmployeeID.TabIndex = 4;
            this.labelUEmployeeID.Text = "Employee ID: ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(21, 137);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(21, 82);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(74, 17);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username: ";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(21, 31);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(58, 17);
            this.labelUserID.TabIndex = 1;
            this.labelUserID.Text = "User ID: ";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(549, 19);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(83, 43);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // UserEmployeeMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(674, 900);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserEmployeeMaintenance";
            this.Text = "User - Employee Maintenance";
            this.Load += new System.EventHandler(this.UserEmployeeMaintenance_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEmployee.ResumeLayout(false);
            this.tabPageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListAllE)).EndInit();
            this.groupBoxPersonalInformation.ResumeLayout(false);
            this.groupBoxPersonalInformation.PerformLayout();
            this.groupBoxJobInformation.ResumeLayout(false);
            this.groupBoxJobInformation.PerformLayout();
            this.tabPageUser.ResumeLayout(false);
            this.tabPageUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUListAll)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageUser;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonUAdd;
        private System.Windows.Forms.DataGridView dataGridViewUListAll;
        private System.Windows.Forms.Button buttonUDelete;
        private System.Windows.Forms.Button buttonUUpdate;
        private System.Windows.Forms.Button buttonUSearch;
        private System.Windows.Forms.Button buttonUListAll;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelURoleID;
        private System.Windows.Forms.Label labelUEmployeeID;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxUFirstName;
        private System.Windows.Forms.TextBox textBoxULastName;
        private System.Windows.Forms.Label labelULastName;
        private System.Windows.Forms.Label labelUFirstName;
        private System.Windows.Forms.TextBox textBoxURoleID;
        private System.Windows.Forms.TextBox textBoxUEmployeeID;
        private System.Windows.Forms.CheckBox checkBoxUserIsActive;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TabPage tabPageEmployee;
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.DataGridView dataGridViewListAllE;
        private System.Windows.Forms.Button buttonDeleteEmployee;
        private System.Windows.Forms.Button buttonUpdateEmployee;
        private System.Windows.Forms.Button buttonSearchEmployee;
        private System.Windows.Forms.Button buttonListAllEmployees;
        private System.Windows.Forms.GroupBox groupBoxPersonalInformation;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.TextBox textBoxEEmail;
        private System.Windows.Forms.TextBox textBoxELastName;
        private System.Windows.Forms.TextBox textBoxEFirstName;
        private System.Windows.Forms.Label labelEPhone;
        private System.Windows.Forms.Label labelEEmail;
        private System.Windows.Forms.Label labelELastName;
        private System.Windows.Forms.Label labelEFirstName;
        private System.Windows.Forms.GroupBox groupBoxJobInformation;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDate;
        private System.Windows.Forms.ComboBox comboBoxEStatus;
        private System.Windows.Forms.TextBox textBoxEJobName;
        private System.Windows.Forms.TextBox textBoxEEmployeeID;
        private System.Windows.Forms.TextBox textBoxERoleID;
        private System.Windows.Forms.Label labelEStatus;
        private System.Windows.Forms.Label labelEHireDate;
        private System.Windows.Forms.Label labelERoleID;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.Label labelETitle;
        private System.Windows.Forms.Button buttonClearUsers;
        private System.Windows.Forms.Label labelUserM;
        private System.Windows.Forms.Label labelEmployeeM;
    }
}