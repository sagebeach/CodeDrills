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
        if (!Page.IsPostBack)
        {
            Calendar1.SelectedDate = DateTime.Today;
            Calendar2.SelectedDate = DateTime.Today.AddDays(14);
            Calendar3.SelectedDate = DateTime.Today.AddDays(21);
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string breakTime;
        if (Calendar1.SelectedDate > Calendar2.SelectedDate)
        {
            breakTime = Calendar1.SelectedDate
            .Subtract(Calendar2.SelectedDate)
            .TotalDays.ToString();
        }
        else
        {
            breakTime = Calendar2.SelectedDate
             .Subtract(Calendar1.SelectedDate)
             .TotalDays.ToString();
        }

        int assignmentLength;
        if (Calendar2.SelectedDate > Calendar3.SelectedDate)
        {
            assignmentLength = (int)Calendar2.SelectedDate
            .Subtract(Calendar3.SelectedDate)
            .TotalDays;
        }
        else
        {
            assignmentLength = (int)Calendar3.SelectedDate
             .Subtract(Calendar2.SelectedDate)
             .TotalDays;
        }


        int timeCheck = int.Parse(breakTime);
        double budgetCost = assignmentLength * 500;
        if (timeCheck < 14) //Operative needs at least 2 weeks between assignments.
        {
            resultLabel.Text = "Error: Must allow at least two weeks between previous asssignment and new assignment.";
            Calendar2.SelectedDate = DateTime.Now.Date.AddDays(14);
        }
        else if (assignmentLength > 21)
        {
            budgetCost = budgetCost + 1000; //adds $1000 if assignment length is over 3 weeks.
            string result = String.Format("Assignment of {0} to assignment {1} is approved. Total cost to budget: {2:C}", codenameTextBox.Text, assignmentTextBox.Text, budgetCost);
            resultLabel.Text = result;
        }
       else
        {
            string result = String.Format("Assignment of {0} to assignment {1} is approved. Total cost to budget: {2:C}", codenameTextBox.Text, assignmentTextBox.Text, budgetCost);
            resultLabel.Text = result;
        }      
    }
}