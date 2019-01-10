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
        private string ChildrenAgeValue;

        public string childrenAgeValue
        {
            get { return ChildrenAgeValue; }
            set
            {
                ChildrenAgeValue = value;
                OnPropertyChanged("ChildrenAgeValue");
            }
        }
    }
}
