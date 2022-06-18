ContaCorrente ContaCaio = new ContaCorrente();

ContaCaio.saldo = 1000;

Console.WriteLine(ContaCaio.saldo);

ContaCaio.Sacar(150);

Console.WriteLine(ContaCaio.saldo);

ContaCaio.Depositar(1000);

Console.WriteLine(ContaCaio.saldo);


ContaCorrente ContaGabriela = new ContaCorrente();
ContaGabriela.titular = "Gabriela";

ContaCaio.transferir(200, ContaGabriela);

Console.WriteLine("Saldo da Conta do Caio :" + ContaCaio.saldo);
Console.WriteLine("Saldo da Conta da Gabriela: " + ContaGabriela.saldo);

Console.ReadLine();