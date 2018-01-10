using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCircles_1 : MonoBehaviour
{
    Texture2D image;
    int width;
    int height;

    float[] centersX;
    float[] centersY;

    void Start()
    {
        width = Camera.main.pixelWidth;
        height = Camera.main.pixelHeight;
        image = new Texture2D(width, height);

        centersX = new float[] { width * 0.5f };
        centersY = new float[] { height * 0.5f};
    }

    void Update()
    {
            //for (float d = Mathf.Sqrt(width * width + height * height); d > 0.1 * height; d *= 2f)
            PaintCircle();
    }

    void PaintCircle()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {

                float distance = 100000;

                for (int i = 0; i < centersX.Length; i++)
                {
                    float dx = Mathf.Abs(centersX[i] - x);
                    float dy = Mathf.Abs(centersY[i] - y);

                    //define radius
                    float tempDistance = Mathf.Sqrt(dx * dx + dy * dy);
                   // tempDistance = tempDistance * 2f;
                    //prevent it become endless 
                    if (tempDistance < distance) distance = tempDistance;
                }

                //when the 2 conditions are both true, paint black, else transparent
                Color color = distance < width * 0.1f && distance > width * 0.09f ? Color.black : Color.clear;

               // mySecondaryCamera.clearFlags = CameraClearFlags.Nothing;

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
