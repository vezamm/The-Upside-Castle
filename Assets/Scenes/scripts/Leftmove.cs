using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Leftmove : MonoBehaviour,IPointerDownHandler, IPointerUpHandler
{
    public float moveSpeed = 5f;
    bool ispressed = false;
    public GameObject Player;
    public float Force;
    public Animator Animator;
    
  
    void Update()
    {
        if (ispressed)
        {
            Player.transform.Translate(Force * Time.deltaTime, 0, 0);
            Animator.SetBool("runingleft", true);
        }
        else Animator.SetBool("runingleft", false);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    { 
        ispressed = false;
    }
}

