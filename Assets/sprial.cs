using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sprial : MonoBehaviour {

    Texture2D image;
    int width = 600;
    int height = 600;
    float r = 0f;
    float theta = 0f;
    int size;
    
	void Start ()
    {
        //r += 0.05f;
        //theta += 0.01f;
        //float x = r * Mathf.Cos(theta);
        //float y = r * Mathf.Sin(theta);

        image = new Texture2D(width, height);

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float dx = 200 - x;
                float dy = 200 - y;
                float distance = Mathf.Sqrt(dx * dx + dy * dy);

                Color color;
                if (distance > 100)
                {
                    color = Color.white;
                }
                else
                {
                    color = Color.black;
                }
                image.SetPixel(x, y, color);
            }
        }
    
        image.Apply();
    }

    void Update ()
    {
        
    }

    private void OnGUI()
    {
        var rectangle = new Rect(0, 0, width, height);
        GUI.DrawTexture(rectangle, image);
    }
}
