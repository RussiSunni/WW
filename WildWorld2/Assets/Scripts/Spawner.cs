﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
 
 public GameObject spawnee;

    // Update is called once per frame
    void Update()
    {
        Instantiate(spawnee);
    }
}