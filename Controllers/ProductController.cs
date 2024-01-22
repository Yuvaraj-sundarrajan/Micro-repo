using Microsoft.AspNetCore.Mvc;
using UpdateWebapi.Model;
using UpdateWebapi.Data;
using Microsoft.EntityFrameworkCore;
namespace UpdateWebapi.Controllers{
[ApiController]
public class UpdateProductController : ControllerBase
{
    private readonly AppDbContext _context;
    public UpdateProductController(AppDbContext context)
    {
        _context = context;
    }
    [Route("api/UpdateProduct")]
    [HttpPut]
    public async Task<IActionResult> Updateuser(Vehicle vehicle)
    {
        if (vehicle == null || vehicle.VehicleID == 0)
            return BadRequest();

       
        _context.Entry(vehicle).State=EntityState.Modified;
        await _context.SaveChangesAsync();
        return Ok();
       }
}
}
