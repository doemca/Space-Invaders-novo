using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPontuacao : MonoBehaviour
{
    private void Awake()
    {
        if (PlayerPrefs.HasKey("pontos"))
        {
            PlayerPrefs.SetInt("pontos", 0);
        }
    }
}
