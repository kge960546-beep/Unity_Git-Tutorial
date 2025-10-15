using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;


public class StreetLamp : MonoBehaviour
{    
    private Light2D light2D;
    private float baseIn;
    void Start()
    {
        light2D = GetComponentInChildren<Light2D>();
    }

    void Update()
    {
        float flicker = Mathf.PerlinNoise(Time.time * 3.0f, 0.0f);
        light2D.intensity = baseIn * Mathf.Lerp(0.8f, 1.1f, flicker);
    }
}
