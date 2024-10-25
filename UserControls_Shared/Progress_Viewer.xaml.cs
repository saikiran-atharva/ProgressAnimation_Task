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
         
        private DispatcherTimer _timer;
        private int _remainingTime;   
        private Storyboard _rotationStoryboard;
        public event EventHandler CountdownCompleted;
        public Progress_Viewer()
        {
            InitializeComponent();
            SetupRotationAnimation();
        }
         
        public void StartRotationAndCountdown()
        {
             
            _remainingTime = 30;
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
            UpdateCountdownText();

            if (_remainingTime <= 0)
            {
                _timer.Stop();
                _rotationStoryboard.Stop();
                CountdownCompleted?.Invoke(this, EventArgs.Empty);
                this.Visibility = Visibility.Collapsed;
                
            }
        }
        private void UpdateCountdownText()
        {
             
            CountdownText.Text = $"Timeout in {_remainingTime} sec";
        }

    }
}
