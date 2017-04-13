using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedTopics
{
    public class FirstClass
    {
        private int number;
        public int Number {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public int MyProperty { get; set; }

        public FirstClass(int initialNumber)
        {
            number = initialNumber;
        }

        public FirstClass()
        {

        }
    }
}
