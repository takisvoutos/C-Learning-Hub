using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Interaction logic for TeacherMenu.xaml
    /// </summary>
    public partial class TeacherMenu : Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V82M8MG\SQLEXPRESS;Initial Catalog=CsTeach;Integrated Security=True");
        string trueOrfalse="";

        public TeacherMenu()
        {
            InitializeComponent();
        }     

        private void submitBut_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand tst = con.CreateCommand();
            tst.CommandText = "SELECT COUNT(*) FROM TestQuest WHERE Chapter= '"+chapt.Text+"'";
            Int32 count = (Int32)tst.ExecuteScalar();

            if ((chapt.Text == "") || (questBox.Text == "(insert question)") || (trueOrfalse == "") || (questBox.Text == ""))
            {
                MessageBox.Show("Invalid Data");
            }
            //elegxos gia na eisagei nea erotisi
            else if(count==10)
            {
                MessageBox.Show("This chapter has already 10 questions. Delete one question in order to insert a new one");   
            }
            else
            {
                //con.Open();
                SqlCommand ins = con.CreateCommand();
                ins.CommandType = CommandType.Text;
                ins.CommandText = "BEGIN IF NOT EXISTS(SELECT * FROM TestQuest " +
                    "WHERE Question = '" + questBox.Text + "') " +
                    "BEGIN INSERT INTO TestQuest(Question, Answer, Chapter, Username) " +
                    "VALUES('" + questBox.Text + "', '" + trueOrfalse + "','" + chapt.Text + "', '" + globalVars.Username + "') END END";
                ins.ExecuteNonQuery();
                MessageBox.Show("Question Added Succesfuly");
            }
            con.Close();

        }

        private void trueBut_Checked(object sender, RoutedEventArgs e)
        {
            trueOrfalse = "true";
        }

        private void falseBut_Checked(object sender, RoutedEventArgs e)
        {
            trueOrfalse = "false";
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            con.Open();
            SqlCommand tst = con.CreateCommand();
            tst.CommandText = "SELECT COUNT(*) FROM TestQuest WHERE Chapter=1";
            Int32 count = (Int32)tst.ExecuteScalar();
            MessageBox.Show(count.ToString());
        }
    }
}
