using back_aula.Classes;

List<PessoaFisica> listaPf = new List<PessoaFisica>();

Console.Clear();
Console.WriteLine(@$"
=============================================
|    Bem vindo ao sistema de cadastro de    |
|        Pessoas Físicas e Juridícas        |
=============================================
");


Utils.BarraCarregamento("Iniciando", 100, 40);


string? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"
=============================================
|        Escolha uma das opções abaixo      |
|-------------------------------------------|
|           1 - Pessoa Física               |
|           2 - Pessoa Juridíca             |
|                                           |
|           0 - Sair                        |
=============================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
=============================================
|        Escolha uma das opções abaixo      |
|-------------------------------------------|
|           1 - Cadastrar Pessoa Física     |
|           2 - Listar Pessoa Física        |
|                                           |
|           0 - Voltar ao menu anterior     |
=============================================
");
                opcaoPf = Console.ReadLine();
                PessoaFisica metodosPf = new PessoaFisica();

                switch (opcaoPf)
                {
                    case "1":
                        Console.Clear();

                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa fisica, tecle Enter ao final");
                        novaPf.Nome = Console.ReadLine();

                        using (StreamWriter sw = new StreamWriter($"{novaPf.Nome}.txt"))
                        {
                            sw.WriteLine(novaPf.Nome);
                        }



                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Cadastro gravado");
                        Console.ResetColor();
                        Thread.Sleep(2000);



                        break;

                    case "2":


                        using (StreamReader sr = new StreamReader("Adriano.txt"))
                        {
                            string linha;

                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(linha);
                            }
                            Console.WriteLine($"Tecle Enter para continuar");
                            Console.ReadLine();

                        }
                        break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Voltando ao menu anterior");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;
                }


            } while (opcaoPf != "0");




            break;

        case "2":
            PessoaJuridica novaPj = new PessoaJuridica();
            PessoaJuridica metodosPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

            novaPj.Nome = "Nome Pj2";
            novaPj.RazaoSocial = "Razão Social Pj2";
            novaPj.Cnpj = "00000000000122";
            novaPj.Rendimento = 10000.5f;

            novoEndPj.logradouro = "Rua Quinta da Conraria";
            novoEndPj.numero = 319;
            novoEndPj.complemento = "Apê";
            novoEndPj.endComercial = true;

            novaPj.Endereco = novoEndPj;

            metodosPj.Inserir(novaPj);



            List<PessoaJuridica> listaExibicaoPJ = metodosPj.LerArquivo();

            foreach (PessoaJuridica cadaItem in listaExibicaoPJ)
            {
                Console.Clear();
                Console.WriteLine(@$"
Nome: {cadaItem.Nome}
Razão Social: {cadaItem.RazaoSocial}
// CNPJ: {cadaItem.Cnpj}
");

                Console.WriteLine($"Aperte ENTER para continuar");
                Console.ReadLine();
            }




            break;

        case "0":

            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar nosso sistema!");
            Thread.Sleep(3000);

            Utils.BarraCarregamento("Finalizando", 500, 6);

            break;

        default:
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção Inválida, por favor digite uma opção válida");
            Console.ResetColor();
            Thread.Sleep(3000);
            break;
    }

} while (opcao != "0");

