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
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(string id)
    {
        var trainer = await _service.Get(id);
        return trainer == null ? NotFound() : Ok(trainer);
    }
    public async Task<IActionResult> Update(string id, Trainer trainer)
    {
        await _service.Update(id, trainer);
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(string id)
    {
        await _service.Delete(id);
        return Ok();
    }
}