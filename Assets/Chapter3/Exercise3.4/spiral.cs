using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]

public class spiral : MonoBehaviour {

    private float r = 0;
    private float theta = 0;
    private float x, y;
    private LineRenderer line;
    public int points;

	void Start () {
        line = GetComponent<LineRenderer>();
        line.positionCount = points;
        CreatePoints ();
	}
	
	void CreatePoints () {
        for (int i = 0; i < points; i++)
        {
            x = r * Mathf.Cos(theta);
            y = r * Mathf.Sin(theta);

            theta += .1f;
            r += 0.01f;
            line.SetPosition(i, new Vector3(x, y, 0f));
        }
    }
}
