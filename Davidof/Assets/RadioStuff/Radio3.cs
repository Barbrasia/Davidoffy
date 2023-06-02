using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio3 : MonoBehaviour
{
    private void OnEnable()
    {
        Antena.StartPlayingRadioMusic += PlayJazz;

    }

    private void OnDisable()
    {
        Antena.StartPlayingRadioMusic -= PlayJazz;
    }

    private void PlayJazz()
    {
        Debug.Log("Jazz");
    }
}
