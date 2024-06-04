using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final : MonoBehaviour
{
    public CanvasGroup myCanvasGroup;
    private AudioSource audioSource;
    public GameObject lfhandle;
    public GameObject lhandle;
    public AudioClip opengate;
    // Start is called before the first frame update
    void Start()
    {

    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.name == "lfhandle")
        {
            audioSource.clip = opengate;
            audioSource.Play();
            lfhandle.gameObject.SetActive(false);
            lhandle.gameObject.SetActive(true);
            ShowUI();
        }
    }

    void ShowUI()
    {
        myCanvasGroup.alpha = 1;
    }
    // Update is called once per frame
}
