namespace StackLL
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
            txtAdd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtKQ = new TextBox();
            btnPush = new Button();
            btnPop = new Button();
            btnPeek = new Button();
            button4 = new Button();
            button5 = new Button();
            txtPeek = new TextBox();
            label3 = new Label();
            sizelbl = new Label();
            SuspendLayout();
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(104, 30);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(100, 23);
            txtAdd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 34);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Giá trị cần thêm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 173);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "StackLinkedList";
            // 
            // txtKQ
            // 
            txtKQ.Location = new Point(104, 170);
            txtKQ.Name = "txtKQ";
            txtKQ.Size = new Size(514, 23);
            txtKQ.TabIndex = 3;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(235, 30);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(75, 23);
            btnPush.TabIndex = 4;
            btnPush.Text = "Push";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(344, 30);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(75, 23);
            btnPop.TabIndex = 5;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(453, 30);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(75, 23);
            btnPeek.TabIndex = 6;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // button4
            // 
            button4.Location = new Point(570, 30);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(646, 170);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 8;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // txtPeek
            // 
            txtPeek.Location = new Point(104, 220);
            txtPeek.Name = "txtPeek";
            txtPeek.Size = new Size(514, 23);
            txtPeek.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 223);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 9;
            label3.Text = "Peek";
            // 
            // sizelbl
            // 
            sizelbl.AutoSize = true;
            sizelbl.Location = new Point(12, 124);
            sizelbl.Name = "sizelbl";
            sizelbl.Size = new Size(32, 15);
            sizelbl.TabIndex = 11;
            sizelbl.Text = "label";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sizelbl);
            Controls.Add(txtPeek);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(btnPeek);
            Controls.Add(btnPop);
            Controls.Add(btnPush);
            Controls.Add(txtKQ);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdd;
        private Label label1;
        private Label label2;
        private TextBox txtKQ;
        private Button btnPush;
        private Button btnPop;
        private Button btnPeek;
        private Button button4;
        private Button button5;
        private TextBox txtPeek;
        private Label label3;
        private Label sizelbl;
    }
}