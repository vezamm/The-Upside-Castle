using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class spriteright : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public SpriteRenderer spriteRenderer;
    bool ispressed = false;


    // Start is called before the first frame update
    private void Start()
    {
        
    }
    void Update()
    {
        if (ispressed)
        {
            spriteRenderer.flipX = false;

        }
    }
    // Update is called once per frame
    public void OnPointerDown(PointerEventData eventData)
    {
        ispressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        ispressed = false;
    }
    
}
