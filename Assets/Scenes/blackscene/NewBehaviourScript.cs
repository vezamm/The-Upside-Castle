using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     Invoke("LoadNextScene", 2f);
    }
        void LoadNextScene()
    {
        // Load the next scene
        SceneManager.LoadScene("scene2");
    }
}
