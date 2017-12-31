using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetile : MonoBehaviour {

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(rb.velocity);
    }

    //   float speed = 10;
    //   public void SetSpeed(float newSpeed)
    //   {
    //       speed = newSpeed;
    //   }
    //// Update is called once per frame
    //void Update ()
    //   {
    //       transform.Translate(Vector3.forward * Time.deltaTime * speed);
    //}
}
