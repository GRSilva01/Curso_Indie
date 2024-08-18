using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio2 : MonoBehaviour
{
     public int x = 0;
     public int y = 0;
     public int z = 0;
    public int num = 15;

    // Start is called before the first frame update
    void Start()
    {
        if(x >= num)
        {
            Debug.Log("o numero maior é: " + x);
        }
        if(z >= num)
        {
            Debug.Log("o numero maior é: " + z);
        }
        if(y >= num)
            
        {
            Debug.Log("o numero maior é: " + y);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
