// Instantiates 10 copies of prefab each 2 units apart from each other

using UnityEngine;
using System.Collections;

public class NewTest : MonoBehaviour
{
    public Transform prefab;

    float nextPosition;
    float NewPosition, PrevPosition;
    float nextRadius;
    float diameter = 5f;
    float FirstMove;
    //scale the instantiated circle to half
    Vector3 shrinkCircle = new Vector3(0.5f, 0.5f, 0);

    void Start()
    {
        instantiateNextCircles();

    }

    public void instantiateNextCircles()
    {
        //int max = 3;

        for (int i = 1; i < 10; i++)
        {
             //float Scale = 1/2;
             Vector3 Pos1 = new Vector3(diameter * (1/2 ^ i), 0, 0);

            //Pos1.x=diameter*[(1/2)^1+(1/2)^2+(1/2)^3+... ...+(1/2)^i];

            var instantiatedPrefab_Right = Instantiate(prefab, Pos1, Quaternion.identity);
             instantiatedPrefab_Right.transform.localScale = shrinkCircle / (2 ^ i);
        
            /*
             Vector3 Pos1 = new Vector3(diameter * 0.5f, 0, 0);
            var instantiatedPrefab_Right = Instantiate(prefab, Pos1, Quaternion.identity);
            instantiatedPrefab_Right.transform.localScale = shrinkCircle;

            Vector3 Pos2 = new Vector3(diameter * 0.75f, 0, 0);
            var instantiatedPrefab_Right2 = Instantiate(prefab, Pos2, Quaternion.identity);
            instantiatedPrefab_Right2.transform.localScale = shrinkCircle / 2;

            Vector3 Pos3 = new Vector3(diameter * 0.875f, 0, 0);
            var instantiatedPrefab_Right3 = Instantiate(prefab, Pos3, Quaternion.identity);
            instantiatedPrefab_Right3.transform.localScale = shrinkCircle / 4;
            */
            //instantiatedPrefab_Right.transform.position;

            //var instantiatedPrefab_Left = Instantiate(prefab, -Pos, Quaternion.identity);
            // instantiatedPrefab_Left.transform.localScale = shrinkCircle;
        }
        //var instantiatedPrefab_Left = Instantiate(prefab, new Vector3(nextPosition - radius / 2, 0, 0), Quaternion.identity);
        //instantiatedPrefab_Left.transform.localScale = shrinkCircle;
    }
}