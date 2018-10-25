namespace XepDash.Business.Models
{
    public interface ISlide
    {
        int Id { get; set; }
        int OrderIndex { get; set; }
        string ImageUri { get; set; }
        bool IsActive { get; set; }

        void LoadData();
    }
}