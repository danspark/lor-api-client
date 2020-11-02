namespace LoR.Client.Internal
{
    public class ExpeditionsResponse
    {
        public bool IsActive { get; set; }

        public string State { get; set; }

        public string[] Record { get; set; }

        public string[] DraftPicks { get; set; }

        public string[] Deck { get; set; }

        public int Games { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }
    }
}