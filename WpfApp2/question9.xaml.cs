﻿using System;
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

namespace WpfApp2
{
    public partial class question9 : Window
    {
        public question9()
        {
            InitializeComponent();
            if (GlobalVariables.TextBox9_8True == true)
            {
                TextBox_1.Text = "т";
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            string letter1 = TextBox_1.Text.ToLower();
            string letter2 = TextBox_2.Text.ToLower();
            string letter3 = TextBox_3.Text.ToLower();
            string letter4 = TextBox_4.Text.ToLower();
            string letter5 = TextBox_5.Text.ToLower();
            string letter6 = TextBox_6.Text.ToLower();
            string letter7 = TextBox_7.Text.ToLower();
            string letter8 = TextBox_8.Text.ToLower();

            if (letter1 == "т" &&
                letter2 == "е" &&
                letter3 == "р" &&
                letter4 == "м" &&
                letter5 == "и" &&
                letter6 == "н" &&
                letter7 == "а" &&
                letter8 == "л")
            {
                MessageBox.Show("правильно");
                GlobalVariables.Question9IsTrue = true;
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
            }
        }
    }
}
