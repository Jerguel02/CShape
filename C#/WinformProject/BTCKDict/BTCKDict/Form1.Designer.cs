namespace BTCKDict
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
            btnSearch = new Button();
            btnDelWord = new Button();
            btnAddWord = new Button();
            txtMean = new TextBox();
            txtEx = new TextBox();
            txtAddMean = new TextBox();
            txtRemoveMean = new TextBox();
            txtRemoveEx = new TextBox();
            txtAddEx = new TextBox();
            btnAddMean = new Button();
            btnRemoveMean = new Button();
            btnAddEx = new Button();
            btnRemoveEx = new Button();
            Result = new Label();
            txtTuLoai = new TextBox();
            WordList = new ListView();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 18);
            label1.Name = "label1";
            label1.Size = new Size(216, 31);
            label1.TabIndex = 0;
            label1.Text = "Từ điển Anh-Việt";
            label1.Click += label1_Click;
            // 
            // txtWord
            // 
            txtWord.Location = new Point(57, 74);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(454, 23);
            txtWord.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(57, 122);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tra Cứu";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnDelWord
            // 
            btnDelWord.Location = new Point(161, 122);
            btnDelWord.Name = "btnDelWord";
            btnDelWord.Size = new Size(75, 23);
            btnDelWord.TabIndex = 3;
            btnDelWord.Text = "Xóa từ";
            btnDelWord.UseVisualStyleBackColor = true;
            // 
            // btnAddWord
            // 
            btnAddWord.Location = new Point(262, 122);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(75, 23);
            btnAddWord.TabIndex = 4;
            btnAddWord.Text = "Thêm từ";
            btnAddWord.UseVisualStyleBackColor = true;
            // 
            // txtMean
            // 
            txtMean.Location = new Point(57, 239);
            txtMean.Multiline = true;
            txtMean.Name = "txtMean";
            txtMean.Size = new Size(503, 125);
            txtMean.TabIndex = 6;
            // 
            // txtEx
            // 
            txtEx.Location = new Point(57, 482);
            txtEx.Multiline = true;
            txtEx.Name = "txtEx";
            txtEx.Size = new Size(503, 125);
            txtEx.TabIndex = 7;
            // 
            // txtAddMean
            // 
            txtAddMean.Location = new Point(57, 393);
            txtAddMean.Name = "txtAddMean";
            txtAddMean.Size = new Size(388, 23);
            txtAddMean.TabIndex = 8;
            // 
            // txtRemoveMean
            // 
            txtRemoveMean.Location = new Point(57, 435);
            txtRemoveMean.Name = "txtRemoveMean";
            txtRemoveMean.Size = new Size(388, 23);
            txtRemoveMean.TabIndex = 9;
            // 
            // txtRemoveEx
            // 
            txtRemoveEx.Location = new Point(57, 670);
            txtRemoveEx.Name = "txtRemoveEx";
            txtRemoveEx.Size = new Size(388, 23);
            txtRemoveEx.TabIndex = 11;
            // 
            // txtAddEx
            // 
            txtAddEx.Location = new Point(57, 628);
            txtAddEx.Name = "txtAddEx";
            txtAddEx.Size = new Size(388, 23);
            txtAddEx.TabIndex = 10;
            // 
            // btnAddMean
            // 
            btnAddMean.Location = new Point(468, 393);
            btnAddMean.Name = "btnAddMean";
            btnAddMean.Size = new Size(92, 23);
            btnAddMean.TabIndex = 12;
            btnAddMean.Text = "Thêm nghĩa";
            btnAddMean.UseVisualStyleBackColor = true;
            // 
            // btnRemoveMean
            // 
            btnRemoveMean.Location = new Point(468, 434);
            btnRemoveMean.Name = "btnRemoveMean";
            btnRemoveMean.Size = new Size(92, 23);
            btnRemoveMean.TabIndex = 13;
            btnRemoveMean.Text = "Xóa nghĩa";
            btnRemoveMean.UseVisualStyleBackColor = true;
            // 
            // btnAddEx
            // 
            btnAddEx.Location = new Point(468, 627);
            btnAddEx.Name = "btnAddEx";
            btnAddEx.Size = new Size(92, 23);
            btnAddEx.TabIndex = 14;
            btnAddEx.Text = "Thêm VD";
            btnAddEx.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEx
            // 
            btnRemoveEx.Location = new Point(468, 670);
            btnRemoveEx.Name = "btnRemoveEx";
            btnRemoveEx.Size = new Size(92, 23);
            btnRemoveEx.TabIndex = 15;
            btnRemoveEx.Text = "Xóa VD";
            btnRemoveEx.UseVisualStyleBackColor = true;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Result.Location = new Point(57, 184);
            Result.Name = "Result";
            Result.Size = new Size(89, 31);
            Result.TabIndex = 16;
            Result.Text = "Result";
            // 
            // txtTuLoai
            // 
            txtTuLoai.Location = new Point(424, 192);
            txtTuLoai.Name = "txtTuLoai";
            txtTuLoai.Size = new Size(136, 23);
            txtTuLoai.TabIndex = 17;
            // 
            // WordList
            // 
            WordList.Location = new Point(878, 122);
            WordList.Name = "WordList";
            WordList.Size = new Size(429, 571);
            WordList.TabIndex = 18;
            WordList.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(878, 74);
            label2.Name = "label2";
            label2.Size = new Size(128, 31);
            label2.TabIndex = 19;
            label2.Text = "WordList";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1319, 734);
            Controls.Add(label2);
            Controls.Add(WordList);
            Controls.Add(txtTuLoai);
            Controls.Add(Result);
            Controls.Add(btnRemoveEx);
            Controls.Add(btnAddEx);
            Controls.Add(btnRemoveMean);
            Controls.Add(btnAddMean);
            Controls.Add(txtRemoveEx);
            Controls.Add(txtAddEx);
            Controls.Add(txtRemoveMean);
            Controls.Add(txtAddMean);
            Controls.Add(txtEx);
            Controls.Add(txtMean);
            Controls.Add(btnAddWord);
            Controls.Add(btnDelWord);
            Controls.Add(btnSearch);
            Controls.Add(txtWord);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWord;
        private Button btnSearch;
        private Button btnDelWord;
        private Button btnAddWord;
        private TextBox txtMean;
        private TextBox txtEx;
        private TextBox txtAddMean;
        private TextBox txtRemoveMean;
        private TextBox txtRemoveEx;
        private TextBox txtAddEx;
        private Button btnAddMean;
        private Button btnRemoveMean;
        private Button btnAddEx;
        private Button btnRemoveEx;
        private Label Result;
        private TextBox txtTuLoai;
        private ListView WordList;
        private Label label2;
    }
}