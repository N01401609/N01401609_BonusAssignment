using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    //DETERMINE WHICH GIVEN DAY IS A WORK DAY

                    //TASK MATCH THE DAYS OF THE WEEK WITH THE GIVEN DAYS OF THE MONTH
                    string DayofTheWeek = "";// string to determine what day of the week is the given date
                    string AddtoCalendar = ""; // string to store every line in the calendar
                    string Activity = ""; //string writes wether it is time to work or have fun 
                    List<string> WorkDaysSelected = new List<string>();

                    //DETERMINE WHICH DAYs ARE WORK DAYS


                    foreach (ListItem day in work_days.Items)
                    {
                        if (day.Selected)
                        {
                            WorkDaysSelected.Add(day.Value);
                        }
                    }

                    work_schedule_summary.InnerHtml = "Your October schedule is as follows <br>";
                    for (int i = 1; i <= 31; i++)
                    {

                        if (i % 7 == 0)
                        {
                            DayofTheWeek = "Monday";

                        }
                        else if (i % 7 == 1)
                        {
                            DayofTheWeek = "Tuesday";

                        }
                        else if (i % 7 == 2)
                        {
                            DayofTheWeek = "Wednesday";

                        }
                        else if (i % 7 == 3)
                        {
                            DayofTheWeek = "Thursday";

                        }
                        else if (i % 7 == 4)
                        {
                            DayofTheWeek = "Friday";

                        }
                        else if (i % 7 == 5)
                        {
                            DayofTheWeek = "Saturday";

                        }
                        else if (i % 7 == 6)
                        {
                            DayofTheWeek = "Sunday";
                        }

                        AddtoCalendar += "October " + i + " is a " + DayofTheWeek + "! <br>";
                    }
                    work_schedule_summary.InnerHtml = AddtoCalendar;


                    

                }

            
            
            }
        }
    }
}