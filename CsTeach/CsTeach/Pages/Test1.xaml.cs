using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
using System.Windows.Controls.Primitives;

namespace CsTeach.Pages
{
    /// <summary>
    /// Interaction logic for Test1.xaml
    /// </summary>
    public partial class Test1 : Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-V82M8MG\SQLEXPRESS;Initial Catalog=CsTeach;Integrated Security=True");
        DataTable dt = new DataTable();
        string answer;
        int grade = 0;
        int nextquest = 0;
        List<string> quests = new List<string>();
        bool c4 = false;
        public Test1()
        {
           
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {


            if (chapt.Text != "")
            {
                con.Open();
                SqlCommand val = con.CreateCommand();
                val.CommandType = CommandType.Text;
                val.CommandText = "select Count(question) from TestQuest WHERE Chapter='" + chapt.Text + "'";
                val.ExecuteNonQuery();
                Int32 validation = (Int32)val.ExecuteScalar();
                if (chapt.Text == "4")
                {
                    c4 = true;
                }
                con.Close();



                if (validation == 10 || c4==true)
                {
                    if (nextquest <= 9)
                    {
                        chapt.IsEnabled = false;
                        sub.Visibility = Visibility.Visible;
                        but1.Visibility = Visibility.Hidden;
                        if (chapt.Text != "4")
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM TestQuest WHERE Chapter='" + chapt.Text + "'", con);
                            sda.Fill(dt);
                        }
                        else if (chapt.Text == "4")
                        {
                            SqlDataAdapter sda = new SqlDataAdapter("SELECT TOP 10 Question, Answer FROM TestQuest ORDER BY NEWID()", con);
                            sda.Fill(dt);
                        }

                        quest.Text = dt.Rows[nextquest][0].ToString();

                    }
                    else
                    {
                        chapt.IsEnabled = true;
                        MessageBox.Show("Test Finished! your grade is " + grade);
                        sub.Visibility = Visibility.Hidden;
                        but1.Visibility = Visibility.Visible;
                        trueBut.IsChecked = false;
                        falseBut.IsChecked = false;
                        con.Open();
                        SqlCommand reg = con.CreateCommand();
                        reg.CommandType = CommandType.Text;
                        reg.CommandText = "INSERT INTO Tests(Username, Chapter, Score) VALUES('" + globalVars.Username + "', '" + chapt.Text + "', '" + grade + "')";
                        reg.ExecuteNonQuery();
                        con.Close();
                        grade = 0;
                        nextquest = 0;

                      

                        Chapters ch = new Chapters();
                        NavigationService.Navigate(ch);
                    }
                }
                else
                {
                   MessageBox.Show("This test is not ready yet. Please contact a Teacher to fix it.");
                }
            }
            else MessageBox.Show("Choose Chpater");
            
           
            
        }

        private void trueBut_Checked(object sender, RoutedEventArgs e)
        {
            answer = "true";
        }

        private void falseBut_Checked(object sender, RoutedEventArgs e)
        {
            answer = "false";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if ((trueBut.IsChecked == true) || (falseBut.IsChecked == true))
            {
                if (nextquest <= 9)
                {
                   
                    if (trueBut.IsChecked == true)
                    {
                        answer = "true";
                    }
                    else { answer = "false"; }

                    if (dt.Rows[nextquest][1].ToString() == answer)
                    {
                        grade = grade + 1;
                        MessageBox.Show("Correct Answer!");
                    }
                    else
                    {
                        MessageBox.Show("Wrong Answer!");
                    }
                }
                trueBut.IsChecked = false;
                falseBut.IsChecked = false;
                nextquest++;
                but1.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
            else
            {
                MessageBox.Show("Choose One Answer");
            }
        }
    }


}
