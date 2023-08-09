namespace Queue
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
            txtAdd = new TextBox();
            label3 = new Label();
            txtQueue = new TextBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            txtFirst = new TextBox();
            button2 = new Button();
            Sizelbl = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 0;
            label1.Text = "Số cần Enqueue";
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(109, 25);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(100, 23);
            txtAdd.TabIndex = 1;
            txtAdd.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 160);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 4;
            label3.Text = "Queue";
            // 
            // txtQueue
            // 
            txtQueue.Location = new Point(82, 157);
            txtQueue.Name = "txtQueue";
            txtQueue.Size = new Size(550, 23);
            txtQueue.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(381, 24);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(638, 156);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(300, 80);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 9;
            button4.Text = "Dequeue";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(300, 24);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 10;
            button5.Text = "Enqueue";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 221);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 11;
            label2.Text = "First";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(82, 213);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(223, 23);
            txtFirst.TabIndex = 12;
            // 
            // button2
            // 
            button2.Location = new Point(381, 80);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "First";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Sizelbl
            // 
            Sizelbl.AutoSize = true;
            Sizelbl.Location = new Point(12, 271);
            Sizelbl.Name = "Sizelbl";
            Sizelbl.Size = new Size(27, 15);
            Sizelbl.TabIndex = 14;
            Sizelbl.Text = "Size";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Sizelbl);
            Controls.Add(button2);
            Controls.Add(txtFirst);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(txtQueue);
            Controls.Add(label3);
            Controls.Add(txtAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = " ";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdd;
        private Label label3;
        private TextBox txtQueue;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label2;
        private TextBox txtFirst;
        private Button button2;
        private Label Sizelbl;
    }
}