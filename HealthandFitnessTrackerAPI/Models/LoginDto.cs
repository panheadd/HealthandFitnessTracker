namespace HealthandFitnessTrackerAPI.Models;
using Google.Cloud.Firestore;

[FirestoreData]
public class LoginDto
{
    [FirestoreProperty] public string Email { get; set; }
    [FirestoreProperty] public string Password { get; set; }
}