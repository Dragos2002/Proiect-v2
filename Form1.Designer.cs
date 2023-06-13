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
            this.SuspendLayout();
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(311, 82);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(94, 29);
            this.buttonAdmin.TabIndex = 0;
            this.buttonAdmin.Text = "Admin";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonSecretar
            // 
            this.buttonSecretar.Location = new System.Drawing.Point(311, 174);
            this.buttonSecretar.Name = "buttonSecretar";
            this.buttonSecretar.Size = new System.Drawing.Size(94, 29);
            this.buttonSecretar.TabIndex = 1;
            this.buttonSecretar.Text = "Secretar";
            this.buttonSecretar.UseVisualStyleBackColor = true;
            this.buttonSecretar.Click += new System.EventHandler(this.buttonSecretar_Click);
            // 
            // buttonProfesor
            // 
            this.buttonProfesor.Location = new System.Drawing.Point(311, 267);
            this.buttonProfesor.Name = "buttonProfesor";
            this.buttonProfesor.Size = new System.Drawing.Size(94, 29);
            this.buttonProfesor.TabIndex = 2;
            this.buttonProfesor.Text = "Profesor";
            this.buttonProfesor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonProfesor);
            this.Controls.Add(this.buttonSecretar);
            this.Controls.Add(this.buttonAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonAdmin;
        private Button buttonSecretar;
        private Button buttonProfesor;
    }
}