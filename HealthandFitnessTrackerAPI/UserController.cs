using Microsoft.AspNetCore.Mvc;

namespace HealthandFitnessTrackerAPI;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly FirestoreService _service;

    public UserController(FirestoreService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> CreateUser([FromBody] User user)
    {
        await _service.AddUserAsync(user);

        return Ok(new
        {
            message = "User added successfully",
            user
        });
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
        var users = await _service.GetUsersAsync();
        return Ok(users);
    }
}