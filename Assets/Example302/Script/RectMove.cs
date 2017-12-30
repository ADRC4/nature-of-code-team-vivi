using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectMove : MonoBehaviour
{

    private float movementDuration = 2.0f;
    private float waitBeforeMoving = 0.01f;
    private bool hasArrived = false;

    // Update is called once per frame
    void Update()
    {
        if (!hasArrived)
        {
            hasArrived = true;
            float randX = Random.Range(-10.0f, 10.0f);
            float randY = Random.Range(-5.0f, 5.0f);
            StartCoroutine(MoveToPoint(new Vector3(randX, randY, -1.504f)));
        }
    }

    private IEnumerator MoveToPoint(Vector3 targetPos)
    {
        float timer = 0.0f;
        Vector3 startPos = transform.position;

        while (timer < movementDuration)
        {
            timer += Time.deltaTime;
            float t = timer / movementDuration;

            t = t * t * t * (t * (6f * t - 15f) + 10f);
            transform.position = Vector3.Lerp(startPos, targetPos, t);

            yield return null;
        }

        yield return new WaitForSeconds(waitBeforeMoving);
        hasArrived = false;
    }
}
