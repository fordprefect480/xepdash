using System.Collections.Generic;

namespace XepDash.Core
{
    public interface ISlideService
    {
        IEnumerable<ISlide> GetSlides();
    }
}