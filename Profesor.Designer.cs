namespace Proiect_v2
{
    partial class Profesor
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
            dataGridView1 = new DataGridView();
            buttonInsertNota = new Button();
            buttonStergeNota = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(405, 306);
            dataGridView1.TabIndex = 0;
            // 
            // buttonInsertNota
            // 
            buttonInsertNota.Location = new Point(49, 446);
            buttonInsertNota.Name = "buttonInsertNota";
            buttonInsertNota.Size = new Size(94, 29);
            buttonInsertNota.TabIndex = 1;
            buttonInsertNota.Text = "Insert Nota";
            buttonInsertNota.UseVisualStyleBackColor = true;
            buttonInsertNota.Click += buttonInsertNota_Click;
            // 
            // buttonStergeNota
            // 
            buttonStergeNota.Location = new Point(334, 446);
            buttonStergeNota.Name = "buttonStergeNota";
            buttonStergeNota.Size = new Size(120, 29);
            buttonStergeNota.TabIndex = 2;
            buttonStergeNota.Text = "Sterge Nota";
            buttonStergeNota.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(237, 27);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 64);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 4;
            label1.Text = "Notele la disciplina:";
            // 
            // Profesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 503);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(buttonStergeNota);
            Controls.Add(buttonInsertNota);
            Controls.Add(dataGridView1);
            Name = "Profesor";
            Text = "Profesor";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonInsertNota;
        private Button buttonStergeNota;
        private TextBox textBox1;
        private Label label1;
    }
}