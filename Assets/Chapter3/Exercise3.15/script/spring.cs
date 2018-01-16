using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour {

    public GameObject cubeObject;
    public GameObject sphereObject;
    private Transform cubeTransform;
    private Transform sphereTransform;
    public bool jointOnCube = false;         
    public bool cubeIsKinematic = true;    
    public bool cubeHasCollider = false;    
    public bool sphereHasGravity = true;   

    private SpringJoint springJoint;        
    public float springForce = 10f;         
    public float springDamper = 2f;     
    public float springMinDistance = 0f;   
    public float springMaxDistance = 0.1f;  

    public bool autoConfigureConnectedAnchor = false;       
    public Vector3 springConnectedAnchor = Vector3.zero;    
    public Vector3 springAnchor = Vector3.zero;
    private WaitForSeconds wait;    
    private YieldInstruction wffu;  
    private Camera mainCam;         
    public float camDepth = 15f;    

    void Start()
    {
        sphereObject.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f); 
        Rigidbody sphereBody = sphereObject.AddComponent<Rigidbody>();
        sphereTransform = sphereObject.transform;
        sphereBody.useGravity = sphereHasGravity;

        cubeObject.transform.position = new Vector3(0f,5f,0f); 
        Rigidbody cubeBody = cubeObject.AddComponent<Rigidbody>();
        cubeBody.isKinematic = cubeIsKinematic;
        cubeTransform = cubeObject.transform;
        Collider cubeCollider = cubeObject.GetComponent<Collider>();
        if (!cubeHasCollider && cubeCollider != null) {
            Destroy(cubeCollider);
        }

        if (jointOnCube)
        {
            springJoint = cubeObject.AddComponent<SpringJoint>();
            springJoint.connectedBody = sphereBody;
        }
        else
        {
            springJoint = sphereObject.AddComponent<SpringJoint>();
            springJoint.connectedBody = cubeBody;
        }
        springJoint.autoConfigureConnectedAnchor = autoConfigureConnectedAnchor;

        if (!autoConfigureConnectedAnchor)
        {
            springJoint.connectedAnchor = springConnectedAnchor;
            springJoint.anchor = springAnchor;
        }
        springJoint.damper = springDamper;
        springJoint.spring = springForce;
        springJoint.minDistance = springMinDistance;
        springJoint.maxDistance = springMaxDistance;

        wait = new WaitForSeconds(0.25f); 
        wffu = new WaitForFixedUpdate();
    }
}
