using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;
using CsvHelper;

namespace osurankedsscorescraper
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var web = new HtmlWeb();
            const string baseUrl = "https://osu.ppy.sh/rankings/osu/score?page=";
            
            TextWriter textWriter = new StreamWriter("test.csv");
            
            var csv = new CsvWriter(textWriter, CultureInfo.CurrentCulture);
            
            for (var pageNumber = 1; pageNumber <= 200; pageNumber++)
            {
                var doc = web.Load(baseUrl + pageNumber);
            
                var tableBody = doc.DocumentNode.SelectNodes("//table//tbody//tr");
                
                csv.WriteRecords(tableBody.Select(tableRow => new Player(tableRow)).ToList());
                csv.Flush();
                System.Threading.Thread.Sleep(1000);
            }
            textWriter.Close();
        }
    }
}