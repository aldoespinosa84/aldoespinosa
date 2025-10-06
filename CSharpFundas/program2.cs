using System;
using CSharpFundas;

namespace CSharpFundas
{
    class program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I am in the second program");

            // Crear instancia de la clase Program
            Program p = new Program();
            p.getData();  // Asegúrate que el método en Program se llame GetData()
        }
    }
}