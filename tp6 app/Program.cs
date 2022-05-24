// See https://aka.ms/new-console-template for more information
calculadora calcular = new calculadora(0);


int opcion = 0;
int valor = 0;
do
{
    Console.WriteLine("Opciones a ingresar: ");
    Console.WriteLine("Opcion 1: Sumar");
    Console.WriteLine("Opcion 2: Restar");
    Console.WriteLine("Opcion 3: Multiplicar");
    Console.WriteLine("Opcion 4: Dividir");
    Console.WriteLine("Opcion 5: Limpiar");
    
    String pedir_opcion = Console.ReadLine();    
    opcion = Convert.ToInt32(pedir_opcion);

    if(opcion == 1){
        Console.WriteLine("Ingrese un numero");
        String value = Console.ReadLine();
        valor = Convert.ToInt32(value);
        calcular.Sumar(valor);
    } else if(opcion == 2){
        Console.WriteLine("Ingrese un numero");
        String value = Console.ReadLine();
        valor = Convert.ToInt32(value);
        calcular.Restar(valor);
    } else if(opcion == 3){
        Console.WriteLine("Ingrese un numero");
        String value = Console.ReadLine();
        valor = Convert.ToInt32(value);
        calcular.Multiplicar(valor);
    } else if(opcion == 4){
        Console.WriteLine("Ingrese un numero");
        String value = Console.ReadLine();
        valor = Convert.ToInt32(value);
        calcular.Dividir(valor);
    } else if(opcion == 5){
        calcular.Limpiar();
        Console.WriteLine("Se elimino el resultado anterior")
    } else{
        Console.WriteLine("Se ingreso un numero incorrecto");
    }

} while (opcion >= 6 || opcion == 0);
Console.WriteLine("El resultado es " + valor);