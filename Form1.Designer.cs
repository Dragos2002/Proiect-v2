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
            SuspendLayout();
            // 
            // buttonAdmin
            // 
            buttonAdmin.Location = new Point(311, 82);
            buttonAdmin.Name = "buttonAdmin";
            buttonAdmin.Size = new Size(94, 29);
            buttonAdmin.TabIndex = 0;
            buttonAdmin.Text = "Admin";
            buttonAdmin.UseVisualStyleBackColor = true;
            buttonAdmin.Click += button1_Click;
            // 
            // buttonSecretar
            // 
            buttonSecretar.Location = new Point(311, 174);
            buttonSecretar.Name = "buttonSecretar";
            buttonSecretar.Size = new Size(94, 29);
            buttonSecretar.TabIndex = 1;
            buttonSecretar.Text = "Secretar";
            buttonSecretar.UseVisualStyleBackColor = true;
            buttonSecretar.Click += button2_Click;
            // 
            // buttonProfesor
            // 
            buttonProfesor.Location = new Point(311, 267);
            buttonProfesor.Name = "buttonProfesor";
            buttonProfesor.Size = new Size(94, 29);
            buttonProfesor.TabIndex = 2;
            buttonProfesor.Text = "Profesor";
            buttonProfesor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonProfesor);
            Controls.Add(buttonSecretar);
            Controls.Add(buttonAdmin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAdmin;
        private Button buttonSecretar;
        private Button buttonProfesor;
    }
}