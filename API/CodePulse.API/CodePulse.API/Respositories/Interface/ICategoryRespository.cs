using CodePulse.API.Models.Domain;

namespace CodePulse.API.Respositories.Interface
{
    public interface ICategoryRespository
    {
        Task<Category> CreateAsync(Category category);

        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category?> GetById(Guid id);
        Task<Category?> UpdateAsync(Category category);

        Task<Category?> DeleteAsync(Guid id);
    }
}
