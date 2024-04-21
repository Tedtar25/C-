// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Pedir el nombre de la semana y decirle si es fin de semana o no.
//En caso de error, indicarlo.
Console.WriteLine("Escribe un dia de la semana.");
String diaSemana=Console.ReadLine();

//Primer metodo
//Hacerlo con switch
switch(diaSemana.ToLower()){
    case "lunes":
        Console.WriteLine("No es fin de semana.");
        break;
    case "martes":
        Console.WriteLine("No es fin de semana.");
        break;
    case "miercoles":
        Console.WriteLine("No es fin de semana.");
        break;
    case "jueves":
        Console.WriteLine("No es fin de semana.");
        break;
    case "viernes":
        Console.WriteLine("No es fin de semana.");
        break;
    case "sabado":
        Console.WriteLine("Es fin de semana.");
        break;
    case "domingo":
        Console.WriteLine("Es fin de semana.");
        break;
    default: Console.WriteLine("Escribe un dia valido.");
        break;
}

//Segundo metodo
//Hacerlo anidado
switch(diaSemana.ToLower()){
    case "lunes":
    case "martes":
    case "miercoles":
    case "jueves":
    case "viernes":
        Console.WriteLine("No es fin de semana.");
        break;
    case "sabado":
    case "domingo":
        Console.WriteLine("Es fin de semana.");
        break;
    default: Console.WriteLine("Escribe un dia valido.");
        break;
}