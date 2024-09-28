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
using System.Windows.Shapes;
using System.Net.NetworkInformation;
using System.Windows.Threading;

namespace WpfApp2
{
    public partial class question1 : Window
    {
        public question1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string letter1 = TextBox_1.Text.ToLower();
            string letter2 = TextBox_2.Text.ToLower();
            string letter3 = TextBox_3.Text.ToLower();
            string letter4 = TextBox_4.Text.ToLower();
            string letter5 = TextBox_5.Text.ToLower();
            string letter6 = TextBox_6.Text.ToLower();
            string letter7 = TextBox_7.Text.ToLower();
            string letter8 = TextBox_8.Text.ToLower();

            if (letter1 == "ф" &&
                letter2 == "р" &&
                letter3 == "о" &&
                letter4 == "н" &&
                letter5 == "т" &&
                letter6 == "э" &&
                letter7 == "н" &&
                letter8 == "д")
            {
                MessageBox.Show("правильно");
                GlobalVariables.Question1IsTrue = true;
                this.Close();
            } else
            {
                MessageBox.Show("не верно");
                TextBox_1.Clear();
                TextBox_2.Clear();
                TextBox_3.Clear();
                TextBox_4.Clear();
                TextBox_5.Clear();
                TextBox_6.Clear();
                TextBox_7.Clear();
                TextBox_8.Clear();
                GlobalVariables.Question1IsTrue = false;
            }
        }
    }
}
