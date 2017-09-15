
using System.Net.Http;
using System.Threading.Tasks;

namespace DeckTracker.Services
{
    public class APIService
    {
        HttpClient client;

        public APIService()
        {
            client = new HttpClient();
        }

        public async Task<JsonResponse> AddDeck()
        {

        }
    }
}
