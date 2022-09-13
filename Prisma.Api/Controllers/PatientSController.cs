using Microsoft.AspNetCore.Mvc;
using Prisma.Domain.Dtos.Patient.Request;
using Prisma.Domain.Exceptions;
using Prisma.Domain.Services;

namespace Prisma.Api.Controllers
{
    [ApiController]
    [Route("api/patient")]
    public class PatientSController : ControllerBase
    {
        private readonly PatientService _patientService;

        public PatientSController(PatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(GetPatientResponse request)
        {
            try
            {
                var result = _patientService.Create(request);
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
                var getPatient = _patientService.Get(id);
                return Ok(Get);
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
                var getPatientList = _patientService.List();
                return Ok(getPatientList);
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
                _patientService.Remove(id);
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
        public IActionResult Update(int id, [FromBody] UpdatePatientRequest request)
        {
            try
            {
                _patientService.Update(id, request);
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
