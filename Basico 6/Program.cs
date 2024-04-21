// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Pedir al usuario el precio de un producto y la forma de pagar (efectivo o tarjeta).
//Si es con tarjeta pedir el numero de cuenta.
Console.WriteLine("Escriba el precio del producto");
int precio=Convert.ToInt32(Console.ReadLine());

if(precio>0){
    Console.WriteLine("Selecciona tu metodo de pago.");
    Console.WriteLine("1=Tarjeta");
    Console.WriteLine("2=Efectivo");
    int metodoPago=Convert.ToInt32(Console.ReadLine());
    switch(metodoPago){
        case 1:
            Console.WriteLine("Escriba su numero de cuenta.");
            Console.ReadLine();
            Console.WriteLine("Gracias por su pago.");
                break;
        case 2:
            Console.WriteLine("Gracias por su pago.");
                break;
        default:
            Console.WriteLine("Selecciona un metodo de pago valido.");
                break;
    }
}else{
    Console.WriteLine("El precio no es valido.");
}