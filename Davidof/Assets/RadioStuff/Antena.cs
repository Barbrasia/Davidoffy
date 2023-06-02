using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antena : MonoBehaviour
{
    public delegate void eventPlayMusic();
    public static event eventPlayMusic StartPlayingRadioMusic;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
            StartPlayingRadioMusic?.Invoke();

    }
}
