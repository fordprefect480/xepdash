namespace XepDash.Core
{
    public interface ISlide
    {
        int OrderIndex { get; set; }

        void LoadData();
    }
}