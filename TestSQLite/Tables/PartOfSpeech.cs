using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSQLite.Tables
{
    public class PartOfSpeech: Tables.Entity
    {
        private string partOfSpeechValue;

        public string PartOfSpeechValue
        {
            get { return partOfSpeechValue; }
            set
            {
                partOfSpeechValue = value;
                OnPropertyChanged("PartOfSpeechValue");
            }
        }

    }
}
