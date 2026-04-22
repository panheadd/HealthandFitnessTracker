using Microsoft.AspNetCore.Mvc;
using HealthandFitnessTrackerAPI.Models;
using HealthandFitnessTrackerAPI.Services;

namespace HealthandFitnessTrackerAPI.Controllers;

[ApiController]
[Route("api/workout-plans")]
public class WorkoutPlanController : ControllerBase
{
    private readonly WorkoutPlanService _service;

    public WorkoutPlanController(WorkoutPlanService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create(WorkoutPlan plan)
    {
        await _service.Add(plan);
        return Ok(plan);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAll());
    }

    [HttpGet("user/{userId}")]
    public async Task<IActionResult> GetByUser(string userId)
    {
        var plans = await _service.GetByUser(userId);
        return Ok(plans);
    }
}