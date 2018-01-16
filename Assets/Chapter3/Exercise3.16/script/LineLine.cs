using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineLine : MonoBehaviour {

    private LineRenderer line;

    public Transform point0;
    public Transform point1;
    public Transform point2;



    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.SetPosition(0, point0.position);

    }


    void Update()
    {
      //  Vector3 pointA = point0.position;
      //  Vector3 pointB = point1.position;
        line.SetPosition(1, point1.position);
        line.SetPosition(2, point2.position);
    }
}
