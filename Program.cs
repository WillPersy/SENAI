using back_aula.Classes;

PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "Nome - PJ";
novaPj.razaoSocial = "Razão Social - PJ";
novaPj.cnpj = "00.000.000/0001-03";

novoEndPj.logradouro = "Rua Deocleciano de Oliveira ";
novoEndPj.numero = 1251;

novaPj.endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
");