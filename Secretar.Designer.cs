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
            this.dataGridStudenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridStudenti
            // 
            this.dataGridStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStudenti.Location = new System.Drawing.Point(40, 112);
            this.dataGridStudenti.Name = "dataGridStudenti";
            this.dataGridStudenti.RowHeadersWidth = 51;
            this.dataGridStudenti.RowTemplate.Height = 29;
            this.dataGridStudenti.Size = new System.Drawing.Size(513, 512);
            this.dataGridStudenti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Studenti";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(210, 656);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(154, 29);
            this.btnInsert.TabIndex = 2;
            this.btnInsert.Text = "Insert Student";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(12, 12);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(94, 29);
            this.btnInapoi.TabIndex = 3;
            this.btnInapoi.Text = "Inapoi";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // Secretar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 734);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridStudenti);
            this.Name = "Secretar";
            this.Text = "Secretar";
            this.Load += new System.EventHandler(this.Secretar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStudenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridStudenti;
        private Label label1;
        private Button btnInsert;
        private Button btnInapoi;
    }
}

