using Google.Cloud.Firestore;
using HealthandFitnessTrackerAPI;

var builder = WebApplication.CreateBuilder(args);

// 🔥 KRİTİK: ADC ENV FIX
Environment.SetEnvironmentVariable(
    "GOOGLE_APPLICATION_CREDENTIALS",
    Path.Combine(Directory.GetCurrentDirectory(), "firebase-key.json")
);

// Services
builder.Services.AddSingleton<FirestoreService>();
builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();