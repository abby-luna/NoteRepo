namespace NotedByAbbyAnna
{
    partial class CreateUpdateNote
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(155, 8);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 32);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(155, 61);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(576, 32);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(616, 548);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(115, 46);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 11);
            label1.Name = "label1";
            label1.Size = new Size(128, 26);
            label1.TabIndex = 4;
            label1.Text = "Enter an ID ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 69);
            label2.Name = "label2";
            label2.Size = new Size(58, 26);
            label2.TabIndex = 5;
            label2.Text = "Title:";
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Microsoft Sans Serif", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(155, 162);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(576, 378);
            richTextBox1.TabIndex = 6;
            richTextBox1.Text = "";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(495, 548);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(115, 46);
            button2.TabIndex = 7;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(68, 166);
            label3.Name = "label3";
            label3.Size = new Size(68, 26);
            label3.TabIndex = 8;
            label3.Text = "Body:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 116);
            label4.Name = "label4";
            label4.Size = new Size(106, 26);
            label4.TabIndex = 9;
            label4.Text = "Catogory:";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(155, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 36);
            comboBox1.TabIndex = 10;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // CreateUpdateNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 609);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateUpdateNote";
            Text = "CreateUpdateNote";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Button button2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
    }
}