using Google.Cloud.Firestore;
using HealthandFitnessTrackerAPI.Services;

var builder = WebApplication.CreateBuilder(args);


Environment.SetEnvironmentVariable(
    "GOOGLE_APPLICATION_CREDENTIALS",
    Path.Combine(Directory.GetCurrentDirectory(), "firebase-key.json")
);


builder.Services.AddSingleton<FirestoreProvider>(sp =>
{
    return new FirestoreProvider();
});


builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<TrainerService>();
builder.Services.AddScoped<WorkoutPlanService>();
builder.Services.AddScoped<SessionService>();
builder.Services.AddScoped<ExerciseLogService>();
builder.Services.AddScoped<GoalService>();


builder.Services.AddControllers();

var app = builder.Build();


app.UseRouting();

app.MapControllers();

app.Run();