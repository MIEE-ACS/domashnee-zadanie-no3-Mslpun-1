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

namespace dz3
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string RUb = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string ENGb = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string RUs = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            string ENGs = "abcdefghijklmnopqrstuvwxyz";
            string bb = RUb + ENGb + RUs + ENGs;

            string end = "";    
            string f = "";
            string text = tb1.Text;
            string key = tb2.Text;
            int n = key.Length;
            char c = 'a';
            int g = 0;
            string key1 = "";
            for(int i = 0; i < key.Length; i++)
            {
                if (Char.IsLetter(key[i]) && !Char.IsDigit(key[i]) && !Char.IsPunctuation(key[i]) )
                {
                    key1 = key1 + key[i];
                }
            }
            if (key1.Length < text.Length)
            {
                while (key1.Length != text.Length)
                {
                    if (g < n)
                    {
                        c = key1[g];
                        g++;
                    }
                    else
                    {
                        g = 0;
                        c = key1[g];
                        g++;
                    }
                    key1 = key1 + c;
                }
                key = key1;
            }
            MessageBox.Show(key,"Ваш ключ получает форму: ");
            int b = 0 , l = 0;
            for (int i = 0; i < text.Length; i++)
            {
                int y = 0;
                for (int d = 0; d < bb.Length; d++)
                {
                    if (text[i] == bb[d])
                    {
                        y = 1;
                    }
                }
                if (y == 1)
                {
                    for (int z = 0; z < RUb.Length; z++)
                    {
                        if (text[i] == RUb[z])
                        {
                            b = z;
                            f = RUb;
                        }
                        if (key[i] == RUb[z])
                        {
                            l = z;
                        }
                    }
                    for (int z = 0; z < RUs.Length; z++)
                    {
                        if (text[i] == RUs[z])
                        {
                            b = z;
                            f = RUs;
                        }
                        if (key[i] == RUs[z])
                        {
                            l = z;
                        }
                    }

                    for (int k = 0; k < ENGb.Length; k++)
                    {
                        if (text[i] == ENGb[k])
                        {
                            b = k;
                            f = ENGb;
                        }
                        if (key[i] == ENGb[k])
                        {
                            l = k;
                        }
                    }
                    for (int k = 0; k < ENGs.Length; k++)
                    {
                        if (text[i] == ENGs[k])
                        {
                            b = k;
                            f = ENGs;
                        }
                        if (key[i] == ENGs[k])
                        {
                            l = k;
                        }
                    }
                    if (rb2.IsChecked == true)
                    {
                        c = f[(b + l) % f.Length];
                        end = end + c;
                    }
                    else if (rb1.IsChecked == true)
                    {
                        c = f[(b + f.Length - l) % f.Length];
                        end = end + c;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка! Выберите шифрование или дешифрование.", "Ошибка!");
                    }
                }
                else
                {
                    end = end + text[i];
                }

            }
            tb3.Text = end;
        }
    }
}
