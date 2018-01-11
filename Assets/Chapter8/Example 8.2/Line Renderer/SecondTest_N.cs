using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class SecondTest_N : MonoBehaviour
{
    public int vertexCount = 40;
    public float lineWidth = 0.2f;
    public float radius;
   

    private LineRenderer lineRenderer;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void OnDrawGizmos()
    {
        float deltaTheta = (2f * Mathf.PI) / vertexCount;
        float theta = 5f;

        Vector3 oldPos = Vector3.zero;
        Vector3 oldPos2 = Vector3.zero;


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

        //if (radius < 10)
        //{


        for (float d = radius; d > 1; d *= 0.5f)
        {
            for (int i = 0; i < vertexCount + 1; i++)
            {
                Vector3 pos = new Vector3(d * Mathf.Cos(theta), d * Mathf.Sin(theta), 0f);
                Gizmos.DrawLine(oldPos, transform.position + pos);

                oldPos = transform.position + pos;
                theta += deltaTheta;

                for (int j = 0; j < vertexCount + 1; j++)
                {


                    Vector3 _posLeft = new Vector3(-1, 0, 0);
                    Vector3 _posRight = new Vector3(1, 0, 0);

                    Vector3 posNew = new Vector3(d * Mathf.Cos(theta), d * Mathf.Sin(theta), 0f);
                    oldPos2 = transform.position + _posLeft;
                    Gizmos.DrawLine(oldPos2, transform.position + posNew);
                    theta += deltaTheta;
                }
            }
        }


    }
}

