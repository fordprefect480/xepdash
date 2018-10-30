namespace XepDash.Core
{
    public interface ISlide
    {
        int Id { get; set; }
        int OrderIndex { get; set; }
        string ImageUri { get; set; }
        bool IsActive { get; set; }
        string XamlPage { get; set; }

        void LoadData();
    }
}