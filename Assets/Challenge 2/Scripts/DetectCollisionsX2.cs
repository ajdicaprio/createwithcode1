﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX2 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
