/*
    Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório entre eles. 
    Ex: Digite um valor: 8 Digite outro valor: 5 A soma entre 8 e 5 é igual a 13.
*/
using Soma.Service;

namespace SomaTest;

public class SomaTest
{
    private CalcSoma _calcSoma;

    public SomaTest()
    {
        _calcSoma = new CalcSoma();
    }
    [Fact]
    public void RealizaASomaEntre8E5ComResultado13()
    {
        //Arrange
        _calcSoma.Numero1 = 8;
        _calcSoma.Numero2 = 5;
        string resposta;
        //Act
        resposta = _calcSoma.ToString();
        //Assert
        Assert.Equal("A soma entre 8 e 5 é igual a 13.",resposta);
    }
}