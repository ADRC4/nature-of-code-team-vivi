using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbranch3 : MonoBehaviour {

    public void growbranches3(int index)
    {
        this.transform.position += this.transform.up * 2 * this.transform.localScale.y;
    }
}
