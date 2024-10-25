using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Threading;

namespace AnimationTask
{
    public partial class Progress_Viewer : Window
    {
        private DispatcherTimer _timer;
        private int _remainingTime;
        private Storyboard _rotationStoryboard;
        public int countdownTimmer { get; set; } = 30;
        public event EventHandler CountdownCompleted;
        public Progress_Viewer()
        {
            InitializeComponent();
            SetupRotationAnimation();
            this.Loaded += Progress_Viewer_Loaded;
        }
        private void Progress_Viewer_Loaded(object sender, RoutedEventArgs e)
        {

            StartRotationAndCountdown();
        }

        public void StartRotationAndCountdown()
        {

            _remainingTime = countdownTimmer;
            UpdateCountdownText();
            _rotationStoryboard.Begin();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }
        private void SetupRotationAnimation()
        {

            _rotationStoryboard = (Storyboard)this.FindResource("RotateStoryboard");

        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            _remainingTime--;
            if (_remainingTime >= 0)
            {
                UpdateCountdownText();
            }
            else
            {
                CountdownText.Text = "TIMEOUT!";
                _rotationStoryboard.Stop();
                Spinner.Visibility = Visibility.Collapsed;
                RedCross.Visibility = Visibility.Visible;
                if (_remainingTime == -4)
                {
                    _timer.Stop();
                    this.Close();
                }

            }
        }
        private void UpdateCountdownText()
        {

            CountdownText.Text = $"Timeout in {_remainingTime} sec";
        }

    }
}