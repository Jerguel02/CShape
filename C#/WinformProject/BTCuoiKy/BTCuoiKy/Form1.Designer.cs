namespace BTCuoiKy
{
    partial class Dictionary
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
            SearchBtn = new Button();
            AddBtn = new Button();
            DeletaBtn = new Button();
            ModifyBtn = new Button();
            SearchBox = new TextBox();
            MeaningBox = new TextBox();
            ExamplesBox = new TextBox();
            button5 = new Button();
            RemoveMeaningBtn = new Button();
            RemoveExampleBtn = new Button();
            button8 = new Button();
            NewMeaningBox = new TextBox();
            RemoveMeaningIndex = new TextBox();
            textBox7 = new TextBox();
            RemoveExampleIndex = new TextBox();
            TypeBox = new TextBox();
            NewWordBox = new TextBox();
            WordBox = new ListView();
            LightBarListBox = new ListBox();
            SuspendLayout();
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(48, 113);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 23);
            SearchBtn.TabIndex = 0;
            SearchBtn.Text = "Tra từ";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += button1_Click;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(166, 113);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "Thêm mới";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // DeletaBtn
            // 
            DeletaBtn.Location = new Point(290, 113);
            DeletaBtn.Name = "DeletaBtn";
            DeletaBtn.Size = new Size(75, 23);
            DeletaBtn.TabIndex = 2;
            DeletaBtn.Text = "Xóa từ";
            DeletaBtn.UseVisualStyleBackColor = true;
            // 
            // ModifyBtn
            // 
            ModifyBtn.Location = new Point(591, 113);
            ModifyBtn.Name = "ModifyBtn";
            ModifyBtn.Size = new Size(75, 23);
            ModifyBtn.TabIndex = 3;
            ModifyBtn.Text = "Sửa từ";
            ModifyBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(48, 43);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(616, 23);
            SearchBox.TabIndex = 4;
            SearchBox.Leave += SearchBox_Leave;
            // 
            // MeaningBox
            // 
            MeaningBox.Location = new Point(50, 380);
            MeaningBox.Multiline = true;
            MeaningBox.Name = "MeaningBox";
            MeaningBox.Size = new Size(698, 138);
            MeaningBox.TabIndex = 5;
            // 
            // ExamplesBox
            // 
            ExamplesBox.Location = new Point(50, 524);
            ExamplesBox.Multiline = true;
            ExamplesBox.Name = "ExamplesBox";
            ExamplesBox.Size = new Size(698, 138);
            ExamplesBox.TabIndex = 6;
            // 
            // button5
            // 
            button5.Location = new Point(446, 180);
            button5.Name = "button5";
            button5.Size = new Size(109, 23);
            button5.TabIndex = 8;
            button5.Text = "Thêm nghĩa";
            button5.UseVisualStyleBackColor = true;
            // 
            // RemoveMeaningBtn
            // 
            RemoveMeaningBtn.Location = new Point(446, 218);
            RemoveMeaningBtn.Name = "RemoveMeaningBtn";
            RemoveMeaningBtn.Size = new Size(109, 23);
            RemoveMeaningBtn.TabIndex = 9;
            RemoveMeaningBtn.Text = "Xóa nghĩa";
            RemoveMeaningBtn.UseVisualStyleBackColor = true;
            // 
            // RemoveExampleBtn
            // 
            RemoveExampleBtn.Location = new Point(446, 295);
            RemoveExampleBtn.Name = "RemoveExampleBtn";
            RemoveExampleBtn.Size = new Size(109, 23);
            RemoveExampleBtn.TabIndex = 11;
            RemoveExampleBtn.Text = "Xóa VD";
            RemoveExampleBtn.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(446, 257);
            button8.Name = "button8";
            button8.Size = new Size(109, 23);
            button8.TabIndex = 10;
            button8.Text = "Thêm VD";
            button8.UseVisualStyleBackColor = true;
            // 
            // NewMeaningBox
            // 
            NewMeaningBox.Location = new Point(50, 180);
            NewMeaningBox.Name = "NewMeaningBox";
            NewMeaningBox.Size = new Size(390, 23);
            NewMeaningBox.TabIndex = 12;
            // 
            // RemoveMeaningIndex
            // 
            RemoveMeaningIndex.Location = new Point(50, 218);
            RemoveMeaningIndex.Name = "RemoveMeaningIndex";
            RemoveMeaningIndex.Size = new Size(390, 23);
            RemoveMeaningIndex.TabIndex = 13;
            RemoveMeaningIndex.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(50, 257);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(390, 23);
            textBox7.TabIndex = 14;
            // 
            // RemoveExampleIndex
            // 
            RemoveExampleIndex.Location = new Point(50, 295);
            RemoveExampleIndex.Name = "RemoveExampleIndex";
            RemoveExampleIndex.Size = new Size(390, 23);
            RemoveExampleIndex.TabIndex = 15;
            // 
            // TypeBox
            // 
            TypeBox.Location = new Point(48, 351);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(390, 23);
            TypeBox.TabIndex = 16;
            // 
            // NewWordBox
            // 
            NewWordBox.Location = new Point(414, 113);
            NewWordBox.Name = "NewWordBox";
            NewWordBox.Size = new Size(171, 23);
            NewWordBox.TabIndex = 17;
            // 
            // WordBox
            // 
            WordBox.Location = new Point(933, 82);
            WordBox.Name = "WordBox";
            WordBox.Size = new Size(375, 580);
            WordBox.TabIndex = 18;
            WordBox.UseCompatibleStateImageBehavior = false;
            // 
            // LightBarListBox
            // 
            LightBarListBox.FormattingEnabled = true;
            LightBarListBox.ItemHeight = 15;
            LightBarListBox.Location = new Point(121, 82);
            LightBarListBox.Name = "LightBarListBox";
            LightBarListBox.Size = new Size(120, 19);
            LightBarListBox.TabIndex = 19;
            // 
            // Dictionary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 667);
            Controls.Add(LightBarListBox);
            Controls.Add(WordBox);
            Controls.Add(NewWordBox);
            Controls.Add(TypeBox);
            Controls.Add(RemoveExampleIndex);
            Controls.Add(textBox7);
            Controls.Add(RemoveMeaningIndex);
            Controls.Add(NewMeaningBox);
            Controls.Add(RemoveExampleBtn);
            Controls.Add(button8);
            Controls.Add(RemoveMeaningBtn);
            Controls.Add(button5);
            Controls.Add(ExamplesBox);
            Controls.Add(MeaningBox);
            Controls.Add(SearchBox);
            Controls.Add(ModifyBtn);
            Controls.Add(DeletaBtn);
            Controls.Add(AddBtn);
            Controls.Add(SearchBtn);
            Name = "Dictionary";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SearchBtn;
        private Button AddBtn;
        private Button DeletaBtn;
        private Button ModifyBtn;
        private TextBox SearchBox;
        private TextBox MeaningBox;
        private TextBox ExamplesBox;
        private Button button5;
        private Button RemoveMeaningBtn;
        private Button RemoveExampleBtn;
        private Button button8;
        private TextBox NewMeaningBox;
        private TextBox RemoveMeaningIndex;
        private TextBox textBox7;
        private TextBox RemoveExampleIndex;
        private TextBox TypeBox;
        private TextBox NewWordBox;
        private ListView WordBox;
        private ListBox LightBarListBox;
    }
}