using NumeroReal.service;
using NumeroReal.views;

double numero,dobro,terca;

View view = new View();

System.Console.WriteLine(view.SolicitaUmNumero());
numero = double.Parse(Console.ReadLine());

DobroDeUmNumero dobroDeUmNumero = new DobroDeUmNumero(numero);
TercaParte tercaParte = new TercaParte(numero);

dobro = dobroDeUmNumero.Resultado();
terca = tercaParte.Resultado();

System.Console.WriteLine(view.Resposta(numero,dobro,terca));
