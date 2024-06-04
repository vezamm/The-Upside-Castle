using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;
    public Image bar;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
       // bar.SetEnable( false);
        // Set up any initial settings for the audio source, like setting the audio clip.
        // For example: audioSource.clip = yourAudioClip;
    }

    public void ToggleMusic()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Pause();
           // bar.SetEnable( true);


        }
        else
        {
            audioSource.Play();
           // bar.SetEnable (false);

        }
    }
}

