using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectControl1 : MonoBehaviour {

    float speed = 1f;
    //float timeMaxToZero = 3f;
    //float maxSpeed = 3f;

    //float accelRatePerSec;
    //float forwardVelocity;

    float screenHalfWidthInWorldUnits;

	void Start ()
    {
        //accelRatePerSec = maxSpeed / timeMaxToZero;
        //forwardVelocity = 0f;

        //float halfRectWidth = transform.localScale.x / 2f;
        screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize;
	}
	
	// Update is called once per frame
	void Update ()
    {
        

        //float inputX = Input.GetAxisRaw("Horizontal");
        //float velocity = inputX * speed;
        //transform.Translate(Vector2.right * velocity * Time.deltaTime);

        if(transform .position .x < -screenHalfWidthInWorldUnits)
        {
            transform.position = new Vector2(screenHalfWidthInWorldUnits, transform.position.y );
        }
        if (transform.position.x > screenHalfWidthInWorldUnits)
        {
            transform.position = new Vector2(-screenHalfWidthInWorldUnits, transform.position.y);
        }

    }
}
