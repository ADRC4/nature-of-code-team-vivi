using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle_New : MonoBehaviour
{
    Texture2D image;
    int width;
    int height;

    float[] centersX;
    float[] centersY;

    // Use this for initialization
    void Start ()
    {
		width =Camera.main.pixelWidth;
        height = Camera.main.pixelHeight;
        //PaintMultipleCircles();

        //define circles' center
        float[] centersX = new float[] { width * 0.5f, width * -0.25f, width * 0.25f };
        float[] centersY = new float[] { height * 0.5f, height * 0.5f, height * 0.5f };

    }

    private void Update()
    {
        PaintMultipleCircles();
    }

    void PaintMultipleCircles()
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

                    //define radius “tempDistance”
                    float tempDistance = Mathf.Sqrt(dx * dx + dy * dy);

                    if (tempDistance < distance) distance = tempDistance;
                }

                Color color = distance < width * 0.1f ? Color.black : Color.white;

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
