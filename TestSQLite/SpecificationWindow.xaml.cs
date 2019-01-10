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
using TestSQLite.Tables;

namespace TestSQLite
{
    /// <summary>
    /// Логика взаимодействия для SpecificationWindow.xaml
    /// </summary>
    public partial class SpecificationWindow : Window
    {
        ApplicationContext db;
        public SpecificationWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Specifications.Load();
            this.DataContext = db.Specifications.Local.ToBindingList();
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
