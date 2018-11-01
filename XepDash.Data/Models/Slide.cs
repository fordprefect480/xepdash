using XepDash.Core;

namespace XepDash.Infrastructure
{
    public class SlideOne : ISlide
    {
        public SlideOne()
        {

        }
        public int OrderIndex { get; set; }
        public string ImageUri { get; set; }
        public string DataTemplateName { get; set; }
        public string Name { get; set; }

        public void LoadData()
        {
            Name = "One";
            ImageUri = "http://placekitten.com/720/730";
        }
    }

    public class SlideTwo : ISlide
    {
        public SlideTwo()
        {

        }
        public int OrderIndex { get; set; }
        public string ImageUri { get; set; }
        public string DataTemplateName { get; set; }
        public string Name { get; set; }

        public void LoadData()
        {
            Name = "Two";
            ImageUri = "http://placekitten.com/500/500";
        }
    }


    public class SlideThree : ISlide
    {
        public SlideThree()
        {

        }
        public int OrderIndex { get; set; }
        public string ImageUri { get; set; }
        public string DataTemplateName { get; set; }
        public string Name { get; set; }

        public void LoadData()
        {
            Name = "Three";
            ImageUri = "http://placekitten.com/610/640";
        }
    }
}