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

namespace Rib_proj
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

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        List<string> list = new List<string>();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //var list = new List<string>();
            //string newMessage = boxtext.Text;

            list.Add(boxtext.Text);
            //blocktext.Text += list + "\r\n";
            foreach (string li in list)
            {
                int i = 0;
                blocktext.Text += list[i] + "\r\n";
                i++;
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
