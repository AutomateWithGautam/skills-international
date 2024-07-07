using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing; 


namespace SkillsInternationalSchool
{
    public partial class LoginForm : Form
    {
        private DataAccess dataAccess;

        public LoginForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
            LoadImage();

        }

        private void LoadImage()
        {
            try
            {
                string imagePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "logo.png"); // Update path as needed
                pictureBox1.Image = Image.FromFile(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Ensure the image is resized to fit the PictureBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Check if the username exists
            string usernameQuery = "SELECT COUNT(1) FROM Logins WHERE Username=@username";
            SqlParameter[] usernameParams = {
                new SqlParameter("@username", username)
            };

            DataTable usernameDt = dataAccess.ExecuteQuery(usernameQuery, usernameParams);
            if (usernameDt.Rows[0][0].ToString() == "1")
            {
                // Check if the password is correct for the given username
                string passwordQuery = "SELECT COUNT(1) FROM Logins WHERE Username=@username AND Password=@password";
                SqlParameter[] passwordParams = {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password)
                };

                DataTable passwordDt = dataAccess.ExecuteQuery(passwordQuery, passwordParams);
                if (passwordDt.Rows[0][0].ToString() == "1")
                {
                    // Correct username and password
                    this.Hide();
                    RegistrationForm regForm = new RegistrationForm();
                    regForm.Show();
                }
                else
                {
                    // Incorrect password
                    MessageBox.Show("Incorrect password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Username does not exist, create new user
                string insertQuery = "INSERT INTO Logins (Username, Password) VALUES (@username, @password)";
                SqlParameter[] insertParams = {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password)
                };

                int rowsAffected = dataAccess.ExecuteNonQuery(insertQuery, insertParams);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("New user created. Logging in...", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    RegistrationForm regForm = new RegistrationForm();
                    regForm.Show();
                }
                else
                {
                    MessageBox.Show("Error creating new user. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
