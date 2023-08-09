namespace Stack
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
            Push = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            txtKQ = new TextBox();
            btnclr = new Button();
            button1 = new Button();
            Sizelbl = new Label();
            button4 = new Button();
            peekelement = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 26);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Giá trị cần thêm:";
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(131, 18);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(100, 23);
            txtAdd.TabIndex = 1;
            // 
            // Push
            // 
            Push.Location = new Point(379, 18);
            Push.Name = "Push";
            Push.Size = new Size(75, 23);
            Push.TabIndex = 2;
            Push.Text = "Push";
            Push.UseVisualStyleBackColor = true;
            Push.Click += Push_Click;
            // 
            // button2
            // 
            button2.Location = new Point(474, 18);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Pop";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(264, 75);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Peek";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 198);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "Stack:";
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(99, 195);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(603, 23);
            txtKQ.TabIndex = 6;
            // 
            // btnclr
            // 
            btnclr.Location = new Point(264, 18);
            btnclr.Name = "btnclr";
            btnclr.Size = new Size(75, 23);
            btnclr.TabIndex = 7;
            btnclr.Text = "Clear";
            btnclr.UseVisualStyleBackColor = true;
            btnclr.Click += btnclr_Click;
            // 
            // button1
            // 
            button1.Location = new Point(713, 194);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Sizelbl
            // 
            Sizelbl.AutoSize = true;
            Sizelbl.Location = new Point(31, 147);
            Sizelbl.Name = "Sizelbl";
            Sizelbl.Size = new Size(27, 15);
            Sizelbl.TabIndex = 9;
            Sizelbl.Text = "Size";
            Sizelbl.Click += Sizelbl_Click;
            // 
            // button4
            // 
            button4.Location = new Point(713, 232);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 12;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // peekelement
            // 
            peekelement.Location = new Point(99, 233);
            peekelement.Name = "peekelement";
            peekelement.Size = new Size(603, 23);
            peekelement.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 236);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 10;
            label3.Text = "Lấy dữ liệu:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(peekelement);
            Controls.Add(label3);
            Controls.Add(Sizelbl);
            Controls.Add(button1);
            Controls.Add(btnclr);
            Controls.Add(txtKQ);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Push);
            Controls.Add(txtAdd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdd;
        private Button Push;
        private Button button2;
        private Button button3;
        private Label label2;
        private TextBox txtKQ;
        private Button btnclr;
        private Button button1;
        private Label Sizelbl;
        private Button button4;
        private TextBox peekelement;
        private Label label3;
    }
}