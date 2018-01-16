using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linetest : MonoBehaviour {

    private LineRenderer line;
    public Transform point0;
    public Transform point1;
    public int points;

    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    void Update()
    {
        //point1 = GameObject.Find("Sphere(Clone)").transform;
        Vector3 pointA = point0.position;
        Vector3 pointB = point1.position;
        line.SetPosition(1, point1.position);
    }
}
