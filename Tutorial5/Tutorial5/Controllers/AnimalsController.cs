using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Tutorial5.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class AnimalsController : ControllerBase
{
    private readonly IConfiguration _configuration;
    public AnimalsController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    
    [HttpGet]
    public IActionResult GetAnimals()
    {
        SqlConnection sqlConnection = new SqlConnection(_configuration.GetConnectionString("Default"));
        sqlConnection.Open();
        return Ok();
    }
}