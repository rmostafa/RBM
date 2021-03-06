
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class Adsense
    {
        public sealed class Dimensions
        {
            
        }

        public sealed class Metrics
        {
            
            [DescriptionAttribute("The total revenue from AdSense ads.")]
            public static DataItem adsenseRevenue = new DataItem("adsenseRevenue");
                                      
            [DescriptionAttribute("The number of AdSense ad units viewed. An Ad unit is a set of ads displayed as a result of one piece of the AdSense ad code. Details: https://support.google.com/adsense/answer/32715?hl=en")]
            public static DataItem adsenseAdUnitsViewed = new DataItem("adsenseAdUnitsViewed");
                                      
            [DescriptionAttribute("The number of AdSense ads viewed. Multiple ads can be displayed within an Ad Unit.")]
            public static DataItem adsenseAdsViewed = new DataItem("adsenseAdsViewed");
                                      
            [DescriptionAttribute("The number of times AdSense ads on your site were clicked.")]
            public static DataItem adsenseAdsClicks = new DataItem("adsenseAdsClicks");
                                      
            [DescriptionAttribute("The number of pageviews during which an AdSense ad was displayed. A page impression can have multiple Ad Units.")]
            public static DataItem adsensePageImpressions = new DataItem("adsensePageImpressions");
                                      
            [DescriptionAttribute("The number of sessions that ended due to a user clicking on an AdSense ad.")]
            public static DataItem adsenseExits = new DataItem("adsenseExits");
                                      

            public sealed class Calculated
            {
                
            [DescriptionAttribute("The percentage of page impressions that resulted in a click on an AdSense ad. (ga:adsenseAdsClicks/ga:adsensePageImpressions ) ")]
            public static DataItem adsenseCTR = new DataItem("adsenseCTR");
                                      
            [DescriptionAttribute("The estimated cost per thousand page impressions. It is your AdSense Revenue per 1000 page impressions. (ga:adsenseRevenue/(ga:adsensePageImpressions/1000) ) ")]
            public static DataItem adsenseECPM = new DataItem("adsenseECPM");
                                      
            }
        }
    }
}
