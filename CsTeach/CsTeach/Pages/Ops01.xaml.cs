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
    /// Interaction logic for Ops01.xaml
    /// </summary>
    public partial class Ops01 : Page
    {
        public Ops01()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ops02 op = new Ops02();
            NavigationService.Navigate(op);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BasicVars02 ba = new BasicVars02();
            NavigationService.Navigate(ba);
        }

        
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Chapters ch = new Chapters();
            NavigationService.Navigate(ch);
        }
    }
}
