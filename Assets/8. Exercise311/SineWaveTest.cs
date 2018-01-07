using UnityEngine;
using System.Collections;

public class SineWaveTest : MonoBehaviour
{
    int amplitude = 1;
    int amplitude2 = 2;

    int numberOfDots = 40;

    public GameObject[] waveDots;
    public GameObject waveDotPrefab;

    //float factor = 0.01f;

    //private object sineWave;

    float speed = 0.5f;
    float Period = 2 * Mathf.PI;
    float Period2 = Mathf.PI;
    float Period3 = 4 * Mathf.PI;
    float Period4 = Mathf.PI / 2;

    bool animate = true;


    void Start()
    {
        // re-initilaze array to get correct size
        waveDots = new GameObject[numberOfDots];

        // instantiate all prefab clones
        //for (int z = 0; z < numberOfDots; z++)
        //{

            for (int i = 0; i < 10; i++)
            {
                waveDots[i] = Instantiate(waveDotPrefab, new Vector3(0, 0, i  ), Quaternion.identity) as GameObject;

                for (int j = 10; j < 20; j++)
                {
                    waveDots[j] = Instantiate(waveDotPrefab, new Vector3(0, 0, j  ), Quaternion.identity) as GameObject;

                    for (int p = 20; p < 30; p++)
                    {
                        waveDots[p] = Instantiate(waveDotPrefab, new Vector3(0, 0, p), Quaternion.identity) as GameObject;

                        for(int q = 30;q < 40; q++)
                        {
                             waveDots[q] = Instantiate(waveDotPrefab, new Vector3(0, 0, q), Quaternion.identity) as GameObject;
                        }
                    }
                }
            }
        //}
    }

    void Update()
    {
        // move the prefab clones as a sine wave
        for (int i = 0; i < 10; i++)
        {
            float functionXvalue = i * Period / 10 ;
            if (animate)
            {
                //Vector3 position = waveDots[i].transform.position;
                //position.y  = Mathf.Sin(Time.time + i * factor) * amplitude;
                functionXvalue += Time.time * speed;
            }

            waveDots[i].transform.position = new Vector3(i - (numberOfDots  / 2), ComputeFunction(functionXvalue) * amplitude, 0);

                //floatObjectsLists[i].transform.position = new Vector3(i - (numberOfObjects / 2), ComputeFunction(functionXvalue) * amplitude, 0);

        for(int j = 10; j < 20; j++)
            {
                float functionXvalue2 = j * Period2 / 20;
                if(animate)
                {
                    functionXvalue2 += Time.time * speed;
                }

                waveDots[j].transform.position = new Vector3(j  - (numberOfDots  / 2) , ComputeFunction2(functionXvalue2) * amplitude2, 0);

                for(int p = 20; p < 30; p++)
                {
                    float functionaXvalue3 = p * Period3 / 30;
                    if(animate)
                    {
                        functionaXvalue3 += Time.time * speed;
                    }

                    waveDots[p].transform.position = new Vector3(p - (numberOfDots / 2), ComputeFunction(functionaXvalue3) * amplitude, 0);


                    for (int q = 30; q < 40; q++)
                    {
                        float functionXvalue4 = q * Period4 / 40;
                        if (animate)
                        {
                            functionXvalue4 += Time.time * speed;
                        }

                        waveDots[q].transform.position = new Vector3(q - (numberOfDots / 2), ComputeFunction2(functionXvalue4) * amplitude2, 0);
                    }
                }
            }
        }

    }

    float ComputeFunction(float x)
    {
        return Mathf.Sin(x);
    }
    float ComputeFunction2(float x)
    {
        return Mathf.Cos (x);
    }

}