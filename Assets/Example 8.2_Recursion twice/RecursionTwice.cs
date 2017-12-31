using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class RecursionTwice : MonoBehaviour {

    public int vertexCount = 40;
    public float lineWidth = 0.2f;
    public float radius;
    //public float radius1;
    public bool circleFillscreen;

    
    private LineRenderer lineRenderer;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    //draw a circle
    private void OnDrawGizmos()
    {
        float deltaTheta = (2f * Mathf.PI) / vertexCount;
        float theta = 5f;
        
        //define the center of circle
        Vector3 oldPos = Vector3.zero ;
        //Vector3 oldpos1  = Vector3.zero + new Vector3(-0.5f* radius , 0, 0);

        for (int i = 0; i < vertexCount + 1; i++)
        {
            Vector3 pos = new Vector3(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta), 0f);
            Gizmos.DrawLine(oldPos, transform.position + pos);

            //draw lines between each pair of neighbouring points instead of the corner(oldpos)
            oldPos = transform.position + pos;

            theta += deltaTheta;
        }

        //Draw 2nd Circle
        for (int i = 0; i < vertexCount + 1; i++)
        {
            Vector3 pos = new Vector3(radius * Mathf.Cos(theta)/2, radius * Mathf.Sin(theta)/2, 0f);
            Gizmos.DrawLine(oldPos, transform.position + pos);

            //draw lines between each pair of neighbouring points instead of the corner(oldpos)
            oldPos = transform.position + pos;

            theta += deltaTheta;
        }
    }

   
}
