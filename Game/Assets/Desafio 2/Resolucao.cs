using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolucao : MonoBehaviour
{
        public int x = 0;
        public int y = 0;
        public int z = 0;
        int maior_numero = 0;
    // Start is called before the first frame update
    void Start()
    {
        maior_numero = x;
        if(y > maior_numero)
        {
            maior_numero = y;
        }
        if(z > maior_numero)
        {
            maior_numero = z;
        }
        Debug.Log("o maior numero é: " + maior_numero);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
