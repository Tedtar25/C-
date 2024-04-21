// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

Console.WriteLine("Hello, World!");
//Pide una frase y recorrela caracter a caracter.

Console.WriteLine("Escribe una frase.");
String frase=Console.ReadLine();

//Como recorrer una cadena

for(int i=0;i<frase.Length;i++){
    Console.WriteLine(frase[i]);
}
