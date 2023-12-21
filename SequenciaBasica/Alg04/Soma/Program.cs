using System.ComponentModel;
using Soma.Service;
using Soma.View;

Mensagem mensagem = new Mensagem();
CalcSoma calc = new CalcSoma();
Console.WriteLine(mensagem.SolicitaPrimeiroValor());
calc.Numero1 = Int32.Parse(Console.ReadLine());
Console.WriteLine(mensagem.SolicitaSegundoValor());
calc.Numero2 = Int32.Parse(Console.ReadLine());
Console.WriteLine(calc.ToString());

