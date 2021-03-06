﻿// Instantiates 10 copies of prefab each 2 units apart from each other

using UnityEngine;
using System.Collections;

public class InstantiateCircles : MonoBehaviour
{
    public Transform prefab;

    float nextPosition = 0;
    float diameter = 5f;
    float nextDistance = 2.5f;
    float FirstMove = 0;
    float FirstPos;
    //scale the instantiated circle to half
    Vector3 shrinkCircle=new Vector3 (0.5f,0.5f,0);
   
    
    void Start()
    {
        instantiateNextCircles();
        
    }

    public void instantiateNextCircles()
    {
        for (int i = 0; i < 3; i++)
        {
            //nextDistance /= nextDistance / 2;
            //nextPosition = diameter / 2;
            FirstMove += FirstMove + diameter / 2f;
            
            var instantiatedPrefab_Right = Instantiate(prefab, new Vector3(FirstPos, 0, 0), Quaternion.identity);

            instantiatedPrefab_Right.transform.localScale = shrinkCircle;

           
        }

        //var instantiatedPrefab_Left = Instantiate(prefab, new Vector3(nextPosition - radius / 2, 0, 0), Quaternion.identity);
        //instantiatedPrefab_Left.transform.localScale = shrinkCircle;


    }



}