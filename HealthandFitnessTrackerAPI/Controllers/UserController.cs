namespace HealthandFitnessTrackerAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using HealthandFitnessTrackerAPI.Models;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly UserService _service;

    public UserController(UserService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create(User user)
    {
        await _service.Add(user);
        return Ok(user);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users = await _service.GetAll();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var user = await _service.Get(id);
        return user == null ? NotFound() : Ok(user);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(string id, User user)
    {
        await _service.Update(id, user);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _service.Delete(id);
        return Ok();
    }
}