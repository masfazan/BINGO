int jogador = 0, cartelas = 0, npossiveis = 0, nsorteado = 0, nbingo = 0, contador = 0, aux = 0, contadorCartela = 0, num = 0, linha = 0, coluna = 0;
int[] njogador = new int[jogador];
int[,] cartelabingo = new int[5, 5];
int[] cartelaSorteio = new int[99] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 };

Console.WriteLine("....BINGO....");

void NumeroJogadores()
{
    Console.WriteLine("Digite o número de jogadores: ");
    jogador = int.Parse(Console.ReadLine());
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

    int[,] cartelaJogador = new int[5, 5];
    Random random = new Random();

    for (int linha = 0; linha < 5; linha++)
    {
        for (int coluna = 0; coluna < 5; coluna++)
        {
            aux = random.Next(1, 100);
            if (cartelaJogador[linha, coluna] == 0)
            {
                cartelaJogador[linha, coluna] = aux;
                cartelaJogador[linha, coluna]++;
            }
            else
            {
                bool repetido = false;
                {
                    if (cartelaJogador[linha, coluna] == aux)
                    {
                        repetido = true;
                    }
                }
                if (!repetido)
                {
                    cartelaJogador[linha, coluna] = aux;

                }
                else
                {
                    coluna--;
                }
            }
            Console.Write($"{cartelaJogador[linha, coluna]}|");
        }
    }
    contador++;
    return cartelaJogador;
} //enquanto retorno da função numero de cartelas for menor que cartelaJogador, imrime mais cartelas
  //precisa imprimir cartela do jogador 1 e cartela do jogador 2
  //tá imprimindo repetido
int SorteioBingo()
{
    Random random = new Random();
    while (contador < 99)
    {
        aux = random.Next(1, 100);
        if (nbingo == 0)
        {
            nbingo = aux;
            nbingo++;
        }
        else
        {
            bool repetido = false;
            for (int i = 0; i < nbingo; i++)
            {
                if (nbingo == aux)
                {
                    repetido = true;
                }
            }
            if (!repetido)
            {
                nbingo = aux;
                nbingo++;
            }
        }
        Console.WriteLine("O número sorteado foi:" + nbingo + "!");
    }
    contador++;
    return nbingo;

}//Sorteando infinito
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
} //falta testar, o número marcado troca por zero

//verificação soma linhas, se for = 0 -> ponto!
//verificaçao soma coluna, se for = 0 -> ponto!
//quando todos os números da cartela forem 0 -> bingo!
/*for (int linha = 0; linha < 5; linha++)
{
    float resultado = 0;
    for (int coluna = 0; coluna < 5; coluna++)
    {
        resultado += cartela[coluna, linha];
    }
   Console.WriteLine(resultado);
}
*/

//MAIN
NumeroJogadores();
Console.WriteLine(NumeroJogadores);
NumeroCartelas();
Console.WriteLine(NumeroCartelas);
CartelaBase();
Console.WriteLine();
SorteioCartela();
Console.WriteLine(cartelaSorteio);
//SorteioBingo();