using ExemplosAula;


Conta conta1 = new Conta(123456,1234,"Luis");

Conta conta2 = new Conta(42141, 19999, "Guilherme") ;

Console.WriteLine($"Conta 1 {conta1.Numero} e Saldo: {conta1.Saldo}, Titular: {conta1.Nome}");

//Imprime o Número e o Saldo da Conta 2

Console.WriteLine($"Conta 2 {conta2.Numero} e Conta 2 {conta2.Saldo}");