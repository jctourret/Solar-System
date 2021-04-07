using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightChange : MonoBehaviour
{
    Light sunlight;
    float fluctuation = 0;
    float baseIntensity = 10;
    float multiplier = 5;
    void Start()
    {
        sunlight = GetComponent<Light>();
    }

    void Update()
    {
        fluctuation += Time.deltaTime;
        sunlight.intensity = Mathf.Sin(fluctuation)*multiplier+baseIntensity;
    }
}
