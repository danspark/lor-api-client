namespace LoR.Client.Internal
{
    public class CardPositionsResponse
    {
        public string PlayerName { get; set; }

        public string OpponentName { get; set; }

        public string GameState { get; set; }

        public ScreenResponse Screen { get; set; }

        public RectangleResponse[] Rectangles { get; set; }

        public class ScreenResponse
        {
            public string ScreenWidth { get; set; }

            public string ScreenHeight { get; set; }
        }

        public class RectangleResponse
        {
            public int CardId { get; set; }

            public string CardCode { get; set; }

            public int TopLeftX { get; set; }

            public int TopLeftY { get; set; }

            public int Width { get; set; }

            public int Height { get; set; }

            public bool LocalPlayer { get; set; }
        }
    }
}