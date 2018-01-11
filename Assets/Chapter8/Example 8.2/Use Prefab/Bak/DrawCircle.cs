using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class DrawCircle : MonoBehaviour
{
    public int vertexCount = 40;
    public float lineWidth = 0.2f;
    public float radius;
    public bool circleFillscreen;

    private LineRenderer lineRenderer;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
        //make pipe
        SetupCircle();
    }

    private void SetupCircle()
    {
        lineRenderer.widthMultiplier = lineWidth;
       
        //caculate the radius
        if(circleFillscreen)
        {
            //Transforms position from screen space into world space
            radius = Vector3.Distance(Camera.main.ScreenToWorldPoint(new Vector3(0f, Camera.main.pixelRect.yMax, 0f)),
                Camera.main.ScreenToWorldPoint(new Vector3(0f, Camera.main.pixelRect.yMin, 0f))) * 0.5f - lineWidth;
        }

        //Perimeter / vertexCount
        float deltaTheta = (2f * Mathf.PI) / vertexCount;
        float theta=0f;

        lineRenderer.positionCount = vertexCount;
        for (int i=0; i<lineRenderer.positionCount; i++)
        {
            Vector3 pos= new Vector3(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta), 0f);
            lineRenderer.SetPosition(i, pos);

            theta += deltaTheta;
        }

    }


//Preview of the circle
#if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        //Perimeter / vertexCount
        float deltaTheta = (2f * Mathf.PI) / vertexCount;
        float theta = 5f;

        Vector3 oldPos = Vector3.zero;

            for (int i = 0; i < vertexCount + 1; i++)
            {
                Vector3 pos = new Vector3(radius * Mathf.Cos(theta), radius * Mathf.Sin(theta), 0f);
                Gizmos.DrawLine(oldPos, transform.position + pos);

                //draw lines between each pair of neighbouring points instead of the corner(oldpos)_Start from oldPos
                oldPos = transform.position + pos;

                theta += deltaTheta;
            }

#endif 

    }

}

