namespace blackJack
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            cards_left = new Label();
            label2 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(33, 30);
            button1.Name = "button1";
            button1.Size = new Size(94, 67);
            button1.TabIndex = 0;
            button1.Text = "StartGame";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(33, 103);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(410, 217);
            richTextBox1.TabIndex = 7;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(133, 34);
            button2.Name = "button2";
            button2.Size = new Size(112, 63);
            button2.TabIndex = 6;
            button2.Text = "Shuffle";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(251, 34);
            button3.Name = "button3";
            button3.Size = new Size(112, 67);
            button3.TabIndex = 3;
            button3.Text = "Deal cards";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            // 
            // cards_left
            // 
            cards_left.AutoSize = true;
            cards_left.Location = new Point(505, 37);
            cards_left.Name = "cards_left";
            cards_left.Size = new Size(0, 20);
            cards_left.TabIndex = 5;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Location = new Point(369, 30);
            button4.Name = "button4";
            button4.Size = new Size(112, 67);
            button4.TabIndex = 8;
            button4.Text = "Stand";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(label2);
            Controls.Add(cards_left);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label cards_left;
        private Label label2;
        private Button button4;
    }
}
