namespace Proiect_v2
{
    partial class Admin
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
            this.dataGridAdmini = new System.Windows.Forms.DataGridView();
            this.dataGridSecretari = new System.Windows.Forms.DataGridView();
            this.dataGridProfesori = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InsAdmin = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deleteAdmin = new System.Windows.Forms.Button();
            this.deleteSecretar = new System.Windows.Forms.Button();
            this.deleteProfesor = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSecretari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesori)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridAdmini
            // 
            this.dataGridAdmini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAdmini.Location = new System.Drawing.Point(83, 99);
            this.dataGridAdmini.Name = "dataGridAdmini";
            this.dataGridAdmini.RowHeadersWidth = 51;
            this.dataGridAdmini.RowTemplate.Height = 29;
            this.dataGridAdmini.Size = new System.Drawing.Size(300, 351);
            this.dataGridAdmini.TabIndex = 0;
            // 
            // dataGridSecretari
            // 
            this.dataGridSecretari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSecretari.Location = new System.Drawing.Point(485, 99);
            this.dataGridSecretari.Name = "dataGridSecretari";
            this.dataGridSecretari.RowHeadersWidth = 51;
            this.dataGridSecretari.RowTemplate.Height = 29;
            this.dataGridSecretari.Size = new System.Drawing.Size(300, 351);
            this.dataGridSecretari.TabIndex = 1;
            // 
            // dataGridProfesori
            // 
            this.dataGridProfesori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProfesori.Location = new System.Drawing.Point(883, 99);
            this.dataGridProfesori.Name = "dataGridProfesori";
            this.dataGridProfesori.RowHeadersWidth = 51;
            this.dataGridProfesori.RowTemplate.Height = 29;
            this.dataGridProfesori.Size = new System.Drawing.Size(300, 351);
            this.dataGridProfesori.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admini";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Secretari";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1007, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Profesori";
            // 
            // InsAdmin
            // 
            this.InsAdmin.Location = new System.Drawing.Point(83, 474);
            this.InsAdmin.Name = "InsAdmin";
            this.InsAdmin.Size = new System.Drawing.Size(106, 29);
            this.InsAdmin.TabIndex = 11;
            this.InsAdmin.Text = "Insert Admin";
            this.InsAdmin.UseVisualStyleBackColor = true;
            this.InsAdmin.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Insert Secretar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(883, 474);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "Insert Profesor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // deleteAdmin
            // 
            this.deleteAdmin.Location = new System.Drawing.Point(264, 474);
            this.deleteAdmin.Name = "deleteAdmin";
            this.deleteAdmin.Size = new System.Drawing.Size(119, 29);
            this.deleteAdmin.TabIndex = 14;
            this.deleteAdmin.Text = "Delete Admin";
            this.deleteAdmin.UseVisualStyleBackColor = true;
            this.deleteAdmin.Click += new System.EventHandler(this.deleteAdmin_Click);
            // 
            // deleteSecretar
            // 
            this.deleteSecretar.Location = new System.Drawing.Point(659, 474);
            this.deleteSecretar.Name = "deleteSecretar";
            this.deleteSecretar.Size = new System.Drawing.Size(126, 29);
            this.deleteSecretar.TabIndex = 15;
            this.deleteSecretar.Text = "Delete Secretar";
            this.deleteSecretar.UseVisualStyleBackColor = true;
            this.deleteSecretar.Click += new System.EventHandler(this.deleteSecretar_Click);
            // 
            // deleteProfesor
            // 
            this.deleteProfesor.Location = new System.Drawing.Point(1049, 474);
            this.deleteProfesor.Name = "deleteProfesor";
            this.deleteProfesor.Size = new System.Drawing.Size(134, 29);
            this.deleteProfesor.TabIndex = 16;
            this.deleteProfesor.Text = "Delete Profesor";
            this.deleteProfesor.UseVisualStyleBackColor = true;
            this.deleteProfesor.Click += new System.EventHandler(this.deleteProfesor_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(12, 12);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(94, 29);
            this.btnInapoi.TabIndex = 17;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1272, 530);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.deleteProfesor);
            this.Controls.Add(this.deleteSecretar);
            this.Controls.Add(this.deleteAdmin);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.InsAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridProfesori);
            this.Controls.Add(this.dataGridSecretari);
            this.Controls.Add(this.dataGridAdmini);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAdmini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSecretari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProfesori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridAdmini;
        private DataGridView dataGridSecretari;
        private DataGridView dataGridProfesori;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button InsAdmin;
        private Button button2;
        private Button button3;
        private Button deleteAdmin;
        private Button deleteSecretar;
        private Button deleteProfesor;
        private Button btnInapoi;
    }
}