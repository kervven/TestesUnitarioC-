namespace Calculadora.dir.Services;

public class CalculadoraImp
{
    public int Somar(int num1, int num2)
    {
        return num1 + num2;
    }

    public double Dividir(int num1, int num2)
    {
        return num1 / num2;
    }

    public int Subtrair(int num1, int num2)
    {
        return num1 - num2;
    }

    public int Multiplicar(int num1, int num2)
    {
        return num1 * num2;
    }

    public bool EhPar(int num)
    {
        return num % 2 == 0;
    }
}