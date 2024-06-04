using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class props : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Key1;
    public GameObject Key2;
    public GameObject chestopen;
    public GameObject chestclose;
    public GameObject Dooropen;
    public GameObject Doorclose;
    public GameObject leverclose;
    public GameObject Leveropen;
    public GameObject opengateddoor;
    public GameObject closegateddoor;
    private bool havekey;
    private bool havekey2;
    private AudioSource audioSource;
    public AudioClip opengate;
    public AudioClip take;

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
        if (other.name == "Key1")
        {
            audioSource.clip = take;
            audioSource.Play();
            Destroy(other.gameObject);
            Debug.Log("Key Collected!");
            havekey = true;
        }

        if (other.name == "close" && havekey == true)
        {
            audioSource.clip = take;
            audioSource.Play();
            chestopen.gameObject.SetActive(true);
            chestclose.gameObject.SetActive(false);
            Key2.gameObject.SetActive(true);
        }
        if (other.name == "key2")
        {
            audioSource.clip = take;
            audioSource.Play();
            Destroy(other.gameObject);
            havekey2 = true;
        }
        if (other.name == "enddoorclose" && havekey2 == true)
        {
            //audioSource.clip = door;
            //audioSource.Play();
            Dooropen.gameObject.SetActive(true);
            Doorclose.gameObject.SetActive(false);
        }
        if (other.name == "leverclose")
        {
            leverclose.gameObject.SetActive(false);
            opengateddoor.gameObject.SetActive(true);
            Leveropen.gameObject.SetActive(true);
            closegateddoor.gameObject.SetActive(false);
            if (audioSource != null)
            {
                audioSource.clip = opengate;
                audioSource.Play();
            }
        }
        if (other.name == "enddooropen" )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if (other.name == "firstdoor"&& Input.GetKey(KeyCode.E))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
