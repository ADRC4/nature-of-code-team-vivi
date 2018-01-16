using UnityEngine;
using System.Collections;

public class PerlinNoiseWave : MonoBehaviour
{
    int amplitude = 1;

    int numberOfDots = 50;

    public GameObject[] waveDots;
    public GameObject waveDotPrefab;

   
    float speed = 1f;
    float Period = 2 * Mathf.PI;
    
    bool animate = true;


    void Start()
    {
        
        waveDots = new GameObject[numberOfDots];

        for (int i = 0; i < numberOfDots; i++)
        {
            waveDots[i] = Instantiate(waveDotPrefab, new Vector3(0, i, 0), Quaternion.identity) as GameObject;

        }
        
    }

    void Update()
    {
        // move the prefab clones as a sine wave
        for (int i = 0; i < numberOfDots; i++)
        {
            float functionYvalue = i * Period  / numberOfDots;
            float functionXvalue = i - (numberOfDots / 2);
            if (animate)
            {
                //functionYvalue += Time.time * speed;
                float  ObjectsPositionHeight = Mathf.PerlinNoise(0f, Time.time *speed*functionYvalue);
                float objectPositionWidth = Mathf.PerlinNoise(Time.time *speed*functionXvalue, 0f);
                Vector3 objectPosition = transform.position;
                objectPosition.x = objectPositionWidth;
                objectPosition.y = ObjectsPositionHeight;

                waveDots[i].transform.position = new Vector3(objectPosition.x, objectPosition.y, 0f);
            }

            

           
        }

    }

    //float ComputeFunction(float x, float y)
    //{
    //    return Mathf.PerlinNoise(x, y);
    //}

}