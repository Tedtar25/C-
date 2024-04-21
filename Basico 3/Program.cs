// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Pedir por consola tu nombre y edad.

Console.WriteLine("Introduce tu nombre");
String nombre = Console.ReadLine();
Console.WriteLine("Introduce tu edad");
String texto = Console.ReadLine();

int edad=Convert.ToInt32(texto);

Console.WriteLine("Te llamas "+nombre+" y tienes "+edad+" anios");

//Read Line le pases lo que le pases es un String a fuerza
//Variables no se pueden llamar iguales aunque sean distinto tipos
//Convert lo que hace es convertir un valor de un dato a otro