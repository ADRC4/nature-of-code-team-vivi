using UnityEngine;
using System.Collections;

public class MultipleSineWave : MonoBehaviour
{
    int amplitude = 1;
    int amplitude2 = 2;

    int numberOfDots = 10;
    int numberOfDots2 = 5;

    public GameObject[] waveDots;
    public GameObject waveDotPrefab;

    public GameObject[] waveDots2;
    public GameObject waveDotPrefab2;

    //float factor = 0.01f;

    //private object sineWave;

    float speed = 1f;
    float speed2 = 0.5f;

    float Period = 2 * Mathf.PI;
    float Period2 = Mathf.PI;
   

    bool animate = true;


    void Start()
    {
        // re-initilaze array to get correct size
        waveDots = new GameObject[numberOfDots];

     

        for (int i = 0; i < numberOfDots; i++)
        {
            waveDots[i] = Instantiate(waveDotPrefab, new Vector3(0, i, 0), Quaternion.identity) as GameObject;

        }


        waveDots2 = new GameObject[numberOfDots2];

        for(int i = 0; i < numberOfDots2; i++)
        {
            waveDots2[i] = Instantiate(waveDotPrefab2, new Vector3(0, i, 0), Quaternion.identity) as GameObject;
        }
        
    }

    void Update()
    {
        // move the prefab clones as a sine wave
        for (int i = 0; i < numberOfDots; i++)
        {
            float functionXvalue = i * Period / numberOfDots;
            if (animate)
            {
                //Vector3 position = waveDots[i].transform.position;
                //position.y  = Mathf.Sin(Time.time + i * factor) * amplitude;
                functionXvalue += Time.time * speed;
            }

            waveDots[i].transform.position = new Vector3(5+i - (numberOfDots / 2), ComputeFunction(functionXvalue) * amplitude, 0);

            
        }




        for (int i = 0; i < numberOfDots2; i++)
        {
            float functionXvalue2 = i * Period2 / numberOfDots2;
            if (animate)
            {
                functionXvalue2 += Time.time * speed2;
            }

            waveDots2[i].transform.position = new Vector3(i  - (numberOfDots2 / 2)-5, ComputeFunction(functionXvalue2) * amplitude2, 0);
        }

    }

    float ComputeFunction(float x)
    {
        return Mathf.Sin(x);
    }
    
}