using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invasores : MonoBehaviour
{
    public Inimigo[] prefabs;
    
    public int linha = 3;

    public int coluna = 5;

    public void Awake()
    {
        for (int linha = 0; linha < this.linha; linha++)
        {
            for (int coluna = 0; coluna < this.coluna; coluna++)
            {
                Inimigo inimigo = Instantiate(this.prefabs[linha], this.transform);
            }
        }
    }
}