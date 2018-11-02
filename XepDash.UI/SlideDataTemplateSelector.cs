using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using XepDash.Core;

namespace XepDash.UI
{
    public class SlideDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate SlideOne { get; set; }
        public DataTemplate SlideTwo { get; set; }
        public DataTemplate SlideThree { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item is ISlide)
            {
                var slide = item as ISlide;
                switch (slide.GetType().Name)
                {
                    case "SlideOne":
                        return SlideOne;

                    case "SlideTwo":
                        return SlideTwo;

                    case "SlideThree":
                        return SlideThree;

                    default:
                        return base.SelectTemplateCore(item, container);
                }
            }

            return base.SelectTemplateCore(item, container);
        }
    }
}
