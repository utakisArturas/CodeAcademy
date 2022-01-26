namespace forms2
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
            this.label2 = new System.Windows.Forms.Label();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.avgGrade = new System.Windows.Forms.Button();
            this.grade = new System.Windows.Forms.RichTextBox();
            this.grades2 = new System.Windows.Forms.RichTextBox();
            this.grade1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "USENAME : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD:";
            // 
            // userNameText
            // 
            this.userNameText.Location = new System.Drawing.Point(117, 185);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(196, 22);
            this.userNameText.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(117, 241);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(196, 22);
            this.passwordText.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(117, 282);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "PRESS ME";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "grade :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "grade :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "grade :";
            // 
            // avgGrade
            // 
            this.avgGrade.Location = new System.Drawing.Point(180, 90);
            this.avgGrade.Name = "avgGrade";
            this.avgGrade.Size = new System.Drawing.Size(133, 35);
            this.avgGrade.TabIndex = 12;
            this.avgGrade.Text = "average grade";
            this.avgGrade.UseVisualStyleBackColor = true;
            this.avgGrade.Click += new System.EventHandler(this.avgGrade_Click);
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(123, 24);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(33, 23);
            this.grade.TabIndex = 13;
            this.grade.Text = "";
            // 
            // grades2
            // 
            this.grades2.Location = new System.Drawing.Point(123, 103);
            this.grades2.Name = "grades2";
            this.grades2.Size = new System.Drawing.Size(33, 23);
            this.grades2.TabIndex = 14;
            this.grades2.Text = "";
            // 
            // grade1
            // 
            this.grade1.Location = new System.Drawing.Point(123, 65);
            this.grade1.Name = "grade1";
            this.grade1.Size = new System.Drawing.Size(33, 23);
            this.grade1.TabIndex = 15;
            this.grade1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 490);
            this.Controls.Add(this.grade1);
            this.Controls.Add(this.grades2);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.avgGrade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button avgGrade;
        private System.Windows.Forms.RichTextBox grade;
        private System.Windows.Forms.RichTextBox grades2;
        private System.Windows.Forms.RichTextBox grade1;
    }
}

