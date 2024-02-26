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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CsTeach.Pages
{
    /// <summary>
    /// Interaction logic for TeacherMenu2.xaml
    /// </summary>
    public partial class TeacherMenu2 : Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V82M8MG\SQLEXPRESS;Initial Catalog=CsTeach;Integrated Security=True");

        SqlCommand sql_command = new SqlCommand();

        public TeacherMenu2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
                string CmdString = string.Empty;
                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V82M8MG\SQLEXPRESS;Initial Catalog=CsTeach;Integrated Security=True"))
                {
                    CmdString = "SELECT Question FROM TestQuest WHERE Chapter = '" +chapt.Text+ "' ";
                    SqlCommand cmd = new SqlCommand(CmdString, con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable("Questions");
                    sda.Fill(dt);
                    questionsGrid.ItemsSource = dt.DefaultView;
                }            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (questBox.Text == "(insert question)")
            {
                MessageBox.Show("Invalid Data");
            }
            else
            {
                con.Open();
                SqlCommand ins = con.CreateCommand();
                ins.CommandType = CommandType.Text;
                ins.CommandText = "DELETE FROM TestQuest WHERE Question = '" + questBox.Text + "'";
                int numberOfRecords = ins.ExecuteNonQuery();
                ins.ExecuteNonQuery();
                con.Close();
                if (numberOfRecords == 0)
                {
                    MessageBox.Show("Invalid Question");
                }
                else
                {
                    MessageBox.Show("Question Deleted Succesfuly");
                }
            }
        }
    }

   
}
