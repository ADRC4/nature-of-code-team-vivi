using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoiseTest5 : MonoBehaviour
{
    GameObject floatObject;

    //public int numberOfObjects = 50;
    //public float animSpeed = 0.5f;
    //public float scaleInputRange = 4 * Mathf.PI;
    //public float scaleResult = 10.0f;
    //public bool animate = true;

    int numberOfObjects = 100;
    float Speed = 0.01f;
    //float Period = 4 * Mathf.PI;
    //float amplitude = 10.0f;

    //public float perlinScale = 4.56f;


    float perlinScale = 4f;
    float[] amplitude = new float[100];
    float[] period = new float[200];
    bool animate = true;

    GameObject[] floatObjectsLists;

    void Start()
    {
        if (floatObject == null)
        {
            floatObject = GameObject.CreatePrimitive(PrimitiveType.Sphere); //public static gameobject;

            floatObjectsLists = new GameObject[numberOfObjects];

            for (int i = 0; i < numberOfObjects; i++)
            {
                floatObjectsLists[i] = (GameObject)GameObject.Instantiate(floatObject, new Vector3(i - (numberOfObjects / 2), 0, 0), Quaternion.identity);
            }

            floatObject.SetActive(false);
        }
    }

    //Vector3[] ObjectsPoints = new Vector3[50];

    void Update()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {

            //float functionXvalue = (floatObjectsLists[i].x * perlinScale) + (Time.timeSinceLevelLoad * Speed);

            //float functionXvalue = (i * perlinScale) + (Time.timeSinceLevelLoad * Speed);

            //float functionYvalue = (i * perlinScale) + (Time.timeSinceLevelLoad * Speed);
            //float functionXvalue = i - (numberOfObjects / 2);

            float functionYvalue = i * period[i] / numberOfObjects;
            float functionXvalue=i ;
            //float functionYvalue = i - (numberOfObjects / 2);

            amplitude[i] = Random.Range(10, 100);
            period[i] = Random.Range(10, 200);

            if (animate)
            {
                //functionXvalue += Time.time * Speed;

                functionYvalue += Time.time * Speed;

                float ObjectsPosition = Mathf.PerlinNoise(functionXvalue, functionYvalue);

                //float pX = (ObjectsPoints[i].x * perlinScale) + (Time.timeSinceLevelLoad * Speed);
                //float pY = (ObjectsPoints[i].y  * perlinScale) + (Time.timeSinceLevelLoad * Speed);

                //ObjectsPoints[i].z  = (Mathf.PerlinNoise(pX, pY) - 0.5F) * amplitude;

                //floatObjectsLists[i].transform.position = new Vector3(pX, pY, 0);

            }

            //floatObjectsLists[i].transform.position = new Vector3(functionXvalue*amplitude [i], functionYvalue * amplitude[i], 0);
            floatObjectsLists[i].transform.position = new Vector3(i - (numberOfObjects / 2), functionYvalue * amplitude[i], 0);
        }


    }

    //float ComputeFunction(int functionXvalue,int functionYvalue)
    //{
    //    return Mathf.PerlinNoise((float)functionXvalue, (float)functionYvalue);
    //}

    //float ComputeFunction(float x)
    //{
    //    return Mathf.Sin(x);
    //}
}
