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
    /// Interaction logic for BasicVars01.xaml
    /// </summary>
    public partial class BasicVars01 : Page
    {
        public BasicVars01()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BasicVars02 BV2 = new BasicVars02();
            NavigationService.Navigate(BV2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Chapters BV1 = new Chapters();
            NavigationService.Navigate(BV1);
        }
    }
}
