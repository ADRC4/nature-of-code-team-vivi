using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbranch4 : MonoBehaviour {

    public void growbranches4(int index)
    {
        this.transform.position += this.transform.up * 2 * this.transform.localScale.y;
    }
}
