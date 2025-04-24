using UnityEngine;

public class PlayAudio : MonoBehaviour
{

    [SerializeField]
    AudioSource audioSource;
    [SerializeField]
    AudioClip audioClip;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayAudioOnce()
    {
        audioSource.PlayOneShot(audioClip);
    }

}
