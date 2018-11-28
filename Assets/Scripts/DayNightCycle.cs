using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("The number of minutes that pass per second, try 60")]
    [SerializeField]
    private float numberOfMinutesPerSecond = 60f;


    private void Update()
    {
        float angleThisFrame = (Time.deltaTime / 360) * numberOfMinutesPerSecond;

        transform.RotateAround(transform.position, Vector3.forward, angleThisFrame); 
    }
}