using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BonusAssignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();

                if (Page.IsValid)
                {
                    int Xvalue = Convert.ToInt32(xvalue.Text);
                    int Yvalue = Convert.ToInt32(yvalue.Text);
                    string QuadrantMsg = "";

                    //TASK: CHECK WHAT QUADRANT THE COORDINATE FALLS INTO
                    //QUADRANT 1 
                    if (Xvalue > 0 && Yvalue >0)
                    {
                        QuadrantMsg = "Your cordinates are in quadrant 1 ";

                    } else if (Xvalue < 0 && Yvalue > 0)
                    {
                        QuadrantMsg = "Your cordinates are in quadrant 2 ";
                    } else if (Xvalue < 0 && Yvalue < 0)
                    {
                        QuadrantMsg = "Your cordinates are in quadrant 3 ";
                    } else if (Xvalue > 0 && Yvalue < 0)
                    {
                        QuadrantMsg = "Your cordinates are in quadrant 4 ";
                    }
                    quadrant_summary.InnerHtml = QuadrantMsg;
                }
            }
        }
    }
}