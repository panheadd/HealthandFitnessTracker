using Google.Apis.Auth.OAuth2;
using Google.Cloud.Firestore;

namespace HealthandFitnessTrackerAPI.Services;

public class FirestoreProvider
{
    public FirestoreDb Db { get; }

    public FirestoreProvider()
    {
        var credential = GoogleCredential
            .FromFile("firebase-key.json")
            .CreateScoped("https://www.googleapis.com/auth/cloud-platform");

        Db = new FirestoreDbBuilder
        {
            ProjectId = "health-and-fitness-track-4b4f6",
            Credential = credential
        }.Build();
    }
}