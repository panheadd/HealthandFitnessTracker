namespace HealthandFitnessTrackerAPI.Models;

public class Trainer
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Name { get; set; }
    public string Email { get; set; }

    public List<string> ClientIds { get; set; } = new();
}