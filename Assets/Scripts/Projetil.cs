using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float velocidade = 15;
    private float tempoDeCriacao;
    public int pontos = 10;
    void Start()
    {
        tempoDeCriacao = Time.time;
        GetComponent<Rigidbody2D>().velocity = Vector2.up * velocidade;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Inimigo"))
        {
            collision.GetComponent<Inimigo>().AplicarDano(1);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if(Time.time > tempoDeCriacao + 5)
        {
            GerenciadorJogo.instance.Acrescentar(pontos);
            Destroy(gameObject);
        }
    }
}
