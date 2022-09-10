using Microsoft.AspNetCore.Mvc;
using Prisma.Domain.Dtos.Address.Request;
using Prisma.Domain.Dtos.Prescriber.Request;
using Prisma.Domain.Exceptions;
using Prisma.Domain.Services;

namespace Prisma.Api.Controllers
{
    [ApiController]
    [Route("api/prescriber")]
    public class PrescriberController : ControllerBase
    {
        private readonly PrescriberService _prescriberService;

        public PrescriberController(PrescriberService prescriberService)
        {
            _prescriberService = prescriberService;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(CreatePrescriberRequest request)
        {
            try
            {
                var result = _prescriberService.Create(request);
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
                var getPrescriber = _prescriberService.Get(id);
                return Ok(getPrescriber);
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
        public IActionResult List()
        {
            try
            {
                var getPrescriberList = _prescriberService.List();
                return Ok(getPrescriberList);
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
                _prescriberService.Remove(id);
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
        public IActionResult Update(int id, [FromBody] UpdatePrescriberRequest request)
        {
            try
            {
                _prescriberService.Update(id, request);
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
