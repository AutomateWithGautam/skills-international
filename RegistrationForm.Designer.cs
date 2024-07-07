namespace SkillsInternationalSchool
{
    partial class RegistrationForm
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

        private void InitializeComponent()
        {
            this.groupBoxStudentRegistration = new System.Windows.Forms.GroupBox();
            this.groupBoxBasicDetails = new System.Windows.Forms.GroupBox();
            this.labelRegNo = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.labelGender = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxContactDetails = new System.Windows.Forms.GroupBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.labelHomePhone = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.labelMobilePhone = new System.Windows.Forms.Label();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.groupBoxParentDetails = new System.Windows.Forms.GroupBox();
            this.labelParentName = new System.Windows.Forms.Label();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.labelNIC = new System.Windows.Forms.Label();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.labelContactNo = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.comboBoxRegNo = new System.Windows.Forms.ComboBox();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.linkExit = new System.Windows.Forms.LinkLabel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupBoxStudentRegistration.SuspendLayout();
            this.groupBoxBasicDetails.SuspendLayout();
            this.groupBoxContactDetails.SuspendLayout();
            this.groupBoxParentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxStudentRegistration
            // 
            this.groupBoxStudentRegistration.Controls.Add(this.comboBoxRegNo);
            this.groupBoxStudentRegistration.Controls.Add(this.groupBoxBasicDetails);
            this.groupBoxStudentRegistration.Controls.Add(this.groupBoxContactDetails);
            this.groupBoxStudentRegistration.Controls.Add(this.groupBoxParentDetails);
            this.groupBoxStudentRegistration.Location = new System.Drawing.Point(24, 66);
            this.groupBoxStudentRegistration.Name = "groupBoxStudentRegistration";
            this.groupBoxStudentRegistration.Size = new System.Drawing.Size(560, 400);
            this.groupBoxStudentRegistration.TabIndex = 0;
            this.groupBoxStudentRegistration.TabStop = false;
            this.groupBoxStudentRegistration.Text = "Student Registration";
            // 
            // groupBoxBasicDetails
            // 
            this.groupBoxBasicDetails.Controls.Add(this.labelRegNo);
            this.groupBoxBasicDetails.Controls.Add(this.txtRegNo);
            this.groupBoxBasicDetails.Controls.Add(this.labelLastName);
            this.groupBoxBasicDetails.Controls.Add(this.txtLastName);
            this.groupBoxBasicDetails.Controls.Add(this.labelFirstName);
            this.groupBoxBasicDetails.Controls.Add(this.txtFirstName);
            this.groupBoxBasicDetails.Controls.Add(this.labelDateOfBirth);
            this.groupBoxBasicDetails.Controls.Add(this.dtpDateOfBirth);
            this.groupBoxBasicDetails.Controls.Add(this.labelGender);
            this.groupBoxBasicDetails.Controls.Add(this.rbtnMale);
            this.groupBoxBasicDetails.Controls.Add(this.rbtnFemale);
            this.groupBoxBasicDetails.Location = new System.Drawing.Point(17, 39);
            this.groupBoxBasicDetails.Name = "groupBoxBasicDetails";
            this.groupBoxBasicDetails.Size = new System.Drawing.Size(525, 130);
            this.groupBoxBasicDetails.TabIndex = 0;
            this.groupBoxBasicDetails.TabStop = false;
            this.groupBoxBasicDetails.Text = "Basic Details";
            // 
            // labelRegNo
            // 
            this.labelRegNo.AutoSize = true;
            this.labelRegNo.Location = new System.Drawing.Point(7, 23);
            this.labelRegNo.Name = "labelRegNo";
            this.labelRegNo.Size = new System.Drawing.Size(53, 13);
            this.labelRegNo.TabIndex = 0;
            this.labelRegNo.Text = "Reg. No.:";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Location = new System.Drawing.Point(71, 20);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(186, 20);
            this.txtRegNo.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(7, 75);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(61, 13);
            this.labelLastName.TabIndex = 1;
            this.labelLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(71, 72);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(186, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(7, 49);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(71, 46);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(186, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(270, 49);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.labelDateOfBirth.TabIndex = 9;
            this.labelDateOfBirth.Text = "Date of Birth:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(344, 46);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(150, 20);
            this.dtpDateOfBirth.TabIndex = 8;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(270, 75);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(45, 13);
            this.labelGender.TabIndex = 12;
            this.labelGender.Text = "Gender:";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(344, 73);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 11;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(398, 73);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 10;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // groupBoxContactDetails
            // 
            this.groupBoxContactDetails.Controls.Add(this.labelAddress);
            this.groupBoxContactDetails.Controls.Add(this.txtAddress);
            this.groupBoxContactDetails.Controls.Add(this.labelEmail);
            this.groupBoxContactDetails.Controls.Add(this.txtEmail);
            this.groupBoxContactDetails.Controls.Add(this.labelHomePhone);
            this.groupBoxContactDetails.Controls.Add(this.txtHomePhone);
            this.groupBoxContactDetails.Controls.Add(this.labelMobilePhone);
            this.groupBoxContactDetails.Controls.Add(this.txtMobilePhone);
            this.groupBoxContactDetails.Location = new System.Drawing.Point(16, 170);
            this.groupBoxContactDetails.Name = "groupBoxContactDetails";
            this.groupBoxContactDetails.Size = new System.Drawing.Size(525, 130);
            this.groupBoxContactDetails.TabIndex = 1;
            this.groupBoxContactDetails.TabStop = false;
            this.groupBoxContactDetails.Text = "Contact Details";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(7, 23);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(71, 20);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(186, 40);
            this.txtAddress.TabIndex = 1;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(270, 23);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(344, 20);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // labelHomePhone
            // 
            this.labelHomePhone.AutoSize = true;
            this.labelHomePhone.Location = new System.Drawing.Point(7, 75);
            this.labelHomePhone.Name = "labelHomePhone";
            this.labelHomePhone.Size = new System.Drawing.Size(74, 13);
            this.labelHomePhone.TabIndex = 4;
            this.labelHomePhone.Text = "Home Phone:";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(99, 72);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.Size = new System.Drawing.Size(158, 20);
            this.txtHomePhone.TabIndex = 5;
            // 
            // labelMobilePhone
            // 
            this.labelMobilePhone.AutoSize = true;
            this.labelMobilePhone.Location = new System.Drawing.Point(270, 75);
            this.labelMobilePhone.Name = "labelMobilePhone";
            this.labelMobilePhone.Size = new System.Drawing.Size(73, 13);
            this.labelMobilePhone.TabIndex = 6;
            this.labelMobilePhone.Text = "Mobile Phone:";
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(344, 72);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(150, 20);
            this.txtMobilePhone.TabIndex = 7;
            // 
            // groupBoxParentDetails
            // 
            this.groupBoxParentDetails.Controls.Add(this.labelParentName);
            this.groupBoxParentDetails.Controls.Add(this.txtParentName);
            this.groupBoxParentDetails.Controls.Add(this.labelNIC);
            this.groupBoxParentDetails.Controls.Add(this.txtNIC);
            this.groupBoxParentDetails.Controls.Add(this.labelContactNo);
            this.groupBoxParentDetails.Controls.Add(this.txtContactNo);
            this.groupBoxParentDetails.Location = new System.Drawing.Point(16, 310);
            this.groupBoxParentDetails.Name = "groupBoxParentDetails";
            this.groupBoxParentDetails.Size = new System.Drawing.Size(525, 80);
            this.groupBoxParentDetails.TabIndex = 2;
            this.groupBoxParentDetails.TabStop = false;
            this.groupBoxParentDetails.Text = "Parent Details";
            // 
            // labelParentName
            // 
            this.labelParentName.AutoSize = true;
            this.labelParentName.Location = new System.Drawing.Point(7, 23);
            this.labelParentName.Name = "labelParentName";
            this.labelParentName.Size = new System.Drawing.Size(74, 13);
            this.labelParentName.TabIndex = 0;
            this.labelParentName.Text = "Parent Name:";
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(99, 20);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(158, 20);
            this.txtParentName.TabIndex = 1;
            // 
            // labelNIC
            // 
            this.labelNIC.AutoSize = true;
            this.labelNIC.Location = new System.Drawing.Point(270, 23);
            this.labelNIC.Name = "labelNIC";
            this.labelNIC.Size = new System.Drawing.Size(29, 13);
            this.labelNIC.TabIndex = 2;
            this.labelNIC.Text = "NIC:";
            // 
            // txtNIC
            // 
            this.txtNIC.Location = new System.Drawing.Point(344, 20);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(150, 20);
            this.txtNIC.TabIndex = 3;
            // 
            // labelContactNo
            // 
            this.labelContactNo.AutoSize = true;
            this.labelContactNo.Location = new System.Drawing.Point(7, 49);
            this.labelContactNo.Name = "labelContactNo";
            this.labelContactNo.Size = new System.Drawing.Size(63, 13);
            this.labelContactNo.TabIndex = 4;
            this.labelContactNo.Text = "Contact No:";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(99, 46);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(158, 20);
            this.txtContactNo.TabIndex = 5;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(602, 128);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 1;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(602, 170);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(602, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(602, 254);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // comboBoxRegNo
            // 
            this.comboBoxRegNo.FormattingEnabled = true;
            this.comboBoxRegNo.Location = new System.Drawing.Point(16, 19);
            this.comboBoxRegNo.Name = "comboBoxRegNo";
            this.comboBoxRegNo.Size = new System.Drawing.Size(186, 21);
            this.comboBoxRegNo.TabIndex = 3;
            this.comboBoxRegNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegNo_SelectedIndexChanged);
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.Location = new System.Drawing.Point(629, 24);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLogout.TabIndex = 5;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Logout";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogout_LinkClicked);
            // 
            // linkExit
            // 
            this.linkExit.AutoSize = true;
            this.linkExit.Location = new System.Drawing.Point(629, 44);
            this.linkExit.Name = "linkExit";
            this.linkExit.Size = new System.Drawing.Size(26, 13);
            this.linkExit.TabIndex = 6;
            this.linkExit.TabStop = true;
            this.linkExit.Text = "Exit";
            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExit_LinkClicked);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(206, 24);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Skills International";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 475);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.linkExit);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.groupBoxStudentRegistration);
            this.Name = "RegistrationForm";
            this.Text = "Student Registration Form";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.groupBoxStudentRegistration.ResumeLayout(false);
            this.groupBoxBasicDetails.ResumeLayout(false);
            this.groupBoxBasicDetails.PerformLayout();
            this.groupBoxContactDetails.ResumeLayout(false);
            this.groupBoxContactDetails.PerformLayout();
            this.groupBoxParentDetails.ResumeLayout(false);
            this.groupBoxParentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.GroupBox groupBoxStudentRegistration;
        private System.Windows.Forms.GroupBox groupBoxBasicDetails;
        private System.Windows.Forms.Label labelRegNo;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.GroupBox groupBoxContactDetails;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label labelHomePhone;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.Label labelMobilePhone;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.GroupBox groupBoxParentDetails;
        private System.Windows.Forms.Label labelParentName;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label labelNIC;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label labelContactNo;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox comboBoxRegNo;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.LinkLabel linkExit;
        private System.Windows.Forms.Label labelTitle;
    }
}
