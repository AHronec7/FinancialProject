using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mortgage_Calculator
{
    public partial class MortgageCalculator : Form
    {
        public MortgageCalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            
            

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




    }
}
