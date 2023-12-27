/*
Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a sua terça parte. 
Ex: Digite um número: 3.5 O dobro de 3.5 é 7.0 A terça parte de 3.5 é 1.16666
*/
using System.ComponentModel;
using NumeroReal.service;
using NumeroReal.views;

namespace NumeroRealTest;

public class NumeroRealTest
{
    private DobroDeUmNumero? _dobro;
    private TercaParte? _terca;

    private View _view;


    public NumeroRealTest()
    {
        _view = new View();
    }

    [Fact]
    public void TestaODobroEATercaParteDoNumero()
    {
        //Arrange
        double numero = 3.5;
        _dobro = new DobroDeUmNumero(numero);
        _terca = new TercaParte(numero);
        //Action
        string resultado = _view.Resposta(numero,_dobro.Resultado(),_terca.Resultado());
        //Assert
        Assert.Equal("O dobro de 3,5 é 7,0 A terça parte de 3,5 é 1,16666", resultado);
    }
}