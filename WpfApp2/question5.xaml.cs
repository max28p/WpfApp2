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
    public partial class question5 : Window
    {
        public question5()
        {
            InitializeComponent();
            if (GlobalVariables.TextBox5_2True == true)
            {
                TextBox_2.Text = "а";
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

            if( letter1 == "р" &&
                letter2 == "а" &&
                letter3 == "з" &&
                letter4 == "ъ" &&
                letter5 == "ё" &&
                letter6 == "м")
            {
                MessageBox.Show("правивльно");
                GlobalVariables.Question5IsTrue= true;
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
            }
        }
    }
}
