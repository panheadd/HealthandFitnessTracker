namespace HealthandFitnessTrackerAPI.Models;

public class Goal
{
    public string Type { get; set; } 
    public double TargetValue { get; set; }
    public double CurrentValue { get; set; }
}