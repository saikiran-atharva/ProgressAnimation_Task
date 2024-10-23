using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;
using System.Windows.Threading;

namespace UserControls_Shared
{
    public partial class PopupUserControl : UserControl
    {
        private int _timeRemaining = 30; // Countdown in seconds
        private DispatcherTimer _timer;
        private DispatcherTimer _animationTimer;
        private double _angle = 0;

        public PopupUserControl()
        {
            InitializeComponent();

            // Setup the countdown timer
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1); // Countdown updates every second
            _timer.Tick += Timer_Tick;
            _timer.Start();

          
            _animationTimer = new DispatcherTimer();
            _animationTimer.Interval = TimeSpan.FromMilliseconds(50); // Spin every 50ms
            _animationTimer.Tick += Animation_Tick;
            _animationTimer.Start(); // Start the spinning animation
            
        }
         

        private void Timer_Tick(object sender, EventArgs e)
        {
            _timeRemaining--;
            CountdownText.Text = _timeRemaining.ToString();  

            if (_timeRemaining <= 0)
            {
                 
                _timer.Stop();
                _animationTimer.Stop();

                
                var parent = this.Parent as Panel;
                if (parent != null)
                {
                    parent.Children.Remove(this);  
                }
            }
        }

        // Timer for rotating the progress ring
        private void Animation_Tick(object sender, EventArgs e)
        {
            _angle += 5; // Rotate by 5 degrees per tick
            if (_angle >= 360)
                _angle = 0;

            SpinnerRotate.Angle = _angle; // Update the spinner rotation in place
        }
    }
}
