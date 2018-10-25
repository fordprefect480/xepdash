using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using XepDash.Business.Models;
using XepDash.Data;

namespace XepDash
{
    public class SlideCoordinator
    {
        private List<ISlide> _knownSlides = new List<ISlide>
        {

        };

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

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DispatcherTimer _slideTimer;
        private DispatcherTimer _pollTimer;
        private Settings _settings;
        private ISettingsRepository _settingsRepository;
        private SlideCoordinator _slideCoordinator;

        public MainPage()
        {
            this.InitializeComponent();

            //ninject dependencies later
            this._settingsRepository = new FileSettingsRepository();
            this._slideCoordinator = new SlideCoordinator();

            LoadSettings();

            SetUpTimers();

            LoadSlideData();

            _pollTimer.Start();
            _slideTimer.Start();
        }

        private void LoadSettings()
        {
            _settings = _settingsRepository.Get().Result;
        }

        private void SetUpTimers()
        {
            _slideTimer = new DispatcherTimer();
            _slideTimer.Interval = TimeSpan.FromSeconds(_settings.SlideIntervalSeconds);
            _slideTimer.Tick += ChangeSlide;

            _pollTimer = new DispatcherTimer();
            _pollTimer.Interval = TimeSpan.FromSeconds(_settings.PollingIntervalSeconds);
            _pollTimer.Tick += RefreshData;
        }

        private void ChangeSlide(object sender, object e)
        {
            if (!fv.Items.Any())
            {
                // or display a 'no slides found' slide?
                return;
            }

            var totalItems = fv.Items.Count;
            fv.SelectedIndex = (fv.SelectedIndex + 1) % totalItems;
        }

        private void RefreshData(object sender, object e)
        {
            LoadSlideData();
        }

        private void LoadSlideData()
        { 
            var slides = _slideCoordinator.GetSlides();

            // clear current items
            fv.Items.Clear();

            foreach (var slide in slides)
            {
                var n = new Random().Next(1000);
                fv.Items.Add(new { Name = n.ToString(), Image = "http://placekitten.com/" + n + "/200" });
            }            
        }
    }
}