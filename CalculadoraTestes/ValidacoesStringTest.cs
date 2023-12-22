using Calculadora.dir.Services;

namespace CalculadoraTestes;

public class ValidacoesStringTest
{
    private ValidacoesString _validacoes;

    public ValidacoesStringTest()
    {
        _validacoes = new ValidacoesString();
    }

    [Fact]
    public void DeveConter5CaracteresEmKervenERetornar6()
    {
        //Arrange
        string texto = "Kerven";
        
        //Act
        int resultado = _validacoes.ContarCaracteres(texto);
        
        //Assert
        Assert.Equal(6, resultado);
    }
}