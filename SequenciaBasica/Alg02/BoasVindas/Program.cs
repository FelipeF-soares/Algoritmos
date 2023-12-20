using BoasVindas.services;

MensagemBoasVidas mensagem = new MensagemBoasVidas();
Console.WriteLine(mensagem.Perguntar());
mensagem.Nome = Console.ReadLine();
Console.WriteLine(mensagem.Exibir());