// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

Console.WriteLine("Hello, World!");
//Pide una frase y muestrala sin espacios.

Console.WriteLine("Escribe una frase.");
String frase=Console.ReadLine();

String fraseSinEspacio="";

//Mostrar cadena sin espacio
//Forma 1: Esta es un poco mas manual

for(int i=0;i<frase.Length;i++){
    //Aqui dice, si no eres un espacio entras pa adentro y asi suma las cadenas
    if(frase[i]!=' '){
       fraseSinEspacio+=frase[i]; 
    }
}
Console.WriteLine(fraseSinEspacio);

//Forma 2: Remplaza los espacios por un sin espacio
String cadenaSinEspacio=frase.Replace(" ","");
Console.WriteLine(cadenaSinEspacio);