using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorInimigo : MonoBehaviour
{
    [Min(0)] public int quantidade = 5;
    public Inimigo[] inimigoPrefab;
    [Min(0.1f)]public float intervalos = 1;

    private void Start()
    {
        StartCoroutine(GerarInimigo());
    }

    public IEnumerator GerarInimigo()
    {
        int inimigosGerados = 0;
        while (true)
        {
            Instantiate(inimigoPrefab[0], transform.position, Quaternion.identity);
            inimigosGerados++;
            yield return new WaitForSeconds(intervalos);
        }
    }
}
