using Refit;
using System.Threading.Tasks;

namespace LoR.Client.Internal
{
    public interface IRuneterraInternalClient
    {
        [Get("/static-decklist")]
        Task<ActiveDeckResponse> GetActiveDeckAsync();

        [Get("/positional-rectangles")]
        Task<CardPositionsResponse> GetCardPositionsAsync();

        [Get("/expeditions-state")]
        Task<ExpeditionsResponse> GetExpeditionsStateAsync();

        [Get("/game-result")]
        Task<GameResultResponse> GetLastGameResultAsync();
    }
}