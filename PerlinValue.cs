using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinValue : MonoBehaviour
{
    //Note:
    //  1. close PerlinPos values return close PerlinNoise values
    //  2. any two PerlinPos values will always return the same PerlinNoise values
    //  3. cannot pass in whole numbers, because will get back same value. must pass in decimal numbers to get different result.

    public Vector2 PerlinPos;
    public float PerlinNoise;

    private void Update()
    {
        PerlinNoise = Mathf.PerlinNoise(PerlinPos.x, PerlinPos.y);
    }
}
