// Instantiates 10 copies of prefab each 2 units apart from each other

using UnityEngine;
using System.Collections;

public class InstantiateCirclesTest2_Oneway : MonoBehaviour
{
    public Transform prefab;
    float diameter=5f;

    //scale the instantiated circle to half
    Vector3 shrinkCircle=new Vector3 (0.5f,0.5f,0);
   
    
    void Start()
    {
        instantiateNextCircles();
        
    }

    public void instantiateNextCircles()
    {
        for (int i = 1; i < 10; i++)
        {
            
            var instantiatedPrefab_Right = Instantiate(prefab, new Vector3(i* diameter / 2, 0, 0), Quaternion.identity);
            
            instantiatedPrefab_Right.transform.localScale = shrinkCircle;
            
        }

        //var instantiatedPrefab_Left = Instantiate(prefab, new Vector3(nextPosition - radius / 2, 0, 0), Quaternion.identity);
        //instantiatedPrefab_Left.transform.localScale = shrinkCircle;


    }



}