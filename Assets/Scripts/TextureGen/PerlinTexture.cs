using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinTexture : TextureShader
{
    public float frequencyX = 1.0f;
    public float frequencyY = 1.0f;

    protected override Color GetColor(int x, int y)
    {
        float px = frequencyX * ((float)x / width);
        float py = frequencyY * ((float)y / height);

        float r = Mathf.PerlinNoise(px, py);

        return new Color(r, r, r, 1);
    }

/*    private void Update()
    {
        UpdateTexture();
    }*/
}
