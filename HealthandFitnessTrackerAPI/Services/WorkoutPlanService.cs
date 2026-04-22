namespace HealthandFitnessTrackerAPI.Services;

using HealthandFitnessTrackerAPI.Models;

public class WorkoutPlanService
{
    private readonly FirestoreRepository<WorkoutPlan> _repo;

    public WorkoutPlanService(FirestoreProvider provider)
    {
        _repo = new FirestoreRepository<WorkoutPlan>(provider.Db, "workoutPlans");
    }

    public Task Add(WorkoutPlan plan) => _repo.AddAsync(plan);

    public Task<List<WorkoutPlan>> GetAll() => _repo.GetAllAsync();

    public Task<List<WorkoutPlan>> GetByUser(string userId)
    {
        return _repo.GetAllAsync()
            .ContinueWith(t => t.Result.Where(x => x.UserId == userId).ToList());
    }
}