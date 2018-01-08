using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spring : MonoBehaviour {

    public GameObject cubeObject;
    public GameObject sphereObject;
    public Transform cubeTransform;
    public bool jointOnCube = false;         // Put the join on the cube? if not put it on the sphere.
    public bool cubeIsKinematic = true;     // Is the cube RB kinematic? No point turning this off really.
    public bool cubeHasCollider = false;    // keep the cube collider? Collider works pretty poorly anyway.
    public bool sphereHasGravity = true;    // keep sphere gravity on?

    private SpringJoint springJoint;        // reference to the joint
    public float springForce = 10f;         // spring value on the joint
    public float springDamper = 2f;     // damper value on the joint
    public float springMinDistance = 0f;    // minDistance on the joint
    public float springMaxDistance = 0.1f;  // maxDistance on the joint

    public bool autoConfigureConnectedAnchor = false;       // turn of autoConfigure
    public Vector3 springConnectedAnchor = Vector3.zero;    // and set anchors manually
    public Vector3 springAnchor = Vector3.zero;

    private WaitForSeconds wait;    // cache of wait for seconds used in the yield.
    private YieldInstruction wffu;  // Fixed update YI
    private Camera mainCam;         // cache of main camera
    public float camDepth = 15f;    // Used to set pos of dragger through camera.

    void Start()
    {
        // Spawn the sphere and set it up
        //GameObject sphereObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphereObject.transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f); // Random start position, to test autoConfigureConnectedAnchor behaviour
        Rigidbody sphereBody = sphereObject.AddComponent<Rigidbody>();
        sphereBody.useGravity = sphereHasGravity;

        // Spawn the cube and set it up
        //GameObject cubeObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cubeObject.transform.position = new Vector3(0f,5f,0f);  // Random start position, to test autoConfigureConnectedAnchor behaviour
        Rigidbody cubeBody = cubeObject.AddComponent<Rigidbody>();
        cubeBody.isKinematic = cubeIsKinematic;
        cubeTransform = cubeObject.transform;
        Collider cubeCollider = cubeObject.GetComponent<Collider>();
        if (!cubeHasCollider && cubeCollider != null) {
            Destroy(cubeCollider);
        }

        // Create the joint and set its properties.
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
            // no point setting manually if autoconfigure is on right?
            springJoint.connectedAnchor = springConnectedAnchor;
            springJoint.anchor = springAnchor;
        }
        springJoint.damper = springDamper;
        springJoint.spring = springForce;
        springJoint.minDistance = springMinDistance;
        springJoint.maxDistance = springMaxDistance;

        wait = new WaitForSeconds(0.25f);   // Cache wait for seconds.
        wffu = new WaitForFixedUpdate();
        /*mainCam = Camera.main;    */              // Cache camera
        /*StartCoroutine(UpdateRoutine());*/    // Start update routine.
    }

    //IEnumerator UpdateRoutine()
    //{
    //    while (true)
    //    {
    //        // wait for FixedUpdate, as we're moving physics objects.
    //        yield return wffu;

    //        // Set position of cube and yield
    //        cubeTransform.position = mainCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDepth));
    //        yield return wait;
    //    }
    //}
}
