using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";

            int largestNumberIndex = 0; //by setting this variable at 0 when it is used with the numbers[] variable below it will pull the value in the 0 index of that array. if this number were say =2, it would pull the 2 index of the numbers array when used in the context numbers[largestNumberIndex]
            int smallestNumberIndex = 0;
            
            for (int i = 0; i < names.Length; i++)
            {
                //find the largest count so far
                if (numbers[i] > numbers[largestNumberIndex])
                {
                    largestNumberIndex = i;
                }
                //find the smallest count so far
                if (numbers[i] < numbers[smallestNumberIndex])
                {
                    smallestNumberIndex = i;
                }
            }

            result = String.Format("Most battles belong to: {0} (value {1})<br />Least battles belong to: {2} (Value: {3})",
                names[largestNumberIndex], numbers[largestNumberIndex], names[smallestNumberIndex], numbers[smallestNumberIndex]);

            resultLabel.Text = result;
        }
    }
}

//Most battles belong to:
//Least battles belong to: