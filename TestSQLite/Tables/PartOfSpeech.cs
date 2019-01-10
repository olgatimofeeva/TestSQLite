using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSQLite.Tables
{
    public class PartOfSpeech: Tables.Entity
    {
        private string PartOfSpeechValue;

        public string partOfSpeechValue
        {
            get { return PartOfSpeechValue; }
            set
            {
                PartOfSpeechValue = value;
                OnPropertyChanged("PartOfSpeechValue");
            }
        }

    }
}
