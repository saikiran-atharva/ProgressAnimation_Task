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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AnimationTask
{
    /// <summary>
    /// Interaction logic for Modal.xaml
    /// </summary>
    public partial class Modal : Window
    {
        public Modal()
        {
            InitializeComponent();
            progress.CountdownCompleted += Progress_CountdownCompleted;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            progress.StartRotationAndCountdown();
        }
        private void Progress_CountdownCompleted(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
