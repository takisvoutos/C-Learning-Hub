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
    /// Interaction logic for TeacherMenuMain.xaml
    /// </summary>
    public partial class TeacherMenuMain : Page
    {
        public TeacherMenuMain()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TeacherMenu tm = new TeacherMenu();
            this.NavigationService.Navigate(tm);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TeacherMenu2 tm2 = new TeacherMenu2();
            this.NavigationService.Navigate(tm2);
        }
    }
}
