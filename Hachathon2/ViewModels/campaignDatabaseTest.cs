using System;
using System.Collections.Generic;
using System.Text;

namespace Hachathon2
{
    public class campaignDatabaseTest
    {
        public List<campaignDatabase> SaudicampaignList { set; get; }
        public List<campaignDatabase> EygptcampaignList { set; get; }

        public campaignDatabaseTest()
        {
            SaudicampaignList = new List<campaignDatabase>();
            EygptcampaignList = new List<campaignDatabase>();
            fillData();

        }

        private void fillData()
        {
            // Object of campaign 1
            campaignDatabase campaign1 = new campaignDatabase();
            campaign1.CampaignName = "AlFerdous";
            campaign1.CampaignCountryOfResidence = "Saudi Arabia";
            campaign1.CampaignImagePath = "frdos.png";
            campaign1.CampaignNoStars = 4;
            campaign1.CampaignAvaVIP = 5;
            campaign1.CampaignVIPPrice = 20000;
            campaign1.CampaignAvaEco = 10;
            campaign1.CampaignEcoPrice = 7500;
            campaign1.CampaignAvaBus = 2;
            campaign1.CampaignBusPrice = 15000;
            campaign1.CampaignAveREview = 7.3;
            //Adding campaign 1
            SaudicampaignList.Add(campaign1);


            // Object of campaign 2
            campaignDatabase campaign2 = new campaignDatabase();
            campaign2.CampaignName = "AlBsha'ar";
            campaign2.CampaignCountryOfResidence = "Saudi Arabia";
            campaign2.CampaignImagePath = "Bshr.png";
            campaign2.CampaignNoStars = 2;
            campaign2.CampaignAvaVIP = 1;
            campaign2.CampaignVIPPrice = 5000;
            campaign2.CampaignAvaEco = 10;
            campaign2.CampaignEcoPrice = 1500;
            campaign2.CampaignAvaBus = 2;
            campaign2.CampaignBusPrice = 3000;
            campaign2.CampaignAveREview = 3.3;
            //Adding campaign 2
            SaudicampaignList.Add(campaign2);


            // Object of campaign 3
            campaignDatabase campaign3 = new campaignDatabase();
            campaign3.CampaignName = "AlFajer";
            campaign3.CampaignCountryOfResidence = "Egypt";
            campaign3.CampaignImagePath = "fjr.png";
            campaign3.CampaignNoStars = 5;
            campaign3.CampaignAvaVIP = 10;
            campaign3.CampaignVIPPrice = 25000;
            campaign3.CampaignAvaEco = 10;
            campaign3.CampaignEcoPrice = 9500;
            campaign3.CampaignAvaBus = 5;
            campaign3.CampaignBusPrice = 15000;
            campaign3.CampaignAveREview = 9.5;
            //Adding campaign 3
            EygptcampaignList.Add(campaign3);

            // Object of campaign 4
            campaignDatabase campaign4 = new campaignDatabase();
            campaign4.CampaignName = "AlSedrah";
            campaign4.CampaignCountryOfResidence = "Egypt";
            campaign4.CampaignImagePath = "sdra.png";
            campaign4.CampaignNoStars = 3;
            campaign4.CampaignAvaVIP = 5;
            campaign4.CampaignVIPPrice = 7000;
            campaign4.CampaignAvaEco = 5;
            campaign4.CampaignEcoPrice = 1500;
            campaign4.CampaignAvaBus = 0;
            campaign4.CampaignBusPrice = 3500;
            campaign4.CampaignAveREview = 6.3;
            //Adding campaign 4
            EygptcampaignList.Add(campaign4);


        }
    }
}
    