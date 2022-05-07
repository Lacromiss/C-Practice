using System;
using System.Collections.Generic;
using System.Text;

namespace Tekrar5
{
    internal class Employee
    {
        private string _name;
        public string Name
        {
            get { return this._name; }
            set
            {
                if (CheckCondition(value))
                {
                    this._name = value;
                }
            }
        }
        public string Surname;
        private double _salary;

        public double Salary
        {
            get { return this._salary; }
            set
            {
                if (value >= 250)
                {
                    this._salary = value;
                }
            }
        }

        public bool CheckCondition(string word)
        {
            if (!string.IsNullOrWhiteSpace(word) && char.IsUpper(word[0]))
            {
                for (int i = 1; i < word.Length; i++)
                {
                    if (!char.IsLetter(word[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}