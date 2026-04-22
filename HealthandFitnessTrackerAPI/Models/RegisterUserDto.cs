namespace HealthandFitnessTrackerAPI.Models;
using Google.Cloud.Firestore;

[FirestoreData]
public class RegisterUserDto
{
    [FirestoreProperty] public string Username { get; set; }
    [FirestoreProperty] public string Email { get; set; }
    [FirestoreProperty] public int Age { get; set; }
    [FirestoreProperty] public string Password { get; set; }
}