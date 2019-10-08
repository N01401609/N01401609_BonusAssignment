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
                   

                    //VARIABLE DECLARATION
                    string DayofTheWeek;// string to determine what day of the week is the given date
                    int NumberDayofTheWeek; //int that represents the day of the week i.e Monday = 0
                    string AddtoCalendar = ""; // string to store every line in the calendar
                    string Activity = ""; //string writes whether it is time to work or have fun 
                    List<string> ListDaysofTheWeek = new List<string>();//List stores days of the week
                    ListDaysofTheWeek.Add("Monday");
                    ListDaysofTheWeek.Add("Tuesday");
                    ListDaysofTheWeek.Add("Wednesday");
                    ListDaysofTheWeek.Add("Thursday");
                    ListDaysofTheWeek.Add("Friday");
                    ListDaysofTheWeek.Add("Saturday");
                    ListDaysofTheWeek.Add("Sunday");

                  
                    AddtoCalendar += work_schedule_summary.InnerHtml = "Your October schedule is as follows <br>";

                    //TASK MATCH THE DAYS OF THE WEEK WITH THE GIVEN DAYS OF THE MONTH
                    for (int i = 1; i <= 31; i++)
                    {
                        NumberDayofTheWeek = i % 7;
                        DayofTheWeek = ListDaysofTheWeek.ElementAt(NumberDayofTheWeek);

                        //TASK: DETERMINE THE DAYS THAT ARE WORK DAYS
                        foreach (ListItem day in work_days.Items)
                        {
                            if(day.Value == DayofTheWeek)
                            {
                                if (day.Selected)
                                {
                                    Activity = "Time to work...";
                                } else
                                {
                                    Activity = "Time to have fun!";
                                }
                            }
                            
               
                        }

                        //TASK: OUTPUT A MESSAGE THAT SAYS THE DATE AND THE ACTIVITY
                        AddtoCalendar += "October " + i + " is a " + DayofTheWeek + "! " + Activity+ " <br>";
                    }
                    work_schedule_summary.InnerHtml = AddtoCalendar;  

                }

            
            
            }
        }
    }
}