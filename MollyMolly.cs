using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* За това какво прави програмата - виж файла 1. 2-4-8_Условие на задачата
*/
namespace _2_4_8
{
    class MollyMolly
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            int R;
            switch(B){
                case 2: 
                    R = A%C;
                    break;
                case 4: 
                    R=A+C;
                    break;
                case 8:
                    R=A*C;
                    break;
                default: 
                    Console.WriteLine("Unknown secret Code!!!");
                    R = 0;
                    break;
            }

            if(R%4 == 0) 
            {
                Console.WriteLine(R/4);
            }
            else 
            {
                Console.WriteLine(R%4);
            }

            Console.WriteLine(R);
            Console.ReadKey();
        }
    }
}
