using System.Collections.Generic;

namespace LoR.Client.Internal
{
    public class ActiveDeckResponse
    {
        public string DeckCode { get; set; }

        public Dictionary<string, int> CardsInDeck { get; set; }
    }
}