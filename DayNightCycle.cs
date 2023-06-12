using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public Light directionalLight; // Directional Light
    public float dayDuration = 120f; // Duration of a day in seconds
    public float maxIntensity = 1f; // Maximum light intensity during the day
    public float minIntensity = 0f; // Minimum light intensity during the night
    public Color dayColor; // Color of the light during the day
    public Color nightColor; // Color of the light during the night

    private float timeOfDay = 0f; // Elapsed time of the day in seconds

    private void Update()
    {
        // Update the time of day
        UpdateTimeOfDay();

        // Update the lighting
        UpdateLighting();
    }

    private void UpdateTimeOfDay()
    {
        // Update the time of day
        timeOfDay += Time.deltaTime;
        if (timeOfDay > dayDuration)
        {
            timeOfDay -= dayDuration;
        }
    }

    private void UpdateLighting()
    {
        // Update the light intensity and color
        float intensity = Mathf.Lerp(minIntensity, maxIntensity, Mathf.Abs((timeOfDay / dayDuration) - 0.5f) * 2f);
        directionalLight.intensity = intensity;

        Color lightColor = Color.Lerp(nightColor, dayColor, Mathf.Abs((timeOfDay / dayDuration) - 0.5f) * 2f);
        directionalLight.color = lightColor;
    }
}
