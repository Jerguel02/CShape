namespace CSet_BitArray
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
            label2 = new Label();
            label3 = new Label();
            radiobtnUnion = new RadioButton();
            radiobtnIntersection = new RadioButton();
            radiobtnDifference = new RadioButton();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lblSetC = new Label();
            lblSetB = new Label();
            lblSetA = new Label();
            btnAddSetA = new Button();
            btnAddSetB = new Button();
            btnAddSetC = new Button();
            panelOptionFunc = new Panel();
            btnExecute = new Button();
            label7 = new Label();
            lblIsSubset = new Label();
            txtAddSetA = new TextBox();
            txtAddSetB = new TextBox();
            txtAddSetC = new TextBox();
            btnClrSetC = new Button();
            btnClrSetB = new Button();
            btnClrSetA = new Button();
            button5 = new Button();
            button6 = new Button();
            panelOptionSet = new Panel();
            radiobtnSetC = new RadioButton();
            radiobtnSetB = new RadioButton();
            radiobtnSetA = new RadioButton();
            panel3 = new Panel();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            txtRemoveC = new TextBox();
            txtRemoveB = new TextBox();
            txtRemoveA = new TextBox();
            btnRemoveC = new Button();
            btnRemoveB = new Button();
            btnRemoveA = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            btnClrReC = new Button();
            btnClrReB = new Button();
            btnCLrReA = new Button();
            panelOptionFunc.SuspendLayout();
            panelOptionSet.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 40);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Add SetA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 77);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Add SetB:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 114);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Add SetC:";
            // 
            // radiobtnUnion
            // 
            radiobtnUnion.AutoSize = true;
            radiobtnUnion.Location = new Point(13, 18);
            radiobtnUnion.Name = "radiobtnUnion";
            radiobtnUnion.Size = new Size(57, 19);
            radiobtnUnion.TabIndex = 3;
            radiobtnUnion.TabStop = true;
            radiobtnUnion.Text = "Union";
            radiobtnUnion.UseVisualStyleBackColor = true;
            radiobtnUnion.CheckedChanged += radiobtnUnion_CheckedChanged;
            // 
            // radiobtnIntersection
            // 
            radiobtnIntersection.AutoSize = true;
            radiobtnIntersection.Location = new Point(13, 64);
            radiobtnIntersection.Name = "radiobtnIntersection";
            radiobtnIntersection.Size = new Size(87, 19);
            radiobtnIntersection.TabIndex = 4;
            radiobtnIntersection.TabStop = true;
            radiobtnIntersection.Text = "Intersection";
            radiobtnIntersection.UseVisualStyleBackColor = true;
            // 
            // radiobtnDifference
            // 
            radiobtnDifference.AutoSize = true;
            radiobtnDifference.Location = new Point(13, 109);
            radiobtnDifference.Name = "radiobtnDifference";
            radiobtnDifference.Size = new Size(79, 19);
            radiobtnDifference.TabIndex = 5;
            radiobtnDifference.TabStop = true;
            radiobtnDifference.Text = "Difference";
            radiobtnDifference.UseVisualStyleBackColor = true;
            radiobtnDifference.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(192, 0, 0);
            label4.Location = new Point(459, 110);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 8;
            label4.Text = "SetC:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(459, 76);
            label5.Name = "label5";
            label5.Size = new Size(35, 15);
            label5.TabIndex = 7;
            label5.Text = "SetB:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(192, 0, 0);
            label6.Location = new Point(459, 39);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 6;
            label6.Text = "SetA:";
            // 
            // lblSetC
            // 
            lblSetC.AutoSize = true;
            lblSetC.Location = new Point(512, 110);
            lblSetC.Name = "lblSetC";
            lblSetC.Size = new Size(38, 15);
            lblSetC.TabIndex = 11;
            lblSetC.Text = "label7";
            // 
            // lblSetB
            // 
            lblSetB.AutoSize = true;
            lblSetB.Location = new Point(512, 76);
            lblSetB.Name = "lblSetB";
            lblSetB.Size = new Size(38, 15);
            lblSetB.TabIndex = 10;
            lblSetB.Text = "label8";
            // 
            // lblSetA
            // 
            lblSetA.AutoSize = true;
            lblSetA.Location = new Point(512, 39);
            lblSetA.Name = "lblSetA";
            lblSetA.Size = new Size(38, 15);
            lblSetA.TabIndex = 9;
            lblSetA.Text = "label9";
            // 
            // btnAddSetA
            // 
            btnAddSetA.Location = new Point(245, 36);
            btnAddSetA.Name = "btnAddSetA";
            btnAddSetA.Size = new Size(75, 23);
            btnAddSetA.TabIndex = 12;
            btnAddSetA.Text = "Add";
            btnAddSetA.UseVisualStyleBackColor = true;
            btnAddSetA.Click += btnAddSetA_Click;
            // 
            // btnAddSetB
            // 
            btnAddSetB.Location = new Point(246, 73);
            btnAddSetB.Name = "btnAddSetB";
            btnAddSetB.Size = new Size(75, 23);
            btnAddSetB.TabIndex = 13;
            btnAddSetB.Text = "Add";
            btnAddSetB.UseVisualStyleBackColor = true;
            btnAddSetB.Click += btnAddSetB_Click;
            // 
            // btnAddSetC
            // 
            btnAddSetC.Location = new Point(246, 110);
            btnAddSetC.Name = "btnAddSetC";
            btnAddSetC.Size = new Size(75, 23);
            btnAddSetC.TabIndex = 14;
            btnAddSetC.Text = "Add";
            btnAddSetC.UseVisualStyleBackColor = true;
            btnAddSetC.Click += btnAddSetC_Click;
            // 
            // panelOptionFunc
            // 
            panelOptionFunc.BorderStyle = BorderStyle.FixedSingle;
            panelOptionFunc.Controls.Add(radiobtnDifference);
            panelOptionFunc.Controls.Add(radiobtnIntersection);
            panelOptionFunc.Controls.Add(radiobtnUnion);
            panelOptionFunc.Location = new Point(22, 415);
            panelOptionFunc.Name = "panelOptionFunc";
            panelOptionFunc.Size = new Size(215, 145);
            panelOptionFunc.TabIndex = 15;
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(364, 475);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(75, 23);
            btnExecute.TabIndex = 16;
            btnExecute.Text = "Execute";
            btnExecute.UseVisualStyleBackColor = true;
            btnExecute.Click += btnExecute_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(417, 354);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 16;
            label7.Text = "IsSubset Check:";
            // 
            // lblIsSubset
            // 
            lblIsSubset.AutoSize = true;
            lblIsSubset.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblIsSubset.Location = new Point(512, 354);
            lblIsSubset.Name = "lblIsSubset";
            lblIsSubset.Size = new Size(39, 15);
            lblIsSubset.TabIndex = 17;
            lblIsSubset.Text = "label7";
            // 
            // txtAddSetA
            // 
            txtAddSetA.Location = new Point(137, 36);
            txtAddSetA.Name = "txtAddSetA";
            txtAddSetA.Size = new Size(100, 23);
            txtAddSetA.TabIndex = 18;
            txtAddSetA.TextChanged += txtAddSetA_TextChanged;
            txtAddSetA.KeyPress += txtAddSetA_KeyPress;
            // 
            // txtAddSetB
            // 
            txtAddSetB.Location = new Point(138, 73);
            txtAddSetB.Name = "txtAddSetB";
            txtAddSetB.Size = new Size(100, 23);
            txtAddSetB.TabIndex = 19;
            txtAddSetB.TextChanged += txtAddSetB_TextChanged;
            txtAddSetB.KeyPress += txtAddSetB_KeyPress;
            // 
            // txtAddSetC
            // 
            txtAddSetC.Location = new Point(138, 110);
            txtAddSetC.Name = "txtAddSetC";
            txtAddSetC.Size = new Size(100, 23);
            txtAddSetC.TabIndex = 20;
            txtAddSetC.TextChanged += txtAddSetC_TextChanged;
            txtAddSetC.KeyPress += txtAddSetC_KeyPress;
            // 
            // btnClrSetC
            // 
            btnClrSetC.Location = new Point(327, 110);
            btnClrSetC.Name = "btnClrSetC";
            btnClrSetC.Size = new Size(75, 23);
            btnClrSetC.TabIndex = 23;
            btnClrSetC.Text = "Clear";
            btnClrSetC.UseVisualStyleBackColor = true;
            btnClrSetC.Click += btnClrSetC_Click;
            // 
            // btnClrSetB
            // 
            btnClrSetB.Location = new Point(327, 73);
            btnClrSetB.Name = "btnClrSetB";
            btnClrSetB.Size = new Size(75, 23);
            btnClrSetB.TabIndex = 22;
            btnClrSetB.Text = "Clear";
            btnClrSetB.UseVisualStyleBackColor = true;
            btnClrSetB.Click += btnClrSetB_Click;
            // 
            // btnClrSetA
            // 
            btnClrSetA.Location = new Point(327, 36);
            btnClrSetA.Name = "btnClrSetA";
            btnClrSetA.Size = new Size(75, 23);
            btnClrSetA.TabIndex = 21;
            btnClrSetA.Text = "Clear";
            btnClrSetA.UseVisualStyleBackColor = true;
            btnClrSetA.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(597, 520);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 27;
            button5.Text = "Quit";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(597, 491);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 26;
            button6.Text = "Restart";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panelOptionSet
            // 
            panelOptionSet.BorderStyle = BorderStyle.FixedSingle;
            panelOptionSet.Controls.Add(radiobtnSetC);
            panelOptionSet.Controls.Add(radiobtnSetB);
            panelOptionSet.Controls.Add(radiobtnSetA);
            panelOptionSet.Location = new Point(233, 415);
            panelOptionSet.Name = "panelOptionSet";
            panelOptionSet.Size = new Size(116, 145);
            panelOptionSet.TabIndex = 28;
            // 
            // radiobtnSetC
            // 
            radiobtnSetC.AutoSize = true;
            radiobtnSetC.Location = new Point(13, 111);
            radiobtnSetC.Name = "radiobtnSetC";
            radiobtnSetC.Size = new Size(49, 19);
            radiobtnSetC.TabIndex = 5;
            radiobtnSetC.TabStop = true;
            radiobtnSetC.Text = "SetC";
            radiobtnSetC.UseVisualStyleBackColor = true;
            radiobtnSetC.CheckedChanged += radiobtnSetC_CheckedChanged;
            // 
            // radiobtnSetB
            // 
            radiobtnSetB.AutoSize = true;
            radiobtnSetB.Location = new Point(13, 64);
            radiobtnSetB.Name = "radiobtnSetB";
            radiobtnSetB.Size = new Size(48, 19);
            radiobtnSetB.TabIndex = 4;
            radiobtnSetB.TabStop = true;
            radiobtnSetB.Text = "SetB";
            radiobtnSetB.UseVisualStyleBackColor = true;
            radiobtnSetB.CheckedChanged += radiobtnSetB_CheckedChanged;
            // 
            // radiobtnSetA
            // 
            radiobtnSetA.AutoSize = true;
            radiobtnSetA.Location = new Point(13, 18);
            radiobtnSetA.Name = "radiobtnSetA";
            radiobtnSetA.Size = new Size(49, 19);
            radiobtnSetA.TabIndex = 3;
            radiobtnSetA.TabStop = true;
            radiobtnSetA.Text = "SetA";
            radiobtnSetA.UseVisualStyleBackColor = true;
            radiobtnSetA.CheckedChanged += radiobtnSetA_CheckedChanged;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(radioButton4);
            panel3.Controls.Add(radioButton5);
            panel3.Controls.Add(radioButton1);
            panel3.Controls.Add(radioButton6);
            panel3.Controls.Add(radioButton2);
            panel3.Controls.Add(radioButton3);
            panel3.Location = new Point(22, 304);
            panel3.Name = "panel3";
            panel3.Size = new Size(355, 105);
            panel3.TabIndex = 29;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(231, 64);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(89, 19);
            radioButton4.TabIndex = 32;
            radioButton4.TabStop = true;
            radioButton4.Text = "SetC vs SetB";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(231, 18);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(90, 19);
            radioButton5.TabIndex = 31;
            radioButton5.TabStop = true;
            radioButton5.Text = "SetC vs SetA";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(122, 18);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(89, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "SetB vs SetC";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(122, 64);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(89, 19);
            radioButton6.TabIndex = 30;
            radioButton6.TabStop = true;
            radioButton6.Text = "SetB vs SetA";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(13, 64);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(90, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "SetA vs SetC";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(13, 18);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(89, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "SetA vs SetB";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged_1;
            // 
            // txtRemoveC
            // 
            txtRemoveC.Location = new Point(138, 219);
            txtRemoveC.Name = "txtRemoveC";
            txtRemoveC.Size = new Size(100, 23);
            txtRemoveC.TabIndex = 35;
            txtRemoveC.TextChanged += txtRemoveC_TextChanged;
            txtRemoveC.KeyPress += txtRemoveC_KeyPress;
            // 
            // txtRemoveB
            // 
            txtRemoveB.Location = new Point(138, 182);
            txtRemoveB.Name = "txtRemoveB";
            txtRemoveB.Size = new Size(100, 23);
            txtRemoveB.TabIndex = 34;
            txtRemoveB.TextChanged += txtRemoveB_TextChanged;
            txtRemoveB.KeyPress += txtRemoveB_KeyPress;
            // 
            // txtRemoveA
            // 
            txtRemoveA.Location = new Point(137, 145);
            txtRemoveA.Name = "txtRemoveA";
            txtRemoveA.Size = new Size(100, 23);
            txtRemoveA.TabIndex = 33;
            txtRemoveA.TextChanged += txtRemoveA_TextChanged;
            txtRemoveA.KeyPress += txtRemoveA_KeyPress;
            // 
            // btnRemoveC
            // 
            btnRemoveC.Location = new Point(246, 219);
            btnRemoveC.Name = "btnRemoveC";
            btnRemoveC.Size = new Size(75, 23);
            btnRemoveC.TabIndex = 32;
            btnRemoveC.Text = "Remove";
            btnRemoveC.UseVisualStyleBackColor = true;
            btnRemoveC.Click += button1_Click_1;
            // 
            // btnRemoveB
            // 
            btnRemoveB.Location = new Point(246, 182);
            btnRemoveB.Name = "btnRemoveB";
            btnRemoveB.Size = new Size(75, 23);
            btnRemoveB.TabIndex = 31;
            btnRemoveB.Text = "Remove";
            btnRemoveB.UseVisualStyleBackColor = true;
            btnRemoveB.Click += button2_Click;
            // 
            // btnRemoveA
            // 
            btnRemoveA.Location = new Point(245, 145);
            btnRemoveA.Name = "btnRemoveA";
            btnRemoveA.Size = new Size(75, 23);
            btnRemoveA.TabIndex = 30;
            btnRemoveA.Text = "Remove";
            btnRemoveA.UseVisualStyleBackColor = true;
            btnRemoveA.Click += button3_Click_1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 223);
            label8.Name = "label8";
            label8.Size = new Size(77, 15);
            label8.TabIndex = 38;
            label8.Text = "Remove SetC";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 186);
            label9.Name = "label9";
            label9.Size = new Size(76, 15);
            label9.TabIndex = 37;
            label9.Text = "Remove SetB";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 149);
            label10.Name = "label10";
            label10.Size = new Size(77, 15);
            label10.TabIndex = 36;
            label10.Text = "Remove SetA";
            // 
            // btnClrReC
            // 
            btnClrReC.Location = new Point(327, 219);
            btnClrReC.Name = "btnClrReC";
            btnClrReC.Size = new Size(75, 23);
            btnClrReC.TabIndex = 41;
            btnClrReC.Text = "Clear";
            btnClrReC.UseVisualStyleBackColor = true;
            btnClrReC.Click += button4_Click;
            // 
            // btnClrReB
            // 
            btnClrReB.Location = new Point(327, 182);
            btnClrReB.Name = "btnClrReB";
            btnClrReB.Size = new Size(75, 23);
            btnClrReB.TabIndex = 40;
            btnClrReB.Text = "Clear";
            btnClrReB.UseVisualStyleBackColor = true;
            btnClrReB.Click += button7_Click;
            // 
            // btnCLrReA
            // 
            btnCLrReA.Location = new Point(327, 145);
            btnCLrReA.Name = "btnCLrReA";
            btnCLrReA.Size = new Size(75, 23);
            btnCLrReA.TabIndex = 39;
            btnCLrReA.Text = "Clear";
            btnCLrReA.UseVisualStyleBackColor = true;
            btnCLrReA.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 620);
            Controls.Add(btnClrReC);
            Controls.Add(btnClrReB);
            Controls.Add(btnCLrReA);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(txtRemoveC);
            Controls.Add(txtRemoveB);
            Controls.Add(txtRemoveA);
            Controls.Add(btnRemoveC);
            Controls.Add(btnRemoveB);
            Controls.Add(btnRemoveA);
            Controls.Add(panel3);
            Controls.Add(panelOptionSet);
            Controls.Add(btnExecute);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(btnClrSetC);
            Controls.Add(btnClrSetB);
            Controls.Add(btnClrSetA);
            Controls.Add(txtAddSetC);
            Controls.Add(txtAddSetB);
            Controls.Add(txtAddSetA);
            Controls.Add(lblIsSubset);
            Controls.Add(label7);
            Controls.Add(panelOptionFunc);
            Controls.Add(btnAddSetC);
            Controls.Add(btnAddSetB);
            Controls.Add(btnAddSetA);
            Controls.Add(lblSetC);
            Controls.Add(lblSetB);
            Controls.Add(lblSetA);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Sets";
            Load += Form1_Load;
            panelOptionFunc.ResumeLayout(false);
            panelOptionFunc.PerformLayout();
            panelOptionSet.ResumeLayout(false);
            panelOptionSet.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private RadioButton radiobtnUnion;
        private RadioButton radiobtnIntersection;
        private RadioButton radiobtnDifference;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lblSetC;
        private Label lblSetB;
        private Label lblSetA;
        private Button btnAddSetA;
        private Button btnAddSetB;
        private Button btnAddSetC;
        private Panel panelOptionFunc;
        private Button btnExecute;
        private Label label7;
        private Label lblIsSubset;
        private TextBox txtAddSetA;
        private TextBox txtAddSetB;
        private TextBox txtAddSetC;
        private Button btnClrSetC;
        private Button btnClrSetB;
        private Button btnClrSetA;
        private Button button5;
        private Button button6;
        private Panel panelOptionSet;
        private RadioButton radiobtnSetC;
        private RadioButton radiobtnSetB;
        private RadioButton radiobtnSetA;
        private Panel panel3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton1;
        private RadioButton radioButton6;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private TextBox txtRemoveC;
        private TextBox txtRemoveB;
        private TextBox txtRemoveA;
        private Button btnRemoveC;
        private Button btnRemoveB;
        private Button btnRemoveA;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button btnClrReC;
        private Button btnClrReB;
        private Button btnCLrReA;
    }
}