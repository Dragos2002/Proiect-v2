namespace Proiect_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonSecretar = new System.Windows.Forms.Button();
            this.buttonProfesor = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.Nume = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LogIn = new System.Windows.Forms.Label();
            this.radiobtnAdmin = new System.Windows.Forms.RadioButton();
            this.radioBtnSecretar = new System.Windows.Forms.RadioButton();
            this.radioBtnProfesor = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(66, 98);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(94, 29);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonSecretar
            // 
            this.buttonSecretar.Location = new System.Drawing.Point(66, 171);
            this.buttonSecretar.Name = "buttonSecretar";
            this.buttonSecretar.Size = new System.Drawing.Size(94, 29);
            this.buttonSecretar.TabIndex = 1;
            this.buttonSecretar.Text = "Secretar";
            this.buttonSecretar.UseVisualStyleBackColor = true;
            this.buttonSecretar.Click += new System.EventHandler(this.buttonSecretar_Click);
            // 
            // buttonProfesor
            // 
            this.buttonProfesor.Location = new System.Drawing.Point(66, 255);
            this.buttonProfesor.Name = "buttonProfesor";
            this.buttonProfesor.Size = new System.Drawing.Size(94, 29);
            this.buttonProfesor.TabIndex = 2;
            this.buttonProfesor.Text = "Profesor";
            this.buttonProfesor.UseVisualStyleBackColor = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(479, 381);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(94, 29);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // Nume
            // 
            this.Nume.AutoSize = true;
            this.Nume.Location = new System.Drawing.Point(469, 102);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(75, 20);
            this.Nume.TabIndex = 5;
            this.Nume.Text = "Username";
            this.Nume.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(416, 149);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(199, 27);
            this.txtUsername.TabIndex = 7;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(416, 233);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(199, 27);
            this.txtParola.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Parola";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LogIn
            // 
            this.LogIn.AutoSize = true;
            this.LogIn.Location = new System.Drawing.Point(486, 52);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(46, 20);
            this.LogIn.TabIndex = 10;
            this.LogIn.Text = "LogIn";
            // 
            // radiobtnAdmin
            // 
            this.radiobtnAdmin.AutoSize = true;
            this.radiobtnAdmin.Location = new System.Drawing.Point(369, 319);
            this.radiobtnAdmin.Name = "radiobtnAdmin";
            this.radiobtnAdmin.Size = new System.Drawing.Size(74, 24);
            this.radiobtnAdmin.TabIndex = 11;
            this.radiobtnAdmin.TabStop = true;
            this.radiobtnAdmin.Text = "Admin";
            this.radiobtnAdmin.UseVisualStyleBackColor = true;
            // 
            // radioBtnSecretar
            // 
            this.radioBtnSecretar.AutoSize = true;
            this.radioBtnSecretar.Location = new System.Drawing.Point(479, 319);
            this.radioBtnSecretar.Name = "radioBtnSecretar";
            this.radioBtnSecretar.Size = new System.Drawing.Size(84, 24);
            this.radioBtnSecretar.TabIndex = 12;
            this.radioBtnSecretar.TabStop = true;
            this.radioBtnSecretar.Text = "Secretar";
            this.radioBtnSecretar.UseVisualStyleBackColor = true;
            // 
            // radioBtnProfesor
            // 
            this.radioBtnProfesor.AutoSize = true;
            this.radioBtnProfesor.Location = new System.Drawing.Point(596, 319);
            this.radioBtnProfesor.Name = "radioBtnProfesor";
            this.radioBtnProfesor.Size = new System.Drawing.Size(85, 24);
            this.radioBtnProfesor.TabIndex = 13;
            this.radioBtnProfesor.TabStop = true;
            this.radioBtnProfesor.Text = "Profesor";
            this.radioBtnProfesor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Selectati ca anume doriti sa va conectati:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 473);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioBtnProfesor);
            this.Controls.Add(this.radioBtnSecretar);
            this.Controls.Add(this.radiobtnAdmin);
            this.Controls.Add(this.LogIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.buttonProfesor);
            this.Controls.Add(this.buttonSecretar);
            this.Controls.Add(this.buttonAdmin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAdmin;
        private Button buttonSecretar;
        private Button buttonProfesor;
        private Button btnLogIn;
        private Label Nume;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtParola;
        private Label label1;
        private Label LogIn;
        private RadioButton radiobtnAdmin;
        private RadioButton radioBtnSecretar;
        private RadioButton radioBtnProfesor;
        private Label label3;
    }
}