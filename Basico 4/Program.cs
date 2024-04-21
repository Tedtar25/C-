// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Pedir 2 numeros por teclado y decir cual es el mayor

Console.WriteLine("Introduce un primer numero");
String x=Console.ReadLine();
Console.WriteLine("Introduce un segundo numero");
String y=Console.ReadLine();

int a=Convert.ToInt32(x);
int b=Convert.ToInt32(y);

if(a>b){
    Console.WriteLine("El numero "+a+" es mayor que "+b);
}else{
    Console.WriteLine("El numero "+b+" es mayor que "+a);
}

//Tambien puedes usar el siguiente comando:

//Console.WriteLine("Introduce un primer numero");
//int x=Convert.ToInt32(Console.ReadLine());
