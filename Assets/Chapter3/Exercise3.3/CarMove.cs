using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour {

    public float speed = 10f;
    float screenHalfWidthInWorldUnits;

    void Start ()
    {
        screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize;
    }
	

	void Update ()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(0, -speed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Rotate(0, 0, 100 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.Rotate(0, 0, -100 * Time.deltaTime);
        }

        if (transform.position.x < -screenHalfWidthInWorldUnits)
        {
            transform.position = new Vector2(screenHalfWidthInWorldUnits, transform.position.y);
        }
        if (transform.position.x > screenHalfWidthInWorldUnits)
        {
            transform.position = new Vector2(-screenHalfWidthInWorldUnits, transform.position.y);
        }
        if (transform.position.y < -screenHalfWidthInWorldUnits)
        {
            transform.position = new Vector2(transform.position.y, screenHalfWidthInWorldUnits);
        }
        if (transform.position.y > screenHalfWidthInWorldUnits)
        {
            transform.position = new Vector2(transform.position.y, -screenHalfWidthInWorldUnits);
        }
    }
}
