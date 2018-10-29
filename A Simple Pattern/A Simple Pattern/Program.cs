using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Simple_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aşağıdaki şekil bir örüntü sonucu ortaya çıkmıştır. Bu örüntüyü sağlayabilecek algoritmayı tasarlayınız.

            //*-*-
            //**-**-**-
            //***-***-***-***-



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        if (k <= i)
                        {
                            Console.Write("*");
                        }
                    }

                    Console.Write("-");
                    if (j > i)
                    {
                        break;
                    }


                }

                Console.WriteLine();

            }
        }
    }
}
