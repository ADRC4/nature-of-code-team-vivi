using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    [SerializeField]
    float rotateSpeed = 1.0f;


    private Transform ThisTransform = null;
    //float moveSpeed = 2f;

    void Start()
    {
        transform.Rotate(transform.forward , Random.Range(0F, 360F));
        StartCoroutine(Spin());
        //StartCoroutine(MoveForward());

        //ThisTransform = GetComponent<Transform>();
        //StartCoroutine(Move());
    }



    IEnumerator Spin()
    {
        while (true)
        {
            transform.Rotate(transform.forward , 360 * rotateSpeed * Time.deltaTime);
            //transform.Translate(Vector3.MoveTowards * moveSpeed * Time.deltaTime);
            yield return 0;
        }
    }

    //IEnumerator Move()
    //{
    //    while (true)
    //    {
    //        ThisTransform.position += ThisTransform.up * moveSpeed * Time.deltaTime;
    //        yield return 0;
    //    }
    //}

    //IEnumerator MoveForward()
    //{
    //    while (true)
    //    {
    //        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    //        yield return 0;
    //    }

    //}

}
