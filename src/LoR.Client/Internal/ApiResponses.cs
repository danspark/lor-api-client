using System.Collections.Generic;

namespace LoR.Client.Internal
{
    public record ActiveDeckResponse(string DeckCode, Dictionary<string, int> CardsInDeck);

    public record ScreenResponse(int ScreenWidth, int ScreenHeight) { }

    public record RectangleResponse(int CardId, string CardCode, int TopLeftX, int TopLeftY,
    int Width, int Height, bool LocalPlayer)
    { }
    public record CardPositionsResponse(string PlayerName, string OpponentName, string GameState,
    ScreenResponse Screen, RectangleResponse[] Rectangles)
    { }

    public record ExpeditionsResponse(bool IsActive, string State, string[] Record, string[] DraftPicks,
string[] Deck, int Games, int Wins, int Losses)
    { }

    public record GameResultResponse(int GameID, bool LocalPlayerWon) { }
}