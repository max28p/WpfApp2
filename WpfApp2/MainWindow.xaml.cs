using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GlobalVariables.timer = true;
            
        }

        private void Button_chit(object sender, RoutedEventArgs e)
        {
            box1_1.Text = "ф";
            box1_2.Text = "р";
            box1_3.Text = "о";
            box1_4.Text = "н";
            box1_5.Text = "т";
            box1_6.Text = "э";
            box1_7.Text = "н";
            box1_8.Text = "д";
            box2_1.Text = "п";
            box2_2.Text = "о";
            box2_3.Text = "г";
            box2_4.Text = "р";
            box2_5.Text = "а";
            box2_6.Text = "м";
            box2_7.Text = "м";
            box2_8.Text = "а";
            box3_1.Text = "и";
            box3_2.Text = "н";
            box3_3.Text = "т";
            box3_4.Text = "е";
            box3_5.Text = "р";
            box3_6.Text = "н";
            box3_7.Text = "е";
            box4_1.Text = "и";
            box4_2.Text = "г";
            box4_3.Text = "а";
            box4_4.Text = "б";
            box4_5.Text = "а";
            box4_6.Text = "й";
            box4_7.Text = "т";
            box5_1.Text = "р";
            box5_2.Text = "з";
            box5_3.Text = "ъ";
            box5_4.Text = "ё";
            box5_5.Text = "м";
            box6_1.Text = "е";
            box6_2.Text = "р";
            box6_3.Text = "а";
            box6_4.Text = "б";
            box6_5.Text = "а";
            box6_6.Text = "й";
            box6_7.Text = "т";
            box7_1.Text = "п";
            box7_2.Text = "й";
            box7_3.Text = "т";
            box7_4.Text = "о";
            box7_5.Text = "н";
            box8_1.Text = "а";
            box8_2.Text = "м";
            box8_3.Text = "я";
            box8_4.Text = "т";
            box8_5.Text = "ь";
            box9_1.Text = "е";
            box9_2.Text = "р";
            box9_3.Text = "м";
            box9_4.Text = "и";
            box9_5.Text = "н";
            box9_6.Text = "а";
            box9_7.Text = "л";
            box10_1.Text = "д";
            box10_2.Text = "ж";
            box10_3.Text = "в";
            box10_4.Text = "а";
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            question1 taskWindow = new question1();
            taskWindow.ShowDialog();
            if (GlobalVariables.Question1IsTrue == true)
            {
                box1_1.Text = "ф";
                box1_2.Text = "р";
                box1_3.Text = "о";
                box1_4.Text = "н";
                box1_5.Text = "т";
                box1_6.Text = "э";
                box1_7.Text = "н";
                box1_8.Text = "д";
                GlobalVariables.TextBox2_1True = true;
                GlobalVariables.TextBox3_1True = true;
            }

        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            question2 taskWindow = new question2();
            taskWindow.ShowDialog();
            if (GlobalVariables.Question2IsTrue == true)
            {
                box2_1.Text = "п";
                box2_2.Text = "о";
                box2_3.Text = "г";
                box2_4.Text = "р";
                box2_5.Text = "а";
                box2_6.Text = "м";
                box2_7.Text = "м";
                box2_8.Text = "а";
                GlobalVariables.TextBox4_2True = true;
                GlobalVariables.TextBox5_2True = true;
                GlobalVariables.TextBox7_2True = true;
            }
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            question3 taskWindow = new question3();
            taskWindow.ShowDialog();
            if (GlobalVariables.Question3IsTrue == true)
            {
                box3_1.Text = "и";
                box3_2.Text = "н";
                box3_3.Text = "т";
                box3_4.Text = "е";
                box3_5.Text = "р";
                box3_6.Text = "н";
                box3_7.Text = "е";
            }
        }
        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            question4 taskWindow = new question4();
            taskWindow.ShowDialog();
            if (GlobalVariables.Question4IsTrue == true)
            {
                box4_1.Text = "и";
                box4_2.Text = "г";
                box4_3.Text = "а";
                box4_4.Text = "б";
                box4_5.Text = "а";
                box4_6.Text = "й";
                box4_7.Text = "т";
                GlobalVariables.TextBox6_4True = true;
            }
        }
        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            question5 taskWindow = new question5();
            taskWindow.ShowDialog();
            if (GlobalVariables.Question5IsTrue == true)
            {
                box5_1.Text = "р";
                box5_2.Text = "з";
                box5_3.Text = "ъ";
                box5_4.Text = "ё";
                box5_5.Text = "м";
            }
        }
        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            question6 taskWindow = new question6();
            taskWindow.ShowDialog();
            if (GlobalVariables.Question6IsTrue)
            {
                box6_1.Text = "е";
                box6_2.Text = "р";
                box6_3.Text = "а";
                box6_4.Text = "б";
                box6_5.Text = "а";
                box6_6.Text = "й";
                box6_7.Text = "т";
            }
        }
        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            question7 taskWindow = new question7();
            taskWindow.ShowDialog();
            if (GlobalVariables.Question7IsTrue)
            {
                box7_1.Text = "п";
                box7_2.Text = "й";
                box7_3.Text = "т";
                box7_4.Text = "о";
                box7_5.Text = "н";
                GlobalVariables.TextBox8_7True = true;
            }
        }
        private void Button_Click8(object sender, RoutedEventArgs e)
        {
            question8 taskWindow = new question8();
            taskWindow.ShowDialog();
            if (GlobalVariables.Question8IsTrue)
            {
                box8_1.Text = "а";
                box8_2.Text = "м";
                box8_3.Text = "я";
                box8_4.Text = "т";
                box8_5.Text = "ь";
                GlobalVariables.TextBox9_8True = true;
            }
        }
        private void Button_Click9(object sender, RoutedEventArgs e)
        {
            question9 taskWindow = new question9();
            taskWindow.ShowDialog();
            if (GlobalVariables.Question9IsTrue)
            {
                box9_1.Text = "е";
                box9_2.Text = "р";
                box9_3.Text = "м";
                box9_4.Text = "и";
                box9_5.Text = "н";
                box9_6.Text = "а";
                box9_7.Text = "л";
                GlobalVariables.TextBox10_9True = true;
            }
        }
        private void Button_Click10(object sender, RoutedEventArgs e)
        {
            question10 taskWindow = new question10();
            taskWindow.ShowDialog();
            if (GlobalVariables.Question10IsTrue)
            {
                box10_1.Text = "д";
                box10_2.Text = "ж";
                box10_3.Text = "в";
                box10_4.Text = "а";
            }
        }
        private void Button_Click11(object sender, RoutedEventArgs e)
        {
            string letter1_1 = box1_1.Text.ToLower();
            string letter1_2 = box1_2.Text.ToLower();
            string letter1_3 = box1_3.Text.ToLower();
            string letter1_4 = box1_4.Text.ToLower();
            string letter1_5 = box1_5.Text.ToLower();
            string letter1_6 = box1_6.Text.ToLower();
            string letter1_7 = box1_7.Text.ToLower();
            string letter1_8 = box1_8.Text.ToLower();
            string letter2_1 = box2_1.Text.ToLower();
            string letter2_2 = box2_2.Text.ToLower();
            string letter2_3 = box2_3.Text.ToLower();
            string letter2_4 = box2_4.Text.ToLower();
            string letter2_5 = box2_5.Text.ToLower();
            string letter2_6 = box2_6.Text.ToLower();
            string letter2_7 = box2_7.Text.ToLower();
            string letter2_8 = box2_8.Text.ToLower();
            string letter3_1 = box3_1.Text.ToLower();
            string letter3_2 = box3_2.Text.ToLower();
            string letter3_3 = box3_3.Text.ToLower();
            string letter3_4 = box3_4.Text.ToLower();
            string letter3_5 = box3_5.Text.ToLower();
            string letter3_6 = box3_6.Text.ToLower();
            string letter3_7 = box3_7.Text.ToLower();
            string letter4_1 = box4_1.Text.ToLower();
            string letter4_2 = box4_2.Text.ToLower();
            string letter4_3 = box4_3.Text.ToLower();
            string letter4_4 = box4_4.Text.ToLower();
            string letter4_5 = box4_5.Text.ToLower();
            string letter4_6 = box4_6.Text.ToLower();
            string letter4_7 = box4_7.Text.ToLower();
            string letter5_1 = box5_1.Text.ToLower();
            string letter5_2 = box5_2.Text.ToLower();
            string letter5_3 = box5_3.Text.ToLower();
            string letter5_4 = box5_4.Text.ToLower();
            string letter5_5 = box5_5.Text.ToLower();
            string letter6_1 = box6_1.Text.ToLower();
            string letter6_2 = box6_2.Text.ToLower();
            string letter6_3 = box6_3.Text.ToLower();
            string letter6_4 = box6_4.Text.ToLower();
            string letter6_5 = box6_5.Text.ToLower();
            string letter6_6 = box6_6.Text.ToLower();
            string letter6_7 = box6_7.Text.ToLower();
            string letter7_1 = box7_1.Text.ToLower();
            string letter7_2 = box7_2.Text.ToLower();
            string letter7_3 = box7_3.Text.ToLower();
            string letter7_4 = box7_4.Text.ToLower();
            string letter7_5 = box7_5.Text.ToLower();
            string letter8_1 = box8_1.Text.ToLower();
            string letter8_2 = box8_2.Text.ToLower();
            string letter8_3 = box8_3.Text.ToLower();
            string letter8_4 = box8_4.Text.ToLower();
            string letter8_5 = box8_5.Text.ToLower();
            string letter9_1 = box9_1.Text.ToLower();
            string letter9_2 = box9_2.Text.ToLower();
            string letter9_3 = box9_3.Text.ToLower();
            string letter9_4 = box9_4.Text.ToLower();
            string letter9_5 = box9_5.Text.ToLower();
            string letter9_6 = box9_6.Text.ToLower();
            string letter9_7 = box9_7.Text.ToLower();
            string letter10_1 = box10_1.Text.ToLower();
            string letter10_2 = box10_2.Text.ToLower();
            string letter10_3 = box10_3.Text.ToLower();
            string letter10_4 = box10_4.Text.ToLower();
            if (letter1_1 == "ф" &&
                letter1_2 == "р" &&
                letter1_3 == "о" &&
                letter1_4 == "н" &&
                letter1_5 == "т" &&
                letter1_6 == "э" &&
                letter1_7 == "н" &&
                letter1_8 == "д" &&
                letter2_1 == "п" &&
                letter2_2 == "о" &&
                letter2_3 == "г" &&
                letter2_4 == "р" &&
                letter2_5 == "а" &&
                letter2_6 == "м" &&
                letter2_7 == "м" &&
                letter2_8 == "а" &&
                letter3_1 == "и" &&
                letter3_2 == "н" &&
                letter3_3 == "т" &&
                letter3_4 == "е" &&
                letter3_5 == "р" &&
                letter3_6 == "н" &&
                letter3_7 == "е" &&
                letter4_1 == "и" &&
                letter4_2 == "г" &&
                letter4_3 == "а" &&
                letter4_4 == "б" &&
                letter4_5 == "а" &&
                letter4_6 == "й" &&
                letter4_7 == "т" &&
                letter5_1 == "р" &&
                letter5_2 == "з" &&
                letter5_3 == "ъ" &&
                letter5_4 == "ё" &&
                letter5_5 == "м" &&
                letter6_1 == "е" &&
                letter6_2 == "р" &&
                letter6_3 == "а" &&
                letter6_4 == "б" &&
                letter6_5 == "а" &&
                letter6_6 == "й" &&
                letter6_7 == "т" &&
                letter7_1 == "п" &&
                letter7_2 == "й" &&
                letter7_3 == "т" &&
                letter7_4 == "о" &&
                letter7_5 == "н" &&
                letter8_1 == "а" &&
                letter8_2 == "м" &&
                letter8_3 == "я" &&
                letter8_4 == "т" &&
                letter8_5 == "ь" &&
                letter9_1 == "е" &&
                letter9_2 == "р" &&
                letter9_3 == "м" &&
                letter9_4 == "и" &&
                letter9_5 == "н" &&
                letter9_6 == "а" &&
                letter9_7 == "л" &&
                letter10_1 == "д" &&
                letter10_2 == "ж" &&
                letter10_3 == "в" &&
                letter10_4 == "а")
            {
                final taskWindow = new final();
                taskWindow.ShowDialog();
                GlobalVariables.timer = false;
                
                if (GlobalVariables.clousAll == true)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("заполнено не всё");
            }
        }
    }
}