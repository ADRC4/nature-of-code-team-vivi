using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbranch6 : MonoBehaviour {

    public void growbranches6(RecursiveBundle2 bundle)
    {
        this.transform.position += this.transform.up * 2 * this.transform.localScale.y;
    }
}
