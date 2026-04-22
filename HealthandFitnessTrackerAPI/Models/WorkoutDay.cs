namespace HealthandFitnessTrackerAPI.Models;

public class WorkoutDay
{
    public string DayName { get; set; }  

    public List<Exercise> Exercises { get; set; } = new();
}