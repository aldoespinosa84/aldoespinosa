using System;
using System.Collections;
using System.Collections.Generic;

//Un ArrayList en C# es una colección dinámica que puede almacenar elementos de diferentes
//tipos (aunque normalmente se usan del mismo tipo) y puede cambiar de tamaño automáticamente
//—a diferencia de un array normal, que tiene tamaño fijo.

//declaras arraylist y el nombre de la colleccion que se va llamar lista
ArrayList lista = new ArrayList();

//aqui agregas a la coleccion a 4 elementos en memoria
lista.Add("hello");
lista.Add("bye");
lista.Add("Aldo");
lista.Add("apple");

Console.WriteLine("Posicion 1 se encontro esta informacion: " + lista[1]);

//El foreach en C# es un bucle especial que sirve para recorrer todos los elementos de
//una colección (como un array, un List, o un ArrayList) de forma sencilla y segura,
//sin tener que usar índices.

// tipo es el tipo que contiene la coleccion int string etc, este caso son de tipo string
//variable nombre temporal por cada elemento que se recorrer que en este caso se le puso item
//coleccion el conjunto de datos arrar o lista en esta caso a que es un arraylist
//lista.sort(); Ordenar de menor a mayor ascendente y reverse de mayor a menor descendente
lista.Sort();
lista.Reverse();

foreach (String item in lista)
{
        Console.WriteLine("Estos son los items encontrados en el arreglo: " + item);
}

//Condicion si el elemento llamado aldo se encuentra en el arreglo y te va arrojar un true o false
Console.WriteLine(lista.Contains("Aldo"));


