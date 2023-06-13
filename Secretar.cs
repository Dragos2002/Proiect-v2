using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Globalization;

namespace Proiect_v2
{
    public partial class Secretar : Form
    {
        public Secretar()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)//insert
        {
            // Create a custom form for the pop-up
            Form popupForm = new Form();
            popupForm.Text = "Student";
            popupForm.StartPosition = FormStartPosition.CenterScreen;
            popupForm.Width = 400;
            popupForm.Height = 370;
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


            Label lblSpecializare = new Label();
            lblSpecializare.Text = "Specializare:";
            lblSpecializare.Location = new Point(10, 250);

            TextBox txtSpecializare = new TextBox();
            txtSpecializare.Location = new Point(120, 250);

            // Create an OK button
            Button btnOK = new Button();
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 280);
            btnOK.Height = 30;





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
            popupForm.Controls.Add(lblSpecializare);
            popupForm.Controls.Add(txtSpecializare);
            //popupForm.Controls.Add(btnOK1);

            // Show the pop-up form as a dialog
            DialogResult result = popupForm.ShowDialog();


            if (result == DialogResult.OK)
            {
                // Access the entered values
                string NM = txtNrM.Text;
                string Nume = txtNume.Text;
                string Prenume = txtPrenume.Text;
                string Initiala_tatalui = txtInT.Text;
                string CNP = txtCNP.Text;
                string Data = data.Value.ToString("yyyy-MM-dd"); // Formatul dorit, ex. "2023-06-13"
                string Ciclu_de_inv = txtCicluInv.Text;
                string Media = txtMedia.Text;
                string Specializare = txtSpecializare.Text;

                // Restul codului rămâne neschimbat
                // ...

                // Create the SQL query with parameter placeholders
                string query = "INSERT INTO studAutomaticav3 (id, nume, prenume, initiala_tata, cnp, data_inscriere, ciclu_invatamant, medie, specializare)" +
                                " VALUES (@NM, @Nume, @Prenume, @IT, @CNP, @Data, @CicluInv, @Media, @Specializare)";

                string connectionString = "Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=StudentiAutomatica;Integrated Security=True;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameter values to the command
                        command.Parameters.AddWithValue("@NM", NM);
                        command.Parameters.AddWithValue("@Nume", Nume);
                        command.Parameters.AddWithValue("@Prenume", Prenume);
                        command.Parameters.AddWithValue("@IT", Initiala_tatalui);
                        command.Parameters.AddWithValue("@CNP", CNP);
                        command.Parameters.AddWithValue("@Data", DateTime.ParseExact(Data, "yyyy-MM-dd", CultureInfo.InvariantCulture)); // Convertim stringul Data la tipul DateTime
                        command.Parameters.AddWithValue("@CicluInv", Ciclu_de_inv);
                        command.Parameters.AddWithValue("@Media", Media);
                        command.Parameters.AddWithValue("@Specializare", Specializare);

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
            }
        }
            private void btnInapoi_Click(object sender, EventArgs e)
            {
                this.Close(); // Închide formularul curent
                Form1 Form1 = new Form1();
                Form1.Show(); // Deschide Form1
            }



            private void Secretar_Load(object sender, EventArgs e)
            {

                SqlConnection con = new SqlConnection("Data Source=ANDREI\\SQLEXPRESS;Initial Catalog=StudentiAutomatica;Integrated Security=True;");
                SqlDataAdapter sdaStudenti = new SqlDataAdapter(@"SELECT * FROM studAutomaticav3", con);
                DataTable dt1 = new DataTable();
                sdaStudenti.Fill(dt1);
                dataGridStudenti.DataSource = dt1;
            }
        
    }
}
