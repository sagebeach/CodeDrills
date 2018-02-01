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
            string[] names = new string[0];
            ViewState.Add("Names", names);

            int[] elections = new int[0];
            ViewState.Add("Elections", elections);

            double[] acts = new double[0];
            ViewState.Add("Acts", acts);
        }
    }

    protected void okButton_Click(object sender, EventArgs e)
    {
        string[] names = (string[])ViewState["Names"];
        Array.Resize(ref names, names.Length + 1);
        int newestName = names.GetUpperBound(0);
        names[newestName] = assetNameTextBox.Text.ToString();
        ViewState["Names"] = names;

        int[] elections = (int[])ViewState["Elections"];
        Array.Resize(ref elections, elections.Length + 1);
        int electionCount = elections.GetUpperBound(0);
        elections[electionCount] = int.Parse(electionsTextBox.Text);
        ViewState["Elections"] = elections;

        double[] acts = (double[])ViewState["Acts"];
        Array.Resize(ref acts, acts.Length + 1);
        int newestActs = acts.GetUpperBound(0);
        acts[newestActs] = double.Parse(subterfugeTextBox.Text);
        ViewState["Acts"] = acts;

        resultLabel.Text = String.Format("Total Elections Rigged: {0}<br />" +
            "Average Acts of Subterfuge per Asset: {1:N2}<br />" +
            "(Last Asset you Added: {2})",
            elections.Sum(),
            acts.Average(),
            names.Last());
    }
}