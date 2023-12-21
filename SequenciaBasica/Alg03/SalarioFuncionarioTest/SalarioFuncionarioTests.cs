/*
    Crie um programa que leia o nome e o salário de um funcionário, mostrando no final uma mensagem. 
    Ex: Nome do Funcionário: Maria do Carmo Salário: 1850,45 O funcionário Maria do Carmo tem um salário de R$1.850,45 em Junho.
*/
using System.Runtime.InteropServices;
using SalarioFuncionario.service;
using SalarioFuncionario.view;

namespace SalarioFuncionarioTest;

public class SalarioFuncionarioTests
{
    private Pessoa _pessoa;
    private RetornaMes _mes;
    private MensagensExibicao _mensagen;
    public SalarioFuncionarioTests()
    {
        _pessoa = new Pessoa();
        _mes = new RetornaMes();
        _mensagen = new MensagensExibicao();
    }
    [Fact]
    public void RetornaONomeEOSalarioDoMes()
    {
        //Arrange
        _pessoa.Nome = "Maria do Carmo";
        _pessoa.Salario = 1850.45M;
        string mes = _mes.ToString();
        //Act
        string resposta = _mensagen.ExibiNomeSalario(_pessoa);
        //Assert
        Assert.Equal($"O funcionário Maria do Carmo tem um salário de R$ 1.850,45 em {mes}.",resposta);
    }
}