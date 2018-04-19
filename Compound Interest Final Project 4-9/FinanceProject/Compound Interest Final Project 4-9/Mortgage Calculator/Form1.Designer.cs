namespace Mortgage_Calculator
{
    partial class MortgageCalculator
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
            this.InterestRateBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ResultsBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Down Payment ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Loaned";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Length of Loan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Interest Rate ";
            // 
            // OriginalAmountBox
            // 
            this.OriginalAmountBox.Location = new System.Drawing.Point(184, 22);
            this.OriginalAmountBox.Name = "OriginalAmountBox";
            this.OriginalAmountBox.Size = new System.Drawing.Size(144, 20);
            this.OriginalAmountBox.TabIndex = 5;
            // 
            // DownPaymentBox
            // 
            this.DownPaymentBox.Location = new System.Drawing.Point(184, 69);
            this.DownPaymentBox.Name = "DownPaymentBox";
            this.DownPaymentBox.Size = new System.Drawing.Size(144, 20);
            this.DownPaymentBox.TabIndex = 6;
            // 
            // AmountLoanedBox
            // 
            this.AmountLoanedBox.Location = new System.Drawing.Point(184, 117);
            this.AmountLoanedBox.Name = "AmountLoanedBox";
            this.AmountLoanedBox.Size = new System.Drawing.Size(144, 20);
            this.AmountLoanedBox.TabIndex = 7;
            // 
            // LengthOfLoanBox
            // 
            this.LengthOfLoanBox.Location = new System.Drawing.Point(184, 178);
            this.LengthOfLoanBox.Name = "LengthOfLoanBox";
            this.LengthOfLoanBox.Size = new System.Drawing.Size(144, 20);
            this.LengthOfLoanBox.TabIndex = 8;
            // 
            // InterestRateBox
            // 
            this.InterestRateBox.Location = new System.Drawing.Point(184, 228);
            this.InterestRateBox.Name = "InterestRateBox";
            this.InterestRateBox.Size = new System.Drawing.Size(144, 20);
            this.InterestRateBox.TabIndex = 9;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(6, 27);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 30);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate ";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Result";
            // 
            // ResultsBox
            // 
            this.ResultsBox.Location = new System.Drawing.Point(33, 127);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.ReadOnly = true;
            this.ResultsBox.Size = new System.Drawing.Size(136, 20);
            this.ResultsBox.TabIndex = 12;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(113, 34);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // ResultsGroupBox
            // 
            this.ResultsGroupBox.Controls.Add(this.CalculateButton);
            this.ResultsGroupBox.Controls.Add(this.label6);
            this.ResultsGroupBox.Controls.Add(this.ResultsBox);
            this.ResultsGroupBox.Controls.Add(this.ClearButton);
            this.ResultsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsGroupBox.Location = new System.Drawing.Point(374, 22);
            this.ResultsGroupBox.Name = "ResultsGroupBox";
            this.ResultsGroupBox.Size = new System.Drawing.Size(200, 176);
            this.ResultsGroupBox.TabIndex = 14;
            this.ResultsGroupBox.TabStop = false;
            this.ResultsGroupBox.Text = "Results";
            // 
            // MortgageCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 321);
            this.Controls.Add(this.ResultsGroupBox);
            this.Controls.Add(this.InterestRateBox);
            this.Controls.Add(this.LengthOfLoanBox);
            this.Controls.Add(this.AmountLoanedBox);
            this.Controls.Add(this.DownPaymentBox);
            this.Controls.Add(this.OriginalAmountBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MortgageCalculator";
            this.Text = "Mortgage Calculator";
            this.ResultsGroupBox.ResumeLayout(false);
            this.ResultsGroupBox.PerformLayout();
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
        private System.Windows.Forms.TextBox InterestRateBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ResultsBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.GroupBox ResultsGroupBox;
    }
}

