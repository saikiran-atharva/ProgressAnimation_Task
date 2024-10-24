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
using UserControls_Shared;
 
namespace AnimationTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenProgress_Click(object sender, RoutedEventArgs e)
        {

            ////PopupUserControl popup = new PopupUserControl();
            //UserControl1 popup = new UserControl1();

            //MainGrid.Children.Add(popup);

            //circleControl.Visibility = Visibility.Visible;
            //circleControl.StartCountdown();
            //Progress_Viewer progress_Viewer = new Progress_Viewer();
            //MainGrid.Children.Add(progress_Viewer);
            //progress_Viewer.Visibility = Visibility.Visible;
            //progress_Viewer.StartCountdown();
            Modal modal = new Modal();
            modal.Owner = this;
            modal.ShowDialog();
             

        }
    }
}
 