using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_35_Challenge
{
    public partial class challenge_phun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                     
        
            string inputString = "Eric";
            string outpuString = ReverseString(inputString);
            Console.Write("Original String:", inputString + Environment.NewLine);
            Console.Write("Reversed String:", outpuString);

            Console.ReadLine();
        }

        private string ReverseString(string inputString)
        {
           string reversedString = "";

           for(int count=inputString.Length-1;count>-0; count--)
            {
                reversedString += inputString[count];
            }

           return reversedString;
        }
    }
}