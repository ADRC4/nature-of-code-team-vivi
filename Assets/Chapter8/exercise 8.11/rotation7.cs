using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation7 : MonoBehaviour {



    public void growbranches7(RecursiveBundle bundle)
    {


       

        this.transform.rotation *= Quaternion.Euler(0, 0, 30 * ((bundle.Index * 2) - 1));




    }
}
