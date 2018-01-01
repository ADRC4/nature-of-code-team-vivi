using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave2 : MonoBehaviour
{
    GameObject floatObject;

    //public int numberOfObjects = 50;
    //public float animSpeed = 0.5f;
    //public float scaleInputRange = 4 * Mathf.PI;
    //public float scaleResult = 10.0f;
    //public bool animate = true;

    int numberOfObjects = 50;
    float Speed = 1f;
    float Period = 2 * Mathf.PI;
    float amplitude = 10.0f;
    bool animate = true;

    GameObject[] floatObjectsLists;
	
	void Start ()
    {
		if(floatObject == null)
        {
            floatObject = GameObject.CreatePrimitive(PrimitiveType.Sphere ); //public static gameobject;

            floatObjectsLists = new GameObject[numberOfObjects];

            for(int i = 0; i < numberOfObjects; i++)
            {
                floatObjectsLists[i] = (GameObject)GameObject.Instantiate(floatObject, new Vector3(i - (numberOfObjects / 2),0, 0), Quaternion.identity);
            }

            floatObject.SetActive(false);
        }
	}
	
	
	void Update ()
    {
		for (int i = 0; i < numberOfObjects; i++)
        {
            float functionXvalue = i * Period / numberOfObjects;

            if (animate)
            {
                functionXvalue += Time.time * Speed;
            }

            floatObjectsLists[i].transform.position = new Vector3(i - (numberOfObjects / 2), ComputeFunction(functionXvalue) * amplitude, 0);
        }
	}

    float ComputeFunction(float x)
    {
        return Mathf.Sin(x);
    }
}
