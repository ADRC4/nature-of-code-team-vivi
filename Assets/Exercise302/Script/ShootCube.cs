using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCube : MonoBehaviour
{
    public GameObject objectPrefab;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newObject = Instantiate(objectPrefab) as GameObject;
            newObject.transform.position = transform.position;

            Rigidbody rb = newObject.GetComponent<Rigidbody>();
            rb.velocity = transform.forward * 20;
        }
	}
}
