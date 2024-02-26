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

namespace CsTeach.Pages
{
    /// <summary>
    /// Interaction logic for help1.xaml
    /// </summary>
    public partial class help1 : Page
    {
        public help1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            helpLogin hlg = new helpLogin();
            this.NavigationService.Navigate(hlg);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            helpStudent hst = new helpStudent();
            this.NavigationService.Navigate(hst);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            helpTeacher th = new helpTeacher();
            this.NavigationService.Navigate(th);
        }
    }
}
