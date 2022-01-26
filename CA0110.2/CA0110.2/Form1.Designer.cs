namespace CA0110._2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.RichTextBox();
            this.heightBox = new System.Windows.Forms.RichTextBox();
            this.nameBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.numberOfLogs = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KMI CALCULATOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter your weight (kg) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter your height (m) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter your name :";
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(12, 64);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(175, 31);
            this.weightBox.TabIndex = 6;
            this.weightBox.Text = "";
            this.weightBox.TextChanged += new System.EventHandler(this.weightBox_TextChanged);
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(12, 153);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(175, 29);
            this.heightBox.TabIndex = 7;
            this.heightBox.Text = "";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 228);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(175, 27);
            this.nameBox.TabIndex = 8;
            this.nameBox.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 32);
            this.button2.TabIndex = 10;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Enter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(202, 223);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 32);
            this.button4.TabIndex = 12;
            this.button4.Text = "Enter";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(131, 310);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(125, 28);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(564, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Log of enters :";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(564, 74);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(224, 264);
            this.richTextBox2.TabIndex = 15;
            this.richTextBox2.Text = "";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(564, 344);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 29);
            this.button5.TabIndex = 16;
            this.button5.Text = "Show";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Number of logs :";
            // 
            // numberOfLogs
            // 
            this.numberOfLogs.Location = new System.Drawing.Point(687, 376);
            this.numberOfLogs.Name = "numberOfLogs";
            this.numberOfLogs.Size = new System.Drawing.Size(65, 23);
            this.numberOfLogs.TabIndex = 18;
            this.numberOfLogs.Text = "";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(687, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 29);
            this.button6.TabIndex = 19;
            this.button6.Text = "Commit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 353);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(94, 29);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.numberOfLogs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox weightBox;
        private System.Windows.Forms.RichTextBox heightBox;
        private System.Windows.Forms.RichTextBox nameBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox numberOfLogs;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button clearButton;
    }
}
