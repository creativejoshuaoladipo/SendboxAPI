using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SendboxAPI.Models;
using SendboxAPI.Services;
using System.Net.Mime;
using System.Web.Http.Filters;

namespace SendboxAPI.Controllers
{
    [Route("api/")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private readonly IOfferService _offerService;

        public OffersController(IOfferService offerService)
        {
            _offerService = offerService;
        }
        [HttpPost]
        [Route("GetOffer")]
     //   [Consumes(MediaTypeNames.Application.Xml)]
        [Consumes("text/xml")]
        public async Task<IActionResult> GetOffer([FromBody] SendBoxOfferRequest request)
        {
            var result = await _offerService.GetOffer(request);
            return Ok(result);
        }

    
    }
}
