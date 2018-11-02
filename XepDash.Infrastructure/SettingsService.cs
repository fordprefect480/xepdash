using System.Threading.Tasks;
using XepDash.Core;

namespace XepDash.Infrastructure
{
    public class SettingsService : ISettingsService
    {
        private ISettingsRepository _settingsRepository;

        public SettingsService(ISettingsRepository settingsRepository)
        {
            _settingsRepository = settingsRepository;
        }

        public async Task<ISettings> Get()
        {
            return await _settingsRepository.Get();
        }
    }
}