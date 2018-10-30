using System;
using XepDash.Core;

namespace XepDash.Infrastructure
{
    public class Slide : ISlide
    {
        public Slide()
        {

        }
        public int Id { get; set; }
        public int OrderIndex { get; set; }
        public string ImageUri { get; set; }
        public bool IsActive { get; set; }
        public string XamlPage { get; set; }

        public void LoadData()
        {
            //throw new NotImplementedException();
        }
    }
}