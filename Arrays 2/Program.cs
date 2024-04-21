// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Array de 10 posiciones con valores pedidos
int[] array =new int[10];

for(int i=0;i<array.Length;i++){
    Console.Write("Ingrese el valor del array "+(i+1));
    Console.WriteLine("");
    int x=Convert.ToInt32(Console.ReadLine());
    array[i]=x;
}
Console.WriteLine("Mostrar datos");
for(int i=0;i<array.Length;i++){
    Console.WriteLine(array[i]);
}