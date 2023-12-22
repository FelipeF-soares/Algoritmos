/*
    Faça um programa que leia as duas notas de um aluno em uma matéria e mostre na tela a sua média na disciplina. 
    Ex: Nota 1: 4,5 Nota 2: 8,5 A média entre 4,5 e 8,5 é igual a 6,5
*/

using MediaAluno.service;

namespace MediaAlunoTest;

public class MediaAlunoTest
{
    private CalculadoraDeMedia _media;

    public MediaAlunoTest()
    {
        _media = new CalculadoraDeMedia();
    }
    [Fact]
    public void CalculaAMediaDeDuasNotas()
    {
        //Arrange
        string mensagem;
        _media.Nota1 = 4.5M;
        _media.Nota2 = 8.5M;
        //Action
        mensagem = _media.ToString();
        //Assert
        Assert.Equal("A média entre 4,5 e 8,5 é igual a 6,5",mensagem);

    }
}