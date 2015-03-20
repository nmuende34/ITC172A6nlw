using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TimeSpan start = new TimeSpan(0, 0, 0);
        TimeSpan morning = new TimeSpan(12, 0, 0);
        TimeSpan afternoon = new TimeSpan(17, 0, 0);
        TimeSpan end = new TimeSpan(23, 59, 59);
        TimeSpan now = DateTime.Now.TimeOfDay;

        if ((now > start) && (now < morning))
        {
            Image1.Visible = false;
            Image2.Visible = false;
            Image3.Visible = true;
            lblTimeSpan.Text = "Good Morning!";
        }
        else if ((now > morning) && (now < afternoon))
        {
            Image1.Visible = true;
            Image2.Visible = false;
            Image3.Visible = false;
            lblTimeSpan.Text = "Good Afternoon!";

        }
        else if (now > afternoon)
        {
            Image1.Visible = false;
            Image2.Visible = true;
            Image3.Visible = false;
            lblTimeSpan.Text = "Good Evening!";        
        }
        else
        {
            Image1.Visible = true;
            Image2.Visible = true;
            Image3.Visible = true;
        }
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        TimeService.TimeClockServiceClient ts = new TimeService.TimeClockServiceClient();
        lblTime.Text = ts.GetCurrentTime();

        
    }
}