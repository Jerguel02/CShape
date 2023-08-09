namespace Dict
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
            txtWord = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            btnAddMean = new Button();
            btnRemoveMean = new Button();
            btnAddExp = new Button();
            btnRemoveExp = new Button();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 25);
            label1.Name = "label1";
            label1.Size = new Size(219, 31);
            label1.TabIndex = 0;
            label1.Text = "Từ Điển Anh Việt";
            // 
            // txtWord
            // 
            txtWord.Location = new Point(44, 76);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(446, 23);
            txtWord.TabIndex = 1;
            txtWord.TextChanged += txtWord_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(44, 122);
            button1.Name = "button1";
            button1.Size = new Size(89, 26);
            button1.TabIndex = 2;
            button1.Text = "Tra từ";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(163, 122);
            button2.Name = "button2";
            button2.Size = new Size(89, 26);
            button2.TabIndex = 3;
            button2.Text = "Xóa từ";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(280, 122);
            button3.Name = "button3";
            button3.Size = new Size(89, 26);
            button3.TabIndex = 4;
            button3.Text = "Thêm từ";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(401, 122);
            button4.Name = "button4";
            button4.Size = new Size(89, 26);
            button4.TabIndex = 5;
            button4.Text = "Sửa từ";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 183);
            label2.Name = "label2";
            label2.Size = new Size(89, 31);
            label2.TabIndex = 6;
            label2.Text = "Result";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 255);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(446, 76);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(44, 462);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(446, 76);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(44, 369);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(185, 23);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(44, 411);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(185, 23);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(44, 567);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(185, 23);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(44, 606);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(185, 23);
            textBox7.TabIndex = 12;
            // 
            // btnAddMean
            // 
            btnAddMean.Location = new Point(258, 369);
            btnAddMean.Name = "btnAddMean";
            btnAddMean.Size = new Size(89, 26);
            btnAddMean.TabIndex = 13;
            btnAddMean.Text = "Thêm nghĩa";
            btnAddMean.UseVisualStyleBackColor = true;
            // 
            // btnRemoveMean
            // 
            btnRemoveMean.Location = new Point(258, 411);
            btnRemoveMean.Name = "btnRemoveMean";
            btnRemoveMean.Size = new Size(89, 26);
            btnRemoveMean.TabIndex = 14;
            btnRemoveMean.Text = "Xóa nghĩa";
            btnRemoveMean.UseVisualStyleBackColor = true;
            // 
            // btnAddExp
            // 
            btnAddExp.Location = new Point(258, 564);
            btnAddExp.Name = "btnAddExp";
            btnAddExp.Size = new Size(89, 26);
            btnAddExp.TabIndex = 15;
            btnAddExp.Text = "Thêm ví dụ";
            btnAddExp.UseVisualStyleBackColor = true;
            // 
            // btnRemoveExp
            // 
            btnRemoveExp.Location = new Point(258, 606);
            btnRemoveExp.Name = "btnRemoveExp";
            btnRemoveExp.Size = new Size(89, 26);
            btnRemoveExp.TabIndex = 16;
            btnRemoveExp.Text = "Xóa ví dụ";
            btnRemoveExp.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(372, 217);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(118, 23);
            textBox8.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1252, 656);
            Controls.Add(textBox8);
            Controls.Add(btnRemoveExp);
            Controls.Add(btnAddExp);
            Controls.Add(btnRemoveMean);
            Controls.Add(btnAddMean);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtWord);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Dictionary";
            Load += Form1_Load;
            TextChanged += Form1_TextChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWord;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button btnAddMean;
        private Button btnRemoveMean;
        private Button btnAddExp;
        private Button btnRemoveExp;
        private TextBox textBox8;
    }
}