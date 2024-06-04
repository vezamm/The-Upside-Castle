using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TUTO : MonoBehaviour
{
    public GameObject Key1;
    public GameObject Dooropen;
    public GameObject Doorclose;
    private bool havekey;
    private AudioSource audioSource;
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
    // Start is called before the first frame update
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

        if (other.name == "closedoor" && havekey == true)
        {
            audioSource.clip = take;
            audioSource.Play();
            Dooropen.gameObject.SetActive(true);
            Doorclose.gameObject.SetActive(false);
        }
        if (other.name == "opendoor")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
