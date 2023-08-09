namespace DEQue
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
            btnClear = new Button();
            label1 = new Label();
            txtAdd = new TextBox();
            btnAddFirst = new Button();
            btnAddLast = new Button();
            btnRemoveFirst = new Button();
            btnRemoveLast = new Button();
            btnFirst = new Button();
            btnLast = new Button();
            lblSize = new Label();
            txtDEQue = new TextBox();
            label2 = new Label();
            txtFirst = new TextBox();
            label3 = new Label();
            txtLast = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Location = new Point(269, 29);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 0;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 33);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Giá trị thêm vào";
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(134, 30);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(100, 23);
            txtAdd.TabIndex = 2;
            // 
            // btnAddFirst
            // 
            btnAddFirst.Location = new Point(363, 29);
            btnAddFirst.Name = "btnAddFirst";
            btnAddFirst.Size = new Size(75, 23);
            btnAddFirst.TabIndex = 3;
            btnAddFirst.Text = "AddFirst";
            btnAddFirst.UseVisualStyleBackColor = true;
            btnAddFirst.Click += btnAddFirst_Click;
            // 
            // btnAddLast
            // 
            btnAddLast.Location = new Point(455, 29);
            btnAddLast.Name = "btnAddLast";
            btnAddLast.Size = new Size(75, 23);
            btnAddLast.TabIndex = 4;
            btnAddLast.Text = "AddLast";
            btnAddLast.UseVisualStyleBackColor = true;
            btnAddLast.Click += btnAddLast_Click;
            // 
            // btnRemoveFirst
            // 
            btnRemoveFirst.Location = new Point(269, 81);
            btnRemoveFirst.Name = "btnRemoveFirst";
            btnRemoveFirst.Size = new Size(125, 23);
            btnRemoveFirst.TabIndex = 5;
            btnRemoveFirst.Text = "Remove First";
            btnRemoveFirst.UseVisualStyleBackColor = true;
            btnRemoveFirst.Click += btnRemoveFirst_Click;
            // 
            // btnRemoveLast
            // 
            btnRemoveLast.Location = new Point(400, 81);
            btnRemoveLast.Name = "btnRemoveLast";
            btnRemoveLast.Size = new Size(130, 23);
            btnRemoveLast.TabIndex = 6;
            btnRemoveLast.Text = "Remove Last";
            btnRemoveLast.UseVisualStyleBackColor = true;
            btnRemoveLast.Click += btnRemoveLast_Click;
            // 
            // btnFirst
            // 
            btnFirst.Location = new Point(363, 131);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(75, 23);
            btnFirst.TabIndex = 7;
            btnFirst.Text = "First";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnLast
            // 
            btnLast.Location = new Point(455, 131);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(75, 23);
            btnLast.TabIndex = 8;
            btnLast.Text = "Last";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(25, 202);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(27, 15);
            lblSize.TabIndex = 9;
            lblSize.Text = "Size";
            // 
            // txtDEQue
            // 
            txtDEQue.Location = new Point(134, 256);
            txtDEQue.Name = "txtDEQue";
            txtDEQue.Size = new Size(536, 23);
            txtDEQue.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 259);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 10;
            label2.Text = "DEQue";
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(134, 310);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(100, 23);
            txtFirst.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 313);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 12;
            label3.Text = "First";
            // 
            // txtLast
            // 
            txtLast.Location = new Point(134, 354);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(100, 23);
            txtLast.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 357);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 14;
            label4.Text = "Last";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLast);
            Controls.Add(label4);
            Controls.Add(txtFirst);
            Controls.Add(label3);
            Controls.Add(txtDEQue);
            Controls.Add(label2);
            Controls.Add(lblSize);
            Controls.Add(btnLast);
            Controls.Add(btnFirst);
            Controls.Add(btnRemoveLast);
            Controls.Add(btnRemoveFirst);
            Controls.Add(btnAddLast);
            Controls.Add(btnAddFirst);
            Controls.Add(txtAdd);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClear;
        private Label label1;
        private TextBox txtAdd;
        private Button btnAddFirst;
        private Button btnAddLast;
        private Button btnRemoveFirst;
        private Button btnRemoveLast;
        private Button btnFirst;
        private Button btnLast;
        private Label lblSize;
        private TextBox txtDEQue;
        private Label label2;
        private TextBox txtFirst;
        private Label label3;
        private TextBox txtLast;
        private Label label4;
    }
}