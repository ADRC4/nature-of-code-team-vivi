using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbranch7 : MonoBehaviour {

    public void growbranches7(RecursiveBundle bundle)
    {
        this.transform.position += this.transform.up * 2 * this.transform.localScale.y;
    }
}
