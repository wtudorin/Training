using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample01
{
    public class Person
    {
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String SurnName { get; set; }
        public String Location { get; set; }
        public int Age { get; set; }
        public Person Wife { get; set; }
        public List<Person> Children { get; set; }
        public Person Father { get; set; }
        public Person Mother { get; set; }
        public Person GranFather { get; set; }
        public Person GranMother { get; set; }
        public Person GranChild { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string Suburb { get; set; }
        public string State { get; set; }

    }

}
