namespace FoodApp
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(529, 84);
            label1.Name = "label1";
            label1.Size = new Size(145, 60);
            label1.TabIndex = 1;
            label1.Text = "Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 185);
            label2.Name = "label2";
            label2.Size = new Size(174, 41);
            label2.TabIndex = 2;
            label2.Text = "Food name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 254);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(413, 47);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(53, 393);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(416, 47);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 324);
            label3.Name = "label3";
            label3.Size = new Size(123, 41);
            label3.TabIndex = 4;
            label3.Text = "Porsion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 478);
            label4.Name = "label4";
            label4.Size = new Size(180, 41);
            label4.TabIndex = 6;
            label4.Text = "Description";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(53, 546);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(416, 159);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(529, 381);
            button1.Name = "button1";
            button1.Size = new Size(186, 94);
            button1.TabIndex = 8;
            button1.Text = "Order now";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(747, 290);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(443, 415);
            dataGridView1.TabIndex = 9;
            // 
            // button2
            // 
            button2.Location = new Point(865, 215);
            button2.Name = "button2";
            button2.Size = new Size(186, 53);
            button2.TabIndex = 10;
            button2.Text = "Show";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(1066, 30);
            button3.Name = "button3";
            button3.Size = new Size(124, 77);
            button3.TabIndex = 11;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 64, 0);
            ClientSize = new Size(1225, 759);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
    }
}