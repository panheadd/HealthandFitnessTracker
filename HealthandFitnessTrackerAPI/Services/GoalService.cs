namespace HealthandFitnessTrackerAPI.Services;

using HealthandFitnessTrackerAPI.Models;

public class GoalService
{
    private readonly FirestoreRepository<Goal> _repo;

    public GoalService(FirestoreProvider provider)
    {
        _repo = new FirestoreRepository<Goal>(provider.Db, "goals");
    }

    public Task Add(Goal g) => _repo.AddAsync(g);
}