using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student:Person
    {
        #region Data Members
        private string program;
        private int year;
        private double fee;
        #endregion

        #region Constructors
        public Student(string _name, string _address, string _program, int _year, double _fee) : base(_name, _address)
        {
            program = _program;
            year = _year;
            fee = _fee;

        }
        public Student()
        {

        }
        #endregion

        #region Methods
        public override string ToString() 
        {
            return $"{base.ToString()}\tProgram: {program}\n\tYear: {year}\n\tFee: {fee}\n";
        }
        #endregion
    }
}
