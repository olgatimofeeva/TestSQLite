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
            Specification Spec = new Specification();
            Spec.SpecificationValue = TBSpecification.Text;
            db.Specifications.Add(Spec);
            db.SaveChanges();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null) return;
            // получаем выделенный объект
            Specification Spec = List.SelectedItem as Specification;
            Spec.SpecificationValue = TBSpecification.Text;
            db.Entry(Spec).State = EntityState.Modified;
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null) return;
            // получаем выделенный объект
            Specification Spec = List.SelectedItem as Specification;
            db.Specifications.Remove(Spec);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
            this.Close();
        }

        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (List.SelectedItem == null) return;
            TBSpecification.Text = (List.SelectedItem as Specification).SpecificationValue;
        }
    }
}
