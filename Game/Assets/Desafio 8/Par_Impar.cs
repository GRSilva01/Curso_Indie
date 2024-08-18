using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Par_Impar : MonoBehaviour
{
    public int par_ou_impar;
    public string par_impar_;
    public string numero_1;
    public int Escolha_1;
    public Text Resultado; 
    public string numero_pc;
    public void Jogar()
    {
        numero_pc = PC();
        Resultado.text = numero_pc;
        Escolha_1 = int.Parse(numero_1);
        par_impar_ = int.Parse(par_ou_impar);


    }

    public string PC()
    {
        int numero_pc_ = Random.Range(0, 6);
        return numero_pc_.ToString();

    }

}
