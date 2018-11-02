using System.Threading.Tasks;

namespace XepDash.Core
{
    public interface ISettingsRepository
    {
        Task<ISettings> Get();

        bool Update(ISettings settings);
    }
}
