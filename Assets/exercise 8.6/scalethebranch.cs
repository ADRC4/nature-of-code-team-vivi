using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalethebranch : MonoBehaviour
{

    public void growbranches(int index)
    {
        this.transform.localScale*= 0.7f;
    }

}
