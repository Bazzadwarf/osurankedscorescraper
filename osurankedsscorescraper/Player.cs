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
        public int TotalScore { get; set; }
        public int RankedScore { get; set; }
        public int SsRankCount { get; set; }
        public int SRankCount { get; set; }
        public int ARankCount { get; set; }

        public Player(HtmlNode inputHtml)
        {
            
        }

        private void ParseRank(HtmlNode inputNode)
        {
            
        }

        private void ParseUsername(HtmlNode inputNode)
        {
            
        }

        private void ParseAccuracy(HtmlNode inputNode)
        {
            
        }

        private void ParsePlayCount(HtmlNode inputNode)
        {
            
        }
        
        private void ParseTotalScore(HtmlNode inputNode)
        {
            
        }
        
        private void ParseRankedScore(HtmlNode inputNode)
        {
            
        }
        
        private void ParseSsRankCount(HtmlNode inputNode)
        {
            
        }
        
        private void ParseSRankCount(HtmlNode inputNode)
        {
            
        }
        
        private void ParseARankCount(HtmlNode inputNode)
        {
            
        }
    }
}