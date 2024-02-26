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
    /// Interaction logic for Arrays01.xaml
    /// </summary>
    public partial class Arrays01 : Page
    {
        public Arrays01()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Chapters ch = new Chapters();
            NavigationService.Navigate(ch);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Des01 d = new Des01();
            NavigationService.Navigate(d);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Arrays02 ar2 = new Arrays02();
            NavigationService.Navigate(ar2);
        }
    }
}
