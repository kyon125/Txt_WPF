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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Open_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = dig.ShowDialog();

            if (result == true)
            {
                TextArea.Text = System.IO.File.ReadAllText(dig.FileName);
            }
        }

        private void Save_Click_2(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();
            Nullable<bool> result = dig.ShowDialog();

            if (result == true)
            {
                string filename = dig.FileName;
            }
        }

        private void A10_Click(object sender, RoutedEventArgs e)
        {

        }

        private void A14_Click(object sender, RoutedEventArgs e)
        {

        }

        private void A18_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
