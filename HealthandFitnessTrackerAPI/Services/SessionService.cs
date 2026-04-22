namespace HealthandFitnessTrackerAPI.Services;

using HealthandFitnessTrackerAPI.Models;

public class SessionService
{
    private readonly FirestoreRepository<Session> _repo;

    public SessionService(FirestoreProvider provider)
    {
        _repo = new FirestoreRepository<Session>(provider.Db, "sessions");
    }

    public Task Add(Session s) => _repo.AddAsync(s);

    public Task<List<Session>> GetAll() => _repo.GetAllAsync();

    public async Task CompleteSession(string id)
    {
        var session = await _repo.GetByIdAsync(id);
        if (session == null) return;

        session.IsCompleted = true;
        await _repo.UpdateAsync(id, session);
    }
}