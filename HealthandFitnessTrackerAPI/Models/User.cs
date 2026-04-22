namespace HealthandFitnessTrackerAPI.Models;

public class User
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Username { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public List<string> TrainerIds { get; set; } = new();
    public List<ExerciseLog> ExerciseLogs { get; set; } = new();
    public Goal Goal { get; set; }
}