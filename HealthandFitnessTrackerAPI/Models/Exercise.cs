namespace HealthandFitnessTrackerAPI.Models;
using Google.Cloud.Firestore;

[FirestoreData]
public class Exercise
{
    [FirestoreProperty] public string Name { get; set; }          
    [FirestoreProperty] public int Sets { get; set; }
    [FirestoreProperty] public int Reps { get; set; }
    [FirestoreProperty] public int RestSeconds { get; set; }
    [FirestoreProperty] public string Notes { get; set; }
}