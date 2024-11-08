namespace UTS_PBO.Views
{
    partial class buku
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
            Judul = new DataGridViewTextBoxColumn();
            Pengarang = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Judul, Pengarang });
            dataGridView1.Location = new Point(429, 70);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(309, 230);
            dataGridView1.TabIndex = 0;
            // 
            // Judul
            // 
            Judul.HeaderText = "Column1";
            Judul.MinimumWidth = 8;
            Judul.Name = "Judul";
            Judul.Width = 150;
            // 
            // Pengarang
            // 
            Pengarang.HeaderText = "Pengarang";
            Pengarang.MinimumWidth = 8;
            Pengarang.Name = "Pengarang";
            Pengarang.Width = 150;
            // 
            // buku
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "buku";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Judul;
        private DataGridViewTextBoxColumn Pengarang;
    }
}