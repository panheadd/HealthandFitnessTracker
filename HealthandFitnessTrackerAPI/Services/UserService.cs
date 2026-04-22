using HealthandFitnessTrackerAPI.Models;
using HealthandFitnessTrackerAPI.Services;

public class UserService
{
    private readonly FirestoreRepository<User> _repo;

    public UserService(FirestoreProvider provider)
    {
        _repo = new FirestoreRepository<User>(provider.Db, "users");
    }

    public Task Add(User user) => _repo.AddAsync(user);

    public Task<List<User>> GetAll() => _repo.GetAllAsync();

    public Task<User?> Get(string id) => _repo.GetByIdAsync(id);

    public Task Update(string id, User user) => _repo.UpdateAsync(id, user);

    public Task Delete(string id) => _repo.DeleteAsync(id);
}