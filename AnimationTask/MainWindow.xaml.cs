using System.Windows;


namespace AnimationTask
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenProgress_Click(object sender, RoutedEventArgs e)
        {
            Progress_Viewer progress = new Progress_Viewer();
            progress.Owner = this;
            //progress.countdownTimmer = 40;
            //progress.countdownTimmer = 10;
            progress.ShowDialog();
        }
    }
}