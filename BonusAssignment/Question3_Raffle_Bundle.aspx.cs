using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    //TASK: DETERMINE WHAT BUNDLE THE INPUT FALLS INTO

                    int TicketsAmount = Convert.ToInt32(tickets_amount.Text);
                    int TypeofBundle = 1;
                    string PrintBundle = "";

                    PrintBundle +=purchase_summary.InnerHtml = "You ordered " + TicketsAmount + " tickets<br>";

                    if (TicketsAmount > 0 && TicketsAmount <= 50 )
                    {
                        TypeofBundle = 1;

                    } else if(TicketsAmount >= 51 && TicketsAmount <=150)
                    {

                        TypeofBundle = 2;

                    } else if (TicketsAmount >=151 && TicketsAmount <=300)
                    {
                        TypeofBundle = 3;
                    } else if (TicketsAmount >= 301)
                    {
                        TypeofBundle = 5;
                    }

                    //TASK: PRINT BASED ON GIVEN BUNDLE
                    
                    for (int i = TypeofBundle; i <= TicketsAmount; i += TypeofBundle)
                    {
                        PrintBundle += "You received a bundle of " + TypeofBundle + "! That's " + i + " ticket(s)!<br>";
                    }

                    //TASK: PRINT REMAINDER
                    int leftover = TicketsAmount % TypeofBundle;
                    if (leftover != 0)
                    {
                        PrintBundle += "You leftover is " + leftover + "! That's " + TicketsAmount + " ticket(s)!<br>";
                    }

                    //TASK: OUTPUT FINAL MESSAGE WITH PRICE
                    double total = TicketsAmount * 0.25;
                    PrintBundle += "Your total ticket(s) is " + TicketsAmount + " and your cost is $" + total + "cad!<br>";




                    purchase_summary.InnerHtml = PrintBundle;
                }
            }
        }
    }
}