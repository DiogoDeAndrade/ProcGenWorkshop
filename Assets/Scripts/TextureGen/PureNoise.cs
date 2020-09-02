using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PureNoise : BaseTextureGenerator
{
    public int seed;

    protected override void FillTexture(Color[] colors)
    {
        MyRndGenerator random = new MyRndGenerator(seed);

        for (int i = 0; i < width * height; i++)
        {
            float r = random.Range(0.0f, 1.0f);

            colors[i] = new Color(r, r, r, 1);
        }
    }
}
