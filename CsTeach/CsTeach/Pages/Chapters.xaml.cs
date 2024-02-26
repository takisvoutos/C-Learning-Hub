using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace CsTeach.Pages
{
    /// <summary>
    /// Interaction logic for Chapters.xaml
    /// </summary>
    public partial class Chapters : Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V82M8MG\SQLEXPRESS;Initial Catalog=CsTeach;Integrated Security=True");
        public Chapters()
        {           

            InitializeComponent();

            Button[] btns = new Button[3];
            btns[0] = btn1;
            btns[1] = btn2;
            btns[2] = btn3;

            int[] AVGS = new int[3];
            AVGS[0] = globalVars.ch1avg;
            AVGS[1] = globalVars.ch2avg;
            AVGS[2] = globalVars.ch3avg;



            for (int i = 0; i < 3; i++)
            {
                if (AVGS[i] <= 2)
                {
                    btns[i].Background = Brushes.Red;
                }
                else if (AVGS[i] <= 4 && AVGS[i] >= 3)
                {
                    btns[i].Background = Brushes.Orange;
                }
                else if (AVGS[i] <= 6 && AVGS[i] >= 5)
                {
                    btns[i].Background = Brushes.Yellow;
                }
                else if (AVGS[i] <= 8 && AVGS[i] >= 7)
                {
                    btns[i].Background = Brushes.LightSteelBlue;
                }
                else if (AVGS[i] <= 10 && AVGS[i] >= 9)
                {
                    btns[i].Background = Brushes.Green;
                }
            }


        }

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BasicVars01 bv1 = new BasicVars01();
            NavigationService.Navigate(bv1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Register re = new Register();
            NavigationService.Navigate(re);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Des01 op = new Des01();
            NavigationService.Navigate(op);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BasicUI01 UI1 = new BasicUI01();
            NavigationService.Navigate(UI1);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Test1 t1 = new Test1();
            NavigationService.Navigate(t1);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("Chapter", SqlDbType.VarChar).Value = 2;
                cmd.CommandText = " IF EXISTS(SELECT * FROM tests WHERE Chapter=2 and Username='" + globalVars.Username + "') BEGIN (select avg(Score) as MO from tests where Chapter = 2 AND Username='" + globalVars.Username + "') END ELSE BEGIN (SELECT Score FROM Tests Where Chapter=5) END ;";
                Int32 avg2 = (Int32)cmd.ExecuteScalar();
                globalVars.ch2avg = avg2;

                
            }
            catch (NullReferenceException i)
            {
                //Ο ΧΡΗΣΤΗΣ ΔΕΝ ΕΧΕΙ ΣΥΜΠΛΗΡΩΣΕΙ ΤΟ ΔΕΥΤΕΡΟ CHAPTER
            }

            try
            {
                SqlCommand cmd2 = con.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.Parameters.Add("Chapter", SqlDbType.VarChar).Value = 1;
                cmd2.CommandText = "IF EXISTS(SELECT * FROM tests WHERE Chapter=1 and Username='" + globalVars.Username + "') BEGIN (select avg(Score) as MO from tests where Chapter = 1 AND Username='" + globalVars.Username + "') END ELSE BEGIN (SELECT Score FROM Tests Where Chapter=5) END ;";
                Int32 avg1 = (Int32)cmd2.ExecuteScalar();
                globalVars.ch1avg = avg1;
            }
            catch(NullReferenceException a)
            {
                //Ο ΧΡΗΣΤΗΣ ΔΕΝ ΕΧΕΙ ΣΥΜΠΛΗΡΩΣΕΙ ΤΟ ΠΡΩΤΟ CHAPTER
            }

            try
            {
                SqlCommand cmd3 = con.CreateCommand();
                cmd3.CommandType = CommandType.Text;
                cmd3.Parameters.Add("Chapter", SqlDbType.VarChar).Value = 3;
                cmd3.CommandText = " IF EXISTS(SELECT * FROM tests WHERE Chapter=3 and Username='" + globalVars.Username + "') BEGIN (select avg(Score) as MO from tests where Chapter = 3 AND Username='" + globalVars.Username + "') END ELSE BEGIN (SELECT Score FROM Tests Where Chapter=5) END ;";
                Int32 avg3 = (Int32)cmd3.ExecuteScalar();
                globalVars.ch3avg = avg3;
            }
            catch (NullReferenceException a)
            {
                //Ο ΧΡΗΣΤΗΣ ΔΕΝ ΕΧΕΙ ΣΥΜΠΛΗΡΩΣΕΙ ΤΟ ΤΡΙΤΟ CHAPTER
            }

            try
            {
                SqlCommand cmd4 = con.CreateCommand();
                cmd4.CommandType = CommandType.Text;
                cmd4.Parameters.Add("Chapter", SqlDbType.VarChar).Value = 4;
                cmd4.CommandText = " IF EXISTS(SELECT * FROM tests WHERE Chapter=4 and Username='" + globalVars.Username + "') BEGIN (select avg(Score) as MO from tests where Chapter = 4 AND Username='" + globalVars.Username + "') END ELSE BEGIN (SELECT Score FROM Tests Where Chapter=5) END ;";
                Int32 avg4 = (Int32)cmd4.ExecuteScalar();
                globalVars.ch4avg = avg4;
            }
            catch (NullReferenceException a)
            {
                //Ο ΧΡΗΣΤΗΣ ΔΕΝ ΕΧΕΙ ΣΥΜΠΛΗΡΩΣΕΙ ΤΟ ΓΕΝΙΚΟ CHAPTER
            }

            MessageBox.Show("Tests Average Scores:" + "\n" + "\n" + "Chapter 1: " + globalVars.ch1avg + "\n" + "Chapter 2: " + globalVars.ch2avg +
                  "\n" + "Chapter 3: " + globalVars.ch3avg + "\n" + "Chapter 4: " + globalVars.ch4avg);

            

            con.Close();

            
        }
    }
}
