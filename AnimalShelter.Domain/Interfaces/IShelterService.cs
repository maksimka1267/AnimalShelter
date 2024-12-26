namespace AnimalShelter.Domain.Interfaces;

public interface IShelterService<TModel>
{
    Task<IEnumerable<TModel>> GetAllAsync();
    Task<TModel> GetByIdAsync(Guid id);
    Task AddAsync(TModel model);
}