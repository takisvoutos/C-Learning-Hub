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
    /// Interaction logic for MuArray1.xaml
    /// </summary>
    public partial class MuArray1 : Page
    {
        public MuArray1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Arrays02 ar2 = new Arrays02();
            NavigationService.Navigate(ar2);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MuArray2 mur2 = new MuArray2();
            NavigationService.Navigate(mur2);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Chapters ch = new Chapters();
            NavigationService.Navigate(ch);
        }
    }
}
