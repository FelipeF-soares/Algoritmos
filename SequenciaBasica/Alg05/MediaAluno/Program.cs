using MediaAluno.service;
using MediaAluno.View;

Mensagem mensagem = new Mensagem();
CalculadoraDeMedia media = new CalculadoraDeMedia();

Console.WriteLine(mensagem.Nota1());
media.Nota1 = decimal.Parse(Console.ReadLine());

Console.WriteLine(mensagem.Nota2());
media.Nota2 = decimal.Parse(Console.ReadLine());

Console.WriteLine(media.ToString());

