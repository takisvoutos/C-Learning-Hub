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
using System.Data.SqlClient;
using System.Data;

namespace CsTeach.Pages
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V82M8MG\SQLEXPRESS;Initial Catalog=CsTeach;Integrated Security=True");
        string type="";
        public Register()
        {
            InitializeComponent();            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if ((pass1.Password == pass2.Password) && (name.Text!="") &&(pass1.Password!="")&&(type!=""))
            {
                con.Open();
                SqlCommand reg = con.CreateCommand();
                reg.CommandType = CommandType.Text;
                reg.CommandText = "BEGIN IF NOT EXISTS(SELECT * FROM Users WHERE Username = '" + name.Text + "') BEGIN INSERT INTO Users(Username, Password, Type) VALUES('" + name.Text + "', '" + pass2.Password + "','" + type + "') END END";
                reg.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Account Created Succesfully");
                Login log = new Login();
                NavigationService.Navigate(log);
            }
            else
            {
                MessageBox.Show("Please Check Your Data");
            }
        }

        private void teacherrad_Checked(object sender, RoutedEventArgs e)
        {
            type = "teacher";
        }

        private void studentrad_Checked(object sender, RoutedEventArgs e)
        {
            type = "student";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Login log = new Login();
            NavigationService.Navigate(log);
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Login log = new Login();
            NavigationService.Navigate(log);
        }
    }
}
