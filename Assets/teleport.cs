using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
  
    private AudioSource audioSource;
    public AudioClip respawn;
    public Transform respawnPoint;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // If there's no AudioSource component on this GameObject, add one.
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "player") // Check for collision with the player
        {
            if (audioSource != null)
            {
                audioSource.clip = respawn;
                audioSource.Play();
            }
            else
            {
                Debug.LogError("AudioSource not found on " + gameObject.name);
            }

            // Respawn the player at the defined respawn point
            other.transform.position = respawnPoint.position;
        }
    }
}
