﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
    }
}