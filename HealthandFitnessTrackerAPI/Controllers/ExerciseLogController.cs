using Microsoft.AspNetCore.Mvc;
using HealthandFitnessTrackerAPI.Models;
using HealthandFitnessTrackerAPI.Services;

namespace HealthandFitnessTrackerAPI.Controllers;

[ApiController]
[Route("api/exercise-logs")]
public class ExerciseLogController : ControllerBase
{
    private readonly ExerciseLogService _service;

    public ExerciseLogController(ExerciseLogService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create(ExerciseLog log)
    {
        await _service.Add(log);
        return Ok(log);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAll());
    }
}