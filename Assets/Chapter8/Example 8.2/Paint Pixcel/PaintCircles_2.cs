using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCircles_2 : MonoBehaviour
{
    Texture2D image;
    int width;
    int height;

    float[] centersX;
    float[] centersY;
    float tempDistance = 1000;

    void Start()
    {
        width = Camera.main.pixelWidth;
        height = Camera.main.pixelHeight;
        image = new Texture2D(width, height);

        //potisions of circle center points
        //centersX = new float[] { width * 0.5f, width * 0.25f, width * 0.75f };
        //centersY = new float[] { height * 0.5f, height * 0.5f, height * 0.5f };

        centersX = new float[] { width * 0.5f };
        centersY = new float[] { height * 0.5f };
    }

    void Update()
    {
        //PaintCircle(width * 0.5f, height * 0.5f, width * 0.1f);
        // PaintCircle(centersX, centersY, float tempDistance);
        PaintCircle(centersX, centersY, tempDistance);

    }



    void PaintCircle(float[] centersX2, float[] centersY2, float tempDistance)
    {
        centersX2 = new float[] { width * 0.5f };
        centersY2 = new float[] { height * 0.5f };
        tempDistance = width * 0.5f;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {

                float distance = 100000;


                /*for (int i = 0; i < centersX2.Length; i++)
                {
                    //CircleCenterPosition(dx,dy)
                    //float dx = Mathf.Abs(centersX2[i] - x);
                    //float dy = Mathf.Abs(centersY2[i] - y);
                    //float tempDistance2 = tempDistance;
                    //float tempDistance2 = Mathf.Sqrt(dx * dx + dy * dy);
                    
                    if (tempDistance < distance) distance = tempDistance;
                }
                */




                if (tempDistance < width * 0.5f)
                {
                    PaintCircle(centersX2, centersY2, tempDistance);
                    tempDistance = tempDistance * 0.75f;
                }


                //Paint area to black color if the distance is both bigger than 0.09*Width and samller than 0.1*width
                //The weight of the circle is (0.1-0.09)*width；Radius(tempDistance) is 0.1*width
                // Color color = distance < width * 0.1f && distance > width * 0.09f ? Color.black : Color.white;
                Color color = distance < width * 0.1f && distance > width * 0.09f ? Color.black : Color.white;
                image.SetPixel(x, y, color);
            }
        }

        image.Apply();
    }



    //Do RecursionTwice of PaintCircel
    //dx = dx - tempDistance / 2f;

    void PaintLinearGradient()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {

                float f = 1 - (float)y / (float)height;

                Color color = Color.HSVToRGB(0, 0, f);

                image.SetPixel(x, y, color);
            }
        }

        image.Apply();
    }



    void DitheredRadialGradient()
    {
        int centerX = width / 2;
        int centerY = height / 2;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float dx = centerX - x;
                float dy = centerY - y;
                float distance = Mathf.Sqrt(dx * dx + dy * dy);

                float f = Mathf.InverseLerp(0, width / 2, distance);
                float r = Random.value;

                Color color;

                if (r > f)
                {
                    color = Color.black;
                }
                else
                {
                    color = Color.white;
                }

                image.SetPixel(x, y, color);
            }
        }

        image.Apply();
    }


    void OnGUI()
    {
        var rectangle = new Rect(0, 0, width, height);
        GUI.DrawTexture(rectangle, image);
    }
}
