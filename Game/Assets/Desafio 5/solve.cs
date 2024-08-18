using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class solve : MonoBehaviour
{
    // Variáveis dos jogadores
    public int mao_jogador_1 = 2;
    public int mao_jogador_2 = 3;
    public bool jogador_1_par = true; // true se jogador 1 escolheu par, false se escolheu ímpar
    public string jogador_1 = "Jogador 1";
    public string jogador_2 = "Jogador 2";

    // Start is called before the first frame update
    void Start()
    {
        int resultado = mao_jogador_1 + mao_jogador_2;

        // Se resto igual a 0, é par
        if (resultado % 2 == 0)
        {
            // Se o número é par e o Jogador 1 escolheu par, ele vence
            if (jogador_1_par == true)
            {
                Debug.Log(resultado + " é um número par, portanto " + jogador_1 + " venceu!");
            }
            // Se o número é par e o Jogador 1 escolheu ímpar, o Jogador 2 venceu
            else
            {
                Debug.Log(resultado + " é um número par, portanto " + jogador_2 + " venceu!");
            }
        }
        // Se o resto é diferente de 0, é ímpar
        else
        {
            // Se o número é ímpar e o Jogador 1 escolheu par, o Jogador 2 venceu
            if (jogador_1_par == true)
            {
                Debug.Log(resultado + " é um número ímpar, portanto " + jogador_2 + " venceu!");
            }
            // Se o número é ímpar e o Jogador 1 escolheu ímpar, ele vence
            else
            {
                Debug.Log(resultado + " é um número ímpar, portanto " + jogador_1 + " venceu!");
            }
        }
    }
}
