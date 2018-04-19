using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compound_Interest_Final_Project_4_9
{
    public partial class MortgageForm : Form
    {
        public MortgageForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OriginalAmountBox.Text = "";
            DownPaymentBox.Text = "";
            AmountLoanedBox.Text = "";
            LengthOfLoanBox.Text = "";
            InterestBox.Text = "";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {

                // variables to hold the values 
                double total = 0;
                double prinp = 0;              // original amount
                double downpay;               //  down payment 
                double loanamount;           //   amount loaned
                int loanlength;             //    length in loan (years)
                int interestrate = 0;   //    the interest rate 






                // parse the values down, when the user inputs in the text boxes


                prinp = double.Parse(OriginalAmountBox.Text);
                downpay = double.Parse(DownPaymentBox.Text);
                loanlength = int.Parse(LengthOfLoanBox.Text);
                loanamount = double.Parse(AmountLoanedBox.Text);
                interestrate = int.Parse(InterestBox.Text) / 100;




                loanamount = prinp - downpay;

                downpay = prinp * ((interestrate * (Math.Pow(1 + interestrate, loanlength))) /
                                   (Math.Pow(1 + interestrate, loanlength) - 1));


                total = (downpay * loanlength) - loanamount;

                double totalamountpaid = downpay * loanlength;





                // display the answers in the text boxes with the .ToString method 

                OriginalAmountBox.Text = prinp.ToString("n2");
                DownPaymentBox.Text = downpay.ToString("n2");
                AmountLoanedBox.Text = loanamount.ToString("n2");
                LengthOfLoanBox.Text = loanlength.ToString("n2");
                InterestBox.Text = interestrate.ToString("n2");

            }
            catch (Exception ex)
            {
                throw ex;
            }

            }

        private void MortgageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
