using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio4 : MonoBehaviour
{
    public int lado_A = 0;
    public int lado_B = 0;
    public int lado_C = 0;

    // Start is called before the first frame update
    void Start()
    {
        if(lado_A == lado_B && lado_A == lado_C)
        {
            Debug.Log("seu triagulo é equilatero");
        }
        else{
        if( lado_A == lado_B || lado_A == lado_C || lado_B == lado_C)
        {
            Debug.Log("seu triangulo é isociles");
        }
        else
        {
            Debug.Log("seu triangulo é escaleno");
        }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
