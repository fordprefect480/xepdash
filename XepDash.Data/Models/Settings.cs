using XepDash.Core;
using XepDash.Infrastructure;

namespace XepDash.Infrastructure
{
    public class Settings : ISettings
    {
        public int SlideIntervalSeconds { get; set; }
        public int PollingIntervalSeconds { get; set; }
    }
}