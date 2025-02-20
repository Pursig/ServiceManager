using Microsoft.AspNetCore.Mvc;
using ServiceManager.Data;

namespace ServiceManager.Controllers
{
    [Route("api/Service")]
    [ApiController]
public class ServiceController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public ServiceController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetService()
    {
        var services = _context.Services.ToList();
        return Ok(services);
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult GetServiceById([FromRoute] Guid id)
    {
        var services = _context.Services.Find(id);
        
        if(services == null)
            return NotFound();
        return Ok(services);
    }
}
}