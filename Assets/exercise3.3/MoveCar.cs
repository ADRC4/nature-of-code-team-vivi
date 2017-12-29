using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour {

    public float speed = 10f;
	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontal * speed * Time.deltaTime, 0);

        float vertical = Input.GetAxis("Vertical");
        transform.Translate(0, 0,-vertical * speed * Time.deltaTime);

            //if (Input.GetKey(KeyCode.S))
            //{
            //    gameObject.transform.Translate(0, 0, 20 * Time.deltaTime);
            //}
            //if (Input.GetKey(KeyCode.W))
            //{
            //    gameObject.transform.Translate(0, 0, -20 * Time.deltaTime);
            //}
            //if (Input.GetKey(KeyCode.D))
            //{
            //    gameObject.transform.Rotate(0, 50 * Time.deltaTime, 0);
            //}
            //if (Input.GetKey(KeyCode.A))
            //{
            //    gameObject.transform.Rotate(0, -50 * Time.deltaTime, 0);
            //}
        
    }
}
