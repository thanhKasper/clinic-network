using Microsoft.AspNetCore.Mvc;
using clientNetworkServer.Dto;

namespace clientNetworkServer.Controllers;

[ApiController]
[Route("api/clinics")]
public class ClinicsController : ControllerBase 
{
    [HttpPost("new")]
    public IActionResult CreateClinic(ClinicDto clinic)
    {

        return Ok(clinic);
    }
}