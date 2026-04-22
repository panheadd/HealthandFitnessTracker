namespace HealthandFitnessTrackerAPI.Services;

using HealthandFitnessTrackerAPI.Models;

public class TrainerService
{
    private readonly FirestoreRepository<Trainer> _repo;

    public TrainerService(FirestoreProvider provider)
    {
        _repo = new FirestoreRepository<Trainer>(provider.Db, "trainers");
    }

    public Task Add(Trainer t) => _repo.AddAsync(t);
    public Task<List<Trainer>> GetAll() => _repo.GetAllAsync();
}