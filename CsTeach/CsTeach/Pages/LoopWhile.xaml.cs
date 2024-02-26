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
    /// Interaction logic for LoopWhile.xaml
    /// </summary>
    public partial class LoopWhile : Page
    {
        public LoopWhile()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            loopWhile2 l2 = new loopWhile2();
            NavigationService.Navigate(l2);
        }
    }
}
