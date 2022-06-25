using SendboxAPI.Models;
using SendboxAPI.Models.Dtos;

namespace SendboxAPI.Services
{
    public interface IOfferService
    {
        Task<SendboxOfferResponse> GetOffer(SendBoxOfferRequest payload);
    }
}
