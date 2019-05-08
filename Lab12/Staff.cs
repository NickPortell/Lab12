using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff:Person
    {
        #region Data Members
        private string school;
        private double pay;
        #endregion

        #region Constructors
        public Staff(string _name, string _address, string _school, double _pay) :base(_name,_address)
        {
            school = _school;
            pay = _pay;

        }
        public Staff()
        {

        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"{base.ToString()}\tSchool: {school}\n\tPay: {pay}\n";
        }
        #endregion


    }
}
