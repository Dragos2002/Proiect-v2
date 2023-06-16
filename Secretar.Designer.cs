namespace Proiect_v2
{
    partial class Secretar
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
            dataGridStudenti = new DataGridView();
            label1 = new Label();
            btnInsert = new Button();
            btnInapoi = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridStudenti).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridStudenti
            // 
            dataGridStudenti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridStudenti.Location = new Point(721, 124);
            dataGridStudenti.Name = "dataGridStudenti";
            dataGridStudenti.RowHeadersWidth = 51;
            dataGridStudenti.RowTemplate.Height = 29;
            dataGridStudenti.Size = new Size(513, 512);
            dataGridStudenti.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(936, 85);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 1;
            label1.Text = "Studenti";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(891, 668);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(154, 29);
            btnInsert.TabIndex = 2;
            btnInsert.Text = "Insert Student";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += button1_Click_1;
            // 
            // btnInapoi
            // 
            btnInapoi.Location = new Point(12, 12);
            btnInapoi.Name = "btnInapoi";
            btnInapoi.Size = new Size(94, 29);
            btnInapoi.TabIndex = 3;
            btnInapoi.Text = "Inapoi";
            btnInapoi.UseVisualStyleBackColor = true;
            btnInapoi.Click += btnInapoi_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(77, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(513, 512);
            dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 85);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 5;
            label2.Text = "Grupe";
            // 
            // button1
            // 
            button1.Location = new Point(113, 668);
            button1.Name = "button1";
            button1.Size = new Size(154, 29);
            button1.TabIndex = 6;
            button1.Text = "Generare Grupa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Secretar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 734);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnInapoi);
            Controls.Add(btnInsert);
            Controls.Add(label1);
            Controls.Add(dataGridStudenti);
            Name = "Secretar";
            Text = "Secretar";
            Load += Secretar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridStudenti).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridStudenti;
        private Label label1;
        private Button btnInsert;
        private Button btnInapoi;
        private DataGridView dataGridView1;
        private Label label2;
        private Button button1;
    }
}

