namespace HealthandFitnessTrackerAPI.Models;

public class WorkoutPlan
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Title { get; set; }       
    public string Description { get; set; }

    public string UserId { get; set; }         
    public string TrainerId { get; set; }      

    public List<WorkoutDay> Days { get; set; } = new();

    public string GoalType { get; set; }      

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public bool IsActive { get; set; } = true;
}