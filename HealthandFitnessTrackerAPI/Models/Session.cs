namespace HealthandFitnessTrackerAPI.Models;

public class Session
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string UserId { get; set; }
    public string TrainerId { get; set; }

    public DateTime ScheduledAt { get; set; }
    public bool IsCompleted { get; set; }
}