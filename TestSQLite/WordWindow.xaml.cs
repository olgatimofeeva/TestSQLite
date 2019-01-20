using System.Data.Entity;
using System.Windows;
using System.Windows.Controls;
using TestSQLite.Tables;


namespace TestSQLite
{
    /// <summary>
    /// Логика взаимодействия для WordWindow.xaml
    /// </summary>
    public partial class WordWindow : Window
    {
        ApplicationContext db;
        //PartOfSpeechInput.ItemsSource = db.ChildrenAges.Local.ToBindingList();

        //    cbtry.DisplayMemberPath = "ChildrenAgeValue";
        //    cbtry.SelectedValuePath = "Id";
        public Word Word { get; private set; }
        public WordWindow(Word p,ApplicationContext DB)
        {
            db = DB;
            InitializeComponent();
            Word = p;
            this.DataContext = Word;

            //combobox с частями речи
            PartOfSpeechInput.ItemsSource = db.PartOfSpeeches.Local.ToBindingList();
            PartOfSpeechInput.DisplayMemberPath = "PartOfSpeechValue";
            PartOfSpeechInput.SelectedValuePath = "Id";

            //combobox со специфиацией
            SpecificationInput.ItemsSource = db.Specifications.Local.ToBindingList();
            SpecificationInput.DisplayMemberPath = "SpecificationValue";
            SpecificationInput.SelectedValuePath = "Id";

            //combobox с возрастами
            ChildrenAgeInput.ItemsSource = db.ChildrenAges.Local.ToBindingList();
            ChildrenAgeInput.DisplayMemberPath = "ChildrenAgeValue";
            ChildrenAgeInput.SelectedValuePath = "Id";
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;            
        }

        private void PartOfSpeechInput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Word.partOfSpeechId = PartOfSpeechInput.SelectedIndex + 1;
        }

        private void SpecificationInput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Word.specificationId = SpecificationInput.SelectedIndex + 1;
        }
        private void ChildrenAgeInput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Word.childrenAgeId = ChildrenAgeInput.SelectedIndex + 1;
        }


    }
}
