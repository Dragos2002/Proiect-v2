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
            buttonAdmin = new Button();
            buttonSecretar = new Button();
            buttonProfesor = new Button();
            btnLogIn = new Button();
            Nume = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtParola = new TextBox();
            label1 = new Label();
            LogIn = new Label();
            radiobtnAdmin = new RadioButton();
            radioBtnSecretar = new RadioButton();
            radioBtnProfesor = new RadioButton();
            label3 = new Label();
            SuspendLayout();
            // 
            // buttonAdmin
            // 
            buttonAdmin.Location = new Point(66, 98);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(94, 29);
            buttonAdmin.TabIndex = 0;
            buttonAdmin.Text = "Admin";
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += buttonAdmin_Click;
            // 
            // buttonSecretar
            // 
            buttonSecretar.Location = new Point(66, 171);
            buttonSecretar.Name = "buttonSecretar";
            buttonSecretar.Size = new Size(94, 29);
            buttonSecretar.TabIndex = 1;
            buttonSecretar.Text = "Secretar";
            buttonSecretar.UseVisualStyleBackColor = true;
            buttonSecretar.Click += buttonSecretar_Click;
            // 
            // buttonProfesor
            // 
            buttonProfesor.Location = new Point(66, 255);
            buttonProfesor.Name = "buttonProfesor";
            buttonProfesor.Size = new Size(94, 29);
            buttonProfesor.TabIndex = 2;
            buttonProfesor.Text = "Profesor";
            buttonProfesor.UseVisualStyleBackColor = true;
            buttonProfesor.Click += buttonProfesor_Click;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(479, 381);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(94, 29);
            btnLogIn.TabIndex = 4;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // Nume
            // 
            Nume.AutoSize = true;
            Nume.Location = new Point(469, 102);
            Nume.Name = "Nume";
            Nume.Size = new Size(75, 20);
            Nume.TabIndex = 5;
            Nume.Text = "Username";
            Nume.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(486, 194);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 6;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(416, 149);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(199, 27);
            txtUsername.TabIndex = 7;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(416, 233);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(199, 27);
            txtParola.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(492, 194);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 9;
            label1.Text = "Parola";
            label1.Click += label1_Click_1;
            // 
            // LogIn
            // 
            LogIn.AutoSize = true;
            LogIn.Location = new Point(486, 52);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(46, 20);
            LogIn.TabIndex = 10;
            LogIn.Text = "LogIn";
            // 
            // radiobtnAdmin
            // 
            radiobtnAdmin.AutoSize = true;
            radiobtnAdmin.Location = new Point(369, 319);
            radiobtnAdmin.Name = "radiobtnAdmin";
            radiobtnAdmin.Size = new Size(74, 24);
            radiobtnAdmin.TabIndex = 11;
            radiobtnAdmin.TabStop = true;
            radiobtnAdmin.Text = "Admin";
            radiobtnAdmin.UseVisualStyleBackColor = true;
            // 
            // radioBtnSecretar
            // 
            radioBtnSecretar.AutoSize = true;
            radioBtnSecretar.Location = new Point(479, 319);
            radioBtnSecretar.Name = "radioBtnSecretar";
            radioBtnSecretar.Size = new Size(84, 24);
            radioBtnSecretar.TabIndex = 12;
            radioBtnSecretar.TabStop = true;
            radioBtnSecretar.Text = "Secretar";
            radioBtnSecretar.UseVisualStyleBackColor = true;
            // 
            // radioBtnProfesor
            // 
            radioBtnProfesor.AutoSize = true;
            radioBtnProfesor.Location = new Point(596, 319);
            radioBtnProfesor.Name = "radioBtnProfesor";
            radioBtnProfesor.Size = new Size(85, 24);
            radioBtnProfesor.TabIndex = 13;
            radioBtnProfesor.TabStop = true;
            radioBtnProfesor.Text = "Profesor";
            radioBtnProfesor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(381, 277);
            label3.Name = "label3";
            label3.Size = new Size(279, 20);
            label3.TabIndex = 14;
            label3.Text = "Selectati ca anume doriti sa va conectati:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 473);
            Controls.Add(label3);
            Controls.Add(radioBtnProfesor);
            Controls.Add(radioBtnSecretar);
            Controls.Add(radiobtnAdmin);
            Controls.Add(LogIn);
            Controls.Add(label1);
            Controls.Add(txtParola);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(Nume);
            Controls.Add(btnLogIn);
            Controls.Add(buttonProfesor);
            Controls.Add(buttonSecretar);
            Controls.Add(buttonAdmin);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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