using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Gravityscript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private bool fliB = false;
    public float audioVolume = 1.0f;
    private bool rotated = false;
    //private AudioSource audioSource;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        
    }
   public void ToggelGravity()
    {     
            if (  !fliB)
            {
                //audioSource.clip = jump;
                //audioSource.Play();
                RotateCharacter(true);
                rotated = true;
                spriteRenderer.flipY = true;
                fliB = true;
            }
            else if ( fliB)
            {
                RotateCharacter(false);
                rotated = false;
                spriteRenderer.flipY = false;
                fliB = false;
            }
        
    }
    void RotateCharacter(bool flipGravity)
    {
        if (flipGravity)
        {
            rb.gravityScale = -1f;
            
        }
        else
        {
            rb.gravityScale = 1f; // Reset gravity to normal
            
        }
    }
}
