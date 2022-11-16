using Back_End_ER02.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "William persy";
novaPF.cpf = "12345678910";
novaPF.rendimento = 6600.5f;

// >>> Pessoa Física <<<
float impostaPagar = novaPF.CalcularImposto (novaPF.rendimento);
Console.WriteLine($"{impostaPagar:0.00}");
Console.WriteLine(impostaPagar.ToString("C"));

// >>> Pessoa Juridica <<<
PessoaJuridica novaPj = new PessoaJuridica();
Console.WriteLine(novaPj.CalcularImposto(6600.5f));