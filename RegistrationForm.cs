using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SkillsInternationalSchool
{
    public partial class RegistrationForm : Form
    {
        private DataAccess dataAccess;

        public RegistrationForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
            LoadRegNoComboBox();

            // Attach event handlers for form load events
            this.Load += RegistrationForm_Load;
            this.Load += RegistrationForm_Load_1;
        }

        private void LoadRegNoComboBox()
        {
            string query = "SELECT regNo FROM Registration";
            DataTable dt = dataAccess.ExecuteQuery(query);
            if (dt != null)
            {
                comboBoxRegNo.DataSource = dt;
                comboBoxRegNo.DisplayMember = "regNo";
                comboBoxRegNo.ValueMember = "regNo";
            }
            else
            {
                MessageBox.Show("Failed to load registration numbers.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegNo.Text) || string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "INSERT INTO Registration (regNo, firstName, lastName, dateOfBirth, gender, address, email, mobilePhone, homePhone, parentName, nic, contactNo) VALUES (@regNo, @firstName, @lastName, @dateOfBirth, @gender, @address, @email, @mobilePhone, @homePhone, @parentName, @nic, @contactNo)";
            SqlParameter[] parameters = {
                new SqlParameter("@regNo", int.Parse(txtRegNo.Text)),
                new SqlParameter("@firstName", txtFirstName.Text),
                new SqlParameter("@lastName", txtLastName.Text),
                new SqlParameter("@dateOfBirth", dtpDateOfBirth.Value),
                new SqlParameter("@gender", rbtnMale.Checked ? "Male" : "Female"),
                new SqlParameter("@address", txtAddress.Text),
                new SqlParameter("@email", txtEmail.Text),
                new SqlParameter("@mobilePhone", int.Parse(txtMobilePhone.Text)),
                new SqlParameter("@homePhone", int.Parse(txtHomePhone.Text)),
                new SqlParameter("@parentName", txtParentName.Text),
                new SqlParameter("@nic", txtNIC.Text),
                new SqlParameter("@contactNo", int.Parse(txtContactNo.Text))
            };

            int rowsAffected = dataAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRegNoComboBox();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegNo.Text) || string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "UPDATE Registration SET firstName=@firstName, lastName=@lastName, dateOfBirth=@dateOfBirth, gender=@gender, address=@address, email=@email, mobilePhone=@mobilePhone, homePhone=@homePhone, parentName=@parentName, nic=@nic, contactNo=@contactNo WHERE regNo=@regNo";
            SqlParameter[] parameters = {
                new SqlParameter("@regNo", int.Parse(txtRegNo.Text)),
                new SqlParameter("@firstName", txtFirstName.Text),
                new SqlParameter("@lastName", txtLastName.Text),
                new SqlParameter("@dateOfBirth", dtpDateOfBirth.Value),
                new SqlParameter("@gender", rbtnMale.Checked ? "Male" : "Female"),
                new SqlParameter("@address", txtAddress.Text),
                new SqlParameter("@email", txtEmail.Text),
                new SqlParameter("@mobilePhone", int.Parse(txtMobilePhone.Text)),
                new SqlParameter("@homePhone", int.Parse(txtHomePhone.Text)),
                new SqlParameter("@parentName", txtParentName.Text),
                new SqlParameter("@nic", txtNIC.Text),
                new SqlParameter("@contactNo", int.Parse(txtContactNo.Text))
            };

            int rowsAffected = dataAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Update successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRegNoComboBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtRegNo.Text))
            {
                MessageBox.Show("Please provide a registration number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Registration WHERE regNo=@regNo";
                SqlParameter[] parameters = {
                    new SqlParameter("@regNo", int.Parse(txtRegNo.Text))
                };

                int rowsAffected = dataAccess.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Delete successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRegNoComboBox();
                }
            }
        }

        private void comboBoxRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRegNo.SelectedValue != null)
            {
                string query = "SELECT * FROM Registration WHERE regNo=@regNo";
                SqlParameter[] parameters = {
                    new SqlParameter("@regNo", comboBoxRegNo.SelectedValue)
                };

                DataTable dt = dataAccess.ExecuteQuery(query, parameters);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtRegNo.Text = row["regNo"].ToString();
                    txtFirstName.Text = row["firstName"].ToString();
                    txtLastName.Text = row["lastName"].ToString();
                    dtpDateOfBirth.Value = DateTime.Parse(row["dateOfBirth"].ToString());
                    if (row["gender"].ToString() == "Male")
                    {
                        rbtnMale.Checked = true;
                    }
                    else
                    {
                        rbtnFemale.Checked = true;
                    }
                    txtAddress.Text = row["address"].ToString();
                    txtEmail.Text = row["email"].ToString();
                    txtMobilePhone.Text = row["mobilePhone"].ToString();
                    txtHomePhone.Text = row["homePhone"].ToString();
                    txtParentName.Text = row["parentName"].ToString();
                    txtNIC.Text = row["nic"].ToString();
                    txtContactNo.Text = row["contactNo"].ToString();
                }
            }
        }

        private void linkLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void linkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRegNo.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobilePhone.Clear();
            txtHomePhone.Clear();
            txtParentName.Clear();
            txtNIC.Clear();
            txtContactNo.Clear();
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            dtpDateOfBirth.Value = DateTime.Now;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // Initialization code when the RegistrationForm loads
            // Example: You can set default values or perform initial actions here
            // For example, focusing on a specific control:
            txtFirstName.Focus();
        }

        private void RegistrationForm_Load_1(object sender, EventArgs e)
        {
            // Additional initialization code when the RegistrationForm loads
            // Example: You can load data from the database or perform other setup tasks
            LoadRegNoComboBox(); // Load registration numbers into the combobox
        }
    }
}
