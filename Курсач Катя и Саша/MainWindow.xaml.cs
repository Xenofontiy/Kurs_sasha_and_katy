using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
using Курсач_Катя_и_Саша.NewFolder1;

namespace Курсач_Катя_и_Саша
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List <Interface1> List_Cities = new List<Interface1>();
        string Path_inf; int numer_;

        public MainWindow()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                List<string> SpisokGorodov = new List<string>();
                if (dialog.FileName != "")
                {
                    string productString = File.ReadAllText(dialog.FileName);
                    SpisokGorodov.AddRange(productString.Split('\n'));
                    Test.Content = SpisokGorodov.Count;

                }
                else
                {
                    MessageBox.Show("Выберите файл");
                    return;
                }

                List_Cities.Clear();
                Cities_ListView.ItemsSource = null;

                for (int i = 0; i < SpisokGorodov.Count; i++)
                {
                    if (SpisokGorodov[i] != "")
                    {
                        string[] data = new string[6];
                        data = SpisokGorodov[i].Split(':');
                        List_Cities.Add(new Class2(data[0], Int32.Parse(data[1]), Int32.Parse(data[2]), Int32.Parse(data[3]), Int32.Parse(data[4]), Int32.Parse(data[5]), Int32.Parse(data[6])));

                    }
                }
                Cities_ListView.ItemsSource = List_Cities;

            }
            catch (Exception)
            {
                MessageBox.Show("Проверьте формат файла и путь");
            }
        }

        private void Timetable_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
