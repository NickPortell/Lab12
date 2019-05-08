using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Person
    {
        #region Data Members
        private string name;
        private string address;
        #endregion

        #region Constructors
        public Person(string _name, string _address)
        {
            name = _name;
            address = _address;
        }
        public Person()
        {

        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"\tName: {name}\n\tAddress: {address}\n";
        }
        #endregion
    }
}
