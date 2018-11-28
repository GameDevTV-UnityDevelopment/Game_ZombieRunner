using UnityEngine;

public class RadioSystem : MonoBehaviour
{
    [SerializeField]
    private AudioClip callHelicopterSFX;

    [SerializeField]
    private AudioClip callReplySFX;

    private AudioSource audioSource;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnMakeInitialHelicopterCall()
    {
        audioSource.clip = callHelicopterSFX;
        audioSource.Play();

        Invoke("HelicopterCallReply", callHelicopterSFX.length + 1f);
    }

    private void HelicopterCallReply()
    {
        audioSource.clip = callReplySFX;
        audioSource.Play();

        BroadcastMessage("OnDispatchHelicopter");
    }
}