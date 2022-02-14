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
            if(text_box.Text.Length > 0) {// если в текстовом поле содержиться какое-то значение
                ListValues.Add(float.Parse(text_box.Text));// добавляем его в массив, параллельно преобразовывая в тип float

                list_box.Items.Clear();// очищаем ListBox
                for (int i = 0; i < ListValues.Count; i++)// перебираем элемеенты в массиве
                    list_box.Items.Add(ListValues[i]);// добавляем элементы в ListBox
            }
        }
    }
}
