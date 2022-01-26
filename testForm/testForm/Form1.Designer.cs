namespace testForm
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
            this.submitButton = new System.Windows.Forms.Button();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTenTimes = new System.Windows.Forms.Button();
            this.grades = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.avgGrade = new System.Windows.Forms.Button();
            this.grades1 = new System.Windows.Forms.TextBox();
            this.grades2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(123, 344);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 29);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Login";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(123, 222);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(221, 27);
            this.userNameText.TabIndex = 1;
            this.userNameText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(123, 286);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(221, 27);
            this.passwordText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "USERNAME:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "PASSWORD:";
            // 
            // nameTenTimes
            // 
            this.nameTenTimes.Location = new System.Drawing.Point(233, 344);
            this.nameTenTimes.Name = "nameTenTimes";
            this.nameTenTimes.Size = new System.Drawing.Size(94, 29);
            this.nameTenTimes.TabIndex = 5;
            this.nameTenTimes.Text = "NAME";
            this.nameTenTimes.UseVisualStyleBackColor = true;
            this.nameTenTimes.Click += new System.EventHandler(this.nameTenTimes_Click);
            // 
            // grades
            // 
            this.grades.Location = new System.Drawing.Point(123, 434);
            this.grades.Name = "grades";
            this.grades.Size = new System.Drawing.Size(125, 27);
            this.grades.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grades";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // avgGrade
            // 
            this.avgGrade.Location = new System.Drawing.Point(263, 500);
            this.avgGrade.Name = "avgGrade";
            this.avgGrade.Size = new System.Drawing.Size(94, 29);
            this.avgGrade.TabIndex = 8;
            this.avgGrade.Text = "avg grade";
            this.avgGrade.UseVisualStyleBackColor = true;
            this.avgGrade.Click += new System.EventHandler(this.avgGrade_Click);
            // 
            // grades1
            // 
            this.grades1.Location = new System.Drawing.Point(123, 467);
            this.grades1.Name = "grades1";
            this.grades1.Size = new System.Drawing.Size(125, 27);
            this.grades1.TabIndex = 9;
            // 
            // grades2
            // 
            this.grades2.Location = new System.Drawing.Point(123, 500);
            this.grades2.Name = "grades2";
            this.grades2.Size = new System.Drawing.Size(125, 27);
            this.grades2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 544);
            this.Controls.Add(this.grades2);
            this.Controls.Add(this.grades1);
            this.Controls.Add(this.avgGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grades);
            this.Controls.Add(this.nameTenTimes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button nameTenTimes;
        private System.Windows.Forms.TextBox grades;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button avgGrade;
        private System.Windows.Forms.TextBox grades1;
        private System.Windows.Forms.TextBox grades2;
    }
}
