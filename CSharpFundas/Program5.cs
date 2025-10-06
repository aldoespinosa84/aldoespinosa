using System;

//Un array en C# (también llamado arreglo) es una colección de elementos del mismo tipo almacenados en una sola variable.
//Sirve para guardar varios valores relacionados sin tener que declarar muchas variables por separado.

//una manera asi
String[] a = { "casa", "perro", "lapiz", "taza" };
int[] b = { 1, 2, 3, 4, 5 };

//se barre el arreglo usando un for, i es donde inicia el arrelgro, i < es hasta el numero maximo del arreglo, i++ 
//que va suamando, se usa una condicion if para encontrar la palabra perro en la posicion 1, si la encuentra manda el msj
//si no la encuentra tambien manda msj que no la encontro, el break detiene el arreglo para que no continue
for (int i = 0; i < a.Length; i++)
{
    //si en la posicion del arreglo numero 1 se encuentra perro 
    if (a[1] == "perro")
    {
        Console.WriteLine("se encontro el elemento");
        break;//detiene el arreglo para que no continue
    }
    else //por si no lo encuentra
    {
        Console.WriteLine("nose encontro el elemento");
        break; //detiene el arreglo para que no continue
    }
    
}

//aqui otra manera de usarlo en memoria aqui pusimos que tenemos 4 espacios en la variable a1
String[] a1 = new String[4];
a1[0] = "hello";
a1[1] = "bye";

//Console.WriteLine(a[1]);


