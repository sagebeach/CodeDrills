using System;
using System.Text; //necessary for stringbuilder
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

public partial class StringVsBuilderTimer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Stopwatch stringTimer = new Stopwatch();
        string str = string.Empty;
        stringTimer.Start();
        for (int i = 0; i < 10000; i++)
        {
            str += "0";
        }
        stringTimer.Stop();
        var stringTime = stringTimer.Elapsed;
        stringLabel.Text = String.Format("String concatenation took: {0} ms", stringTime);

        StringBuilder strb = new StringBuilder(string.Empty);
        stringTimer.Restart();
        for (int i = 0; i < 10000; i++)
        {
            strb.Append("0");
        }
        stringTimer.Stop();
        var stringBuilderTime = stringTimer.Elapsed;
        stringBuilderLabel.Text = String.Format("StringBuilder construction took: {0} ms", stringBuilderTime);

        if (stringTime > stringBuilderTime)
        {
            var result = stringTime - stringBuilderTime;
            comparisonLabel.Text = String.Format("StringBuilder was {0} ms faster than string", result.ToString());
        }
        else
        {
            var result = stringBuilderTime - stringTime;
            comparisonLabel.Text = String.Format("String was {0} ms faster than StringBuilder", result.ToString());
        }
    }
}