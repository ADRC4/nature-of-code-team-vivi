using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBaton : MonoBehaviour
{
    Texture2D image;

    int width;
    int height;

    int radius = 10;

    float rotateAngle = 20f;
    float rotateSpeed = 1f;
    float rotateAcceleration = 0.001f;


    Vector2 point1 = new Vector2(100, 100);//new Vector3(100, 100, 0);
    Vector2 point2 = new Vector2(200, 200);//new Vector3(200, 200, 0);
    Vector2 center = Vector3.zero;

    void Start()
    {
        center = (point1 + point2) / 2;
        //Vector3 center = new Vector3(150,150,0);
        width = Camera.main.pixelWidth;
        height = Camera.main.pixelHeight;

        image = new Texture2D(width, height);

        StartCoroutine(Rotation());
    }

    void Update()
    {
        PaintBaton();
    }

    //float rotateAngle = 20f;
    //float rotateSpeed = 1000;

    IEnumerator Rotation()
    {
        while (true)
        {
            point1 = PointRotate(center, point1, rotateAngle);
            point2 = PointRotate(center, point2, rotateAngle);
            rotateSpeed += rotateAcceleration * Time.deltaTime;
            yield return new WaitForSeconds(1 / rotateSpeed);
        }
    }
    private Vector2 PointRotate(Vector2 center, Vector2 p1, float angle)
    {
        Vector2 tmp = new Vector2();
        float angleHude = angle * Mathf.PI / 180;
        float x1 = (p1.x - center.x) * Mathf.Cos(angleHude) + (p1.y - center.y) * Mathf.Sin(angleHude) + center.x;
        float y1 = -(p1.x - center.x) * Mathf.Sin(angleHude) + (p1.y - center.y) * Mathf.Cos(angleHude) + center.y;
        tmp.x = x1;
        tmp.y = y1;
        return tmp;

    }

    void PaintBaton()
    {
        Color _color = Color.white;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector2 circlePoint = new Vector2(x, y);

                //Color _color = (Vector2 .Distance(circlePoint,point1 ) <= radius) || (Vector2.Distance(circlePoint ,point2)<=radius ) ? Color.black : Color.white;
                if (Vector2.Distance(circlePoint, point1) <= radius || Vector2.Distance(circlePoint, point2) <= radius)
                {
                    _color = Color.black;
                }
                else
                {
                    _color = Color.white;
                }

                //image.SetPixel(x, y, _clolor);

                image.SetPixel(x, y, _color);
            }
        }

        Vector2 line = point2 - point1;
        float dx = Mathf.Abs(point1.x - point2.x);
        float dy = Mathf.Abs(point1.y - point2.y);

        float k = (point1.y - point2.y) / (point1.x - point2.x);
        float b = point1.y - k * point1.x;

        int minValue;
        int maxValue;
        if (dx > dy)
        {
            minValue = (int)Mathf.Min(point1.x, point2.x);
            maxValue = (int)Mathf.Max(point1.x, point2.x);
            for (int x = minValue; x < maxValue; x++)
            {
                image.SetPixel(x, (int)(k * x + b), Color.black);
            }
        }
        else
        {
            minValue = (int)Mathf.Min(point1.y, point2.y);
            maxValue = (int)Mathf.Max(point1.y, point2.y);
            for (int y = minValue; y < maxValue; y++)
            {
                image.SetPixel((int)((y - b) / k), y, Color.black);
            }
        }

        image.Apply();
    }

    private void OnGUI()
    {
        var square = new Rect(0, 0, width, height);
        GUI.DrawTexture(square, image);
    }
}
