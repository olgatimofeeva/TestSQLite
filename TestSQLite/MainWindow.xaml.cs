using System.Data.Entity;
using System.Windows;
using TestSQLite.Tables;


namespace TestSQLite
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            db.Words.Load();
            db.ChildrenAges.Load();
            db.Specifications.Load();
            db.PartOfSpeeches.Load();
            this.DataContext = db.Words.Local.ToBindingList();
            //this.DataContext = db.Specifications.Local.ToBindingList();
        }


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WordWindow wordWindow = new WordWindow(new Word(),db);
            if (wordWindow.ShowDialog() == true)
            {
                Word words = wordWindow.Word;
               db.Words.Add(words);
                db.SaveChanges();
            }
        }

        private void searchText_Click(object sender, RoutedEventArgs e)
        {
            searchText.Clear();

        }


        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (List.SelectedItem == null) return;
            // получаем выделенный объект
            Word word = List.SelectedItem as Word;

            WordWindow wordWindow = new WordWindow(new Word
            {
                Id = word.Id,
                wordValue = word.wordValue,
                specification = word.specification,
                childrenAge = word.childrenAge,
                partOfSpeech = word.partOfSpeech
            }, db);
            if (wordWindow.ShowDialog() == true)
            {
               word = db.Words.Find(wordWindow.Word.Id);
                if (word != null)
                {
                    word.wordValue = wordWindow.Word.wordValue;
                    word.specificationId = wordWindow.Word.specificationId;
                    word.childrenAgeId = wordWindow.Word.childrenAgeId;
                    word.partOfSpeechId = wordWindow.Word.partOfSpeechId;
                    db.Entry(word).State = EntityState.Modified;
                    db.SaveChanges();
                    
                }
                List.Items.Refresh();
            }
        }

        public void Button_partOfSpeech(object sender, RoutedEventArgs e)
        {
            PartOfSpeechWindow partOfSpeechWindow = new PartOfSpeechWindow();
            partOfSpeechWindow.Show();
        }
        public void Button_childrenAge(object sender, RoutedEventArgs e)
        {
            ChildrenAgeWindow childrenAgeWindow = new ChildrenAgeWindow();
            childrenAgeWindow.Show();
        }
        public void Button_specification(object sender, RoutedEventArgs e)
        {
            SpecificationWindow specificationWindow = new SpecificationWindow();
            specificationWindow.Show();
        }

        public void Button_search(object sender, RoutedEventArgs e)
        {

        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (List.SelectedItem == null) return;
            // получаем выделенный объект
            Word word = List.SelectedItem as Word;
            db.Words.Remove(word);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
          //  List.Items.Refresh();
        }
    }
}
