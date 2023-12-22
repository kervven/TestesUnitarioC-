using Calculadora.dir.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }
    
    [Fact]
    public void DeveSomar5Com10ERetronar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;
        
        //Act
        int resultado = _calc.Somar(num1, num2);

        //Assert
        Assert.Equal(15, resultado);
    }
    
    [Fact]
    public void DeveDividir10Com2ERetronar5()
    {
        //Arrange
        int num1 = 10;
        int num2 = 2;
        
        //Act
        double resultado = _calc.Dividir(num1, num2);

        //Assert
        Assert.Equal(5, resultado);
    }
    
    [Fact]
    public void DeveSubtrair10Com10ERetronar0()
    {
        //Arrange
        int num1 = 10;
        int num2 = 10;
        
        //Act
        int resultado = _calc.Subtrair(num1, num2);

        //Assert
        Assert.Equal(0, resultado);
    }
    
    [Fact]
    public void DeveMultiplicar5Com10ERetronar50()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;
        
        //Act
        int resultado = _calc.Multiplicar(num1, num2);

        //Assert
        Assert.Equal(50, resultado);
    }
    
    [Fact]
    public void DeveVerificar4EhParERetronarVerdadeiro()
    {
        //Arrange
        int num = 4;
        
        //Act
        bool resultado = _calc.EhPar(num);

        //Assert
        Assert.True(resultado);
    }

    // [Theory]
    // [InlineData(2)]
    // [InlineData(6)]
    // [InlineData(8)]
    // [InlineData(10)]
    // [InlineData(12)]
    // public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int num)
    // {
    //     //Act
    //     bool resultado = _calc.EhPar(num);
    //
    //     //Assert
    //     Assert.True(resultado);
    // }
    
    [Theory]
    [InlineData(new int[] {2, 6})]
    [InlineData(new int[] {8, 18, 36})]
    public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
    {
        //Act / Assert
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));

    }
    
    
}