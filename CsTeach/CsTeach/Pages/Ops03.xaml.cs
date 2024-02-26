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
    /// Interaction logic for Ops03.xaml
    /// </summary>
    public partial class Ops03 : Page
    {
        public Ops03()
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
            Ops02 op2 = new Ops02();
            NavigationService.Navigate(op2);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Loops01 l1 = new Loops01();
            NavigationService.Navigate(l1);

        }
    }
}
