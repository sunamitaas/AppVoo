

// tire a interação do usuario da sua logica
// aqui é a logica

public class Voo
{
    //public DateOnly dataVoo;
    //public TimeOnly timeVoo;

    private DateTime dataVoo;
    private int numVoo;
    public int qtdVagas;
    public bool[] poltronas;          // usar vetor ou lista 


    //CONSTRUTOR
    // O que é o metodo Construtor? toda vez que eu inicio uma instancia ele ja executa.
    //this ele referencia a variavel fora do metodo, isso é feito para diferenciar a variavel de entrada do metodo da variavel da classe la emcima. 

    public int getnumVoo()
    {
        return numVoo;
    }

    public DateTime getdatavoo()
    {
        return dataVoo;
    }

    public Voo (int qtdVagas, int numVoo, DateTime dataVoo)
    {

        this.dataVoo = dataVoo;
        this.numVoo = numVoo;
        poltronas = new bool[qtdVagas];
        this.qtdVagas = qtdVagas;

    }


    // Poltrona Livre

    public int ProximoLivre()
    {
        for (int i = 0; i < poltronas.Length; i++)   
        {
            if (poltronas[i] == false)
            {
                int poltronaLivre = i + 1;
                Console.WriteLine("A Proxima poltrona livre é: ");
                return poltronaLivre;                                                    // +1 é para add o indice
            }

        }

        return -1 ;
    }

    // verifica se a poltrona esta ocupada

    public bool Verifica(int numPoltrona)
    {

        if (poltronas[numPoltrona - 1] == true)
        {
            Console.WriteLine("A Poltrona não esta livre");
            return true;

        }
        else
        {
            return false;
        }

    }

    // Método Ocupa
    /*
    public bool Ocupa (int numPoltrona)
    {
        if (this.Verifica(numPoltrona) == true)
        {
            poltronas[numPoltrona - 1] = true;
            Console.WriteLine("A Poltrona esta ocupada");
            return true;
        }
        else
        {
            Console.WriteLine("A Poltrona não esta ocupada");
            return false;
        }
    }
    */

    public bool Ocupa(int numPoltrona)
    {
        if (this.Verifica(numPoltrona))
        {
            // Console.WriteLine("A Poltrona não esta Livre");
            return false;
            
        }
        else
        {
            poltronas[numPoltrona - 1] = true;
            // Console.WriteLine("A Poltrona foi ocupada com Sucesso");
            return true;
        }
    }

    //vagas 

    public int Vagas ()
    {
        int vagasLivres = 0;
        for(int i = 0;i < poltronas.Length; i++)
        {

            if (poltronas[i] == false)
            {
                vagasLivres += 1;
            }
            
        }
        return vagasLivres;
    }

}
