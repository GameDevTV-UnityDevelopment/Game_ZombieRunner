using UnityEngine;

public class ClearArea : MonoBehaviour
{
    [SerializeField]
    private float timeSinceLastTrigger;

    private bool foundClearArea = false;


    private void Update()
    {
        timeSinceLastTrigger += Time.deltaTime; 

        if(timeSinceLastTrigger > 1f && Time.realtimeSinceStartup > 10f && !foundClearArea)
        {
            SendMessageUpwards("OnFindClearArea");

            foundClearArea = true;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag != "Player")
        {
            timeSinceLastTrigger = 0f;
        }
    }
}