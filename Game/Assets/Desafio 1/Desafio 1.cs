using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio1 : MonoBehaviour
{
    public int x = 5;
    public int y = 7;
    string Conta = "A soma de x + a é igual a: ";

    // Start is called before the first frame update
    void Start()
    {
        int Calculo = x + y;

        Debug.Log(Conta + Calculo);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
