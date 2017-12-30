using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour {

    public float moveSpeed;
    public float maxSpeed = 1f;
    public float timeZeroToMax = 3f;
    float accelRatePerSec;
    float forwardVelocity;
    float screenHalfWidthInWorldUnits;

	// Use this for initialization
	void Start ()
    {
        accelRatePerSec = maxSpeed / timeZeroToMax;
        forwardVelocity = 0f;
        screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Movement
        if (Input.GetKey(KeyCode.Z))
        {
            gameObject.transform.Translate(0, forwardVelocity , 0);
            forwardVelocity += accelRatePerSec * Time.deltaTime;
            forwardVelocity = Mathf.Min(forwardVelocity, maxSpeed);
        }
        //if (Input.GetKey(KeyCode.S))
        //{
        //    gameObject.transform.Translate(0, -5 * Time.deltaTime, 0);
        //}
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
