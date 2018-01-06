using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpheres : MonoBehaviour {

    bool animate = true;
    //float Period = 2 * Mathf.PI;
    //float Speed = 2f;
    //float amplitude;
    //float amplitude = 2f;
    private GameObject Qiu;
    float theta = 0;
    float Period = 2 * Mathf.PI;
    float aVelocity = 2f;
    //float aAcceleration = 0.01f;
    float amplitude = 2f;
    int numberOfObjects = 6;
    private Transform point1;

    GameObject[] Qius;

    // Use this for initialization
    void Start()
    {
        if (Qiu == null)
        {
            Qiu = GameObject.CreatePrimitive(PrimitiveType.Sphere);//create a sphere
            Qius = new GameObject[numberOfObjects];

            for (int i = 0; i < numberOfObjects; i++)
            {
                Qius[i] = (GameObject)GameObject.Instantiate(Qiu, new Vector3(transform.position.x, 0, 0), Quaternion.identity);
                //point1 = GameObject.Find("Sphere(Clone)").transform;
            }
            Qiu.SetActive(false);//hide the original
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (animate)
        {
            for (int i = 0; i < numberOfObjects; i++)
            {
                if (i < 3)
                {
                    float a = i * Period / numberOfObjects;
                    //a += aVelocity;
                    //amplitude = Random.Range(2, 5);
                    //aVelocity = Random.Range(0f, 0.1f);
                    //amplitude = Random.Range(-4f, 4f);
                    a += Time.time * aVelocity;
                    float y = Mathf.Sin(a) * amplitude;
                    //float x = theta;
                    //float y = amplitude * Mathf.Sin(theta);
                    //aVelocity += aAcceleration;
                    //float x = amplitude * Mathf.Sin(theta);
                    //float y = amplitude * Mathf.Sin(theta);

                    NewMethod(i).transform.position = new Vector3(transform.position.x, y, 0);
                }
                else
                {
                    float a = i * Period / numberOfObjects;
                    a += Time.time * aVelocity;
                    float y = Mathf.Sin(a) * amplitude;
                    NewMethod(i).transform.position = new Vector3(-transform.position.x, y, 0);
                    //Debug.Log(i);
                }
            }
        }
    }

    private GameObject NewMethod(int i)
    {
        return Qius[i];
    }
}
