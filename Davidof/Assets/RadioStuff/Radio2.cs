using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio2 : MonoBehaviour
{
    private void OnEnable()
    {
        Antena.StartPlayingRadioMusic += PlayKpop;

    }

    private void OnDisable()
    {
        Antena.StartPlayingRadioMusic -= PlayKpop;
    }

    private void PlayKpop()
    {
        Debug.Log("Kpop");
    }
}
