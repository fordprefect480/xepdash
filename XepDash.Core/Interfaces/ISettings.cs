namespace XepDash.Core
{
    public interface ISettings
    {
        int PollingIntervalSeconds { get; set; }
        int SlideIntervalSeconds { get; set; }
    }
}