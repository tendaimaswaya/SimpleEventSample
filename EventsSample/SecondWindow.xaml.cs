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

namespace EventsSample
{
    /// <summary>
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
            MainWindow.handler_refresh += new RoutedEventHandler(Refresh); //the static event handler in Main Window is then registered to trigger the Refresh method in this window
        }

        private void Refresh(object sender, RoutedEventArgs e)      //triggered when event in Main Window is invoked
        {
            setNumber();          
        }
        
         void setNumber()   //just a method to produce random number on Refresh
        {
          //  Random random = new Random();          
            label.Content = new Random().Next().ToString();
        }
    }
}
