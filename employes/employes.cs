using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace employes
{
    internal class Employes
    {
        public string name;
        public string surname;
        public string _fullName;
        public string No;
        public int _salary ;
        public Employes(string no, string fullname,int salary,)
        {
            No = no;
            
             Salary=salary;
        }
        public int Salary
        {
            get => _salary;
            set
            {
                if (value >= 250)
                {
                    _salary = value;
                }
                else
                {
                    throw new Exception("Maas deyrei 250-dan kicik ola bilmez!");
                }
            }
        }
        static bool IsCapitalized(string str)
        {
            if (!Char.IsUpper(str[0]))
                return false;

            for (int i = 1; i < str.Length; i++)
            {
                if (!Char.IsLower(str[i]))
                    return false;
            }

            return true;
        }

        static bool IsFullname(string str)
        {
            var words = str.Split(' ');

            if (words.Length != 2)
                return false;

            if (!IsCapitalized(words[0]) || !IsCapitalized(words[1]))
                return false;

            return true;
        }
        static bool ContainsOnlyLetter(string str)
        {
            if (!string.IsNullOrWhiteSpace(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (!char.IsLetter(str[i]))
                        return false;
                }
                return true;
            }
            return false;
        }
        public string GetInfo()
        {
            return $"fullName: {_fullName} - Salary: {Salary}-No{No}";
        }


    }

    


    
}
