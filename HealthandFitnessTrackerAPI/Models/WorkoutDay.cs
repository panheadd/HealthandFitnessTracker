namespace HealthandFitnessTrackerAPI.Models;
using Google.Cloud.Firestore;

[FirestoreData]
public class WorkoutDay
{
    [FirestoreProperty] public string DayName { get; set; }  

    [FirestoreProperty] public List<Exercise> Exercises { get; set; } = new();
}