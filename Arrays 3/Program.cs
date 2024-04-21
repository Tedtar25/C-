// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Sumar los valores de un array y mostrar el resultado
int[] array=new int[10];
int x;
int sumatoria=0;
for(int i = 0;i<array.Length;i++){
    Console.WriteLine("Escribe un numero en la posicion "+(i+1));
    x=Convert.ToInt32(Console.ReadLine());
    sumatoria+=x;
    array[i]=x;
}
Console.WriteLine("La sumatoria total es: "+sumatoria);