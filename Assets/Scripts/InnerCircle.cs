﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerCircle : MonoBehaviour
{
    public int degree = 18;
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        transform.Rotate(0, 0, -degree * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
