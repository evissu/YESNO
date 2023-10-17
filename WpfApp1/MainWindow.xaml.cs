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
using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void Buttom2_(object sender, RoutedEventArgs e)
        {
        
        }

        private void Buttom2_MouseEnter(object sender, MouseEventArgs e)
        {
            if (((Button)sender).Content.ToString() == "НЕТ"  ) 
            {
                this.Buttom2.Content = "ДА";
                this.Button1.Content = "НЕТ";
            }
            
        }

      
        
        private void Button1_MouseEnter_1(object sender, MouseEventArgs e)
        {
            if (((Button)sender).Content.ToString() == "НЕТ") 
            {
                this.Button1.Content = "ДА";
                this.Buttom2.Content = "НЕТ";
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if (((Button)sender).Content.ToString() == "ДА") 
            { MessageBox.Show("i think u are liar"); }
            
        }

        private void Buttom2_Click(object sender, RoutedEventArgs e)
        {
            if(((Button)sender).Content.ToString()== "ДА")
            {
                MessageBox.Show("i think u are liar");
            }
        }
    }
}
