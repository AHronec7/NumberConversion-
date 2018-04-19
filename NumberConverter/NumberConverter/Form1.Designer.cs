namespace NumberConverter
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ArabicButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.RomanButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(140, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ArabicButton
            // 
            this.ArabicButton.Location = new System.Drawing.Point(23, 243);
            this.ArabicButton.Name = "ArabicButton";
            this.ArabicButton.Size = new System.Drawing.Size(115, 23);
            this.ArabicButton.TabIndex = 4;
            this.ArabicButton.Text = "Convert to Roman";
            this.ArabicButton.UseVisualStyleBackColor = true;
            this.ArabicButton.Click += new System.EventHandler(this.ArabicButton_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(140, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 31);
            this.label3.TabIndex = 5;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // RomanButton
            // 
            this.RomanButton.Location = new System.Drawing.Point(234, 243);
            this.RomanButton.Name = "RomanButton";
            this.RomanButton.Size = new System.Drawing.Size(115, 23);
            this.RomanButton.TabIndex = 6;
            this.RomanButton.Text = "Convert To Arabic";
            this.RomanButton.UseVisualStyleBackColor = true;
            this.RomanButton.Click += new System.EventHandler(this.RomanButton_Click_1);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(140, 292);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 338);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.RomanButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ArabicButton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ArabicButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button RomanButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

