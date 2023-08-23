using ClasseConta;//esse arquivo precisa usar o outro arquivo
//função - método Main() - implícito

//para realizar a instanciação em 2 passos
//1 - declarar a variável do tipo classe
Conta objeto1;

//2- instanciar a variável
objeto1 = new Conta();
//manipular os dados do objeto
objeto1.numero = 101;
objeto1.titular = "Pressman";
objeto1.saldo = 123.99;


Conta objeto2 = new Conta(); //declarar na memória, depois instância
objeto2.numero = 102;
objeto2.titular = "Assis";
objeto2.saldo = 99;

Conta objeto3 = new Conta();
Console.WriteLine("Informe o número: ");
objeto3.numero = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Nome do titular: ");
objeto3.titular = Console.ReadLine();
System.Console.WriteLine("Informe o saldo da conta: ");
objeto3.saldo = Convert.ToDouble(Console.ReadLine());

//mostrar os dados cadastrados
objeto2.MostrarAtributos();
objeto2.Sacar(10);
objeto2.MostrarAtributos();

objeto1.MostrarAtributos();
objeto1.Depositar(1000);
objeto1.MostrarAtributos();


