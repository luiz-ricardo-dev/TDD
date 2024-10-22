namespace CalculadoraTest;

using Calculadora;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "22/10/2024";
        Calculadora calc = new Calculadora("22/10/2024");

        return calc;
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.Somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(5, 4, 1)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.Subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

     [Theory]
    [InlineData(2, 1, 2)]
    [InlineData(5, 4, 20)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.Multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(4, 2, 2)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.Dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestDivisaoPorZero()
    {
        // Given
        Calculadora calc = construirClasse();
    
        // When

        // Then
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(3,0));
    }

    [Fact]
    public void TestHistorico()
    {
        // Given
         Calculadora calc = construirClasse();
        // When
        calc.Somar(1, 2);
        calc.Somar(3, 5);
        calc.Somar(2, 5);
        calc.Somar(6, 7);

        var lista = calc.Historico();
    
        // Then
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count());
    }
}