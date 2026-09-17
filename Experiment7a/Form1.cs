using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Experiment_07
{
    public partial class Form1 : Form
    {
        Label lblName;
        Label lblAge;
        Label lblEmail;
        Label lblMobile;

        TextBox txtName;
        TextBox txtAge;
        TextBox txtEmail;
        TextBox txtMobile;

        Button btnValidate;
        Button btnClear;

        public Form1()
        {
            InitializeComponent();
            CreateForm();
        }

        private void CreateForm()
        {
            this.Text = "Window Validation";
            this.Width = 500;
            this.Height = 400;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Name
            lblName = new Label();
            lblName.Text = "Name";
            lblName.Left = 50;
            lblName.Top = 50;
            lblName.Width = 100;

            txtName = new TextBox();
            txtName.Left = 170;
            txtName.Top = 45;
            txtName.Width = 250;

            // Age
            lblAge = new Label();
            lblAge.Text = "Age";
            lblAge.Left = 50;
            lblAge.Top = 100;
            lblAge.Width = 100;

            txtAge = new TextBox();
            txtAge.Left = 170;
            txtAge.Top = 95;
            txtAge.Width = 250;

            // Email
            lblEmail = new Label();
            lblEmail.Text = "Email";
            lblEmail.Left = 50;
            lblEmail.Top = 150;
            lblEmail.Width = 100;

            txtEmail = new TextBox();
            txtEmail.Left = 170;
            txtEmail.Top = 145;
            txtEmail.Width = 250;

            // Mobile
            lblMobile = new Label();
            lblMobile.Text = "Mobile Number";
            lblMobile.Left = 50;
            lblMobile.Top = 200;
            lblMobile.Width = 100;

            txtMobile = new TextBox();
            txtMobile.Left = 170;
            txtMobile.Top = 195;
            txtMobile.Width = 250;

            // Validate Button
            btnValidate = new Button();
            btnValidate.Text = "Validate";
            btnValidate.Left = 170;
            btnValidate.Top = 250;
            btnValidate.Width = 100;

            btnValidate.Click += btnValidate_Click;

            // Clear Button
            btnClear = new Button();
            btnClear.Text = "Clear";
            btnClear.Left = 280;
            btnClear.Top = 250;
            btnClear.Width = 100;

            btnClear.Click += btnClear_Click;

            // Add controls
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);

            this.Controls.Add(lblAge);
            this.Controls.Add(txtAge);

            this.Controls.Add(lblEmail);
            this.Controls.Add(txtEmail);

            this.Controls.Add(lblMobile);
            this.Controls.Add(txtMobile);

            this.Controls.Add(btnValidate);
            this.Controls.Add(btnClear);
        }

        private void btnValidate_Click(object? sender, EventArgs e)
        {
            // Name validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name.");
                txtName.Focus();
                return;
            }

            // Age validation
            int age;

            if (!int.TryParse(txtAge.Text, out age) ||
                age < 1 || age > 100)
            {
                MessageBox.Show("Please enter a valid age.");
                txtAge.Focus();
                return;
            }

            // Email validation
            string emailPattern =
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
                return;
            }

            // Mobile validation
            if (!Regex.IsMatch(txtMobile.Text, @"^[0-9]{10}$"))
            {
                MessageBox.Show(
                    "Mobile number must contain 10 digits.");

                txtMobile.Focus();
                return;
            }

            MessageBox.Show(
                "Validation Successful!",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            txtName.Clear();
            txtAge.Clear();
            txtEmail.Clear();
            txtMobile.Clear();

            txtName.Focus();
        }
    }
}