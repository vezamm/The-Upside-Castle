using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public Button play;
    public Text title;
    public Button settings; // Start is called before the first frame update
    void Start()
    {
        title.text = "The upside Castle";
        play.GetComponentInChildren<Text>().text = "play";
        settings.GetComponentInChildren<Text>().text = "settings";

    }

   
}
