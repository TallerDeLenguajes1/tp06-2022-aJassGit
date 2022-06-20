public class calculadora{
    public double resultado;
    private double primer_valor;
    
    public calculadora(double primer_valor)
    {
        resultado = primer_valor;
    }

    public double Sumar(double valor_ingreso)
    {
        return resultado += valor_ingreso;
    }

    public double Restar(double valor_ingreso)
    {
        return resultado -= valor_ingreso;
    }

    public double Multiplicar(double valor_ingreso)
    {
        return resultado *= valor_ingreso;
    }

    public double Dividir(double valor_ingreso)
    {
        if(valor_ingreso != 0){
            return resultado /= valor_ingreso;
        } else {
            Console.WriteLine("Syntax Error: no existe division por cero");
            return 0;
        }
    }

    public double Limpiar(double primer_valor)
    {
        return resultado = primer_valor;
    }
}