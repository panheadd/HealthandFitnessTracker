namespace HealthandFitnessTrackerAPI.Models;
using Google.Cloud.Firestore;

[FirestoreData]
public class ExerciseLog
{
    [FirestoreProperty] public string Id { get; set; } = Guid.NewGuid().ToString();
    [FirestoreProperty] public string ExerciseName { get; set; }
    [FirestoreProperty] public int DurationMinutes { get; set; }
    [FirestoreProperty] public DateTime Date { get; set; } = DateTime.UtcNow;
}