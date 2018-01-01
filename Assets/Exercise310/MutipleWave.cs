using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MutipleWave : MonoBehaviour
{
    GameObject floatObject0;
    //public Transform 

    int numberOfObjects0 = 50;
    float Speed0 = 1f;
    float Period0 = 2* Mathf.PI;
    float amplitude0 = 10.0f;
    bool animate = true;

    GameObject[] floatObjectsLists0;



    GameObject floatObject1;

    int numberOfObjects1 = 10;
    float Speed1 = 0.5f;
    float Period1 = Mathf.PI;
    float amplitude1 = 2.0f;
    //bool animate = true;

    GameObject[] floatObjectsLists1;

    void Start()
    {
        if (floatObject0 == null)
        {

            //Vector3 scale = new Vector3(10f, 10f, 0);
            floatObject0 = GameObject.CreatePrimitive(PrimitiveType.Sphere); //public static gameobject;
            //floatObject0.transform.position = scale;
            floatObjectsLists0 = new GameObject[numberOfObjects0];

            for (int i = 0; i < numberOfObjects0; i++)
            {
                floatObjectsLists0[i] = (GameObject)GameObject.Instantiate(floatObject0, new Vector3(i - (numberOfObjects0 / 2), 0, 0), Quaternion.identity);
            }
            //floatObject0[i].transform.position = scale;

            floatObject0.SetActive(false);
        }




        if (floatObject1 == null)
        {
            floatObject1 = GameObject.CreatePrimitive(PrimitiveType.Sphere); //public static gameobject;

            floatObjectsLists1 = new GameObject[numberOfObjects1];

            for (int i = 0; i < numberOfObjects1; i++)
            {
                floatObjectsLists1[i] = (GameObject)GameObject.Instantiate(floatObject1, new Vector3(i - (numberOfObjects1 / 2), 0, 0), Quaternion.identity);
            }

            floatObject1.SetActive(false);
        }
    }


    void Update()
    {
        for (int i = 0; i < numberOfObjects0; i++)
        {
            float functionXvalue0 = i * Period0 / numberOfObjects0;

            if (animate)
            {
                functionXvalue0 += Time.time * Speed0;
            }

            floatObjectsLists0[i].transform.position = new Vector3(40+i - (numberOfObjects0 / 2), ComputeFunction0(functionXvalue0) * amplitude0, 0);


        }





        for (int i = 0; i < numberOfObjects1; i++)
        {
            float functionXvalue1 = i * Period1 / numberOfObjects1;

            if (animate)
            {
                functionXvalue1 += Time.time * Speed1;
            }

            floatObjectsLists1[i].transform.position = new Vector3(i - (numberOfObjects1 / 2), ComputeFunction1(functionXvalue1) * amplitude1, 0);
        }
    }

    float ComputeFunction0(float x)
    {
        return Mathf.Sin(x);
    }


    float ComputeFunction1(float x)
    {
        return Mathf.Sin(x);
    }
}
