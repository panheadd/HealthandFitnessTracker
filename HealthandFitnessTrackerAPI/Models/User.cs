namespace HealthandFitnessTrackerAPI.Models;
using Google.Cloud.Firestore;

[FirestoreData]
public class User
{
    [FirestoreProperty] public string Id { get; set; } = Guid.NewGuid().ToString();
    [FirestoreProperty] public string Username { get; set; }
    [FirestoreProperty] public string Email { get; set; }
    [FirestoreProperty] public string Password { get; set; }
    [FirestoreProperty] public int Age { get; set; }

    [FirestoreProperty] public List<string> TrainerIds { get; set; } = new();
    [FirestoreProperty] public List<ExerciseLog> ExerciseLogs { get; set; } = new();
    [FirestoreProperty] public Goal Goal { get; set; }
}