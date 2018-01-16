using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    bool move = true;
    float Period = 2 * Mathf.PI;
    float Speed = 2f;
    float amplitude = 5f;
    public GameObject Sphere;

    void Start()
    {

    }

    void Update()
    {
        if (move)
        {
            float a = Period;
            a += Time.time * Speed;
            float y = Mathf.Sin(a) * amplitude;
            Sphere.transform.position = new Vector3(0, y, 0);
        }
    }
}
