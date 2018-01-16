﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    private LineRenderer line;
    public Transform point0;
    public Transform point1;

    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        Vector3 pointA = point0.position;
        Vector3 pointB = point1.position;
        line.SetPosition(0, point1.position);
    }
}

