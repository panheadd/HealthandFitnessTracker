using Microsoft.AspNetCore.Mvc;
using HealthandFitnessTrackerAPI.Models;
using HealthandFitnessTrackerAPI.Services;

namespace HealthandFitnessTrackerAPI.Controllers;

[ApiController]
[Route("api/sessions")]
public class SessionController : ControllerBase
{
    private readonly SessionService _service;

    public SessionController(SessionService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create(Session session)
    {
        await _service.Add(session);
        return Ok(session);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAll());
    }

    [HttpPut("complete/{id}")]
    public async Task<IActionResult> Complete(string id)
    {
        await _service.CompleteSession(id);
        return Ok();
    }
}