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
    /// Interaction logic for loops02.xaml
    /// </summary>
    public partial class loops02 : Page
    {
        public loops02()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            loopframe.Source = new Uri("loopWhile.xaml", UriKind.Relative);
        }

        private void loopframe_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            loopframe.Source = new Uri("loopFor.xaml", UriKind.Relative);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            loopframe.Source = new Uri("loopDo.xaml", UriKind.Relative);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Loops01 l1 = new Loops01();
            NavigationService.Navigate(l1);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Chapters ch = new Chapters();
            NavigationService.Navigate(ch);
        }
    }
}
