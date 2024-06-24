using CodePulse.API.Models.Domain;

namespace CodePulse.API.Respositories.Interface
{
    public interface IImageRespository
    {
        Task<BlogImage> Upload(IFormFile file, BlogImage blogImage);

        Task<IEnumerable<BlogImage>> GetAll();
    }
}
