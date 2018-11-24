using System.Data.Entity;
using System.Windows;


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
            this.DataContext = db.Words.Local.ToBindingList();


        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            WordWindow wordWindow = new WordWindow(new Words());
            if (wordWindow.ShowDialog() == true)
            {
                Words words = wordWindow.Word;
                db.Words.Add(words);
                db.SaveChanges();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            // если ни одного объекта не выделено, выходим
            if (phonesList.SelectedItem == null) return;
            // получаем выделенный объект
            Words word = phonesList.SelectedItem as Words;

            WordWindow wordWindow = new WordWindow(new Words
            {
                Id = word.Id,
                word = word.word,
                partofspeech = word.partofspeech,
                specification = word.specification
            });
            if (wordWindow.ShowDialog() == true)
            {
                word = db.Words.Find(wordWindow.Word.Id);
                if (word != null)
                {
                    word.word = wordWindow.Word.word;
                    word.partofspeech = wordWindow.Word.partofspeech;
                    word.specification = wordWindow.Word.specification;
                    db.Entry(word).State = EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
