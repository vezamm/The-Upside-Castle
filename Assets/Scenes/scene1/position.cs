using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class position : MonoBehaviour
{
    public Health healthscript;

    public GameObject open;
    public GameObject close;
    public GameObject key2;
    
    
    private bool rotated = false;
    public bool test;
    public bool test2;
    public GameObject dooropen;
    public GameObject doorclose;
    public float audioVolume = 1.0f;
    private AudioSource audioSource;
    public AudioClip jump;
    public AudioClip take;
    public AudioClip door;
    

    void Start()
    {
        
        open.gameObject.SetActive(false); 
        key2.gameObject.SetActive(false);
        dooropen.gameObject.SetActive(false);
        audioSource = gameObject.AddComponent<AudioSource>();
        
        UpdateVolume(); // Set the initial volume

        // Subscribe to the onValidate callback to detect changes in the Inspector


    }

   
   /* void OnPlayModeStateChanged(UnityEditor.PlayModeStateChange state)
    {
        if (state == UnityEditor.PlayModeStateChange.EnteredEditMode || state == UnityEditor.PlayModeStateChange.EnteredPlayMode)
        {
            UpdateVolume();
        }
    }*/

    void UpdateVolume()
    {
        audioSource.volume = audioVolume;
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "Key")
        {
            audioSource.clip = take;
            audioSource.Play();
            Destroy(other.gameObject);
            Debug.Log("Key Collected!");
            test = true;
        }

        if (other.name == "close" && test == true)
        {
            audioSource.clip = take;
            audioSource.Play();
            open.gameObject.SetActive(true);
            close.gameObject.SetActive(false);
            key2.gameObject.SetActive(true); 
        }
        if (other.name =="key2")
        {
            audioSource.clip = take;
            audioSource.Play();
            Destroy(other.gameObject);
            test2 = true;
        }
        if (other.name == "doorclose" && test2 == true)
        {
            audioSource.clip = door;
            audioSource.Play();
            dooropen.gameObject.SetActive(true);
            doorclose.gameObject.SetActive(false);
        }
        if (other.name == "dooropen")
        {
             SceneManager.LoadScene("Scene2");
        }

        if (other.CompareTag("heart"))
        {
            Destroy(other.gameObject);
            if (healthscript.health == healthscript.NumOfhearts)
            {
                healthscript.health += 1;
                healthscript.NumOfhearts += 1;
            }
            else if (healthscript.health < healthscript.NumOfhearts)
            {
                healthscript.health += 1;
            }

            

        }
    }

     
}



