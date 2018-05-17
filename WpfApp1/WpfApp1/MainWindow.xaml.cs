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
        //紀錄檔案路徑
        string File_Path = "";
        public MainWindow()
        {            
            InitializeComponent();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            //先將Textbox清空
            TextArea.Text = "";

            //開啟儲存檔案視窗
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();
            Nullable<bool> result = dig.ShowDialog();

            if (result == true)
            {
                File_Path = dig.FileName;
                System.IO.File.WriteAllText(File_Path, TextArea.Text);
            }

            //開啟檔案
            TextArea.Text = System.IO.File.ReadAllText(dig.FileName);
            Title = dig.SafeFileName;
        }

        private void Open_Click_1(object sender, RoutedEventArgs e)
        {
            //開啟檔案視窗
            Microsoft.Win32.OpenFileDialog dig = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = dig.ShowDialog();

            if (result == true)
            {
                File_Path = dig.FileName;
                TextArea.Text = System.IO.File.ReadAllText(dig.FileName);
            }

            Title = dig.SafeFileName;
        }

        private void Save_Click_2(object sender, RoutedEventArgs e)
        {
            //假如儲存路徑為空
            if (File_Path == "")
            {
                //則另存新的檔案
                Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();
                Nullable<bool> result = dig.ShowDialog();

                if (result == true)
                {
                    File_Path = dig.FileName;
                    System.IO.File.WriteAllText(File_Path, TextArea.Text);
                }

                Title = dig.SafeFileName;
            }
            else
            {
                //不然則直接儲存
                System.IO.File.WriteAllText(File_Path, TextArea.Text);
            }
        }

        //改變字體大小
        private void A10_Click(object sender, RoutedEventArgs e)
        {
            TextArea.FontSize = 10;
        }

        private void A14_Click(object sender, RoutedEventArgs e)
        {
            TextArea.FontSize = 14;
        }

        private void A18_Click(object sender, RoutedEventArgs e)
        {
            TextArea.FontSize = 18;
        }

        private void Save_as_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();
            Nullable<bool> result = dig.ShowDialog();

            if (result == true)
            {
                File_Path = dig.FileName;
                System.IO.File.WriteAllText(File_Path, TextArea.Text);
            }

            Title = dig.SafeFileName;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            //將背景顏色改為灰，字體顏色為深灰
            TextArea.Background = Brushes.DarkGray;
            TextArea.Foreground = Brushes.Gray;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            //將背景顏色改為白，字體顏色為深灰
            TextArea.Background = Brushes.White;
            TextArea.Foreground = Brushes.DarkGray;
        }
    }
}
