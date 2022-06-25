using SendboxAPI.Models;
using SendboxAPI.Models.Dtos;

namespace SendboxAPI.Services
{
    public class OfferService: IOfferService
    {

        public OfferService()
        {

        }
        private static List<SendBoxOfferRequest> offers = new List<SendBoxOfferRequest>();

        public async Task<SendboxOfferResponse> GetOffer(SendBoxOfferRequest payload)
        {
            var serviceResponse = new SendboxOfferResponse();
            offers.Add(payload);
            serviceResponse.Quote = 3.0M;

            return serviceResponse;
        }
    }
}
