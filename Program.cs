/*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).

Entrada:                                  Saida:  in;  out
5
14
123
10
-25
32  */

class Program
{
    public static void Main(string[] args)
    {
        int count_in = 0;
        int count_out = 0;
        Console.WriteLine("Digite um numero inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 0; i < numero; i++)
        {
            if (numero >= 10 && numero <= 20)
                count_in++;
            else
                count_out++;
        }
        Console.WriteLine(count_in + " - in");
        Console.WriteLine(count_out + " - out");
    }
}