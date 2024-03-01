using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//int arrayi ucun extention method yazirsiz.
//Hemin extention method arrayin elementlerinin hasilini tapsin

namespace Homework_Extensions.Extensions
{
    public static  class ArrayExtensions
    {
        public static int Product(this int[] array)
        {
            if(array == null || array.Length==0)
            {
                return 0;
            }

            int result=1;
            foreach(int item in array)
            {
                result*= item;
            }
            return result;
        }
    }
}
