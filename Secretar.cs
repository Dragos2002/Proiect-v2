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
    public partial class Secretar : Form
    {
        public Secretar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a custom form for the pop-up
            Form popupForm = new Form();
            popupForm.Text = "Student";
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            popupForm.Width = 400;
            popupForm.Height = 350;
            Label lblNrM = new Label();
            lblNrM.Text = "Nr matricol:";
            lblNrM.Location = new Point(10, 10);

            TextBox txtNrM = new TextBox();
            txtNrM.Location = new Point(120, 10);
            // Create labels and textboxes for name, username, and password
            Label lblNume = new Label();
            lblNume.Text = "Nume:";
            lblNume.Location = new Point(10, 40);

            TextBox txtNume = new TextBox();
            txtNume.Location = new Point(120, 40);

            Label lblPrenume = new Label();
            lblPrenume.Text = "Prenume:";
            lblPrenume.Location = new Point(10, 70);

            TextBox txtPrenume = new TextBox();
            txtPrenume.Location = new Point(120, 70);

            Label lblInT = new Label();
            lblInT.Text = "Init tata:";
            lblInT.Location = new Point(10, 100);

            TextBox txtInT = new TextBox();
            txtInT.Location = new Point(120, 100);

            Label lblCNP = new Label();
            lblCNP.Text = "CNP:";
            lblCNP.Location = new Point(10, 130);

            TextBox txtCNP = new TextBox();
            txtCNP.Location = new Point(120, 130);

            Label lblData = new Label();
            lblData.Text = "Data insc:";
            lblData.Location = new Point(10, 160);
            
            DateTimePicker data = new DateTimePicker();
            data.Location = new Point(120, 160);

            Label lblCicluInv = new Label();
            lblCicluInv.Text = "Ciclu inv:";
            lblCicluInv.Location = new Point(10, 190);

            TextBox txtCicluInv = new TextBox();
            txtCicluInv.Location = new Point(120, 190);

            Label lblMedia = new Label();
            lblMedia.Text = "Media:";
            lblMedia.Location = new Point(10, 220);

            TextBox txtMedia = new TextBox();
            txtMedia.Location = new Point(120, 220);

            // Create an OK button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 250);
            btnOK.Height = 30;

            //Create an Cancel button
            /*Button btnOK1 = new Button();
            btnOK1.Text = "Cancel";
            btnOK1.DialogResult = DialogResult.Cancel;
            btnOK1.Location = new Point(190, 190);
            btnOK1.Height = 30;*/



            // Add controls to the form
            popupForm.Controls.Add(lblNrM);
            popupForm.Controls.Add(txtNrM);
            popupForm.Controls.Add(lblNume);
            popupForm.Controls.Add(txtNume);
            popupForm.Controls.Add(lblPrenume);
            popupForm.Controls.Add(txtPrenume);
            popupForm.Controls.Add(lblInT);
            popupForm.Controls.Add(txtInT);
            popupForm.Controls.Add(lblCNP);
            popupForm.Controls.Add(txtCNP);
            popupForm.Controls.Add(btnOK);
            popupForm.Controls.Add(lblData);
            popupForm.Controls.Add(data);
            popupForm.Controls.Add(lblCicluInv);
            popupForm.Controls.Add(txtCicluInv);
            popupForm.Controls.Add(lblMedia);
            popupForm.Controls.Add(txtMedia);
            //popupForm.Controls.Add(btnOK1);

            // Show the pop-up form as a dialog
            DialogResult result = popupForm.ShowDialog();
            /*if (result == DialogResult.Cancel)
                popupForm.Close();*/
            /*if (string.IsNullOrEmpty(txtName.Text)
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
            }*/
        }
    }
}
