using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorInimigo : MonoBehaviour
{
    public Inimigo[] inimigoPrefab;
    [Min(0.1f)]public float intervalos = 1;

    private void Start()
    {
        StartCoroutine(GerarInimigo());
    }

    public IEnumerator GerarInimigo()
    {
        while (true)
        {
            Instantiate(inimigoPrefab[0], transform.position, Quaternion.identity);
            yield return new WaitForSeconds(intervalos);
        }
    }
}
