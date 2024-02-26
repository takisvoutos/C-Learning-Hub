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
    /// Interaction logic for BasicVars02.xaml
    /// </summary>
    public partial class BasicVars02 : Page
    {
        public BasicVars02()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Chapters Ch = new Chapters();
            NavigationService.Navigate(Ch);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BasicVars01 bv1 = new BasicVars01();
            NavigationService.Navigate(bv1);
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            Ops01 op = new Ops01();
            NavigationService.Navigate(op);
        }
    }
}
