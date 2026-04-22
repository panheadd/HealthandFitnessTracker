namespace HealthandFitnessTrackerAPI.Models;
using Google.Cloud.Firestore;

[FirestoreData]
public class Goal
{
    [FirestoreProperty] public string Type { get; set; } 
    [FirestoreProperty] public double TargetValue { get; set; }
    [FirestoreProperty] public double CurrentValue { get; set; }
}