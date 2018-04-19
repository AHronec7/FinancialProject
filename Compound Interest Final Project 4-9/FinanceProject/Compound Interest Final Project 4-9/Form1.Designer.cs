namespace Compound_Interest_Final_Project_4_9
{
    partial class CompoundForm
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
            this.InitialAmountBox = new System.Windows.Forms.TextBox();
            this.InterestRateBox = new System.Windows.Forms.TextBox();
            this.DepositsPerMonthBox = new System.Windows.Forms.TextBox();
            this.NumberOfYearsBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalculateBox = new System.Windows.Forms.TextBox();
            this.CompoundedBox = new System.Windows.Forms.ComboBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Interest Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Additional Deposits per month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Number Of Years";
            // 
            // InitialAmountBox
            // 
            this.InitialAmountBox.Location = new System.Drawing.Point(258, 26);
            this.InitialAmountBox.Name = "InitialAmountBox";
            this.InitialAmountBox.Size = new System.Drawing.Size(100, 20);
            this.InitialAmountBox.TabIndex = 4;
            // 
            // InterestRateBox
            // 
            this.InterestRateBox.Location = new System.Drawing.Point(258, 89);
            this.InterestRateBox.Name = "InterestRateBox";
            this.InterestRateBox.Size = new System.Drawing.Size(100, 20);
            this.InterestRateBox.TabIndex = 5;
            // 
            // DepositsPerMonthBox
            // 
            this.DepositsPerMonthBox.Location = new System.Drawing.Point(258, 149);
            this.DepositsPerMonthBox.Name = "DepositsPerMonthBox";
            this.DepositsPerMonthBox.Size = new System.Drawing.Size(100, 20);
            this.DepositsPerMonthBox.TabIndex = 6;
            // 
            // NumberOfYearsBox
            // 
            this.NumberOfYearsBox.Location = new System.Drawing.Point(258, 216);
            this.NumberOfYearsBox.Name = "NumberOfYearsBox";
            this.NumberOfYearsBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOfYearsBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Times Compounded";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(26, 369);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(167, 23);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate Compound Interest";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(535, 369);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(52, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CalculateBox
            // 
            this.CalculateBox.Location = new System.Drawing.Point(258, 369);
            this.CalculateBox.Name = "CalculateBox";
            this.CalculateBox.ReadOnly = true;
            this.CalculateBox.Size = new System.Drawing.Size(100, 20);
            this.CalculateBox.TabIndex = 12;
            // 
            // CompoundedBox
            // 
            this.CompoundedBox.FormattingEnabled = true;
            this.CompoundedBox.Items.AddRange(new object[] {
            "Annually",
            "Semi-Annually",
            "Monthly",
            "Daily"});
            this.CompoundedBox.Location = new System.Drawing.Point(258, 286);
            this.CompoundedBox.Name = "CompoundedBox";
            this.CompoundedBox.Size = new System.Drawing.Size(121, 21);
            this.CompoundedBox.TabIndex = 13;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(413, 369);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CompoundForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(621, 413);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CompoundedBox);
            this.Controls.Add(this.CalculateBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumberOfYearsBox);
            this.Controls.Add(this.DepositsPerMonthBox);
            this.Controls.Add(this.InterestRateBox);
            this.Controls.Add(this.InitialAmountBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CompoundForm";
            this.Text = "Compound Interest";
            this.Load += new System.EventHandler(this.CompoundForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox InitialAmountBox;
        private System.Windows.Forms.TextBox InterestRateBox;
        private System.Windows.Forms.TextBox DepositsPerMonthBox;
        private System.Windows.Forms.TextBox NumberOfYearsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox CalculateBox;
        private System.Windows.Forms.ComboBox CompoundedBox;
        private System.Windows.Forms.Button ClearButton;
    }
}

