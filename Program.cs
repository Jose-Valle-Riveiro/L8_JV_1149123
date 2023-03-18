using System;

namespace L8_JV_1149123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("LABORATORIO 8");
            Console.WriteLine("JOSE RODRIGO VALLE RIVERO");
            Console.WriteLine("1149123");
            Console.WriteLine("--------------------------------");


            Console.WriteLine("BINARIOS: ");
            Console.WriteLine("INGRESE UN NUMERO: ");
            int num = Convert.ToInt32(Console.ReadLine());
            

            long binario = 0;
            int digito;

            //BINARIOS
            Console.WriteLine("NUMERO ORIGINAL: " + num);

            for (int i = num % 2, j = 0; num > 0; num = num /2, i = num % 2, j++)
            {
                digito = i % 2;
                binario = binario + digito * (long)Math.Pow(10, j);
            }

            
            Console.WriteLine("NUMERO BINARIO: " + binario);

            Console.WriteLine("");
            Console.WriteLine("HEXADECIMALES: ");
            Console.WriteLine("INGRESE UN NUMERO: ");
            num = Convert.ToInt32(Console.ReadLine());
            string hex = " ";
            while(true)
            {

                if((num % 16) != 0) { 
                
                    if((num % 16) > 9)
                    {

                        switch (num % 16)
                        {
                            case 10:
                                hex = "A" + hex;
                                break;

                            case 11:
                                hex = "B" + hex;
                                break;

                            case 12:
                                hex = "C" + hex;
                                break;

                            case 13:
                                hex = "D" + hex;
                                break;

                            case 14:
                                hex = "E" + hex;
                                break;

                            case 15:
                                hex = "F" + hex;
                                break;

                        }



                    }
                    else
                    {
                        hex = (num % 16) + hex;
                    }

                }
                else
                {
                    hex = "0" + hex;
                }
                num = num / 16;
                if(num <= 0)
                {

                    break;
                }


            }
            Console.WriteLine("NUMERO HEXADECIMAL: " + hex);

        }
    }
}
