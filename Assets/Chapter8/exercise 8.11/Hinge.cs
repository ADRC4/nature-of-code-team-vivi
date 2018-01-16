using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hinge : MonoBehaviour
{
    public Rigidbody rigidbody;
    public HingeJoint hingeJoint;


    public void growbranches7(RecursiveBundle bundle)
    {
        var parentbody = bundle.Parents.GetComponent<Rigidbody>();
        rigidbody.isKinematic = false;

        hingeJoint.connectedBody = parentbody;
        hingeJoint.connectedAnchor = bundle.Parents.pivotposition;



       




    }

}
