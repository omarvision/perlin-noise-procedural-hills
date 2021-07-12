using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinBouncingCube : MonoBehaviour
{
    public float elapsedTime = 0f;
    public float perlinNoise = 0f;
    public float multiplier = 0f;

    private void Update()
    {
        elapsedTime = Time.time;
        perlinNoise = Mathf.PerlinNoise(elapsedTime, 0);  // value between 0..1

        this.transform.position = new Vector3(this.transform.position.x, perlinNoise * multiplier, transform.position.z);
    }
}
