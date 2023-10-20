using System;

namespace Ciclos;

class Program
{
    static void Main()
    {
        
       /// creacion de un array ///
      //Tipo [] nomnbredelarray = new Tipo [longituddelarray]

       static int Mayor (int[] array)
       {

          if (array.Length == 0)
          {
            Console.WriteLine("el array no contiene elementos");
          }
          
            int mayor = array[0];
            for (int i = 0; i <array.Length; i++)
            {
                 if (array[i] > mayor)
                 {
                    mayor = array[i];
                 }
            }
            return mayor;
          

       }

       int [] arrayy = {7,2,8,3,6,9,23,54};
       Mayor(arrayy);


    }
}