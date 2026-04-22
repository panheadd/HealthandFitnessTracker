using HealthandFitnessTrackerAPI.Services;

namespace HealthandFitnessTrackerAPI.Controllers;

using Microsoft.AspNetCore.Mvc;
using HealthandFitnessTrackerAPI.Models;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly UserService _userService;
    private readonly TrainerService _trainerService;

    public AuthController(UserService userService, TrainerService trainerService)
    {
        _userService = userService;
        _trainerService = trainerService;
    }
    
    [HttpPost("register/user")]
    public async Task<IActionResult> RegisterUser(RegisterUserDto dto)
    {
        var user = new User
        {
            Username = dto.Username,
            Email = dto.Email,
            Age = dto.Age,
            Password = dto.Password
        };

        await _userService.Add(user);

        return Ok(new
        {
            message = "User registered successfully",
            user.Id
        });
    }
    
    [HttpPost("register/trainer")]
    public async Task<IActionResult> RegisterTrainer(RegisterTrainerDto dto)
    {
        var trainer = new Trainer
        {
            Name = dto.Name,
            Email = dto.Email,
            Password = dto.Password
        };

        await _trainerService.Add(trainer);

        return Ok(new
        {
            message = "Trainer registered successfully",
            trainer.Id
        });
    }
    
    [HttpPost("login/user")]
    public async Task<IActionResult> LoginUser(LoginDto dto)
    {
        var users = await _userService.GetAll();

        var user = users.FirstOrDefault(x =>
            x.Email == dto.Email &&
            x.Password == dto.Password
        );

        if (user == null)
            return Unauthorized("Invalid user credentials");

        return Ok(new
        {
            message = "User login successful",
            user.Id,
            user.Username
        });
    }
    
    [HttpPost("login/trainer")]
    public async Task<IActionResult> LoginTrainer(LoginDto dto)
    {
        var trainers = await _trainerService.GetAll();

        var trainer = trainers.FirstOrDefault(x =>
            x.Email == dto.Email &&
            x.Password == dto.Password
        );

        if (trainer == null)
            return Unauthorized("Invalid trainer credentials");

        return Ok(new
        {
            message = "Trainer login successful",
            trainer.Id,
            trainer.Name
        });
    }
}