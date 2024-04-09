using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Serialization;
using UnityEngine;
using UnityEditor;

[ExecuteInEditMode]


public class clothSkin : MonoBehaviour
{
    public GameObject[] meshes;
    public Material[] skins;

    public static int currentSkin { get; set; }

    [SerializeField]
    private int sCurrentSkin = 0;


    void Start()
    {
        if (!Application.isEditor)
        {
            currentSkin = 0; // Normal value, used for the final game
        }
    }

    void OnValidate()
    {
        if (sCurrentSkin < 0)
            sCurrentSkin = 0;
        else if (sCurrentSkin > skins.Length - 1)
            sCurrentSkin = skins.Length - 1;

        currentSkin = sCurrentSkin;

        foreach (GameObject mesh in meshes)
        {
            mesh.GetComponent<MeshRenderer>().material = skins[currentSkin];
        }

    }
}
