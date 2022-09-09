using Microsoft.AspNetCore.Mvc;
using Prisma.Domain.Dtos.Address.Request;
using Prisma.Domain.Exceptions;
using Prisma.Domain.Services;

namespace Prisma.Api.Controllers
{
    [ApiController]
    [Route("api/address")]
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
            try
            {
                var result = _addressService.Create(request);
                return CreatedAtAction(nameof(Get), new { Id = result.Id }, result);
            }
            catch (EntityAlreadyRegisteredException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var getAddress = _addressService.Get(id);
                return Ok(getAddress);
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet]
        [Route("list")]
        public IActionResult List(int id)
        {
            try
            {
                var getAddressList = _addressService.List();
                return Ok(getAddressList);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpDelete]
        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            try
            {
                _addressService.Remove(id);
                return NoContent();
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPatch]
        [Route("update/{id}")]
        public IActionResult Update(int id, [FromBody] UpdateAddressRequest request)
        {
            try
            {
                _addressService.Update(id, request);
                return Get(id);
            }
            catch (EntityNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
