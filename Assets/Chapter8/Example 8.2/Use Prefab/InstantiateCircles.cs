// Instantiates 10 copies of prefab each 2 units apart from each other

using UnityEngine;
using System.Collections;

public class InstantiateCircles : MonoBehaviour
{
    public Transform prefab;

    float nextPosition;
    float nextRadius;
    float radius = 5f;

    //scale the instantiated circle to half
    Vector3 shrinkCircle=new Vector3 (0.5f,0.5f,0);
   
    
    void Start()
    {
        instantiateNextCircles();
        
    }

    public void instantiateNextCircles()
    {
        for (int i = 0; i < 10; i++)
        {
            nextPosition += nextRadius;

            var instantiatedPrefab_Right = Instantiate(prefab, new Vector3(nextPosition + radius / 2, 0, 0), Quaternion.identity);

            instantiatedPrefab_Right.transform.localScale = shrinkCircle;

           
        }

        var instantiatedPrefab_Left = Instantiate(prefab, new Vector3(nextPosition - radius / 2, 0, 0), Quaternion.identity);
        instantiatedPrefab_Left.transform.localScale = shrinkCircle;


    }



}