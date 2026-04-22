using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace HealthandFitnessTrackerAPI;

public class FirestoreService
{
    private readonly FirestoreDb _db;

    public FirestoreService()
    {
        var credential = GoogleCredential
            .FromFile("firebase-key.json")
            .CreateScoped("https://www.googleapis.com/auth/cloud-platform");

        _db = new FirestoreDbBuilder
        {
            ProjectId = "health-and-fitness-track-4b4f6",
            Credential = credential
        }.Build();
    }

    public async Task AddWorkoutAsync(Dictionary<string, object> workout)
    {
        await _db.Collection("workouts").AddAsync(workout);
    }

    public async Task<List<Dictionary<string, object>>> GetWorkouts()
    {
        var snapshot = await _db.Collection("workouts").GetSnapshotAsync();

        return snapshot.Documents
            .Select(d => d.ToDictionary())
            .ToList();
    }
    
    public async Task AddUserAsync(User user)
    {
        await _db.Collection("users").AddAsync(user);
    }

    public async Task<List<User>> GetUsersAsync()
    {
        var snapshot = await _db.Collection("users").GetSnapshotAsync();

        return snapshot.Documents
            .Select(d => d.ConvertTo<User>())
            .ToList();
    }
}