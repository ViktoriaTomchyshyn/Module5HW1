using System.Threading.Tasks;
using Module5HW1.Model;

namespace Module5HW1.Services.Abstractions;
public interface IResourceService
{
    Task<Resource> GetResource(int id);
    Task<CollectionData<Resource>> GetResources();
}
