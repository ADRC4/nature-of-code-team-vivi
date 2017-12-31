using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation6 : MonoBehaviour {

    float angle;
    public float scale=1.0f;


    private void Update()
    {
        float n = Random.Range(0.0f, 1.0f);
        //float n = Mathf.PerlinNoise(1.0f, 0.0f);

        angle = (2 *n - 1) * 30;
        this.transform.rotation = Quaternion.Euler(0, 0, angle);

    }




    //public void growbranches6(int index)
    //{

    //    angle = 60 * Mathf.PerlinNoise(Time.deltaTime * scale, 0.0f);


    //    this.transform.rotation *= Quaternion.Euler(0, 0, angle * ((index * 2) - 1));


    //}
}
