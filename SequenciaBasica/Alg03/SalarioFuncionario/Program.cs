using SalarioFuncionario.service;
using SalarioFuncionario.view;

MensagensExibicao mensagem = new MensagensExibicao();
Pessoa pessoa = new Pessoa();
System.Console.WriteLine(mensagem.SolicitaNome());
pessoa.Nome = Console.ReadLine();
System.Console.WriteLine(mensagem.SolicitaSalario());
pessoa.Salario = decimal.Parse(Console.ReadLine());
System.Console.WriteLine(mensagem.ExibiNomeSalario(pessoa));