namespace HealthandFitnessTrackerAPI.Models;
using Google.Cloud.Firestore;

[FirestoreData]
public class WorkoutPlan
{
    [FirestoreProperty] public string Id { get; set; } = Guid.NewGuid().ToString();

    [FirestoreProperty] public string Title { get; set; }       
    [FirestoreProperty] public string Description { get; set; }

    [FirestoreProperty] public string UserId { get; set; }         
    [FirestoreProperty] public string TrainerId { get; set; }      

    [FirestoreProperty] public List<WorkoutDay> Days { get; set; } = new();

    [FirestoreProperty] public string GoalType { get; set; }      

    [FirestoreProperty] public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    [FirestoreProperty] public bool IsActive { get; set; } = true;
}