using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    private bool isUpsideDown = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            isUpsideDown = !isUpsideDown;
            ToggleGravity();
        }
    }

    void ToggleGravity()
    {
        if (isUpsideDown)
        {
            Physics2D.gravity = new Vector2(0, -9.81f); 
        }
        else
        {
            Physics2D.gravity = new Vector2(0, 9.81f); 
            
        }
    }
}
