using HealthandFitnessTrackerAPI.Services;

namespace HealthandFitnessTrackerAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using HealthandFitnessTrackerAPI.Models;

[ApiController]
[Route("api/trainers")]
public class TrainerController : ControllerBase
{
    private readonly TrainerService _service;

    public TrainerController(TrainerService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> Create(Trainer trainer)
    {
        await _service.Add(trainer);
        return Ok(trainer);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAll());
    }
}