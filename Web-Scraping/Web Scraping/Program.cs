using HtmlAgilityPack;
using System;

namespace Web_Scraping
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = "https://cv.lt/nuolatinis-darbas?department=1040&city=1010";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);
            var jobTitles = htmlDoc.DocumentNode.SelectNodes("//*[@class='info-wr']");

            foreach (var jobTitle in jobTitles)
            {   
                Console.WriteLine(jobTitle.SelectSingleNode("button").InnerText);
            }



          
        }
    }
}
