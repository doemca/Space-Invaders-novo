using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float velocidade = 5;
    public GameObject projetil;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projetil, 
                transform.position,Quaternion.identity);
        }
    }

    void FixedUpdate()
    {
        float eixoX = Input.GetAxis("Horizontal");
        Vector2 direcao = new Vector2(eixoX, 0);
        GetComponent<Rigidbody2D>().velocity = direcao*velocidade;

        float xLimite = Mathf.Clamp(transform.position.x, -9, 9);
        Vector3 limite = transform.position;
        limite.x = xLimite;
        transform.position = limite;
    
    }
}
