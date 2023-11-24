namespace MealeyMachine
{
    partial class Form2
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
            button1 = new Button();
            table = new DataGridView();
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)table).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(389, 20);
            label1.TabIndex = 0;
            label1.Text = "Bilgileri Eksiksiz Girerek Tabloyu Gönder Butonuna Basınız";
            // 
            // button1
            // 
            button1.Location = new Point(707, 9);
            button1.Name = "button1";
            button1.Size = new Size(209, 29);
            button1.TabIndex = 1;
            button1.Text = "Tabloyu Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // table
            // 
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            table.BackgroundColor = SystemColors.Window;
            table.BorderStyle = BorderStyle.Fixed3D;
            table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            table.Location = new Point(12, 54);
            table.Name = "table";
            table.RowHeadersWidth = 51;
            table.RowTemplate.Height = 29;
            table.Size = new Size(904, 463);
            table.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 542);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 3;
            label2.Text = "Text:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 535);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 27);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(297, 533);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Çalıştır";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 582);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(904, 150);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 744);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(table);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private DataGridView table;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private RichTextBox richTextBox1;
    }
}