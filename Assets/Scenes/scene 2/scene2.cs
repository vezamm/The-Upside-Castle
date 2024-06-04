using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene2 : MonoBehaviour
{
    
    public bool testsc2 = false;
    public bool testkey = false;
    public bool ftest = false;
    public GameObject fhandle;
    public GameObject handle;
    public GameObject chessc;
    public GameObject chesso;
    public GameObject keyf;
    public GameObject doorsc3;
    public GameObject key1;
    public GameObject doorsch;
    public GameObject doour;
    private AudioSource audioSource;
    public AudioClip take;
    public AudioClip door;
    public AudioClip opengate;

    // Start is called before the first frame update
    void Start()
    {
       
        
        
        
        fhandle.gameObject.SetActive(true);
        chessc.gameObject.SetActive(true);
        chesso.gameObject.SetActive(true);
        keyf.gameObject.SetActive(false);
        key1.gameObject.SetActive(true);
        audioSource = gameObject.AddComponent<AudioSource>();


    }

    // Update is called once per frame
    
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "doorsch" && testsc2 == true)
        {
            SceneManager.LoadScene("hideen room");
        }
        if (other.name == "door2")
        {
            SceneManager.LoadScene("scene2.1");
        }
        if (other.name == "fhandle" )
        {
            audioSource.clip = opengate;
            audioSource.Play();
            fhandle.gameObject.SetActive(false);
            handle.gameObject.SetActive(true);
            doorsch.gameObject.SetActive(true);
            doour.gameObject.SetActive(false);
            testsc2 = true;
            
        }
        if (other.name == "key1" )
        {
            audioSource.clip = take;
            audioSource.Play();
            key1.gameObject.SetActive(false);
            

        }
        if (other.name == "chessc" && testkey == true)
        {
            audioSource.clip = take;
            audioSource.Play();
            chessc.gameObject.SetActive(false);
            chesso.gameObject.SetActive(true);
            keyf.gameObject.SetActive(true);

        }
        if (other.name == "keyf")
        {
            
            keyf.gameObject.SetActive(false);
            ftest = true;

        }
        if (other.name == "doorsc3" && ftest == true)
        {
            audioSource.clip = door;
            audioSource.Play();
            doorsc3.gameObject.SetActive(false);
            SceneManager.LoadScene("scene3");

        }


      

    }
    
}
