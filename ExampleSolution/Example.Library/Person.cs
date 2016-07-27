using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Library
{
    public class Person
    {
        private int _age = 9;

        public int Name{ get; set; }
            
        public int Age
        {
            get { return _age;  }
            set { _age = value;  }
        }
    }
}
