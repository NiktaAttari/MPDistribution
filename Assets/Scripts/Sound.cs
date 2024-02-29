using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    AudioSource sources;
    BoxCollider soundTrigger;

    void Awake()
    {
        sources = GetComponent<AudioSource>();
        soundTrigger = GetComponent<BoxCollider>();
    }
    void OnTriggerEnter(Collider collider)
    {
        sources.Play();
    }
}
