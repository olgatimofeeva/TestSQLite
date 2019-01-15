using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSQLite.Tables;

namespace TestSQLite.Tables
{
    public class ChildrenAge: Entity
    {
        private string childrenAgeValue;
        
        public string ChildrenAgeValue
        {
            get { return childrenAgeValue; }
            set
            {
                childrenAgeValue = value;
                OnPropertyChanged("ChildrenAgeValue");
            }
        }
    }
}
