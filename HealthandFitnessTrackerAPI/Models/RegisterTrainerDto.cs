namespace HealthandFitnessTrackerAPI.Models;
using Google.Cloud.Firestore;

[FirestoreData]
public class RegisterTrainerDto
{
    [FirestoreProperty] public string Name { get; set; }
    [FirestoreProperty] public string Email { get; set; }
    [FirestoreProperty] public string Password { get; set; }
}