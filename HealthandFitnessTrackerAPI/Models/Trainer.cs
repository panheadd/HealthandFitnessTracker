namespace HealthandFitnessTrackerAPI.Models;
using Google.Cloud.Firestore;

[FirestoreData]
public class Trainer
{
    [FirestoreProperty] public string Id { get; set; } = Guid.NewGuid().ToString();
    [FirestoreProperty] public string Name { get; set; }
    [FirestoreProperty] public string Email { get; set; }
    [FirestoreProperty] public string Password { get; set; }

    [FirestoreProperty] public List<string> ClientIds { get; set; } = new();
}