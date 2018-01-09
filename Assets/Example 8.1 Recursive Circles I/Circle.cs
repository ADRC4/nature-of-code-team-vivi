using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (LineRenderer ))]
public class Circle : MonoBehaviour
{
    public int vertexCount = 40;
    public float lineWidth = 0.2f;
    public float radius;
    public bool circleFillscreen;

    private LineRenderer lineRenderer;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>(); 
    }

    private void OnDrawGizmos()
    {
        float deltaTheta = (2f * Mathf.PI) / vertexCount;
        float theta = 0f;

        Vector3 oldPos = Vector3.zero;


        if (radius >= 10)
        {
           
            for (int i = 0; i < vertexCount + 1; i++)
            {
                Vector3 pos = new Vector3(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta), 0f);
                Gizmos.DrawLine(oldPos, transform.position + pos);

                //draw lines between each pair of neighbouring points instead of the corner(oldpos)
                oldPos = transform.position + pos;

                theta += deltaTheta;
            }
        }

        if (radius < 10)
        {
            radius *= 0.75f;

           
            for (int i = 0; i < vertexCount + 1; i++)
            {
                Vector3 pos = new Vector3(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta), 0f);
                Gizmos.DrawLine(oldPos, transform.position + pos);

                //draw lines between each pair of neighbouring points instead of the corner(oldpos)
                oldPos = transform.position + pos;

                theta += deltaTheta;
            }
        }
        

    }      
}

