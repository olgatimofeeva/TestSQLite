using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSQLite.Tables
{
    public class Specification: Tables.Entity
    {

        private string specificationValue; 

        public string SpecificationValue
        {
            get { return specificationValue; }
            set
            {
                specificationValue = value;
                OnPropertyChanged("SpecificationValue");
            }
        }

    }
}
