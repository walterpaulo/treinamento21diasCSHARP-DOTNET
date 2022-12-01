/*
Data: 01/12/2022

Temos a missão de construir um pequeno sistema onde

1 - iremos capturar a quantidade de litros de um posto de combustível
2 - Capture também o R$ valor do litro

Quando chegar o cliente, pergunta do nome do mesmo e o R$ valor que o cliente
deseja colocar de combustível

Baseado no valor que ele colocou de combustível você irá tirar a quantidade de litros do estoque

No finial do programa, mostrar para o cliente, a quantidade de litros que le colocou em seu veículo
e mostrar quantos litros sobrou no posto

OBs: Não precisamos trabalhar com condicionais, iremos utilizar, somente o que aprendemos até agora,
(uso de variáveis, leitura e escrita na tela)

*/

Console.WriteLine("Bem vindo ao Posto");

Console.WriteLine("Digite a quantidade do posto de combustível:");
double quatidadeLitroPosto = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor por litro:");
double valorLitro = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome do cliente:");
var nomeDoCliente = Console.ReadLine();

Console.WriteLine("Digite o valor em dinheiro:");
double valorAbastacer = double.Parse(Console.ReadLine());

var litroCliente = valorAbastacer / valorLitro;

var restantePosto = quatidadeLitroPosto - litroCliente;

Console.WriteLine($"O cliente abasteceu: {litroCliente}");
Console.WriteLine($"Sobrou no posto: {restantePosto}");
