using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RespawnTrigger : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip respawn;
    public Transform respawnPoint;
    public Health healthscript;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // If there's no AudioSource component on this GameObject, add one.
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    public void OnTriggerStay2D(Collider2D other) 
    { 
   
        if (other.CompareTag("Player")) // Check for collision with the player
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
            healthscript.health -=1;
        }
    }
}
