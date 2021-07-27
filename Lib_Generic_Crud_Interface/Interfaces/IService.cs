using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Interfaces
{
    public interface IService
    {
        IServiceCollection AddServices(IServiceCollection services, IConfiguration configuration = null);
    }
}
