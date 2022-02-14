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

namespace _4pr
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

        //массив(коллекция)
        public List<float> ListValues = new List<float>();

        /// <summary>
        /// Функция добавления элемента в массив
        /// </summary>

        private void AddList(object sender, RoutedEventArgs e)
        {
            if (value_list.Text.Length > 0)
            {
                ListValues.Add(float.Parse(value_list.Text));

                list_values.Items.Clear();
                for (int i = 0; i < ListValues.Count; i++)
                    list_values.Items.Add(ListValues[i]);
            }
        }




        public List<string> listValues2 = new List<string>();




        private void AddList2(object sender, RoutedEventArgs e)
        {
            string text = value_list2.Text;
            listValues2 = value_list2.Text.Split(' ').ToList();
            for (int i = 0; i < listValues2.Count; i++)
            {
                list_values2.Items.Add(listValues2[i]);
            }
        }
    }
}
