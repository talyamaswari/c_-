using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project_GrandWaze
{
    /// <summary>
    /// Interaction logic for User_login.xaml
    /// </summary>
    public partial class User_login : Window
    {
        public User_login()
        {
            InitializeComponent();
     
        }
    
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          

        }
        //בדיקה על המייל שהוזן האם הוא תקין
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           if (!(EmailAddressHelper.Validate(mail.Text)) || mail.Text=="gmail.com" || mail.Text=="walla.com" )
            {
                MessageBox.Show("the email is not correct");
            }
                else
            { 
                  this.Hide();
                  Select_store s = new Select_store();
                  s.ShowDialog();
            }

        }
     
        //אימות מייל
        public static class EmailAddressHelper
        {
            public static bool Validate(string emailAddress)
            {
                var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
                bool isValid = Regex.IsMatch(emailAddress, regex, RegexOptions.IgnoreCase);
                return isValid;
            }
        }

        private void name_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!(IsAllCharEnglish(name.Text)))
            {
                MessageBox.Show("Invalid user name ");
            }
        }
        private bool IsAllCharEnglish(string Input)//בדיקה על השם משתמש שהוא באנגלית
            {
                foreach (var item in Input.ToCharArray())
                {
                    if (!char.IsLower(item) && !char.IsUpper(item) && !char.IsDigit(item) && !char.IsWhiteSpace(item))
                    {
                        return false;
                    }
                }
                return true;
            }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow s = new MainWindow();
            s.ShowDialog();
        }
    }
}

