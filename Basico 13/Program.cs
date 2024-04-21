// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Muestra una frasse con todos los caracteres en mayusculas
Console.WriteLine("Escribe una frase.");
String frase=Console.ReadLine();

String fraseMayusculas="";

//Forma 1: Esta es la manual
for(int i=0;i<frase.Length;i++){
    //Se utiliza la tabla de ASIIC para ver mayusculas y minusculas
    //El 97 es la minusculas y la mayusculas son el 65, hay 32 pocisiones diferentes
    if(frase[i]>='a' && frase[i]<= 'z'){
       fraseMayusculas+=(char)(frase[i]-32); 
    }else{
        fraseMayusculas+=(frase[i]);
    }
}
Console.WriteLine(fraseMayusculas);

//Forma 2: Esta es con comandos
String cadenaMayuscula=frase.ToUpper();
Console.WriteLine(cadenaMayuscula);