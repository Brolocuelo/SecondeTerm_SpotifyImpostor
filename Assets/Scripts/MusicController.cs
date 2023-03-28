using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public GameObject camera;
    private AudioSource _audioSource; 

    private void Start()
    {
        _audioSource = camera.GetComponent<AudioSource>();
    }

    public void musicVolum(float v)
    {
        _audioSource.volume = v;
    }

}
