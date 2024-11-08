namespace UTS_PBO.Views
{
    partial class Register
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(198, 62);
            label1.Name = "label1";
            label1.Size = new Size(393, 45);
            label1.TabIndex = 0;
            label1.Text = "Silahkan Daftarkan Akun";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 154);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 31);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(364, 126);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(349, 188);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(295, 216);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 31);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(353, 250);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(295, 278);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 31);
            textBox3.TabIndex = 6;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
    }
}