using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newbranches : MonoBehaviour
{
    public void growbranches(int index)
    {
        this.transform.position += this.transform.up*this.transform.localScale.y;
    }


}
