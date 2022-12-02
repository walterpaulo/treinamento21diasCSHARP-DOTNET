/*
Data: 01/12/2022

PayBank é uma startup do sitema financeiro
eles precisam do um programa que cadastre um cliente
com o soldo do investimento do mesmo.

crie um programa que solicite o investidor e o saldo que deseja colocar
após colocar o dinheiro do cliente (saldo), desconte um tax de 0.05%.

após esta operação, pergunte ao cliente  e o mesmo deseja sacar o dinheiro
se o cliente desejar sacar, coloque para o mesmo, digitar o valor do sque

se o saque foi maior do que o valor depositado em conta - o desconto da taxa mostrar 
mensagem na tela, falanço que o valor de resgate é maior do que o saldo em conta.

*/

Console.WriteLine("======[ PayBank ]======");
  Console.WriteLine("Digite o nome do investidor: ");
  var nomeInvestidor = Console.ReadLine();

  Console.WriteLine($"{nomeInvestidor} informe o valor a ser investido: ");
  double valorInvestido = 0;
  double.TryParse(Console.ReadLine(), out valorInvestido);

  double taxa = valorInvestido * 0.05 / 100;

  valorInvestido = valorInvestido - taxa;

  Console.WriteLine($"{nomeInvestidor} você deseja sacar o dinheiro ? Digite 1 para Sim - 0 para Não");
  int sacarDinheiro = 0; 
  int.TryParse(Console.ReadLine(), out sacarDinheiro);
  if (Convert.ToBoolean(sacarDinheiro))
  {
    Console.WriteLine("Informe o valor do saque: ");
    double valorSaque = 0;
    double.TryParse(Console.ReadLine(), out valorSaque);

    if(valorSaque > valorInvestido)
    {
      Console.WriteLine($"O valor do resgate é maior que o saldo em conta: {valorInvestido}");
    }
    else
    {
      Console.WriteLine("Saque realizado com sucesso.");
      Console.WriteLine($"Saldo atualizado: {valorInvestido - valorSaque}");
    }
  }
