namespace HealthandFitnessTrackerAPI.Services;

using HealthandFitnessTrackerAPI.Models;

public class ExerciseLogService
{
    private readonly FirestoreRepository<ExerciseLog> _repo;

    public ExerciseLogService(FirestoreProvider provider)
    {
        _repo = new FirestoreRepository<ExerciseLog>(provider.Db, "exerciseLogs");
    }

    public Task Add(ExerciseLog log) => _repo.AddAsync(log);

    public Task<List<ExerciseLog>> GetAll() => _repo.GetAllAsync();
}