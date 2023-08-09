namespace Trees
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
            lblKQ = new Label();
            label2 = new Label();
            txtAdd = new TextBox();
            Insert = new Button();
            button2 = new Button();
            radioInorder = new RadioButton();
            RadioPre = new RadioButton();
            radioPost = new RadioButton();
            radioLevel = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 88);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Trees Traversal:";
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblKQ.Location = new Point(133, 88);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(42, 15);
            lblKQ.TabIndex = 2;
            lblKQ.Text = "Result";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 43);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Element:";
            // 
            // txtAdd
            // 
            txtAdd.Location = new Point(98, 40);
            txtAdd.Name = "txtAdd";
            txtAdd.Size = new Size(100, 23);
            txtAdd.TabIndex = 4;
            txtAdd.TextChanged += txtAdd_TextChanged;
            // 
            // Insert
            // 
            Insert.Location = new Point(231, 39);
            Insert.Name = "Insert";
            Insert.Size = new Size(75, 23);
            Insert.TabIndex = 5;
            Insert.Text = "Add";
            Insert.UseVisualStyleBackColor = true;
            Insert.Click += Insert_Click;
            // 
            // button2
            // 
            button2.Location = new Point(334, 39);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Clr";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioInorder
            // 
            radioInorder.AutoSize = true;
            radioInorder.Location = new Point(503, 10);
            radioInorder.Name = "radioInorder";
            radioInorder.Size = new Size(66, 19);
            radioInorder.TabIndex = 7;
            radioInorder.TabStop = true;
            radioInorder.Text = "In order";
            radioInorder.UseVisualStyleBackColor = true;
            radioInorder.CheckedChanged += radioInorder_CheckedChanged;
            // 
            // RadioPre
            // 
            RadioPre.AutoSize = true;
            RadioPre.Location = new Point(503, 35);
            RadioPre.Name = "RadioPre";
            RadioPre.Size = new Size(73, 19);
            RadioPre.TabIndex = 8;
            RadioPre.TabStop = true;
            RadioPre.Text = "Pre order";
            RadioPre.UseVisualStyleBackColor = true;
            RadioPre.CheckedChanged += RadioPre_CheckedChanged;
            // 
            // radioPost
            // 
            radioPost.AutoSize = true;
            radioPost.Location = new Point(503, 60);
            radioPost.Name = "radioPost";
            radioPost.Size = new Size(74, 19);
            radioPost.TabIndex = 9;
            radioPost.TabStop = true;
            radioPost.Text = "Post over";
            radioPost.UseVisualStyleBackColor = true;
            radioPost.CheckedChanged += radioPost_CheckedChanged;
            // 
            // radioLevel
            // 
            radioLevel.AutoSize = true;
            radioLevel.Location = new Point(503, 86);
            radioLevel.Name = "radioLevel";
            radioLevel.Size = new Size(86, 19);
            radioLevel.TabIndex = 10;
            radioLevel.TabStop = true;
            radioLevel.Text = "Level  order";
            radioLevel.UseVisualStyleBackColor = true;
            radioLevel.CheckedChanged += radioLevel_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 133);
            Controls.Add(radioLevel);
            Controls.Add(radioPost);
            Controls.Add(RadioPre);
            Controls.Add(radioInorder);
            Controls.Add(button2);
            Controls.Add(Insert);
            Controls.Add(txtAdd);
            Controls.Add(label2);
            Controls.Add(lblKQ);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Trees";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblKQ;
        private Label label2;
        private TextBox txtAdd;
        private Button Insert;
        private Button button2;
        private RadioButton radioInorder;
        private RadioButton RadioPre;
        private RadioButton radioPost;
        private RadioButton radioLevel;
    }
}