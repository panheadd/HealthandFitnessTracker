namespace HealthandFitnessTrackerAPI.Models;
using Google.Cloud.Firestore;

[FirestoreData]
public class Session
{
    [FirestoreProperty] public string Id { get; set; } = Guid.NewGuid().ToString();
    [FirestoreProperty] public string UserId { get; set; }
    [FirestoreProperty] public string TrainerId { get; set; }

    [FirestoreProperty] public DateTime ScheduledAt { get; set; }
    [FirestoreProperty] public bool IsCompleted { get; set; }
}