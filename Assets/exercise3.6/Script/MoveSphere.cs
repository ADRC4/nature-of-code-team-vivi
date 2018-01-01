using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{

    bool animate = true;
    float Period = 2 * Mathf.PI;
    float Speed = 1f;
    float amplitude = 5f;
    public GameObject Sphere;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (animate)
        {

            float functionXvalue = Period;
            functionXvalue += Time.time * Speed;
            Sphere.transform.position = new Vector3(0, floating(functionXvalue) * amplitude, 0);
        }
    }

    float floating(float y)
    {
        return Mathf.Sin(y);
    }
}
