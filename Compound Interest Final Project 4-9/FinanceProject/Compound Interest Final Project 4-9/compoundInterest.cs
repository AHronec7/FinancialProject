using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compound_Interest_Final_Project_4_9
{
    public class compoundInterest
    {

        // variables that the user wil input, strings
        public static string compound(string principal, string interestrate, string monthlydep, string yr, string timescomp)
        {



            try
            {




                //variables

                //double total = 0;
                //double initialamount;
                //double interest;
                //double deposits;
                //int years;
                int timescompounded = 0;




                // parse the inputs in the text boxes to the double or int specification
                 double initialamount = double.Parse(principal);
                 double  interest = double.Parse(interestrate) / 100;
                 double deposits = double.Parse(monthlydep);
                 int years = int.Parse(yr);






                /* if statements to see if it is annually or so on, the statement will see if 
                 * it is annually then the variable "timescompounded" will be selected and so on
                 * it just keep running and iterating*/




                // if statements to determine if the timescomp is annually, semi- annual, etc.
                // if determines if the varialbe equals the string then the variable is set to 1 for annual, 6 for semi -annual etc.
              
                int yearscompounded;



                if (timescomp == ("Annually"))
                {

                    timescompounded = 1; yearscompounded = (years * 12);
                }


                else if (timescomp == ("Semi-Annually"))
                {
                    timescompounded = 2; yearscompounded = (years * 6);

                }

                else if (timescomp == ("Monthly"))
                {
                    timescompounded = 12;
                }


                else if (timescomp == ("Daily"))
                {
                    timescompounded = 12; yearscompounded = (years * 12) / 365;
                }






                // variables to hold for the formula to calculate compound interest
                // im breaking down the formula and step by step, calculating the formula

                double i = interest / timescompounded;
                int c = timescompounded;
                int y = years;
                double l = (y * c);
                double f = Math.Pow(1 + i, 1);
                double p = initialamount;
                double x = (f - 1);
                double DEP = double.Parse(monthlydep);



                // I am using these variables which are performing the actual calculation
                // it breaks down each variable

                double eq1 = i + 1;
                double eq2 = Math.Pow(eq1, (y * c));
                double eq3 = eq2 - 1;
                double eq4 = eq3 * DEP;

                double eqp2 = eq4 / i;
                double eqp1 = p * eq2;
                double total = eqp1 + eqp2;





                // returns the total in the output box, and strings it to its currency format


                return total.ToString("c");
          
       
            }

            catch (Exception ex)
            {
                throw ex;




                




            }
        }

    }
}
    
        
    



