using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour

{
    public GameObject pausemenu;
    public void pause()
    {
        //pausemenu.SetActive(true);
        Time.timeScale = 0;
    }
    public void replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;


    }
    public void resume()
    {
        pausemenu?.SetActive(false);
        Time.timeScale = 1.0f;

    }
    public void home()
    {
        SceneManager.LoadScene("main");
        Time.timeScale = 1f;

    }
}
