using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    public GameObject opengateddoor;
    public GameObject leveropen;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            other.gameObject.SetActive(false);
            opengateddoor.gameObject.SetActive(true);
            leveropen.gameObject.SetActive(true);
        }
    }

}
