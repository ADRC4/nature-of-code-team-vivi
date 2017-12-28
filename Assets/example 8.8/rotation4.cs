using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation4 : MonoBehaviour
{

    float angle;




    public void growbranches4(int index)
    {
        

        angle = Random.Range(0, 60);

        this.transform.rotation *= Quaternion.Euler(0, 0, angle * ((index * 2) - 1));




    }

}
