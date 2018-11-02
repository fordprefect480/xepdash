using System;
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
            var x = new Random().Next(100, 1000);

            Name = "One";
            ImageUri = "http://placekitten.com/" + x + "/" + x;
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
            var x = new Random().Next(100, 1000);

            Name = "Two";
            ImageUri = "http://placekitten.com/" + x + "/" + x;
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
            var x = new Random().Next(100, 1000);

            Name = "Three";
            ImageUri = "http://placekitten.com/" + x + "/" + x;
        }
    }
}