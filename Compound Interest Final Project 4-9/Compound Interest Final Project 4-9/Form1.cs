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
    public partial class CompoundForm : Form
    {
        public CompoundForm()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {


                string ex = compoundInterest.compound(InitialAmountBox.Text, InterestRateBox.Text,
               DepositsPerMonthBox.Text, NumberOfYearsBox.Text, CompoundedBox.SelectedItem.ToString());

                string principal = InitialAmountBox.Text;
                string interestrate = InterestRateBox.Text;
                string monthlydep = DepositsPerMonthBox.Text;
                string yr = NumberOfYearsBox.Text;
                string timescomp = CompoundedBox.Text;


                CalculateBox.Text = compoundInterest.compound(principal, interestrate, monthlydep, yr, timescomp);
            }


            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            InitialAmountBox.Text = "";
            InterestRateBox.Text = "";
            DepositsPerMonthBox.Text = "";
            NumberOfYearsBox.Text = "";
            CompoundedBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompoundForm_Load(object sender, EventArgs e)
        {

        }
    }
}





             
        

