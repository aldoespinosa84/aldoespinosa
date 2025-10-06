
using System;

namespace CSharpFundas
{
    //Herencias hereda lo del padre al hijo
    //Program es el hijo y va heredar lo del padre Program4
    //podemos accesar los metodos del padre ahora
    class Program : Program4
    {
        //Metodo es publico puede accessar cualquier clase en el codigo, tienen que estar fuera del metodo main principal
        //pones void no retorna nada, pero si pones string, int, o cualquiera se espera que retorne eso

        //En C#, un constructor es un método especial de una clase que se utiliza principalmente para inicializar objetos
        //cuando se crean. Es decir, su propósito es establecer los valores iniciales de los atributos o realizar cualquier
        //configuración necesaria antes de que el objeto se use.

        //variable global
        String name;
        String FullName;

        //Constructor inicializa un objeto llamado name
        public Program(String name) 
        { 
            //global variable - variable constructor, el atributo que se paso al constructor a travez de name se pasa
            //a la variable global name con this.name
            this.name = name;
        }

        //constructor que manda los atributos name y lastname a la variable global full name.
        public Program(string name, string lastname) 
        {
            this.FullName = name + " " + lastname;
        }


        //this. hacer referencia a la variable creada, este metodo imprime el atribituo que se mando al constructor.
        public void getName()
        {
            Console.WriteLine("My name is " + this.name);
        }
        public void getFullName()
        {
            Console.WriteLine("My Full Name is " + this.FullName);
        }
        public void getData()
        {
            Console.WriteLine("I am inside the method");

        }
        static void Main(string[] args)
        {
            //creamos un objeto para la clase getData(), cuando se execute esta linea directamente va al contrusctor
            //que creamos y executa el bloque, creamos un objeto y le estamos pasando un argumneto que es el nombre
            //a travez del constructor que creamos, aldo lo pasa al variable name que tiene el constructor
            Program p = new Program("Aldo");
            Program p1 = new Program("aldo", "Espinosa");
            
            p.getData();
            //metodo para el nombre
            p.getName();

            //metodo para el nombre completo
            p1.getFullName();

            //el metodo que esta heredando el padre al hijo en la clase program4
            p.SetData();

            Console.WriteLine("Hellow World");

            int a = 4;
            Console.WriteLine("number is: " + a);

            String name = "aldo";
            Console.WriteLine("name is: " + name);

            //mas simplificado
            Console.WriteLine($"name is: {name}");

            //solo usarlo cuando no sabemos el valor que esperamos
            //usar siempre palabras reservadas string, int, boolean, 
            //etc.
            var age = 41;
            Console.WriteLine("age" + age);

            //dynamic puedes cambiar los valores de la variable
            //sin alterar su tipo ya sea string, int, boolean, etc.
            dynamic height = 13.2;
            Console.WriteLine($"Height is {height}");

            height = "hello";
            Console.WriteLine($"Height is {height}");

            height = false;
            Console.WriteLine($"Height is {height}");
        }
    }

}
