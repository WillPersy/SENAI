// Váriaveis

    let convidados = 69;
    let dataHoje = new Date();
    let dataEvento = new Date("2022-07-15");
    let idade = 25;


//Sistema

console.log("Sistema de Cadastro");

    if(dataEvento >= dataHoje) {

    console.log("Data válida, cadastro permitido.");
    }
    else{

    console.log("Data inválida. O evento já passou! ");
    }

    if(idade >= 18) {

    console.log("Cadastro permitido.");
    }
    else{

        console.log("Não podemos prosseguir com seu cadastro. Você não é maior de 18 anos!");
    }

    if(convidados <= 100) {

        console.log("Cadastro concluído.");
    }
    else {

        console.log("Infelizmente não podemos prosseguir com seu cadastro. Limite de pessoas excedido.");
    }

