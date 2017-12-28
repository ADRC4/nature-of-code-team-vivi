using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation2 : MonoBehaviour {

    public void growbranches2(int index)
    {
        this.transform.rotation *= Quaternion.Euler(0, 0, 30 * ((index * 2) - 1));
    }
}
