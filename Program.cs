﻿using System;

namespace ejercico2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite el ingreso de 10 números y 
            //que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            int  a, mayor = 0;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Escriba un nro: ");
                a = int.Parse(Console.ReadLine());
                    if (x == 0)
                    mayor = a;
                    else if(a > mayor)
                    mayor = a;
            }
            Console.WriteLine("El mayor es: " + mayor);

                    


        }
    }
}
