namespace Compound_Interest_Final_Project_4_9
{
    partial class MortgageForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OriginalAmountBox = new System.Windows.Forms.TextBox();
            this.DownPaymentBox = new System.Windows.Forms.TextBox();
            this.AmountLoanedBox = new System.Windows.Forms.TextBox();
            this.LengthOfLoanBox = new System.Windows.Forms.TextBox();
            this.InterestBox = new System.Windows.Forms.TextBox();
            this.ResultsBox = new System.Windows.Forms.GroupBox();
            this.ResultsTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ResultsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Down Payment ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Loaned";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Length of Loan";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Interest Rate";
            // 
            // OriginalAmountBox
            // 
            this.OriginalAmountBox.Location = new System.Drawing.Point(157, 26);
            this.OriginalAmountBox.Name = "OriginalAmountBox";
            this.OriginalAmountBox.Size = new System.Drawing.Size(132, 20);
            this.OriginalAmountBox.TabIndex = 5;
            // 
            // DownPaymentBox
            // 
            this.DownPaymentBox.Location = new System.Drawing.Point(157, 85);
            this.DownPaymentBox.Name = "DownPaymentBox";
            this.DownPaymentBox.Size = new System.Drawing.Size(132, 20);
            this.DownPaymentBox.TabIndex = 6;
            // 
            // AmountLoanedBox
            // 
            this.AmountLoanedBox.Location = new System.Drawing.Point(157, 135);
            this.AmountLoanedBox.Name = "AmountLoanedBox";
            this.AmountLoanedBox.Size = new System.Drawing.Size(132, 20);
            this.AmountLoanedBox.TabIndex = 7;
            // 
            // LengthOfLoanBox
            // 
            this.LengthOfLoanBox.Location = new System.Drawing.Point(157, 195);
            this.LengthOfLoanBox.Name = "LengthOfLoanBox";
            this.LengthOfLoanBox.Size = new System.Drawing.Size(132, 20);
            this.LengthOfLoanBox.TabIndex = 8;
            // 
            // InterestBox
            // 
            this.InterestBox.Location = new System.Drawing.Point(157, 255);
            this.InterestBox.Name = "InterestBox";
            this.InterestBox.Size = new System.Drawing.Size(132, 20);
            this.InterestBox.TabIndex = 9;
            // 
            // ResultsBox
            // 
            this.ResultsBox.BackColor = System.Drawing.Color.Bisque;
            this.ResultsBox.Controls.Add(this.ResultsTextBox);
            this.ResultsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsBox.Location = new System.Drawing.Point(407, 26);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.Size = new System.Drawing.Size(200, 207);
            this.ResultsBox.TabIndex = 10;
            this.ResultsBox.TabStop = false;
            this.ResultsBox.Text = "Results";
            // 
            // ResultsTextBox
            // 
            this.ResultsTextBox.Location = new System.Drawing.Point(39, 46);
            this.ResultsTextBox.Name = "ResultsTextBox";
            this.ResultsTextBox.ReadOnly = true;
            this.ResultsTextBox.Size = new System.Drawing.Size(133, 20);
            this.ResultsTextBox.TabIndex = 0;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(351, 329);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 11;
            this.CalculateButton.Text = "Calculate ";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(504, 329);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MortgageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(619, 375);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.InterestBox);
            this.Controls.Add(this.LengthOfLoanBox);
            this.Controls.Add(this.AmountLoanedBox);
            this.Controls.Add(this.DownPaymentBox);
            this.Controls.Add(this.OriginalAmountBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MortgageForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MortgageForm_Load);
            this.ResultsBox.ResumeLayout(false);
            this.ResultsBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OriginalAmountBox;
        private System.Windows.Forms.TextBox DownPaymentBox;
        private System.Windows.Forms.TextBox AmountLoanedBox;
        private System.Windows.Forms.TextBox LengthOfLoanBox;
        private System.Windows.Forms.TextBox InterestBox;
        private System.Windows.Forms.GroupBox ResultsBox;
        private System.Windows.Forms.TextBox ResultsTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
    }
}