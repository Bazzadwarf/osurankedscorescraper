using System;
using HtmlAgilityPack;

namespace osurankedsscorescraper
{
    internal class Player
    {
        public int Rank { get; set; }
        public string Country { get; set; }
        public string Username { get; set; }
        public double Accuracy { get; set; }
        public int PlayCount { get; set; }
        public long TotalScore { get; set; }
        public long RankedScore { get; set; }
        public int SsRankCount { get; set; }
        public int SRankCount { get; set; }
        public int ARankCount { get; set; }

        public Player()
        {
            Rank = int.MaxValue;
            Country = string.Empty;
            Username = string.Empty;
            Accuracy = double.MinValue;
            PlayCount = int.MinValue;
            TotalScore = long.MinValue;
            RankedScore = long.MinValue;
            SsRankCount = int.MinValue;
            SRankCount = int.MinValue;
            ARankCount = int.MinValue;
        }
        
        public Player(HtmlNode inputNode)
        {
            ParseRank(inputNode);
            ParseCountry(inputNode);
            ParseUsername(inputNode);
            ParseAccuracy(inputNode);
            ParsePlayCount(inputNode);
            ParseTotalScore(inputNode);
            ParseRankedScore(inputNode);
            ParseSsRankCount(inputNode);
            ParseSRankCount(inputNode);
            ParseARankCount(inputNode);

            Console.WriteLine(Rank + " " + Country + " " + Username + " " + Accuracy + " " + PlayCount + " " + TotalScore + " " + RankedScore + " " + SsRankCount + " " + SRankCount + " " + ARankCount);
        }

        private void ParseRank(HtmlNode inputNode)
        {
            Rank = int.Parse(inputNode.ChildNodes[1].InnerText.Trim().Remove(0, 1));
        }

        private void ParseCountry(HtmlNode inputNode)
        {
            var getHrefValue = inputNode.ChildNodes[3].InnerHtml.Split('"');

            Country = getHrefValue[7];
        }
        
        private void ParseUsername(HtmlNode inputNode)
        {
            Username = inputNode.ChildNodes[3].InnerText.Trim();
        }

        private void ParseAccuracy(HtmlNode inputNode)
        {
            var acc = inputNode.ChildNodes[5].InnerText.Trim();

            Accuracy = double.Parse(acc.Remove(acc.Length - 1, 1));
        }

        private void ParsePlayCount(HtmlNode inputNode)
        {
            PlayCount = int.Parse(inputNode.ChildNodes[7].InnerText.Trim().Replace(",", ""));
        }

        private void ParseTotalScore(HtmlNode inputNode)
        {
            var innerHtml = inputNode.ChildNodes[9].InnerHtml;

            var i = innerHtml.IndexOf("'", StringComparison.Ordinal);
            var substring = innerHtml.Substring(i + 1, i);
            substring = substring.Substring(0, substring.IndexOf("'", StringComparison.Ordinal));
            substring = substring.Replace(",", "");
            TotalScore = long.Parse(substring);
        }

        private void ParseRankedScore(HtmlNode inputNode)
        {
            var innerHtml = inputNode.ChildNodes[11].InnerHtml;

            var i = innerHtml.IndexOf("'", StringComparison.Ordinal);
            var substring = innerHtml.Substring(i + 1, i);
            substring = substring.Substring(0, substring.IndexOf("'", StringComparison.Ordinal));
            substring = substring.Replace(",", "");
            RankedScore = long.Parse(substring);
        }

        private void ParseSsRankCount(HtmlNode inputNode)
        {
            SsRankCount = int.Parse(inputNode.ChildNodes[13].InnerText.Trim().Replace(",", ""));
        }

        private void ParseSRankCount(HtmlNode inputNode)
        {
            SRankCount = int.Parse(inputNode.ChildNodes[15].InnerText.Trim().Replace(",", ""));
        }

        private void ParseARankCount(HtmlNode inputNode)
        {
            ARankCount = int.Parse(inputNode.ChildNodes[17].InnerText.Trim().Replace(",", ""));
        }
    }
}