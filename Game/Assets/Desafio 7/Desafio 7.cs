using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desafio7 : MonoBehaviour
{
    private int C = 0;
    private int Upgrade = 1;
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("cliques: " + C);
        
    }

    public void Botao_clique()
    {
        C = C + Upgrade;
        Debug.Log("cliques: " + C);
    }
    public void Upgrade_5()
    {
        if(C >= 10)
        {
            C -= 10;
            Upgrade += 5;
            Debug.Log("Upgrade +5!!");
        }
        else{
            Debug.Log("voce nao tem cliques suficiente!");
        }
    }
    public void Upgrade_10()
    {
        if(C >= 50)
        {
            C -= 50;
            Upgrade += 10;
            Debug.Log("Upgrade +10!!");
        }
        else{
            Debug.Log("voce nao tem cliques suficiente!");
        }
    }


}
