using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio1 : MonoBehaviour
{

    private void OnEnable()
    {
        Antena.StartPlayingRadioMusic += PlayClassicMusic;

    }

    private void OnDisable()
    {
        Antena.StartPlayingRadioMusic -= PlayClassicMusic;
    }

    private void PlayClassicMusic()
    {
        Debug.Log("Klasyczna Muzyka");
    }
}
