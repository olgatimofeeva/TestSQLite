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
using System.Windows.Shapes;
using System.Data.Entity;

namespace TestSQLite
{
    /// <summary>
    /// Логика взаимодействия для PartOfSpeechWindow.xaml
    /// </summary>
    public partial class PartOfSpeechWindow : Window
    {
        ApplicationContext db;
        public PartOfSpeechWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.PartOfSpeeches.Load();
            this.DataContext = db.PartOfSpeeches.Local.ToBindingList();
        }

        //кнопки сверху
        public void Button_MainWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void searchText_Click(object sender, RoutedEventArgs e)
        {
            searchText.Clear();

        }

        public void Button_search(object sender, RoutedEventArgs e)
        {

        }

        //конпки снизу
        private void Add_Click(object sender, RoutedEventArgs e)
        {
  
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
        }


    }
}
