using HtmlAgilityPack;
using System;

namespace Web_Scraping
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = "https://www.cvonline.lt/darbo-skelbimai/informacines-technologijos/q-.net/q-.net/vilniaus?page=1";

            HtmlWeb web = new HtmlWeb();

            var htmlDoc = web.Load(html);
            var jobTitles = htmlDoc.DocumentNode.SelectNodes("//*[@class='offer_primary_info']");

            foreach (var jobTitle in jobTitles)
            {   
                Console.WriteLine(jobTitle.SelectSingleNode("h2").InnerText);
            }



          
        }
    }
}
