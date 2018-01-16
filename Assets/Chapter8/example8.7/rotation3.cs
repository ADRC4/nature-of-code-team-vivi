using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation3 : MonoBehaviour
{
    float angle;




    public void growbranches3(int index)
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        angle = 90 * mousePosition.x /10;

        this.transform.rotation *= Quaternion.Euler(0, 0, angle * ((index * 2) - 1));




    }
}
