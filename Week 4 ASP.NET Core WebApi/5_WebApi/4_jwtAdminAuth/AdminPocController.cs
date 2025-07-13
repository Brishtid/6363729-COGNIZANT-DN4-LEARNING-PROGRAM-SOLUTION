using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

[ApiController]
[Route("api/[controller]")]
[Authorize(Roles = "Admin,POC")]
public class EmployeeController : ControllerBase
{
    [HttpGet("secure-data")]
    public IActionResult GetSecureData()
    {
        var userId = User.FindFirst("UserId")?.Value;
        var role = User.FindFirst(ClaimTypes.Role)?.Value;

        return Ok(new { message = "This is secured", userId, role });
    }
}
