using UnityEngine;

public class InnerVoice : MonoBehaviour
{
    [SerializeField]
    private AudioClip whatHappenSFX;

    [SerializeField]
    private AudioClip goodLandingAreaSFX;

    private AudioSource audioSource;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = whatHappenSFX;
        audioSource.Play();
    }

    private void OnFindClearArea()
    {
        audioSource.clip = goodLandingAreaSFX;
        audioSource.Play();

        Invoke("CallHelicopter", goodLandingAreaSFX.length);
    }

    private void CallHelicopter()
    {
        SendMessageUpwards("OnMakeInitialHelicopterCall");
    }
}