﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIdial : MonoBehaviour
{
    public float boundY = 2.25f;
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var pos = GameObject.Find("Ball").transform.position;

        if (pos.y > boundY)
        {
            pos.y = boundY;
        }
        else if (pos.y < -boundY)
        {
            pos.y = -boundY;
        }

        pos.x = -4.0f;

        transform.position = pos;
    }
}
