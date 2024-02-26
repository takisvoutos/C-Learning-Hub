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
    /// Interaction logic for Loops01.xaml
    /// </summary>
    public partial class Loops01 : Page
    {
        public Loops01()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ops03 op3 = new Ops03();
            NavigationService.Navigate(op3);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            loops02 l2 = new loops02();
            NavigationService.Navigate(l2);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Chapters ch = new Chapters();
            NavigationService.Navigate(ch);
        }
    }
}
