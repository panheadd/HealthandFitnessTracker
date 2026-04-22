namespace HealthandFitnessTrackerAPI.Models;

public class ExerciseLog
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string ExerciseName { get; set; }
    public int DurationMinutes { get; set; }
    public DateTime Date { get; set; } = DateTime.UtcNow;
}