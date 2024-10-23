//using System;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Media.Animation;
//using System.Windows.Threading;

//namespace UserControls_Shared
//{
//    public partial class CircularTimerControl : UserControl
//    {
//        private DispatcherTimer _timer;
//        private int _remainingTime;
//        private Storyboard _rotationStoryboard;

//        public CircularTimerControl()
//        {
//            InitializeComponent();
//            SetupRotationAnimation();
//        }

//        private void SetupRotationAnimation()
//        {
//            // Create the rotation animation
//            _rotationStoryboard = new Storyboard();
//            var rotateAnimation = new DoubleAnimation(0, 360, new Duration(TimeSpan.FromSeconds(2)));
//            rotateAnimation.RepeatBehavior = RepeatBehavior.Forever;
//            Storyboard.SetTarget(rotateAnimation, rotateTransform);
//            Storyboard.SetTargetProperty(rotateAnimation, new PropertyPath(RotateTransform.AngleProperty));
//            _rotationStoryboard.Children.Add(rotateAnimation);
//        }

//        public void StartCountdown()
//        {
//            _remainingTime = 30; // Set countdown to 30 seconds
//            countdownText.Text = _remainingTime.ToString();

//            // Start the rotation animation
//            _rotationStoryboard.Begin();

//            // Setup the timer
//            _timer = new DispatcherTimer();
//            _timer.Interval = TimeSpan.FromSeconds(1);
//            _timer.Tick += Timer_Tick;
//            _timer.Start();
//        }

//        private void Timer_Tick(object sender, EventArgs e)
//        {
//            _remainingTime--;
//            countdownText.Text = _remainingTime.ToString();

//            if (_remainingTime <= 0)
//            {
//                // Stop the timer and animation
//                _timer.Stop();
//                _rotationStoryboard.Stop();
//                // Hide the control when the countdown ends
//                this.Visibility = Visibility.Collapsed;
//            }
//        }
//    }
//}
