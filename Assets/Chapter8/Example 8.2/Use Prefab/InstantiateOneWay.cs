// Instantiates 10 copies of prefab each 2 units apart from each other

using UnityEngine;
using System.Collections;



public class InstantiateOneWay : MonoBehaviour
{
    public Transform prefab;
    float radius = 5f;

    void Start()
    {
        for (int i = 1; i < 10; i++)
        {
            //Instantiate Circles to right
             Instantiate(prefab, new Vector3(i * radius/2.0F, 0, 0), Quaternion.identity);
        }
    }
}