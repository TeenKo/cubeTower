﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsEnabled : MonoBehaviour
{
    public int needToUnlock;
    public Material blackMaterial;

    private void Start()
    {
        if (PlayerPrefs.GetInt("score") < needToUnlock)
            GetComponent<MeshRenderer>().material = blackMaterial;
    }
}
