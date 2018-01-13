// Instantiates 10 copies of prefab each 2 units apart from each other

using UnityEngine;
using System.Collections;



public class ONEWAY : MonoBehaviour
{
    public Transform prefab;
    float diameter = 5f;

    Vector3 shrinkCircle = new Vector3(0.5f, 0.5f, 0);

    void Start()
    {
        
        for(int i=1; i<10; i++)
        {
            //Instantiate Circles to right
            var _TotalDistance = i * diameter / 2f;
            //_TotalDistance = _TotalDistance + 
            //var instantiatedPrefab_Right = Instantiate(prefab, new Vector3(0, 0, 0), Quaternion.identity);


            //instantiatedPrefab_Right.transform.localScale = shrinkCircle;

            //4 times recursion from 5 to 0.3125_to limit the loop
           /* for (int r = 5; r > 0.3; r *= 1 / 2) 
            {

                instantiatedPrefab_Right.transform.localScale = shrinkCircle;
                 i * radius / 2.0f
            }*/
        }
        
        
        
    }
    
}