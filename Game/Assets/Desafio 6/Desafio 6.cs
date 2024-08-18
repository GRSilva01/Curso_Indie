using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using JetBrains.Annotations;
using UnityEngine;

public class Desafio6 : MonoBehaviour
{
    public int x = 0;
    public int y = 0;
    public int z = 0;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(MaiorQueMil(10, 30, 5)); 
    }
    bool MaiorQueMil( int a, int b, int c)
    {
        int valor = (a + b) * c;
        if(valor > 1000){
            return true;
        }
        else{
            return false;
        }
    }
}
