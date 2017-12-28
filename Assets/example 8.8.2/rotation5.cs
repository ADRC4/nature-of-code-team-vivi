using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation5 : MonoBehaviour {

    float angle;




    public void growbranches5(int index)
    {
        

        angle = Random.Range(-90, 90);

        this.transform.rotation *= Quaternion.Euler(0, 0, angle * ((index * 2) - 1));




    }
}
