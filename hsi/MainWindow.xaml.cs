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

namespace hsi
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

        private void dwa(object sender, RoutedEventArgs e)
        {
                int i = Convert.ToInt32(x1.Text);
                textBox2.Text = Convert.ToString(i, 2);
        }

        private void wos(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(x1.Text);
            textBox2.Text = Convert.ToString(i, 8);

        }

        private void hes(object sender, RoutedEventArgs e)
        {
            
                int i = Convert.ToInt32(x1.Text);
                textBox2.Text = Convert.ToString(i, 16);
            
            
        }

      
    }
     
}
