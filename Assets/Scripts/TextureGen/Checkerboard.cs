using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkerboard : BaseTextureGenerator
{
    public Color color1 = Color.yellow;
    public Color color2 = Color.red;
    [Range(1, 32)]
    public int gridSize = 8;

    protected override void FillTexture(Color[] colors)
    {
        base.FillTexture(colors);

        int sizeX = width / gridSize;
        int sizeY = height / gridSize;

        for (int i = 0; i < width * height; i++)
        {
            int x = i % width;
            int y = i / width;

            int condition = (((x / sizeX) + (y / sizeY)) % 2);

            if (condition == 0)
                colors[i] = color1;
            else
                colors[i] = color2;
        }
    }

    /*private void Update()
    {
        UpdateTexture();
    }*/
}
