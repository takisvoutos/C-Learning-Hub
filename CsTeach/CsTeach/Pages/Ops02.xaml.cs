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
    /// Interaction logic for Ops02.xaml
    /// </summary>
    public partial class Ops02 : Page
    {
        public Ops02()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ops01 op = new Ops01();
            NavigationService.Navigate(op);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ops03 op3 = new Ops03();
            NavigationService.Navigate(op3);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Chapters ch = new Chapters();
            NavigationService.Navigate(ch);
        }
    }
}
