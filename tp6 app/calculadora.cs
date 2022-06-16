public class calculadora{
    public double resultado;
    public double valor_ingreso;
    
    public calculadora(double primer_valor)
    {
        this.resultado = primer_valor;
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

    public double Limpiar()
    {
        return resultado = 0;
    }
}