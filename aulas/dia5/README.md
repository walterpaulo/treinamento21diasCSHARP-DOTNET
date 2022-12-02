## Aula 5 - [Desafio 21 dias em CSHARP/DOTNET](../../README.md)


### Para
Uso do laça "para" na repetição

```c#
static void Main(string[] args)
{
  foreach(var param in args)
  {
    Console.WriteLine("Olá - " + param)
  }

}

//Digite no terminal
//$ dotnet run parametros params2 'parametro 3'
// Olá - parametros
// Olá - params2
// Olá - parametro 3
```

#### Exercicio
[Resolução](../exercicios/exercicio0501.cs)
```
PayBank é uma startup do sitema financeiro
eles precisam do um programa que cadastre um cliente
com o soldo do investimento do mesmo.

crie um programa que solicite o investidor e o saldo que deseja colocar
após colocar o dinheiro do cliente (saldo), desconte um tax de 0.05%.

após esta operação, pergunte ao cliente  e o mesmo deseja sacar o dinheiro
se o cliente desejar sacar, coloque para o mesmo, digitar o valor do sque

se o saque foi maior do que o valor depositado em conta - o desconto da taxa mostrar mensagem na tela, falanço que o valor de resgate é maior do que o saldo em conta.
```