using Back_End_ER02.Classes;

PessoaFisica novaPF = new PessoaFisica();
novaPF.nome = "William";
novaPF.cpf = "12345678910";

Console.WriteLine("Welcome - " + novaPF.nome);
Console.WriteLine($"Welcome: {novaPF.nome} de CPF: {novaPF.cpf}");

