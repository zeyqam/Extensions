using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//2 eded extension method yazirsiz. Biri emailin icinde @ isaresinin olub olmamasini yoxlamalidir.
//Digeri passwordun uzunluqunun 8den boyuk olub olmadigini yoxlamalidir.

namespace Homework_Extensions.Extensions
{
    public static class StringExtensions
    {
        public static bool HasAtSymbol(this string email)
        {
            return email.Contains("@");
        }
        public static bool IsPasswordLengthValid(this string password)
        {
            return password.Length > 8;
        }



    }
}
