using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorJogo : MonoBehaviour
{
    public int inimigosADerrotar = 0;
    public int pontuacao = 0;
    public static GerenciadorJogo instance;

    public void Start()
    {
        instance = this;
    }

    public void Acrescentar(int pontos)
    {
        pontuacao += pontos;
        inimigosADerrotar--;
        if(inimigosADerrotar <= 0)
        {
            FimdoJogo();
        }
    }

    public void FimdoJogo()
    {
        Time.timeScale = 0;
    }
}
