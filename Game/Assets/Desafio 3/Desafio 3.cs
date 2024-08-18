using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio3 : MonoBehaviour
{
    public string letra = "A";
    // Start is called before the first frame update
    void Start()
    {
        if( letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u" || letra == "A" || letra == "E" || letra == "I" || letra == "O" || letra == "U")
        {
            Debug.Log("a letra: " + letra + " é uma vogal.");
        }
        else{

            Debug.Log("a letra: " + letra + " é uma consoante");
        }
    }     

    // Update is called once per frame
    void Update()
    {
        
    }
}
