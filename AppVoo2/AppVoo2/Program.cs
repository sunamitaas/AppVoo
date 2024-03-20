// Sunamita 
// AppVoo

/*

TESTES:

Voo voo = new Voo(10, 001, new DateTime());
voo.poltronas[0] = true;
voo.poltronas[1] = true;

Console.WriteLine(voo.ProximoLivre());

Console.WriteLine("Digite o numero da poltrona que você quer: ");
int pol = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(voo.Verifica(pol));
voo.Ocupa(pol);
Console.WriteLine(voo.Verifica(pol));

Console.WriteLine("Numero de vagas disponiveis: ");
Console.WriteLine(voo.Vagas());

for (int i = 0; i < voo.qtdVagas; i++)
{

    Console.WriteLine(voo.poltronas[i]);

}
*/

// MENU - RESERVAR PASSAGEM

//Criar uma instância da classe Voo


Voo voo = new Voo(10, 123, new DateTime(2024, 3, 20));

bool pesquisar = true;

while (pesquisar)
{
    Console.WriteLine("Ola, faça a reserva da sua passagem por aqui");
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Verificar próxima poltrona livre");
    Console.WriteLine("2 - Verificar se uma poltrona está ocupada");
    Console.WriteLine("3 - Ocupar uma poltrona");
    Console.WriteLine("4 - Verificar quantidade de vagas");
    Console.WriteLine("5 - Sair");

    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            int proximaPoltrona = voo.ProximoLivre();

            if (proximaPoltrona != -1)                   // -1 para encaixar no vetor
                Console.WriteLine($"{proximaPoltrona}");
            else
                Console.WriteLine("Não há poltronas livres.");
        break;

        case 2:

            Console.WriteLine("Digite o número da poltrona:");
            int numeroPoltrona = int.Parse(Console.ReadLine());

            if (voo.Verifica(numeroPoltrona))
                Console.WriteLine("A poltrona não está livre.");
            else
                Console.WriteLine("A poltrona está livre.");
        break;

        case 3:
            Console.WriteLine("Digite o número da poltrona:");
            int numPoltrona = int.Parse(Console.ReadLine());

            if (voo.Ocupa(numPoltrona))
                Console.WriteLine("Poltrona ocupada com sucesso.");
            else
                Console.WriteLine("A Poltrona não foi ocupada");
        break;

        case 4:
            int vagasLivres = voo.Vagas();
            Console.WriteLine($"Número de vagas livres: {vagasLivres}");
            break;

        case 5:
            pesquisar = false;
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    Console.WriteLine(); // Linha em branco
}


