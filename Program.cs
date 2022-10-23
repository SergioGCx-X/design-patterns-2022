// TODO Implementar un menu para poder seleccionar cual ejercicio ejecutar implementando un patron de diseño
//menu-escoja-se guarda
IConsumer consumer =  new StrategyClient();//IConsumer consumer = new Ejercicio2Cliente();

consumer.runClient();

string linea;
Console.WriteLine("Elija una de las opciones ingresando el numero correspondiente:");
Console.WriteLine("1 - Ejercicio 1");
Console.WriteLine("2 - Ejercicio 2");
Console.WriteLine("3 - Ejercicio 3");
linea = Console.ReadLine();

switch (linea){
    case "1":
        IConsumer consumer1 = new Ejercicio1Cliente();
        consumer1.runClient();
        break;
    case "2":
        IConsumer consumer2 = new Ejercicio2Cliente();
        consumer2.runClient();
        break;
    case "3":
        IConsumer consumer3 = new Ejercicio3Cliente();
        consumer3.runClient();
        break;
    case "null":
        Console.WriteLine("Ingrese un numero del 1 al 3");
    break;
}