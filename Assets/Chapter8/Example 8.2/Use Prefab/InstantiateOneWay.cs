// Instantiates 10 copies of prefab each 2 units apart from each other

using UnityEngine;
using System.Collections;



public class InstantiateOneWay : MonoBehaviour
{
    public Transform prefab;
    float radius=5f;
    
    Vector3 shrinkCircle = new Vector3(0.5f, 0.5f, 0);
    
    void Start()
    {
        Instantiate(2.5f);
    }

    void Instantiate(float e )
    {
        
        for (int r = 5; r > 0.3; r *= 1/2) //4 times recursion from 5 to 0.3125_to limit the loop
        {
            //Instantiate Circles to right
            var instantiatedPrefab_Right = Instantiate(prefab, new Vector3(e, 0, 0), Quaternion.identity);

            instantiatedPrefab_Right.transform.localScale = e*0.5f*shrinkCircle;
        }
      
        /*for (int d = 1; d < 10; d++)
        {
           Instantiate(e);
        }
        */
        
      
    }
}