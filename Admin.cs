using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_v2
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a custom form for the pop-up
            Form popupForm = new Form();
            popupForm.Text = "Admini";
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            // Create labels and textboxes for name, username, and password
            Label lblName = new Label();
            lblName.Text = "Nume:";
            lblName.Location = new Point(10, 10);

            TextBox txtName = new TextBox();
            txtName.Location = new Point(120, 10);

            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new Point(10, 40);

            TextBox txtUsername = new TextBox();
            txtUsername.Location = new Point(120, 40);

            Label lblPassword = new Label();
            lblPassword.Text = "Parola:";
            lblPassword.Location = new Point(10, 70);

            TextBox txtPassword = new TextBox();
            txtPassword.Location = new Point(120, 70);
            txtPassword.PasswordChar = '*';

            // Create an OK button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 120);
            btnOK.Height = 30;

            //Create an Cancel button
            /*Button btnOK1 = new Button();
            btnOK1.Text = "Cancel";
            btnOK1.DialogResult = DialogResult.Cancel;
            btnOK1.Location = new Point(190, 190);
            btnOK1.Height = 30;*/



            // Add controls to the form
            popupForm.Controls.Add(lblName);
            popupForm.Controls.Add(txtName);
            popupForm.Controls.Add(lblUsername);
            popupForm.Controls.Add(txtUsername);
            popupForm.Controls.Add(lblPassword);
            popupForm.Controls.Add(txtPassword);
            popupForm.Controls.Add(btnOK);
            //popupForm.Controls.Add(btnOK1);

            // Show the pop-up form as a dialog
            DialogResult result = popupForm.ShowDialog();
            /*if (result == DialogResult.Cancel)
                popupForm.Close();*/
            if (string.IsNullOrEmpty(txtName.Text)
           || string.IsNullOrEmpty(txtUsername.Text)
           || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Completati toate campurile.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else


            // Process the result
            if (result == DialogResult.OK)
            {
                // Access the entered values
                string name = txtName.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Do something with the entered values
                MessageBox.Show("Admin inregistrat");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a custom form for the pop-up
            Form popupForm = new Form();
            popupForm.Text = "Secretar";
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            // Create labels and textboxes for name, username, and password
            Label lblName = new Label();
            lblName.Text = "Nume:";
            lblName.Location = new Point(10, 10);

            TextBox txtName = new TextBox();
            txtName.Location = new Point(120, 10);

            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new Point(10, 40);

            TextBox txtUsername = new TextBox();
            txtUsername.Location = new Point(120, 40);

            Label lblPassword = new Label();
            lblPassword.Text = "Parola:";
            lblPassword.Location = new Point(10, 70);

            TextBox txtPassword = new TextBox();
            txtPassword.Location = new Point(120, 70);
            txtPassword.PasswordChar = '*';

            // Create an OK button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 120);
            btnOK.Height = 30;

            //Create an Cancel button
            /*Button btnOK1 = new Button();
            btnOK1.Text = "Cancel";
            btnOK1.DialogResult = DialogResult.Cancel;
            btnOK1.Location = new Point(190, 190);
            btnOK1.Height = 30;*/



            // Add controls to the form
            popupForm.Controls.Add(lblName);
            popupForm.Controls.Add(txtName);
            popupForm.Controls.Add(lblUsername);
            popupForm.Controls.Add(txtUsername);
            popupForm.Controls.Add(lblPassword);
            popupForm.Controls.Add(txtPassword);
            popupForm.Controls.Add(btnOK);
            //popupForm.Controls.Add(btnOK1);

            // Show the pop-up form as a dialog
            DialogResult result = popupForm.ShowDialog();
            /*if (result == DialogResult.Cancel)
                popupForm.Close();*/
            if (string.IsNullOrEmpty(txtName.Text)
           || string.IsNullOrEmpty(txtUsername.Text)
           || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Completati toate campurile.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else


            // Process the result
            if (result == DialogResult.OK)
            {
                // Access the entered values
                string name = txtName.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Do something with the entered values
                MessageBox.Show("Secretar inregistrat");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a custom form for the pop-up
            Form popupForm = new Form();
            popupForm.Text = "Profesori";
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            // Create labels and textboxes for name, username, and password
            Label lblName = new Label();
            lblName.Text = "Nume:";
            lblName.Location = new Point(10, 10);

            TextBox txtName = new TextBox();
            txtName.Location = new Point(120, 10);

            Label lblUsername = new Label();
            lblUsername.Text = "Username:";
            lblUsername.Location = new Point(10, 40);

            TextBox txtUsername = new TextBox();
            txtUsername.Location = new Point(120, 40);

            Label lblPassword = new Label();
            lblPassword.Text = "Parola:";
            lblPassword.Location = new Point(10, 70);

            TextBox txtPassword = new TextBox();
            txtPassword.Location = new Point(120, 70);
            txtPassword.PasswordChar = '*';

            // Create an OK button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 120);
            btnOK.Height = 30;

            //Create an Cancel button
            /*Button btnOK1 = new Button();
            btnOK1.Text = "Cancel";
            btnOK1.DialogResult = DialogResult.Cancel;
            btnOK1.Location = new Point(190, 190);
            btnOK1.Height = 30;*/



            // Add controls to the form
            popupForm.Controls.Add(lblName);
            popupForm.Controls.Add(txtName);
            popupForm.Controls.Add(lblUsername);
            popupForm.Controls.Add(txtUsername);
            popupForm.Controls.Add(lblPassword);
            popupForm.Controls.Add(txtPassword);
            popupForm.Controls.Add(btnOK);
            //popupForm.Controls.Add(btnOK1);

            // Show the pop-up form as a dialog
            DialogResult result = popupForm.ShowDialog();
            /*if (result == DialogResult.Cancel)
                popupForm.Close();*/
            if (string.IsNullOrEmpty(txtName.Text)
           || string.IsNullOrEmpty(txtUsername.Text)
           || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Completati toate campurile.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else


            // Process the result
            if (result == DialogResult.OK)
            {
                // Access the entered values
                string name = txtName.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                // Do something with the entered values
                MessageBox.Show("Profesor inregistrat");
            }
        }
    }
}
