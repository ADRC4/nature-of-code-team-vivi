using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbranch5 : MonoBehaviour {

    public void growbranches5(int index)
    {
        this.transform.position += this.transform.up * 2 * this.transform.localScale.y;
    }
}
