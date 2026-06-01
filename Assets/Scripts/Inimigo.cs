using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public int vida = 1;
    public float alturaDescida = 1;
    [Min(1)] public float velocidade = 1;
    public int pontos = 10;


    public void AplicarDano(int dano)
    {
        vida -= dano;
        if(vida == 0)
        {
            Destroy(gameObject);
        }
    }

    Vector3 direcao = Vector2.right;
    private void Update()
    {

        if(transform.position.x > 9)
        {
            direcao = Vector2.left;
            transform.position += Vector3.down * alturaDescida;
         }
        if(transform.position.x < -9)
        {
            direcao = Vector2.right;
            transform.position += Vector3.down * alturaDescida;
        }
        transform.position += direcao*Time.deltaTime;
    }
}
