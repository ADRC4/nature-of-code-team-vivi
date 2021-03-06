﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintCircles_5 : MonoBehaviour
{
    Texture2D image;
    int width;
    int height;

    float[] centersX;
    float[] centersY;
    //float dx;
    //float dy;
    //float tempDistance;
    float OldRadius;
    float dxLeft;
    float tempDistanceLeft;

    void Start()
    {
        width = Camera.main.pixelWidth;
        height = Camera.main.pixelHeight;
        image = new Texture2D(width, height);

        centersX = new float[] { width * 0.5f };
        centersY = new float[] { height * 0.5f };
    }


    void Update()
    {
        if (OldRadius < 0.01f * height)
        {
            for (int i = 0; i < 10; i++)
            {
                PaintCircle(width * 0.5f, height * 0.5f, Mathf.Sqrt(width * width + height * height) * 0.5f);

            }
        }

        //for (float d = OldRadius; d >= 0.01f * height; d *= 0.75f)

        for (int i = 0; i < 10; i++)
        {
            PaintCircle(width * 0.5f - Mathf.Sqrt(width * width + height * height) * 0.25f, height * 0.5f, Mathf.Sqrt(width * width + height * height) * 0.25f);
            PaintCircle(width * 0.5f + Mathf.Sqrt(width * width + height * height) * 0.25f, height * 0.5f, Mathf.Sqrt(width * width + height * height) * 0.25f);
        }


    }


    void PaintCircle(float dx, float dy, float thisRadius)
    {
        OldRadius = OldRadius*0.5f;
        thisRadius = OldRadius;
        
        //Radius can not bigger than 100000
        float distance = 100000;

        //Circle can not wider than screen's width
        for (int x = 0; x < width; x++)
        {
            //Circle can not higher than screen's height
            for (int y = 0; y < height; y++)
            {
                
                
                for (int i = 0; i < centersX.Length; i++)
                {
                    //define centerPosition(dx,dy)
                    dx = Mathf.Abs(centersX[i] - x);
                    dy = Mathf.Abs(centersY[i] - y);

                    //define radius
                    thisRadius = Mathf.Sqrt(dx * dx + dy * dy);

                    //prevent it become endless 
                    if (thisRadius < distance) distance = thisRadius;
                }

                //define stroke width
                //when the 2 conditions are both true, paint black, else transparent
                Color color = distance < width * 0.1f && distance > width * 0.09f ? Color.black : Color.clear;

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
