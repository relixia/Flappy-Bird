﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
