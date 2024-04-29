int jogador = 0, cartelas = 0, npossiveis = 0, nsorteado = 0, nbingo = 0, contador = 0, aux = 0, contadorCartela = 0, num = 0, linha = 0, coluna = 0;
bool repetido;
int[] njogador = new int[jogador];
int[,] cartelabingo = new int[5, 5];
int[,] cartelaJogador = new int[5, 5];
int[] cartelaSorteio = new int[99] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 };
Console.WriteLine("....BINGO....");
int NumeroJogadores()
{
    Console.WriteLine("Digite o número de jogadores: ");
    jogador = int.Parse(Console.ReadLine());
    return jogador;
}//ok
int NumeroCartelas()
{
    {
        Console.WriteLine("Digite o número de cartelas para os jogadores: ");
        cartelas = int.Parse(Console.ReadLine());
    }
    return cartelas;
}//ok
void CartelaBase()
{
    for (int nsorteado = 0; nsorteado < 99; nsorteado++)
    {
        cartelaSorteio[nsorteado] = nsorteado + 1;
        Console.Write($"{cartelaSorteio[nsorteado]}|");
    }
}//ok
int[,] SorteioCartela()
{
    contador = 0;
    int[,] cartelaJogador = new int[5, 5];
    for (int linha = 0; linha < 5; linha++)
    {
        for (int coluna = 0; coluna < 5; coluna++)
        {
            do
            {
                repetido = false;
                aux = new Random().Next(1, 100);
                for (int l = 0; l < 5; l++)
                {
                    for (int c = 0; c < 5; c++)
                    {
                        if (cartelaJogador[l, c] == aux)
                        {
                            repetido = true;
                        }

                    }
                }
            } while (repetido);
            cartelaJogador[linha, coluna] = aux;
            contador++;
            Console.Write($"{cartelaJogador[linha, coluna]}|");

        }
        Console.WriteLine();
    }
    return cartelaJogador;
}
int SorteioBingo()
{
    contador = 0;
    nbingo = 0;
    Random random = new Random();
    while (contador < 99)
    {
        aux = random.Next(1, 100);

        for (int i = 0; i < contador; i++)
            if (nbingo == 0)
            {
                nbingo = aux;
                nbingo++;
            }
            else
            {
                bool repetido = false;
                {
                    if (nbingo == aux)
                    {
                        repetido = true;
                        break;
                    }
                }
                if (!repetido)
                {
                    nbingo = aux;
                    nbingo++;
                }
            }
        Console.WriteLine("O número sorteado foi:" + nbingo + "!");
        contador++;
    }
    return nbingo;

}
bool NumeroMarcado(int[,] cartelaJogador, int nbingo, int num)
{

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (cartelaJogador[linha, coluna] == num || nbingo == num)
            {
                num = 0;
                return true;
            }

        }
    }
    return false;
}
int ColunaCompleta(int[,] cartelaJogador, int nbingo)
{
    contador = 0;
    for (int linha = 0; linha < 5; linha++)
    {
        int resultadocoluna = 0;
        for (int coluna = 0; coluna < 5; coluna++)
        {
            resultadocoluna += cartelaJogador[coluna, linha];
        }
        if (resultadocoluna == 0)
        {
            contador++;
        }
    }
    return contador;
}
int LinhaCompleta(int[,] cartelaJogador, int nbingo)
{
    contador = 0;
    for (int coluna = 0; coluna < 5; coluna++)
    {
        int resultadolinha = 0;
        for (int linha = 0; linha < 5; linha++)
        {
            resultadolinha += cartelaJogador[coluna, linha];
        }
        if (resultadolinha == 0)
        {
            contador++;
        }
    }
    return contador;
}
int CartelaCheia(int[,] cartelaJogador, int bingo)
{

    return bingo;
}

//Main
NumeroJogadores();
Console.WriteLine(NumeroJogadores);
NumeroCartelas();
Console.WriteLine(NumeroCartelas);
CartelaBase();
Console.WriteLine();
Console.WriteLine(cartelaSorteio);
Console.WriteLine();
SorteioCartela();
Console.WriteLine();
SorteioBingo();