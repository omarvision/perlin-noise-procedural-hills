using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinCubeGen1d : MonoBehaviour
{
    public float perlinNoise = 0f;
    public float refinement = 0f;
    public float multiplier = 0f;
    public int cubes = 0;
    public bool quantize = false;

    private void Start()
    {
        for (int i = 0; i < cubes; i++)
        {           
            perlinNoise = Mathf.PerlinNoise(i * refinement, 0);
            GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
            if (quantize == false)
            {
                go.transform.position = new Vector3(i, perlinNoise * multiplier, 0);
            }
            else
            {
                go.transform.position = new Vector3(i, Mathf.RoundToInt(perlinNoise * multiplier), 0);
            }
        }
    }
}
