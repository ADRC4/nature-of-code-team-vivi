using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRect : MonoBehaviour {

    public GameObject RectPrefab;
    private int rectCount = 0;
    public float secondsBetweenSpawns = 1;
    float nextSpawnTime;

    int rectMaxCount = 20;

    //private List<GameObject> prefab_list = new List<GameObject>() ;

    //Vector2 spawnSizeMin = new Vector2(5, 5);
    //Vector2 spawnSizeMax = new Vector2(10, 10);
    public Vector2 spawnSizeMinMax;

    Vector2 screenHalfSizeWorldUnits;

	void Start ()
    {
        screenHalfSizeWorldUnits = new Vector2(Camera.main.aspect * Camera.main.orthographicSize,Camera.main.orthographicSize );
        InvokeRepeating("Spawn", 0, secondsBetweenSpawns);
	}

    // Update is called once per frame
    void Update()
    {
        //if(.Count >= rectMax)
        //{
        //    return;
        //}

        //if (Time.time > nextSpawnTime)
        //{
        //    nextSpawnTime = Time.time + secondsBetweenSpawns;

        //    float spawnSize = Random.Range(spawnSizeMinMax.x, spawnSizeMinMax.y);
        //    Vector2 spawnPosition = new Vector2(Random.Range(-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x), screenHalfSizeWorldUnits.y);
        //    GameObject newRect = (GameObject)Instantiate(RectPrefab, spawnPosition, Quaternion.identity);
        //    newRect.transform.localScale = Vector2.one * spawnSize;
        //}
    }

    void Spawn()
    {
        rectCount++;
        if(rectCount >= rectMaxCount)
        {
            CancelInvoke("Spawn");
        }

        if (Time.time > nextSpawnTime)
        {
            nextSpawnTime = Time.time + secondsBetweenSpawns;

            float spawnSize = Random.Range(spawnSizeMinMax.x, spawnSizeMinMax.y);
            Vector2 spawnPosition = new Vector2(Random.Range(-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x), screenHalfSizeWorldUnits.y);
            GameObject newRect = (GameObject)Instantiate(RectPrefab, spawnPosition, Quaternion.identity);
            newRect.transform.localScale = Vector2.one * spawnSize;
        }
    }
}
