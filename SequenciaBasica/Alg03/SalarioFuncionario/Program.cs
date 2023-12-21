using SalarioFuncionario.service;
using SalarioFuncionario.view;

MensagensExibicao mensagem = new MensagensExibicao();
Pessoa pessoa = new Pessoa();
Console.WriteLine(mensagem.SolicitaNome());
pessoa.Nome = Console.ReadLine();
Console.WriteLine(mensagem.SolicitaSalario());
pessoa.Salario = decimal.Parse(Console.ReadLine());
Console.WriteLine(mensagem.ExibiNomeSalario(pessoa));