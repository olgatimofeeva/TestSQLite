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

namespace TestSQLite
{
    /// <summary>
    /// Логика взаимодействия для WordWindow.xaml
    /// </summary>
    public partial class WordWindow : Window
    {
        public Words Word { get; private set; }
        public WordWindow(Words p)
        {
            InitializeComponent();

            Word = p;
            this.DataContext = Word;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
