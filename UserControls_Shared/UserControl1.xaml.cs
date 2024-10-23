using System.Text;
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

namespace UserControls_Shared
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public void Rotate_Ring(object sender, RoutedEventArgs e)
        {

            RotateTransform rotateTransform = new RotateTransform();
            progressPath.RenderTransform = rotateTransform;
            progressPath.RenderTransformOrigin = new Point(0.5, 0.5);


            DoubleAnimation rotateAnimation = new DoubleAnimation
            {
                From = 0,
                To = 360,
                Duration = new Duration(TimeSpan.FromSeconds(1)),
                RepeatBehavior = RepeatBehavior.Forever
            };

            rotateTransform.BeginAnimation(RotateTransform.AngleProperty, rotateAnimation);
             //progressPath.RenderTransform.BeginAnimation(RotateTransform.CenterXProperty, rotateAnimation);
        }
    }

}
