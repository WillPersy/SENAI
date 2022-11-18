using back_aula.Classes;


PessoaFisica novaPF = new PessoaFisica();
Endereco novoEndPf = new Endereco();

novaPF.nome = "William Persy";
novaPF.cpf = "12345678910";
novaPF.rendimento = 6600.5f;
novaPF.dataNasc = new DateTime(2000, 10, 01);

novoEndPf.logradouro = "Rua Deocleciano de Oliveira";
novoEndPf.numero = 240;
novoEndPf.complemento = "Casa";
novoEndPf.endComercial = true;

novaPF.endereco = novoEndPf;

Console.WriteLine(@$"
Nome: {novaPF.nome}, 
Rendimento: {novaPF.rendimento} 
Cpf: {novaPF.cpf} 
Logradouro: {novaPF.endereco.logradouro}
Numero: {novaPF.endereco.numero}
");