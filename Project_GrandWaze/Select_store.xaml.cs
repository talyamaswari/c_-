using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
using System.Windows.Shapes;

namespace Project_GrandWaze
{
    /// <summary>
    /// Interaction logic for Select_store.xaml
    /// </summary>
    public partial class Select_store : Window
    {
        public Select_store()
        {
            InitializeComponent();

            stors.IsEnabled = false;


        }

        private void Select_store_Load(object sender, EventArgs e)
        {
            GroupBox box = new GroupBox();
            
             box.Name = "רשימת החנויות שלי";
            
    

        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int flag = 0;
            foreach (var item in list_of_store.Items)
            {
                if (stors.SelectedItem == item)
                { 
                    flag = 1;
                    break;
                }
            }
            if(flag==0)
                 list_of_store.Items.Add(stors.SelectedItem);


        }

        private void list_of_store_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          
            
        }

        private void map_1_Checked(object sender, RoutedEventArgs e)
        {
            if (map_1.IsChecked==true)
            {
                stors.IsEnabled =true ;
                stors.Items.Clear();
                list_of_store.Items.Clear();
                stors.Items.Add("zara");
                stors.Items.Add("65");
                stors.Items.Add("5");


            }
        }

        private void map_2_Checked(object sender, RoutedEventArgs e)
        {
            if (map_2.IsChecked == true)
            {
            stors.IsEnabled = true;
            stors.Items.Clear();
            list_of_store.Items.Clear();
            stors.Items.Add("michal corse");//הכנסת חנויות ששיכות לקומה
            stors.Items.Add("123");//הכנסת חנויות ששיכות לקומה
            stors.Items.Add("156");//הכנסת חנויות ששיכות לקומה

            }

        }
        private void map_3_Checked(object sender, RoutedEventArgs e)
        {
            if (map_3.IsChecked == true)
            { 
            stors.IsEnabled = true;
            stors.Items.Clear();
            list_of_store.Items.Clear();
            stors.Items.Add("mango");//הכנסת חנויות ששייכות לקומה
            stors.Items.Add("castro");//הכנסת חנויות ששייכות לקומה
            stors.Items.Add("aldo");//הכנסת חנויות ששייכות לקומה

            }
        }

        private void found_Click(object sender, RoutedEventArgs e)
        {
            if (map_1.IsChecked == true || map_2.IsChecked == true || map_3.IsChecked == true)
            {
                if (map_1.IsChecked == true)
                {
                    this.Hide();
                    map_1 s = new map_1();
                    s.ShowDialog();
                }
                else
                {
                    if (map_2.IsChecked == true)
                    {

                    }
                    else
                    {
                        this.Hide();
                        map_3 s = new map_3();
                        s.ShowDialog();

                    }

                }
            }
            else
                MessageBox.Show("No choice was made");
        }
    }
}
