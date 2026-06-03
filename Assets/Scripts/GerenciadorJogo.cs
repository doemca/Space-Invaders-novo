using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorJogo : MonoBehaviour
{
    public int inimigosADerrotar = 0;
    public int pontuacao = 0;
    public static GerenciadorJogo instance;
    public TMP_Text textoPontos;
    public GameObject TelaFimdeJogo;

    public void Start()
    {
        Time.timeScale = 1;
        instance = this;
        TelaFimdeJogo.SetActive(false);
        if (PlayerPrefs.HasKey("pontos"))
        {
            pontuacao = PlayerPrefs.GetInt("pontos");
        }
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
        PlayerPrefs.SetInt("pontos", pontuacao);
        TelaFimdeJogo.SetActive(true);
        Time.timeScale = 0;
    }

    public void Update()
    {
        textoPontos.SetText(pontuacao. ToString());
    }

    public void CarregarCena(string cena)
    {
        SceneManager.LoadSceneAsync(cena);
    }
}
