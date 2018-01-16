using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{

    public void growbranches(int index)
    {
        this.transform.rotation *= Quaternion.Euler(0,0,30*((index*2)-1));
    }


}
