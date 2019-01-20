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
            PartOfSpeechInput.Items.Refresh();

            //combobox со специфиацией
            SpecificationInput.ItemsSource = db.Specifications.Local.ToBindingList();
            SpecificationInput.DisplayMemberPath = "SpecificationValue";
            SpecificationInput.SelectedValuePath = "Id";
            SpecificationInput.Items.Refresh();

            //combobox с возрастами
            ChildrenAgeInput.ItemsSource = db.ChildrenAges.Local.ToBindingList();
            ChildrenAgeInput.DisplayMemberPath = "ChildrenAgeValue";
            ChildrenAgeInput.SelectedValuePath = "Id";
            ChildrenAgeInput.Items.Refresh();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;            
        }

        private void PartOfSpeechInput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Word.partOfSpeechId = (int)PartOfSpeechInput.SelectedValue;
        }

        private void SpecificationInput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Word.specificationId = (int)SpecificationInput.SelectedValue ;
        }
        private void ChildrenAgeInput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Word.childrenAgeId = (int)ChildrenAgeInput.SelectedValue;
        }


    }
}
