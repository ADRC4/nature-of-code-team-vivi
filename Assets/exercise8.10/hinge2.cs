using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hinge2 : MonoBehaviour {

    public Rigidbody rigidbody;
    public HingeJoint hingeJoint;


    public void growbranches6(RecursiveBundle2 bundle)
    {
        var parentbody = bundle.Parents.GetComponent<Rigidbody>();
        rigidbody.isKinematic = false;

        hingeJoint.connectedBody = parentbody;
        hingeJoint.connectedAnchor = bundle.Parents.pivotposition;








    }
}
