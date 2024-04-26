using System;
using System.Runtime.InteropServices;

int jogador = 0, cartelas=0, npossiveis=0, nsorteado=0, nbingo=0, contador=0, aux=0, contadorCartela = 0;
int[] njogador = new int[jogador];
int[,] cartelabingo=new int[5,5];
int[] cartelasorteio = new int[99] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 };

Console.WriteLine("....BINGO....");
void Imprimir(float[,] matriz, string titulo)
{
    Console.WriteLine();
    for (int linha = 0; linha < 5; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < 5; coluna++)
        {
            Console.Write(matriz[linha, coluna] + " ");
        }
    }
}//ok
void NumeroJogadores()
{
    Console.WriteLine("Digite o número de jogadores: ");
    jogador = int.Parse(Console.ReadLine());
}//ok
void NumeroCartelas()
{
    Console.WriteLine("Digite o número de cartelas para os jogadores: ");
    cartelas = int.Parse(Console.ReadLine());
}//ok
void CartelaBase()
{
    for (int nsorteado = 0; nsorteado < 99; nsorteado++)
    {
        cartelasorteio[nsorteado] = nsorteado + 1;
        Console.Write($"{cartelasorteio[nsorteado]},\n");
    }
}//ok
int[,] CartelaJogador()
{
    int[,] cartelaJogador = new int[5, 5];
    return cartelaJogador;

}
int checarRepetido(int[,] cartelasorteio)
{
    int aux = new Random().Next(1, 100);
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (cartelasorteio[i, j] == aux)
            {
                aux = 0;
            }

        }
    }
    return aux;

}
void SorteioCartela()
{
    int[,] cartelasorteio = CartelaJogador();
    int num = 0;
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            while (num == 0)
            {                
                num = checarRepetido(cartelasorteio);               
            }
            cartelasorteio[i, j] = num;

        }
    }
    Console.WriteLine(Cartela(cartelasorteio));
}
void SorteioBingo()
{   //sortear 1 por vez e marcar na função ou vetor base qual número já foi
    while (contador < 99)
    {
        Random random = new Random();
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
    }
    contador++;

}//ok
int[,] Cartela(int [,]cartelasorteio)
{
    //for (int linha = 0; linha < 5; linha++)
    //{
    //    for (int coluna = 0; coluna < 5; coluna++)
    //    {
    //        cartelabingo[linha, coluna] = cartelasorteio[nsorteado];
    //    }
    //}
    for (int linha = 0; linha < 5; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < 5; coluna++)
        {
            Console.Write(cartelasorteio[linha, coluna] + "| ");
        }
    }
    return cartelasorteio;
}//ok
void NumeroMarcado(int[,] cartelabingo)
{
    for (int linha = 0; linha < 5; linha++)
    {
        for (int coluna = 0; coluna < 5; coluna++)
        {
            if (cartelabingo[linha, coluna] == aux)
            {
                cartelabingo[linha, coluna] = 0;
            }
        }

    }
}


//MAIN
NumeroJogadores();
Console.WriteLine(NumeroJogadores);
NumeroCartelas();
Console.WriteLine(NumeroCartelas);
CartelaBase();
CartelaJogador();
int[,] cartela = CartelaJogador();


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







