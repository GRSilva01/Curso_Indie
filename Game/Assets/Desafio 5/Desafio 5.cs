using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Desafio5 : MonoBehaviour
{
    public string jogador_1 = "nome";
    public string jogador_2 = "nome";
    public int valor_1 = 0;
    public int valor_2 = 0;
    int resultado = 0;

    // Start is called before the first frame update
    void Start()
    {
        resultado = valor_1 + valor_2;
        if (resultado % 2 == 0)
        {
            Debug.Log(resultado + " é um numero par portando o " + jogador_1 + " venceu!!");
        }
        else
        {
            Debug.Log(resultado + " é um numero impar portando o " + jogador_2 + " venceu!!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
