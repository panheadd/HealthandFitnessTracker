namespace HealthandFitnessTrackerAPI;

using Google.Cloud.Firestore;

[FirestoreData]
public class User
{
    [FirestoreProperty] public string Username { get; set; }

    [FirestoreProperty] public int Age { get; set; }

    [FirestoreProperty] public string Email { get; set; }
}