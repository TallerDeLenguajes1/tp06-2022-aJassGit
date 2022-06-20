Console.WriteLine("Ingrese un numero inicial:");
String initial = Console.ReadLine();
double inicial = Convert.ToDouble(initial);
calculadora calcular = new calculadora(inicial);

int opcion = 0;
double valor = 0;

do
{
    Console.WriteLine("Opciones a ingresar:");
    Console.WriteLine("Opcion 1: Sumar");
    Console.WriteLine("Opcion 2: Restar");
    Console.WriteLine("Opcion 3: Multiplicar");
    Console.WriteLine("Opcion 4: Dividir");
    Console.WriteLine("Opcion 5: Limpiar");
    Console.WriteLine("Opcion 6: Cerrar Calculadora");
    
    String pedir_opcion = Console.ReadLine();
    opcion = Convert.ToInt32(pedir_opcion);


    if(opcion == 1){
        Console.WriteLine("Ingrese otro numero");
        String value = Console.ReadLine();
        valor = Convert.ToDouble(value);
        Console.WriteLine(calcular.resultado+" + "+valor+" = "+calcular.Sumar(valor));
    } else if(opcion == 2){
        Console.WriteLine("Ingrese otro numero");
        String value = Console.ReadLine();
        valor = Convert.ToDouble(value);
        Console.WriteLine(calcular.resultado+" - "+valor+" = "+calcular.Restar(valor));
    } else if(opcion == 3){
        Console.WriteLine("Ingrese otro numero");
        String value = Console.ReadLine();
        valor = Convert.ToDouble(value);
        Console.WriteLine(calcular.resultado+" * "+valor+" = "+calcular.Multiplicar(valor));
    } else if(opcion == 4){
        Console.WriteLine("Ingrese otro numero");
        String value = Console.ReadLine();
        valor = Convert.ToDouble(value);
        Console.WriteLine(calcular.resultado+" / "+valor+" = "+calcular.Dividir(valor));
    } else if(opcion == 5){
        Console.WriteLine("Se elimino el resultado anterior");
        Console.WriteLine("Ingrese un nuevo numero inicial:");
        initial = Console.ReadLine();
        inicial = Convert.ToDouble(initial);
        calcular.Limpiar(inicial);
    } else if(opcion == 6){
        Console.WriteLine("El programa se cerrará a continuacion");
    } else {
        Console.WriteLine("Se ingreso una opcion incorrecta");
    }

} while (opcion < 6 && opcion != 0);