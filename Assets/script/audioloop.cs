using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioloop : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        
    }

    void Update()
    {
        if (audioSource.time > 1.75f)
        {
            audioSource.Stop();
            audioSource.Play(0);
        }
    }
}
