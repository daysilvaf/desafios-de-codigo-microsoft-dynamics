DESAFIO
Na calçada em frente ao Palácio Imperial, não se sabe a razão, existe uma sequência de N números desenhados no chão. A sequência tem a seguinte forma: ela começa e termina 
com o número 1; apenas os números 1 e 2 aparecem nela; e o número 2 aparece pelo menos uma vez. Veja um exemplo na coluna (a) da figura ao lado. Ninguém sabe o significado 
da sequência e, justamente por isso, várias teorias malucas surgiram. Uma delas diz que a sequência representa, na verdade, apenas um valor que estaria relacionado a um 
segredo dos imperadores. Esse valor é a quantidade máxima de números da sequência que poderiam ser marcados com um círculo, de modo que a sequência de números marcados 
não contenha dois números iguais consecutivos. A coluna (b) da figura ao lado ilustra uma sequência de 4 números marcados que obedece a restrição acima. Só que é possível 
marcar 7 números, como mostra a coluna (c) da figura.

Neste problema, dada a sequência original de números desenhados no chão da calçada, seu programa deve computar e imprimir a quantidade máxima de números da sequência que 
poderiam ser marcados com um círculo sem que haja dois números iguais consecutivos na sequência marcada.

ENTRADA
A primeira linha da entrada contém um inteiro N representando o tamanho da sequência. As N linhas seguintes contêm, cada uma, um inteiro Vi , para 1 ≤ i ≤ N, definindo a 
sequência de números desenhados no chão da calçada imperial.

SAÍDA
Seu programa deve imprimir uma linha contendo um número inteiro representando a quantidade máxima de números da sequência que poderiam ser marcados com um círculo sem que 
haja dois números iguais consecutivos na sequência marcada.

RESTRIÇÕES
3 ≤ N ≤ 500
Vi é igual a 1 ou 2, para 1 ≤ i ≤ N

EXEMPLOS
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros 
casos possíveis.

-------------------
| ENTRADA | SAÍDA |
-------------------
|    5    |   3   |
|    1    |       |
|    1    |       |
|    1    |       |
|    2    |       |
|    1    |       |
-------------------
|    12   |   7   |
|    1    |       |
|    2    |       |
|    1    |       |
|    2    |       |
|    2    |       |
|    2    |       |
|    1    |       |
|    1    |       |
|    2    |       |
|    2    |       |
|    1    |       |
|    1    |       |
-------------------
|    3    |   3   |
|    1    |       |
|    2    |       |
|    1    |       |
-------------------

CÓDIGO

using System;

class Program 
{
    public static void Main() 
    {
        int tamanhoSequencia = Convert.ToInt32(Console.ReadLine());
        int quantidadeNumerosMarcados = 0;
        int ultimoNumeroLido = 0; // Inicializa em zero, porque "Vi é igual a 1 ou 2";

        for (int i = 0; i < tamanhoSequencia; i++) 
        {
            int vi = Convert.ToInt32(Console.ReadLine());
            
            // Verifica se o número lido (Vi) é diferente do último número lido para marcá-lo.
            if (vi != ultimoNumeroLido) 
            {
                quantidadeNumerosMarcados++;
            }

            ultimoNumeroLido = vi;
        }

        // Imprime a quantidade de números marcados.
        Console.WriteLine(quantidadeNumerosMarcados);
    }
}
