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

	// Use this for initialization
	void Start () {
        line = GetComponent<LineRenderer>();
        line.positionCount = points + 1;
        line.useWorldSpace = false;
        CreatePoints ();
	}
	
	void CreatePoints () {
        // For every new point
        for (int i = 0; i < points  + 1; i++)
        {
            x = r * Mathf.Cos(theta);
            y = r * Mathf.Sin(theta);

            // Increment the angle
            theta += .1f;
            // Increment the radius
            r += 0.01f;
            line.SetPosition(i, new Vector3(x, y, 0f));
            Debug.Log(i);
        }
    }
}
