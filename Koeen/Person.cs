using System;
using System.Collections.Generic;
using System.Text;

namespace Koeen
{
    class Person
    {
        private string _name;
        private int _age;
        private DateTime _date;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int age
        {
            get { return _age; }
            set { _age = value; }
        }
        public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }
        public Person(string _navn)
        {
            this._name = _navn;
            this._date = DateTime.Now;
        }
    }
}
