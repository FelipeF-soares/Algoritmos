/*
Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boas vindas para ela: 
Ex: Qual é o seu nome? João da Silva Olá João da Silva, é um prazer te conhecer!
*/
using BoasVindas.services;

namespace BoasVindasTest;

public class BoasVindasTeste
{
    private MensagemBoasVidas _mensagem;

    public BoasVindasTeste()
    {   
        _mensagem = new MensagemBoasVidas();
    }
    [Fact]
    public void ExibirMensagemDeBoasVindas()
    {
        //Arrange
        _mensagem.Nome = "João da Silva";
        string resposta;
        //Act
        resposta = _mensagem.Exibir();
        //Asset
        Assert.Equal("Olá João da Silva, é um prazer te conhecer!",resposta);
    }
}