using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using Windows.Storage;
using XepDash.Core;

namespace XepDash.Infrastructure
{
    public class FileSettingsRepository : ISettingsRepository
    { 
        public async Task<ISettings> Get()
        {
            // Create a file in the root called settings.json and store settings in json format.
            // Make sure to set "Build Action" of file to "content".
            var uri = new Uri("ms-appx:///settings.json");
            var settingsFile = await StorageFile.GetFileFromApplicationUriAsync(uri);
            var fileString = await FileIO.ReadTextAsync(settingsFile);
            return JsonConvert.DeserializeObject<Settings>(fileString);            
        }

        public bool Update(ISettings settings)
        {
            throw new NotImplementedException();
        }
    }
}
