using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Flickering : MonoBehaviour
{
    Light2D Light;
    public float Base = 0.065f;
    public float Multiplier = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Light = GetComponent<Light2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //float Flicker = (Mathf.Sin(Time.time) / 2f) + 0.5f;

        float Flicker = Time.deltaTime * Multiplier * 10;

        Light.intensity = Base + Flicker;

    }

}
