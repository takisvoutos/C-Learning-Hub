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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {

        
        public Login()
        {
            InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           

            SqlConnection scn = new SqlConnection();
            scn.ConnectionString = @"Data Source=DESKTOP-V82M8MG\SQLEXPRESS;Initial Catalog=CsTeach;Integrated Security=True";
            SqlCommand scmd = new SqlCommand("select count (*) as cnt from Users where Username=@usr and Password=@pwd and Type=@tp", scn);
            scmd.Parameters.Clear();
            scmd.Parameters.AddWithValue("@usr", UserName.Text);
            scmd.Parameters.AddWithValue("@pwd", PWD.Password);
            scmd.Parameters.AddWithValue("@tp", Type.Text);
            scn.Open();

            //ΕΠΙΤΙΧΗΣ ΣΥΝΔΕΣΗ
            if (scmd.ExecuteScalar().ToString() == "1")
            {
                MessageBox.Show("YOU ARE GRANTED WITH ACCESS");
                globalVars.Username = UserName.Text;
                globalVars.Password = PWD.Password;
                globalVars.typedb = Type.Text;
                if (globalVars.typedb == "student")
                {                    
                    SqlCommand cmd = scn.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    // ΥΠΟΛΟΓΙΣΜΟΣ ΜΕΣΩΝ ΟΡΩΝ ΚΑΘΕ ΚΕΦΑΛΑΙΟΥ ΤΟΥ ΧΡΗΣΤΗ ΠΟΥ ΣΥΝΔΕΘΗΚΕ 
                    try
                    {
                        cmd.Parameters.Add("Chapter", SqlDbType.VarChar).Value = 2;
                        cmd.CommandText = " IF EXISTS(SELECT * FROM Tests WHERE Chapter=2 AND Username='" +
                            globalVars.Username + "') " + "BEGIN (select avg(Score) as MO from Tests where Chapter = 2 AND Username='"
                            + globalVars.Username + "') END " + "ELSE BEGIN (SELECT Score FROM Tests Where Chapter=5) END ;";
                        Int32 avg2 = (Int32)cmd.ExecuteScalar();
                        globalVars.ch2avg = avg2;

                        SqlCommand cmd2 = scn.CreateCommand();
                        cmd2.CommandType = CommandType.Text;
                        cmd2.Parameters.Add("Chapter", SqlDbType.VarChar).Value = 1;
                        cmd2.CommandText = "IF EXISTS(SELECT * FROM tests WHERE Chapter=1 AND Username='" + globalVars.Username + "') BEGIN (select avg(Score) as MO from tests where Chapter = 1 AND Username='" + globalVars.Username + "') END ELSE BEGIN (SELECT Score FROM Tests Where Chapter=5) END ;";
                        Int32 avg1 = (Int32)cmd2.ExecuteScalar();
                        globalVars.ch1avg = avg1;

                        SqlCommand cmd3 = scn.CreateCommand();
                        cmd3.CommandType = CommandType.Text;
                        cmd3.Parameters.Add("Chapter", SqlDbType.VarChar).Value = 3;
                        cmd3.CommandText = " IF EXISTS(SELECT * FROM tests WHERE Chapter=3 AND Username='" + globalVars.Username + "') BEGIN (select avg(Score) as MO from tests where Chapter = 3 AND Username='" + globalVars.Username + "') END ELSE BEGIN (SELECT Score FROM Tests Where Chapter=5) END ;";
                        Int32 avg3 = (Int32)cmd3.ExecuteScalar();
                        globalVars.ch3avg = avg3;

                        SqlCommand cmd4 = scn.CreateCommand();
                        cmd4.CommandType = CommandType.Text;
                        cmd4.Parameters.Add("Chapter", SqlDbType.VarChar).Value = 4;
                        cmd4.CommandText = " IF EXISTS(SELECT * FROM tests WHERE Chapter=4 AND Username='" + globalVars.Username + "') BEGIN (select avg(Score) as MO from tests where Chapter = 4 AND Username='" + globalVars.Username + "') END ELSE BEGIN (SELECT Score FROM Tests Where Chapter=5) END ;";
                        Int32 avg4 = (Int32)cmd3.ExecuteScalar();
                        globalVars.ch4avg = avg4;
                    }
                    catch(NullReferenceException i)
                    {

                    }
                    

                    globalVars.logedIn = true;

                    Chapters ch = new Chapters();
                    NavigationService.Navigate(ch);
                }
                else
                {
                    globalVars.logedIn = true;

                    TeacherMenuMain tm = new TeacherMenuMain();
                    NavigationService.Navigate(tm);
                }
            }
            else
            {
                MessageBox.Show("Invalid Data");
                UserName.Clear();
                PWD.Clear();
                Type.Text="";
            }
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Register reg = new Register();
            NavigationService.Navigate(reg);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Test1 t1 = new Test1();
            NavigationService.Navigate(t1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            testPage tp = new testPage();
            this.NavigationService.Navigate(tp);
        }
    }
}
