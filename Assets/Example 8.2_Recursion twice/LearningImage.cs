using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningImage : MonoBehaviour
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
        //PaintMultipleCircles();

        centersX = new float[] { width * 0.15f, width * 0.3f, width * 0.7f };
        centersY = new float[] { height * 0.23f, height * 0.4f, height * 0.5f };
    }

    void Update()
    {
        PaintMultipleCirclesMoveRandom();
    }

    void PaintMultipleCirclesMoveRandom()
    {
        for (int i = 0; i < centersX.Length; i++)
        {
            Vector2 random = Random.insideUnitCircle;
            random.Normalize();
            random *= 10;

            centersX[i] += random.x;
            centersY[i] += random.y;
        }

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float distance = 100000;

                for (int i = 0; i < centersX.Length; i++)
                {

                    float dx = Mathf.Abs(centersX[i] - x);
                    float dy = Mathf.Abs(centersY[i] - y);

                    float tempDistance = Mathf.Sqrt(dx * dx + dy * dy);

                    if (tempDistance < distance) distance = tempDistance;
                }

                image.SetPixel(x, y,
                    distance < width * 0.1f ? Color.black : Color.white
                    );
            }
        }

        image.Apply();
    }

    void PaintMultipleCirclesMove()
    {
        for (int i = 0; i < centersX.Length; i++)
        {
            centersX[i] += Time.time * 25;
        }

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float distance = 100000;

                for (int i = 0; i < centersX.Length; i++)
                {

                    float dx = Mathf.Abs(centersX[i] - x);
                    float dy = Mathf.Abs(centersY[i] - y);

                    float tempDistance = Mathf.Sqrt(dx * dx + dy * dy);

                    if (tempDistance < distance) distance = tempDistance;
                }

                image.SetPixel(x, y,
                    distance < width * 0.1f ? Color.black : Color.white
                    );
            }
        }

        image.Apply();
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

                    float tempDistance = Mathf.Sqrt(dx * dx + dy * dy);

                    if (tempDistance < distance) distance = tempDistance;
                }

                Color color = distance < width * 0.1f ? Color.black : Color.white;

                image.SetPixel(x, y, color);
            }
        }

        image.Apply();
    }

    void PaintDitheredLinearGradient()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float f = 1 - (float)y / (float)height;
                float r = Random.value;

                Color color = f > r ? Color.black : Color.white;

                image.SetPixel(x, y, color);
            }
        }

        image.Apply();
    }

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

    void PaintSquare()
    {
        int centerX = width / 2;
        int centerY = height / 2;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float dx = Mathf.Abs(centerX - x);
                float dy = Mathf.Abs(centerY - y);

                // float distance = Mathf.Sqrt(dx * dx + dy * dy);

                Color color;

                if (dx < width / 3 && dy < width / 3)
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
