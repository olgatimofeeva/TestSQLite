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
using TestSQLite.Tables;
using System.Data.Entity;

namespace TestSQLite
{
    /// <summary>
    /// Логика взаимодействия для ChildrenAgeWindow.xaml
    /// </summary>
    public partial class ChildrenAgeWindow : Window
    {
        ApplicationContext db;
        public ChildrenAgeWindow()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.ChildrenAges.Load();
            this.DataContext = db.ChildrenAges.Local.ToBindingList();
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
            ChildrenAge ChAge = new ChildrenAge();
            ChAge.ChildrenAgeValue = TBChildrenAge.Text;
            db.ChildrenAges.Add(ChAge);
            db.SaveChanges();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null) return;
            // получаем выделенный объект
            ChildrenAge ChAge = List.SelectedItem as ChildrenAge;
            ChAge.ChildrenAgeValue = TBChildrenAge.Text;
            db.Entry(ChAge).State = EntityState.Modified;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null) return;
            // получаем выделенный объект
            ChildrenAge ChAge = List.SelectedItem as ChildrenAge;
            db.ChildrenAges.Remove(ChAge);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
            this.Close();
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (List.SelectedItem == null) return;
            TBChildrenAge.Text = (List.SelectedItem as ChildrenAge).ChildrenAgeValue;
        }
    }
}
