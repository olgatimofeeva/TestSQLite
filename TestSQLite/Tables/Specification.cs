using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSQLite.Tables
{
    public class Specification: Tables.Entity
    {

        private string SpecificationValue; 

        public string specificationValue
        {
            get { return SpecificationValue; }
            set
            {
                SpecificationValue = value;
                OnPropertyChanged("SpecificationValue");
            }
        }

    }
}
