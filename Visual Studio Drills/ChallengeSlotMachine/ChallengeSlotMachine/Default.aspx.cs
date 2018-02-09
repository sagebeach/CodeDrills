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

    }

    //apply random image to the reels on button click/
        //randomize one wheel
        //randomize all wheels
    //evaluate image result for the value result
        //value of cherries, bar, and jackpot
    // apply value result to money total
        //caluclate win/loss
        //make sure results persist to viewstate


    protected void leverButton_Click(object sender, EventArgs e)
    {
        
        //string slotImage = randomizeImageResults();
        string[] imageReel = new string[] {randomizeImageResults(), randomizeImageResults(), randomizeImageResults()}
        setRandomizedImages(imageReel);    
        }

    private void setRandomizedImages(string[] imageReel)
    {
       
        imageReel1.ImageUrl = "/images/" + imageReel[0] + ".png";
        imageReel2.ImageUrl = "/images/" + imageReel[1] + ".png";
        imageReel3.ImageUrl = "/images/" + imageReel[2] + ".png";
    }

        Random random = new Random();
    private string randomizeImageResults()
    {
        string[] slotImages = new string[] { "Bar", "Bell", "Cherry", "Clover", "Diamond", "Horseshoe", "Lemon", "Orange", "Plum", "Seven", "Strawberry", "Watermellon" };
        return slotImages[random.Next(11)];
    }
/*
   private string setReelImage()
    {
       imageReel1.ImageUrl = "/images/" + randomizeImageResults() + ".png";
    } */
}