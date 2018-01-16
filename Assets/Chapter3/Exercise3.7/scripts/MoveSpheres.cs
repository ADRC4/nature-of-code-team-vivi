using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpheres : MonoBehaviour {

    bool move = true;
    private GameObject Qiu;
    float theta = 0;
    float Period = 2 * Mathf.PI;
    float aVelocity = 2f;
    float amplitude = 2f;
    int numberOfObjects = 6;
    private Transform point1;
    GameObject[] Qius;

    void Start()
    {
        if (Qiu == null)
        {
            Qiu = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            Qius = new GameObject[numberOfObjects];

            for (int i = 0; i < numberOfObjects; i++)
            {
                Qius[i] = (GameObject)GameObject.Instantiate(Qiu, new Vector3(transform.position.x, 0, 0), Quaternion.identity);
            }
            Qiu.SetActive(false);//hide the original
        }
    }

    void Update()
    {
        if (move)
        {
            for (int i = 0; i < numberOfObjects; i++)
            {
                if (i < 3)
                {
                    float a = i * Period / numberOfObjects;
                    a += Time.time * aVelocity;
                    float y = Mathf.Sin(a) * amplitude;

                    NewMethod(i).transform.position = new Vector3(transform.position.x, y, 0);
                }
                else
                {
                    float a = i * Period / numberOfObjects;
                    a += Time.time * aVelocity;
                    float y = Mathf.Sin(a) * amplitude;
                    NewMethod(i).transform.position = new Vector3(-transform.position.x, y, 0);
                }
            }
        }
    }

    private GameObject NewMethod(int i)
    {
        return Qius[i];
    }
}
