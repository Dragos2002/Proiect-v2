using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_v2
{
    public partial class Profesor : Form
    {
        public Profesor()
        {
            InitializeComponent();
        }

        private void buttonInsertNota_Click(object sender, EventArgs e)
        {
            // Create a custom form for the pop-up
            Form popupForm = new Form();
            popupForm.Text = "Note";
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            popupForm.Width = 300;
            popupForm.Height = 200;
            Label lblNrMat = new Label();
            lblNrMat.Text = "Nr. matricol:";
            lblNrMat.Location = new Point(10, 10);

            TextBox txtNrMat = new TextBox();
            txtNrMat.Location = new Point(120, 10);
            // Create labels and textboxes for name, username, and password
            Label lblNota = new Label();
            lblNota.Text = "Nota:";
            lblNota.Location = new Point(10, 40);

            TextBox txtNota = new TextBox();
            txtNota.Location = new Point(120, 40);

            // Create an OK button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 70);
            btnOK.Height = 30;

            // Add controls to the form
            popupForm.Controls.Add(lblNrMat);
            popupForm.Controls.Add(txtNrMat);
            popupForm.Controls.Add(lblNota);
            popupForm.Controls.Add(txtNota);
            popupForm.Controls.Add(btnOK);

            // Show the pop-up form as a dialog
            DialogResult result = popupForm.ShowDialog();


            if (result == DialogResult.OK)
            {
                // Access the entered values
                string Materie = txtNrMat.Text;
                string Nota = txtNota.Text;

                // Restul codului rămâne neschimbat
                // ...

                // Create the SQL query with parameter placeholders
                /*
                string query = "INSERT INTO studAutomaticav3 (id, nume, prenume, initiala_tata, cnp, data_inscriere, ciclu_invatamant, medie, specializare)" +
                                " VALUES (@NM, @Nume, @Prenume, @IT, @CNP, @Data, @CicluInv, @Media, @Specializare)";

                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=StudentiAutomatica;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter values to the command
                        command.Parameters.AddWithValue("@Materie", Materie);
                        command.Parameters.AddWithValue("@Nota", Nota);

                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            MessageBox.Show("Data inserted successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }



                    }
                }
                */
            }
        }
    }
}

