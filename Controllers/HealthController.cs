using Microsoft.AspNetCore.Mvc;

namespace DevOpsDeployment.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet("ready")]
    public IActionResult Ready() => Ok(new { status = "ready" });

    [HttpGet("live")]
    public IActionResult Live() => Ok(new { status = "live" });
}
