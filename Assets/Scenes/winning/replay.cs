using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class replay : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayButtonClicked()
    {
        SceneManager.LoadScene("Scene1");
    }
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}

