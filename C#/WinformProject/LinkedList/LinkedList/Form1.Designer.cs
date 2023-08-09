
namespace LinkedList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClrAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnClrPos = new System.Windows.Forms.Button();
            this.btnClrAll = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radiobtnFirst = new System.Windows.Forms.RadioButton();
            this.radiobtnLast = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.sizetxt = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập vào giá trị cần thêm:";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(242, 18);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 20);
            this.txtAdd.TabIndex = 1;
            this.txtAdd.TextChanged += new System.EventHandler(this.txtAdd_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(443, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 72);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClrAdd
            // 
            this.btnClrAdd.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClrAdd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClrAdd.ForeColor = System.Drawing.Color.Red;
            this.btnClrAdd.ImageKey = "(none)";
            this.btnClrAdd.Location = new System.Drawing.Point(348, 15);
            this.btnClrAdd.Name = "btnClrAdd";
            this.btnClrAdd.Size = new System.Drawing.Size(75, 23);
            this.btnClrAdd.TabIndex = 3;
            this.btnClrAdd.Text = "Clear";
            this.btnClrAdd.UseVisualStyleBackColor = false;
            this.btnClrAdd.Click += new System.EventHandler(this.btnClrAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Xuất List: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập vị trí cần thêm:";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(242, 67);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 20);
            this.txtPosition.TabIndex = 8;
            this.txtPosition.TextChanged += new System.EventHandler(this.txtPosition_TextChanged);
            // 
            // btnClrPos
            // 
            this.btnClrPos.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClrPos.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClrPos.ForeColor = System.Drawing.Color.Red;
            this.btnClrPos.ImageKey = "(none)";
            this.btnClrPos.Location = new System.Drawing.Point(348, 65);
            this.btnClrPos.Name = "btnClrPos";
            this.btnClrPos.Size = new System.Drawing.Size(75, 22);
            this.btnClrPos.TabIndex = 9;
            this.btnClrPos.Text = "Clear";
            this.btnClrPos.UseVisualStyleBackColor = false;
            this.btnClrPos.Click += new System.EventHandler(this.btnClrPos_Click);
            // 
            // btnClrAll
            // 
            this.btnClrAll.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnClrAll.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClrAll.ForeColor = System.Drawing.Color.Red;
            this.btnClrAll.ImageKey = "(none)";
            this.btnClrAll.Location = new System.Drawing.Point(392, 209);
            this.btnClrAll.Name = "btnClrAll";
            this.btnClrAll.Size = new System.Drawing.Size(75, 42);
            this.btnClrAll.TabIndex = 10;
            this.btnClrAll.Text = "Clear All";
            this.btnClrAll.UseVisualStyleBackColor = false;
            this.btnClrAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.ImageKey = "(none)";
            this.button3.Location = new System.Drawing.Point(500, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 11;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radiobtnFirst
            // 
            this.radiobtnFirst.AutoSize = true;
            this.radiobtnFirst.Location = new System.Drawing.Point(19, 14);
            this.radiobtnFirst.Name = "radiobtnFirst";
            this.radiobtnFirst.Size = new System.Drawing.Size(66, 17);
            this.radiobtnFirst.TabIndex = 12;
            this.radiobtnFirst.TabStop = true;
            this.radiobtnFirst.Text = "Add First";
            this.radiobtnFirst.UseVisualStyleBackColor = true;
            this.radiobtnFirst.CheckedChanged += new System.EventHandler(this.radiobtnFirst_CheckedChanged);
            // 
            // radiobtnLast
            // 
            this.radiobtnLast.AutoSize = true;
            this.radiobtnLast.Location = new System.Drawing.Point(19, 51);
            this.radiobtnLast.Name = "radiobtnLast";
            this.radiobtnLast.Size = new System.Drawing.Size(67, 17);
            this.radiobtnLast.TabIndex = 13;
            this.radiobtnLast.TabStop = true;
            this.radiobtnLast.Text = "Add Last";
            this.radiobtnLast.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.ImageKey = "(none)";
            this.button4.Location = new System.Drawing.Point(603, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 42);
            this.button4.TabIndex = 14;
            this.button4.Text = "Quit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radiobtnLast);
            this.panel1.Controls.Add(this.radiobtnFirst);
            this.panel1.Location = new System.Drawing.Point(562, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(148, 94);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "Số phần tử của List: ";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.size.Location = new System.Drawing.Point(169, 167);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(0, 22);
            this.size.TabIndex = 18;
            // 
            // sizetxt
            // 
            this.sizetxt.AutoSize = true;
            this.sizetxt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizetxt.ForeColor = System.Drawing.Color.Purple;
            this.sizetxt.Location = new System.Drawing.Point(184, 166);
            this.sizetxt.Name = "sizetxt";
            this.sizetxt.Size = new System.Drawing.Size(49, 22);
            this.sizetxt.TabIndex = 19;
            this.sizetxt.Text = "label";
            this.sizetxt.Click += new System.EventHandler(this.sizetxt_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(115, 112);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(626, 20);
            this.txtKQ.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(726, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "PhamNghia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.sizetxt);
            this.Controls.Add(this.size);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClrAll);
            this.Controls.Add(this.btnClrPos);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClrAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Linked List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClrAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Button btnClrPos;
        private System.Windows.Forms.Button btnClrAll;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radiobtnFirst;
        private System.Windows.Forms.RadioButton radiobtnLast;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label sizetxt;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Label label5;
    }
}

