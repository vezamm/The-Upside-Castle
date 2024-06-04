using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightMove : MonoBehaviour, IPointerDownHandler, IPointerUpHandler

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
            Animator.SetBool("runing", true);
        }
        else Animator.SetBool("runing", false);
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
