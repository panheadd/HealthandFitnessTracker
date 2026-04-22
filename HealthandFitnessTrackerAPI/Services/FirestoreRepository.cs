using Google.Cloud.Firestore;

namespace HealthandFitnessTrackerAPI.Services;

public class FirestoreRepository<T> where T : class
{
    private readonly FirestoreDb _db;
    private readonly string _collectionName;

    public FirestoreRepository(FirestoreDb db, string collectionName)
    {
        _db = db;
        _collectionName = collectionName;
    }

    private CollectionReference Collection => _db.Collection(_collectionName);

    public async Task AddAsync(T entity)
    {
        await Collection.AddAsync(entity);
    }

    public async Task<List<T>> GetAllAsync()
    {
        var snapshot = await Collection.GetSnapshotAsync();

        return snapshot.Documents
            .Select(d => d.ConvertTo<T>())
            .ToList();
    }

    public async Task<T?> GetByIdAsync(string id)
    {
        var doc = await Collection.Document(id).GetSnapshotAsync();
        return doc.Exists ? doc.ConvertTo<T>() : null;
    }

    public async Task UpdateAsync(string id, T entity)
    {
        await Collection.Document(id).SetAsync(entity, SetOptions.Overwrite);
    }

    public async Task DeleteAsync(string id)
    {
        await Collection.Document(id).DeleteAsync();
    }
}