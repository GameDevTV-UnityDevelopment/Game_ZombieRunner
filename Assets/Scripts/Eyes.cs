using UnityEngine;

public class Eyes : MonoBehaviour
{
    private Camera eyes;
    private float defaultFieldOfView = 60f;


    private void Start()
    {
        eyes = GetComponent<Camera>();
        defaultFieldOfView = eyes.fieldOfView;
    }

    private void Update()
    {
        if (Input.GetButton("Zoom"))
        {
            eyes.fieldOfView = defaultFieldOfView / 1.5f;
        }
        else
        {
            eyes.fieldOfView = defaultFieldOfView;
        }
    }
}