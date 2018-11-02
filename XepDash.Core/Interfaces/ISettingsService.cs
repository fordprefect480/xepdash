using System.Threading.Tasks;

namespace XepDash.Core
{
    public interface ISettingsService
    {
        Task<ISettings> Get();
    }
}