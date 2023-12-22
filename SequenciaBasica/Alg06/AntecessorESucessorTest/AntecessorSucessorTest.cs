/*
    Faça um programa que leia um número inteiro e mostre o seu antecessor e seu sucessor. 
    Ex: Digite um número: 9 O antecessor de 9 é 8 O sucessor de 9 é 10
*/
using AntecessorESucessor.Service;

namespace AntecessorESucessorTest;

public class AntecessorESucessorTest
{
    private AntecessorSucessor _numero;
    public AntecessorESucessorTest()
    {
        _numero = new AntecessorSucessor();
    }
    [Fact]
    public void TestaOAntecessoESucessorDoNumero9()
    {
        //Arrange
        string resposta;
        _numero.Numero = 9;
        //Act
        resposta = _numero.ToString();
        //Assert
        Assert.Equal("O antecessor de 9 é 8 O sucessor de 9 é 10",resposta);
    }
}