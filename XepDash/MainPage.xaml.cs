using Autofac;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using XepDash.Core;

namespace XepDash.UI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private DispatcherTimer _slideTimer;
        private DispatcherTimer _pollTimer;
        private ISettings _settings;
        private ISettingsService _settingsService;
        private ISlideService _slideService;

        public MainPage()
        {
            this.InitializeComponent();
            this._settingsService = App.Container.Resolve<ISettingsService>();
            this._slideService = App.Container.Resolve<ISlideService>();

            LoadSettings();

            SetUpTimers();

            LoadSlideData();

            _pollTimer.Start();
            _slideTimer.Start();
        }

        private void LoadSettings()
        {
            _settings = _settingsService.Get().Result;
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
            var slides = _slideService.GetSlides().ToList();
            slides.ForEach(s => fv.Items.Add(s));
        }
    }
}