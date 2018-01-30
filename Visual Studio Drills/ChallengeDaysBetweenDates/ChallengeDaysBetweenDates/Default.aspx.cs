﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void okButton_Click(object sender, EventArgs e)
    {
         if (myCalendarFirst.SelectedDate > myCalendarSecond.SelectedDate)
         {
             textLabel.Text = myCalendarFirst.SelectedDate
             .Subtract(myCalendarSecond.SelectedDate)
             .TotalDays.ToString();
         }
         else
         {
             textLabel.Text = myCalendarSecond.SelectedDate
            .Subtract(myCalendarFirst.SelectedDate)
            .TotalDays.ToString();
         } 
    }
}