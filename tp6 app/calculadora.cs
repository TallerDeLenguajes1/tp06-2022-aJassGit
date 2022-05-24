// See https://aka.ms/new-console-template for more information
public class calculadora{
    private double resultado;

    public calculadora(double valor)
    {
        resultado = valor;
    }

    public double Resultado { get => resultado; set => resultado = value; }

    public void Sumar(double valor_sumar)
    {
        resultado = resultado + valor_sumar;
    }

    public void Restar(double valor_restar)
    {
        resultado = resultado - valor_restar;
    }

    public void Multiplicar(double valor_multiplicar)
    {
        resultado = resultado * valor_multiplicar;
    }

    public void Dividir(double valor_dividir)
    {
        if(valor_dividir != 0){
            resultado = resultado * valor_dividir;
        }
    }

    public void Limpiar()
    {
        resultado = 0;
    }
}