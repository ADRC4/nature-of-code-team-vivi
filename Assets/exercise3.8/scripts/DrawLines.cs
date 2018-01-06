using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLines : MonoBehaviour {

    private LineRenderer line;

    public Transform point0;
    private Transform point1;
    //public Transform point2;
    //public Transform point3;
    public int points;


    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = points + 1;
        line.useWorldSpace = false;
        //line.SetPosition(0, point0.position);

    }


    void Update()
    {
        point1 = GameObject.Find("Sphere(Clone)").transform;
        Vector3 pointA = point0.position;
        Vector3 pointB = point1.position;
        //point1.position = transform.position.
        line.SetPosition(0, point1.position);

        //Vector3 pointC = point0.position;
        //Vector3 pointD = point2.position;
        //line.SetPosition(1, point2.position);

        //Vector3 pointA = point0.position;
        //Vector3 pointF = point3.position;
        //line.SetPosition(1, point3.position);
    }
}
