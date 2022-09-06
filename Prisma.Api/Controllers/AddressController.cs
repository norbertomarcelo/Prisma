using Microsoft.AspNetCore.Mvc;
using Prisma.Domain.Dto.Address.Request;
using Prisma.Domain.Services;

namespace Prisma.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : ControllerBase
    {
        private readonly AddressService _addressService;

        public AddressController(AddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(CreateAddressRequest request)
        {
            _addressService.Create(request);
            return Ok();
        }
    }
}
