namespace CA0110
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
            this.dateName = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.RichTextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.showGrade = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.addButton1 = new System.Windows.Forms.Button();
            this.addButton2 = new System.Windows.Forms.Button();
            this.firstSemester = new System.Windows.Forms.RichTextBox();
            this.secondSemester = new System.Windows.Forms.RichTextBox();
            this.thirdSemester = new System.Windows.Forms.RichTextBox();
            this.showAverageButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.showGrade1 = new System.Windows.Forms.Button();
            this.showGrade2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateName
            // 
            this.dateName.Location = new System.Drawing.Point(12, 23);
            this.dateName.Name = "dateName";
            this.dateName.Size = new System.Drawing.Size(94, 29);
            this.dateName.TabIndex = 0;
            this.dateName.Text = "Date";
            this.dateName.UseVisualStyleBackColor = true;
            this.dateName.Click += new System.EventHandler(this.dateName_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(12, 71);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(94, 29);
            this.nameButton.TabIndex = 1;
            this.nameButton.Text = "Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a number";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(12, 154);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(110, 39);
            this.numberTextBox.TabIndex = 3;
            this.numberTextBox.Text = "";
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(12, 199);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 29);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // showGrade
            // 
            this.showGrade.Location = new System.Drawing.Point(223, 299);
            this.showGrade.Name = "showGrade";
            this.showGrade.Size = new System.Drawing.Size(94, 29);
            this.showGrade.TabIndex = 11;
            this.showGrade.Text = "ShowGrades";
            this.showGrade.UseVisualStyleBackColor = true;
            this.showGrade.Click += new System.EventHandler(this.avgGrade_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(168, 299);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(49, 29);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // addButton1
            // 
            this.addButton1.Location = new System.Drawing.Point(168, 376);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(49, 29);
            this.addButton1.TabIndex = 13;
            this.addButton1.Text = "add";
            this.addButton1.UseVisualStyleBackColor = true;
            this.addButton1.Click += new System.EventHandler(this.addButton1_Click);
            // 
            // addButton2
            // 
            this.addButton2.Location = new System.Drawing.Point(168, 450);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(49, 29);
            this.addButton2.TabIndex = 14;
            this.addButton2.Text = "add";
            this.addButton2.UseVisualStyleBackColor = true;
            this.addButton2.Click += new System.EventHandler(this.addButton2_Click);
            // 
            // firstSemester
            // 
            this.firstSemester.Location = new System.Drawing.Point(3, 282);
            this.firstSemester.Name = "firstSemester";
            this.firstSemester.Size = new System.Drawing.Size(159, 46);
            this.firstSemester.TabIndex = 16;
            this.firstSemester.Text = "";
            this.firstSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstSemester_KeyPress);
            // 
            // secondSemester
            // 
            this.secondSemester.Location = new System.Drawing.Point(3, 359);
            this.secondSemester.Name = "secondSemester";
            this.secondSemester.Size = new System.Drawing.Size(159, 46);
            this.secondSemester.TabIndex = 17;
            this.secondSemester.Text = "";
            this.secondSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secondSemester_KeyPress);
            // 
            // thirdSemester
            // 
            this.thirdSemester.Location = new System.Drawing.Point(3, 433);
            this.thirdSemester.Name = "thirdSemester";
            this.thirdSemester.Size = new System.Drawing.Size(159, 46);
            this.thirdSemester.TabIndex = 18;
            this.thirdSemester.Text = "";
            this.thirdSemester.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thirdSemester_KeyPress);
            // 
            // showAverageButton
            // 
            this.showAverageButton.Location = new System.Drawing.Point(323, 281);
            this.showAverageButton.Name = "showAverageButton";
            this.showAverageButton.Size = new System.Drawing.Size(160, 47);
            this.showAverageButton.TabIndex = 19;
            this.showAverageButton.Text = "Show Average Grade";
            this.showAverageButton.UseVisualStyleBackColor = true;
            this.showAverageButton.Click += new System.EventHandler(this.showAverageButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 46);
            this.button1.TabIndex = 20;
            this.button1.Text = "Show Average Grade";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 46);
            this.button2.TabIndex = 21;
            this.button2.Text = "Show Average Grade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // showGrade1
            // 
            this.showGrade1.Location = new System.Drawing.Point(223, 376);
            this.showGrade1.Name = "showGrade1";
            this.showGrade1.Size = new System.Drawing.Size(94, 29);
            this.showGrade1.TabIndex = 22;
            this.showGrade1.Text = "ShowGrades";
            this.showGrade1.UseVisualStyleBackColor = true;
            this.showGrade1.Click += new System.EventHandler(this.showGrade1_Click);
            // 
            // showGrade2
            // 
            this.showGrade2.Location = new System.Drawing.Point(223, 450);
            this.showGrade2.Name = "showGrade2";
            this.showGrade2.Size = new System.Drawing.Size(94, 29);
            this.showGrade2.TabIndex = 23;
            this.showGrade2.Text = "ShowGrades";
            this.showGrade2.UseVisualStyleBackColor = true;
            this.showGrade2.Click += new System.EventHandler(this.showGrade2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "First semester grades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Second semester grades";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Third semester grades";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 572);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showGrade2);
            this.Controls.Add(this.showGrade1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.showAverageButton);
            this.Controls.Add(this.thirdSemester);
            this.Controls.Add(this.secondSemester);
            this.Controls.Add(this.firstSemester);
            this.Controls.Add(this.addButton2);
            this.Controls.Add(this.addButton1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.showGrade);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.dateName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dateName;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox numberTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button showGrade;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.RichTextBox firstSemester;
        private System.Windows.Forms.RichTextBox secondSemester;
        private System.Windows.Forms.RichTextBox thirdSemester;
        private System.Windows.Forms.Button showAverageButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button showGrade1;
        private System.Windows.Forms.Button showGrade2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
