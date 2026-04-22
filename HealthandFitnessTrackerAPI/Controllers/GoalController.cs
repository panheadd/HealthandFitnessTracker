using Microsoft.AspNetCore.Mvc;
using HealthandFitnessTrackerAPI.Models;
using HealthandFitnessTrackerAPI.Services;

namespace HealthandFitnessTrackerAPI.Controllers;

[ApiController]
[Route("api/goals")]
public class GoalController : ControllerBase
{
    private readonly GoalService _service;

    public GoalController(GoalService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create(Goal goal)
    {
        await _service.Add(goal);
        return Ok(goal);
    }
}