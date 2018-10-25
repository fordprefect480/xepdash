using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Windows.Storage;
using XepDash.Business.Models;

namespace XepDash.Data
{
    public interface ISettingsRepository
    {
        Task<Settings> Get();

        bool Update(Settings settings);
    }

    public class FileSettingsRepository : ISettingsRepository
    { 
        public async Task<Settings> Get()
        {
            // Create a file in the root called settings.json and store settings in json format.
            // Make sure to set "Build Action" of file to "content".
            var uri = new Uri("ms-appx:///settings.json");
            var settingsFile = await StorageFile.GetFileFromApplicationUriAsync(uri);
            var fileString = await FileIO.ReadTextAsync(settingsFile);
            return JsonConvert.DeserializeObject<Settings>(fileString);            
        }

        public bool Update(Settings settings)
        {
            throw new NotImplementedException();
        }
    }
}
