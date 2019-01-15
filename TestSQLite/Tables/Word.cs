using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSQLite.Tables
{
    public class Word : Entity
    {
        private string WordValue;
        private int SpecificationId;
        private int PartOfSpeechId;
        private int ChildrenAgeId;

        public PartOfSpeech partOfSpeech { get; set; }

        public Specification specification { get; set; }

        public ChildrenAge childrenAge { get; set; }

        public int specificationId
        {
            get { return SpecificationId; }
            set
            {
                SpecificationId = value;
                OnPropertyChanged("SpecificationId");
            }
        }

        public int childrenAgeId
        {
            get { return ChildrenAgeId; }
            set
            {
                ChildrenAgeId = value;
                OnPropertyChanged("ChildrenAgeId");
            }
        }

        public int partOfSpeechId
        {
            get { return PartOfSpeechId; }
            set
            {
                PartOfSpeechId = value;
                OnPropertyChanged("PartOfSpeechId");
            }
        }


        public string wordValue
        {
            get { return WordValue; }
            set
            {
                WordValue = value;
                OnPropertyChanged("Word");
            }
        }

    }
}
