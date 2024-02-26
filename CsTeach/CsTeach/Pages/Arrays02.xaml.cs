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
    /// Interaction logic for Arrays02.xaml
    /// </summary>
    public partial class Arrays02 : Page
    {
        public Arrays02()
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
            Arrays01 ar = new Arrays01();
            NavigationService.Navigate(ar);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MuArray1 ma = new MuArray1();
            NavigationService.Navigate(ma);
        }
    }
}
