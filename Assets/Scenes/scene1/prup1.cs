using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prup1 : MonoBehaviour
{
    public GameObject open;
    public GameObject close;
    public GameObject key2;
    public bool test;
    public bool test2;
    public GameObject dooropen;
    public GameObject doorclose;
    public float audioVolume = 1.0f;
    private AudioSource audioSource;
    public AudioClip jump;
    public AudioClip take;
    public AudioClip door;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        UpdateVolume();
    }

    // Update is called once per frame
  
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
        if (other.name == "key2")
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
            SceneManager.LoadScene("New Scene");
        }
    }

}
