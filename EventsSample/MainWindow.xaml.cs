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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EventsSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static RoutedEventHandler handler_refresh;       //static EventHandler registered in SecondWindow and invoked in this window
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_launch_Click(object sender, RoutedEventArgs e)
        {
          new SecondWindow().Show();        //launch second window
           btn_refresh.IsEnabled = true;      //enable refresh button. Doing this to avoid encountering an exception if 
                                              //the user clicks on refresh button before launching window. Off course there 
                                              //are ways around this but for this demo, this mechanism should suffice
        }

        private void btn_refresh_Click(object sender, RoutedEventArgs e)
        {            
            handler_refresh.Invoke(this, new RoutedEventArgs());
        }
    }
}
