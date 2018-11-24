using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestSQLite
{
   public class Words : INotifyPropertyChanged
    {
        private string Word;
        private string PartOfSpeech;
        private string Specification;

        public int Id { get; set; }

        public string word
        {
            get { return Word; }
            set
            {
                Word = value;
                OnPropertyChanged("Word");
            }
        }

        public string partofspeech
        {
            get { return PartOfSpeech; }
            set
            {
                PartOfSpeech = value;
                OnPropertyChanged("PartOfSpeech");
            }
        }

        public string specification
        {
            get { return Specification; }
            set
            {
                Specification = value;
                OnPropertyChanged("Specification");
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
