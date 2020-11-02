using System.Threading.Tasks;
using Refit;

namespace LoR.Client.Internal
{
    public interface IRuneterraInternalClient
    {
        [Get("/static-decklist")]
        Task<ActiveDeckResponse> GetActiveDeckAsync();

        [Get("/positional-rectangles")]
        Task<CardPositionsResponse> GetCardPositions();

        [Get("/expeditions-state")]
        Task<ExpeditionsResponse> GetExpeditionsState();

        [Get("/game-result")]
        Task<GameResultResponse> GetLastGameResult();
    }
}