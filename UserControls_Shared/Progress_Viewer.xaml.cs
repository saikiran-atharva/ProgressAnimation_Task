using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace UserControls_Shared
{
    /// <summary>
    /// Interaction logic for Progress_Viewer.xaml
    /// </summary>
    public partial class Progress_Viewer : UserControl
    {
        //private int _timeRemaining = 30;
        //private DispatcherTimer _timer;
        //private int _remainingTime;
        //private Storyboard _rotationStoryboard;
        private DispatcherTimer _timer;
        private int _remainingTime;   
        private Storyboard _rotationStoryboard;
        public Progress_Viewer()
        {
            InitializeComponent();
            SetupRotationAnimation();
        }
        //public void StartCountdown()
        //{
        //    _remainingTime = 30;  
        //    CountdownText.Text = _remainingTime.ToString();


        //    _rotationStoryboard.Begin(this,true);
        //    _timer = new DispatcherTimer();
        //    _timer.Interval = TimeSpan.FromSeconds(1);
        //    _timer.Tick += Timer_Tick;
        //    _timer.Start();
        //}
        //private void SetupRotationAnimation()
        //{
        //    // Create the rotation animation
        //    _rotationStoryboard = new Storyboard();
        //    var rotateAnimation = new DoubleAnimation(0, 360, new Duration(TimeSpan.FromSeconds(2)));
        //    rotateAnimation.RepeatBehavior = RepeatBehavior.Forever;
        //    Storyboard.SetTarget(rotateAnimation, rotateTransform);
        //    Storyboard.SetTargetProperty(rotateAnimation, new PropertyPath(RotateTransform.AngleProperty));
        //    _rotationStoryboard.Children.Add(rotateAnimation);
        //}
        //private void Timer_Tick(object sender, EventArgs e)
        //{
        //    _timeRemaining--;
        //    CountdownText.Text = _timeRemaining.ToString();

        //    if (_timeRemaining <= 0)
        //    {

        //        _timer.Stop();
        //        _rotationStoryboard.Stop(this);


        //        var parent = this.Parent as Panel;
        //        if (parent != null)
        //        {
        //            parent.Children.Remove(this);
        //        }
        //    }
        //}
        public void StartRotationAndCountdown()
        {
             
            _remainingTime = 30;
            CountdownText.Text = _remainingTime.ToString();


            _rotationStoryboard.Begin();
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1); // 1 second intervals
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
            CountdownText.Text = _remainingTime.ToString();


            if (_remainingTime <= 0)
            {
                _timer.Stop();
                _rotationStoryboard.Stop();
                //RotateStoryboard.Storyboard.Stop();
                this.Visibility = Visibility.Collapsed;
            }
        }

    }
}
