using System;
using System.Collections.Generic;
using System.Linq;
using XepDash.Core;

namespace XepDash.Infrastructure
{
    public class SlideService : ISlideService
    {
        private IEnumerable<ISlide> _knownSlides;

        public SlideService(IEnumerable<ISlide> slides)
        {
            _knownSlides = slides;
        }

        public IEnumerable<ISlide> GetSlides()
        {
            var loadedSlides = new List<ISlide>();
            foreach (var slide in _knownSlides)
            {
                try
                {
                    slide.LoadData();
                    loadedSlides.Add(slide);
                }
                catch(Exception e)
                {

                }
            }

            return loadedSlides.OrderBy(s => s.OrderIndex);
        }
    }
}