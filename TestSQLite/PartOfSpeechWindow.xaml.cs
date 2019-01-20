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
    /// Логика взаимодействия для PartOfSpeechWindow.xaml
    /// </summary>
    public partial class PartOfSpeechWindow : Window
    {
        public ApplicationContext db;
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
            PartOfSpeech PoS= new PartOfSpeech();
            PoS.PartOfSpeechValue= TBPartOfSpeech.Text;
            db.PartOfSpeeches.Add(PoS);
            db.SaveChanges();
            
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null) return;
            // получаем выделенный объект
            PartOfSpeech PoS = List.SelectedItem as PartOfSpeech;
            PoS.PartOfSpeechValue = TBPartOfSpeech.Text;
            db.Entry(PoS).State = EntityState.Modified;
            db.SaveChanges();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null) return;
            // получаем выделенный объект
            PartOfSpeech PoS = List.SelectedItem as PartOfSpeech;
            db.PartOfSpeeches.Remove(PoS);
            db.SaveChanges();
        }




        private void List_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (List.SelectedItem == null) return;
            TBPartOfSpeech.Text = (List.SelectedItem as PartOfSpeech).PartOfSpeechValue;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
